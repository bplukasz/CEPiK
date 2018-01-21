using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Service
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Nie podano nazwy usługi !")]
        public String Name { get; set; }
    }
}
