using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_15 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_catEstatus_catEstatusid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_catSexo_catSexoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_tblAreaServicio_tblAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_tblAreaServicio_catAreas_catareaid",
                table: "tblAreaServicio");

            migrationBuilder.DropForeignKey(
                name: "FK_tblAreaServicio_CatServicio_catservicioid",
                table: "tblAreaServicio");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_catGarantia_catGarantiaid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_catTipoEntrada_catTipoEntradaid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_catTipoPartida_catTipoPartidaid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_catUnidadDestino_catUnidadDestinoid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_tblAreaServicio_tblAreaServicioid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_tblResguardatarios_tblResguardatariosid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_tblResguardatarios_CatServicio_CatServicioid",
                table: "tblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_tblResguardatarios_tblAreaServicio_TblAreaServicioid",
                table: "tblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_tblResguardatarios_catEstatus_catEstatusid",
                table: "tblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_tblResguardatarios_catSexo_catSexoid",
                table: "tblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_tblResguardatarios_CatTipoContrato_catTipoContratoid",
                table: "tblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_tblResguardatarios_CatTurno_catTurnoid",
                table: "tblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_tblSalidaBien_catTipoSalida_catTipoSalidaid",
                table: "tblSalidaBien");

            migrationBuilder.DropForeignKey(
                name: "FK_tblSalidaBien_catUnidadDestino_catUnidadDestinoid",
                table: "tblSalidaBien");

            migrationBuilder.DropForeignKey(
                name: "FK_tblSalidaBien_TblBienes_tblbienesid",
                table: "tblSalidaBien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblSalidaBien",
                table: "tblSalidaBien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblResguardatarios",
                table: "tblResguardatarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblAreaServicio",
                table: "tblAreaServicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_catUnidadDestino",
                table: "catUnidadDestino");

            migrationBuilder.DropPrimaryKey(
                name: "PK_catTipoSalida",
                table: "catTipoSalida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_catTipoPartida",
                table: "catTipoPartida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_catTipoEntrada",
                table: "catTipoEntrada");

            migrationBuilder.DropPrimaryKey(
                name: "PK_catSexo",
                table: "catSexo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_catGarantia",
                table: "catGarantia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_catEstatus",
                table: "catEstatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_catAreas",
                table: "catAreas");

            migrationBuilder.RenameTable(
                name: "tblSalidaBien",
                newName: "TblSalidaBien");

            migrationBuilder.RenameTable(
                name: "tblResguardatarios",
                newName: "TblResguardatarios");

            migrationBuilder.RenameTable(
                name: "tblAreaServicio",
                newName: "TblAreaServicio");

            migrationBuilder.RenameTable(
                name: "catUnidadDestino",
                newName: "CatUnidadDestino");

            migrationBuilder.RenameTable(
                name: "catTipoSalida",
                newName: "CatTipoSalida");

            migrationBuilder.RenameTable(
                name: "catTipoPartida",
                newName: "CatTipoPartida");

            migrationBuilder.RenameTable(
                name: "catTipoEntrada",
                newName: "CatTipoEntrada");

            migrationBuilder.RenameTable(
                name: "catSexo",
                newName: "CatSexo");

            migrationBuilder.RenameTable(
                name: "catGarantia",
                newName: "CatGarantia");

            migrationBuilder.RenameTable(
                name: "catEstatus",
                newName: "CatEstatus");

            migrationBuilder.RenameTable(
                name: "catAreas",
                newName: "CatArea");

            migrationBuilder.RenameIndex(
                name: "IX_tblSalidaBien_tblbienesid",
                table: "TblSalidaBien",
                newName: "IX_TblSalidaBien_tblbienesid");

            migrationBuilder.RenameIndex(
                name: "IX_tblSalidaBien_catUnidadDestinoid",
                table: "TblSalidaBien",
                newName: "IX_TblSalidaBien_catUnidadDestinoid");

            migrationBuilder.RenameIndex(
                name: "IX_tblSalidaBien_catTipoSalidaid",
                table: "TblSalidaBien",
                newName: "IX_TblSalidaBien_catTipoSalidaid");

            migrationBuilder.RenameIndex(
                name: "IX_tblResguardatarios_catTurnoid",
                table: "TblResguardatarios",
                newName: "IX_TblResguardatarios_catTurnoid");

            migrationBuilder.RenameIndex(
                name: "IX_tblResguardatarios_catTipoContratoid",
                table: "TblResguardatarios",
                newName: "IX_TblResguardatarios_catTipoContratoid");

            migrationBuilder.RenameIndex(
                name: "IX_tblResguardatarios_catSexoid",
                table: "TblResguardatarios",
                newName: "IX_TblResguardatarios_catSexoid");

            migrationBuilder.RenameIndex(
                name: "IX_tblResguardatarios_catEstatusid",
                table: "TblResguardatarios",
                newName: "IX_TblResguardatarios_catEstatusid");

            migrationBuilder.RenameIndex(
                name: "IX_tblResguardatarios_TblAreaServicioid",
                table: "TblResguardatarios",
                newName: "IX_TblResguardatarios_TblAreaServicioid");

            migrationBuilder.RenameIndex(
                name: "IX_tblResguardatarios_CatServicioid",
                table: "TblResguardatarios",
                newName: "IX_TblResguardatarios_CatServicioid");

            migrationBuilder.RenameIndex(
                name: "IX_tblAreaServicio_catservicioid",
                table: "TblAreaServicio",
                newName: "IX_TblAreaServicio_catservicioid");

            migrationBuilder.RenameIndex(
                name: "IX_tblAreaServicio_catareaid",
                table: "TblAreaServicio",
                newName: "IX_TblAreaServicio_catareaid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblSalidaBien",
                table: "TblSalidaBien",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblResguardatarios",
                table: "TblResguardatarios",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblAreaServicio",
                table: "TblAreaServicio",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatUnidadDestino",
                table: "CatUnidadDestino",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatTipoSalida",
                table: "CatTipoSalida",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatTipoPartida",
                table: "CatTipoPartida",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatTipoEntrada",
                table: "CatTipoEntrada",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatSexo",
                table: "CatSexo",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatGarantia",
                table: "CatGarantia",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatEstatus",
                table: "CatEstatus",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatArea",
                table: "CatArea",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatEstatus_catEstatusid",
                table: "CtrlUsuarios",
                column: "catEstatusid",
                principalTable: "CatEstatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatSexo_catSexoid",
                table: "CtrlUsuarios",
                column: "catSexoid",
                principalTable: "CatSexo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_TblAreaServicio_tblAreaServicioid",
                table: "CtrlUsuarios",
                column: "tblAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblAreaServicio_CatArea_catareaid",
                table: "TblAreaServicio",
                column: "catareaid",
                principalTable: "CatArea",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblAreaServicio_CatServicio_catservicioid",
                table: "TblAreaServicio",
                column: "catservicioid",
                principalTable: "CatServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_CatGarantia_catGarantiaid",
                table: "TblBienes",
                column: "catGarantiaid",
                principalTable: "CatGarantia",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_CatTipoEntrada_catTipoEntradaid",
                table: "TblBienes",
                column: "catTipoEntradaid",
                principalTable: "CatTipoEntrada",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_CatTipoPartida_catTipoPartidaid",
                table: "TblBienes",
                column: "catTipoPartidaid",
                principalTable: "CatTipoPartida",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_CatUnidadDestino_catUnidadDestinoid",
                table: "TblBienes",
                column: "catUnidadDestinoid",
                principalTable: "CatUnidadDestino",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_TblAreaServicio_tblAreaServicioid",
                table: "TblBienes",
                column: "tblAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_TblResguardatarios_tblResguardatariosid",
                table: "TblBienes",
                column: "tblResguardatariosid",
                principalTable: "TblResguardatarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblResguardatarios_CatServicio_CatServicioid",
                table: "TblResguardatarios",
                column: "CatServicioid",
                principalTable: "CatServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblResguardatarios_TblAreaServicio_TblAreaServicioid",
                table: "TblResguardatarios",
                column: "TblAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblResguardatarios_CatEstatus_catEstatusid",
                table: "TblResguardatarios",
                column: "catEstatusid",
                principalTable: "CatEstatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblResguardatarios_CatSexo_catSexoid",
                table: "TblResguardatarios",
                column: "catSexoid",
                principalTable: "CatSexo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblResguardatarios_CatTipoContrato_catTipoContratoid",
                table: "TblResguardatarios",
                column: "catTipoContratoid",
                principalTable: "CatTipoContrato",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblResguardatarios_CatTurno_catTurnoid",
                table: "TblResguardatarios",
                column: "catTurnoid",
                principalTable: "CatTurno",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_CatTipoSalida_catTipoSalidaid",
                table: "TblSalidaBien",
                column: "catTipoSalidaid",
                principalTable: "CatTipoSalida",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_CatUnidadDestino_catUnidadDestinoid",
                table: "TblSalidaBien",
                column: "catUnidadDestinoid",
                principalTable: "CatUnidadDestino",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_TblBienes_tblbienesid",
                table: "TblSalidaBien",
                column: "tblbienesid",
                principalTable: "TblBienes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatEstatus_catEstatusid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatSexo_catSexoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_TblAreaServicio_tblAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblAreaServicio_CatArea_catareaid",
                table: "TblAreaServicio");

            migrationBuilder.DropForeignKey(
                name: "FK_TblAreaServicio_CatServicio_catservicioid",
                table: "TblAreaServicio");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_CatGarantia_catGarantiaid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_CatTipoEntrada_catTipoEntradaid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_CatTipoPartida_catTipoPartidaid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_CatUnidadDestino_catUnidadDestinoid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_TblAreaServicio_tblAreaServicioid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_TblResguardatarios_tblResguardatariosid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatServicio_CatServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_TblAreaServicio_TblAreaServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatEstatus_catEstatusid",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatSexo_catSexoid",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatTipoContrato_catTipoContratoid",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatTurno_catTurnoid",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_CatTipoSalida_catTipoSalidaid",
                table: "TblSalidaBien");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_CatUnidadDestino_catUnidadDestinoid",
                table: "TblSalidaBien");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_TblBienes_tblbienesid",
                table: "TblSalidaBien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblSalidaBien",
                table: "TblSalidaBien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblResguardatarios",
                table: "TblResguardatarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblAreaServicio",
                table: "TblAreaServicio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatUnidadDestino",
                table: "CatUnidadDestino");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatTipoSalida",
                table: "CatTipoSalida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatTipoPartida",
                table: "CatTipoPartida");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatTipoEntrada",
                table: "CatTipoEntrada");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatSexo",
                table: "CatSexo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatGarantia",
                table: "CatGarantia");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatEstatus",
                table: "CatEstatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatArea",
                table: "CatArea");

            migrationBuilder.RenameTable(
                name: "TblSalidaBien",
                newName: "tblSalidaBien");

            migrationBuilder.RenameTable(
                name: "TblResguardatarios",
                newName: "tblResguardatarios");

            migrationBuilder.RenameTable(
                name: "TblAreaServicio",
                newName: "tblAreaServicio");

            migrationBuilder.RenameTable(
                name: "CatUnidadDestino",
                newName: "catUnidadDestino");

            migrationBuilder.RenameTable(
                name: "CatTipoSalida",
                newName: "catTipoSalida");

            migrationBuilder.RenameTable(
                name: "CatTipoPartida",
                newName: "catTipoPartida");

            migrationBuilder.RenameTable(
                name: "CatTipoEntrada",
                newName: "catTipoEntrada");

            migrationBuilder.RenameTable(
                name: "CatSexo",
                newName: "catSexo");

            migrationBuilder.RenameTable(
                name: "CatGarantia",
                newName: "catGarantia");

            migrationBuilder.RenameTable(
                name: "CatEstatus",
                newName: "catEstatus");

            migrationBuilder.RenameTable(
                name: "CatArea",
                newName: "catAreas");

            migrationBuilder.RenameIndex(
                name: "IX_TblSalidaBien_tblbienesid",
                table: "tblSalidaBien",
                newName: "IX_tblSalidaBien_tblbienesid");

            migrationBuilder.RenameIndex(
                name: "IX_TblSalidaBien_catUnidadDestinoid",
                table: "tblSalidaBien",
                newName: "IX_tblSalidaBien_catUnidadDestinoid");

            migrationBuilder.RenameIndex(
                name: "IX_TblSalidaBien_catTipoSalidaid",
                table: "tblSalidaBien",
                newName: "IX_tblSalidaBien_catTipoSalidaid");

            migrationBuilder.RenameIndex(
                name: "IX_TblResguardatarios_catTurnoid",
                table: "tblResguardatarios",
                newName: "IX_tblResguardatarios_catTurnoid");

            migrationBuilder.RenameIndex(
                name: "IX_TblResguardatarios_catTipoContratoid",
                table: "tblResguardatarios",
                newName: "IX_tblResguardatarios_catTipoContratoid");

            migrationBuilder.RenameIndex(
                name: "IX_TblResguardatarios_catSexoid",
                table: "tblResguardatarios",
                newName: "IX_tblResguardatarios_catSexoid");

            migrationBuilder.RenameIndex(
                name: "IX_TblResguardatarios_catEstatusid",
                table: "tblResguardatarios",
                newName: "IX_tblResguardatarios_catEstatusid");

            migrationBuilder.RenameIndex(
                name: "IX_TblResguardatarios_TblAreaServicioid",
                table: "tblResguardatarios",
                newName: "IX_tblResguardatarios_TblAreaServicioid");

            migrationBuilder.RenameIndex(
                name: "IX_TblResguardatarios_CatServicioid",
                table: "tblResguardatarios",
                newName: "IX_tblResguardatarios_CatServicioid");

            migrationBuilder.RenameIndex(
                name: "IX_TblAreaServicio_catservicioid",
                table: "tblAreaServicio",
                newName: "IX_tblAreaServicio_catservicioid");

            migrationBuilder.RenameIndex(
                name: "IX_TblAreaServicio_catareaid",
                table: "tblAreaServicio",
                newName: "IX_tblAreaServicio_catareaid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblSalidaBien",
                table: "tblSalidaBien",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblResguardatarios",
                table: "tblResguardatarios",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblAreaServicio",
                table: "tblAreaServicio",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_catUnidadDestino",
                table: "catUnidadDestino",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_catTipoSalida",
                table: "catTipoSalida",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_catTipoPartida",
                table: "catTipoPartida",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_catTipoEntrada",
                table: "catTipoEntrada",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_catSexo",
                table: "catSexo",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_catGarantia",
                table: "catGarantia",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_catEstatus",
                table: "catEstatus",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_catAreas",
                table: "catAreas",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_catEstatus_catEstatusid",
                table: "CtrlUsuarios",
                column: "catEstatusid",
                principalTable: "catEstatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_catSexo_catSexoid",
                table: "CtrlUsuarios",
                column: "catSexoid",
                principalTable: "catSexo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_tblAreaServicio_tblAreaServicioid",
                table: "CtrlUsuarios",
                column: "tblAreaServicioid",
                principalTable: "tblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAreaServicio_catAreas_catareaid",
                table: "tblAreaServicio",
                column: "catareaid",
                principalTable: "catAreas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblAreaServicio_CatServicio_catservicioid",
                table: "tblAreaServicio",
                column: "catservicioid",
                principalTable: "CatServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_catGarantia_catGarantiaid",
                table: "TblBienes",
                column: "catGarantiaid",
                principalTable: "catGarantia",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_catTipoEntrada_catTipoEntradaid",
                table: "TblBienes",
                column: "catTipoEntradaid",
                principalTable: "catTipoEntrada",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_catTipoPartida_catTipoPartidaid",
                table: "TblBienes",
                column: "catTipoPartidaid",
                principalTable: "catTipoPartida",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_catUnidadDestino_catUnidadDestinoid",
                table: "TblBienes",
                column: "catUnidadDestinoid",
                principalTable: "catUnidadDestino",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_tblAreaServicio_tblAreaServicioid",
                table: "TblBienes",
                column: "tblAreaServicioid",
                principalTable: "tblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_tblResguardatarios_tblResguardatariosid",
                table: "TblBienes",
                column: "tblResguardatariosid",
                principalTable: "tblResguardatarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblResguardatarios_CatServicio_CatServicioid",
                table: "tblResguardatarios",
                column: "CatServicioid",
                principalTable: "CatServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblResguardatarios_tblAreaServicio_TblAreaServicioid",
                table: "tblResguardatarios",
                column: "TblAreaServicioid",
                principalTable: "tblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblResguardatarios_catEstatus_catEstatusid",
                table: "tblResguardatarios",
                column: "catEstatusid",
                principalTable: "catEstatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblResguardatarios_catSexo_catSexoid",
                table: "tblResguardatarios",
                column: "catSexoid",
                principalTable: "catSexo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblResguardatarios_CatTipoContrato_catTipoContratoid",
                table: "tblResguardatarios",
                column: "catTipoContratoid",
                principalTable: "CatTipoContrato",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblResguardatarios_CatTurno_catTurnoid",
                table: "tblResguardatarios",
                column: "catTurnoid",
                principalTable: "CatTurno",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblSalidaBien_catTipoSalida_catTipoSalidaid",
                table: "tblSalidaBien",
                column: "catTipoSalidaid",
                principalTable: "catTipoSalida",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblSalidaBien_catUnidadDestino_catUnidadDestinoid",
                table: "tblSalidaBien",
                column: "catUnidadDestinoid",
                principalTable: "catUnidadDestino",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tblSalidaBien_TblBienes_tblbienesid",
                table: "tblSalidaBien",
                column: "tblbienesid",
                principalTable: "TblBienes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
