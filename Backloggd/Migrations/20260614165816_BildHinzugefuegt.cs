using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backloggd.Migrations
{
    /// <inheritdoc />
    public partial class BildHinzugefuegt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Bild",
                schema: "HauserKarlHeinz_3CK",
                table: "Spiel",
                type: "bytea",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bild",
                schema: "HauserKarlHeinz_3CK",
                table: "Spiel");
        }
    }
}
