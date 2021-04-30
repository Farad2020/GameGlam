using Microsoft.EntityFrameworkCore.Migrations;

namespace GameGlamer.Data.Migrations
{
    public partial class AddingNewModelsGamesAndDLCOrLoot : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    worth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    instructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    open_giveaway_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    published_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    platforms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    users = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gamerpower_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    open_giveaway = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    worth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    instructions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    open_giveaway_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    published_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    platforms = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    users = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    gamerpower_url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    open_giveaway = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Enrollments");
        }
    }
}
