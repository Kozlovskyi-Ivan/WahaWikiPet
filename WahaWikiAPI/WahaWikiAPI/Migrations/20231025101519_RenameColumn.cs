using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WahaWikiAPI.Migrations
{
    public partial class RenameColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatLines_Units_UnitId",
                table: "StatLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_UnitTypes_UnitTypeId",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitAbilitiesRelationships",
                table: "UnitAbilitiesRelationships");

            migrationBuilder.DropIndex(
                name: "IX_UnitAbilitiesRelationships_AbilitiesId",
                table: "UnitAbilitiesRelationships");

            migrationBuilder.RenameColumn(
                name: "WeaponAbilitiesId",
                table: "WeaponAbilities",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "UnitTypeId",
                table: "Units",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UnitId",
                table: "StatLines",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitAbilitiesRelationships",
                table: "UnitAbilitiesRelationships",
                columns: new[] { "AbilitiesId", "UnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_UnitAbilitiesRelationships_UnitId",
                table: "UnitAbilitiesRelationships",
                column: "UnitId");

            migrationBuilder.AddForeignKey(
                name: "FK_StatLines_Units_UnitId",
                table: "StatLines",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Units_UnitTypes_UnitTypeId",
                table: "Units",
                column: "UnitTypeId",
                principalTable: "UnitTypes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StatLines_Units_UnitId",
                table: "StatLines");

            migrationBuilder.DropForeignKey(
                name: "FK_Units_UnitTypes_UnitTypeId",
                table: "Units");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UnitAbilitiesRelationships",
                table: "UnitAbilitiesRelationships");

            migrationBuilder.DropIndex(
                name: "IX_UnitAbilitiesRelationships_UnitId",
                table: "UnitAbilitiesRelationships");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "WeaponAbilities",
                newName: "WeaponAbilitiesId");

            migrationBuilder.AlterColumn<int>(
                name: "UnitTypeId",
                table: "Units",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UnitId",
                table: "StatLines",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UnitAbilitiesRelationships",
                table: "UnitAbilitiesRelationships",
                columns: new[] { "UnitId", "AbilitiesId" });

            migrationBuilder.CreateIndex(
                name: "IX_UnitAbilitiesRelationships_AbilitiesId",
                table: "UnitAbilitiesRelationships",
                column: "AbilitiesId");

            migrationBuilder.AddForeignKey(
                name: "FK_StatLines_Units_UnitId",
                table: "StatLines",
                column: "UnitId",
                principalTable: "Units",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Units_UnitTypes_UnitTypeId",
                table: "Units",
                column: "UnitTypeId",
                principalTable: "UnitTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
