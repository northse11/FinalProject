using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class innitialwithData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "HobbyID", "HobbyActive", "HobbyAge", "HobbyDescription", "HobbyDifficulty", "HobbyName" },
                values: new object[] { 1, false, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Checkers..", "Easy", "Checkers" });

            migrationBuilder.InsertData(
                table: "TeamMember",
                columns: new[] { "ID", "Birthdate", "FirstName", "LastName", "Program", "Year" },
                values: new object[] { 1, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jon", "Sanjuan", "Software", "Junio" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
