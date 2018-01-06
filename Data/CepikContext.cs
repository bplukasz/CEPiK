using CEPiK.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK
{
    public class CepikContext : DbContext
    {
        public CepikContext(DbContextOptions<CepikContext> options) : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Carjacking> Carjackings { get; set; }
        public DbSet<Deregister> Deregisters { get; set; }
        public DbSet<EditHistory> EditHistory { get; set; }
        public DbSet<RegistrationBook> RegistrationBooks { get; set; }
        public DbSet<TemporaryLicense> TemporaryLicenses { get; set; }
        public DbSet<Editor> Editors { get; set; }
        public DbSet<Fuel> Fuels { get; set; }
        public DbSet<TechnicalResearch> TechnicalResearchs { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<TidalWithdrawal> TidalWithdrawals { get; set; }
        public DbSet<LegalizationMark> LegalizationMarks { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<VehicleCard> VehicleCards { get; set; }
        public DbSet<Loss> Loses { get; set; }
        public DbSet<TemporaryStickers> TemporaryStickers { get; set; }
        public DbSet<RegistrationHistory> RegistrationHistory { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbContextOptions<CepikContext> Options { get; }

        public DbSet<Entrepreneur> Entrepreneurs { get; set; }
        public DbSet<VehicleControlStation> VehicleControlStations { get; set; }
        public DbSet<Diagnostician> Diagnosticians { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> User { get; set; }

    }
}
