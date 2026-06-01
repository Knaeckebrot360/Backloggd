using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Backloggd.Migrations
{
    /// <inheritdoc />
    public partial class erste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "HauserKarlHeinz_3CK");

            migrationBuilder.CreateTable(
                name: "Spiel",
                schema: "HauserKarlHeinz_3CK",
                columns: table => new
                {
                    SpielId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Titel = table.Column<string>(type: "text", nullable: false),
                    Genre = table.Column<string>(type: "text", nullable: false),
                    Entwickler = table.Column<string>(type: "text", nullable: false),
                    Publisher = table.Column<string>(type: "text", nullable: false),
                    Beschreibung = table.Column<string>(type: "text", nullable: false),
                    Release = table.Column<string>(type: "text", nullable: false),
                    DurchschnittsBewertung = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spiel", x => x.SpielId);
                });

            migrationBuilder.CreateTable(
                name: "Review",
                schema: "HauserKarlHeinz_3CK",
                columns: table => new
                {
                    ReviewId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ReviewText = table.Column<string>(type: "text", nullable: false),
                    Rating = table.Column<int>(type: "integer", nullable: false),
                    User = table.Column<string>(type: "text", nullable: false),
                    SpielId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Review_Spiel_SpielId",
                        column: x => x.SpielId,
                        principalSchema: "HauserKarlHeinz_3CK",
                        principalTable: "Spiel",
                        principalColumn: "SpielId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_SpielId",
                schema: "HauserKarlHeinz_3CK",
                table: "Review",
                column: "SpielId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review",
                schema: "HauserKarlHeinz_3CK");

            migrationBuilder.DropTable(
                name: "Spiel",
                schema: "HauserKarlHeinz_3CK");
        }
    }
}
