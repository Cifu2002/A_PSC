using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace A_PSC.BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class EntitiesCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Annexes",
                columns: table => new
                {
                    IdAnnex = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeAnnex = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DescriptionAnnex = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FileUrlAnnex = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Annexes", x => x.IdAnnex);
                });

            migrationBuilder.CreateTable(
                name: "BeneficiaryPopulations",
                columns: table => new
                {
                    IdBeneficiaryPopulation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenBeneficiaryPopulation = table.Column<int>(type: "int", nullable: false),
                    WomenBeneficiaryPopulation = table.Column<int>(type: "int", nullable: false),
                    TotalBeneficiaryPopulation = table.Column<int>(type: "int", nullable: false),
                    DirectBeneficiariesBeneficiaryPopulation = table.Column<int>(type: "int", nullable: false),
                    IndirectBeneficiariesBeneficiaryPopulation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeneficiaryPopulations", x => x.IdBeneficiaryPopulation);
                });

            migrationBuilder.CreateTable(
                name: "CooperatingEntities",
                columns: table => new
                {
                    IdCooperatingEntity = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeCooperatingEntity = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NameCooperatingEntity = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CooperatingEntities", x => x.IdCooperatingEntity);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    IdProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeProduct = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NameProduct = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DescriptionProduct = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    GoalProduct = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IndicatorProduct = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.IdProduct);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    IdProvince = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProvince = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.IdProvince);
                });

            migrationBuilder.CreateTable(
                name: "SpecificObjectives",
                columns: table => new
                {
                    IdSpecificObjective = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionSpecificObjective = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GoalSpecificObjective = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IndicatorSpecificObjective = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecificObjectives", x => x.IdSpecificObjective);
                });

            migrationBuilder.CreateTable(
                name: "Agreements",
                columns: table => new
                {
                    IdAgreement = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeAgreement = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NameAgreement = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DescriptionAgreement = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StartDateAgreement = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    EndDateAgreement = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    LocationAgreement = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IdCooperatingEntityPer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agreements", x => x.IdAgreement);
                    table.ForeignKey(
                        name: "FK_Agreements_CooperatingEntities_IdCooperatingEntityPer",
                        column: x => x.IdCooperatingEntityPer,
                        principalTable: "CooperatingEntities",
                        principalColumn: "IdCooperatingEntity",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CooperatingEntityContributions",
                columns: table => new
                {
                    IdCooperatingEntityContribution = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionCooperatingEntityContribution = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ValueCooperatingEntityContribution = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    IdCooperatingEntityPer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CooperatingEntityContributions", x => x.IdCooperatingEntityContribution);
                    table.ForeignKey(
                        name: "FK_CooperatingEntityContributions_CooperatingEntities_IdCooperatingEntityPer",
                        column: x => x.IdCooperatingEntityPer,
                        principalTable: "CooperatingEntities",
                        principalColumn: "IdCooperatingEntity",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RepresentativeBeneficiaries",
                columns: table => new
                {
                    IdRepresentativeBeneficiary = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepresentativeBeneficiaryName = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    RepresentativeBeneficiaryPosition = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    RepresentativeBeneficiaryPhone = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    RepresentativeBeneficiaryEmail = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IdCooperatingEntityPer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepresentativeBeneficiaries", x => x.IdRepresentativeBeneficiary);
                    table.ForeignKey(
                        name: "FK_RepresentativeBeneficiaries_CooperatingEntities_IdCooperatingEntityPer",
                        column: x => x.IdCooperatingEntityPer,
                        principalTable: "CooperatingEntities",
                        principalColumn: "IdCooperatingEntity",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cantons",
                columns: table => new
                {
                    IdCanton = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCanton = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdProvincePer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cantons", x => x.IdCanton);
                    table.ForeignKey(
                        name: "FK_Cantons_Provinces_IdProvincePer",
                        column: x => x.IdProvincePer,
                        principalTable: "Provinces",
                        principalColumn: "IdProvince",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectActivities",
                columns: table => new
                {
                    IdProjectActivity = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescriptionProjectActivity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    WeekProjectActivity = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StartDateProjectActivity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateProjectActivity = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ObservationsProjectActivity = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    StudentHoursProjectActivity = table.Column<int>(type: "int", nullable: true),
                    TeacherHoursProjectActivity = table.Column<int>(type: "int", nullable: true),
                    IdSpecificObjectivePer = table.Column<int>(type: "int", nullable: false),
                    IdProductPer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectActivities", x => x.IdProjectActivity);
                    table.ForeignKey(
                        name: "FK_ProjectActivities_Products_IdProductPer",
                        column: x => x.IdProductPer,
                        principalTable: "Products",
                        principalColumn: "IdProduct",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectActivities_SpecificObjectives_IdSpecificObjectivePer",
                        column: x => x.IdSpecificObjectivePer,
                        principalTable: "SpecificObjectives",
                        principalColumn: "IdSpecificObjective",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Parishes",
                columns: table => new
                {
                    IdParish = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameParish = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IdCantonPer = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parishes", x => x.IdParish);
                    table.ForeignKey(
                        name: "FK_Parishes_Cantons_IdCantonPer",
                        column: x => x.IdCantonPer,
                        principalTable: "Cantons",
                        principalColumn: "IdCanton",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agreements_IdCooperatingEntityPer",
                table: "Agreements",
                column: "IdCooperatingEntityPer");

            migrationBuilder.CreateIndex(
                name: "IX_Cantons_IdProvincePer",
                table: "Cantons",
                column: "IdProvincePer");

            migrationBuilder.CreateIndex(
                name: "IX_CooperatingEntityContributions_IdCooperatingEntityPer",
                table: "CooperatingEntityContributions",
                column: "IdCooperatingEntityPer");

            migrationBuilder.CreateIndex(
                name: "IX_Parishes_IdCantonPer",
                table: "Parishes",
                column: "IdCantonPer");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectActivities_IdProductPer",
                table: "ProjectActivities",
                column: "IdProductPer");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectActivities_IdSpecificObjectivePer",
                table: "ProjectActivities",
                column: "IdSpecificObjectivePer");

            migrationBuilder.CreateIndex(
                name: "IX_RepresentativeBeneficiaries_IdCooperatingEntityPer",
                table: "RepresentativeBeneficiaries",
                column: "IdCooperatingEntityPer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agreements");

            migrationBuilder.DropTable(
                name: "Annexes");

            migrationBuilder.DropTable(
                name: "BeneficiaryPopulations");

            migrationBuilder.DropTable(
                name: "CooperatingEntityContributions");

            migrationBuilder.DropTable(
                name: "Parishes");

            migrationBuilder.DropTable(
                name: "ProjectActivities");

            migrationBuilder.DropTable(
                name: "RepresentativeBeneficiaries");

            migrationBuilder.DropTable(
                name: "Cantons");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "SpecificObjectives");

            migrationBuilder.DropTable(
                name: "CooperatingEntities");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
