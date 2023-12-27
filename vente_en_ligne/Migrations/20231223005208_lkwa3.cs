using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace venteenligne.Migrations
{
    /// <inheritdoc />
    public partial class lkwa3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PanierPrincs");

            migrationBuilder.RenameColumn(
                name: "IDPa",
                table: "Paniers",
                newName: "IDU");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IDU",
                table: "Paniers",
                newName: "IDPa");

            migrationBuilder.CreateTable(
                name: "PanierPrincs",
                columns: table => new
                {
                    PID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCréation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IDU = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PanierPrincs", x => x.PID);
                });
        }
    }
}
