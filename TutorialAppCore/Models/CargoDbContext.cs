using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TutorialAppCore.Models
{
    public class CargoDbContext:DbContext
    {
        public CargoDbContext(DbContextOptions<CargoDbContext> options) : base(options)
        {

        }
        public DbSet<CargoSystem> cargosystem { get; set; }
        //public DbSet<productLs> ProductLs { get; set; }
    }
    
}
