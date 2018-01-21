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
        [Required(ErrorMessage = "Nie podano nazwy stacji !")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Nie podano NIP !")]
        [RegularExpression(@"^[0-9]{10}", ErrorMessage = "NIP nie zgodny z formatem (10 cyfr)")]
        public long NIP { get; set; }
        public int AddressID { get; set; }

        public Address Address { get; set; }
        [ForeignKey("NIP")]
        public Entrepreneur Entrepreneur { get; set; }

        public List<Diagnostician> Diagnosticians { get; set; }
        public List<Service> Services { get; set; }
    }
}