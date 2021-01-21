using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class tb6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_IdFacturasIdFactura",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesCatTipoDeBien~",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_IdFacturasIdFactura",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesCatTipoDeBie~",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_IdFacturasIdFactura",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesCatTipoD~",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_IdFacturasIdFactura",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_catTipoDeBienesCatTipoDeBienId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasIdFactura",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdFacturasIdFactura",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdFacturasIdFactura",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdFacturasIdFactura",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdFacturasIdFactura",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdFacturasIdFactura",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdFacturasIdFactura",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdFacturasIdFactura",
                table: "TblBienesEquMedico");

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catTipoDeBienid",
                table: "TblInstrumentalMedico",
                column: "catTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasid",
                table: "TblInstrumentalMedico",
                column: "IdFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catTipoDeBienid",
                table: "TblBienesSistemas",
                column: "catTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdFacturasid",
                table: "TblBienesSistemas",
                column: "IdFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_catTipoDeBienid",
                table: "TblBienesMuebles",
                column: "catTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdFacturasid",
                table: "TblBienesMuebles",
                column: "IdFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catTipoDeBienid",
                table: "TblBienesEquMedico",
                column: "catTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdFacturasid",
                table: "TblBienesEquMedico",
                column: "IdFacturasid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~",
                table: "TblBienesEquMedico",
                column: "catTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_IdFacturasid",
                table: "TblBienesEquMedico",
                column: "IdFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesCatTipoDeBien~",
                table: "TblBienesMuebles",
                column: "catTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_IdFacturasid",
                table: "TblBienesMuebles",
                column: "IdFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesCatTipoDeBie~",
                table: "TblBienesSistemas",
                column: "catTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_IdFacturasid",
                table: "TblBienesSistemas",
                column: "IdFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesCatTipoD~",
                table: "TblInstrumentalMedico",
                column: "catTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_IdFacturasid",
                table: "TblInstrumentalMedico",
                column: "IdFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_IdFacturasid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesCatTipoDeBien~",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_IdFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesCatTipoDeBie~",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_IdFacturasid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesCatTipoD~",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_IdFacturasid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_catTipoDeBienid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_catTipoDeBienid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdFacturasid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_catTipoDeBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_catTipoDeBienid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdFacturasid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdFacturasid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdFacturasid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdFacturasid",
                table: "TblBienesEquMedico");

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasIdFactura",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasIdFactura",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasIdFactura",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasIdFactura",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catTipoDeBienesCatTipoDeBienId",
                table: "TblInstrumentalMedico",
                column: "catTipoDeBienesCatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasIdFactura",
                table: "TblInstrumentalMedico",
                column: "IdFacturasIdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesSistemas",
                column: "catTipoDeBienesCatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdFacturasIdFactura",
                table: "TblBienesSistemas",
                column: "IdFacturasIdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesMuebles",
                column: "catTipoDeBienesCatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdFacturasIdFactura",
                table: "TblBienesMuebles",
                column: "IdFacturasIdFactura");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesEquMedico",
                column: "catTipoDeBienesCatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdFacturasIdFactura",
                table: "TblBienesEquMedico",
                column: "IdFacturasIdFactura");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~",
                table: "TblBienesEquMedico",
                column: "catTipoDeBienesCatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_IdFacturasIdFactura",
                table: "TblBienesEquMedico",
                column: "IdFacturasIdFactura",
                principalTable: "TblFacturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesCatTipoDeBien~",
                table: "TblBienesMuebles",
                column: "catTipoDeBienesCatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_IdFacturasIdFactura",
                table: "TblBienesMuebles",
                column: "IdFacturasIdFactura",
                principalTable: "TblFacturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesCatTipoDeBie~",
                table: "TblBienesSistemas",
                column: "catTipoDeBienesCatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_IdFacturasIdFactura",
                table: "TblBienesSistemas",
                column: "IdFacturasIdFactura",
                principalTable: "TblFacturas",
                principalColumn: "IdFactura",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesCatTipoD~",
                table: "TblInstrumentalMedico",
                column: "catTipoDeBienesCatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
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
