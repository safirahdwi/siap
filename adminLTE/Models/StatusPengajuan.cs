using System;
using System.Collections.Generic;

namespace adminLTE.Models
{
    public partial class StatusPengajuan
    {
        public StatusPengajuan()
        {
            TahapanPengajuan = new HashSet<TahapanPengajuan>();
        }

        public int Id { get; set; }
        public string Nama { get; set; }

        public virtual ICollection<TahapanPengajuan> TahapanPengajuan { get; set; }
    }
}
