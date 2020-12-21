using Microsoft.EntityFrameworkCore.Migrations;

namespace Homework6.DAL.Migrations
{
    public partial class ChangeBuilding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfFlat",
                table: "Buildings",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfFlat",
                table: "Buildings");
        }
    }
}
