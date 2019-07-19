using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace adminLTE.Models
{
    public class AkunPengguna
    {
        [Key]
        public int Struktur_organisasi_id { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage = "This filed is required.")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This filed is required.")]
        public string Password { get; set; }
    }
}