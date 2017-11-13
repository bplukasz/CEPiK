using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        [Display(Name = "Ulica")]
        public string Street { get; set; }
        [Display(Name = "Kod pocztowy")]
        public string PostalCode { get; set; }
        [Display(Name = "Numer lokalu")]
        public string HouseNumber { get; set; }
        [Display(Name = "Miasto")]
        public string City { get; set; }
        [Display(Name = "Województwo")]
        public string Voivodeship { get; set; }
        [Display(Name = "Gmina")]
        public string Commune { get; set; }
    }
}
