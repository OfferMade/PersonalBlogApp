using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalBlogApp.Migrations
{
    /// <inheritdoc />
    public partial class WritingSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Writings",
                columns: new[] { "WritingId", "WritingDescription", "WritingName" },
                values: new object[,]
                {
                    { 1, "denemeiçyazı1", "Deneme" },
                    { 2, "denemeiçyazı2", "Deneme2" },
                    { 3, "denemeiçyazı3", "Deneme3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Writings",
                keyColumn: "WritingId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Writings",
                keyColumn: "WritingId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Writings",
                keyColumn: "WritingId",
                keyValue: 3);
        }
    }
}
