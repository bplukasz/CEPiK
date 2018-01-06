using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CEPiK.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commune = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Voivodeship = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarBrand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Variant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Version = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarID);
                });

            migrationBuilder.CreateTable(
                name: "Editors",
                columns: table => new
                {
                    PESEL = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EditData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editors", x => x.PESEL);
                });

            migrationBuilder.CreateTable(
                name: "Entrepreneurs",
                columns: table => new
                {
                    NIP = table.Column<long>(type: "bigint", nullable: false),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberInEnterpreneurRegister = table.Column<int>(type: "int", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrepreneurs", x => x.NIP);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    PESEL = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REGON = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.PESEL);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationBooks",
                columns: table => new
                {
                    RegistrationBookID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExpirationData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Series = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TidalPermission = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationBooks", x => x.RegistrationBookID);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalResearchs",
                columns: table => new
                {
                    TechnicalResearchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Demaged = table.Column<bool>(type: "bit", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mileage = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalResearchs", x => x.TechnicalResearchID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleCards",
                columns: table => new
                {
                    VehicleCardID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExpirationData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeriesAndNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCards", x => x.VehicleCardID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleControlStations",
                columns: table => new
                {
                    VehicleControlStationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressID = table.Column<int>(type: "int", nullable: false),
                    NIP = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleControlStations", x => x.VehicleControlStationID);
                    table.ForeignKey(
                        name: "FK_VehicleControlStations_Addresses_AddressID",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "AddressID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VehicleControlStations_Entrepreneurs_NIP",
                        column: x => x.NIP,
                        principalTable: "Entrepreneurs",
                        principalColumn: "NIP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Allocation = table.Column<int>(type: "int", nullable: true),
                    AllowedPackage = table.Column<float>(type: "real", nullable: true),
                    AutomobileMaker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AverageFuelConsumption = table.Column<float>(type: "real", nullable: true),
                    AxleNumber = table.Column<int>(type: "int", nullable: true),
                    BodyNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CarID = table.Column<int>(type: "int", nullable: true),
                    DataOfTheBodyNumber = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeadweightLoad = table.Column<float>(type: "real", nullable: true),
                    Destination = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ECTypeApproval = table.Column<bool>(type: "bit", nullable: true),
                    EnginePower = table.Column<float>(type: "real", nullable: true),
                    EngineSize = table.Column<float>(type: "real", nullable: true),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstRegistrationAbroad = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GrossVehicleWeightRating = table.Column<float>(type: "real", nullable: true),
                    InitialRegistration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ManufactureYear = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MaximumTotalWeight = table.Column<float>(type: "real", nullable: true),
                    MaximumTowedMassOfTheTrailer = table.Column<float>(type: "real", nullable: true),
                    PESEL = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PermissibleAxleLoad = table.Column<float>(type: "real", nullable: true),
                    RadarDevice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationAuthority = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationBookID = table.Column<int>(type: "int", nullable: true),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subgenus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SuspensionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TechnicalResearchID = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeApprovalCertificate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleCardID = table.Column<int>(type: "int", nullable: true),
                    WeatherDependent = table.Column<bool>(type: "bit", nullable: true),
                    Wheelbase = table.Column<float>(type: "real", nullable: true),
                    WheelbaseAVG = table.Column<float>(type: "real", nullable: true),
                    WheelbaseMAX = table.Column<float>(type: "real", nullable: true),
                    WheelbaseMIN = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleID);
                    table.ForeignKey(
                        name: "FK_Vehicles_Cars_CarID",
                        column: x => x.CarID,
                        principalTable: "Cars",
                        principalColumn: "CarID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_Owners_PESEL",
                        column: x => x.PESEL,
                        principalTable: "Owners",
                        principalColumn: "PESEL",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_RegistrationBooks_RegistrationBookID",
                        column: x => x.RegistrationBookID,
                        principalTable: "RegistrationBooks",
                        principalColumn: "RegistrationBookID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_TechnicalResearchs_TechnicalResearchID",
                        column: x => x.TechnicalResearchID,
                        principalTable: "TechnicalResearchs",
                        principalColumn: "TechnicalResearchID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleCards_VehicleCardID",
                        column: x => x.VehicleCardID,
                        principalTable: "VehicleCards",
                        principalColumn: "VehicleCardID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Diagnosticians",
                columns: table => new
                {
                    DiagnosticianID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfPremissions = table.Column<int>(type: "int", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleControlStationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diagnosticians", x => x.DiagnosticianID);
                    table.ForeignKey(
                        name: "FK_Diagnosticians_VehicleControlStations_VehicleControlStationID",
                        column: x => x.VehicleControlStationID,
                        principalTable: "VehicleControlStations",
                        principalColumn: "VehicleControlStationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleControlStationID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceID);
                    table.ForeignKey(
                        name: "FK_Services_VehicleControlStations_VehicleControlStationID",
                        column: x => x.VehicleControlStationID,
                        principalTable: "VehicleControlStations",
                        principalColumn: "VehicleControlStationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Carjackings",
                columns: table => new
                {
                    CarjackingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateofEvent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RediscoveryVehicle = table.Column<bool>(type: "bit", nullable: false),
                    VehicalTheft = table.Column<bool>(type: "bit", nullable: false),
                    VehicleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carjackings", x => x.CarjackingID);
                    table.ForeignKey(
                        name: "FK_Carjackings_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Deregisters",
                columns: table => new
                {
                    DeregisterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CertificateOfDismantling = table.Column<bool>(type: "bit", nullable: false),
                    DataDeregister = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReasonOfDeregistration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deregisters", x => x.DeregisterID);
                    table.ForeignKey(
                        name: "FK_Deregisters_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EditHistory",
                columns: table => new
                {
                    EditHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EditorPESEL = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PESEL = table.Column<int>(type: "int", nullable: false),
                    VehicleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EditHistory", x => x.EditHistoryID);
                    table.ForeignKey(
                        name: "FK_EditHistory_Editors_EditorPESEL",
                        column: x => x.EditorPESEL,
                        principalTable: "Editors",
                        principalColumn: "PESEL",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EditHistory_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    FuelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AverageEmmision = table.Column<float>(type: "real", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.FuelID);
                    table.ForeignKey(
                        name: "FK_Fuels_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    InsuranceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataOfTheContractExecution = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InsurenceCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NameOfConfirmationDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProtectionPeriod = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SeriesOfConfirmationDocument = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehiclesVehicleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.InsuranceID);
                    table.ForeignKey(
                        name: "FK_Insurances_Vehicles_VehiclesVehicleID",
                        column: x => x.VehiclesVehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LegalizationMarks",
                columns: table => new
                {
                    LegalizationMarkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataOfIssue = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Series = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehiclesVehicleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalizationMarks", x => x.LegalizationMarkID);
                    table.ForeignKey(
                        name: "FK_LegalizationMarks_Vehicles_VehiclesVehicleID",
                        column: x => x.VehiclesVehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationHistory",
                columns: table => new
                {
                    RegistrationHistoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrganMakingPreviousRegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousRegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationHistory", x => x.RegistrationHistoryID);
                    table.ForeignKey(
                        name: "FK_RegistrationHistory_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TemporaryLicenses",
                columns: table => new
                {
                    TemporaryLicenseID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataOFRenevalAndValidity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpirationData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurposeOfRelease = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseData = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Series = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VehicleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemporaryLicenses", x => x.TemporaryLicenseID);
                    table.ForeignKey(
                        name: "FK_TemporaryLicenses_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TemporaryStickers",
                columns: table => new
                {
                    TemporaryStickersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReleaseOfTheControlSticker = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReleaseOfTheTemporaryBoardSticker = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TemporaryStickers", x => x.TemporaryStickersID);
                    table.ForeignKey(
                        name: "FK_TemporaryStickers_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TidalWithdrawals",
                columns: table => new
                {
                    TidalWithdrawalID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataRestore = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateWithdrawal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehiclesVehicleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TidalWithdrawals", x => x.TidalWithdrawalID);
                    table.ForeignKey(
                        name: "FK_TidalWithdrawals_Vehicles_VehiclesVehicleID",
                        column: x => x.VehiclesVehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Loses",
                columns: table => new
                {
                    LossID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommitmentEvidence = table.Column<bool>(type: "bit", nullable: false),
                    CommitmentOfTheTemporaryPermit = table.Column<bool>(type: "bit", nullable: false),
                    DataOfEvent = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LossOfBoard = table.Column<bool>(type: "bit", nullable: false),
                    LossOfEvidence = table.Column<bool>(type: "bit", nullable: false),
                    LossOfTemporaryBoard = table.Column<bool>(type: "bit", nullable: false),
                    LossOfTemporaryPermit = table.Column<bool>(type: "bit", nullable: false),
                    LossOfVehicaleCard = table.Column<bool>(type: "bit", nullable: false),
                    RediscoveryOfTheEvidence = table.Column<bool>(type: "bit", nullable: false),
                    RediscoveryOfTheTemporaryBoard = table.Column<bool>(type: "bit", nullable: false),
                    RediscoveryOfTheTemporaryPermit = table.Column<bool>(type: "bit", nullable: false),
                    RediscoveryOfTheVehicaleCard = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationBookID = table.Column<int>(type: "int", nullable: true),
                    RetentionOfEvidence = table.Column<bool>(type: "bit", nullable: false),
                    RetentionOfTheTemporaryPermit = table.Column<bool>(type: "bit", nullable: false),
                    TemporaryLicenseID = table.Column<int>(type: "int", nullable: true),
                    VehicleCardID = table.Column<int>(type: "int", nullable: true),
                    VehiclesVehicleID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loses", x => x.LossID);
                    table.ForeignKey(
                        name: "FK_Loses_RegistrationBooks_RegistrationBookID",
                        column: x => x.RegistrationBookID,
                        principalTable: "RegistrationBooks",
                        principalColumn: "RegistrationBookID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Loses_TemporaryLicenses_TemporaryLicenseID",
                        column: x => x.TemporaryLicenseID,
                        principalTable: "TemporaryLicenses",
                        principalColumn: "TemporaryLicenseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Loses_VehicleCards_VehicleCardID",
                        column: x => x.VehicleCardID,
                        principalTable: "VehicleCards",
                        principalColumn: "VehicleCardID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Loses_Vehicles_VehiclesVehicleID",
                        column: x => x.VehiclesVehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carjackings_VehicleID",
                table: "Carjackings",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Deregisters_VehicleID",
                table: "Deregisters",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Diagnosticians_VehicleControlStationID",
                table: "Diagnosticians",
                column: "VehicleControlStationID");

            migrationBuilder.CreateIndex(
                name: "IX_EditHistory_EditorPESEL",
                table: "EditHistory",
                column: "EditorPESEL");

            migrationBuilder.CreateIndex(
                name: "IX_EditHistory_VehicleID",
                table: "EditHistory",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Fuels_VehicleID",
                table: "Fuels",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Insurances_VehiclesVehicleID",
                table: "Insurances",
                column: "VehiclesVehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_LegalizationMarks_VehiclesVehicleID",
                table: "LegalizationMarks",
                column: "VehiclesVehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Loses_RegistrationBookID",
                table: "Loses",
                column: "RegistrationBookID");

            migrationBuilder.CreateIndex(
                name: "IX_Loses_TemporaryLicenseID",
                table: "Loses",
                column: "TemporaryLicenseID");

            migrationBuilder.CreateIndex(
                name: "IX_Loses_VehicleCardID",
                table: "Loses",
                column: "VehicleCardID");

            migrationBuilder.CreateIndex(
                name: "IX_Loses_VehiclesVehicleID",
                table: "Loses",
                column: "VehiclesVehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationHistory_VehicleID",
                table: "RegistrationHistory",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Services_VehicleControlStationID",
                table: "Services",
                column: "VehicleControlStationID");

            migrationBuilder.CreateIndex(
                name: "IX_TemporaryLicenses_VehicleID",
                table: "TemporaryLicenses",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_TemporaryStickers_VehicleID",
                table: "TemporaryStickers",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_TidalWithdrawals_VehiclesVehicleID",
                table: "TidalWithdrawals",
                column: "VehiclesVehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleControlStations_AddressID",
                table: "VehicleControlStations",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_VehicleControlStations_NIP",
                table: "VehicleControlStations",
                column: "NIP");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_CarID",
                table: "Vehicles",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_PESEL",
                table: "Vehicles",
                column: "PESEL");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_RegistrationBookID",
                table: "Vehicles",
                column: "RegistrationBookID",
                unique: true,
                filter: "[RegistrationBookID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_TechnicalResearchID",
                table: "Vehicles",
                column: "TechnicalResearchID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleCardID",
                table: "Vehicles",
                column: "VehicleCardID",
                unique: true,
                filter: "[VehicleCardID] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Carjackings");

            migrationBuilder.DropTable(
                name: "Deregisters");

            migrationBuilder.DropTable(
                name: "Diagnosticians");

            migrationBuilder.DropTable(
                name: "EditHistory");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropTable(
                name: "Insurances");

            migrationBuilder.DropTable(
                name: "LegalizationMarks");

            migrationBuilder.DropTable(
                name: "Loses");

            migrationBuilder.DropTable(
                name: "RegistrationHistory");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "TemporaryStickers");

            migrationBuilder.DropTable(
                name: "TidalWithdrawals");

            migrationBuilder.DropTable(
                name: "Editors");

            migrationBuilder.DropTable(
                name: "TemporaryLicenses");

            migrationBuilder.DropTable(
                name: "VehicleControlStations");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Entrepreneurs");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "RegistrationBooks");

            migrationBuilder.DropTable(
                name: "TechnicalResearchs");

            migrationBuilder.DropTable(
                name: "VehicleCards");
        }
    }
}
