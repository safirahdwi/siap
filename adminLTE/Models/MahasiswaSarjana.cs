﻿using System;
using System.Collections.Generic;

namespace adminLTE.Models
{
    public partial class MahasiswaSarjana
    {
        public int Id { get; set; }
        public int MahasiswaId { get; set; }
        public string Nim { get; set; }
        public int MayorId { get; set; }
        public int? MinorId { get; set; }
        public int JalurMasukId { get; set; }
        public DateTime? TanggalMasuk { get; set; }
        public int? Angkatan { get; set; }
        public int? StatusAkademikId { get; set; }
        public int? BatasStudi { get; set; }
        public int? TahunAkademikId { get; set; }
        public bool? IsTpb { get; set; }
        public int? TahunAkademikTpbid { get; set; }
        public int? TahunSemesterMasukId { get; set; }

        public virtual Mahasiswa Mahasiswa { get; set; }
    }
}
