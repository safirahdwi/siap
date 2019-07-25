﻿using System;
using System.Collections.Generic;

namespace adminLTE.Models
{
    public partial class Mahasiswa
    {
        public Mahasiswa()
        {
            AnggotaOrmawa = new HashSet<AnggotaOrmawa>();
        }

        public int Id { get; set; }
        public int? OrangId { get; set; }
        public int? StrataId { get; set; }
        public string Nimkey { get; set; }

        public virtual Orang Orang { get; set; }
        public virtual MahasiswaDiploma MahasiswaDiploma { get; set; }
        public virtual MahasiswaDoktor MahasiswaDoktor { get; set; }
        public virtual MahasiswaMagister MahasiswaMagister { get; set; }
        public virtual MahasiswaSarjana MahasiswaSarjana { get; set; }
        public virtual ICollection<AnggotaOrmawa> AnggotaOrmawa { get; set; }
    }
}
