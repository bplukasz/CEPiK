using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class TechnicalResearch
    {
        public int TechnicalResearchID { get; set; }
        public DateTime Data { get; set; }
        public float Mileage { get; set; }
        public Boolean Demaged { get; set; }
        public String Details { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }

    }
}
