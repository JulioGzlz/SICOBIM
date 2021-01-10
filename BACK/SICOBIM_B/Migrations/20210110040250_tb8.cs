using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class tb8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatServicio_CatServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropTable(
                name: "TblSalidas");

            migrationBuilder.DropIndex(
                name: "IX_TblResguardatarios_CatServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "CatServicioid",
                table: "TblResguardatarios");

            migrationBuilder.RenameColumn(
                name: "Catservicioid",
                table: "TblResguardatarios",
                newName: "CatServicioid");

            migrationBuilder.CreateTable(
                name: "TblSalidasBien",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    catTipoSalidaid = table.Column<int>(nullable: true),
                    CatUnidadDestinoid = table.Column<int>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    IdBienesEquipoMedicoid = table.Column<int>(nullable: true),
                    IdBienesSistemasid = table.Column<int>(nullable: true),
                    IdBienesMueblesid = table.Column<int>(nullable: true),
                    IdInstrumentalMedicoid = table.Column<int>(nullable: true),
                    CatTipoDeBienId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSalidasBien", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblSalidasBien_CatTipoDeBien_CatTipoDeBienId",
                        column: x => x.CatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidasBien_CatTipoSalida_catTipoSalidaid",
                        column: x => x.catTipoSalidaid,
                        principalTable: "CatTipoSalida",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidasBien_CatUnidadDestino_CatUnidadDestinoid",
                        column: x => x.CatUnidadDestinoid,
                        principalTable: "CatUnidadDestino",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidasBien_TblBienesEquMedico_IdBienesEquipoMedicoid",
                        column: x => x.IdBienesEquipoMedicoid,
                        principalTable: "TblBienesEquMedico",
                        principalColumn: "TblBienesEquMedicoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidasBien_TblBienesMuebles_IdBienesMueblesid",
                        column: x => x.IdBienesMueblesid,
                        principalTable: "TblBienesMuebles",
                        principalColumn: "TblBienesMueblesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidasBien_TblBienesSistemas_IdBienesSistemasid",
                        column: x => x.IdBienesSistemasid,
                        principalTable: "TblBienesSistemas",
                        principalColumn: "TblBienesSistemasId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidasBien_TblInstrumentalMedico_IdInstrumentalMedicoid",
                        column: x => x.IdInstrumentalMedicoid,
                        principalTable: "TblInstrumentalMedico",
                        principalColumn: "TblInstrumentalMedicoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_CatServicioid",
                table: "TblResguardatarios",
                column: "CatServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidasBien_CatTipoDeBienId",
                table: "TblSalidasBien",
                column: "CatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidasBien_catTipoSalidaid",
                table: "TblSalidasBien",
                column: "catTipoSalidaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidasBien_CatUnidadDestinoid",
                table: "TblSalidasBien",
                column: "CatUnidadDestinoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidasBien_IdBienesEquipoMedicoid",
                table: "TblSalidasBien",
                column: "IdBienesEquipoMedicoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidasBien_IdBienesMueblesid",
                table: "TblSalidasBien",
                column: "IdBienesMueblesid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidasBien_IdBienesSistemasid",
                table: "TblSalidasBien",
                column: "IdBienesSistemasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidasBien_IdInstrumentalMedicoid",
                table: "TblSalidasBien",
                column: "IdInstrumentalMedicoid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblResguardatarios_CatServicio_CatServicioid",
                table: "TblResguardatarios",
                column: "CatServicioid",
                principalTable: "CatServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatServicio_CatServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropTable(
                name: "TblSalidasBien");

            migrationBuilder.DropIndex(
                name: "IX_TblResguardatarios_CatServicioid",
                table: "TblResguardatarios");

            migrationBuilder.RenameColumn(
                name: "CatServicioid",
                table: "TblResguardatarios",
                newName: "Catservicioid");

            migrationBuilder.AddColumn<int>(
                name: "CatServicioid",
                table: "TblResguardatarios",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TblSalidas",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    CatTipoDeBienId = table.Column<int>(type: "integer", nullable: true),
                    catTipoSalidaid = table.Column<int>(type: "integer", nullable: true),
                    catUnidadDestinoid = table.Column<int>(type: "integer", nullable: true),
                    fechaAlta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fechaMod = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    IdBien = table.Column<int>(type: "integer", nullable: false),
                    idUsuarioAlta = table.Column<int>(type: "integer", nullable: false),
                    TblBienesEquMedicoId = table.Column<int>(type: "integer", nullable: true),
                    TblBienesMueblesId = table.Column<int>(type: "integer", nullable: true),
                    TblBienesSistemasId = table.Column<int>(type: "integer", nullable: true),
                    TblInstrumentalMedicoId = table.Column<int>(type: "integer", nullable: true),
                    usuarioMod = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSalidas", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblSalidas_CatTipoDeBien_CatTipoDeBienId",
                        column: x => x.CatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidas_CatTipoSalida_catTipoSalidaid",
                        column: x => x.catTipoSalidaid,
                        principalTable: "CatTipoSalida",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidas_CatUnidadDestino_catUnidadDestinoid",
                        column: x => x.catUnidadDestinoid,
                        principalTable: "CatUnidadDestino",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidas_TblBienesEquMedico_TblBienesEquMedicoId",
                        column: x => x.TblBienesEquMedicoId,
                        principalTable: "TblBienesEquMedico",
                        principalColumn: "TblBienesEquMedicoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidas_TblBienesMuebles_TblBienesMueblesId",
                        column: x => x.TblBienesMueblesId,
                        principalTable: "TblBienesMuebles",
                        principalColumn: "TblBienesMueblesId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidas_TblBienesSistemas_TblBienesSistemasId",
                        column: x => x.TblBienesSistemasId,
                        principalTable: "TblBienesSistemas",
                        principalColumn: "TblBienesSistemasId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidas_TblInstrumentalMedico_TblInstrumentalMedicoId",
                        column: x => x.TblInstrumentalMedicoId,
                        principalTable: "TblInstrumentalMedico",
                        principalColumn: "TblInstrumentalMedicoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_CatServicioid",
                table: "TblResguardatarios",
                column: "CatServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidas_CatTipoDeBienId",
                table: "TblSalidas",
                column: "CatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidas_catTipoSalidaid",
                table: "TblSalidas",
                column: "catTipoSalidaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidas_catUnidadDestinoid",
                table: "TblSalidas",
                column: "catUnidadDestinoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidas_TblBienesEquMedicoId",
                table: "TblSalidas",
                column: "TblBienesEquMedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidas_TblBienesMueblesId",
                table: "TblSalidas",
                column: "TblBienesMueblesId");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidas_TblBienesSistemasId",
                table: "TblSalidas",
                column: "TblBienesSistemasId");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidas_TblInstrumentalMedicoId",
                table: "TblSalidas",
                column: "TblInstrumentalMedicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblResguardatarios_CatServicio_CatServicioid",
                table: "TblResguardatarios",
                column: "CatServicioid",
                principalTable: "CatServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
