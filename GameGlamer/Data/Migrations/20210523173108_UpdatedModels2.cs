using Microsoft.EntityFrameworkCore.Migrations;

namespace GameGlamer.Data.Migrations
{
    public partial class UpdatedModels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "gameId",
                table: "UserLoots",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "UserLoots",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "gameId",
                table: "UserGames",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "userId",
                table: "UserGames",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gameId",
                table: "UserLoots");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "UserLoots");

            migrationBuilder.DropColumn(
                name: "gameId",
                table: "UserGames");

            migrationBuilder.DropColumn(
                name: "userId",
                table: "UserGames");
        }
    }
}
