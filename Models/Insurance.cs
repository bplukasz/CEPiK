using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Insurance
    {
        public int InsuranceID { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Company { get; set; }
        public String Adress { get; set; }
        public String InsurenceCompany { get; set; }
        public String NameOfConfirmationDocument { get; set; }
        public String SeriesOfConfirmationDocument { get; set; }
        public DataType DataOfTheContractExecution { get; set; }
        public DataType ProtectionPeriod { get; set; }
        public DataType ExpirationData { get; set; }

        public Vehicle Vehicles { get; set; }

    }
}
