using Microsoft.EntityFrameworkCore.Migrations;

namespace WeightTracker.Data.Migrations
{
    public partial class ExtendIdentityTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "goalWeight",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "heightInInches",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "goalWeight",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "heightInInches",
                table: "AspNetUsers");
        }
    }
}
