using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lagranja.api.Models
{
    [Table("Animal")]
    public class AnimalViewModel
    {
        [Key]
        public int Idanimal { get; set; }
        public int Idtipoanimal { get; set; }
        public int idcorral { get; set; }
        public DateTime fechanacimiento { get; set; }
    }
}
