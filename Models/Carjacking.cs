using System;
using System.ComponentModel.DataAnnotations;

namespace CEPiK.Models
{
    public class Carjacking
    {
        public int CarjackingID { get; set; }
        public Boolean VehicalTheft { get; set; }
        public Boolean RediscoveryVehicle { get; set; }
        public DataType DateofEvent { get; set; }

        public Vehicle vehicle { get; set; }

    }
}
