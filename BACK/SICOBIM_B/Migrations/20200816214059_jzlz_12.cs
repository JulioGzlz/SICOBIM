using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatTipoDeBien_CatTipoDeBienid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_TblBienes_TblBienesid",
                table: "TblBienes");

            migrationBuilder.DropIndex(
                name: "IX_TblBienes_TblBienesid",
                table: "TblBienes");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_CatTipoDeBienid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "TblBienesid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienid",
                table: "CtrlUsuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TblBienesid",
                table: "TblBienes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienid",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_TblBienesid",
                table: "TblBienes",
                column: "TblBienesid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_CatTipoDeBienid",
                table: "CtrlUsuarios",
                column: "CatTipoDeBienid");

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatTipoDeBien_CatTipoDeBienid",
                table: "CtrlUsuarios",
                column: "CatTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_TblBienes_TblBienesid",
                table: "TblBienes",
                column: "TblBienesid",
                principalTable: "TblBienes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
