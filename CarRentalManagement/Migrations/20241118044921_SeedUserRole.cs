using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "b937402d-94d5-4182-8f9c-a831dace5df1", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEE8dlu3J7g3hXcOQjQoJyWS+2gG21BxQ3p114QIjtJIbvsRA62TV4kYuBoRWXbLm0Q==", null, false, "c86042b6-fc37-4c77-87f4-3c3d955d04cc", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(1777), new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(1787) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(1789), new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(1790) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(1979), new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(1981), new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(2066), new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(2069), new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(2071), new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(2073), new DateTime(2024, 11, 18, 12, 49, 20, 507, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(2783), new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(2812), new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(2812) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(3193), new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(3197), new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(3313), new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(3316), new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(3319), new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(3322), new DateTime(2024, 11, 18, 12, 0, 11, 522, DateTimeKind.Local).AddTicks(3322) });
        }
    }
}
