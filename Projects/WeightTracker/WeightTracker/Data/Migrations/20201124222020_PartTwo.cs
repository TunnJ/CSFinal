using Microsoft.EntityFrameworkCore.Migrations;

namespace WeightTracker.Data.Migrations
{
    public partial class PartTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "goalWeight",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "heightInInches",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "goalWeight",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "heightInInches",
                table: "AspNetUsers");
        }
    }
}
