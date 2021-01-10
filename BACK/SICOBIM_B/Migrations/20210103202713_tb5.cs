using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class tb5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_TblAreaServicio_IdAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblAreaServicio_IdAreaServicioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblAreaServicio_IdAreaServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblAreaServicio_IdAreaServicioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblAreaServicio_IdAreaServicioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatServicio_CatServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_TblAreaServicio_TblAreaServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropTable(
                name: "TblAreaServicio");

            migrationBuilder.DropIndex(
                name: "IX_TblResguardatarios_CatServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropIndex(
                name: "IX_TblResguardatarios_TblAreaServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdAreaServicioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdAreaServicioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdAreaServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdAreaServicioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_IdAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "TblAreaServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "IdAreaServicioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdAreaServicioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdAreaServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdAreaServicioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.RenameColumn(
                name: "CatServicioid",
                table: "TblResguardatarios",
                newName: "Catservicioid");

            migrationBuilder.AddColumn<int>(
                name: "TblBienesMueblesId",
                table: "TblSalidas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatServicioid",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Catareaid",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdServicioId",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catAreaid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catServicioid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catAreaid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catServicioid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catAreaid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catServicioid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catAreaid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catServicioid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catAreaid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catServicioid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidas_TblBienesMueblesId",
                table: "TblSalidas",
                column: "TblBienesMueblesId");

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_CatServicioid",
                table: "TblResguardatarios",
                column: "CatServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_Catareaid",
                table: "TblResguardatarios",
                column: "Catareaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_IdServicioId",
                table: "TblResguardatarios",
                column: "IdServicioId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catAreaid",
                table: "TblInstrumentalMedico",
                column: "catAreaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catServicioid",
                table: "TblInstrumentalMedico",
                column: "catServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catAreaid",
                table: "TblBienesSistemas",
                column: "catAreaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catServicioid",
                table: "TblBienesSistemas",
                column: "catServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_catAreaid",
                table: "TblBienesMuebles",
                column: "catAreaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_catServicioid",
                table: "TblBienesMuebles",
                column: "catServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catAreaid",
                table: "TblBienesEquMedico",
                column: "catAreaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catServicioid",
                table: "TblBienesEquMedico",
                column: "catServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_catAreaid",
                table: "CtrlUsuarios",
                column: "catAreaid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_catServicioid",
                table: "CtrlUsuarios",
                column: "catServicioid");

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatArea_catAreaid",
                table: "CtrlUsuarios",
                column: "catAreaid",
                principalTable: "CatArea",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatServicio_catServicioid",
                table: "CtrlUsuarios",
                column: "catServicioid",
                principalTable: "CatServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_CatArea_catAreaid",
                table: "TblBienesEquMedico",
                column: "catAreaid",
                principalTable: "CatArea",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_CatServicio_catServicioid",
                table: "TblBienesEquMedico",
                column: "catServicioid",
                principalTable: "CatServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatArea_catAreaid",
                table: "TblBienesMuebles",
                column: "catAreaid",
                principalTable: "CatArea",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatServicio_catServicioid",
                table: "TblBienesMuebles",
                column: "catServicioid",
                principalTable: "CatServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_CatArea_catAreaid",
                table: "TblBienesSistemas",
                column: "catAreaid",
                principalTable: "CatArea",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_CatServicio_catServicioid",
                table: "TblBienesSistemas",
                column: "catServicioid",
                principalTable: "CatServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_CatArea_catAreaid",
                table: "TblInstrumentalMedico",
                column: "catAreaid",
                principalTable: "CatArea",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_CatServicio_catServicioid",
                table: "TblInstrumentalMedico",
                column: "catServicioid",
                principalTable: "CatServicio",
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
                name: "FK_TblResguardatarios_CatArea_Catareaid",
                table: "TblResguardatarios",
                column: "Catareaid",
                principalTable: "CatArea",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblResguardatarios_CatServicio_IdServicioId",
                table: "TblResguardatarios",
                column: "IdServicioId",
                principalTable: "CatServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidas_TblBienesMuebles_TblBienesMueblesId",
                table: "TblSalidas",
                column: "TblBienesMueblesId",
                principalTable: "TblBienesMuebles",
                principalColumn: "TblBienesMueblesId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatArea_catAreaid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatServicio_catServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_CatArea_catAreaid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_CatServicio_catServicioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatArea_catAreaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatServicio_catServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_CatArea_catAreaid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_CatServicio_catServicioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_CatArea_catAreaid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_CatServicio_catServicioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatServicio_CatServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatArea_Catareaid",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatServicio_IdServicioId",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidas_TblBienesMuebles_TblBienesMueblesId",
                table: "TblSalidas");

            migrationBuilder.DropIndex(
                name: "IX_TblSalidas_TblBienesMueblesId",
                table: "TblSalidas");

            migrationBuilder.DropIndex(
                name: "IX_TblResguardatarios_CatServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropIndex(
                name: "IX_TblResguardatarios_Catareaid",
                table: "TblResguardatarios");

            migrationBuilder.DropIndex(
                name: "IX_TblResguardatarios_IdServicioId",
                table: "TblResguardatarios");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_catAreaid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_catServicioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_catAreaid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_catServicioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_catAreaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_catServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_catAreaid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_catServicioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_catAreaid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_catServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "TblBienesMueblesId",
                table: "TblSalidas");

            migrationBuilder.DropColumn(
                name: "CatServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "Catareaid",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "IdServicioId",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "catAreaid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "catServicioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "catAreaid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "catServicioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "catAreaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "catServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "catAreaid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "catServicioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "catAreaid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "catServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.RenameColumn(
                name: "Catservicioid",
                table: "TblResguardatarios",
                newName: "CatServicioid");

            migrationBuilder.AddColumn<int>(
                name: "TblAreaServicioid",
                table: "TblResguardatarios",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAreaServicioid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAreaServicioid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAreaServicioid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAreaServicioid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAreaServicioid",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TblAreaServicio",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    catareaid = table.Column<int>(type: "integer", nullable: true),
                    catservicioid = table.Column<int>(type: "integer", nullable: true),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    fechaAlta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fechaMod = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    usuarioMod = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAreaServicio", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblAreaServicio_CatArea_catareaid",
                        column: x => x.catareaid,
                        principalTable: "CatArea",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblAreaServicio_CatServicio_catservicioid",
                        column: x => x.catservicioid,
                        principalTable: "CatServicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_CatServicioid",
                table: "TblResguardatarios",
                column: "CatServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_TblAreaServicioid",
                table: "TblResguardatarios",
                column: "TblAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdAreaServicioid",
                table: "TblInstrumentalMedico",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdAreaServicioid",
                table: "TblBienesSistemas",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdAreaServicioid",
                table: "TblBienesMuebles",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdAreaServicioid",
                table: "TblBienesEquMedico",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_IdAreaServicioid",
                table: "CtrlUsuarios",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblAreaServicio_catareaid",
                table: "TblAreaServicio",
                column: "catareaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblAreaServicio_catservicioid",
                table: "TblAreaServicio",
                column: "catservicioid");

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_TblAreaServicio_IdAreaServicioid",
                table: "CtrlUsuarios",
                column: "IdAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblAreaServicio_IdAreaServicioid",
                table: "TblBienesEquMedico",
                column: "IdAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblAreaServicio_IdAreaServicioid",
                table: "TblBienesMuebles",
                column: "IdAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblAreaServicio_IdAreaServicioid",
                table: "TblBienesSistemas",
                column: "IdAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblAreaServicio_IdAreaServicioid",
                table: "TblInstrumentalMedico",
                column: "IdAreaServicioid",
                principalTable: "TblAreaServicio",
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
        }
    }
}
