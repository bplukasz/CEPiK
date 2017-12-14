using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public String Type { get; set; }
        public String RegistrationNumber { get; set; }
        public String TypeApprovalCertificate { get; set; }
        public Boolean ECTypeApproval { get; set; }
        public String VIN { get; set; }
        public String BodyNumber { get; set; }
        public DateTime ManufactureYear { get; set; }
        public DateTime InitialRegistration { get; set; }
        public Boolean WeatherDependent { get; set; }
        public String RegistrationAuthority { get; set; }
        public DateTime DataOfTheBodyNumber { get; set; }
        public String Destination { get; set; }
        public float EngineSize { get; set; }
        public float EnginePower { get; set; }
        public float GrossVehicleWeightRating { get; set; }
        public float AllowedPackage { get; set; }
        public int AxleNumber { get; set; }
        public float PermissibleAxleLoad { get; set; }
        public float MaximumTowedMassOfTheTrailer { get; set; }
        public int Allocation { get; set; }
        public DateTime FirstRegistrationAbroad { get; set; }
        public String Subgenus { get; set; }
        public String SuspensionType { get; set; }
        public float AverageFuelConsumption { get; set; }
        public float MaximumTotalWeight { get; set; }
        public float DeadweightLoad { get; set; }
        public String Equipment { get; set; }
        public String RadarDevice { get; set; }
        public String AutomobileMaker { get; set; }
        public float Wheelbase { get; set; }
        public float WheelbaseMIN { get; set; }
        public float WheelbaseAVG { get; set; }
        public float WheelbaseMAX { get; set; }


        public ICollection<TemporaryLicense> TemporaryLicenses { get; set; }
        public Car Car { get; set; }
        public ICollection<Fuel> Fuels { get; set; }
        public TechnicalResearch TechnicalResearch { get; set; }
        public Owner Owner { get; set; }
        public ICollection<Carjacking> Carjackings { get; set; }
        public ICollection<Deregister> Deregisters { get; set; }
        public ICollection<TemporaryStickers> TemporaryStickers { get; set; }
        public ICollection<RegistrationHistory> RegistrationHistory { get; set; }
        public ICollection<TidalWithdrawal> TidalWithdrawals { get; set; }
        public ICollection<LegalizationMark> LegalizationMarks { get; set; }
        public ICollection<Insurance> Insurances { get; set; }
        public VehicleCard VehicleCard { get; set; }
        public ICollection<Loss> Losses { get; set; }
        public RegistrationBook RegistrationBook { get; set; }
        public ICollection<EditHistory> EditHistory { get; set; }

    }
}
