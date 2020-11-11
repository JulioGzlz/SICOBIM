using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_33 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IdFacturasTblFacturasId",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblFacturasId",
                table: "TblFacturas",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasTblFacturasId",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasTblFacturasId",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblFacturasId",
                table: "TblBienesEquMedico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblFacturas",
                table: "TblFacturas",
                column: "TblFacturasId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasTblFacturasId",
                table: "TblInstrumentalMedico",
                column: "IdFacturasTblFacturasId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdFacturasTblFacturasId",
                table: "TblBienesSistemas",
                column: "IdFacturasTblFacturasId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdFacturasTblFacturasId",
                table: "TblBienesMuebles",
                column: "IdFacturasTblFacturasId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_TblFacturasId",
                table: "TblBienesEquMedico",
                column: "TblFacturasId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_TblFacturasId",
                table: "TblBienesEquMedico",
                column: "TblFacturasId",
                principalTable: "TblFacturas",
                principalColumn: "TblFacturasId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_IdFacturasTblFacturasId",
                table: "TblBienesMuebles",
                column: "IdFacturasTblFacturasId",
                principalTable: "TblFacturas",
                principalColumn: "TblFacturasId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_IdFacturasTblFacturasId",
                table: "TblBienesSistemas",
                column: "IdFacturasTblFacturasId",
                principalTable: "TblFacturas",
                principalColumn: "TblFacturasId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_IdFacturasTblFacturasId",
                table: "TblInstrumentalMedico",
                column: "IdFacturasTblFacturasId",
                principalTable: "TblFacturas",
                principalColumn: "TblFacturasId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_TblFacturasId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_IdFacturasTblFacturasId",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_IdFacturasTblFacturasId",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_IdFacturasTblFacturasId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasTblFacturasId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblFacturas",
                table: "TblFacturas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdFacturasTblFacturasId",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdFacturasTblFacturasId",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_TblFacturasId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdFacturasTblFacturasId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "TblFacturasId",
                table: "TblFacturas");

            migrationBuilder.DropColumn(
                name: "IdFacturasTblFacturasId",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdFacturasTblFacturasId",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "TblFacturasId",
                table: "TblBienesEquMedico");

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasIdFactura",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFactura",
                table: "TblFacturas",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasIdFactura",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasIdFactura",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFactura",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TblFacturasIdFactura",
                table: "TblBienesEquMedico",
                type: "integer",
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
    }
}
