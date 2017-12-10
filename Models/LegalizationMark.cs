using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class LegalizationMark
    {
        public int LegalizationMarkID { get; set; }
        public String Series { get; set; }
        public String Number { get; set; }
        public DateTime DataOfIssue { get; set; }
        public Vehicle Vehicles { get; set; }

    }
}
