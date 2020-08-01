using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class ej_08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_CtrlUsuarios_cat_horario_cat_horarioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_cat_horario_cat_Horarioid",
                table: "TblBienes");

            migrationBuilder.DropTable(
                name: "cat_horario");

            migrationBuilder.DropIndex(
                name: "IX_TblBienes_cat_Horarioid",
                table: "TblBienes");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_CatServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_CatTipoDeBienesid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_cat_horarioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "cat_Horarioid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "CatServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienesid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "cat_horarioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "correo",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idTipoBien",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "usuarioMod",
                table: "CatServicio");

            migrationBuilder.DropColumn(
                name: "UsuarioAlta",
                table: "catRol");

            migrationBuilder.RenameColumn(
                name: "idRol",
                table: "CtrlUsuarios",
                newName: "idrol");

            migrationBuilder.RenameColumn(
                name: "catRolid",
                table: "CtrlUsuarios",
                newName: "CatRolid");

            migrationBuilder.RenameIndex(
                name: "IX_CtrlUsuarios_catRolid",
                table: "CtrlUsuarios",
                newName: "IX_CtrlUsuarios_CatRolid");

            migrationBuilder.AddColumn<string>(
                name: "RFC",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblAreaServicioid",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargo",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catSexoid",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idSexo",
                table: "TblResguardatarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "numeroempleado",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "plaza",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblBienesid",
                table: "TblBienes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cantidad",
                table: "TblBienes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "catGarantiaid",
                table: "TblBienes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoEntradaid",
                table: "TblBienes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoPartidaid",
                table: "TblBienes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catUnidadDestinoid",
                table: "TblBienes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "contrato",
                table: "TblBienes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idAñosGarantia",
                table: "TblBienes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "identrada",
                table: "TblBienes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idtipopartida",
                table: "TblBienes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idunidaddestino",
                table: "TblBienes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numerofederalizacion",
                table: "TblBienes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "observaciones",
                table: "TblBienes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "proveedor",
                table: "TblBienes",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "subtotal",
                table: "TblBienes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "tblAreaServicioid",
                table: "TblBienes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblFacturasid",
                table: "TblBienes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblInventariosid",
                table: "TblBienes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RFC",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cargo",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catEstatusid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoContratoid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTurnoid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idestatus",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idtipocontrato",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idturno",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "numeroempleado",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "plaza",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblAreaServicioid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "CatTurno",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "CatTipoDeBien",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "CatTipoContrato",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "CatSexo",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "CatServicio",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idusuarioMod",
                table: "CatServicio",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "catRol",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaMod",
                table: "catRol",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "idUsuarioAlta",
                table: "catRol",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idusuarioMod",
                table: "catRol",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "CatEstatus",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "CatEstadoDelBien",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatArea",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    area = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    usuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    idusuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatArea", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CatGarantia",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    añosGarantia = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatGarantia", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CatPermiso",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    permiso = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatPermiso", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoEntrada",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipoentrada = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoEntrada", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoPartida",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    partida = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoPartida", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CatTipoSalida",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tiposalida = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTipoSalida", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CatUnidadDestino",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    destino = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    idusuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatUnidadDestino", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TblFacturas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    facturas = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFacturas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TblInventarios",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumeroInventario = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblInventarios", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TblAreaServicio",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idarea = table.Column<int>(nullable: false),
                    catareaid = table.Column<int>(nullable: true),
                    idservicio = table.Column<int>(nullable: false),
                    catservicioid = table.Column<int>(nullable: true),
                    localizacion = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "TblConfPerfil",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idpermiso = table.Column<int>(nullable: false),
                    catPermisoid = table.Column<int>(nullable: true),
                    idrol = table.Column<int>(nullable: false),
                    catRolid = table.Column<int>(nullable: true),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblConfPerfil", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblConfPerfil_CatPermiso_catPermisoid",
                        column: x => x.catPermisoid,
                        principalTable: "CatPermiso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblConfPerfil_catRol_catRolid",
                        column: x => x.catRolid,
                        principalTable: "catRol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblSalidaBien",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idbien = table.Column<int>(nullable: false),
                    tblbienesid = table.Column<int>(nullable: true),
                    idtiposalida = table.Column<int>(nullable: false),
                    catTipoSalidaid = table.Column<int>(nullable: true),
                    idunidaddestino = table.Column<int>(nullable: false),
                    catUnidadDestinoid = table.Column<int>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblSalidaBien", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblSalidaBien_CatTipoSalida_catTipoSalidaid",
                        column: x => x.catTipoSalidaid,
                        principalTable: "CatTipoSalida",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidaBien_CatUnidadDestino_catUnidadDestinoid",
                        column: x => x.catUnidadDestinoid,
                        principalTable: "CatUnidadDestino",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidaBien_TblBienes_tblbienesid",
                        column: x => x.tblbienesid,
                        principalTable: "TblBienes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_TblAreaServicioid",
                table: "TblResguardatarios",
                column: "TblAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_catSexoid",
                table: "TblResguardatarios",
                column: "catSexoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_TblBienesid",
                table: "TblBienes",
                column: "TblBienesid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_catGarantiaid",
                table: "TblBienes",
                column: "catGarantiaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_catTipoEntradaid",
                table: "TblBienes",
                column: "catTipoEntradaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_catTipoPartidaid",
                table: "TblBienes",
                column: "catTipoPartidaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_catUnidadDestinoid",
                table: "TblBienes",
                column: "catUnidadDestinoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_tblAreaServicioid",
                table: "TblBienes",
                column: "tblAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_tblFacturasid",
                table: "TblBienes",
                column: "tblFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_tblInventariosid",
                table: "TblBienes",
                column: "tblInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_CatTipoDeBienid",
                table: "CtrlUsuarios",
                column: "CatTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_catEstatusid",
                table: "CtrlUsuarios",
                column: "catEstatusid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_catTipoContratoid",
                table: "CtrlUsuarios",
                column: "catTipoContratoid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_catTurnoid",
                table: "CtrlUsuarios",
                column: "catTurnoid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_tblAreaServicioid",
                table: "CtrlUsuarios",
                column: "tblAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblAreaServicio_catareaid",
                table: "TblAreaServicio",
                column: "catareaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblAreaServicio_catservicioid",
                table: "TblAreaServicio",
                column: "catservicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_catPermisoid",
                table: "TblConfPerfil",
                column: "catPermisoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_catRolid",
                table: "TblConfPerfil",
                column: "catRolid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidaBien_catTipoSalidaid",
                table: "TblSalidaBien",
                column: "catTipoSalidaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidaBien_catUnidadDestinoid",
                table: "TblSalidaBien",
                column: "catUnidadDestinoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidaBien_tblbienesid",
                table: "TblSalidaBien",
                column: "tblbienesid");

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_catRol_CatRolid",
                table: "CtrlUsuarios",
                column: "CatRolid",
                principalTable: "catRol",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatTipoDeBien_CatTipoDeBienid",
                table: "CtrlUsuarios",
                column: "CatTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatEstatus_catEstatusid",
                table: "CtrlUsuarios",
                column: "catEstatusid",
                principalTable: "CatEstatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatTipoContrato_catTipoContratoid",
                table: "CtrlUsuarios",
                column: "catTipoContratoid",
                principalTable: "CatTipoContrato",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatTurno_catTurnoid",
                table: "CtrlUsuarios",
                column: "catTurnoid",
                principalTable: "CatTurno",
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
                name: "FK_TblBienes_TblBienes_TblBienesid",
                table: "TblBienes",
                column: "TblBienesid",
                principalTable: "TblBienes",
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
                name: "FK_TblBienes_TblFacturas_tblFacturasid",
                table: "TblBienes",
                column: "tblFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_TblInventarios_tblInventariosid",
                table: "TblBienes",
                column: "tblInventariosid",
                principalTable: "TblInventarios",
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
                name: "FK_TblResguardatarios_CatSexo_catSexoid",
                table: "TblResguardatarios",
                column: "catSexoid",
                principalTable: "CatSexo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_catRol_CatRolid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatTipoDeBien_CatTipoDeBienid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatEstatus_catEstatusid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatTipoContrato_catTipoContratoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatTurno_catTurnoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_TblAreaServicio_tblAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_TblBienes_TblBienesid",
                table: "TblBienes");

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
                name: "FK_TblBienes_TblFacturas_tblFacturasid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_TblInventarios_tblInventariosid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_TblAreaServicio_TblAreaServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatSexo_catSexoid",
                table: "TblResguardatarios");

            migrationBuilder.DropTable(
                name: "CatGarantia");

            migrationBuilder.DropTable(
                name: "CatTipoEntrada");

            migrationBuilder.DropTable(
                name: "CatTipoPartida");

            migrationBuilder.DropTable(
                name: "TblAreaServicio");

            migrationBuilder.DropTable(
                name: "TblConfPerfil");

            migrationBuilder.DropTable(
                name: "TblFacturas");

            migrationBuilder.DropTable(
                name: "TblInventarios");

            migrationBuilder.DropTable(
                name: "TblSalidaBien");

            migrationBuilder.DropTable(
                name: "CatArea");

            migrationBuilder.DropTable(
                name: "CatPermiso");

            migrationBuilder.DropTable(
                name: "CatTipoSalida");

            migrationBuilder.DropTable(
                name: "CatUnidadDestino");

            migrationBuilder.DropIndex(
                name: "IX_TblResguardatarios_TblAreaServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropIndex(
                name: "IX_TblResguardatarios_catSexoid",
                table: "TblResguardatarios");

            migrationBuilder.DropIndex(
                name: "IX_TblBienes_TblBienesid",
                table: "TblBienes");

            migrationBuilder.DropIndex(
                name: "IX_TblBienes_catGarantiaid",
                table: "TblBienes");

            migrationBuilder.DropIndex(
                name: "IX_TblBienes_catTipoEntradaid",
                table: "TblBienes");

            migrationBuilder.DropIndex(
                name: "IX_TblBienes_catTipoPartidaid",
                table: "TblBienes");

            migrationBuilder.DropIndex(
                name: "IX_TblBienes_catUnidadDestinoid",
                table: "TblBienes");

            migrationBuilder.DropIndex(
                name: "IX_TblBienes_tblAreaServicioid",
                table: "TblBienes");

            migrationBuilder.DropIndex(
                name: "IX_TblBienes_tblFacturasid",
                table: "TblBienes");

            migrationBuilder.DropIndex(
                name: "IX_TblBienes_tblInventariosid",
                table: "TblBienes");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_CatTipoDeBienid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_catEstatusid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_catTipoContratoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_catTurnoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_tblAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "RFC",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "TblAreaServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "cargo",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "catSexoid",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "idSexo",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "numeroempleado",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "plaza",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "TblBienesid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "cantidad",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "catGarantiaid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "catTipoEntradaid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "catTipoPartidaid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "catUnidadDestinoid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "contrato",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "idAñosGarantia",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "identrada",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "idtipopartida",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "idunidaddestino",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "numerofederalizacion",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "observaciones",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "proveedor",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "subtotal",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "tblAreaServicioid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "tblFacturasid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "tblInventariosid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "RFC",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "cargo",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "catEstatusid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "catTipoContratoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "catTurnoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idestatus",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idtipocontrato",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idturno",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "numeroempleado",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "plaza",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "tblAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "CatTurno");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "CatTipoDeBien");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "CatTipoContrato");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "CatSexo");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "CatServicio");

            migrationBuilder.DropColumn(
                name: "idusuarioMod",
                table: "CatServicio");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "catRol");

            migrationBuilder.DropColumn(
                name: "fechaMod",
                table: "catRol");

            migrationBuilder.DropColumn(
                name: "idUsuarioAlta",
                table: "catRol");

            migrationBuilder.DropColumn(
                name: "idusuarioMod",
                table: "catRol");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "CatEstatus");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "CatEstadoDelBien");

            migrationBuilder.RenameColumn(
                name: "idrol",
                table: "CtrlUsuarios",
                newName: "idRol");

            migrationBuilder.RenameColumn(
                name: "CatRolid",
                table: "CtrlUsuarios",
                newName: "catRolid");

            migrationBuilder.RenameIndex(
                name: "IX_CtrlUsuarios_CatRolid",
                table: "CtrlUsuarios",
                newName: "IX_CtrlUsuarios_catRolid");

            migrationBuilder.AddColumn<int>(
                name: "cat_Horarioid",
                table: "TblBienes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "TblBienes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatServicioid",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienesid",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cat_horarioid",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "CtrlUsuarios",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idTipoBien",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "usuarioMod",
                table: "CatServicio",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioAlta",
                table: "catRol",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "cat_horario",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fechaAlta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fechaMod = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    horario = table.Column<string>(type: "text", nullable: true),
                    usuarioAlta = table.Column<int>(type: "integer", nullable: false),
                    usuarioMod = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat_horario", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_cat_Horarioid",
                table: "TblBienes",
                column: "cat_Horarioid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_CatServicioid",
                table: "CtrlUsuarios",
                column: "CatServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_CatTipoDeBienesid",
                table: "CtrlUsuarios",
                column: "CatTipoDeBienesid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_cat_horarioid",
                table: "CtrlUsuarios",
                column: "cat_horarioid");

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
                name: "FK_CtrlUsuarios_cat_horario_cat_horarioid",
                table: "CtrlUsuarios",
                column: "cat_horarioid",
                principalTable: "cat_horario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_cat_horario_cat_Horarioid",
                table: "TblBienes",
                column: "cat_Horarioid",
                principalTable: "cat_horario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
