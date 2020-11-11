using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_35 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblContratoBien_IdContratoBienid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblContratoBien_IdContratoBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblContratoBien_IdContratoBienid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblContratoBien");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblContratoBien_IdContratoBienid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdContratoBienid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblContratoBien",
                table: "TblContratoBien");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdContratoBienid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdContratoBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdContratoBienid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdContratoBienid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "id",
                table: "TblContratoBien");

            migrationBuilder.DropColumn(
                name: "IdContratoBienid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdContratoBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdContratoBienid",
                table: "TblBienesEquMedico");

            migrationBuilder.AddColumn<int>(
                name: "IdContratoBienTblContratoBienId",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblContratoBien",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblContratoBienId",
                table: "TblContratoBien",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdContratoBienTblContratoBienId",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdContratoBienTblContratoBienId",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblContratoBienId",
                table: "TblBienesEquMedico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblContratoBien",
                table: "TblContratoBien",
                column: "TblContratoBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdContratoBienTblContratoBienId",
                table: "TblInstrumentalMedico",
                column: "IdContratoBienTblContratoBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdContratoBienTblContratoBienId",
                table: "TblBienesSistemas",
                column: "IdContratoBienTblContratoBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdContratoBienTblContratoBienId",
                table: "TblBienesMuebles",
                column: "IdContratoBienTblContratoBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_TblContratoBienId",
                table: "TblBienesEquMedico",
                column: "TblContratoBienId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblContratoBien_TblContratoBienId",
                table: "TblBienesEquMedico",
                column: "TblContratoBienId",
                principalTable: "TblContratoBien",
                principalColumn: "TblContratoBienId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblContratoBien_IdContratoBienTblContratoB~",
                table: "TblBienesMuebles",
                column: "IdContratoBienTblContratoBienId",
                principalTable: "TblContratoBien",
                principalColumn: "TblContratoBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblContratoBien_IdContratoBienTblContrato~",
                table: "TblBienesSistemas",
                column: "IdContratoBienTblContratoBienId",
                principalTable: "TblContratoBien",
                principalColumn: "TblContratoBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblContratoBien",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblContratoBien_IdContratoBienTblCont~",
                table: "TblInstrumentalMedico",
                column: "IdContratoBienTblContratoBienId",
                principalTable: "TblContratoBien",
                principalColumn: "TblContratoBienId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblContratoBien_TblContratoBienId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblContratoBien_IdContratoBienTblContratoB~",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblContratoBien_IdContratoBienTblContrato~",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblContratoBien");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblContratoBien_IdContratoBienTblCont~",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdContratoBienTblContratoBienId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblContratoBien",
                table: "TblContratoBien");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdContratoBienTblContratoBienId",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdContratoBienTblContratoBienId",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_TblContratoBienId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdContratoBienTblContratoBienId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "TblContratoBienId",
                table: "TblContratoBien");

            migrationBuilder.DropColumn(
                name: "IdContratoBienTblContratoBienId",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdContratoBienTblContratoBienId",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "TblContratoBienId",
                table: "TblBienesEquMedico");

            migrationBuilder.AddColumn<int>(
                name: "IdContratoBienid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblContratoBien",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "TblContratoBien",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdContratoBienid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdContratoBienid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdContratoBienid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblContratoBien",
                table: "TblContratoBien",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdContratoBienid",
                table: "TblInstrumentalMedico",
                column: "IdContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdContratoBienid",
                table: "TblBienesSistemas",
                column: "IdContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdContratoBienid",
                table: "TblBienesMuebles",
                column: "IdContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdContratoBienid",
                table: "TblBienesEquMedico",
                column: "IdContratoBienid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblContratoBien_IdContratoBienid",
                table: "TblBienesEquMedico",
                column: "IdContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblContratoBien_IdContratoBienid",
                table: "TblBienesMuebles",
                column: "IdContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblContratoBien_IdContratoBienid",
                table: "TblBienesSistemas",
                column: "IdContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblContratoBien",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblContratoBien_IdContratoBienid",
                table: "TblInstrumentalMedico",
                column: "IdContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
