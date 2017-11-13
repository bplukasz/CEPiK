using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class VehicleControlStation
    {
        public int VehicleControlStationID { get; set; }
        [Display(Name = "Nazwa stacji")]
        public string Name { get; set; }
        public long NIP { get; set; }
        public int AddressID { get; set; }

        public Address Address { get; set; }
        [ForeignKey("NIP")]
        public Entrepreneur Entrepreneur { get; set; }
        public ICollection<Diagnostician> Diagnosticians { get; set; }
        public ICollection<Service> Services { get; set; }
    }
}