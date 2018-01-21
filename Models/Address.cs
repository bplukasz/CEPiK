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
        [Required(ErrorMessage ="Nie podano ulicy")]
        public string Street { get; set; }
        [Required(ErrorMessage ="Nie podano kodu pocztowego")]
        [RegularExpression(@"^[0-9]{2}-[0-9]{3}", ErrorMessage = "Kod pocztowy nie zgodny z formatem (xx-xxx)")]
        [Display(Name = "Kod pocztowy")]
        public string PostalCode { get; set; }
        [Display(Name = "Numer lokalu")]
        [Required(ErrorMessage ="Nie podano numeru domu")]
        public string HouseNumber { get; set; }
        [Display(Name = "Miasto")]
        [Required(ErrorMessage ="Nie podano miasta")]
        public string City { get; set; }
        [Display(Name = "Województwo")]
        public string Voivodeship { get; set; }
        [Display(Name = "Gmina")]
        public string Commune { get; set; }
    }
}
