using Microsoft.EntityFrameworkCore.Migrations;

namespace Cpagemini.EFCoreCodeFirst.Migrations
{
    public partial class RemoveIsReadFromBooks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRead",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRead",
                table: "Books",
                type: "bit",
                nullable: true);
        }
    }
}
