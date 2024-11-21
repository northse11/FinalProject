using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class MigrationWithTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "HobbyID", "HobbyActive", "HobbyAge", "HobbyDescription", "HobbyDifficulty", "HobbyName" },
                values: new object[] { 1, true, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hobby....", "Medium", "Hobby" });

            migrationBuilder.InsertData(
                table: "TeamMember",
                columns: new[] { "ID", "Birthdate", "FirstName", "LastName", "Program", "Year" },
                values: new object[] { 1, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steve", "North", "software", "junior" });
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
