using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventsManager.Migrations
{
    /// <inheritdoc />
    public partial class Seedingjoinedtabletestingrelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryEvent",
                columns: new[] { "CategoriesId", "EventsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryEvent",
                keyColumns: new[] { "CategoriesId", "EventsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CategoryEvent",
                keyColumns: new[] { "CategoriesId", "EventsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "CategoryEvent",
                keyColumns: new[] { "CategoriesId", "EventsId" },
                keyValues: new object[] { 3, 3 });
        }
    }
}
