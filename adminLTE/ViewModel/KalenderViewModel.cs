using adminLTE.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adminLTE.ViewModel
{
    public class KalenderViewModel
    {
        public int Id { get; set; }
        public int? KegiatanOrmawaId { get; set; }
        public DateTime? Tmt { get; set; }
        public DateTime? Tst { get; set; }

        public virtual KegiatanOrmawa KegiatanOrmawa { get; set; }
    }
}
