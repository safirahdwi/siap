using System;
using System.Collections.Generic;

namespace adminLTE.Models
{
    public partial class DaftarDokumenOrmawa
    {
        public int Id { get; set; }
        public int? PengajuanProposalKegiatanId { get; set; }
        public int? DokumenOrmawaId { get; set; }

        public virtual DokumenOrmawa DokumenOrmawa { get; set; }
        public virtual PengajuanProposalKegiatan PengajuanProposalKegiatan { get; set; }
    }
}
