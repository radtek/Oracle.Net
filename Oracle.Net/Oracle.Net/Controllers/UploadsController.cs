using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.EntityFrameworkCore;
using Oracle.Net.Data;
using Oracle.Net.Models;

namespace Oracle.Net.Controllers
{
    public class UploadsController : Controller
    {
        private readonly OracleContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        public UploadsController(OracleContext context,IHostingEnvironment hostingEnvironment)
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

        public void FileSave()
        {
            var files = Request.Form.Files;
            foreach (var file in files)
            {
                string path = null;
                string webRootPath = _hostingEnvironment.WebRootPath;
                if (file.Length > 0)
                {
                    string fileExt = Path.GetExtension(file.FileName); //文件扩展名
                    long fileSize = file.Length; //获得文件大小，以字节为单位
                    string newFileName = System.Guid.NewGuid().ToString() + fileExt; //随机生成新的文件名
                    var filePath = webRootPath + "/upload/" + newFileName;
                    path = filePath;
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
            }
        }

        public IActionResult DownLoad(string file)
        {
            var addrUrl = file;
            var stream = System.IO.File.OpenRead(addrUrl);
            string fileExt = Path.GetExtension(file);
            //获取文件的ContentType
            var provider = new FileExtensionContentTypeProvider();
            var memi = provider.Mappings[fileExt];
            return File(stream, memi, Path.GetFileName(addrUrl));

        }

        // GET: Uploads
        [Authorize(Roles = "teacher")]
        public IActionResult Index()
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var classid = _context.User.First(item => item.PhoneNumber == phonenumber).Class;
            return View(_context.Upload.Where(item => (item.Class == classid)));
        }


        // GET: Uploads/Create
        [Authorize(Roles = "teacher")]
        public IActionResult Create()
        {
            var phonenumber = @User.Claims.SingleOrDefault(s => s.Type == System.Security.Claims.ClaimTypes.MobilePhone).Value;
            var classid = _context.User.First(item => item.PhoneNumber == phonenumber).Class;
            ViewBag.Class = classid;
            return View();
        }

        // POST: Uploads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "teacher")]
        public async Task<IActionResult> Create([Bind("Id,Name,Info,Path,Size,Class")] Upload upload)
        {
            string path = null;
            var files = Request.Form.Files;
            foreach (var file in files)
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                if (file.Length > 0)
                {
                    string fileExt = Path.GetExtension(file.FileName); //文件扩展名
                    long fileSize = file.Length; //获得文件大小，以字节为单位
                    string newFileName = System.Guid.NewGuid().ToString() + fileExt; //随机生成新的文件名
                    var filePath = webRootPath + "/upload/" + newFileName;
                    path = filePath;
                    
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }
            }
            upload.Path = path;
            FileInfo f = new FileInfo(path);
            double size = f.Length / 1024;
            Math.Round(size, 2);
            upload.Size = size.ToString()+"KB";

            if (ModelState.IsValid)
            {
                _context.Add(upload);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(upload);
        }

        // GET: Uploads/Edit/5
        [Authorize(Roles = "teacher")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upload = await _context.Upload.FindAsync(id);
            if (upload == null)
            {
                return NotFound();
            }
            return View(upload);
        }

        // POST: Uploads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "teacher")]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Info,Path,Size,Class")] Upload upload)
        {
            if (id != upload.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(upload);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UploadExists(upload.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(upload);
        }

        // GET: Uploads/Delete/5
        [Authorize(Roles = "teacher")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var upload = await _context.Upload
                .FirstOrDefaultAsync(m => m.Id == id);
            if (upload == null)
            {
                return NotFound();
            }

            return View(upload);
        }

        // POST: Uploads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "teacher")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var upload = await _context.Upload.FindAsync(id);
            _context.Upload.Remove(upload);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UploadExists(int id)
        {
            return _context.Upload.Any(e => e.Id == id);
        }
    }
}
