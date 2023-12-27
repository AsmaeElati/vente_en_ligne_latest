using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace venteenligne.Migrations
{
    /// <inheritdoc />
    public partial class lkwa7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Paniers_IDU",
                table: "Paniers",
                column: "IDU");

            migrationBuilder.AddForeignKey(
                name: "FK_Paniers_Utilisateurs_IDU",
                table: "Paniers",
                column: "IDU",
                principalTable: "Utilisateurs",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paniers_Utilisateurs_IDU",
                table: "Paniers");

            migrationBuilder.DropIndex(
                name: "IX_Paniers_IDU",
                table: "Paniers");
        }
    }
}
