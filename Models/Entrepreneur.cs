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
        public long NIP { get; set; }
        [Display(Name = "Imie przedsiębiorcy")]
        public string Name { get; set; }
        [Display(Name = "Nazwisko przedsiębiorcy")]
        public string Surname { get; set; }
        public int NumberInEnterpreneurRegister { get; set; }
        public int AddressID { get; set; }

        public Address Address;
        public ICollection<VehicleControlStation> VehicleControlStations { get; set; }
    }
}
