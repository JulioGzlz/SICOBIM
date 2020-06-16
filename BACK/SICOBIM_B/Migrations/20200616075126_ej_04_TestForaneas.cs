using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class ej_04_TestForaneas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "cat_Horarioid",
                table: "usuarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idHorario",
                table: "usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "cat_horario",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    horario = table.Column<string>(nullable: true),
                    usuarioAlta = table.Column<int>(nullable: false),
                    fechaAlta = table.Column<DateTime>(nullable: false),
                    usuarioMod = table.Column<int>(nullable: false),
                    fechaMod = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cat_horario", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_cat_Horarioid",
                table: "usuarios",
                column: "cat_Horarioid");

            migrationBuilder.AddForeignKey(
                name: "FK_usuarios_cat_horario_cat_Horarioid",
                table: "usuarios",
                column: "cat_Horarioid",
                principalTable: "cat_horario",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usuarios_cat_horario_cat_Horarioid",
                table: "usuarios");

            migrationBuilder.DropTable(
                name: "cat_horario");

            migrationBuilder.DropIndex(
                name: "IX_usuarios_cat_Horarioid",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "cat_Horarioid",
                table: "usuarios");

            migrationBuilder.DropColumn(
                name: "idHorario",
                table: "usuarios");
        }
    }
}
