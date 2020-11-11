using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_28 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_IdFacturasid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_IdFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_IdFacturasid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_IdFacturasid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblFacturas",
                table: "TblFacturas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdFacturasid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdFacturasid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdFacturasid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "id",
                table: "TblFacturas");

            migrationBuilder.DropColumn(
                name: "IdFacturasid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdFacturasid",
                table: "TblBienesEquMedico");

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasIdFactura",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFactura",
                table: "TblFacturas",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasIdFactura",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasIdFactura",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFactura",
                table: "TblBienesEquMedico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TblFacturasIdFactura",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblFacturas",
                table: "TblFacturas",
                column: "IdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasIdFactura",
                table: "TblInstrumentalMedico",
                column: "IdFacturasIdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdFacturasIdFactura",
                table: "TblBienesSistemas",
                column: "IdFacturasIdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdFacturasIdFactura",
                table: "TblBienesMuebles",
                column: "IdFacturasIdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_TblFacturasIdFactura",
                table: "TblBienesEquMedico",
                column: "TblFacturasIdFactura");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_TblFacturasIdFactura",
                table: "TblBienesEquMedico",
                column: "TblFacturasIdFactura",
                principalTable: "TblFacturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_IdFacturasIdFactura",
                table: "TblBienesMuebles",
                column: "IdFacturasIdFactura",
                principalTable: "TblFacturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_IdFacturasIdFactura",
                table: "TblBienesSistemas",
                column: "IdFacturasIdFactura",
                principalTable: "TblFacturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_IdFacturasIdFactura",
                table: "TblInstrumentalMedico",
                column: "IdFacturasIdFactura",
                principalTable: "TblFacturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_TblFacturasIdFactura",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_IdFacturasIdFactura",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_IdFacturasIdFactura",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_IdFacturasIdFactura",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasIdFactura",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblFacturas",
                table: "TblFacturas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdFacturasIdFactura",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdFacturasIdFactura",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_TblFacturasIdFactura",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdFacturasIdFactura",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdFactura",
                table: "TblFacturas");

            migrationBuilder.DropColumn(
                name: "IdFacturasIdFactura",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdFacturasIdFactura",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdFactura",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "TblFacturasIdFactura",
                table: "TblBienesEquMedico");

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "TblFacturas",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblFacturas",
                table: "TblFacturas",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasid",
                table: "TblInstrumentalMedico",
                column: "IdFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdFacturasid",
                table: "TblBienesSistemas",
                column: "IdFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdFacturasid",
                table: "TblBienesMuebles",
                column: "IdFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdFacturasid",
                table: "TblBienesEquMedico",
                column: "IdFacturasid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_IdFacturasid",
                table: "TblBienesEquMedico",
                column: "IdFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_IdFacturasid",
                table: "TblBienesMuebles",
                column: "IdFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_IdFacturasid",
                table: "TblBienesSistemas",
                column: "IdFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_IdFacturasid",
                table: "TblInstrumentalMedico",
                column: "IdFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
