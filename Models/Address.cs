using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string HouseNumber { get; set; }
        public string City { get; set; }
        public string Voivodeship { get; set; }
        public string Commune { get; set; }
    }
}
