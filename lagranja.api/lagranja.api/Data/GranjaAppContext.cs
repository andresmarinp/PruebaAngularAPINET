using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using lagranja.api.Models;

namespace lagranja.api.Data
{
    public class GranjaAppContext : DbContext
    {
        public GranjaAppContext(DbContextOptions<GranjaAppContext> options)
            : base(options)
        {
        }

        public DbSet<lagranja.api.Models.CorralViewModel> CorralViewModel { get; set; }

        public DbSet<lagranja.api.Models.TipoAnimalViewModel> TipoAnimalViewModel { get; set; }

        public DbSet<lagranja.api.Models.AnimalViewModel> AnimalViewModel { get; set; }
    }
}