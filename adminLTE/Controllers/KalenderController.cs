using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adminLTE.Models;
using adminLTE.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace adminLTE.Controllers
{
    public class KalenderController : Controller
    {
        private readonly DBINTEGRASI_MASTER_BAYUPPKU2Context _context;

        public KalenderController(DBINTEGRASI_MASTER_BAYUPPKU2Context context)
        {
            _context = context;
        }
        public IActionResult KalenderKegiatan()
        {
            KalenderViewModel vm = new KalenderViewModel();
            return View(vm);
        }
    }
}

