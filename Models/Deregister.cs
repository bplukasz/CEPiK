using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Deregister
    {
        public int DeregisterID { get; set; }
        public DataType DataDeregister { get; set; }
        public String ReasonOfDeregistration { get; set; }
        public Boolean CertificateOfDismantling { get; set; }

        public Vehicle vehicle { get; set; }

    }
}
