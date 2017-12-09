using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Owner
    {
        [Key]
        public String PESEL { get; set; }
        public String REGON { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String CompanyName { get; set; }
        public String Adress { get; set; }

        public ICollection<Vehicle> Vehicles { get; set; }

    }
}
