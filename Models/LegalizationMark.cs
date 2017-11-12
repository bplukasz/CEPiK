﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class LegalizationMark
    {
        public int LegalizationMarksID { get; set; }
        public String Series { get; set; }
        public String Number { get; set; }
        public DataType DataOfIssue { get; set; }
        public Vehicle Vehicles { get; set; }

    }
}
