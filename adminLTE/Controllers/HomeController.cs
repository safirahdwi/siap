using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace adminLTE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Beranda()
        {
            return View();
        }
        public IActionResult Daftaranggota()
        {
            return View();
        }
        public IActionResult Publikasi()
        {
            return View();
        }
        public IActionResult KalenderKegiatan()
        {
            return View();
        }
    }
}