using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Oracle.Net.Data;
using Oracle.Net.Models;
using Oracle.Net.ViewModels;

namespace Oracle.Net.Controllers
{
    public class HomeController : Controller
    {
        private readonly OracleContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(OracleContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        public interface IFormFile
        {
            string ContentType { get; }
            string ContentDisposition { get; }
            IHeaderDictionary Headers { get; }
            long Length { get; }
            string Name { get; }
            string FileName { get; }
            Stream OpenReadStream();
            void CopyTo(Stream target);
        }

        [Authorize]
        public IActionResult Index()
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var classid = _context.User.First(item => item.PhoneNumber == phonenumber).Class;
            var newslist = _context.News.Where(item => (item.Id < 8) && (item.Class == classid));
            var testlist = _context.Testlist.Where(item => (item.Id > 0) && (item.Class == classid)).Take(3);
            var loadlist = _context.Upload.Where(item => (item.Id >0) && (item.Class == classid)).Take(4);
           
            var indexViewModel = new IndexViewModel(newslist.ToList(), testlist.ToList(), loadlist.ToList());
            return View(indexViewModel);
        }

        [Authorize]
        public IActionResult News(int? id)
        {
            var file = _context.News.Where(item => item.Id == id);
            return View(file);
        }

        [Authorize]
        public IActionResult Scenetest()
        {
            var sencelist = _context.Scenetest.Where(item => item.Id > 0);
            return View(sencelist);
        }

        [Authorize]
        public IActionResult Testonline(int? id)
        {      
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var classid = _context.User.First(item => item.PhoneNumber == phonenumber).Class;
            var testlist = _context.Testlist.Where(item => (item.Class == classid && item.Scene== id));
            return View(testlist);
        }

        [HttpPost]
        public JsonResult SaveScore(int testscore, int testid, DateTime testtime ){
            var name = User.Identity.Name;
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value; 
            var userid = _context.User.First(item => item.PhoneNumber == phonenumber).Id;
            var testname = _context.Testlist.First(item => item.Id ==testid).Testname;
            Score score = new Score()
            {
                UserId = userid,
                Testscore = testscore,
                Testid = testid,
                Testname = testname,
                Testtime = testtime,
            };

                _context.Add(score);
                _context.SaveChanges();
            
            return new JsonResult("OK");
         }

        [Authorize]
        public IActionResult Testdetail(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var list = _context.Test.Where(item => (item.Testid== id));
            if (list == null)
            {
                return NotFound();
            }
            var n = 0;
            foreach( var i in list)
            {
                n++;
            }
            ViewBag.Sum = n;
            ViewBag.Testid = id;
            string ans = "";
            string mark = "";  
            foreach(var i in list)
            {
                ans += i.Answ + ";";
                mark += i.Mark + ";";                 
            }
            if(mark.Length>0 && ans.Length > 0)
            {
                ViewBag.Mark = mark.Substring(0, mark.Length - 1);
                ViewBag.Answ = ans.Substring(0, ans.Length - 1);
            }
            else
            {
                ViewBag.Mark = 0;
                ViewBag.Answ = 0;
            }
            var x = 1;
            foreach(var item in list)
            {
                item.Id = x;
                x++;
            }
            return View(list);
        }

        [Authorize]
        public IActionResult Myscore()
        {      
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var userid = _context.User.First(item => item.PhoneNumber == phonenumber).Id;
            var myscore = _context.Score.Where(item => (item.UserId == userid));
            foreach(var i in myscore)
            {
                var testid = i.Testid;
                var scene = _context.Testlist.First(item => item.Id == testid).Scene;
                i.Scene = scene;                                                       //通过 testlist 得到每条分数记录的 scene
            } 
            return View(myscore);
        }

        [Authorize(Roles = "teacher")]
        public IActionResult Manage()
        {
            return View();
        }

        [Authorize(Roles = "teacher")]
        public IActionResult Allscore()
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var classid = _context.User.First(item => item.PhoneNumber == phonenumber).Class; //得到班号

            var alltestid = (from item in _context.Testlist
                             where (item.Class == classid)
                             select item.Id
                             ).ToList();    //得到班级里的所有测试卷号

            var allscore = _context.Score.Where(item => item.Id < 0);

            foreach (var item in alltestid)
            {
                var score = (from i in _context.Score
                             where (i.Testid == item)
                             select i
                             );
                allscore = allscore.Concat(score);  //得到本班所有测试分数
            }

            foreach (var i in allscore)
            {
                var testid = i.Testid;
                var scene = _context.Testlist.First(item => item.Id == testid).Scene;
                i.Scene = scene;                                                       //通过 testlist 得到每条分数记录的 scene

                var userid = i.UserId;
                var term = _context.User.First(item => item.Id == userid).Term;
                i.Term = term;                                                         //同理得到term
            }

            return View(allscore.OrderBy(item => item.Term));
        }


