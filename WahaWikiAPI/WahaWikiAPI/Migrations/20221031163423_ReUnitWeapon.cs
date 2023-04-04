using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WahaWikiAPI.Migrations
{
    public partial class ReUnitWeapon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Units_UnitId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_UnitId",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "Weapons");

            migrationBuilder.CreateTable(
                name: "UnitWeaponRelationships",
                columns: table => new
                {
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    WeaponId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitWeaponRelationships", x => new { x.UnitId, x.WeaponId });
                    table.ForeignKey(
                        name: "FK_UnitWeaponRelationships_Units_UnitId",
                        column: x => x.UnitId,
                        principalTable: "Units",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UnitWeaponRelationships_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "WeaponId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UnitWeaponRelationships_WeaponId",
                table: "UnitWeaponRelationships",
                column: "WeaponId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UnitWeaponRelationships");

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "Weapons",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_UnitId",
                table: "Weapons",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Units_UnitId",
                table: "Weapons",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id");
        }
    }
}
