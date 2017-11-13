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
        public DataType DateWithdrawal { get; set; }
        public DataType DataRestore { get; set; }

        public Vehicle Vehicles { get; set; }

    }
}
