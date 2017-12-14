using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CEPiK.Models
{
    public class Vehicle
    {

        [Display(Name = "ID")]
        public int VehicleID { get; set; }
        [Display(Name = "Rodzaj")]
        public String Type { get; set; }
        [Display(Name = "Numer rejestracyjny")]
        public String RegistrationNumber { get; set; }
        [Display(Name = "Typ certyfikatu")]
        public String TypeApprovalCertificate { get; set; }
        [Display(Name = "Typ EC")]
        public Boolean ECTypeApproval { get; set; }
        [Display(Name = "VIN")]
        public String VIN { get; set; }
        [Display(Name = "Number Podwozia")]
        public String BodyNumber { get; set; }
        [Display(Name = "Rok produkcji")]
        public DataType ManufactureYear { get; set; }
        [Display(Name = "Dotychczasowy numer rejestracyjny")]
        public DataType InitialRegistration { get; set; }
        [Display(Name = "Dostosowany do pogody")]
        public Boolean WeatherDependent { get; set; }
        [Display(Name = "Punkt rejestracji")]
        public String RegistrationAuthority { get; set; }
        [Display(Name = "Data BodyNumber")]
        public DateTime DataOfTheBodyNumber { get; set; }
        [Display(Name = "Przeznaczenie")]
        public String Destination { get; set; }
        [Display(Name = "Rozmiar silnika")]
        public float EngineSize { get; set; }
        [Display(Name = "Moc silnika")]
        public float EnginePower { get; set; }
        [Display(Name = "Całkowita waga")]
        public float GrossVehicleWeightRating { get; set; }
        [Display(Name = "Dozwolony udźwig")]
        public float AllowedPackage { get; set; }
        [Display(Name = "Numer osi")]
        public int AxleNumber { get; set; }
        [Display(Name = "Obciążenie na oś")]
        public float PermissibleAxleLoad { get; set; }
        [Display(Name = "Maksymalna masa przyczepy")]
        public float MaximumTowedMassOfTheTrailer { get; set; }
        [Display(Name = "Asygnacja")]
        public int Allocation { get; set; }
        [Display(Name = "Pierwsza rejestracja za granica")]
        public DateTime FirstRegistrationAbroad { get; set; }
        [Display(Name = "Podrodzaj")]
        public String Subgenus { get; set; }
        [Display(Name = "Rodzaj zawieszenia")]
        public String SuspensionType { get; set; }
        [Display(Name = "Średnia zużycia paliwa")]
        public float AverageFuelConsumption { get; set; }
        [Display(Name = "Maksymalna łączna masa")]
        public float MaximumTotalWeight { get; set; }
        [Display(Name = "Maksymalne obciążenie")]
        public float DeadweightLoad { get; set; }
        [Display(Name = "Wyposażenie")]
        public String Equipment { get; set; }
        [Display(Name = "Urządzenie radarowe")]
        public String RadarDevice { get; set; }
        [Display(Name = "Znacznik Automobile")]
        public String AutomobileMaker { get; set; }
        [Display(Name = "Rozstaw osi")]
        public float Wheelbase { get; set; }
        [Display(Name = "Minimalny rozstaw osi")]
        public float WheelbaseMIN { get; set; }
        [Display(Name = "Średni rozstaw osi")]
        public float WheelbaseAVG { get; set; }
        [Display(Name = "Maksymalny rozstaw osi")]
        public float WheelbaseMAX { get; set; }


        public int CarID { get; set; }
        public Car Car { get; set; }

        public int TechnicalResearchID { get; set; }
        public TechnicalResearch TechnicalResearch { get; set; }

        public string PESEL { get; set; }
        public Owner Owner { get; set; }

        public int VehicleCardID { get; set; }
        public VehicleCard VehicleCard { get; set; }

        public int RegistrationBookID { get; set; }
        public RegistrationBook RegistrationBook { get; set; }

        public ICollection<Loss> Losses { get; set; }
        public ICollection<EditHistory> EditHistory { get; set; }
        public ICollection<Carjacking> Carjackings { get; set; }
        public ICollection<Deregister> Deregisters { get; set; }
        public ICollection<TemporaryStickers> TemporaryStickers { get; set; }
        public ICollection<RegistrationHistory> RegistrationHistory { get; set; }
        public ICollection<TidalWithdrawal> TidalWithdrawals { get; set; }
        public ICollection<LegalizationMark> LegalizationMarks { get; set; }
        public ICollection<Insurance> Insurances { get; set; }
        public ICollection<Fuel> Fuels { get; set; }
        public ICollection<TemporaryLicense> TemporaryLicenses { get; set; }

    }
}
