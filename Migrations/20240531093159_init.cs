using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalBlogApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Writings",
                columns: table => new
                {
                    WritingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WritingName = table.Column<string>(type: "TEXT", nullable: false),
                    WritingDescription = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Writings", x => x.WritingId);
                });

            migrationBuilder.InsertData(
                table: "Writings",
                columns: new[] { "WritingId", "WritingDescription", "WritingName" },
                values: new object[,]
                {
                    { 1, "denemeiçyazı1", "Deneme" },
                    { 2, "denemeiçyazı2", "Deneme2" },
                    { 3, "denemeiçyazı3", "Deneme3" },
                    { 4, "denemeiçyazı4", "Deneme4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Writings");
        }
    }
}
