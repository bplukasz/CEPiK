using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Loss
    {
        public int LossID { get; set; }
        public Boolean LossOfEvidence { get; set; }
        public Boolean LossOfBoard { get; set; }
        public Boolean LossOfTemporaryPermit { get; set; }
        public Boolean LossOfTemporaryBoard { get; set; }
        public Boolean LossOfVehicaleCard { get; set; }
        public Boolean RediscoveryOfTheEvidence { get; set; }
        public Boolean RediscoveryOfTheTemporaryPermit { get; set; }
        public Boolean RediscoveryOfTheTemporaryBoard { get; set; }
        public Boolean RediscoveryOfTheVehicaleCard { get; set; }
        public DataType DataOfEvent { get; set; }
        public Boolean RetentionOfEvidence { get; set; }
        public Boolean RetentionOfTheTemporaryPermit { get; set; }
        public Boolean CommitmentEvidence { get; set; }
        public Boolean CommitmentOfTheTemporaryPermit { get; set; }

        public Vehicle Vehicles { get; set; }
        public RegistrationBook RegistrationBook { get; set; }
        public VehicleCard VehicleCard { get; set; }
        public TemporaryLicense TemporaryLicense { get; set; }

    }
}
