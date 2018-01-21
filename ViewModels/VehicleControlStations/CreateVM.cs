using CEPiK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.ViewModels.VehicleControlStations
{
    public class CreateVM
    {
        public VehicleControlStation VehicleControlStation { get; set; }
        public Entrepreneur Entrepreneur { get; set; }
        public Address Address { get; set; }
        public Address EntrepreneurAddres { get; set; }
        public List<Diagnostician> Diagnosticians { get; set; }
        public List<Service> Services { get; set; }
    }
}
