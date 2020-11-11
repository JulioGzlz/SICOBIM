using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_34 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblClaveSaica_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveSaica");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_TblBienesEquMedico_TblBienesEquMedicoid",
                table: "TblSalidaBien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblBienesEquMedico",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "id",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesEquMedico");

            migrationBuilder.RenameColumn(
                name: "TblBienesEquMedicoid",
                table: "TblSalidaBien",
                newName: "TblBienesEquMedicoId");

            migrationBuilder.RenameIndex(
                name: "IX_TblSalidaBien_TblBienesEquMedicoid",
                table: "TblSalidaBien",
                newName: "IX_TblSalidaBien_TblBienesEquMedicoId");

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblClaveSaica",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblBienesEquMedicoId",
                table: "TblBienesEquMedico",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblBienesEquMedico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblBienesEquMedico",
                table: "TblBienesEquMedico",
                column: "TblBienesEquMedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_CatTipoDeBienId",
                table: "TblBienesEquMedico",
                column: "CatTipoDeBienId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_CatTipoDeBienId",
                table: "TblBienesEquMedico",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblClaveSaica_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveSaica",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_TblBienesEquMedico_TblBienesEquMedicoId",
                table: "TblSalidaBien",
                column: "TblBienesEquMedicoId",
                principalTable: "TblBienesEquMedico",
                principalColumn: "TblBienesEquMedicoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_CatTipoDeBienId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblClaveSaica_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveSaica");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_TblBienesEquMedico_TblBienesEquMedicoId",
                table: "TblSalidaBien");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblBienesEquMedico",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_CatTipoDeBienId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "TblBienesEquMedicoId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienId",
                table: "TblBienesEquMedico");

            migrationBuilder.RenameColumn(
                name: "TblBienesEquMedicoId",
                table: "TblSalidaBien",
                newName: "TblBienesEquMedicoid");

            migrationBuilder.RenameIndex(
                name: "IX_TblSalidaBien_TblBienesEquMedicoId",
                table: "TblSalidaBien",
                newName: "IX_TblSalidaBien_TblBienesEquMedicoid");

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblClaveSaica",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblBienesEquMedico",
                table: "TblBienesEquMedico",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesEquMedico",
                column: "catTipoDeBienesCatTipoDeBienId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~",
                table: "TblBienesEquMedico",
                column: "catTipoDeBienesCatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblClaveSaica_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveSaica",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_TblBienesEquMedico_TblBienesEquMedicoid",
                table: "TblSalidaBien",
                column: "TblBienesEquMedicoid",
                principalTable: "TblBienesEquMedico",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
