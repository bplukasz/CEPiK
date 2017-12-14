using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CEPiK.Models
{
    public class Car
    {
        [Display(Name = "ID")]
        public int CarID { get; set; }
        [Display(Name = "Marka")]
        public String CarBrand { get; set; }
        [Display(Name = "Kategoria")]
        public String Category { get; set; }
        [Display(Name = "Typ")]
        public String Type { get; set; }
        [Display(Name = "Model")]
        public String Model { get; set; }
        [Display(Name = "Wariant")]
        public String Variant { get; set; }
        [Display(Name = "Wersja")]
        public String Version { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }

    }
}
