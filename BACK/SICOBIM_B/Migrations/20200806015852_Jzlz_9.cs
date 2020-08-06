using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class Jzlz_9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CtrlUsuarios_catRol_CatRolid",
                table: "CtrlUsuarios");

            migrationBuilder.DropTable(
                name: "TblConfPerfil");

            migrationBuilder.DropTable(
                name: "CatPermiso");

            migrationBuilder.DropTable(
                name: "catRol");

            migrationBuilder.DropIndex(
                name: "IX_CtrlUsuarios_CatRolid",
                table: "CtrlUsuarios");

            migrationBuilder.DropColumn(
                name: "CatRolid",
                table: "CtrlUsuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CatRolid",
                table: "CtrlUsuarios",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatPermiso",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    fechaAlta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fechaMod = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    idUsuarioAlta = table.Column<int>(type: "integer", nullable: false),
                    permiso = table.Column<string>(type: "text", nullable: true),
                    usuarioMod = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatPermiso", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "catRol",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: true),
                    fechaAlta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fechaMod = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    idUsuarioAlta = table.Column<int>(type: "integer", nullable: false),
                    idusuarioMod = table.Column<int>(type: "integer", nullable: false),
                    rol = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catRol", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TblConfPerfil",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    activo = table.Column<bool>(type: "boolean", nullable: false),
                    catPermisoid = table.Column<int>(type: "integer", nullable: true),
                    catRolid = table.Column<int>(type: "integer", nullable: true),
                    fechaAlta = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    fechaMod = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    idpermiso = table.Column<int>(type: "integer", nullable: false),
                    idrol = table.Column<int>(type: "integer", nullable: false),
                    usuarioMod = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_CtrlUsuarios_CatRolid",
                table: "CtrlUsuarios",
                column: "CatRolid");

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_catPermisoid",
                table: "TblConfPerfil",
                column: "catPermisoid");

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_catRolid",
                table: "TblConfPerfil",
                column: "catRolid");

            migrationBuilder.AddForeignKey(
                name: "FK_CtrlUsuarios_catRol_CatRolid",
                table: "CtrlUsuarios",
                column: "CatRolid",
                principalTable: "catRol",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
