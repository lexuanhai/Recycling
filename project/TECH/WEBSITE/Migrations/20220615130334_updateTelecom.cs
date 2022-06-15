using Microsoft.EntityFrameworkCore.Migrations;

namespace WEBSITE.Migrations
{
    public partial class updateTelecom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Telecom",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    Exchange = table.Column<string>(nullable: true),
                    Point = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telecom", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Telecom");
        }
    }
}
