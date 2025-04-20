using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmaVisitApp.Api.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cycles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DateDebut = table.Column<DateOnly>(type: "date", nullable: false),
                    DateFin = table.Column<DateOnly>(type: "date", nullable: false),
                    NbrSemaine = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "date", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cycles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Geos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CodeIMS = table.Column<int>(type: "int", nullable: true),
                    UGIMS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MenuItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Controller = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Area = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Path = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CssIcon = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TagNumber = table.Column<int>(type: "int", nullable: true),
                    TagTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "date", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pharmacies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NomPharmacie = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NomPharmacien = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PrenomPharmacien = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GeoId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 255, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Potentiel = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "date", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pharmacies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PharmaLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CodeX3 = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NomPharmacie = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NomPharmacien = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PrenomPharmacien = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GeoId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 255, nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Adresse = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Potentiel = table.Column<int>(type: "int", nullable: true),
                    PharmacieId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: true),
                    IsValid = table.Column<bool>(type: "bit", nullable: true),
                    OperationType = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ValidatedAt = table.Column<DateTime>(type: "date", nullable: true),
                    ValidatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmaLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false),
                    PharmacieId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false),
                    CycleId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: true),
                    Semaine = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "date", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Label = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ValidatedPlan = table.Column<bool>(type: "bit", nullable: true),
                    IsValidatedPlan = table.Column<bool>(type: "bit", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    AdConnect = table.Column<bool>(type: "bit", nullable: true),
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false),
                    ResponsableId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "date", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visites",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PharmacieId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false),
                    DateVisite = table.Column<DateOnly>(type: "date", nullable: true),
                    PharmacieVu = table.Column<bool>(type: "bit", nullable: true),
                    BonCommande = table.Column<bool>(type: "bit", nullable: true),
                    FormationDipensee = table.Column<bool>(type: "bit", nullable: true),
                    RemisePlv = table.Column<bool>(type: "bit", nullable: true),
                    VisiteDouble = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false),
                    CycleId = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: true),
                    Semaine = table.Column<int>(type: "int", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "date", nullable: true),
                    ModifiedBy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visites", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GeoUser",
                columns: table => new
                {
                    GeosId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeoUser", x => new { x.GeosId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_GeoUser_Geos_GeosId",
                        column: x => x.GeosId,
                        principalTable: "Geos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GeoUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GeoUser_UsersId",
                table: "GeoUser",
                column: "UsersId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cycles");

            migrationBuilder.DropTable(
                name: "GeoUser");

            migrationBuilder.DropTable(
                name: "MenuItems");

            migrationBuilder.DropTable(
                name: "Pharmacies");

            migrationBuilder.DropTable(
                name: "PharmaLogs");

            migrationBuilder.DropTable(
                name: "Planifications");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "Visites");

            migrationBuilder.DropTable(
                name: "Geos");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
