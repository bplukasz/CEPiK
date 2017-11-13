using CEPiK.Models;
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
                new Address { City="Warszawa", Commune="Gmina Warszawa", HouseNumber="11", PostalCode="21-500", Street="Znana", Voivodeship="Mazowieckie" },
                new Address { City="Warszawa", Commune="Gmina Warszawa", HouseNumber="3", PostalCode="21-500", Street="Secemińska", Voivodeship="Mazowieckie" },
                new Address { City="Warszawa", Commune="Gmina Warszawa", HouseNumber="643", PostalCode="21-500", Street="Góralska", Voivodeship="Mazowieckie" },
                new Address { City="Warszawa", Commune="Gmina Warszawa", HouseNumber="314", PostalCode="21-500", Street="Hala Wola", Voivodeship="Mazowieckie" },
            };

            foreach (Address address in addresses)
            {
                context.Addresses.Add(address);
            }
            context.SaveChanges();

            var entrepreneurs = new Entrepreneur[]
            {
                new Entrepreneur {NIP=5423642344, Name="Jan", Surname="Kowalski",  NumberInEnterpreneurRegister=2332 },
                new Entrepreneur {NIP=5423642000, Name="Adam", Surname="Kwiatkowski",  NumberInEnterpreneurRegister=23 },
                new Entrepreneur {NIP=5423642001, Name="Konrad", Surname="Chmielewski",  NumberInEnterpreneurRegister=2353 },
                new Entrepreneur {NIP=5423642002, Name="Janina", Surname="Chudzikiewicz",  NumberInEnterpreneurRegister=6423 },
                new Entrepreneur {NIP=5423642003, Name="Tomasz", Surname="Chudy",  NumberInEnterpreneurRegister=5424 },
            };

            foreach (Entrepreneur entrepreneur in entrepreneurs)
            {
                context.Entrepreneurs.Add(entrepreneur);
            }
            context.SaveChanges();

            var diagnosticians = new Diagnostician[]
            {
                new Diagnostician { Name="Ryszard", Surname="Zieliński", NumberOfPremissions=0321},
                new Diagnostician { Name="Robert", Surname="Głębocki", NumberOfPremissions=1324},
                new Diagnostician { Name="Damian", Surname="Furtak", NumberOfPremissions=3531},
                new Diagnostician { Name="Zenon", Surname="Moszczyński", NumberOfPremissions=5325},
                new Diagnostician { Name="Zbigniew", Surname="Karwacki", NumberOfPremissions=6342},
                 new Diagnostician { Name="Harry", Surname="Matejko", NumberOfPremissions=3551},
                new Diagnostician { Name="Henryk", Surname="Antonio", NumberOfPremissions=5312},
                new Diagnostician { Name="Janusz", Surname="Kacpszyk", NumberOfPremissions=6532},
            };

            foreach (Diagnostician diagnostician in diagnosticians)
            {
                context.Diagnosticians.Add(diagnostician);
            }
            context.SaveChanges();

            var services = new Service[]
            {
                new Service {Name="Identyfikacja pojazdu, w tym: sprawdzenie cech identyfikacyjnych oraz ustalenie i porównanie zgodnoÊci faktycznych danych pojazdu z danymi zapisanymi w dowodzie rejestracyjnym lub odpowiadajàcym mu dokumencie" },
                new Service {Name="Identyfikacja pojazdu: sprawdzenie prawidΠowoÊci oznaczeƒ i stanu tablic rejestracyjnych pojazdu" },
                new Service {Name="Sprawdzenie i ocenę prawidłowości działania poszczególnych zespołów i układów pojazdu, w szczególności pod względem bezpieczeństwa jazdy i ochrony środowiska, w tym sprawdzenie i ocenę: stanu technicznego ogumienia" },
                new Service {Name="Sprawdzenie i ocenę prawidłowości działania poszczególnych zespołów i układów pojazdu, w szczególności pod względem bezpieczeństwa jazdy i ochrony środowiska, w tym sprawdzenie i ocenę: stanu technicznego zawieszenia" },
                new Service {Name="Sprawdzenie i ocenę prawidłowości działania poszczególnych zespołów i układów pojazdu, w szczególności pod względem bezpieczeństwa jazdy i ochrony środowiska, w tym sprawdzenie i ocenę: instalacji elektrycznej" },
            };

            foreach (Service service in services)
            {
                context.Services.Add(service);
                context.SaveChanges();
            }

                var vehicleControlStations = new VehicleControlStation[]
                {
                new VehicleControlStation { Name="U Romana" , Address = addresses[0], Diagnosticians = {diagnosticians[0]}, Entrepreneur =entrepreneurs[0] , NIP =5423642344, Services = {services[0], services[2]}},
                new VehicleControlStation { Name="Stacja" , Address = addresses[1], Diagnosticians = {diagnosticians[5],diagnosticians[6],diagnosticians[7]}, Entrepreneur =entrepreneurs[1] , NIP =5423642000, Services = {services[1], services[3]}},
                new VehicleControlStation { Name="Kontroli" , Address = addresses[2], Diagnosticians = {diagnosticians[1] }, Entrepreneur =entrepreneurs[2] , NIP =5423642001, Services = {services[0], services[4]}},
                new VehicleControlStation {Name="Pojazdów" , Address = addresses[3], Diagnosticians = {diagnosticians[2] }, Entrepreneur =entrepreneurs[3] , NIP =5423642002, Services = {services[2], services[3]}},
                new VehicleControlStation {Name="Zapraszamy" , Address = addresses[4], Diagnosticians = {diagnosticians[4] }, Entrepreneur =entrepreneurs[4] , NIP =5423642003, Services = {services[0], services[3]}},
                };

                foreach (VehicleControlStation vehicleControlStation in vehicleControlStations)
                {
                    context.VehicleControlStations.Add(vehicleControlStation);
                }
                context.SaveChanges();
            }
        }
    }
