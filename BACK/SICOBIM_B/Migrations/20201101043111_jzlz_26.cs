using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_TblAreaServicio_tblAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_tblAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idServicio",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idSexo",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idestatus",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idrol",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idtipocontrato",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idturno",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "tblAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.AddColumn<int>(
                name: "IdAreaServicioid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catRolid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_IdAreaServicioid",
                table: "CtrlUsuarios",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_catRolid",
                table: "CtrlUsuarios",
                column: "catRolid");

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_TblAreaServicio_IdAreaServicioid",
                table: "CtrlUsuarios",
                column: "IdAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatRol_catRolid",
                table: "CtrlUsuarios",
                column: "catRolid",
                principalTable: "CatRol",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_TblAreaServicio_IdAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatRol_catRolid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_IdAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_catRolid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "IdAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "catRolid",
                table: "CtrlUsuarios");

            migrationBuilder.AddColumn<int>(
                name: "idServicio",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idSexo",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idestatus",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idrol",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idtipocontrato",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idturno",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tblAreaServicioid",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_tblAreaServicioid",
                table: "CtrlUsuarios",
                column: "tblAreaServicioid");

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_TblAreaServicio_tblAreaServicioid",
                table: "CtrlUsuarios",
                column: "tblAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
