using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hobby",
                columns: table => new
                {
                    HobbyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HobbyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HobbyDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HobbyAge = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HobbyActive = table.Column<bool>(type: "bit", nullable: false),
                    HobbyDifficulty = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobby", x => x.HobbyID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hobby");
        }
    }
}
