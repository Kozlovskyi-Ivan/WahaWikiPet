using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WahaWikiAPI.Migrations
{
    public partial class NewWeapon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeaponAbilities_Weapons_WeaponId",
                table: "WeaponAbilities");

            migrationBuilder.DropIndex(
                name: "IX_WeaponAbilities_WeaponId",
                table: "WeaponAbilities");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "WeaponAbilities");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Weapons",
                newName: "WeaponId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "WeaponAbilities",
                newName: "WeaponAbilitiesId");

            migrationBuilder.AddColumn<int>(
                name: "TypeRuleText",
                table: "WeaponTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WeaponAbilitiesRelationships",
                columns: table => new
                {
                    WeaponId = table.Column<int>(type: "int", nullable: false),
                    WeaponAbilitiesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponAbilitiesRelationships", x => new { x.WeaponId, x.WeaponAbilitiesId });
                    table.ForeignKey(
                        name: "FK_WeaponAbilitiesRelationships_WeaponAbilities_WeaponAbilitiesId",
                        column: x => x.WeaponAbilitiesId,
                        principalTable: "WeaponAbilities",
                        principalColumn: "WeaponAbilitiesId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeaponAbilitiesRelationships_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "WeaponId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WeaponAbilitiesRelationships_WeaponAbilitiesId",
                table: "WeaponAbilitiesRelationships",
                column: "WeaponAbilitiesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponAbilitiesRelationships");

            migrationBuilder.DropColumn(
                name: "TypeRuleText",
                table: "WeaponTypes");

            migrationBuilder.RenameColumn(
                name: "WeaponId",
                table: "Weapons",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "WeaponAbilitiesId",
                table: "WeaponAbilities",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "WeaponId",
                table: "WeaponAbilities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeaponAbilities_WeaponId",
                table: "WeaponAbilities",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_WeaponAbilities_Weapons_WeaponId",
                table: "WeaponAbilities",
                column: "WeaponId",
                principalTable: "Weapons",
                principalColumn: "Id");
        }
    }
}
