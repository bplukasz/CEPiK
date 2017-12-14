﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Editor
    {
        [Key]
        public String PESEL { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DateTime EditData { get; set; }

        public ICollection<EditHistory> EditHistory { get; set; }

    }
}
