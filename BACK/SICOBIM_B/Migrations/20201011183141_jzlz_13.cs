using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "catPisosid",
                table: "TblBienes",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idpiso",
                table: "TblBienes",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_TblBienes_catPisosid",
                table: "TblBienes",
                column: "catPisosid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienes_CatPiso_catPisosid",
                table: "TblBienes",
                column: "catPisosid",
                principalTable: "CatPiso",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienes_CatPiso_catPisosid",
                table: "TblBienes");

            migrationBuilder.DropTable(
                name: "CatPiso");

            migrationBuilder.DropIndex(
                name: "IX_TblBienes_catPisosid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "catPisosid",
                table: "TblBienes");

            migrationBuilder.DropColumn(
                name: "idpiso",
                table: "TblBienes");
        }
    }
}
