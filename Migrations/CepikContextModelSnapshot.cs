﻿// <auto-generated />
using CEPiK;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CEPiK.Migrations
{
    [DbContext(typeof(CepikContext))]
    partial class CepikContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CEPiK.Models.Address", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Commune");

                    b.Property<string>("HouseNumber");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Street");

                    b.Property<string>("Voivodeship");

                    b.HasKey("AddressID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("CEPiK.Models.Car", b =>
                {
                    b.Property<int>("CarID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CarBrand");

                    b.Property<string>("Category");

                    b.Property<string>("Model");

                    b.Property<string>("Type");

                    b.Property<string>("Variant");

                    b.Property<string>("Version");

                    b.HasKey("CarID");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("CEPiK.Models.Carjacking", b =>
                {
                    b.Property<int>("CarjackingID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateofEvent");

                    b.Property<bool>("RediscoveryVehicle");

                    b.Property<bool>("VehicalTheft");

                    b.Property<int?>("VehicleID");

                    b.HasKey("CarjackingID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Carjackings");
                });

            modelBuilder.Entity("CEPiK.Models.CepikContext", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("CEPiK.Models.Deregister", b =>
                {
                    b.Property<int>("DeregisterID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CertificateOfDismantling");

                    b.Property<DateTime>("DataDeregister");

                    b.Property<string>("ReasonOfDeregistration")
                        .IsRequired();

                    b.Property<int?>("VehicleID");

                    b.Property<string>("Vin");

                    b.HasKey("DeregisterID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Deregisters");
                });

            modelBuilder.Entity("CEPiK.Models.Diagnostician", b =>
                {
                    b.Property<int>("DiagnosticianID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("NumberOfPremissions");

                    b.Property<string>("Surname");

                    b.Property<int?>("VehicleControlStationID");

                    b.HasKey("DiagnosticianID");

                    b.HasIndex("VehicleControlStationID");

                    b.ToTable("Diagnosticians");
                });

            modelBuilder.Entity("CEPiK.Models.EditHistory", b =>
                {
                    b.Property<int>("EditHistoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EditorPESEL");

                    b.Property<int>("PESEL");

                    b.Property<int>("VehicleID");

                    b.HasKey("EditHistoryID");

                    b.HasIndex("EditorPESEL");

                    b.HasIndex("VehicleID");

                    b.ToTable("EditHistory");
                });

            modelBuilder.Entity("CEPiK.Models.Editor", b =>
                {
                    b.Property<string>("PESEL")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EditData");

                    b.Property<string>("Name");

                    b.Property<string>("Surname");

                    b.HasKey("PESEL");

                    b.ToTable("Editors");
                });

            modelBuilder.Entity("CEPiK.Models.Entrepreneur", b =>
                {
                    b.Property<long>("NIP");

                    b.Property<int>("AddressID");

                    b.Property<string>("Name");

                    b.Property<int>("NumberInEnterpreneurRegister");

                    b.Property<string>("Surname");

                    b.HasKey("NIP");

                    b.ToTable("Entrepreneurs");
                });

            modelBuilder.Entity("CEPiK.Models.Fuel", b =>
                {
                    b.Property<int>("FuelID")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("AverageEmmision");

                    b.Property<string>("FuelType");

                    b.Property<int?>("VehicleID");

                    b.HasKey("FuelID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Fuels");
                });

            modelBuilder.Entity("CEPiK.Models.Insurance", b =>
                {
                    b.Property<int>("InsuranceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("Company");

                    b.Property<DateTime>("DataOfTheContractExecution");

                    b.Property<DateTime>("ExpirationData");

                    b.Property<string>("InsurenceCompany");

                    b.Property<string>("Name");

                    b.Property<string>("NameOfConfirmationDocument");

                    b.Property<DateTime>("ProtectionPeriod");

                    b.Property<string>("SeriesOfConfirmationDocument");

                    b.Property<string>("Surname");

                    b.Property<int?>("VehiclesVehicleID");

                    b.HasKey("InsuranceID");

                    b.HasIndex("VehiclesVehicleID");

                    b.ToTable("Insurances");
                });

            modelBuilder.Entity("CEPiK.Models.LegalizationMark", b =>
                {
                    b.Property<int>("LegalizationMarkID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataOfIssue");

                    b.Property<string>("Number");

                    b.Property<string>("Series");

                    b.Property<int?>("VehiclesVehicleID");

                    b.HasKey("LegalizationMarkID");

                    b.HasIndex("VehiclesVehicleID");

                    b.ToTable("LegalizationMarks");
                });

            modelBuilder.Entity("CEPiK.Models.Loss", b =>
                {
                    b.Property<int>("LossID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CommitmentEvidence");

                    b.Property<bool>("CommitmentOfTheTemporaryPermit");

                    b.Property<DateTime>("DataOfEvent");

                    b.Property<bool>("LossOfBoard");

                    b.Property<bool>("LossOfEvidence");

                    b.Property<bool>("LossOfTemporaryBoard");

                    b.Property<bool>("LossOfTemporaryPermit");

                    b.Property<bool>("LossOfVehicaleCard");

                    b.Property<bool>("RediscoveryOfTheEvidence");

                    b.Property<bool>("RediscoveryOfTheTemporaryBoard");

                    b.Property<bool>("RediscoveryOfTheTemporaryPermit");

                    b.Property<bool>("RediscoveryOfTheVehicaleCard");

                    b.Property<int?>("RegistrationBookID");

                    b.Property<bool>("RetentionOfEvidence");

                    b.Property<bool>("RetentionOfTheTemporaryPermit");

                    b.Property<int?>("TemporaryLicenseID");

                    b.Property<int?>("VehicleCardID");

                    b.Property<int?>("VehiclesVehicleID");

                    b.HasKey("LossID");

                    b.HasIndex("RegistrationBookID");

                    b.HasIndex("TemporaryLicenseID");

                    b.HasIndex("VehicleCardID");

                    b.HasIndex("VehiclesVehicleID");

                    b.ToTable("Loses");
                });

            modelBuilder.Entity("CEPiK.Models.Owner", b =>
                {
                    b.Property<string>("PESEL")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("CompanyName");

                    b.Property<string>("Name");

                    b.Property<string>("REGON");

                    b.Property<string>("Surname");

                    b.HasKey("PESEL");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("CEPiK.Models.RegistrationBook", b =>
                {
                    b.Property<int>("RegistrationBookID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpirationData");

                    b.Property<string>("Number");

                    b.Property<DateTime>("ReleaseData");

                    b.Property<string>("Series");

                    b.Property<bool>("TidalPermission");

                    b.HasKey("RegistrationBookID");

                    b.ToTable("RegistrationBooks");
                });

            modelBuilder.Entity("CEPiK.Models.RegistrationHistory", b =>
                {
                    b.Property<int>("RegistrationHistoryID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OrganMakingPreviousRegistrationNumber");

                    b.Property<string>("PreviousRegistrationNumber");

                    b.Property<int?>("VehicleID");

                    b.HasKey("RegistrationHistoryID");

                    b.HasIndex("VehicleID");

                    b.ToTable("RegistrationHistory");
                });

            modelBuilder.Entity("CEPiK.Models.Service", b =>
                {
                    b.Property<int>("ServiceID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int?>("VehicleControlStationID");

                    b.HasKey("ServiceID");

                    b.HasIndex("VehicleControlStationID");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("CEPiK.Models.TechnicalResearch", b =>
                {
                    b.Property<int>("TechnicalResearchID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<bool>("Demaged");

                    b.Property<string>("Details");

                    b.Property<float>("Mileage");

                    b.HasKey("TechnicalResearchID");

                    b.ToTable("TechnicalResearchs");
                });

            modelBuilder.Entity("CEPiK.Models.TemporaryLicense", b =>
                {
                    b.Property<int>("TemporaryLicenseID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataOFRenevalAndValidity");

                    b.Property<DateTime>("ExpirationData");

                    b.Property<string>("Number");

                    b.Property<string>("PurposeOfRelease");

                    b.Property<DateTime>("ReleaseData");

                    b.Property<string>("Series");

                    b.Property<int?>("VehicleID");

                    b.HasKey("TemporaryLicenseID");

                    b.HasIndex("VehicleID");

                    b.ToTable("TemporaryLicenses");
                });

            modelBuilder.Entity("CEPiK.Models.TemporaryStickers", b =>
                {
                    b.Property<int>("TemporaryStickersID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ReleaseOfTheControlSticker");

                    b.Property<DateTime>("ReleaseOfTheTemporaryBoardSticker");

                    b.Property<int?>("VehicleID");

                    b.HasKey("TemporaryStickersID");

                    b.HasIndex("VehicleID");

                    b.ToTable("TemporaryStickers");
                });

            modelBuilder.Entity("CEPiK.Models.TidalWithdrawal", b =>
                {
                    b.Property<int>("TidalWithdrawalID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DataRestore");

                    b.Property<DateTime>("DateWithdrawal");

                    b.Property<int?>("VehiclesVehicleID");

                    b.HasKey("TidalWithdrawalID");

                    b.HasIndex("VehiclesVehicleID");

                    b.ToTable("TidalWithdrawals");
                });

            modelBuilder.Entity("CEPiK.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Allocation");

                    b.Property<float?>("AllowedPackage");

                    b.Property<string>("AutomobileMaker");

                    b.Property<float?>("AverageFuelConsumption");

                    b.Property<int?>("AxleNumber");

                    b.Property<string>("BodyNumber");

                    b.Property<int?>("CarID");

                    b.Property<DateTime?>("DataOfTheBodyNumber");

                    b.Property<float?>("DeadweightLoad");

                    b.Property<string>("Destination");

                    b.Property<bool?>("ECTypeApproval");

                    b.Property<float?>("EnginePower");

                    b.Property<float?>("EngineSize");

                    b.Property<string>("Equipment");

                    b.Property<DateTime?>("FirstRegistrationAbroad");

                    b.Property<float?>("GrossVehicleWeightRating");

                    b.Property<DateTime?>("InitialRegistration");

                    b.Property<DateTime?>("ManufactureYear");

                    b.Property<float?>("MaximumTotalWeight");

                    b.Property<float?>("MaximumTowedMassOfTheTrailer");

                    b.Property<string>("PESEL");

                    b.Property<float?>("PermissibleAxleLoad");

                    b.Property<string>("RadarDevice");

                    b.Property<string>("RegistrationAuthority");

                    b.Property<int?>("RegistrationBookID");

                    b.Property<string>("RegistrationNumber");

                    b.Property<string>("Subgenus");

                    b.Property<string>("SuspensionType");

                    b.Property<int?>("TechnicalResearchID");

                    b.Property<string>("Type");

                    b.Property<string>("TypeApprovalCertificate");

                    b.Property<string>("VIN");

                    b.Property<int?>("VehicleCardID");

                    b.Property<bool?>("WeatherDependent");

                    b.Property<float?>("Wheelbase");

                    b.Property<float?>("WheelbaseAVG");

                    b.Property<float?>("WheelbaseMAX");

                    b.Property<float?>("WheelbaseMIN");

                    b.HasKey("VehicleID");

                    b.HasIndex("CarID");

                    b.HasIndex("PESEL");

                    b.HasIndex("RegistrationBookID")
                        .IsUnique()
                        .HasFilter("[RegistrationBookID] IS NOT NULL");

                    b.HasIndex("TechnicalResearchID");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("CEPiK.Models.VehicleCard", b =>
                {
                    b.Property<int>("VehicleCardID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ExpirationData");

                    b.Property<string>("SeriesAndNumber");

                    b.Property<string>("VIN");

                    b.Property<int>("VehicleID");

                    b.HasKey("VehicleCardID");

                    b.HasIndex("VehicleID")
                        .IsUnique();

                    b.ToTable("VehicleCards");
                });

            modelBuilder.Entity("CEPiK.Models.VehicleControlStation", b =>
                {
                    b.Property<int>("VehicleControlStationID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressID");

                    b.Property<long>("NIP");

                    b.Property<string>("Name");

                    b.HasKey("VehicleControlStationID");

                    b.HasIndex("AddressID");

                    b.HasIndex("NIP");

                    b.ToTable("VehicleControlStations");
                });

            modelBuilder.Entity("CEPiK.Models.Carjacking", b =>
                {
                    b.HasOne("CEPiK.Models.Vehicle", "vehicle")
                        .WithMany("Carjackings")
                        .HasForeignKey("VehicleID");
                });

            modelBuilder.Entity("CEPiK.Models.Deregister", b =>
                {
                    b.HasOne("CEPiK.Models.Vehicle", "vehicle")
                        .WithMany("Deregisters")
                        .HasForeignKey("VehicleID");
                });

            modelBuilder.Entity("CEPiK.Models.Diagnostician", b =>
                {
                    b.HasOne("CEPiK.Models.VehicleControlStation")
                        .WithMany("Diagnosticians")
                        .HasForeignKey("VehicleControlStationID");
                });

            modelBuilder.Entity("CEPiK.Models.EditHistory", b =>
                {
                    b.HasOne("CEPiK.Models.Editor", "Editor")
                        .WithMany("EditHistory")
                        .HasForeignKey("EditorPESEL");

                    b.HasOne("CEPiK.Models.Vehicle", "vehicle")
                        .WithMany("EditHistory")
                        .HasForeignKey("VehicleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CEPiK.Models.Fuel", b =>
                {
                    b.HasOne("CEPiK.Models.Vehicle", "Vehicle")
                        .WithMany("Fuels")
                        .HasForeignKey("VehicleID");
                });

            modelBuilder.Entity("CEPiK.Models.Insurance", b =>
                {
                    b.HasOne("CEPiK.Models.Vehicle", "Vehicles")
                        .WithMany("Insurances")
                        .HasForeignKey("VehiclesVehicleID");
                });

            modelBuilder.Entity("CEPiK.Models.LegalizationMark", b =>
                {
                    b.HasOne("CEPiK.Models.Vehicle", "Vehicles")
                        .WithMany("LegalizationMarks")
                        .HasForeignKey("VehiclesVehicleID");
                });

            modelBuilder.Entity("CEPiK.Models.Loss", b =>
                {
                    b.HasOne("CEPiK.Models.RegistrationBook", "RegistrationBook")
                        .WithMany("Losses")
                        .HasForeignKey("RegistrationBookID");

                    b.HasOne("CEPiK.Models.TemporaryLicense", "TemporaryLicense")
                        .WithMany("Losses")
                        .HasForeignKey("TemporaryLicenseID");

                    b.HasOne("CEPiK.Models.VehicleCard", "VehicleCard")
                        .WithMany("Losses")
                        .HasForeignKey("VehicleCardID");

                    b.HasOne("CEPiK.Models.Vehicle", "Vehicles")
                        .WithMany("Losses")
                        .HasForeignKey("VehiclesVehicleID");
                });

            modelBuilder.Entity("CEPiK.Models.RegistrationHistory", b =>
                {
                    b.HasOne("CEPiK.Models.Vehicle", "vehicle")
                        .WithMany("RegistrationHistory")
                        .HasForeignKey("VehicleID");
                });

            modelBuilder.Entity("CEPiK.Models.Service", b =>
                {
                    b.HasOne("CEPiK.Models.VehicleControlStation")
                        .WithMany("Services")
                        .HasForeignKey("VehicleControlStationID");
                });

            modelBuilder.Entity("CEPiK.Models.TemporaryLicense", b =>
                {
                    b.HasOne("CEPiK.Models.Vehicle", "Vehicle")
                        .WithMany("TemporaryLicenses")
                        .HasForeignKey("VehicleID");
                });

            modelBuilder.Entity("CEPiK.Models.TemporaryStickers", b =>
                {
                    b.HasOne("CEPiK.Models.Vehicle", "vehicle")
                        .WithMany("TemporaryStickers")
                        .HasForeignKey("VehicleID");
                });

            modelBuilder.Entity("CEPiK.Models.TidalWithdrawal", b =>
                {
                    b.HasOne("CEPiK.Models.Vehicle", "Vehicles")
                        .WithMany("TidalWithdrawals")
                        .HasForeignKey("VehiclesVehicleID");
                });

            modelBuilder.Entity("CEPiK.Models.Vehicle", b =>
                {
                    b.HasOne("CEPiK.Models.Car", "Car")
                        .WithMany("Vehicles")
                        .HasForeignKey("CarID");

                    b.HasOne("CEPiK.Models.Owner", "Owner")
                        .WithMany("Vehicles")
                        .HasForeignKey("PESEL");

                    b.HasOne("CEPiK.Models.RegistrationBook", "RegistrationBook")
                        .WithOne("Vehicles")
                        .HasForeignKey("CEPiK.Models.Vehicle", "RegistrationBookID");

                    b.HasOne("CEPiK.Models.TechnicalResearch", "TechnicalResearch")
                        .WithMany("Vehicles")
                        .HasForeignKey("TechnicalResearchID");
                });

            modelBuilder.Entity("CEPiK.Models.VehicleCard", b =>
                {
                    b.HasOne("CEPiK.Models.Vehicle", "Vehicles")
                        .WithOne("VehicleCard")
                        .HasForeignKey("CEPiK.Models.VehicleCard", "VehicleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CEPiK.Models.VehicleControlStation", b =>
                {
                    b.HasOne("CEPiK.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CEPiK.Models.Entrepreneur", "Entrepreneur")
                        .WithMany("VehicleControlStations")
                        .HasForeignKey("NIP")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
