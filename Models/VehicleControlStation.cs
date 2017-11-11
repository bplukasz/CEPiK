using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class VehicleControlStation
    {
        public int VehicleControlStationID { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }
        public int AddressID { get; set; }

        public Address address { get; set; }
    }
}
