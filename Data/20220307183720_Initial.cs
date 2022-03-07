using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Data
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    userId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    username = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    password = table.Column<string>(type: "TEXT", maxLength: 15, nullable: true),
                    Roles = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.userId);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "userId", "Roles", "password", "username" },
                values: new object[] { 1, null, "iLoveMax123", "Kacper2022" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUsers");
        }
    }
}
