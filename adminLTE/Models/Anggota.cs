using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace adminLTE.Models
{
    public class Anggota
    {
        [Key]
        public int AnggotaID { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        public string Nama { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Nim { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Jabatan { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Divisi { get; set; }
    }
}