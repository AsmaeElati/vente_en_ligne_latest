using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace venteenligne.Migrations
{
    /// <inheritdoc />
    public partial class lkwa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Panier");

            migrationBuilder.DropTable(
                name: "PanierPrincs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    table.ForeignKey(
                        name: "FK_PanierPrincs_Utilisateurs_IDU",
                        column: x => x.IDU,
                        principalTable: "Utilisateurs",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Panier",
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
                    table.PrimaryKey("PK_Panier", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Panier_PanierPrincs_IDPa",
                        column: x => x.IDPa,
                        principalTable: "PanierPrincs",
                        principalColumn: "PID");
                    table.ForeignKey(
                        name: "FK_Panier_Produits_IDPro",
                        column: x => x.IDPro,
                        principalTable: "Produits",
                        principalColumn: "IdPr");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Panier_IDPa",
                table: "Panier",
                column: "IDPa");

            migrationBuilder.CreateIndex(
                name: "IX_Panier_IDPro",
                table: "Panier",
                column: "IDPro");

            migrationBuilder.CreateIndex(
                name: "IX_PanierPrincs_IDU",
                table: "PanierPrincs",
                column: "IDU");
        }
    }
}
