using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class RegistrationBook
    {
        public int RegistrationBookID { get; set; }
        public String Number { get; set; }
        public String Series { get; set; }
        public DateTime ExpirationData { get; set; }
        public Boolean TidalPermission { get; set; }
        public DateTime ReleaseData { get; set; }

        public Vehicle Vehicles { get; set; }
        public ICollection<Loss> Losses { get; set; }
    }
}