        [Authorize]
        public IActionResult Download()
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var classid = _context.User.First(item => item.PhoneNumber == phonenumber).Class;
            var files = _context.Upload.Where(item => item.Class == classid);
            return View(files);
        }

        [Authorize]
        public IActionResult Download1(int? id)
        {
            var file = _context.Upload.Where(item => item.Id == id);
            return View(file);
        }
        
        [Authorize]
        public IActionResult Qa()
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var classid = _context.User.First(item => item.PhoneNumber == phonenumber).Class; 
            var quer = _context.User.Where(item => item.Class == classid); //本班中所有提问者

            var allquestion = _context.Question.Where(item => item.Id < 0);
            var allanswer = _context.Answer.Where(item => item.Id < 0);
            foreach (var item in quer)
            {
                var question = (from i in _context.Question
                             where (i.Querid == item.Id)
                             select i
                            );
                allquestion = allquestion.Concat(question);   //本班所有同学提出的所有问题
            }

            var allquestions = allquestion.ToList();
            allquestions.Reverse();

            return View(allquestions);
        }

        public IActionResult FileSave()
        {
            var files = Request.Form.Files;
            string path = null;
            foreach (var file in files)
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                if (file.Length > 0)
                {
                    long fileSize = file.Length; //获得文件大小，以字节为单位
                    string newFileName = System.Guid.NewGuid().ToString() + ".jpg"; //随机生成新的文件名
                    var filePath = webRootPath + "/picture/" + newFileName;
                    path = "/picture/" + newFileName;
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
            }

            return new JsonResult(path);
        }

        [HttpPost]
        public JsonResult SaveQuestion(string quesname, string info, DateTime subtime,string picture)
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var querid = _context.User.First(item => item.PhoneNumber == phonenumber).Id;
            var quername = _context.User.First(item => item.PhoneNumber == phonenumber).Name;
            Question question = new Question()
            {
                Quesname = quesname,
                Info = info,
                Querid = querid,
                Quername = quername,
                Subtime = subtime,
                Picture = picture
            };

            _context.Add(question);
            _context.SaveChanges();

            return new JsonResult("OK");
        }

        [Authorize]
        public IActionResult Qadetail(int? id)
        {
            var question = _context.Question.Where(item => item.Id == id);
            var allanswer = _context.Answer.Where(item => item.Quesid == id);
          
            ViewBag.Num = allanswer.Count();
            var allcomment = _context.Comment.Where(item => item.Id < 0);
            foreach(var item in allanswer)
            {
                var comment = (from i in _context.Comment
                              where (i.Answerid == item.Id)
                              select i
                             );
                allcomment = allcomment.Concat(comment);
            }
            var questionViewModel = new QuestionViewModel(question.ToList(), allanswer.ToList(),allcomment.ToList());
            return View(questionViewModel);
        }

        [HttpPost]
        public JsonResult SaveAnswer(int quesid,string reply, DateTime replytime)
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var answid = _context.User.First(item => item.PhoneNumber == phonenumber).Id;
            var name = _context.User.First(item => item.PhoneNumber == phonenumber).Name;
            Answer answer = new Answer()
            {
                Quesid = quesid,
                Reply = reply,
                Replyerid = answid,
                Replytime = replytime,
                Replyername = name,
            };
  
            _context.Add(answer);
            _context.SaveChanges();

            return new JsonResult("OK");
        }

        [HttpPost]
        public JsonResult SaveComment(int answerid, string message)
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var senderid = _context.User.First(item => item.PhoneNumber == phonenumber).Id;
            var name = _context.User.First(item => item.PhoneNumber == phonenumber).Name;
            Comment comment = new Comment()
            {
                Answerid = answerid,
                Senderid = senderid,
                Sendername = name,
                Message = message,
            };

            _context.Add(comment);
            _context.SaveChanges();

            return new JsonResult("OK");
        }

        [Authorize]
        public IActionResult Myquestion()
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var id = _context.User.First(item => item.PhoneNumber == phonenumber).Id;

            var myquestion = (from i in _context.Question
                            where (i.Querid == id)
                            select i
                            );
            var myquestions = myquestion.ToList();
            myquestions.Reverse();
            return View(myquestions);
        }

        [Authorize(Roles = "teacher")]
        public IActionResult Mystudent()
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var classid = _context.User.First(item => item.PhoneNumber == phonenumber).Class;
            var allstudent = _context.User.Where(item => item.Class == classid && item.Role == "student");
            return View(allstudent.OrderBy(item => item.Term));
        }

        [Authorize]
        public IActionResult Teaching()
        {
            return View();
        }

        [Authorize]
        public IActionResult Scene1()
        {
            return View();
        }

        [Authorize]
        public IActionResult Scene2()
        {
            return View();
        }

        [Authorize]
        public IActionResult Scene3()
        {
            return View();
        }

        [Authorize]
        public IActionResult Scene4()
        {
            return View();
        }

        [Authorize]
        public IActionResult Scene5()
        {
            return View();
        }

        [Authorize]
        public IActionResult Scene6()
        {
            return View();
        }

        [Authorize]
        public IActionResult Scene7()
        {
            return View();
        }

        [Authorize]
        public IActionResult Scene8()
        {
            return View();
        }

        [Authorize]
        public IActionResult About()
        {
            return View();
        }


        [Authorize]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
    }
}
