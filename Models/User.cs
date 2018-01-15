using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class User
    {
        public int ID { get; set; }
        [Display(Name = "Nazwa uzytkownika")]
        [RegularExpression(@"^[A-Za-z0-9]{5,}", ErrorMessage = "Minimum 5 znakow")]
        [Remote("ValidateUserName", controller: "Home", ErrorMessage = "Nazwa użytkownik już w użyciu")]

        public string UserName { get; set; }
        [RegularExpression(@"^[A-Za-z0-9]{5,}", ErrorMessage = "Minimum 5 znakow")]
        [Required(ErrorMessage = "Wprowadź hasło")]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Wprowadź imię")]
        [Display(Name = "Imie")]
        public string Name { get; set; }
    }
}
