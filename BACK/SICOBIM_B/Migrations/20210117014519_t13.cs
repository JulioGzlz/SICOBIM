using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class t13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "activo",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "area",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "fechaAlta",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "fechaMod",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "idusuarioMod",
                table: "CatArea");

            migrationBuilder.DropColumn(
                name: "usuarioAlta",
                table: "CatArea");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "CatArea",
                newName: "Id");

            migrationBuilder.AddColumn<DateTime>(
                name: "InsertDate",
                table: "CatArea",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "InsertUserId",
                table: "CatArea",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CatArea",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsBySystem",
                table: "CatArea",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CatArea",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "CatArea",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UpdateUserId",
                table: "CatArea",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "CatArea",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "Id",
                table: "CatArea",
                newName: "id");

            migrationBuilder.AddColumn<bool>(
                name: "activo",
                table: "CatArea",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "area",
                table: "CatArea",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaAlta",
                table: "CatArea",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaMod",
                table: "CatArea",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "idusuarioMod",
                table: "CatArea",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "usuarioAlta",
                table: "CatArea",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
