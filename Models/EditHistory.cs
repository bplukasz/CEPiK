using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class EditHistory
    {
        public int EditorID { get; set; }
        public Editor Editor { get; set; }

        public int VehicleID { get; set; }
        public Vehicle vehicle { get; set; }

    }
}
