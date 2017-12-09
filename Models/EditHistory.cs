using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class EditHistory
    {
        public int EditHistoryID { get; set; }
        public int PESEL { get; set; }

        public Editor Editor { get; set; }

        public int VehicleID { get; set; }
        public Vehicle vehicle { get; set; }

    }
}
