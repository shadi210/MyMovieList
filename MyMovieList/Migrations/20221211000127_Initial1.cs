using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyMovieList.Migrations
{
    /// <inheritdoc />
    public partial class Initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userEmail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userEmail);
                });

            migrationBuilder.CreateTable(
                name: "Movies_Watched",
                columns: table => new
                {
                    movieId = table.Column<int>(type: "int", nullable: false),
                    userEmail = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    watched = table.Column<bool>(type: "bit", nullable: false),
                    score = table.Column<int>(type: "int", nullable: false),
                    favourite = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies_Watched", x => new { x.userEmail, x.movieId });
                    table.ForeignKey(
                        name: "FK_Movies_Watched_Movies_movieId",
                        column: x => x.movieId,
                        principalTable: "Movies",
                        principalColumn: "movieId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Watched_Users_userEmail",
                        column: x => x.userEmail,
                        principalTable: "Users",
                        principalColumn: "userEmail",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movies_Watched_movieId",
                table: "Movies_Watched",
                column: "movieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies_Watched");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
