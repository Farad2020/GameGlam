using Microsoft.EntityFrameworkCore.Migrations;

namespace GameGlamer.Data.Migrations
{
    public partial class DbContextUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.RenameTable(
                name: "Enrollments",
                newName: "DLCorLootDeals");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "GameDeals");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DLCorLootDeals",
                table: "DLCorLootDeals",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameDeals",
                table: "GameDeals",
                column: "id");

            migrationBuilder.CreateTable(
                name: "UserGames",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGames", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserLoots",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLoots", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserGames");

            migrationBuilder.DropTable(
                name: "UserLoots");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameDeals",
                table: "GameDeals");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DLCorLootDeals",
                table: "DLCorLootDeals");

            migrationBuilder.RenameTable(
                name: "GameDeals",
                newName: "Courses");

            migrationBuilder.RenameTable(
                name: "DLCorLootDeals",
                newName: "Enrollments");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enrollments",
                table: "Enrollments",
                column: "id");
        }
    }
}
