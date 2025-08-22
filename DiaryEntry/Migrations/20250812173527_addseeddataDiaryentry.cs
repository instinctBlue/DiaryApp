using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class addseeddataDiaryentry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with Joe", new DateTime(2025, 8, 12, 20, 35, 26, 841, DateTimeKind.Local).AddTicks(6065), "Went Hiking" },
                    { 2, "Went shopping with Joe", new DateTime(2025, 8, 12, 20, 35, 26, 841, DateTimeKind.Local).AddTicks(6616), "Went Shopping" },
                    { 3, "Went diving with Joe", new DateTime(2025, 8, 12, 20, 35, 26, 841, DateTimeKind.Local).AddTicks(6624), "Went Diving" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
