using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Fuel
    {
        public int FuelID { get; set; }
        public String FuelType { get; set; }
        public float AverageEmmision { get; set; }

        public Vehicle Vehicle { get; set; }

    }
}
