using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace adminLTE.Models
{
    public class AkunPenggunaContext : DbContext
    {
        public AkunPenggunaContext(DbContextOptions<AkunPenggunaContext> options) : base(options)
        {

        }
        public DbSet<AkunPengguna> Akunpengguna { get; set; }
    }
}