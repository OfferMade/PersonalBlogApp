using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalBlogApp.Migrations
{
    /// <inheritdoc />
    public partial class WritingSeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Writings",
                columns: new[] { "WritingId", "WritingDescription", "WritingName" },
                values: new object[] { 4, "denemeiçyazı4", "Deneme4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Writings",
                keyColumn: "WritingId",
                keyValue: 4);
        }
    }
}
