using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace venteenligne.Migrations
{
    /// <inheritdoc />
    public partial class lkwa2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PanierPrincs",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDU = table.Column<int>(type: "int", nullable: false),
                    DateCréation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanierPrincs", x => x.PID);
                });

            migrationBuilder.CreateTable(
                name: "Paniers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IDPa = table.Column<int>(type: "int", nullable: false),
                    IDPro = table.Column<int>(type: "int", nullable: false),
                    Quantité = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paniers", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PanierPrincs");

            migrationBuilder.DropTable(
                name: "Paniers");
        }
    }
}
