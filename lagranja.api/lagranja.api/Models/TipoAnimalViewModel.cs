using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace lagranja.api.Models
{
    [Table("TipoAnimal")]
    public class TipoAnimalViewModel
    {
        [Key]
        public int Idtipoanimal { get; set; }
        public string Nombre { get; set; }
        public string Peligrosidad { get; set; }
    }
}
