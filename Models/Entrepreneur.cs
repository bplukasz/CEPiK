using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Entrepreneur
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required(ErrorMessage = "Nie podano NIP !")]
        [RegularExpression(@"^[0-9]{10}", ErrorMessage = "NIP nie zgodny z formatem (10 cyfr)")]
        public long NIP { get; set; }
        [Display(Name = "Imie przedsiębiorcy")]
        [Required(ErrorMessage ="Nie podano imienia przedsiębiorcy")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko przedsiębiorcy")]
        [Required(ErrorMessage ="Nie podano nazwiska przedsiębiorcy")]
        public string Surname { get; set; }
        public int NumberInEnterpreneurRegister { get; set; }
        public int AddressID { get; set; }

        public Address Address;
        public ICollection<VehicleControlStation> VehicleControlStations { get; set; }
    }
}
