using Microsoft.EntityFrameworkCore.Migrations;

namespace Traveltech.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SymbolId",
                table: "SocialMedias");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SymbolId",
                table: "SocialMedias",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
