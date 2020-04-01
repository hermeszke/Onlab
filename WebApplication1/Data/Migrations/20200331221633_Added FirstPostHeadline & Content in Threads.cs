using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Data.Migrations
{
    public partial class AddedFirstPostHeadlineContentinThreads : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstPostContent",
                table: "Threads",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FirstPostHeadline",
                table: "Threads",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstPostContent",
                table: "Threads");

            migrationBuilder.DropColumn(
                name: "FirstPostHeadline",
                table: "Threads");
        }
    }
}
