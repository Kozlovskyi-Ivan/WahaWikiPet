using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WahaWikiAPI.Migrations
{
    public partial class wTypeFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfShot",
                table: "WeaponTypes");

            migrationBuilder.AddColumn<string>(
                name: "NumberOfShot",
                table: "Weapons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfShot",
                table: "Weapons");

            migrationBuilder.AddColumn<string>(
                name: "NumberOfShot",
                table: "WeaponTypes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
