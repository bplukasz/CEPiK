using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Entrepreneur
    {
        public long NIP { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int AddressID { get; set; }

        public Address address;
    }
}
