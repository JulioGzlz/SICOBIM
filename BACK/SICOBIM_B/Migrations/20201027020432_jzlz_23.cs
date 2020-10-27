using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveCambs_IdClaveCambsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_IdClaveCambsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblClaveCambs_IdClaveCambsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdClaveCambsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdClaveCambsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdClaveCambsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdClaveCambsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdClaveCambsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdClaveCambsid",
                table: "TblBienesEquMedico");

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCabmsid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCabmsid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCabmsid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdClaveCabmsid",
                table: "TblBienesSistemas",
                column: "IdClaveCabmsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdClaveCabmsid",
                table: "TblBienesMuebles",
                column: "IdClaveCabmsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdClaveCabmsid",
                table: "TblBienesEquMedico",
                column: "IdClaveCabmsid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveCambs_IdClaveCabmsid",
                table: "TblBienesEquMedico",
                column: "IdClaveCabmsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_IdClaveCabmsid",
                table: "TblBienesMuebles",
                column: "IdClaveCabmsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblClaveCambs_IdClaveCabmsid",
                table: "TblBienesSistemas",
                column: "IdClaveCabmsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveCambs_IdClaveCabmsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_IdClaveCabmsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblClaveCambs_IdClaveCabmsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdClaveCabmsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdClaveCabmsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdClaveCabmsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdClaveCabmsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdClaveCabmsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdClaveCabmsid",
                table: "TblBienesEquMedico");

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCambsid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCambsid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCambsid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdClaveCambsid",
                table: "TblBienesSistemas",
                column: "IdClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdClaveCambsid",
                table: "TblBienesMuebles",
                column: "IdClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdClaveCambsid",
                table: "TblBienesEquMedico",
                column: "IdClaveCambsid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveCambs_IdClaveCambsid",
                table: "TblBienesEquMedico",
                column: "IdClaveCambsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_IdClaveCambsid",
                table: "TblBienesMuebles",
                column: "IdClaveCambsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblClaveCambs_IdClaveCambsid",
                table: "TblBienesSistemas",
                column: "IdClaveCambsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
