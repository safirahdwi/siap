using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using adminLTE.Models;

namespace adminLTE.Controllers
{
    public class AnggotaController : Controller
    {
        private readonly AnggotaContext _context;

        public AnggotaController(AnggotaContext context)
        {
            _context = context;
        }

        // GET: Anggota
        public async Task<IActionResult> Daftaranggota()
        {
            return View(await _context.Anggotas.ToListAsync());
        }

        // GET: Anggota/Create
        public IActionResult AddorEdit(int id = 0)
        {
            if (id == 0)
                return View(new Anggota());
            else
                return View(_context.Anggotas.Find(id));
        }

        // POST: Anggota/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("AnggotaID,Nama,Nim,Jabatan,Divisi")] Anggota anggota)
        {
            if (ModelState.IsValid)
            {
                if (anggota.AnggotaID == 0)
                    _context.Add(anggota);
                else
                    _context.Update(anggota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Daftaranggota));
            }
            return View(anggota);
        }

        // GET: Anggota/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var anggota = await _context.Anggotas.FindAsync(id);
            _context.Anggotas.Remove(anggota);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Daftaranggota));
        }

    }
}
