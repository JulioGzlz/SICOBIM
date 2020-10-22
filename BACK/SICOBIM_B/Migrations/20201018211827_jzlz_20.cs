using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblInventarios_tblInventariosid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_tblInventariosid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idinventario",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "tblInventariosid",
                table: "TblBienesEquMedico");

            migrationBuilder.AddColumn<int>(
                name: "idInventarioid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_idInventarioid",
                table: "TblBienesEquMedico",
                column: "idInventarioid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblInventarios_idInventarioid",
                table: "TblBienesEquMedico",
                column: "idInventarioid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblInventarios_idInventarioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_idInventarioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idInventarioid",
                table: "TblBienesEquMedico");

            migrationBuilder.AddColumn<int>(
                name: "idinventario",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tblInventariosid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblInventariosid",
                table: "TblBienesEquMedico",
                column: "tblInventariosid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblInventarios_tblInventariosid",
                table: "TblBienesEquMedico",
                column: "tblInventariosid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
