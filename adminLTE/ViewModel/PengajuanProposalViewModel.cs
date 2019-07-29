using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adminLTE.ViewModel
{
    public class PengajuanProposalViewModel
    {
        public int Id { get; set; }
        public int? AnggotaOrmawaId { get; set; }
        public string Kegiatan { get; set; }
        public int? TipeKegiatanOrmawaId { get; set; }
        public int? JenisKegiatanOrmawaId { get; set; }
        public long? DanaAnggaran { get; set; }
        public int? PenanggungJawabId { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? TimeApproved { get; set; }


        public IEnumerable<SelectListItem> ListAnggotaOrmawa { get; set; }
        public IEnumerable<SelectListItem> ListTipeKegiatan { get; set; }
        public IEnumerable<SelectListItem> ListJenisKegiatan { get; set; }
        //public IEnumerable<SelectListItem> ListPenanggungJawab { get; set; }
    }
}
