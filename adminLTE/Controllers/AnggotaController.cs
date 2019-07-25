using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using adminLTE.Models;
using adminLTE.ViewModel;

namespace adminLTE.Controllers
{
    public class AnggotaController : Controller
    {
        private readonly DBINTEGRASI_MASTER_BAYUPPKU2Context _context;

        public AnggotaController(DBINTEGRASI_MASTER_BAYUPPKU2Context context)
        {
            _context = context;
        }

        // GET: Anggota
        //public async Task<IActionResult> Daftaranggota()
        //{
        //    return View(await _context.AnggotaOrmawa.ToListAsync());
        //}
        public IActionResult Daftaranggota()
        {
            AnggotaOrmawaViewModel vm = new AnggotaOrmawaViewModel();
            return View(vm);
        }

        // GET: Anggota/Create
        public IActionResult AddorEdit()
        {
            //if (id == 0)
            //    return View(new Anggota());
            //else
            //    return View(_context.AnggotaOrmawa.Find(id));
            AnggotaOrmawaViewModel vm = new AnggotaOrmawaViewModel();
            return View(vm);
        }

        // POST: Anggota/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult AddOrEdit(AnggotaOrmawaViewModel vm)
        {
            if (ModelState.IsValid)
            {
                //if (anggota.AnggotaID == 0)
                //    _context.Add(anggota);
                //else
                //    _context.Update(anggota);
                //await _context.SaveChangesAsync();
                AnggotaOrmawa ormawa = new AnggotaOrmawa();
                ormawa.MahasiswaId = vm.MahasiswaId;
                ormawa.OrganisasiOrmawaId = vm.OrganisasiOrmawaId;
                ormawa.TanggalBergabung = vm.TanggalBergabung;
                _context.AnggotaOrmawa.Add(ormawa);
                _context.SaveChanges();
                //return RedirectToAction(nameof(Daftaranggota));
                return RedirectToAction("Daftaranggota", "Anggota");
            }
            return RedirectToAction("Daftaranggota","Anggota");
        }

        // GET: Anggota/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var anggota = await _context.AnggotaOrmawa.FindAsync(id);
            _context.AnggotaOrmawa.Remove(anggota);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Daftaranggota));
        }

    }
}
