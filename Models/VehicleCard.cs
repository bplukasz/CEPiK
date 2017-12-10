
using Microsoft.AspNetCore.Mvc;
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

        
        [RegularExpression(@"^[A-Z]{2}\\[A-Z]{3}[ ][0-9]{7}", ErrorMessage = "Wymagany format seri XX\\XXX XXXXXXX")]
        [Required(ErrorMessage ="Pole jest puste !")]
        [Display(Name = "Seria i numer karty")]
        [Remote("ValidateEmployeeNo", "VehicleCards", ErrorMessage = "Podana karta już istnieje w systemie")]
        public String SeriesAndNumber { get; set; }

        [Required(ErrorMessage ="Nie podano daty !")]
        [DataType(DataType.Date)]
        [Display(Name = "Data wydania")]
        public DateTime ExpirationData { get; set; }

        public Vehicle Vehicles { get; set; }
        public ICollection<Loss> Losses { get; set; }

    }
}
