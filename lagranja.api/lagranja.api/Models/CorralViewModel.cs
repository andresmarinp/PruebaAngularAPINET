using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lagranja.api.Models
{
    [Table("Corral")]
    public class CorralViewModel
    {
        [Key]
        public int Idcorral { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
    }
}
