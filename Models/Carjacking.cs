using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Carjacking
    {
        public int CarjackingID { get; set; }
        public Boolean VehicalTheft { get; set; }
        public Boolean RediscoveryVehicle { get; set; }
        public DateTime DateofEvent { get; set; }

        public Vehicle vehicle { get; set; }

    }
}