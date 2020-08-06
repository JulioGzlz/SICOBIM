using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class Jzlz_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idRol",
                table: "TblConfPerfil",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CatRol",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    rol = table.Column<string>(nullable: true),
                    descripcion = table.Column<string>(nullable: true),
                    idUsuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    idusuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false),
                    activo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatRol", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TblConfPerfil_idRol",
                table: "TblConfPerfil",
                column: "idRol");

            migrationBuilder.AddForeignKey(
                name: "FK_TblConfPerfil_CatRol_idRol",
                table: "TblConfPerfil",
                column: "idRol",
                principalTable: "CatRol",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblConfPerfil_CatRol_idRol",
                table: "TblConfPerfil");

            migrationBuilder.DropTable(
                name: "CatRol");

            migrationBuilder.DropIndex(
                name: "IX_TblConfPerfil_idRol",
                table: "TblConfPerfil");

            migrationBuilder.DropColumn(
                name: "idRol",
                table: "TblConfPerfil");
        }
    }
}
