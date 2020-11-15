using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class new_tb1 : Migration
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

            migrationBuilder.DropTable(
                name: "TblBienes");

            migrationBuilder.DropTable(
                name: "cat_horario");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_CatServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_CatTipoDeBienesid",
                table: "CtrlUsuarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_cat_horarioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatTipoDeBien",
                table: "CatTipoDeBien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_catRol",
                table: "catRol");

            migrationBuilder.DropColumn(
                name: "idEstatus",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "idServicio",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "idTipoContrato",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "idTurno",
                table: "TblResguardatarios");

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

            migrationBuilder.DropColumn(
                name: "id",
                table: "CatTipoDeBien");

            migrationBuilder.DropColumn(
                name: "usuarioMod",
                table: "CatServicio");

            migrationBuilder.DropColumn(
                name: "UsuarioAlta",
                table: "catRol");

            migrationBuilder.RenameTable(
                name: "catRol",
                newName: "CatRol");

            migrationBuilder.AddColumn<string>(
                name: "cargo",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catSexoid",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "numeroempleado",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "plaza",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RFC",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblAreaServicioid",
                table: "TblResguardatarios",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValueSql: "'0001-01-01 00:00:00'::timestamp without time zone",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaAlta",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValueSql: "'0001-01-01 00:00:00'::timestamp without time zone",
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

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
                name: "IdAreaServicioid",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idTok",
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

            migrationBuilder.AddColumn<string>(
                name: "RFC",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "CatTurno",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienId",
                table: "CatTipoDeBien",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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
                table: "CatRol",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaMod",
                table: "CatRol",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "idUsuarioAlta",
                table: "CatRol",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idusuarioMod",
                table: "CatRol",
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

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatTipoDeBien",
                table: "CatTipoDeBien",
                column: "CatTipoDeBienId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatRol",
                table: "CatRol",
                column: "id");

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
                name: "CatPiso",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    piso = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatPiso", x => x.id);
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
                    descripcion = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    partidapresupestual = table.Column<string>(nullable: true)
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
                name: "RefreshToken",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Token = table.Column<string>(nullable: true),
                    Expires = table.Column<DateTime>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedByIp = table.Column<string>(nullable: true),
                    Revoked = table.Column<DateTime>(nullable: true),
                    RevokedByIp = table.Column<string>(nullable: true),
                    ReplacedByToken = table.Column<string>(nullable: true),
                    Userid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshToken", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefreshToken_CtrlUsuarios_Userid",
                        column: x => x.Userid,
                        principalTable: "CtrlUsuarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblClaveCambs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    clavecambs = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    CatTipoDeBienId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblClaveCambs", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienId",
                        column: x => x.CatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblClaveSaica",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    clavesaica = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    CatTipoDeBienId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblClaveSaica", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblClaveSaica_CatTipoDeBien_CatTipoDeBienId",
                        column: x => x.CatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblContratoBien",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    contratobien = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    CatTipoDeBienId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblContratoBien", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienId",
                        column: x => x.CatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblFacturas",
                columns: table => new
                {
                    IdFactura = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    IVA = table.Column<double>(nullable: false),
                    costoTotal = table.Column<double>(nullable: false),
                    subtotal = table.Column<double>(nullable: false),
                    CatTipoDeBienId = table.Column<int>(nullable: false),
                    factura = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFacturas", x => x.IdFactura);
                    table.ForeignKey(
                        name: "FK_TblFacturas_CatTipoDeBien_CatTipoDeBienId",
                        column: x => x.CatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TblFederalizacion",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    federalizacion = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    CatTipoDeBienId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFederalizacion", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblFederalizacion_CatTipoDeBien_CatTipoDeBienId",
                        column: x => x.CatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Restrict);
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
                    activo = table.Column<bool>(nullable: false),
                    CatTipoDeBienId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblInventarios", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblInventarios_CatTipoDeBien_CatTipoDeBienId",
                        column: x => x.CatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblProveedor",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    proveedor = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    CatTipoDeBienId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProveedor", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblProveedor_CatTipoDeBien_CatTipoDeBienId",
                        column: x => x.CatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblAreaServicio",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    catareaid = table.Column<int>(nullable: true),
                    catservicioid = table.Column<int>(nullable: true),
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
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    IdPermisoid = table.Column<int>(nullable: true),
                    IdRolid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_TblConfPerfil_CatPermiso_IdPermisoid",
                        column: x => x.IdPermisoid,
                        principalTable: "CatPermiso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblConfPerfil_CatRol_IdRolid",
                        column: x => x.IdRolid,
                        principalTable: "CatRol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblBienesEquMedico",
                columns: table => new
                {
                    TblBienesEquMedicoId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    marca = table.Column<string>(nullable: true),
                    modelo = table.Column<string>(nullable: true),
                    serie = table.Column<string>(nullable: true),
                    cantidad = table.Column<int>(nullable: false),
                    catGarantiaid = table.Column<int>(nullable: true),
                    catTipoPartidaid = table.Column<int>(nullable: true),
                    catTipoEntradaid = table.Column<int>(nullable: true),
                    catPisosid = table.Column<int>(nullable: true),
                    catEstadoDelBienid = table.Column<int>(nullable: true),
                    observaciones = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    IdInventarioid = table.Column<int>(nullable: true),
                    IdAreaServicioid = table.Column<int>(nullable: true),
                    IdClaveSaicaid = table.Column<int>(nullable: true),
                    IdContratoBienid = table.Column<int>(nullable: true),
                    IdFederalizacionid = table.Column<int>(nullable: true),
                    IdProveedorid = table.Column<int>(nullable: true),
                    IdResguardatariosid = table.Column<int>(nullable: true),
                    IdClaveCabmsid = table.Column<int>(nullable: true),
                    catTipoDeBienesCatTipoDeBienId = table.Column<int>(nullable: true),
                    IdFacturasIdFactura = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBienesEquMedico", x => x.TblBienesEquMedicoId);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_CatEstadoDelBien_catEstadoDelBienid",
                        column: x => x.catEstadoDelBienid,
                        principalTable: "CatEstadoDelBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_CatGarantia_catGarantiaid",
                        column: x => x.catGarantiaid,
                        principalTable: "CatGarantia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_CatPiso_catPisosid",
                        column: x => x.catPisosid,
                        principalTable: "CatPiso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~",
                        column: x => x.catTipoDeBienesCatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_CatTipoEntrada_catTipoEntradaid",
                        column: x => x.catTipoEntradaid,
                        principalTable: "CatTipoEntrada",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_CatTipoPartida_catTipoPartidaid",
                        column: x => x.catTipoPartidaid,
                        principalTable: "CatTipoPartida",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblAreaServicio_IdAreaServicioid",
                        column: x => x.IdAreaServicioid,
                        principalTable: "TblAreaServicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblClaveCambs_IdClaveCabmsid",
                        column: x => x.IdClaveCabmsid,
                        principalTable: "TblClaveCambs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblClaveSaica_IdClaveSaicaid",
                        column: x => x.IdClaveSaicaid,
                        principalTable: "TblClaveSaica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblContratoBien_IdContratoBienid",
                        column: x => x.IdContratoBienid,
                        principalTable: "TblContratoBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblFacturas_IdFacturasIdFactura",
                        column: x => x.IdFacturasIdFactura,
                        principalTable: "TblFacturas",
                        principalColumn: "IdFactura",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblFederalizacion_IdFederalizacionid",
                        column: x => x.IdFederalizacionid,
                        principalTable: "TblFederalizacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblInventarios_IdInventarioid",
                        column: x => x.IdInventarioid,
                        principalTable: "TblInventarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblProveedor_IdProveedorid",
                        column: x => x.IdProveedorid,
                        principalTable: "TblProveedor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblResguardatarios_IdResguardatariosid",
                        column: x => x.IdResguardatariosid,
                        principalTable: "TblResguardatarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblBienesMuebles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    marca = table.Column<string>(nullable: true),
                    modelo = table.Column<string>(nullable: true),
                    serie = table.Column<string>(nullable: true),
                    catEstadoDelBienid = table.Column<int>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    cantidad = table.Column<int>(nullable: false),
                    catGarantiaid = table.Column<int>(nullable: true),
                    catTipoEntradaid = table.Column<int>(nullable: true),
                    catTipoPartidaid = table.Column<int>(nullable: true),
                    observaciones = table.Column<string>(nullable: true),
                    catPisosid = table.Column<int>(nullable: true),
                    IProveedorid = table.Column<int>(nullable: true),
                    IdAreaServicioid = table.Column<int>(nullable: true),
                    IdClaveSaicaid = table.Column<int>(nullable: true),
                    IdContratoBienid = table.Column<int>(nullable: true),
                    IdFederalizacionid = table.Column<int>(nullable: true),
                    IdInventariosid = table.Column<int>(nullable: true),
                    IdResguardatariosid = table.Column<int>(nullable: true),
                    IdClaveCabmsid = table.Column<int>(nullable: true),
                    IdFacturasIdFactura = table.Column<int>(nullable: true),
                    catTipoDeBienesCatTipoDeBienId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBienesMuebles", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_CatEstadoDelBien_catEstadoDelBienid",
                        column: x => x.catEstadoDelBienid,
                        principalTable: "CatEstadoDelBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_CatGarantia_catGarantiaid",
                        column: x => x.catGarantiaid,
                        principalTable: "CatGarantia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_CatPiso_catPisosid",
                        column: x => x.catPisosid,
                        principalTable: "CatPiso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesCatTipoDeBien~",
                        column: x => x.catTipoDeBienesCatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_CatTipoEntrada_catTipoEntradaid",
                        column: x => x.catTipoEntradaid,
                        principalTable: "CatTipoEntrada",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_CatTipoPartida_catTipoPartidaid",
                        column: x => x.catTipoPartidaid,
                        principalTable: "CatTipoPartida",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_TblAreaServicio_IdAreaServicioid",
                        column: x => x.IdAreaServicioid,
                        principalTable: "TblAreaServicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_TblClaveCambs_IdClaveCabmsid",
                        column: x => x.IdClaveCabmsid,
                        principalTable: "TblClaveCambs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_TblClaveSaica_IdClaveSaicaid",
                        column: x => x.IdClaveSaicaid,
                        principalTable: "TblClaveSaica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_TblContratoBien_IdContratoBienid",
                        column: x => x.IdContratoBienid,
                        principalTable: "TblContratoBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_TblFacturas_IdFacturasIdFactura",
                        column: x => x.IdFacturasIdFactura,
                        principalTable: "TblFacturas",
                        principalColumn: "IdFactura",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_TblFederalizacion_IdFederalizacionid",
                        column: x => x.IdFederalizacionid,
                        principalTable: "TblFederalizacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_TblInventarios_IdInventariosid",
                        column: x => x.IdInventariosid,
                        principalTable: "TblInventarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_TblResguardatarios_IdResguardatariosid",
                        column: x => x.IdResguardatariosid,
                        principalTable: "TblResguardatarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesMuebles_TblProveedor_IProveedorid",
                        column: x => x.IProveedorid,
                        principalTable: "TblProveedor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblBienesSistemas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    marca = table.Column<string>(nullable: true),
                    modelo = table.Column<string>(nullable: true),
                    serie = table.Column<string>(nullable: true),
                    cantidad = table.Column<int>(nullable: false),
                    catGarantiaid = table.Column<int>(nullable: true),
                    catTipoPartidaid = table.Column<int>(nullable: true),
                    catTipoEntradaid = table.Column<int>(nullable: true),
                    catPisosid = table.Column<int>(nullable: true),
                    catEstadoDelBienid = table.Column<int>(nullable: true),
                    observaciones = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    IdAreaServicioid = table.Column<int>(nullable: true),
                    IdClaveSaicaid = table.Column<int>(nullable: true),
                    IdContratoBienid = table.Column<int>(nullable: true),
                    IdFederalizacionid = table.Column<int>(nullable: true),
                    IdInventariosid = table.Column<int>(nullable: true),
                    IdProveedorid = table.Column<int>(nullable: true),
                    IdResguardatariosid = table.Column<int>(nullable: true),
                    IdClaveCabmsid = table.Column<int>(nullable: true),
                    IdFacturasIdFactura = table.Column<int>(nullable: true),
                    catTipoDeBienesCatTipoDeBienId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBienesSistemas", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_CatEstadoDelBien_catEstadoDelBienid",
                        column: x => x.catEstadoDelBienid,
                        principalTable: "CatEstadoDelBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_CatGarantia_catGarantiaid",
                        column: x => x.catGarantiaid,
                        principalTable: "CatGarantia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_CatPiso_catPisosid",
                        column: x => x.catPisosid,
                        principalTable: "CatPiso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesCatTipoDeBie~",
                        column: x => x.catTipoDeBienesCatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_CatTipoEntrada_catTipoEntradaid",
                        column: x => x.catTipoEntradaid,
                        principalTable: "CatTipoEntrada",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_CatTipoPartida_catTipoPartidaid",
                        column: x => x.catTipoPartidaid,
                        principalTable: "CatTipoPartida",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblAreaServicio_IdAreaServicioid",
                        column: x => x.IdAreaServicioid,
                        principalTable: "TblAreaServicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblClaveCambs_IdClaveCabmsid",
                        column: x => x.IdClaveCabmsid,
                        principalTable: "TblClaveCambs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblClaveSaica_IdClaveSaicaid",
                        column: x => x.IdClaveSaicaid,
                        principalTable: "TblClaveSaica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblContratoBien_IdContratoBienid",
                        column: x => x.IdContratoBienid,
                        principalTable: "TblContratoBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblFacturas_IdFacturasIdFactura",
                        column: x => x.IdFacturasIdFactura,
                        principalTable: "TblFacturas",
                        principalColumn: "IdFactura",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblFederalizacion_IdFederalizacionid",
                        column: x => x.IdFederalizacionid,
                        principalTable: "TblFederalizacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblInventarios_IdInventariosid",
                        column: x => x.IdInventariosid,
                        principalTable: "TblInventarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblProveedor_IdProveedorid",
                        column: x => x.IdProveedorid,
                        principalTable: "TblProveedor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblResguardatarios_IdResguardatariosid",
                        column: x => x.IdResguardatariosid,
                        principalTable: "TblResguardatarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblInstrumentalMedico",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    marca = table.Column<string>(nullable: true),
                    modelo = table.Column<string>(nullable: true),
                    serie = table.Column<string>(nullable: true),
                    cantidad = table.Column<int>(nullable: false),
                    catGarantiaid = table.Column<int>(nullable: true),
                    catTipoPartidaid = table.Column<int>(nullable: true),
                    catTipoEntradaid = table.Column<int>(nullable: true),
                    catPisosid = table.Column<int>(nullable: true),
                    catEstadoDelBienid = table.Column<int>(nullable: true),
                    observaciones = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    IdAreaServicioid = table.Column<int>(nullable: true),
                    IdClaveCambsid = table.Column<int>(nullable: true),
                    IdClaveSaicaid = table.Column<int>(nullable: true),
                    IdContratoBienid = table.Column<int>(nullable: true),
                    IdFederalizacionid = table.Column<int>(nullable: true),
                    IdInventariosid = table.Column<int>(nullable: true),
                    IdProveedorid = table.Column<int>(nullable: true),
                    IdResguardatariosid = table.Column<int>(nullable: true),
                    IdFacturasIdFactura = table.Column<int>(nullable: true),
                    catTipoDeBienesCatTipoDeBienId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblInstrumentalMedico", x => x.id);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_CatEstadoDelBien_catEstadoDelBienid",
                        column: x => x.catEstadoDelBienid,
                        principalTable: "CatEstadoDelBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_CatGarantia_catGarantiaid",
                        column: x => x.catGarantiaid,
                        principalTable: "CatGarantia",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_CatPiso_catPisosid",
                        column: x => x.catPisosid,
                        principalTable: "CatPiso",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesCatTipoD~",
                        column: x => x.catTipoDeBienesCatTipoDeBienId,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "CatTipoDeBienId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_CatTipoEntrada_catTipoEntradaid",
                        column: x => x.catTipoEntradaid,
                        principalTable: "CatTipoEntrada",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_CatTipoPartida_catTipoPartidaid",
                        column: x => x.catTipoPartidaid,
                        principalTable: "CatTipoPartida",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblAreaServicio_IdAreaServicioid",
                        column: x => x.IdAreaServicioid,
                        principalTable: "TblAreaServicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblClaveCambs_IdClaveCambsid",
                        column: x => x.IdClaveCambsid,
                        principalTable: "TblClaveCambs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblClaveSaica_IdClaveSaicaid",
                        column: x => x.IdClaveSaicaid,
                        principalTable: "TblClaveSaica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblContratoBien_IdContratoBienid",
                        column: x => x.IdContratoBienid,
                        principalTable: "TblContratoBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblFacturas_IdFacturasIdFactura",
                        column: x => x.IdFacturasIdFactura,
                        principalTable: "TblFacturas",
                        principalColumn: "IdFactura",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblFederalizacion_IdFederalizacionid",
                        column: x => x.IdFederalizacionid,
                        principalTable: "TblFederalizacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblInventarios_IdInventariosid",
                        column: x => x.IdInventariosid,
                        principalTable: "TblInventarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblProveedor_IdProveedorid",
                        column: x => x.IdProveedorid,
                        principalTable: "TblProveedor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblResguardatarios_IdResguardatariosid",
                        column: x => x.IdResguardatariosid,
                        principalTable: "TblResguardatarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblSalidas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    catTipoSalidaid = table.Column<int>(nullable: true),
                    catUnidadDestinoid = table.Column<int>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false),
                    CatTipoDeBienId = table.Column<int>(nullable: true),
                    IdBien = table.Column<int>(nullable: false),
                    TblBienesEquMedicoId = table.Column<int>(nullable: true),
                    TblBienesMueblesId = table.Column<int>(nullable: true),
                    TblBienesSistemasId = table.Column<int>(nullable: true),
                    TblInstrumentalMedicoId = table.Column<int>(nullable: true)
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
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidas_TblBienesSistemas_TblBienesSistemasId",
                        column: x => x.TblBienesSistemasId,
                        principalTable: "TblBienesSistemas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblSalidas_TblInstrumentalMedico_TblInstrumentalMedicoId",
                        column: x => x.TblInstrumentalMedicoId,
                        principalTable: "TblInstrumentalMedico",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_catSexoid",
                table: "TblResguardatarios",
                column: "catSexoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_TblAreaServicioid",
                table: "TblResguardatarios",
                column: "TblAreaServicioid");

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
                name: "IX_CtrlUsuarios_IdAreaServicioid",
                table: "CtrlUsuarios",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshToken_Userid",
                table: "RefreshToken",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_TblAreaServicio_catareaid",
                table: "TblAreaServicio",
                column: "catareaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblAreaServicio_catservicioid",
                table: "TblAreaServicio",
                column: "catservicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catEstadoDelBienid",
                table: "TblBienesEquMedico",
                column: "catEstadoDelBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catGarantiaid",
                table: "TblBienesEquMedico",
                column: "catGarantiaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catPisosid",
                table: "TblBienesEquMedico",
                column: "catPisosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesEquMedico",
                column: "catTipoDeBienesCatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catTipoEntradaid",
                table: "TblBienesEquMedico",
                column: "catTipoEntradaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catTipoPartidaid",
                table: "TblBienesEquMedico",
                column: "catTipoPartidaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdAreaServicioid",
                table: "TblBienesEquMedico",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdClaveCabmsid",
                table: "TblBienesEquMedico",
                column: "IdClaveCabmsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdClaveSaicaid",
                table: "TblBienesEquMedico",
                column: "IdClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdContratoBienid",
                table: "TblBienesEquMedico",
                column: "IdContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdFacturasIdFactura",
                table: "TblBienesEquMedico",
                column: "IdFacturasIdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdFederalizacionid",
                table: "TblBienesEquMedico",
                column: "IdFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdInventarioid",
                table: "TblBienesEquMedico",
                column: "IdInventarioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdProveedorid",
                table: "TblBienesEquMedico",
                column: "IdProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdResguardatariosid",
                table: "TblBienesEquMedico",
                column: "IdResguardatariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_catEstadoDelBienid",
                table: "TblBienesMuebles",
                column: "catEstadoDelBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_catGarantiaid",
                table: "TblBienesMuebles",
                column: "catGarantiaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_catPisosid",
                table: "TblBienesMuebles",
                column: "catPisosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesMuebles",
                column: "catTipoDeBienesCatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_catTipoEntradaid",
                table: "TblBienesMuebles",
                column: "catTipoEntradaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_catTipoPartidaid",
                table: "TblBienesMuebles",
                column: "catTipoPartidaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdAreaServicioid",
                table: "TblBienesMuebles",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdClaveCabmsid",
                table: "TblBienesMuebles",
                column: "IdClaveCabmsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdClaveSaicaid",
                table: "TblBienesMuebles",
                column: "IdClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdContratoBienid",
                table: "TblBienesMuebles",
                column: "IdContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdFacturasIdFactura",
                table: "TblBienesMuebles",
                column: "IdFacturasIdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdFederalizacionid",
                table: "TblBienesMuebles",
                column: "IdFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdInventariosid",
                table: "TblBienesMuebles",
                column: "IdInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdResguardatariosid",
                table: "TblBienesMuebles",
                column: "IdResguardatariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IProveedorid",
                table: "TblBienesMuebles",
                column: "IProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catEstadoDelBienid",
                table: "TblBienesSistemas",
                column: "catEstadoDelBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catGarantiaid",
                table: "TblBienesSistemas",
                column: "catGarantiaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catPisosid",
                table: "TblBienesSistemas",
                column: "catPisosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesSistemas",
                column: "catTipoDeBienesCatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catTipoEntradaid",
                table: "TblBienesSistemas",
                column: "catTipoEntradaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catTipoPartidaid",
                table: "TblBienesSistemas",
                column: "catTipoPartidaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdAreaServicioid",
                table: "TblBienesSistemas",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdClaveCabmsid",
                table: "TblBienesSistemas",
                column: "IdClaveCabmsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdClaveSaicaid",
                table: "TblBienesSistemas",
                column: "IdClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdContratoBienid",
                table: "TblBienesSistemas",
                column: "IdContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdFacturasIdFactura",
                table: "TblBienesSistemas",
                column: "IdFacturasIdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdFederalizacionid",
                table: "TblBienesSistemas",
                column: "IdFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdInventariosid",
                table: "TblBienesSistemas",
                column: "IdInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdProveedorid",
                table: "TblBienesSistemas",
                column: "IdProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdResguardatariosid",
                table: "TblBienesSistemas",
                column: "IdResguardatariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblClaveCambs_CatTipoDeBienId",
                table: "TblClaveCambs",
                column: "CatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblClaveSaica_CatTipoDeBienId",
                table: "TblClaveSaica",
                column: "CatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_IdPermisoid",
                table: "TblConfPerfil",
                column: "IdPermisoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_IdRolid",
                table: "TblConfPerfil",
                column: "IdRolid");

            migrationBuilder.CreateIndex(
                name: "IX_TblContratoBien_CatTipoDeBienId",
                table: "TblContratoBien",
                column: "CatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFacturas_CatTipoDeBienId",
                table: "TblFacturas",
                column: "CatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblFederalizacion_CatTipoDeBienId",
                table: "TblFederalizacion",
                column: "CatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catEstadoDelBienid",
                table: "TblInstrumentalMedico",
                column: "catEstadoDelBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catGarantiaid",
                table: "TblInstrumentalMedico",
                column: "catGarantiaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catPisosid",
                table: "TblInstrumentalMedico",
                column: "catPisosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catTipoDeBienesCatTipoDeBienId",
                table: "TblInstrumentalMedico",
                column: "catTipoDeBienesCatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catTipoEntradaid",
                table: "TblInstrumentalMedico",
                column: "catTipoEntradaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catTipoPartidaid",
                table: "TblInstrumentalMedico",
                column: "catTipoPartidaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdAreaServicioid",
                table: "TblInstrumentalMedico",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdClaveCambsid",
                table: "TblInstrumentalMedico",
                column: "IdClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdClaveSaicaid",
                table: "TblInstrumentalMedico",
                column: "IdClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdContratoBienid",
                table: "TblInstrumentalMedico",
                column: "IdContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasIdFactura",
                table: "TblInstrumentalMedico",
                column: "IdFacturasIdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdFederalizacionid",
                table: "TblInstrumentalMedico",
                column: "IdFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdInventariosid",
                table: "TblInstrumentalMedico",
                column: "IdInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdProveedorid",
                table: "TblInstrumentalMedico",
                column: "IdProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdResguardatariosid",
                table: "TblInstrumentalMedico",
                column: "IdResguardatariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInventarios_CatTipoDeBienId",
                table: "TblInventarios",
                column: "CatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblProveedor_CatTipoDeBienId",
                table: "TblProveedor",
                column: "CatTipoDeBienId");

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
                name: "FK_CtrlUsuarios_CatEstatus_catEstatusid",
                table: "CtrlUsuarios",
                column: "catEstatusid",
                principalTable: "CatEstatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatRol_catRolid",
                table: "CtrlUsuarios",
                column: "catRolid",
                principalTable: "CatRol",
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
                name: "FK_CtrlUsuarios_TblAreaServicio_IdAreaServicioid",
                table: "CtrlUsuarios",
                column: "IdAreaServicioid",
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

            migrationBuilder.AddForeignKey(
                name: "FK_TblResguardatarios_TblAreaServicio_TblAreaServicioid",
                table: "TblResguardatarios",
                column: "TblAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatEstatus_catEstatusid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatRol_catRolid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatTipoContrato_catTipoContratoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatTurno_catTurnoid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_TblAreaServicio_IdAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatSexo_catSexoid",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_TblAreaServicio_TblAreaServicioid",
                table: "TblResguardatarios");

            migrationBuilder.DropTable(
                name: "RefreshToken");

            migrationBuilder.DropTable(
                name: "TblConfPerfil");

            migrationBuilder.DropTable(
                name: "TblSalidas");

            migrationBuilder.DropTable(
                name: "CatPermiso");

            migrationBuilder.DropTable(
                name: "CatTipoSalida");

            migrationBuilder.DropTable(
                name: "CatUnidadDestino");

            migrationBuilder.DropTable(
                name: "TblBienesEquMedico");

            migrationBuilder.DropTable(
                name: "TblBienesMuebles");

            migrationBuilder.DropTable(
                name: "TblBienesSistemas");

            migrationBuilder.DropTable(
                name: "TblInstrumentalMedico");

            migrationBuilder.DropTable(
                name: "CatGarantia");

            migrationBuilder.DropTable(
                name: "CatPiso");

            migrationBuilder.DropTable(
                name: "CatTipoEntrada");

            migrationBuilder.DropTable(
                name: "CatTipoPartida");

            migrationBuilder.DropTable(
                name: "TblAreaServicio");

            migrationBuilder.DropTable(
                name: "TblClaveCambs");

            migrationBuilder.DropTable(
                name: "TblClaveSaica");

            migrationBuilder.DropTable(
                name: "TblContratoBien");

            migrationBuilder.DropTable(
                name: "TblFacturas");

            migrationBuilder.DropTable(
                name: "TblFederalizacion");

            migrationBuilder.DropTable(
                name: "TblInventarios");

            migrationBuilder.DropTable(
                name: "TblProveedor");

            migrationBuilder.DropTable(
                name: "CatArea");

            migrationBuilder.DropIndex(
                name: "IX_TblResguardatarios_catSexoid",
                table: "TblResguardatarios");

            migrationBuilder.DropIndex(
                name: "IX_TblResguardatarios_TblAreaServicioid",
                table: "TblResguardatarios");

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
                name: "IX_CtrlUsuarios_IdAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatTipoDeBien",
                table: "CatTipoDeBien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatRol",
                table: "CatRol");

            migrationBuilder.DropColumn(
                name: "cargo",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "catSexoid",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "numeroempleado",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "plaza",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "RFC",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "TblAreaServicioid",
                table: "TblResguardatarios");

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
                name: "IdAreaServicioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idTok",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "numeroempleado",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "plaza",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "RFC",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "CatTurno");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienId",
                table: "CatTipoDeBien");

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
                table: "CatRol");

            migrationBuilder.DropColumn(
                name: "fechaMod",
                table: "CatRol");

            migrationBuilder.DropColumn(
                name: "idUsuarioAlta",
                table: "CatRol");

            migrationBuilder.DropColumn(
                name: "idusuarioMod",
                table: "CatRol");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "CatEstatus");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "CatEstadoDelBien");

            migrationBuilder.RenameTable(
                name: "CatRol",
                newName: "catRol");

            migrationBuilder.AddColumn<int>(
                name: "idEstatus",
                table: "TblResguardatarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idServicio",
                table: "TblResguardatarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTipoContrato",
                table: "TblResguardatarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTurno",
                table: "TblResguardatarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CtrlUsuarios",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "'0001-01-01 00:00:00'::timestamp without time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaAlta",
                table: "CtrlUsuarios",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldDefaultValueSql: "'0001-01-01 00:00:00'::timestamp without time zone");

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
                name: "idRol",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idServicio",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idSexo",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTipoBien",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "CatTipoDeBien",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatTipoDeBien",
                table: "CatTipoDeBien",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_catRol",
                table: "catRol",
                column: "id");

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

            migrationBuilder.CreateTable(
                name: "TblBienes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IVA = table.Column<double>(type: "double precision", nullable: false),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    catEstadoDelBienid = table.Column<int>(type: "integer", nullable: true),
                    catTipoDeBienesid = table.Column<int>(type: "integer", nullable: true),
                    cat_Horarioid = table.Column<int>(type: "integer", nullable: true),
                    claveCambs = table.Column<string>(type: "text", nullable: true),
                    claveSaica = table.Column<string>(type: "text", nullable: true),
                    costoTotal = table.Column<double>(type: "double precision", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    fechaAlta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fechaMod = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    idEstadoFisico = table.Column<int>(type: "integer", nullable: false),
                    idFactura = table.Column<int>(type: "integer", nullable: false),
                    idResguardatario = table.Column<int>(type: "integer", nullable: false),
                    idServicio = table.Column<int>(type: "integer", nullable: false),
                    idTipoBien = table.Column<int>(type: "integer", nullable: false),
                    idUsuarioAlta = table.Column<int>(type: "integer", nullable: false),
                    marca = table.Column<string>(type: "text", nullable: true),
                    modelo = table.Column<string>(type: "text", nullable: true),
                    numeroInventario = table.Column<int>(type: "integer", nullable: false),
                    serie = table.Column<string>(type: "text", nullable: true),
                    tblResguardatariosid = table.Column<int>(type: "integer", nullable: true),
                    usuarioMod = table.Column<int>(type: "integer", nullable: false)
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
                name: "IX_CtrlUsuarios_cat_horarioid",
                table: "CtrlUsuarios",
                column: "cat_horarioid");

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
        }
    }
}
