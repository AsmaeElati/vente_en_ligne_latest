using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace venteenligne.Migrations
{
    /// <inheritdoc />
    public partial class lkwa8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paniers_Utilisateurs_IDU",
                table: "Paniers");

            migrationBuilder.DropIndex(
                name: "IX_Paniers_IDU",
                table: "Paniers");

            migrationBuilder.DropColumn(
                name: "IDU",
                table: "Paniers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IDU",
                table: "Paniers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
