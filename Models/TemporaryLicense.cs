using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class TemporaryLicense
    {
        public int TemporaryLicenseID { get; set; }
        public DateTime ExpirationData { get; set; }
        public DateTime DataOFRenevalAndValidity { get; set; }
        public String PurposeOfRelease { get; set; }
        public String Series { get; set; }
        public String Number { get; set; }
        public DateTime ReleaseData { get; set; }

        public Vehicle Vehicle { get; set; }
        public ICollection<Loss> Losses { get; set; }

    }
}
