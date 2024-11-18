using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8648), new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8662), new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8663) });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8890), new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8891), "BMW", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8893), new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8894), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8969), new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8970), "i4", "System" },
                    { 2, "System", new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8971), new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8972), "X5", "System" },
                    { 3, "System", new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8973), new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8974), "Prius", "System" },
                    { 4, "System", new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8975), new DateTime(2024, 11, 18, 11, 45, 43, 864, DateTimeKind.Local).AddTicks(8976), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 9, 26, 373, DateTimeKind.Local).AddTicks(9648), new DateTime(2024, 11, 18, 11, 9, 26, 373, DateTimeKind.Local).AddTicks(9666) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 11, 9, 26, 373, DateTimeKind.Local).AddTicks(9668), new DateTime(2024, 11, 18, 11, 9, 26, 373, DateTimeKind.Local).AddTicks(9669) });
        }
    }
}
