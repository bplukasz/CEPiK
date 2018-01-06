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
                    AddressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: true),
                    Commune = table.Column<string>(nullable: true),
                    HouseNumber = table.Column<string>(nullable: true),
                    PostalCode = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    Voivodeship = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressID);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CarBrand = table.Column<string>(nullable: true),
                    Category = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Variant = table.Column<string>(nullable: true),
                    Version = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarID);
                });

            migrationBuilder.CreateTable(
                name: "Editors",
                columns: table => new
                {
                    PESEL = table.Column<string>(nullable: false),
                    EditData = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editors", x => x.PESEL);
                });

            migrationBuilder.CreateTable(
                name: "Entrepreneurs",
                columns: table => new
                {
                    NIP = table.Column<long>(nullable: false),
                    AddressID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    NumberInEnterpreneurRegister = table.Column<int>(nullable: false),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entrepreneurs", x => x.NIP);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    PESEL = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    REGON = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.PESEL);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationBooks",
                columns: table => new
                {
                    RegistrationBookID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExpirationData = table.Column<DateTime>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    ReleaseData = table.Column<DateTime>(nullable: false),
                    Series = table.Column<string>(nullable: true),
                    TidalPermission = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationBooks", x => x.RegistrationBookID);
                });

            migrationBuilder.CreateTable(
                name: "TechnicalResearchs",
                columns: table => new
                {
                    TechnicalResearchID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Data = table.Column<DateTime>(nullable: false),
                    Demaged = table.Column<bool>(nullable: false),
                    Details = table.Column<string>(nullable: true),
                    Mileage = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechnicalResearchs", x => x.TechnicalResearchID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleControlStations",
                columns: table => new
                {
                    VehicleControlStationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressID = table.Column<int>(nullable: false),
                    NIP = table.Column<long>(nullable: false),
                    Name = table.Column<string>(nullable: true)
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
                    VehicleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Allocation = table.Column<int>(nullable: true),
                    AllowedPackage = table.Column<float>(nullable: true),
                    AutomobileMaker = table.Column<string>(nullable: true),
                    AverageFuelConsumption = table.Column<float>(nullable: true),
                    AxleNumber = table.Column<int>(nullable: true),
                    BodyNumber = table.Column<string>(nullable: true),
                    CarID = table.Column<int>(nullable: true),
                    DataOfTheBodyNumber = table.Column<DateTime>(nullable: true),
                    DeadweightLoad = table.Column<float>(nullable: true),
                    Destination = table.Column<string>(nullable: true),
                    ECTypeApproval = table.Column<bool>(nullable: true),
                    EnginePower = table.Column<float>(nullable: true),
                    EngineSize = table.Column<float>(nullable: true),
                    Equipment = table.Column<string>(nullable: true),
                    FirstRegistrationAbroad = table.Column<DateTime>(nullable: true),
                    GrossVehicleWeightRating = table.Column<float>(nullable: true),
                    InitialRegistration = table.Column<DateTime>(nullable: true),
                    ManufactureYear = table.Column<DateTime>(nullable: true),
                    MaximumTotalWeight = table.Column<float>(nullable: true),
                    MaximumTowedMassOfTheTrailer = table.Column<float>(nullable: true),
                    PESEL = table.Column<string>(nullable: true),
                    PermissibleAxleLoad = table.Column<float>(nullable: true),
                    RadarDevice = table.Column<string>(nullable: true),
                    RegistrationAuthority = table.Column<string>(nullable: true),
                    RegistrationBookID = table.Column<int>(nullable: true),
                    RegistrationNumber = table.Column<string>(nullable: true),
                    Subgenus = table.Column<string>(nullable: true),
                    SuspensionType = table.Column<string>(nullable: true),
                    TechnicalResearchID = table.Column<int>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    TypeApprovalCertificate = table.Column<string>(nullable: true),
                    VIN = table.Column<string>(nullable: true),
                    VehicleCardID = table.Column<int>(nullable: true),
                    WeatherDependent = table.Column<bool>(nullable: true),
                    Wheelbase = table.Column<float>(nullable: true),
                    WheelbaseAVG = table.Column<float>(nullable: true),
                    WheelbaseMAX = table.Column<float>(nullable: true),
                    WheelbaseMIN = table.Column<float>(nullable: true)
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
                });

            migrationBuilder.CreateTable(
                name: "Diagnosticians",
                columns: table => new
                {
                    DiagnosticianID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    NumberOfPremissions = table.Column<int>(nullable: false),
                    Surname = table.Column<string>(nullable: true),
                    VehicleControlStationID = table.Column<int>(nullable: true)
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
                    ServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    VehicleControlStationID = table.Column<int>(nullable: true)
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
                    CarjackingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateofEvent = table.Column<DateTime>(nullable: false),
                    RediscoveryVehicle = table.Column<bool>(nullable: false),
                    VehicalTheft = table.Column<bool>(nullable: false),
                    VehicleID = table.Column<int>(nullable: true)
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
                    DeregisterID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CertificateOfDismantling = table.Column<bool>(nullable: false),
                    DataDeregister = table.Column<DateTime>(nullable: false),
                    ReasonOfDeregistration = table.Column<string>(nullable: false),
                    VehicleID = table.Column<int>(nullable: true),
                    Vin = table.Column<string>(nullable: true)
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
                    EditHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EditorPESEL = table.Column<string>(nullable: true),
                    PESEL = table.Column<int>(nullable: false),
                    VehicleID = table.Column<int>(nullable: false)
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
                    FuelID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AverageEmmision = table.Column<float>(nullable: false),
                    FuelType = table.Column<string>(nullable: true),
                    VehicleID = table.Column<int>(nullable: true)
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
                    InsuranceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Adress = table.Column<string>(nullable: true),
                    Company = table.Column<string>(nullable: true),
                    DataOfTheContractExecution = table.Column<DateTime>(nullable: false),
                    ExpirationData = table.Column<DateTime>(nullable: false),
                    InsurenceCompany = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    NameOfConfirmationDocument = table.Column<string>(nullable: true),
                    ProtectionPeriod = table.Column<DateTime>(nullable: false),
                    SeriesOfConfirmationDocument = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    VehiclesVehicleID = table.Column<int>(nullable: true)
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
                    LegalizationMarkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataOfIssue = table.Column<DateTime>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    Series = table.Column<string>(nullable: true),
                    VehiclesVehicleID = table.Column<int>(nullable: true)
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
                    RegistrationHistoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OrganMakingPreviousRegistrationNumber = table.Column<string>(nullable: true),
                    PreviousRegistrationNumber = table.Column<string>(nullable: true),
                    VehicleID = table.Column<int>(nullable: true)
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
                    TemporaryLicenseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataOFRenevalAndValidity = table.Column<DateTime>(nullable: false),
                    ExpirationData = table.Column<DateTime>(nullable: false),
                    Number = table.Column<string>(nullable: true),
                    PurposeOfRelease = table.Column<string>(nullable: true),
                    ReleaseData = table.Column<DateTime>(nullable: false),
                    Series = table.Column<string>(nullable: true),
                    VehicleID = table.Column<int>(nullable: true)
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
                    TemporaryStickersID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ReleaseOfTheControlSticker = table.Column<DateTime>(nullable: false),
                    ReleaseOfTheTemporaryBoardSticker = table.Column<DateTime>(nullable: false),
                    VehicleID = table.Column<int>(nullable: true)
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
                    TidalWithdrawalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DataRestore = table.Column<DateTime>(nullable: false),
                    DateWithdrawal = table.Column<DateTime>(nullable: false),
                    VehiclesVehicleID = table.Column<int>(nullable: true)
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
                name: "VehicleCards",
                columns: table => new
                {
                    VehicleCardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExpirationData = table.Column<DateTime>(nullable: false),
                    SeriesAndNumber = table.Column<string>(nullable: true),
                    VIN = table.Column<string>(nullable: true),
                    VehicleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleCards", x => x.VehicleCardID);
                    table.ForeignKey(
                        name: "FK_VehicleCards_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "VehicleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loses",
                columns: table => new
                {
                    LossID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CommitmentEvidence = table.Column<bool>(nullable: false),
                    CommitmentOfTheTemporaryPermit = table.Column<bool>(nullable: false),
                    DataOfEvent = table.Column<DateTime>(nullable: false),
                    LossOfBoard = table.Column<bool>(nullable: false),
                    LossOfEvidence = table.Column<bool>(nullable: false),
                    LossOfTemporaryBoard = table.Column<bool>(nullable: false),
                    LossOfTemporaryPermit = table.Column<bool>(nullable: false),
                    LossOfVehicaleCard = table.Column<bool>(nullable: false),
                    RediscoveryOfTheEvidence = table.Column<bool>(nullable: false),
                    RediscoveryOfTheTemporaryBoard = table.Column<bool>(nullable: false),
                    RediscoveryOfTheTemporaryPermit = table.Column<bool>(nullable: false),
                    RediscoveryOfTheVehicaleCard = table.Column<bool>(nullable: false),
                    RegistrationBookID = table.Column<int>(nullable: true),
                    RetentionOfEvidence = table.Column<bool>(nullable: false),
                    RetentionOfTheTemporaryPermit = table.Column<bool>(nullable: false),
                    TemporaryLicenseID = table.Column<int>(nullable: true),
                    VehicleCardID = table.Column<int>(nullable: true),
                    VehiclesVehicleID = table.Column<int>(nullable: true)
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
                name: "IX_VehicleCards_VehicleID",
                table: "VehicleCards",
                column: "VehicleID",
                unique: true);

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
                name: "User");

            migrationBuilder.DropTable(
                name: "Editors");

            migrationBuilder.DropTable(
                name: "TemporaryLicenses");

            migrationBuilder.DropTable(
                name: "VehicleCards");

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
        }
    }
}
