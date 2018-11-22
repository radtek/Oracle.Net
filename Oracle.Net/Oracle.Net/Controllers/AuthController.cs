using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Oracle.Net.Data;
using Oracle.Net.Models;


namespace Oracle.Net.Controllers
{
    public class AuthController : Controller
    {
        private readonly OracleContext _context;

        public AuthController(OracleContext context)
        {
            _context = context;
        }

        // GET: Users/Create
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Id,Name,PhoneNumber,Password,Class,Term,Role")] User user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return View(user);
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(User model)
        {   
            if (model.PhoneNumber == null || model.Password == null)
            {
                const string noUserNameOrPasswordMessage = "用户名或密码为空！";
                return BadRequest(noUserNameOrPasswordMessage);
            }
            if (ModelState.IsValid)
            {
                List<User> list = (from item in _context.User
                                   where (item.Id > 0)
                                   select item
                           ).ToList();
                var user = list.SingleOrDefault(s => s.PhoneNumber == model.PhoneNumber && s.Password == model.Password);


                if (user != null)
                {
                    var claims = new List<Claim>(){
                              new Claim(ClaimTypes.Name,user.Name),new Claim(ClaimTypes.MobilePhone,user.PhoneNumber),new Claim(ClaimTypes.Role,user.Role)
                           };
                    var identity = new ClaimsIdentity(claims, "login");
                    var principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    if (principal.Identity.IsAuthenticated)
                        return RedirectToAction("Index", "Home");
                }
            }
            const string badUserNameOrPasswordMessage = "用户名或密码错误！";
            return BadRequest(badUserNameOrPasswordMessage);
        }

        public async Task<IActionResult> Logout()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return View();
        }

        public IActionResult Findpassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Findpwd(int id, string phonenumber)
        {
            var pwd = _context.User.FirstOrDefault(item => item.Id == id && item.PhoneNumber == phonenumber).Password;

            return Ok(new { password = pwd, });
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
