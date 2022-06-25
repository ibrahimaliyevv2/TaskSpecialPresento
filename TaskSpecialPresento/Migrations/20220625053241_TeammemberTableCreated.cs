using Microsoft.EntityFrameworkCore.Migrations;

namespace TaskSpecialPresento.Migrations
{
    public partial class TeammemberTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teammembers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 30, nullable: false),
                    Position = table.Column<string>(maxLength: 30, nullable: true),
                    TwitterUsername = table.Column<string>(maxLength: 100, nullable: true),
                    FacebookUsername = table.Column<string>(maxLength: 100, nullable: true),
                    InstagramUsername = table.Column<string>(maxLength: 100, nullable: true),
                    LinkedinUsername = table.Column<string>(maxLength: 100, nullable: true),
                    ImageName = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teammembers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teammembers");
        }
    }
}
