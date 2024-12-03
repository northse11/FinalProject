using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class migration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "FavoriteMovie",
                columns: new[] { "ID", "Director", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 5, "Parker Finn", "Horror", 8.5, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smile 2" });

            migrationBuilder.InsertData(
                table: "FavoriteSong",
                columns: new[] { "FavoriteSongID", "Artist", "SongName", "TeamMemberID" },
                values: new object[] { 5, "Black Out The Sun", "Wildfire", 5 });

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "HobbyID", "HobbyActive", "HobbyAge", "HobbyDescription", "HobbyDifficulty", "HobbyName" },
                values: new object[] { 5, false, new DateTime(2010, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playing classical piano music", "Medium", "Playing Piano" });

            migrationBuilder.UpdateData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 1,
                column: "Program",
                value: "Software");

            migrationBuilder.UpdateData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Birthdate", "Program", "Year" },
                values: new object[] { new DateTime(2000, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Software", "Junior" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FavoriteMovie",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "HobbyID", "HobbyActive", "HobbyAge", "HobbyDescription", "HobbyDifficulty", "HobbyName" },
                values: new object[] { 1, true, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hobby....", "Medium", "Hobby" });

            migrationBuilder.UpdateData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 1,
                column: "Program",
                value: "software");

            migrationBuilder.UpdateData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Birthdate", "Program", "Year" },
                values: new object[] { new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "test", "test" });
        }
    }
}
