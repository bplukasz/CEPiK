using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class TidalWithdrawal
    {
        public int TidalWithdrawalID { get; set; }
        public DateTime DateWithdrawal { get; set; }
        public DateTime DataRestore { get; set; }

        public Vehicle Vehicles { get; set; }

    }
}
