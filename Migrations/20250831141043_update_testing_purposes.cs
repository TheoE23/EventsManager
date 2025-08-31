using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EventsManager.Migrations
{
    /// <inheritdoc />
    public partial class update_testing_purposes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "LocationID", "Name" },
                values: new object[] { 4, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Local teams face off.", 1, "Football Match" });

            migrationBuilder.InsertData(
                table: "CategoryEvent",
                columns: new[] { "CategoriesId", "EventsId" },
                values: new object[] { 4, 4 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryEvent",
                keyColumns: new[] { "CategoriesId", "EventsId" },
                keyValues: new object[] { 4, 4 });

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
