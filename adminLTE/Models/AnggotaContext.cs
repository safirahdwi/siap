using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adminLTE.Models
{
    public class AnggotaContext : DbContext
    {
        public AnggotaContext(DbContextOptions<AnggotaContext> options) : base(options)
        {
        }

        public DbSet<Anggota> Anggotas { get; set; }
    }
}