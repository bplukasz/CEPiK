
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CEPiK.Models
{
    public class VehicleCard
    {
        public int VehicleCardID { get; set; }


        [RegularExpression(@"^[A-Z]{2}\\[A-Z]{3}[ ][0-9]{7}", ErrorMessage = "Wymagany format seri XX\\XXX XXXXXXX")]
        [Display(Name = "Seria i numer karty")]
        [Remote("ValidateNumberAndSerial", "VehicleCards", ErrorMessage = "Podana karta już istnieje w systemie")]
        public String SeriesAndNumber { get; set; }

        [Required(ErrorMessage = "Nie podano daty !")]
        [DataType(DataType.Date)]
        [Display(Name = "Data wydania")]
        public DateTime ExpirationData { get; set; }

        [RegularExpression(@"^[A-HJ-NPR-Z0-9]{14}", ErrorMessage = "Wymagany format  14 znaków")]
        [Display(Name = "Numer vin samochodu")]
        [Remote("ValidateVIN", "VehicleCards", ErrorMessage = "Brak samochodu o takim numerze VIN")]
        public String VIN { get; set; }

        public int VehicleID { get; set; }

        [ForeignKey("VehicleID")]
        public Vehicle Vehicles { get; set; }
        public ICollection<Loss> Losses { get; set; }

    }
}
