using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class migrationTeamData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2004, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "TeamMember",
                columns: new[] { "ID", "Birthdate", "FirstName", "LastName", "Program", "Year" },
                values: new object[,]
                {
                    { 2, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jack", "Cooper", "test", "test" },
                    { 3, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isan", "Kalhan", "test", "test" },
                    { 4, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Earl", "Schreck", "test", "test" },
                    { 5, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jon", "Soriano Sanjuan", "test", "test" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 1,
                column: "Birthdate",
                value: new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
