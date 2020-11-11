using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_31 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienid",
                table: "TblClaveCambs");

            migrationBuilder.DropForeignKey(
                name: "FK_TblClaveSaica_CatTipoDeBien_CatTipoDeBienid",
                table: "TblClaveSaica");

            migrationBuilder.DropForeignKey(
                name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienid",
                table: "TblContratoBien");

            migrationBuilder.DropForeignKey(
                name: "FK_TblFacturas_CatTipoDeBien_CatTipoDeBienid",
                table: "TblFacturas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblFederalizacion_CatTipoDeBien_CatTipoDeBienid",
                table: "TblFederalizacion");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInventarios_CatTipoDeBien_CatTipoDeBienid",
                table: "TblInventarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblProveedor_CatTipoDeBien_CatTipoDeBienid",
                table: "TblProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_CatTipoDeBien_CatTipoDeBienid",
                table: "TblSalidaBien");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_catTipoDeBienesid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_catTipoDeBienesid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_catTipoDeBienesid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_catTipoDeBienesid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatTipoDeBien",
                table: "CatTipoDeBien");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "id",
                table: "CatTipoDeBien");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienid",
                table: "TblSalidaBien",
                newName: "CatTipoDeBienId");

            migrationBuilder.RenameIndex(
                name: "IX_TblSalidaBien_CatTipoDeBienid",
                table: "TblSalidaBien",
                newName: "IX_TblSalidaBien_CatTipoDeBienId");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienid",
                table: "TblProveedor",
                newName: "CatTipoDeBienId");

            migrationBuilder.RenameIndex(
                name: "IX_TblProveedor_CatTipoDeBienid",
                table: "TblProveedor",
                newName: "IX_TblProveedor_CatTipoDeBienId");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienid",
                table: "TblInventarios",
                newName: "CatTipoDeBienId");

            migrationBuilder.RenameIndex(
                name: "IX_TblInventarios_CatTipoDeBienid",
                table: "TblInventarios",
                newName: "IX_TblInventarios_CatTipoDeBienId");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienid",
                table: "TblFederalizacion",
                newName: "CatTipoDeBienId");

            migrationBuilder.RenameIndex(
                name: "IX_TblFederalizacion_CatTipoDeBienid",
                table: "TblFederalizacion",
                newName: "IX_TblFederalizacion_CatTipoDeBienId");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienid",
                table: "TblFacturas",
                newName: "CatTipoDeBienId");

            migrationBuilder.RenameIndex(
                name: "IX_TblFacturas_CatTipoDeBienid",
                table: "TblFacturas",
                newName: "IX_TblFacturas_CatTipoDeBienId");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienid",
                table: "TblContratoBien",
                newName: "CatTipoDeBienId");

            migrationBuilder.RenameIndex(
                name: "IX_TblContratoBien_CatTipoDeBienid",
                table: "TblContratoBien",
                newName: "IX_TblContratoBien_CatTipoDeBienId");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienid",
                table: "TblClaveSaica",
                newName: "CatTipoDeBienId");

            migrationBuilder.RenameIndex(
                name: "IX_TblClaveSaica_CatTipoDeBienid",
                table: "TblClaveSaica",
                newName: "IX_TblClaveSaica_CatTipoDeBienId");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienid",
                table: "TblClaveCambs",
                newName: "CatTipoDeBienId");

            migrationBuilder.RenameIndex(
                name: "IX_TblClaveCambs_CatTipoDeBienid",
                table: "TblClaveCambs",
                newName: "IX_TblClaveCambs_CatTipoDeBienId");

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblFacturas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdCatTipoBien",
                table: "TblFacturas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienId",
                table: "CatTipoDeBien",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatTipoDeBien",
                table: "CatTipoDeBien",
                column: "CatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catTipoDeBienesCatTipoDeBienId",
                table: "TblInstrumentalMedico",
                column: "catTipoDeBienesCatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesSistemas",
                column: "catTipoDeBienesCatTipoDeBienId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesMuebles",
                column: "catTipoDeBienesCatTipoDeBienId");

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
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesCatTipoDeBien~",
                table: "TblBienesMuebles",
                column: "catTipoDeBienesCatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesCatTipoDeBie~",
                table: "TblBienesSistemas",
                column: "catTipoDeBienesCatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveCambs",
                column: "CatTipoDeBienId",
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
                name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblContratoBien",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblFacturas_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFacturas",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblFederalizacion_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFederalizacion",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesCatTipoD~",
                table: "TblInstrumentalMedico",
                column: "catTipoDeBienesCatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInventarios_CatTipoDeBien_CatTipoDeBienId",
                table: "TblInventarios",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblProveedor_CatTipoDeBien_CatTipoDeBienId",
                table: "TblProveedor",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblSalidaBien",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesCatTipoDeBi~",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesCatTipoDeBien~",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesCatTipoDeBie~",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveCambs");

            migrationBuilder.DropForeignKey(
                name: "FK_TblClaveSaica_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveSaica");

            migrationBuilder.DropForeignKey(
                name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblContratoBien");

            migrationBuilder.DropForeignKey(
                name: "FK_TblFacturas_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFacturas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblFederalizacion_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFederalizacion");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesCatTipoD~",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInventarios_CatTipoDeBien_CatTipoDeBienId",
                table: "TblInventarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblProveedor_CatTipoDeBien_CatTipoDeBienId",
                table: "TblProveedor");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_CatTipoDeBien_CatTipoDeBienId",
                table: "TblSalidaBien");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_catTipoDeBienesCatTipoDeBienId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CatTipoDeBien",
                table: "CatTipoDeBien");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdCatTipoBien",
                table: "TblFacturas");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "catTipoDeBienesCatTipoDeBienId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienId",
                table: "CatTipoDeBien");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienId",
                table: "TblSalidaBien",
                newName: "CatTipoDeBienid");

            migrationBuilder.RenameIndex(
                name: "IX_TblSalidaBien_CatTipoDeBienId",
                table: "TblSalidaBien",
                newName: "IX_TblSalidaBien_CatTipoDeBienid");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienId",
                table: "TblProveedor",
                newName: "CatTipoDeBienid");

            migrationBuilder.RenameIndex(
                name: "IX_TblProveedor_CatTipoDeBienId",
                table: "TblProveedor",
                newName: "IX_TblProveedor_CatTipoDeBienid");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienId",
                table: "TblInventarios",
                newName: "CatTipoDeBienid");

            migrationBuilder.RenameIndex(
                name: "IX_TblInventarios_CatTipoDeBienId",
                table: "TblInventarios",
                newName: "IX_TblInventarios_CatTipoDeBienid");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienId",
                table: "TblFederalizacion",
                newName: "CatTipoDeBienid");

            migrationBuilder.RenameIndex(
                name: "IX_TblFederalizacion_CatTipoDeBienId",
                table: "TblFederalizacion",
                newName: "IX_TblFederalizacion_CatTipoDeBienid");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienId",
                table: "TblFacturas",
                newName: "CatTipoDeBienid");

            migrationBuilder.RenameIndex(
                name: "IX_TblFacturas_CatTipoDeBienId",
                table: "TblFacturas",
                newName: "IX_TblFacturas_CatTipoDeBienid");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienId",
                table: "TblContratoBien",
                newName: "CatTipoDeBienid");

            migrationBuilder.RenameIndex(
                name: "IX_TblContratoBien_CatTipoDeBienId",
                table: "TblContratoBien",
                newName: "IX_TblContratoBien_CatTipoDeBienid");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienId",
                table: "TblClaveSaica",
                newName: "CatTipoDeBienid");

            migrationBuilder.RenameIndex(
                name: "IX_TblClaveSaica_CatTipoDeBienId",
                table: "TblClaveSaica",
                newName: "IX_TblClaveSaica_CatTipoDeBienid");

            migrationBuilder.RenameColumn(
                name: "CatTipoDeBienId",
                table: "TblClaveCambs",
                newName: "CatTipoDeBienid");

            migrationBuilder.RenameIndex(
                name: "IX_TblClaveCambs_CatTipoDeBienId",
                table: "TblClaveCambs",
                newName: "IX_TblClaveCambs_CatTipoDeBienid");

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienid",
                table: "TblFacturas",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "catTipoDeBienesid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "CatTipoDeBien",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CatTipoDeBien",
                table: "CatTipoDeBien",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_catTipoDeBienesid",
                table: "TblInstrumentalMedico",
                column: "catTipoDeBienesid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_catTipoDeBienesid",
                table: "TblBienesSistemas",
                column: "catTipoDeBienesid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_catTipoDeBienesid",
                table: "TblBienesMuebles",
                column: "catTipoDeBienesid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_catTipoDeBienesid",
                table: "TblBienesEquMedico",
                column: "catTipoDeBienesid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_CatTipoDeBien_catTipoDeBienesid",
                table: "TblBienesEquMedico",
                column: "catTipoDeBienesid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_CatTipoDeBien_catTipoDeBienesid",
                table: "TblBienesMuebles",
                column: "catTipoDeBienesid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_CatTipoDeBien_catTipoDeBienesid",
                table: "TblBienesSistemas",
                column: "catTipoDeBienesid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienid",
                table: "TblClaveCambs",
                column: "CatTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblClaveSaica_CatTipoDeBien_CatTipoDeBienid",
                table: "TblClaveSaica",
                column: "CatTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblContratoBien_CatTipoDeBien_CatTipoDeBienid",
                table: "TblContratoBien",
                column: "CatTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblFacturas_CatTipoDeBien_CatTipoDeBienid",
                table: "TblFacturas",
                column: "CatTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblFederalizacion_CatTipoDeBien_CatTipoDeBienid",
                table: "TblFederalizacion",
                column: "CatTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_CatTipoDeBien_catTipoDeBienesid",
                table: "TblInstrumentalMedico",
                column: "catTipoDeBienesid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInventarios_CatTipoDeBien_CatTipoDeBienid",
                table: "TblInventarios",
                column: "CatTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblProveedor_CatTipoDeBien_CatTipoDeBienid",
                table: "TblProveedor",
                column: "CatTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_CatTipoDeBien_CatTipoDeBienid",
                table: "TblSalidaBien",
                column: "CatTipoDeBienid",
                principalTable: "CatTipoDeBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
