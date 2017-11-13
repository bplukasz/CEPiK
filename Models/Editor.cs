using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Editor
    {
        public String PESEL { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public DataType EditData { get; set; }

        public ICollection<EditHistory> EditHistory { get; set; }

    }
}
