using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class t14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_CatEstatus_catEstatusid",
                table: "CtrlUsuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesCatTipoDeBien~",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesCatTipoDeBie~",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveCambs");

            migrationBuilder.DropForeignKey(
                name: "FK_TblClaveSaica_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveSaica");

            migrationBuilder.DropForeignKey(
                name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblContratoBien");

            migrationBuilder.DropForeignKey(
                name: "FK_TblFacturas_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFacturas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblFederalizacion_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFederalizacion");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesCatTipoD~",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInventarios_CatTipoDeBien_CatTipoDeBienId",
                table: "TblInventarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblProveedor_CatTipoDeBien_CatTipoDeBienId",
                table: "TblProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_TblResguardatarios_CatEstatus_catEstatusid",
                table: "TblResguardatarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidasBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblSalidasBien");

            migrationBuilder.DropTable(
                name: "CatEstatus");

            migrationBuilder.DropIndex(
                name: "IX_TblResguardatarios_catEstatusid",
                table: "TblResguardatarios");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_catEstatusid",
                table: "CtrlUsuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatTipoDeBien",
                table: "CatTipoDeBien");

            migrationBuilder.DropColumn(
                name: "catEstatusid",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "catEstatusid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idusuarioMod",
                table: "CatUnidadDestino");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienId",
                table: "CatTipoDeBien");

            migrationBuilder.DropColumn(
                name: "idusuarioMod",
                table: "CatServicio");

            migrationBuilder.DropColumn(
                name: "usuarioAlta",
                table: "CatServicio");

            migrationBuilder.DropColumn(
                name: "idusuarioMod",
                table: "CatRol");

            migrationBuilder.DropColumn(
                name: "InsertDate",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "InsertUserId",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "IsBySystem",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "UpdateUserId",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "CatArea");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatUnidadDestino",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatUnidadDestino",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatUnidadDestino",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatUnidadDestino",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatUnidadDestino",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatUnidadDestino",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuarioMod",
                table: "CatTurno",
                newName: "UsuarioMod");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatTurno",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatTurno",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatTurno",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatTurno",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatTurno",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatTurno",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuarioMod",
                table: "CatTipoSalida",
                newName: "UsuarioMod");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatTipoSalida",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatTipoSalida",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatTipoSalida",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatTipoSalida",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatTipoSalida",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatTipoSalida",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuarioMod",
                table: "CatTipoPartida",
                newName: "UsuarioMod");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatTipoPartida",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatTipoPartida",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatTipoPartida",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatTipoPartida",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatTipoPartida",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatTipoPartida",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuarioMod",
                table: "CatTipoEntrada",
                newName: "UsuarioMod");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatTipoEntrada",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatTipoEntrada",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatTipoEntrada",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatTipoEntrada",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatTipoEntrada",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatTipoEntrada",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuarioMod",
                table: "CatTipoDeBien",
                newName: "UsuarioMod");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatTipoDeBien",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatTipoDeBien",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatTipoDeBien",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatTipoDeBien",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatTipoDeBien",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "usuarioMod",
                table: "CatTipoContrato",
                newName: "UsuarioMod");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatTipoContrato",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatTipoContrato",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatTipoContrato",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatTipoContrato",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatTipoContrato",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatTipoContrato",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuarioMod",
                table: "CatSexo",
                newName: "UsuarioMod");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatSexo",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatSexo",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatSexo",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatSexo",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatSexo",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatSexo",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatServicio",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatServicio",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatServicio",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatServicio",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatServicio",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatRol",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatRol",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatRol",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatRol",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatRol",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatRol",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuarioMod",
                table: "CatPiso",
                newName: "UsuarioMod");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatPiso",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatPiso",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatPiso",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatPiso",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatPiso",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatPiso",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuarioMod",
                table: "CatPermiso",
                newName: "UsuarioMod");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatPermiso",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatPermiso",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatPermiso",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatPermiso",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatPermiso",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatPermiso",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuarioMod",
                table: "CatGarantia",
                newName: "UsuarioMod");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatGarantia",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatGarantia",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatGarantia",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatGarantia",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatGarantia",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatGarantia",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "usuarioMod",
                table: "CatEstadoDelBien",
                newName: "UsuarioMod");

            migrationBuilder.RenameColumn(
                name: "idUsuarioAlta",
                table: "CatEstadoDelBien",
                newName: "IdUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "fechaMod",
                table: "CatEstadoDelBien",
                newName: "FechaMod");

            migrationBuilder.RenameColumn(
                name: "fechaAlta",
                table: "CatEstadoDelBien",
                newName: "FechaAlta");

            migrationBuilder.RenameColumn(
                name: "descripcion",
                table: "CatEstadoDelBien",
                newName: "Descripcion");

            migrationBuilder.RenameColumn(
                name: "activo",
                table: "CatEstadoDelBien",
                newName: "Activo");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatEstadoDelBien",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatUnidadDestino",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatUnidadDestino",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioMod",
                table: "CatUnidadDestino",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioMod",
                table: "CatTurno",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatTurno",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatTurno",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioMod",
                table: "CatTipoSalida",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatTipoSalida",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatTipoSalida",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioMod",
                table: "CatTipoPartida",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatTipoPartida",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatTipoPartida",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioMod",
                table: "CatTipoEntrada",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatTipoEntrada",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatTipoEntrada",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioMod",
                table: "CatTipoDeBien",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatTipoDeBien",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatTipoDeBien",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "CatTipoDeBien",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioMod",
                table: "CatTipoContrato",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatTipoContrato",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatTipoContrato",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioMod",
                table: "CatSexo",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatSexo",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatSexo",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatServicio",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatServicio",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuarioAlta",
                table: "CatServicio",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioMod",
                table: "CatServicio",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatRol",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatRol",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioMod",
                table: "CatRol",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioMod",
                table: "CatPiso",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatPiso",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatPiso",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioMod",
                table: "CatPermiso",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatPermiso",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatPermiso",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioMod",
                table: "CatGarantia",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatGarantia",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatGarantia",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UsuarioMod",
                table: "CatEstadoDelBien",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaMod",
                table: "CatEstadoDelBien",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "CatEstadoDelBien",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatArea",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "CatArea",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaAlta",
                table: "CatArea",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaMod",
                table: "CatArea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuarioAlta",
                table: "CatArea",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioMod",
                table: "CatArea",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "area",
                table: "CatArea",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatTipoDeBien",
                table: "CatTipoDeBien",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~",
                table: "TblBienesEquMedico",
                column: "catTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesCatTipoDeBien~",
                table: "TblBienesMuebles",
                column: "catTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesCatTipoDeBie~",
                table: "TblBienesSistemas",
                column: "catTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveCambs",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblClaveSaica_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveSaica",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblContratoBien",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblFacturas_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFacturas",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblFederalizacion_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFederalizacion",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesCatTipoD~",
                table: "TblInstrumentalMedico",
                column: "catTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInventarios_CatTipoDeBien_CatTipoDeBienId",
                table: "TblInventarios",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblProveedor_CatTipoDeBien_CatTipoDeBienId",
                table: "TblProveedor",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidasBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblSalidasBien",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesCatTipoDeBien~",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesCatTipoDeBie~",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveCambs");

            migrationBuilder.DropForeignKey(
                name: "FK_TblClaveSaica_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveSaica");

            migrationBuilder.DropForeignKey(
                name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblContratoBien");

            migrationBuilder.DropForeignKey(
                name: "FK_TblFacturas_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFacturas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblFederalizacion_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFederalizacion");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesCatTipoD~",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInventarios_CatTipoDeBien_CatTipoDeBienId",
                table: "TblInventarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblProveedor_CatTipoDeBien_CatTipoDeBienId",
                table: "TblProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidasBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblSalidasBien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatTipoDeBien",
                table: "CatTipoDeBien");

            migrationBuilder.DropColumn(
                name: "UsuarioMod",
                table: "CatUnidadDestino");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CatTipoDeBien");

            migrationBuilder.DropColumn(
                name: "IdUsuarioAlta",
                table: "CatServicio");

            migrationBuilder.DropColumn(
                name: "UsuarioMod",
                table: "CatServicio");

            migrationBuilder.DropColumn(
                name: "UsuarioMod",
                table: "CatRol");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "FechaAlta",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "FechaMod",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "IdUsuarioAlta",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "UsuarioMod",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "area",
                table: "CatArea");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatUnidadDestino",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatUnidadDestino",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatUnidadDestino",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatUnidadDestino",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatUnidadDestino",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatUnidadDestino",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuarioMod",
                table: "CatTurno",
                newName: "usuarioMod");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatTurno",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatTurno",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatTurno",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatTurno",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatTurno",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatTurno",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuarioMod",
                table: "CatTipoSalida",
                newName: "usuarioMod");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatTipoSalida",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatTipoSalida",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatTipoSalida",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatTipoSalida",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatTipoSalida",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatTipoSalida",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuarioMod",
                table: "CatTipoPartida",
                newName: "usuarioMod");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatTipoPartida",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatTipoPartida",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatTipoPartida",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatTipoPartida",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatTipoPartida",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatTipoPartida",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuarioMod",
                table: "CatTipoEntrada",
                newName: "usuarioMod");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatTipoEntrada",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatTipoEntrada",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatTipoEntrada",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatTipoEntrada",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatTipoEntrada",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatTipoEntrada",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuarioMod",
                table: "CatTipoDeBien",
                newName: "usuarioMod");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatTipoDeBien",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatTipoDeBien",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatTipoDeBien",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatTipoDeBien",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatTipoDeBien",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "UsuarioMod",
                table: "CatTipoContrato",
                newName: "usuarioMod");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatTipoContrato",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatTipoContrato",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatTipoContrato",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatTipoContrato",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatTipoContrato",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatTipoContrato",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuarioMod",
                table: "CatSexo",
                newName: "usuarioMod");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatSexo",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatSexo",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatSexo",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatSexo",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatSexo",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatSexo",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatServicio",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatServicio",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatServicio",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatServicio",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatServicio",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatRol",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatRol",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatRol",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatRol",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatRol",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatRol",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuarioMod",
                table: "CatPiso",
                newName: "usuarioMod");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatPiso",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatPiso",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatPiso",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatPiso",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatPiso",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatPiso",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuarioMod",
                table: "CatPermiso",
                newName: "usuarioMod");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatPermiso",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatPermiso",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatPermiso",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatPermiso",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatPermiso",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatPermiso",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuarioMod",
                table: "CatGarantia",
                newName: "usuarioMod");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatGarantia",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatGarantia",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatGarantia",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatGarantia",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatGarantia",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatGarantia",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "UsuarioMod",
                table: "CatEstadoDelBien",
                newName: "usuarioMod");

            migrationBuilder.RenameColumn(
                name: "IdUsuarioAlta",
                table: "CatEstadoDelBien",
                newName: "idUsuarioAlta");

            migrationBuilder.RenameColumn(
                name: "FechaMod",
                table: "CatEstadoDelBien",
                newName: "fechaMod");

            migrationBuilder.RenameColumn(
                name: "FechaAlta",
                table: "CatEstadoDelBien",
                newName: "fechaAlta");

            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "CatEstadoDelBien",
                newName: "descripcion");

            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "CatEstadoDelBien",
                newName: "activo");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CatEstadoDelBien",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "catEstatusid",
                table: "TblResguardatarios",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catEstatusid",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatUnidadDestino",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatUnidadDestino",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "idusuarioMod",
                table: "CatUnidadDestino",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "usuarioMod",
                table: "CatTurno",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatTurno",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatTurno",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "usuarioMod",
                table: "CatTipoSalida",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatTipoSalida",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatTipoSalida",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "usuarioMod",
                table: "CatTipoPartida",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatTipoPartida",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatTipoPartida",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "usuarioMod",
                table: "CatTipoEntrada",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatTipoEntrada",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatTipoEntrada",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "usuarioMod",
                table: "CatTipoDeBien",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatTipoDeBien",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatTipoDeBien",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienId",
                table: "CatTipoDeBien",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "usuarioMod",
                table: "CatTipoContrato",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatTipoContrato",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatTipoContrato",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "usuarioMod",
                table: "CatSexo",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatSexo",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatSexo",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatServicio",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatServicio",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "idusuarioMod",
                table: "CatServicio",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "usuarioAlta",
                table: "CatServicio",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatRol",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatRol",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "idusuarioMod",
                table: "CatRol",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "usuarioMod",
                table: "CatPiso",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatPiso",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatPiso",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "usuarioMod",
                table: "CatPermiso",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatPermiso",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatPermiso",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "usuarioMod",
                table: "CatGarantia",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatGarantia",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatGarantia",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "usuarioMod",
                table: "CatEstadoDelBien",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "fechaMod",
                table: "CatEstadoDelBien",
                type: "timestamp without time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatEstadoDelBien",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "descripcion",
                table: "CatArea",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "CatArea",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "InsertUserId",
                table: "CatArea",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CatArea",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsBySystem",
                table: "CatArea",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CatArea",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "CatArea",
                type: "timestamp without time zone",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "CatArea",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "CatArea",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatTipoDeBien",
                table: "CatTipoDeBien",
                column: "CatTipoDeBienId");

            migrationBuilder.CreateTable(
                name: "CatEstatus",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    estatus = table.Column<string>(type: "text", nullable: true),
                    fechaAlta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fechaMod = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    idUsuarioAlta = table.Column<int>(type: "integer", nullable: false),
                    usuarioMod = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatEstatus", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblResguardatarios_catEstatusid",
                table: "TblResguardatarios",
                column: "catEstatusid");

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_catEstatusid",
                table: "CtrlUsuarios",
                column: "catEstatusid");

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_CatEstatus_catEstatusid",
                table: "CtrlUsuarios",
                column: "catEstatusid",
                principalTable: "CatEstatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~",
                table: "TblBienesEquMedico",
                column: "catTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesCatTipoDeBien~",
                table: "TblBienesMuebles",
                column: "catTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesCatTipoDeBie~",
                table: "TblBienesSistemas",
                column: "catTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveCambs",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblClaveSaica_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveSaica",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblContratoBien",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblFacturas_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFacturas",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblFederalizacion_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFederalizacion",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesCatTipoD~",
                table: "TblInstrumentalMedico",
                column: "catTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInventarios_CatTipoDeBien_CatTipoDeBienId",
                table: "TblInventarios",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblProveedor_CatTipoDeBien_CatTipoDeBienId",
                table: "TblProveedor",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblResguardatarios_CatEstatus_catEstatusid",
                table: "TblResguardatarios",
                column: "catEstatusid",
                principalTable: "CatEstatus",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidasBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblSalidasBien",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
