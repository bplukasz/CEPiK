using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CEPiK.Models
{
    public class TechnicalResearch
    {
        public int TechnicalResearchID { get; set; }
        public DataType Data { get; set; }
        public float Mileage { get; set; }
        public Boolean Demaged { get; set; }
        public String Details { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }

    }
}
