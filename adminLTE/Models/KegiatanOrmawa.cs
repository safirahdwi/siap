using System;
using System.Collections.Generic;

namespace adminLTE.Models
{
    public partial class KegiatanOrmawa
    {
        public KegiatanOrmawa()
        {
            KalenderKegiatanOrmawa = new HashSet<KalenderKegiatanOrmawa>();
        }

        public int Id { get; set; }
        public int? PengajuanProposalKegiatanId { get; set; }
        public int? OrganisasiOrmawaId { get; set; }
        public bool? StatusKegiatan { get; set; }

        public virtual OrganisasiOrmawa OrganisasiOrmawa { get; set; }
        public virtual PengajuanProposalKegiatan PengajuanProposalKegiatan { get; set; }
        public virtual ICollection<KalenderKegiatanOrmawa> KalenderKegiatanOrmawa { get; set; }
        public object JenisKegiatanOrmawaID { get; internal set; }
    }
}
