using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblConfPerfil_CatPermiso_idPermiso",
                table: "TblConfPerfil");

            migrationBuilder.DropIndex(
                name: "IX_TblConfPerfil_idPermiso",
                table: "TblConfPerfil");

            migrationBuilder.DropColumn(
                name: "idPermiso",
                table: "TblConfPerfil");

            migrationBuilder.AddColumn<int>(
                name: "CatPermisoid",
                table: "TblConfPerfil",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idUsuarioAlta",
                table: "TblConfPerfil",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_CatPermisoid",
                table: "TblConfPerfil",
                column: "CatPermisoid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblConfPerfil_CatPermiso_CatPermisoid",
                table: "TblConfPerfil",
                column: "CatPermisoid",
                principalTable: "CatPermiso",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblConfPerfil_CatPermiso_CatPermisoid",
                table: "TblConfPerfil");

            migrationBuilder.DropIndex(
                name: "IX_TblConfPerfil_CatPermisoid",
                table: "TblConfPerfil");

            migrationBuilder.DropColumn(
                name: "CatPermisoid",
                table: "TblConfPerfil");

            migrationBuilder.DropColumn(
                name: "idUsuarioAlta",
                table: "TblConfPerfil");

            migrationBuilder.AddColumn<int>(
                name: "idPermiso",
                table: "TblConfPerfil",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_idPermiso",
                table: "TblConfPerfil",
                column: "idPermiso");

            migrationBuilder.AddForeignKey(
                name: "FK_TblConfPerfil_CatPermiso_idPermiso",
                table: "TblConfPerfil",
                column: "idPermiso",
                principalTable: "CatPermiso",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
