using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DavaSurecTakip.DataAccess.Migrations
{
    public partial class FullDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authorities",
                columns: table => new
                {
                    AuthId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorityDefination = table.Column<string>(type: "Varchar(40)", nullable: true),
                    FieldName = table.Column<string>(type: "Varchar(40)", nullable: true),
                    View = table.Column<bool>(type: "bit", nullable: false),
                    Create = table.Column<bool>(type: "bit", nullable: false),
                    Change = table.Column<bool>(type: "bit", nullable: false),
                    Delete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authorities", x => x.AuthId);
                });

            migrationBuilder.CreateTable(
                name: "caseDtos",
                columns: table => new
                {
                    IdDto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseResultDto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CaseSubjectDto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileStageDto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProvinceDto = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_caseDtos", x => x.IdDto);
                });

            migrationBuilder.CreateTable(
                name: "lookupAttornerL",
                columns: table => new
                {
                    AttornerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attorner = table.Column<string>(type: "Varchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupAttornerL", x => x.AttornerId);
                });

            migrationBuilder.CreateTable(
                name: "lookupCaseResultL",
                columns: table => new
                {
                    CaseResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseResult = table.Column<string>(type: "Varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupCaseResultL", x => x.CaseResultId);
                });

            migrationBuilder.CreateTable(
                name: "lookupCaseSubjectL",
                columns: table => new
                {
                    CaseSubjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseSubject = table.Column<string>(type: "Varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupCaseSubjectL", x => x.CaseSubjectId);
                });

            migrationBuilder.CreateTable(
                name: "lookupDamageTypeL",
                columns: table => new
                {
                    DamageTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DamageType = table.Column<string>(type: "Varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupDamageTypeL", x => x.DamageTypeId);
                });

            migrationBuilder.CreateTable(
                name: "lookupFileDamageStatusL",
                columns: table => new
                {
                    DamageStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileDamagesStatus = table.Column<string>(type: "Varchar(40)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupFileDamageStatusL", x => x.DamageStatusId);
                });

            migrationBuilder.CreateTable(
                name: "lookupFileStageL",
                columns: table => new
                {
                    FileStageId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileStage = table.Column<string>(type: "Varchar(40)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupFileStageL", x => x.FileStageId);
                });

            migrationBuilder.CreateTable(
                name: "lookupInsuranceExplanationL",
                columns: table => new
                {
                    InsuranceExplanationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InsuranceExplanation = table.Column<string>(type: "Varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupInsuranceExplanationL", x => x.InsuranceExplanationId);
                });

            migrationBuilder.CreateTable(
                name: "lookupPaymentTypeL",
                columns: table => new
                {
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentType = table.Column<string>(type: "Varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupPaymentTypeL", x => x.PaymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "lookupProvinceL",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Province = table.Column<string>(type: "Varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupProvinceL", x => x.ProvinceId);
                });

            migrationBuilder.CreateTable(
                name: "lookupWorkAreaL",
                columns: table => new
                {
                    WorkAreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkArea = table.Column<string>(type: "Varchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupWorkAreaL", x => x.WorkAreaId);
                });

            migrationBuilder.CreateTable(
                name: "userAuthorizations",
                columns: table => new
                {
                    AdName = table.Column<string>(type: "Varchar(40)", nullable: false),
                    AuthId = table.Column<int>(type: "int", nullable: false),
                    RowNumb = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userAuthorizations", x => x.AdName);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "Varchar(15)", nullable: true),
                    UserPassword = table.Column<string>(type: "Varchar(10)", maxLength: 10, nullable: true),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lookupCourtInfoL",
                columns: table => new
                {
                    CourtinInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourtinInfo = table.Column<string>(type: "Varchar(200)", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    LookupProvinceLProvinceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupCourtInfoL", x => x.CourtinInfoId);
                    table.ForeignKey(
                        name: "FK_lookupCourtInfoL_lookupProvinceL_LookupProvinceLProvinceId",
                        column: x => x.LookupProvinceLProvinceId,
                        principalTable: "lookupProvinceL",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "lookupLevyInfoL",
                columns: table => new
                {
                    LevyInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LevyInfo = table.Column<string>(type: "Varchar(160)", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    LookupProvinceLProvinceId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lookupLevyInfoL", x => x.LevyInfoId);
                    table.ForeignKey(
                        name: "FK_lookupLevyInfoL_lookupProvinceL_LookupProvinceLProvinceId",
                        column: x => x.LookupProvinceLProvinceId,
                        principalTable: "lookupProvinceL",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "cases",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CorporationId = table.Column<int>(type: "int", nullable: false),
                    IHopeId = table.Column<int>(type: "int", nullable: false),
                    CaseResultId = table.Column<int>(type: "int", nullable: false),
                    LookupCaseResultLCaseResultId = table.Column<int>(type: "int", nullable: true),
                    CaseSubjectId = table.Column<int>(type: "int", nullable: false),
                    LookupCaseSubjectLCaseSubjectId = table.Column<int>(type: "int", nullable: true),
                    FileStageId = table.Column<int>(type: "int", nullable: false),
                    LookupFileStageLFileStageId = table.Column<int>(type: "int", nullable: true),
                    CourtInfoId = table.Column<int>(type: "int", nullable: false),
                    LookupCourtInfoLCourtinInfoId = table.Column<int>(type: "int", nullable: true),
                    ClaimantAttornerId = table.Column<int>(type: "int", nullable: false),
                    LookupAttornerLAttornerId = table.Column<int>(type: "int", nullable: true),
                    DefendantAttornerId = table.Column<int>(type: "int", nullable: false),
                    LookupAttornerAttornerId = table.Column<int>(type: "int", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: false),
                    LookupProvinceLProvinceId = table.Column<int>(type: "int", nullable: true),
                    TrialDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ActualBasis = table.Column<string>(type: "Varchar(20)", nullable: true),
                    OldBasis = table.Column<string>(type: "Varchar(20)", nullable: true),
                    Claimant = table.Column<string>(type: "Varchar(200)", nullable: true),
                    Tc = table.Column<string>(type: "Varchar(11)", nullable: true),
                    Defendant = table.Column<string>(type: "Varchar(200)", nullable: true),
                    SecondDefendant = table.Column<string>(type: "Varchar(200)", nullable: true),
                    Notified = table.Column<string>(type: "Varchar(200)", nullable: true),
                    CaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CaseOpeningValue = table.Column<int>(type: "int", nullable: false),
                    CaseActualValue = table.Column<int>(type: "int", nullable: false),
                    InFavorOfAgencyFee = table.Column<int>(type: "int", nullable: false),
                    InterimInjunction = table.Column<bool>(type: "bit", nullable: false),
                    ObjectiveOfInterimInjunction = table.Column<bool>(type: "bit", nullable: false),
                    Archive = table.Column<bool>(type: "bit", nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ErDatCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdNameCreate = table.Column<string>(type: "Varchar(40)", nullable: true),
                    ErDatChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdNameChange = table.Column<string>(type: "Varchar(40)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cases", x => x.CaseId);
                    table.ForeignKey(
                        name: "FK_cases_lookupAttornerL_LookupAttornerAttornerId",
                        column: x => x.LookupAttornerAttornerId,
                        principalTable: "lookupAttornerL",
                        principalColumn: "AttornerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cases_lookupAttornerL_LookupAttornerLAttornerId",
                        column: x => x.LookupAttornerLAttornerId,
                        principalTable: "lookupAttornerL",
                        principalColumn: "AttornerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cases_lookupCaseResultL_LookupCaseResultLCaseResultId",
                        column: x => x.LookupCaseResultLCaseResultId,
                        principalTable: "lookupCaseResultL",
                        principalColumn: "CaseResultId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cases_lookupCaseSubjectL_LookupCaseSubjectLCaseSubjectId",
                        column: x => x.LookupCaseSubjectLCaseSubjectId,
                        principalTable: "lookupCaseSubjectL",
                        principalColumn: "CaseSubjectId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cases_lookupCourtInfoL_LookupCourtInfoLCourtinInfoId",
                        column: x => x.LookupCourtInfoLCourtinInfoId,
                        principalTable: "lookupCourtInfoL",
                        principalColumn: "CourtinInfoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cases_lookupFileStageL_LookupFileStageLFileStageId",
                        column: x => x.LookupFileStageLFileStageId,
                        principalTable: "lookupFileStageL",
                        principalColumn: "FileStageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_cases_lookupProvinceL_LookupProvinceLProvinceId",
                        column: x => x.LookupProvinceLProvinceId,
                        principalTable: "lookupProvinceL",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "paidDamages",
                columns: table => new
                {
                    RowNumb = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseId = table.Column<int>(type: "int", nullable: false),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false),
                    LookupPaymentTypeLPaymentTypeId = table.Column<int>(type: "int", nullable: true),
                    WorkAreaId = table.Column<int>(type: "int", nullable: false),
                    LookupWorkAreaLWorkAreaId = table.Column<int>(type: "int", nullable: true),
                    DamageTypeId = table.Column<int>(type: "int", nullable: false),
                    LookupDamageTypeLDamageTypeId = table.Column<int>(type: "int", nullable: true),
                    LevyId = table.Column<int>(type: "int", nullable: false),
                    LookupLevyInfoLLevyInfoId = table.Column<int>(type: "int", nullable: true),
                    FileDamageStatusId = table.Column<int>(type: "int", nullable: false),
                    LookupFileDamageStatusLDamageStatusId = table.Column<int>(type: "int", nullable: true),
                    InsuranceExpid = table.Column<int>(type: "int", nullable: false),
                    LookupInsuranceExplanationLInsuranceExplanationId = table.Column<int>(type: "int", nullable: true),
                    Piece = table.Column<int>(type: "int", nullable: false),
                    PartInfo = table.Column<string>(type: "Varchar(20)", nullable: true),
                    FirmInfo = table.Column<string>(type: "Varchar(100)", nullable: true),
                    PayeeInfo = table.Column<string>(type: "Varchar(160)", nullable: true),
                    SapPaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SapPaymentYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentAmount = table.Column<float>(type: "real", nullable: false),
                    SapAmount = table.Column<float>(type: "real", nullable: false),
                    CashCollateral = table.Column<float>(type: "real", nullable: false),
                    InfoNote = table.Column<string>(type: "Varchar(4000)", nullable: true),
                    Insurable = table.Column<bool>(type: "bit", nullable: false),
                    RecouseDeclaration = table.Column<bool>(type: "bit", nullable: false),
                    RecouseExplanation = table.Column<string>(type: "Varchar(100)", nullable: true),
                    CalculatedRecouseAmount = table.Column<float>(type: "real", nullable: false),
                    CollectionAmount = table.Column<float>(type: "real", nullable: false),
                    RemainingAmount = table.Column<float>(type: "real", nullable: false),
                    CollectionChannel = table.Column<string>(type: "Varchar(20)", nullable: true),
                    CaseFinalSituation = table.Column<bool>(type: "bit", nullable: false),
                    ErDatCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdNameCreate = table.Column<string>(type: "Varchar(40)", nullable: true),
                    ErDatChange = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdNameChange = table.Column<string>(type: "Varchar(40)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paidDamages", x => x.RowNumb);
                    table.ForeignKey(
                        name: "FK_paidDamages_cases_CaseId",
                        column: x => x.CaseId,
                        principalTable: "cases",
                        principalColumn: "CaseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_paidDamages_lookupDamageTypeL_LookupDamageTypeLDamageTypeId",
                        column: x => x.LookupDamageTypeLDamageTypeId,
                        principalTable: "lookupDamageTypeL",
                        principalColumn: "DamageTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_paidDamages_lookupFileDamageStatusL_LookupFileDamageStatusLDamageStatusId",
                        column: x => x.LookupFileDamageStatusLDamageStatusId,
                        principalTable: "lookupFileDamageStatusL",
                        principalColumn: "DamageStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_paidDamages_lookupInsuranceExplanationL_LookupInsuranceExplanationLInsuranceExplanationId",
                        column: x => x.LookupInsuranceExplanationLInsuranceExplanationId,
                        principalTable: "lookupInsuranceExplanationL",
                        principalColumn: "InsuranceExplanationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_paidDamages_lookupLevyInfoL_LookupLevyInfoLLevyInfoId",
                        column: x => x.LookupLevyInfoLLevyInfoId,
                        principalTable: "lookupLevyInfoL",
                        principalColumn: "LevyInfoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_paidDamages_lookupPaymentTypeL_LookupPaymentTypeLPaymentTypeId",
                        column: x => x.LookupPaymentTypeLPaymentTypeId,
                        principalTable: "lookupPaymentTypeL",
                        principalColumn: "PaymentTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_paidDamages_lookupWorkAreaL_LookupWorkAreaLWorkAreaId",
                        column: x => x.LookupWorkAreaLWorkAreaId,
                        principalTable: "lookupWorkAreaL",
                        principalColumn: "WorkAreaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cases_LookupAttornerAttornerId",
                table: "cases",
                column: "LookupAttornerAttornerId");

            migrationBuilder.CreateIndex(
                name: "IX_cases_LookupAttornerLAttornerId",
                table: "cases",
                column: "LookupAttornerLAttornerId");

            migrationBuilder.CreateIndex(
                name: "IX_cases_LookupCaseResultLCaseResultId",
                table: "cases",
                column: "LookupCaseResultLCaseResultId");

            migrationBuilder.CreateIndex(
                name: "IX_cases_LookupCaseSubjectLCaseSubjectId",
                table: "cases",
                column: "LookupCaseSubjectLCaseSubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_cases_LookupCourtInfoLCourtinInfoId",
                table: "cases",
                column: "LookupCourtInfoLCourtinInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_cases_LookupFileStageLFileStageId",
                table: "cases",
                column: "LookupFileStageLFileStageId");

            migrationBuilder.CreateIndex(
                name: "IX_cases_LookupProvinceLProvinceId",
                table: "cases",
                column: "LookupProvinceLProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_lookupCourtInfoL_LookupProvinceLProvinceId",
                table: "lookupCourtInfoL",
                column: "LookupProvinceLProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_lookupLevyInfoL_LookupProvinceLProvinceId",
                table: "lookupLevyInfoL",
                column: "LookupProvinceLProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_paidDamages_CaseId",
                table: "paidDamages",
                column: "CaseId");

            migrationBuilder.CreateIndex(
                name: "IX_paidDamages_LookupDamageTypeLDamageTypeId",
                table: "paidDamages",
                column: "LookupDamageTypeLDamageTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_paidDamages_LookupFileDamageStatusLDamageStatusId",
                table: "paidDamages",
                column: "LookupFileDamageStatusLDamageStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_paidDamages_LookupInsuranceExplanationLInsuranceExplanationId",
                table: "paidDamages",
                column: "LookupInsuranceExplanationLInsuranceExplanationId");

            migrationBuilder.CreateIndex(
                name: "IX_paidDamages_LookupLevyInfoLLevyInfoId",
                table: "paidDamages",
                column: "LookupLevyInfoLLevyInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_paidDamages_LookupPaymentTypeLPaymentTypeId",
                table: "paidDamages",
                column: "LookupPaymentTypeLPaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_paidDamages_LookupWorkAreaLWorkAreaId",
                table: "paidDamages",
                column: "LookupWorkAreaLWorkAreaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "authorities");

            migrationBuilder.DropTable(
                name: "caseDtos");

            migrationBuilder.DropTable(
                name: "paidDamages");

            migrationBuilder.DropTable(
                name: "userAuthorizations");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "cases");

            migrationBuilder.DropTable(
                name: "lookupDamageTypeL");

            migrationBuilder.DropTable(
                name: "lookupFileDamageStatusL");

            migrationBuilder.DropTable(
                name: "lookupInsuranceExplanationL");

            migrationBuilder.DropTable(
                name: "lookupLevyInfoL");

            migrationBuilder.DropTable(
                name: "lookupPaymentTypeL");

            migrationBuilder.DropTable(
                name: "lookupWorkAreaL");

            migrationBuilder.DropTable(
                name: "lookupAttornerL");

            migrationBuilder.DropTable(
                name: "lookupCaseResultL");

            migrationBuilder.DropTable(
                name: "lookupCaseSubjectL");

            migrationBuilder.DropTable(
                name: "lookupCourtInfoL");

            migrationBuilder.DropTable(
                name: "lookupFileStageL");

            migrationBuilder.DropTable(
                name: "lookupProvinceL");
        }
    }
}
