using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EventsManager.Migrations
{
    /// <inheritdoc />
    public partial class addingsomedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Music" },
                    { 2, "Art" },
                    { 3, "Technology" },
                    { 4, "Sports" }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Name", "TemperatureC" },
                values: new object[,]
                {
                    { 1, "New York", null },
                    { 2, "Los Angeles", null },
                    { 3, "Chicago", null }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Date", "Description", "LocationID", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "An evening of smooth jazz.", 1, "Jazz Concert" },
                    { 2, new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Showcasing modern art.", 2, "Art Exhibition" },
                    { 3, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latest in tech innovations.", 3, "Tech Conference" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
