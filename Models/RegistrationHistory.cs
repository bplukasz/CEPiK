using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class RegistrationHistory
    {
        public int RegistrationHistoryID { get; set; }
        public String PreviousRegistrationNumber { get; set; }
        public String OrganMakingPreviousRegistrationNumber { get; set; }

        public Vehicle vehicle { get; set; }

}
}
