using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class ej_07 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_cat_horario_cat_Horarioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idHorario",
                table: "CtrlUsuarios");

            migrationBuilder.RenameColumn(
                name: "cat_Horarioid",
                table: "CtrlUsuarios",
                newName: "cat_horarioid");

            migrationBuilder.RenameIndex(
                name: "IX_CtrlUsuarios_cat_Horarioid",
                table: "CtrlUsuarios",
                newName: "IX_CtrlUsuarios_cat_horarioid");

            migrationBuilder.AddColumn<int>(
                name: "CatServicioid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienesid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catRolid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catSexoid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idRol",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idServicio",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idSexo",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTipoBien",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CatEstadoDelBien",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    estado = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatEstadoDelBien", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CatEstatus",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    estatus = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatEstatus", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CatServicio",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    servicio = table.Column<string>(nullable: true),
                    usuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatServicio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CatSexo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    sexo = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatSexo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoContrato",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    contrato = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoContrato", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoDeBien",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TipodeBien = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoDeBien", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CatTurno",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    turno = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTurno", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TblResguardatarios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nombre = table.Column<string>(nullable: true),
                    apellidoUno = table.Column<string>(nullable: true),
                    apellidoDos = table.Column<string>(nullable: true),
                    idServicio = table.Column<int>(nullable: false),
                    CatServicioid = table.Column<int>(nullable: true),
                    idTurno = table.Column<int>(nullable: false),
                    catTurnoid = table.Column<int>(nullable: true),
                    idEstatus = table.Column<int>(nullable: false),
                    catEstatusid = table.Column<int>(nullable: true),
                    idTipoContrato = table.Column<int>(nullable: false),
                    catTipoContratoid = table.Column<int>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblResguardatarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblResguardatarios_CatServicio_CatServicioid",
                        column: x => x.CatServicioid,
                        principalTable: "CatServicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblResguardatarios_CatEstatus_catEstatusid",
                        column: x => x.catEstatusid,
                        principalTable: "CatEstatus",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblResguardatarios_CatTipoContrato_catTipoContratoid",
                        column: x => x.catTipoContratoid,
                        principalTable: "CatTipoContrato",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblResguardatarios_CatTurno_catTurnoid",
                        column: x => x.catTurnoid,
                        principalTable: "CatTurno",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblBienes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numeroInventario = table.Column<int>(nullable: false),
                    descripcion = table.Column<string>(nullable: true),
                    marca = table.Column<string>(nullable: true),
                    modelo = table.Column<string>(nullable: true),
                    serie = table.Column<string>(nullable: true),
                    idFactura = table.Column<int>(nullable: false),
                    claveCambs = table.Column<string>(nullable: true),
                    claveSaica = table.Column<string>(nullable: true),
                    IVA = table.Column<double>(nullable: false),
                    costoTotal = table.Column<double>(nullable: false),
                    idServicio = table.Column<int>(nullable: false),
                    cat_Horarioid = table.Column<int>(nullable: true),
                    idResguardatario = table.Column<int>(nullable: false),
                    tblResguardatariosid = table.Column<int>(nullable: true),
                    idTipoBien = table.Column<int>(nullable: false),
                    catTipoDeBienesid = table.Column<int>(nullable: true),
                    idEstadoFisico = table.Column<int>(nullable: false),
                    catEstadoDelBienid = table.Column<int>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBienes", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblBienes_CatEstadoDelBien_catEstadoDelBienid",
                        column: x => x.catEstadoDelBienid,
                        principalTable: "CatEstadoDelBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienes_CatTipoDeBien_catTipoDeBienesid",
                        column: x => x.catTipoDeBienesid,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienes_cat_horario_cat_Horarioid",
                        column: x => x.cat_Horarioid,
                        principalTable: "cat_horario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienes_TblResguardatarios_tblResguardatariosid",
                        column: x => x.tblResguardatariosid,
                        principalTable: "TblResguardatarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_CatServicioid",
                table: "CtrlUsuarios",
                column: "CatServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_CatTipoDeBienesid",
                table: "CtrlUsuarios",
                column: "CatTipoDeBienesid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_catRolid",
                table: "CtrlUsuarios",
                column: "catRolid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_catSexoid",
                table: "CtrlUsuarios",
                column: "catSexoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_catEstadoDelBienid",
                table: "TblBienes",
                column: "catEstadoDelBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_catTipoDeBienesid",
                table: "TblBienes",
                column: "catTipoDeBienesid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_cat_Horarioid",
                table: "TblBienes",
                column: "cat_Horarioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_tblResguardatariosid",
                table: "TblBienes",
                column: "tblResguardatariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_CatServicioid",
                table: "TblResguardatarios",
                column: "CatServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_catEstatusid",
                table: "TblResguardatarios",
                column: "catEstatusid");

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_catTipoContratoid",
                table: "TblResguardatarios",
                column: "catTipoContratoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_catTurnoid",
                table: "TblResguardatarios",
                column: "catTurnoid");

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatServicio_CatServicioid",
                table: "CtrlUsuarios",
                column: "CatServicioid",
                principalTable: "CatServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatTipoDeBien_CatTipoDeBienesid",
                table: "CtrlUsuarios",
                column: "CatTipoDeBienesid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_catRol_catRolid",
                table: "CtrlUsuarios",
                column: "catRolid",
                principalTable: "catRol",
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
                name: "FK_CtrlUsuarios_cat_horario_cat_horarioid",
                table: "CtrlUsuarios",
                column: "cat_horarioid",
                principalTable: "cat_horario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatServicio_CatServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatTipoDeBien_CatTipoDeBienesid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_catRol_catRolid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatSexo_catSexoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_cat_horario_cat_horarioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropTable(
                name: "CatSexo");

            migrationBuilder.DropTable(
                name: "TblBienes");

            migrationBuilder.DropTable(
                name: "CatEstadoDelBien");

            migrationBuilder.DropTable(
                name: "CatTipoDeBien");

            migrationBuilder.DropTable(
                name: "TblResguardatarios");

            migrationBuilder.DropTable(
                name: "CatServicio");

            migrationBuilder.DropTable(
                name: "CatEstatus");

            migrationBuilder.DropTable(
                name: "CatTipoContrato");

            migrationBuilder.DropTable(
                name: "CatTurno");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_CatServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_CatTipoDeBienesid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_catRolid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_catSexoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "CatServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienesid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "catRolid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "catSexoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idRol",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idServicio",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idSexo",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idTipoBien",
                table: "CtrlUsuarios");

            migrationBuilder.RenameColumn(
                name: "cat_horarioid",
                table: "CtrlUsuarios",
                newName: "cat_Horarioid");

            migrationBuilder.RenameIndex(
                name: "IX_CtrlUsuarios_cat_horarioid",
                table: "CtrlUsuarios",
                newName: "IX_CtrlUsuarios_cat_Horarioid");

            migrationBuilder.AddColumn<int>(
                name: "idHorario",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_cat_horario_cat_Horarioid",
                table: "CtrlUsuarios",
                column: "cat_Horarioid",
                principalTable: "cat_horario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
