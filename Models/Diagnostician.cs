using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Diagnostician
    {
        public int DiagnosticianID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int NumberOfPremissions { get; set; }
    }
}
