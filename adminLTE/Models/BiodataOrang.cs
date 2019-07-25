﻿using System;
using System.Collections.Generic;

namespace adminLTE.Models
{
    public partial class BiodataOrang
    {
        public int Id { get; set; }
        public byte AgamaId { get; set; }
        public byte? StatusKawinId { get; set; }
        public int? PekerjaanId { get; set; }
        public int? SukuBangsaId { get; set; }
        public int? WargaNegaraId { get; set; }
        public byte? GolonganDarahId { get; set; }
        public int? Tinggi { get; set; }
        public int? Berat { get; set; }
        public byte? AnakKe { get; set; }
        public byte? DariJumlahBersaudara { get; set; }
        public string PertamaMerokok { get; set; }
        public int? PengubahId { get; set; }
        public int? AsalNegaraId { get; set; }

        public virtual Orang IdNavigation { get; set; }
    }
}
