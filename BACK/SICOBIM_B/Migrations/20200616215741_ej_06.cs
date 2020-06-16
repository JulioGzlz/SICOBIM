using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class ej_06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuarios_cat_horario_cat_Horarioid",
                table: "usuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios");

            migrationBuilder.RenameTable(
                name: "usuarios",
                newName: "CtrlUsuarios");

            migrationBuilder.RenameIndex(
                name: "IX_usuarios_cat_Horarioid",
                table: "CtrlUsuarios",
                newName: "IX_CtrlUsuarios_cat_Horarioid");

            migrationBuilder.AddColumn<bool>(
                name: "activo",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "correo",
                table: "CtrlUsuarios",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaAlta",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaMod",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "idUsuarioAlta",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "usuarioMod",
                table: "CtrlUsuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CtrlUsuarios",
                table: "CtrlUsuarios",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_cat_horario_cat_Horarioid",
                table: "CtrlUsuarios",
                column: "cat_Horarioid",
                principalTable: "cat_horario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_cat_horario_cat_Horarioid",
                table: "CtrlUsuarios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CtrlUsuarios",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "activo",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "correo",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "fechaAlta",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "fechaMod",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "idUsuarioAlta",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "usuarioMod",
                table: "CtrlUsuarios");

            migrationBuilder.RenameTable(
                name: "CtrlUsuarios",
                newName: "usuarios");

            migrationBuilder.RenameIndex(
                name: "IX_CtrlUsuarios_cat_Horarioid",
                table: "usuarios",
                newName: "IX_usuarios_cat_Horarioid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usuarios",
                table: "usuarios",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_cat_horario_cat_Horarioid",
                table: "usuarios",
                column: "cat_Horarioid",
                principalTable: "cat_horario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
