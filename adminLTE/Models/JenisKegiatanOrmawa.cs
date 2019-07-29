using System;
using System.Collections.Generic;

namespace adminLTE.Models
{
    public partial class JenisKegiatanOrmawa
    {
        public JenisKegiatanOrmawa()
        {
            PengajuanProposalKegiatan = new HashSet<PengajuanProposalKegiatan>();
        }

        public int Id { get; set; }
        public string Nama { get; set; }

        public virtual ICollection<PengajuanProposalKegiatan> PengajuanProposalKegiatan { get; set; }
        public object KegiatanOrmawaId { get; internal set; }
        public int KegiatanOrmawaID { get; internal set; }
    }
}
