using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Deregister
    {
        public int DeregisterID { get; set; }
        [Required(ErrorMessage = "Nie podano daty !")]
        [DataType(DataType.Date)]
        [Display(Name = "Data wyrejestrowania")]
        public DateTime DataDeregister { get; set; }
        [Required(ErrorMessage = "Podaj powod wyrejestrowania !")]
        [Display(Name = "Powod wyrejestrowania")]
        public String ReasonOfDeregistration { get; set; }
        [Required(ErrorMessage = "Brak pozwolenia !")]
        [Display(Name = "Pozwolenie na wyrejestrowanie")]
        public Boolean CertificateOfDismantling { get; set; }
        [RegularExpression(@"^[A-HJ-NPR-Z0-9]{14}", ErrorMessage = "Wymagany format  14 znaków")]
        [Display(Name = "Numer vin samochodu")]
        [Remote("ValidateVIN", "VehicleCards", ErrorMessage = "Brak samochodu o takim numerze VIN")]
        public String Vin { get; set; }

        public Vehicle vehicle { get; set; }

    }
}
