using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CEPiK.Models;

namespace CEPiK.Data
{
    public static class DbInitializer
    {
        public static void Initialize(CepikContext context)
        {
            context.Database.EnsureCreated();

            if (context.Entrepreneurs.Any())
            {
                return;   // DB has been seeded
            }

            var addresses = new Address[]
            {
                new Address { City="Warszawa", Commune="Gmina Warszawa", HouseNumber="23", PostalCode="21-500", Street="Mazowiecka", Voivodeship="Mazowieckie" },
            };

            foreach (Address address in addresses)
            {
                context.Addresses.Add(address);
            }
            context.SaveChanges();

            var entrepreneurs = new Entrepreneur[]
            {
                new Entrepreneur {NIP=5423642344, Name="Jan", Surname="Kowalski", AddressID=1, NumberInEnterpreneurRegister=2332 },
            };
            
            foreach(Entrepreneur entrepreneur in entrepreneurs)
            {
                context.Entrepreneurs.Add(entrepreneur);
            }
            context.SaveChanges();
        }
    }
}
