using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class migrationbreakfast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "BreakfastItems",
                columns: table => new
                {
                    breakfastID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    breakfastItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    breakfastItemDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    breakfastItemPrice = table.Column<int>(type: "int", nullable: false),
                    breakfastItemQuantity = table.Column<int>(type: "int", nullable: false),
                    breakfastTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreakfastItems", x => x.breakfastID);
                });

            migrationBuilder.InsertData(
                table: "FavoriteMovie",
                columns: new[] { "ID", "Director", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 2, "Irvin Kershner", "Sci-Fi", 8.6999999999999993, new DateTime(1980, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Star Wars: Episode V - The Empire Strikes Back" },
                    { 3, "M Night Shyamalan", "Sci-Fi", 10.0, new DateTime(2002, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Signs" },
                    { 4, "Parker Finn", "Horror", 8.5, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smile 2" }
                });

            migrationBuilder.UpdateData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 1,
                column: "TeamMemberID",
                value: 4);

            migrationBuilder.InsertData(
                table: "FavoriteSong",
                columns: new[] { "FavoriteSongID", "Artist", "SongName", "TeamMemberID" },
                values: new object[,]
                {
                    { 2, "Duran Duran", "Invisible", 2 },
                    { 3, "Eagles", "Lyin' Eyes", 1 },
                    { 4, "Black Out The Sun", "Wildfire", 5 }
                });

            migrationBuilder.InsertData(
                table: "Hobby",
                columns: new[] { "HobbyID", "HobbyActive", "HobbyAge", "HobbyDescription", "HobbyDifficulty", "HobbyName" },
                values: new object[,]
                {
                    { 1, true, new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hobby....", "Medium", "Hobby" },
                    { 2, true, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playing the trumpet for the University of Cincinnati Marching Band.", "Medium", "Marching Band" },
                    { 3, true, new DateTime(2020, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Learning new recipes and cooking new foods", "Medium", "Cooking" },
                    { 4, false, new DateTime(2010, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Playing classical piano music", "Medium", "Playing Piano" }
                });

            migrationBuilder.UpdateData(
                table: "TeamMember",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Birthdate", "Program" },
                values: new object[] { new DateTime(2003, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "IT" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreakfastItems");

            migrationBuilder.DeleteData(
                table: "FavoriteMovie",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FavoriteMovie",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FavoriteMovie",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hobby",
                keyColumn: "HobbyID",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "FavoriteMovie",
                columns: new[] { "ID", "Director", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 5, "Parker Finn", "Horror", 8.5, new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Smile 2" });

            migrationBuilder.UpdateData(
                table: "FavoriteSong",
                keyColumn: "FavoriteSongID",
                keyValue: 1,
                column: "TeamMemberID",
                value: 1);

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
                keyValue: 2,
                columns: new[] { "Birthdate", "Program" },
                values: new object[] { new DateTime(2015, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "test" });
        }
    }
}
