using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class tb7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveCambs_IdClaveCambsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdClaveCambsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdClaveCambsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCabmsid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdClaveCabmsid",
                table: "TblInstrumentalMedico",
                column: "IdClaveCabmsid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveCambs_IdClaveCabmsid",
                table: "TblInstrumentalMedico",
                column: "IdClaveCabmsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveCambs_IdClaveCabmsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdClaveCabmsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdClaveCabmsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCambsid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdClaveCambsid",
                table: "TblInstrumentalMedico",
                column: "IdClaveCambsid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveCambs_IdClaveCambsid",
                table: "TblInstrumentalMedico",
                column: "IdClaveCambsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
