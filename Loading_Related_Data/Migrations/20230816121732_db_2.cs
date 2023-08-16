using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Loading_Related_Data.Migrations
{
    /// <inheritdoc />
    public partial class db_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ankara" },
                    { 2, "Yozgat" }
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "Id", "Discriminator", "Name", "RegionId", "Salary", "Surname" },
                values: new object[,]
                {
                    { 1, "Employee", "Gençay", 1, 1500, "Yıldız" },
                    { 2, "Employee", "Mahmut", 2, 1500, "Yıldız" },
                    { 3, "Employee", "Rıfkı", 1, 1500, "Yıldız" },
                    { 4, "Employee", "Cüneyt", 2, 1500, "Yıldız" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "EmployeeId", "OrderDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 8, 16, 15, 17, 32, 269, DateTimeKind.Local).AddTicks(3457) },
                    { 2, 1, new DateTime(2023, 8, 16, 15, 17, 32, 269, DateTimeKind.Local).AddTicks(3469) },
                    { 3, 2, new DateTime(2023, 8, 16, 15, 17, 32, 269, DateTimeKind.Local).AddTicks(3470) },
                    { 4, 2, new DateTime(2023, 8, 16, 15, 17, 32, 269, DateTimeKind.Local).AddTicks(3471) },
                    { 5, 3, new DateTime(2023, 8, 16, 15, 17, 32, 269, DateTimeKind.Local).AddTicks(3471) },
                    { 6, 3, new DateTime(2023, 8, 16, 15, 17, 32, 269, DateTimeKind.Local).AddTicks(3472) },
                    { 7, 3, new DateTime(2023, 8, 16, 15, 17, 32, 269, DateTimeKind.Local).AddTicks(3473) },
                    { 8, 4, new DateTime(2023, 8, 16, 15, 17, 32, 269, DateTimeKind.Local).AddTicks(3474) },
                    { 9, 4, new DateTime(2023, 8, 16, 15, 17, 32, 269, DateTimeKind.Local).AddTicks(3474) },
                    { 10, 1, new DateTime(2023, 8, 16, 15, 17, 32, 269, DateTimeKind.Local).AddTicks(3475) },
                    { 11, 2, new DateTime(2023, 8, 16, 15, 17, 32, 269, DateTimeKind.Local).AddTicks(3476) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Persons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
