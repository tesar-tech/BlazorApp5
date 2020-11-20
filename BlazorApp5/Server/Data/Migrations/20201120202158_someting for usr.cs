using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorApp5.Server.Data.Migrations
{
    public partial class sometingforusr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SomethingForUser",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SomethingForUser",
                table: "AspNetUsers");
        }
    }
}
