using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adminLTE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace adminLTE.Controllers
{
    public class LoginController : Controller
    {
        private AkunPenggunaContext _context;
        public LoginController(AkunPenggunaContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(AkunPengguna user)
        {
            var account = _context.Akunpengguna.Where(u => u.UserName == user.UserName && u.Password == user.Password).FirstOrDefault();
            if (account != null)
            {
                HttpContext.Session.SetString("Struktur_organisasi_id", account.Struktur_organisasi_id.ToString());
                HttpContext.Session.SetString("UserName", account.UserName);
                return RedirectToAction("Welcome");
            }
            else
            {
                ModelState.AddModelError("", "UserName or Password is Wrong.");
            }
            return View();
        }

        public IActionResult Welcome()
        {
            if (HttpContext.Session.GetString("Struktur_organisasi_id") != null)
            {
                ViewBag.Username = HttpContext.Session.GetString("UserName");
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}