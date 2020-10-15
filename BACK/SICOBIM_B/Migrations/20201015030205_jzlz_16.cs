using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_CatEstadoDelBien_catEstadoDelBienid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_CatGarantia_catGarantiaid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_CatPiso_catPisosid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_CatTipoDeBien_catTipoDeBienesid",
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
                name: "FK_TblBienes_TblResguardatarios_tblResguardatariosid",
                table: "TblBienes");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_TblBienes_tblbienesid",
                table: "TblSalidaBien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblBienes",
                table: "TblBienes");

            migrationBuilder.DropIndex(
                name: "IX_TblBienes_catUnidadDestinoid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "partida",
                table: "CatTipoPartida");

            migrationBuilder.DropColumn(
                name: "IVA",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "catUnidadDestinoid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "claveCambs",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "claveSaica",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "contrato",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "costoTotal",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "idunidaddestino",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "numeroInventario",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "numerofederalizacion",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "proveedor",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "subtotal",
                table: "TblBienes");

            migrationBuilder.RenameTable(
                name: "TblBienes",
                newName: "TblBienesMuebles");

            migrationBuilder.RenameColumn(
                name: "idFactura",
                table: "TblBienesMuebles",
                newName: "idfactura");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienes_tblResguardatariosid",
                table: "TblBienesMuebles",
                newName: "IX_TblBienesMuebles_tblResguardatariosid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienes_tblInventariosid",
                table: "TblBienesMuebles",
                newName: "IX_TblBienesMuebles_tblInventariosid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienes_tblFacturasid",
                table: "TblBienesMuebles",
                newName: "IX_TblBienesMuebles_tblFacturasid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienes_tblAreaServicioid",
                table: "TblBienesMuebles",
                newName: "IX_TblBienesMuebles_tblAreaServicioid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienes_catTipoPartidaid",
                table: "TblBienesMuebles",
                newName: "IX_TblBienesMuebles_catTipoPartidaid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienes_catTipoEntradaid",
                table: "TblBienesMuebles",
                newName: "IX_TblBienesMuebles_catTipoEntradaid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienes_catTipoDeBienesid",
                table: "TblBienesMuebles",
                newName: "IX_TblBienesMuebles_catTipoDeBienesid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienes_catPisosid",
                table: "TblBienesMuebles",
                newName: "IX_TblBienesMuebles_catPisosid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienes_catGarantiaid",
                table: "TblBienesMuebles",
                newName: "IX_TblBienesMuebles_catGarantiaid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienes_catEstadoDelBienid",
                table: "TblBienesMuebles",
                newName: "IX_TblBienesMuebles_catEstadoDelBienid");

            migrationBuilder.AddColumn<int>(
                name: "TblBienesEquMedicoid",
                table: "TblSalidaBien",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblBienesSistemasid",
                table: "TblSalidaBien",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblInstrumentalMedicoid",
                table: "TblSalidaBien",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "IVA",
                table: "TblFacturas",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "costoTotal",
                table: "TblFacturas",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "subtotal",
                table: "TblFacturas",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "partidapresupestual",
                table: "CatTipoPartida",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idclaveCambs",
                table: "TblBienesMuebles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "idclaveSaica",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idcontrato",
                table: "TblBienesMuebles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idfederalizacion",
                table: "TblBienesMuebles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idinventario",
                table: "TblBienesMuebles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idproveedor",
                table: "TblBienesMuebles",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tblClaveCambsid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblClaveSaicaid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblContratoBienid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblFederalizacionid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblProveedorid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblBienesMuebles",
                table: "TblBienesMuebles",
                column: "id");

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
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblClaveCambs", x => x.id);
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
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblClaveSaica", x => x.id);
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
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblContratoBien", x => x.id);
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
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblFederalizacion", x => x.id);
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
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblProveedor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TblBienesEquMedico",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idfederalizacion = table.Column<int>(nullable: false),
                    tblFederalizacionid = table.Column<int>(nullable: true),
                    idinventario = table.Column<int>(nullable: false),
                    tblInventariosid = table.Column<int>(nullable: true),
                    marca = table.Column<string>(nullable: true),
                    modelo = table.Column<string>(nullable: true),
                    serie = table.Column<string>(nullable: true),
                    cantidad = table.Column<int>(nullable: false),
                    idcontrato = table.Column<int>(nullable: false),
                    tblContratoBienid = table.Column<int>(nullable: true),
                    idproveedor = table.Column<int>(nullable: false),
                    tblProveedorid = table.Column<int>(nullable: true),
                    idfactura = table.Column<int>(nullable: false),
                    tblFacturasid = table.Column<int>(nullable: true),
                    idAñosGarantia = table.Column<int>(nullable: false),
                    catGarantiaid = table.Column<int>(nullable: true),
                    idtipopartida = table.Column<int>(nullable: false),
                    catTipoPartidaid = table.Column<int>(nullable: true),
                    idclaveCambs = table.Column<int>(nullable: false),
                    tblClaveCambsid = table.Column<int>(nullable: true),
                    idclaveSaica = table.Column<string>(nullable: true),
                    tblClaveSaicaid = table.Column<int>(nullable: true),
                    identrada = table.Column<int>(nullable: false),
                    catTipoEntradaid = table.Column<int>(nullable: true),
                    idServicio = table.Column<int>(nullable: false),
                    tblAreaServicioid = table.Column<int>(nullable: true),
                    idpiso = table.Column<int>(nullable: false),
                    catPisosid = table.Column<int>(nullable: true),
                    idResguardatario = table.Column<int>(nullable: false),
                    tblResguardatariosid = table.Column<int>(nullable: true),
                    idTipoBien = table.Column<int>(nullable: false),
                    catTipoDeBienesid = table.Column<int>(nullable: true),
                    idEstadoFisico = table.Column<int>(nullable: false),
                    catEstadoDelBienid = table.Column<int>(nullable: true),
                    observaciones = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBienesEquMedico", x => x.id);
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
                        name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesid",
                        column: x => x.catTipoDeBienesid,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "id",
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
                        name: "FK_TblBienesEquMedico_TblAreaServicio_tblAreaServicioid",
                        column: x => x.tblAreaServicioid,
                        principalTable: "TblAreaServicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblClaveCambs_tblClaveCambsid",
                        column: x => x.tblClaveCambsid,
                        principalTable: "TblClaveCambs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblClaveSaica_tblClaveSaicaid",
                        column: x => x.tblClaveSaicaid,
                        principalTable: "TblClaveSaica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblContratoBien_tblContratoBienid",
                        column: x => x.tblContratoBienid,
                        principalTable: "TblContratoBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblFacturas_tblFacturasid",
                        column: x => x.tblFacturasid,
                        principalTable: "TblFacturas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblFederalizacion_tblFederalizacionid",
                        column: x => x.tblFederalizacionid,
                        principalTable: "TblFederalizacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblInventarios_tblInventariosid",
                        column: x => x.tblInventariosid,
                        principalTable: "TblInventarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblProveedor_tblProveedorid",
                        column: x => x.tblProveedorid,
                        principalTable: "TblProveedor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesEquMedico_TblResguardatarios_tblResguardatariosid",
                        column: x => x.tblResguardatariosid,
                        principalTable: "TblResguardatarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TblBienesSistemas",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idfederalizacion = table.Column<int>(nullable: false),
                    tblFederalizacionid = table.Column<int>(nullable: true),
                    idinventario = table.Column<int>(nullable: false),
                    tblInventariosid = table.Column<int>(nullable: true),
                    marca = table.Column<string>(nullable: true),
                    modelo = table.Column<string>(nullable: true),
                    serie = table.Column<string>(nullable: true),
                    cantidad = table.Column<int>(nullable: false),
                    idcontrato = table.Column<int>(nullable: false),
                    tblContratoBienid = table.Column<int>(nullable: true),
                    idproveedor = table.Column<int>(nullable: false),
                    tblProveedorid = table.Column<int>(nullable: true),
                    idfactura = table.Column<int>(nullable: false),
                    tblFacturasid = table.Column<int>(nullable: true),
                    idAñosGarantia = table.Column<int>(nullable: false),
                    catGarantiaid = table.Column<int>(nullable: true),
                    idtipopartida = table.Column<int>(nullable: false),
                    catTipoPartidaid = table.Column<int>(nullable: true),
                    idclaveCambs = table.Column<int>(nullable: false),
                    tblClaveCambsid = table.Column<int>(nullable: true),
                    idclaveSaica = table.Column<string>(nullable: true),
                    tblClaveSaicaid = table.Column<int>(nullable: true),
                    identrada = table.Column<int>(nullable: false),
                    catTipoEntradaid = table.Column<int>(nullable: true),
                    idServicio = table.Column<int>(nullable: false),
                    tblAreaServicioid = table.Column<int>(nullable: true),
                    idpiso = table.Column<int>(nullable: false),
                    catPisosid = table.Column<int>(nullable: true),
                    idResguardatario = table.Column<int>(nullable: false),
                    tblResguardatariosid = table.Column<int>(nullable: true),
                    idTipoBien = table.Column<int>(nullable: false),
                    catTipoDeBienesid = table.Column<int>(nullable: true),
                    idEstadoFisico = table.Column<int>(nullable: false),
                    catEstadoDelBienid = table.Column<int>(nullable: true),
                    observaciones = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
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
                        name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesid",
                        column: x => x.catTipoDeBienesid,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "id",
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
                        name: "FK_TblBienesSistemas_TblAreaServicio_tblAreaServicioid",
                        column: x => x.tblAreaServicioid,
                        principalTable: "TblAreaServicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblClaveCambs_tblClaveCambsid",
                        column: x => x.tblClaveCambsid,
                        principalTable: "TblClaveCambs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblClaveSaica_tblClaveSaicaid",
                        column: x => x.tblClaveSaicaid,
                        principalTable: "TblClaveSaica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblContratoBien_tblContratoBienid",
                        column: x => x.tblContratoBienid,
                        principalTable: "TblContratoBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblFacturas_tblFacturasid",
                        column: x => x.tblFacturasid,
                        principalTable: "TblFacturas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblFederalizacion_tblFederalizacionid",
                        column: x => x.tblFederalizacionid,
                        principalTable: "TblFederalizacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblInventarios_tblInventariosid",
                        column: x => x.tblInventariosid,
                        principalTable: "TblInventarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblProveedor_tblProveedorid",
                        column: x => x.tblProveedorid,
                        principalTable: "TblProveedor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblBienesSistemas_TblResguardatarios_tblResguardatariosid",
                        column: x => x.tblResguardatariosid,
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
                    idfederalizacion = table.Column<int>(nullable: false),
                    tblFederalizacionid = table.Column<int>(nullable: true),
                    idinventario = table.Column<int>(nullable: false),
                    tblInventariosid = table.Column<int>(nullable: true),
                    marca = table.Column<string>(nullable: true),
                    modelo = table.Column<string>(nullable: true),
                    serie = table.Column<string>(nullable: true),
                    cantidad = table.Column<int>(nullable: false),
                    idcontrato = table.Column<int>(nullable: false),
                    tblContratoBienid = table.Column<int>(nullable: true),
                    idproveedor = table.Column<int>(nullable: false),
                    tblProveedorid = table.Column<int>(nullable: true),
                    idfactura = table.Column<int>(nullable: false),
                    tblFacturasid = table.Column<int>(nullable: true),
                    idAñosGarantia = table.Column<int>(nullable: false),
                    catGarantiaid = table.Column<int>(nullable: true),
                    idtipopartida = table.Column<int>(nullable: false),
                    catTipoPartidaid = table.Column<int>(nullable: true),
                    idclaveCambs = table.Column<int>(nullable: false),
                    tblClaveCambsid = table.Column<int>(nullable: true),
                    idclaveSaica = table.Column<string>(nullable: true),
                    tblClaveSaicaid = table.Column<int>(nullable: true),
                    identrada = table.Column<int>(nullable: false),
                    catTipoEntradaid = table.Column<int>(nullable: true),
                    idServicio = table.Column<int>(nullable: false),
                    tblAreaServicioid = table.Column<int>(nullable: true),
                    idpiso = table.Column<int>(nullable: false),
                    catPisosid = table.Column<int>(nullable: true),
                    idResguardatario = table.Column<int>(nullable: false),
                    tblResguardatariosid = table.Column<int>(nullable: true),
                    idTipoBien = table.Column<int>(nullable: false),
                    catTipoDeBienesid = table.Column<int>(nullable: true),
                    idEstadoFisico = table.Column<int>(nullable: false),
                    catEstadoDelBienid = table.Column<int>(nullable: true),
                    observaciones = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
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
                        name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesid",
                        column: x => x.catTipoDeBienesid,
                        principalTable: "CatTipoDeBien",
                        principalColumn: "id",
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
                        name: "FK_TblInstrumentalMedico_TblAreaServicio_tblAreaServicioid",
                        column: x => x.tblAreaServicioid,
                        principalTable: "TblAreaServicio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblClaveCambs_tblClaveCambsid",
                        column: x => x.tblClaveCambsid,
                        principalTable: "TblClaveCambs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblClaveSaica_tblClaveSaicaid",
                        column: x => x.tblClaveSaicaid,
                        principalTable: "TblClaveSaica",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblContratoBien_tblContratoBienid",
                        column: x => x.tblContratoBienid,
                        principalTable: "TblContratoBien",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblFacturas_tblFacturasid",
                        column: x => x.tblFacturasid,
                        principalTable: "TblFacturas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblFederalizacion_tblFederalizacionid",
                        column: x => x.tblFederalizacionid,
                        principalTable: "TblFederalizacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblInventarios_tblInventariosid",
                        column: x => x.tblInventariosid,
                        principalTable: "TblInventarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblProveedor_tblProveedorid",
                        column: x => x.tblProveedorid,
                        principalTable: "TblProveedor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TblInstrumentalMedico_TblResguardatarios_tblResguardatarios~",
                        column: x => x.tblResguardatariosid,
                        principalTable: "TblResguardatarios",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidaBien_TblBienesEquMedicoid",
                table: "TblSalidaBien",
                column: "TblBienesEquMedicoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidaBien_TblBienesSistemasid",
                table: "TblSalidaBien",
                column: "TblBienesSistemasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidaBien_TblInstrumentalMedicoid",
                table: "TblSalidaBien",
                column: "TblInstrumentalMedicoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblClaveCambsid",
                table: "TblBienesMuebles",
                column: "tblClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblClaveSaicaid",
                table: "TblBienesMuebles",
                column: "tblClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblContratoBienid",
                table: "TblBienesMuebles",
                column: "tblContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblFederalizacionid",
                table: "TblBienesMuebles",
                column: "tblFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblProveedorid",
                table: "TblBienesMuebles",
                column: "tblProveedorid");

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
                name: "IX_TblBienesEquMedico_catTipoDeBienesid",
                table: "TblBienesEquMedico",
                column: "catTipoDeBienesid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catTipoEntradaid",
                table: "TblBienesEquMedico",
                column: "catTipoEntradaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catTipoPartidaid",
                table: "TblBienesEquMedico",
                column: "catTipoPartidaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblAreaServicioid",
                table: "TblBienesEquMedico",
                column: "tblAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblClaveCambsid",
                table: "TblBienesEquMedico",
                column: "tblClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblClaveSaicaid",
                table: "TblBienesEquMedico",
                column: "tblClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblContratoBienid",
                table: "TblBienesEquMedico",
                column: "tblContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblFacturasid",
                table: "TblBienesEquMedico",
                column: "tblFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblFederalizacionid",
                table: "TblBienesEquMedico",
                column: "tblFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblInventariosid",
                table: "TblBienesEquMedico",
                column: "tblInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblProveedorid",
                table: "TblBienesEquMedico",
                column: "tblProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblResguardatariosid",
                table: "TblBienesEquMedico",
                column: "tblResguardatariosid");

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
                name: "IX_TblBienesSistemas_catTipoDeBienesid",
                table: "TblBienesSistemas",
                column: "catTipoDeBienesid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catTipoEntradaid",
                table: "TblBienesSistemas",
                column: "catTipoEntradaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catTipoPartidaid",
                table: "TblBienesSistemas",
                column: "catTipoPartidaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblAreaServicioid",
                table: "TblBienesSistemas",
                column: "tblAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblClaveCambsid",
                table: "TblBienesSistemas",
                column: "tblClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblClaveSaicaid",
                table: "TblBienesSistemas",
                column: "tblClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblContratoBienid",
                table: "TblBienesSistemas",
                column: "tblContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblFacturasid",
                table: "TblBienesSistemas",
                column: "tblFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblFederalizacionid",
                table: "TblBienesSistemas",
                column: "tblFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblInventariosid",
                table: "TblBienesSistemas",
                column: "tblInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblProveedorid",
                table: "TblBienesSistemas",
                column: "tblProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblResguardatariosid",
                table: "TblBienesSistemas",
                column: "tblResguardatariosid");

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
                name: "IX_TblInstrumentalMedico_catTipoDeBienesid",
                table: "TblInstrumentalMedico",
                column: "catTipoDeBienesid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catTipoEntradaid",
                table: "TblInstrumentalMedico",
                column: "catTipoEntradaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catTipoPartidaid",
                table: "TblInstrumentalMedico",
                column: "catTipoPartidaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblAreaServicioid",
                table: "TblInstrumentalMedico",
                column: "tblAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblClaveCambsid",
                table: "TblInstrumentalMedico",
                column: "tblClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblClaveSaicaid",
                table: "TblInstrumentalMedico",
                column: "tblClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblContratoBienid",
                table: "TblInstrumentalMedico",
                column: "tblContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblFacturasid",
                table: "TblInstrumentalMedico",
                column: "tblFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblFederalizacionid",
                table: "TblInstrumentalMedico",
                column: "tblFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblInventariosid",
                table: "TblInstrumentalMedico",
                column: "tblInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblProveedorid",
                table: "TblInstrumentalMedico",
                column: "tblProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblResguardatariosid",
                table: "TblInstrumentalMedico",
                column: "tblResguardatariosid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatEstadoDelBien_catEstadoDelBienid",
                table: "TblBienesMuebles",
                column: "catEstadoDelBienid",
                principalTable: "CatEstadoDelBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatGarantia_catGarantiaid",
                table: "TblBienesMuebles",
                column: "catGarantiaid",
                principalTable: "CatGarantia",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatPiso_catPisosid",
                table: "TblBienesMuebles",
                column: "catPisosid",
                principalTable: "CatPiso",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesid",
                table: "TblBienesMuebles",
                column: "catTipoDeBienesid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatTipoEntrada_catTipoEntradaid",
                table: "TblBienesMuebles",
                column: "catTipoEntradaid",
                principalTable: "CatTipoEntrada",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatTipoPartida_catTipoPartidaid",
                table: "TblBienesMuebles",
                column: "catTipoPartidaid",
                principalTable: "CatTipoPartida",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblAreaServicio_tblAreaServicioid",
                table: "TblBienesMuebles",
                column: "tblAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_tblClaveCambsid",
                table: "TblBienesMuebles",
                column: "tblClaveCambsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblClaveSaica_tblClaveSaicaid",
                table: "TblBienesMuebles",
                column: "tblClaveSaicaid",
                principalTable: "TblClaveSaica",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblContratoBien_tblContratoBienid",
                table: "TblBienesMuebles",
                column: "tblContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_tblFacturasid",
                table: "TblBienesMuebles",
                column: "tblFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblFederalizacion_tblFederalizacionid",
                table: "TblBienesMuebles",
                column: "tblFederalizacionid",
                principalTable: "TblFederalizacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_tblInventariosid",
                table: "TblBienesMuebles",
                column: "tblInventariosid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblProveedor_tblProveedorid",
                table: "TblBienesMuebles",
                column: "tblProveedorid",
                principalTable: "TblProveedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblResguardatarios_tblResguardatariosid",
                table: "TblBienesMuebles",
                column: "tblResguardatariosid",
                principalTable: "TblResguardatarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_TblBienesEquMedico_TblBienesEquMedicoid",
                table: "TblSalidaBien",
                column: "TblBienesEquMedicoid",
                principalTable: "TblBienesEquMedico",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_TblBienesSistemas_TblBienesSistemasid",
                table: "TblSalidaBien",
                column: "TblBienesSistemasid",
                principalTable: "TblBienesSistemas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_TblInstrumentalMedico_TblInstrumentalMedicoid",
                table: "TblSalidaBien",
                column: "TblInstrumentalMedicoid",
                principalTable: "TblInstrumentalMedico",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_TblBienesMuebles_tblbienesid",
                table: "TblSalidaBien",
                column: "tblbienesid",
                principalTable: "TblBienesMuebles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatEstadoDelBien_catEstadoDelBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatGarantia_catGarantiaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatPiso_catPisosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatTipoEntrada_catTipoEntradaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatTipoPartida_catTipoPartidaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblAreaServicio_tblAreaServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_tblClaveCambsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblClaveSaica_tblClaveSaicaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblContratoBien_tblContratoBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_tblFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFederalizacion_tblFederalizacionid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_tblInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblProveedor_tblProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblResguardatarios_tblResguardatariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_TblBienesEquMedico_TblBienesEquMedicoid",
                table: "TblSalidaBien");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_TblBienesSistemas_TblBienesSistemasid",
                table: "TblSalidaBien");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_TblInstrumentalMedico_TblInstrumentalMedicoid",
                table: "TblSalidaBien");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_TblBienesMuebles_tblbienesid",
                table: "TblSalidaBien");

            migrationBuilder.DropTable(
                name: "TblBienesEquMedico");

            migrationBuilder.DropTable(
                name: "TblBienesSistemas");

            migrationBuilder.DropTable(
                name: "TblInstrumentalMedico");

            migrationBuilder.DropTable(
                name: "TblClaveCambs");

            migrationBuilder.DropTable(
                name: "TblClaveSaica");

            migrationBuilder.DropTable(
                name: "TblContratoBien");

            migrationBuilder.DropTable(
                name: "TblFederalizacion");

            migrationBuilder.DropTable(
                name: "TblProveedor");

            migrationBuilder.DropIndex(
                name: "IX_TblSalidaBien_TblBienesEquMedicoid",
                table: "TblSalidaBien");

            migrationBuilder.DropIndex(
                name: "IX_TblSalidaBien_TblBienesSistemasid",
                table: "TblSalidaBien");

            migrationBuilder.DropIndex(
                name: "IX_TblSalidaBien_TblInstrumentalMedicoid",
                table: "TblSalidaBien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblBienesMuebles",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblClaveCambsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblClaveSaicaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblContratoBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblFederalizacionid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "TblBienesEquMedicoid",
                table: "TblSalidaBien");

            migrationBuilder.DropColumn(
                name: "TblBienesSistemasid",
                table: "TblSalidaBien");

            migrationBuilder.DropColumn(
                name: "TblInstrumentalMedicoid",
                table: "TblSalidaBien");

            migrationBuilder.DropColumn(
                name: "IVA",
                table: "TblFacturas");

            migrationBuilder.DropColumn(
                name: "costoTotal",
                table: "TblFacturas");

            migrationBuilder.DropColumn(
                name: "subtotal",
                table: "TblFacturas");

            migrationBuilder.DropColumn(
                name: "partidapresupestual",
                table: "CatTipoPartida");

            migrationBuilder.DropColumn(
                name: "idclaveCambs",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idclaveSaica",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idcontrato",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idfederalizacion",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idinventario",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idproveedor",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblClaveCambsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblClaveSaicaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblContratoBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblFederalizacionid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.RenameTable(
                name: "TblBienesMuebles",
                newName: "TblBienes");

            migrationBuilder.RenameColumn(
                name: "idfactura",
                table: "TblBienes",
                newName: "idFactura");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienesMuebles_tblResguardatariosid",
                table: "TblBienes",
                newName: "IX_TblBienes_tblResguardatariosid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienesMuebles_tblInventariosid",
                table: "TblBienes",
                newName: "IX_TblBienes_tblInventariosid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienesMuebles_tblFacturasid",
                table: "TblBienes",
                newName: "IX_TblBienes_tblFacturasid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienesMuebles_tblAreaServicioid",
                table: "TblBienes",
                newName: "IX_TblBienes_tblAreaServicioid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienesMuebles_catTipoPartidaid",
                table: "TblBienes",
                newName: "IX_TblBienes_catTipoPartidaid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienesMuebles_catTipoEntradaid",
                table: "TblBienes",
                newName: "IX_TblBienes_catTipoEntradaid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienesMuebles_catTipoDeBienesid",
                table: "TblBienes",
                newName: "IX_TblBienes_catTipoDeBienesid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienesMuebles_catPisosid",
                table: "TblBienes",
                newName: "IX_TblBienes_catPisosid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienesMuebles_catGarantiaid",
                table: "TblBienes",
                newName: "IX_TblBienes_catGarantiaid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienesMuebles_catEstadoDelBienid",
                table: "TblBienes",
                newName: "IX_TblBienes_catEstadoDelBienid");

            migrationBuilder.AddColumn<string>(
                name: "partida",
                table: "CatTipoPartida",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "IVA",
                table: "TblBienes",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "catUnidadDestinoid",
                table: "TblBienes",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "claveCambs",
                table: "TblBienes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "claveSaica",
                table: "TblBienes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "contrato",
                table: "TblBienes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "costoTotal",
                table: "TblBienes",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "idunidaddestino",
                table: "TblBienes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numeroInventario",
                table: "TblBienes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "numerofederalizacion",
                table: "TblBienes",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "proveedor",
                table: "TblBienes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "subtotal",
                table: "TblBienes",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblBienes",
                table: "TblBienes",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_catUnidadDestinoid",
                table: "TblBienes",
                column: "catUnidadDestinoid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_CatEstadoDelBien_catEstadoDelBienid",
                table: "TblBienes",
                column: "catEstadoDelBienid",
                principalTable: "CatEstadoDelBien",
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
                name: "FK_TblBienes_CatPiso_catPisosid",
                table: "TblBienes",
                column: "catPisosid",
                principalTable: "CatPiso",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_CatTipoDeBien_catTipoDeBienesid",
                table: "TblBienes",
                column: "catTipoDeBienesid",
                principalTable: "CatTipoDeBien",
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
                name: "FK_TblBienes_TblResguardatarios_tblResguardatariosid",
                table: "TblBienes",
                column: "tblResguardatariosid",
                principalTable: "TblResguardatarios",
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
    }
}
