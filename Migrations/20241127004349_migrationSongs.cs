using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class migrationSongs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FavoriteSong",
                columns: table => new
                {
                    FavoriteSongID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamMemberID = table.Column<int>(type: "int", nullable: false),
                    SongName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteSong", x => x.FavoriteSongID);
                    table.ForeignKey(
                        name: "FK_FavoriteSong_TeamMember_TeamMemberID",
                        column: x => x.TeamMemberID,
                        principalTable: "TeamMember",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FavoriteSong",
                columns: new[] { "FavoriteSongID", "Artist", "SongName", "TeamMemberID" },
                values: new object[] { 1, "Queen", "Bohemian Rhapsody", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteSong_TeamMemberID",
                table: "FavoriteSong",
                column: "TeamMemberID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteSong");
        }
    }
}
