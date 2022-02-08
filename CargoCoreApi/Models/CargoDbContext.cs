using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CargoCoreApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CargoCoreApi.Models
{
    public class CargoDbContext : DbContext
    {
        public CargoDbContext(DbContextOptions<CargoDbContext> options) : base(options)
        {

        }
        public DbSet<CargoSystem> cargoSystem { get; set; }
    }
}
