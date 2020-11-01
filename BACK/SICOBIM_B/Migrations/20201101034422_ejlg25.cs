using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class ejlg25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblConfPerfil_CatPermiso_CatPermisoid",
                table: "TblConfPerfil");

            migrationBuilder.DropForeignKey(
                name: "FK_TblConfPerfil_CatRol_idRol",
                table: "TblConfPerfil");

            migrationBuilder.DropIndex(
                name: "IX_TblConfPerfil_CatPermisoid",
                table: "TblConfPerfil");

            migrationBuilder.DropIndex(
                name: "IX_TblConfPerfil_idRol",
                table: "TblConfPerfil");

            migrationBuilder.DropColumn(
                name: "CatPermisoid",
                table: "TblConfPerfil");

            migrationBuilder.DropColumn(
                name: "idRol",
                table: "TblConfPerfil");

            migrationBuilder.AddColumn<int>(
                name: "IdPermisoid",
                table: "TblConfPerfil",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdRolid",
                table: "TblConfPerfil",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_IdPermisoid",
                table: "TblConfPerfil",
                column: "IdPermisoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_IdRolid",
                table: "TblConfPerfil",
                column: "IdRolid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblConfPerfil_CatPermiso_IdPermisoid",
                table: "TblConfPerfil",
                column: "IdPermisoid",
                principalTable: "CatPermiso",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblConfPerfil_CatRol_IdRolid",
                table: "TblConfPerfil",
                column: "IdRolid",
                principalTable: "CatRol",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblConfPerfil_CatPermiso_IdPermisoid",
                table: "TblConfPerfil");

            migrationBuilder.DropForeignKey(
                name: "FK_TblConfPerfil_CatRol_IdRolid",
                table: "TblConfPerfil");

            migrationBuilder.DropIndex(
                name: "IX_TblConfPerfil_IdPermisoid",
                table: "TblConfPerfil");

            migrationBuilder.DropIndex(
                name: "IX_TblConfPerfil_IdRolid",
                table: "TblConfPerfil");

            migrationBuilder.DropColumn(
                name: "IdPermisoid",
                table: "TblConfPerfil");

            migrationBuilder.DropColumn(
                name: "IdRolid",
                table: "TblConfPerfil");

            migrationBuilder.AddColumn<int>(
                name: "CatPermisoid",
                table: "TblConfPerfil",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idRol",
                table: "TblConfPerfil",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_CatPermisoid",
                table: "TblConfPerfil",
                column: "CatPermisoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_idRol",
                table: "TblConfPerfil",
                column: "idRol");

            migrationBuilder.AddForeignKey(
                name: "FK_TblConfPerfil_CatPermiso_CatPermisoid",
                table: "TblConfPerfil",
                column: "CatPermisoid",
                principalTable: "CatPermiso",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblConfPerfil_CatRol_idRol",
                table: "TblConfPerfil",
                column: "idRol",
                principalTable: "CatRol",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
