using CEPiK.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Data
{
    public class CepikContext : DbContext
    {
        public CepikContext(DbContextOptions<CepikContext> options) : base(options)
        {
        }


        public DbSet<Entrepreneur> Entrepreneurs { get; set; }
        public DbSet<VehicleControlStation> VehicleControlStations { get; set; }
        public DbSet<Diagnostician> Diagnosticians { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
