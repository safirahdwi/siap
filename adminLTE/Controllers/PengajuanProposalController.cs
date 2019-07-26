using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using adminLTE.BusinessModel;
using adminLTE.Models;
using adminLTE.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace adminLTE.Controllers
{
    public class PengajuanProposalController : Controller
    {
        private readonly DBINTEGRASI_MASTER_BAYUPPKU2Context _context;
        private readonly Combobox _combobox;

        public PengajuanProposalController(DBINTEGRASI_MASTER_BAYUPPKU2Context context, Combobox combobox)
        {
            _context = context;
            _combobox = combobox;
        }

        // GET: Anggota
        //public async Task<IActionResult> Daftaranggota()
        //{
        //    return View(await _context.AnggotaOrmawa.ToListAsync());
        //}
        public IActionResult Pengajuan()
        {
           PengajuanProposalViewModel vm = new PengajuanProposalViewModel();
            return View(vm);
        }

        // GET: Anggota/Create
        public IActionResult Add()
        {
            //if (id == 0)
            //    return View(new Anggota());
            //else
            //    return View(_context.AnggotaOrmawa.Find(id));
            PengajuanProposalViewModel vm = new PengajuanProposalViewModel();
            vm.ListAnggotaOrmawa = new SelectList(_combobox.AnggotaOrmawa(), "ID", "Value");
            vm.ListTipeKegiatan = new SelectList(_combobox.TipeKegiatanOrmawa(), "ID", "Value");
            vm.ListJenisKegiatan = new SelectList(_combobox.JenisKegiatanOrmawa(), "ID", "Value");
            //vm.ListPenanggungJawab = new SelectList(_combobox.(), "ID", "Value");
            return View(vm);
        }

        // POST: Anggota/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult AddOrEdit(PengajuanProposalKegiatan vm)
        {
            if (ModelState.IsValid)
            {
                //if (anggota.AnggotaID == 0)
                //    _context.Add(anggota);
                //else
                //    _context.Update(anggota);
                //await _context.SaveChangesAsync();
                PengajuanProposalKegiatan pengajuan = new PengajuanProposalKegiatan();
                pengajuan.AnggotaOrmawaId = vm.AnggotaOrmawaId;
                pengajuan.Kegiatan = vm.Kegiatan;
                pengajuan.TipeKegiatanOrmawa = vm.TipeKegiatanOrmawa;
                pengajuan.JenisKegiatanOrmawa = vm.JenisKegiatanOrmawa;
                pengajuan.DanaAnggaran = vm.DanaAnggaran;
                pengajuan.PenanggungJawabId = vm.PenanggungJawabId;
                pengajuan.ApprovedBy = vm.ApprovedBy;
                pengajuan.TimeApproved = vm.TimeApproved;
                _context.PengajuanProposalKegiatan.Add(pengajuan);
                _context.SaveChanges();
                //return RedirectToAction(nameof(Daftaranggota));
                return RedirectToAction("Pengajuan", "PengajuanProposal");
            }
            return RedirectToAction("Pengajuan", "PengajuanProposal");
        }

        // GET: Anggota/Delete/5
       /* public async Task<IActionResult> Delete(int? id)
        {
            var anggota = await _context.AnggotaOrmawa.FindAsync(id);
            _context.AnggotaOrmawa.Remove(anggota);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Daftaranggota));
        }*/

    }
}