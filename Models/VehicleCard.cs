using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class VehicleCard
    {
        public int VehicleCardID { get; set; }
        public String Number { get; set; }
        public String Series { get; set; }
        public DataType ExpirationData { get; set; }

        public Vehicle Vehicles { get; set; }
        public ICollection<Loss> Losses { get; set; }

    }
}
