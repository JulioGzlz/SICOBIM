using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_36 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveCambs_IdClaveCabmsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveSaica_IdClaveSaicaid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblFederalizacion_IdFederalizacionid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblInventarios_IdInventarioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblProveedor_IdProveedorid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblProveedor_IProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_IdClaveCabmsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblClaveSaica_IdClaveSaicaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFederalizacion_IdFederalizacionid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_IdInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblClaveCambs_IdClaveCabmsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblClaveSaica_IdClaveSaicaid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblFederalizacion_IdFederalizacionid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblInventarios_IdInventariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblProveedor_IdProveedorid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveCambs");

            migrationBuilder.DropForeignKey(
                name: "FK_TblFederalizacion_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFederalizacion");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveCambs_IdClaveCambsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveSaica_IdClaveSaicaid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblFederalizacion_IdFederalizacionid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblInventarios_IdInventariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblProveedor_IdProveedorid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInventarios_CatTipoDeBien_CatTipoDeBienId",
                table: "TblInventarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblProveedor_CatTipoDeBien_CatTipoDeBienId",
                table: "TblProveedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblProveedor",
                table: "TblProveedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblInventarios",
                table: "TblInventarios");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdClaveCambsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdClaveSaicaid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdFederalizacionid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdInventariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdProveedorid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblFederalizacion",
                table: "TblFederalizacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblClaveSaica",
                table: "TblClaveSaica");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblClaveCambs",
                table: "TblClaveCambs");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdClaveCabmsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdClaveSaicaid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdFederalizacionid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdInventariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdProveedorid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdClaveCabmsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdClaveSaicaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdFederalizacionid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdClaveCabmsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdClaveSaicaid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdFederalizacionid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdInventarioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdProveedorid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "id",
                table: "TblProveedor");

            migrationBuilder.DropColumn(
                name: "id",
                table: "TblInventarios");

            migrationBuilder.DropColumn(
                name: "IdClaveCambsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdClaveSaicaid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdFederalizacionid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdInventariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdProveedorid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "id",
                table: "TblFederalizacion");

            migrationBuilder.DropColumn(
                name: "id",
                table: "TblClaveSaica");

            migrationBuilder.DropColumn(
                name: "id",
                table: "TblClaveCambs");

            migrationBuilder.DropColumn(
                name: "IdClaveCabmsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdClaveSaicaid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdFederalizacionid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdInventariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdProveedorid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdClaveCabmsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdClaveSaicaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdFederalizacionid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdClaveCabmsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdClaveSaicaid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdFederalizacionid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdInventarioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdProveedorid",
                table: "TblBienesEquMedico");

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblProveedor",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblProveedorId",
                table: "TblProveedor",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblInventarios",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblInventariosId",
                table: "TblInventarios",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCambsTblClaveCabmsId",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveSaicaTblClaveSaicaId",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFederalizacionTblFederalizacionId",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventariosTblInventariosId",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProveedorTblProveedorId",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblFederalizacion",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblFederalizacionId",
                table: "TblFederalizacion",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "TblClaveSaicaId",
                table: "TblClaveSaica",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblClaveCambs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblClaveCabmsId",
                table: "TblClaveCambs",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCabmsTblClaveCabmsId",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveSaicaTblClaveSaicaId",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFederalizacionTblFederalizacionId",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventariosTblInventariosId",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProveedorTblProveedorId",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IProveedorTblProveedorId",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCabmsTblClaveCabmsId",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveSaicaTblClaveSaicaId",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFederalizacionTblFederalizacionId",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventariosTblInventariosId",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblClaveCabmsId",
                table: "TblBienesEquMedico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TblClaveSaicaId",
                table: "TblBienesEquMedico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TblFederalizacionId",
                table: "TblBienesEquMedico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TblInventariosId",
                table: "TblBienesEquMedico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TblProveedorId",
                table: "TblBienesEquMedico",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblProveedor",
                table: "TblProveedor",
                column: "TblProveedorId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblInventarios",
                table: "TblInventarios",
                column: "TblInventariosId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblFederalizacion",
                table: "TblFederalizacion",
                column: "TblFederalizacionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblClaveSaica",
                table: "TblClaveSaica",
                column: "TblClaveSaicaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblClaveCambs",
                table: "TblClaveCambs",
                column: "TblClaveCabmsId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdClaveCambsTblClaveCabmsId",
                table: "TblInstrumentalMedico",
                column: "IdClaveCambsTblClaveCabmsId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdClaveSaicaTblClaveSaicaId",
                table: "TblInstrumentalMedico",
                column: "IdClaveSaicaTblClaveSaicaId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdFederalizacionTblFederalizacionId",
                table: "TblInstrumentalMedico",
                column: "IdFederalizacionTblFederalizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdInventariosTblInventariosId",
                table: "TblInstrumentalMedico",
                column: "IdInventariosTblInventariosId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdProveedorTblProveedorId",
                table: "TblInstrumentalMedico",
                column: "IdProveedorTblProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdClaveCabmsTblClaveCabmsId",
                table: "TblBienesSistemas",
                column: "IdClaveCabmsTblClaveCabmsId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdClaveSaicaTblClaveSaicaId",
                table: "TblBienesSistemas",
                column: "IdClaveSaicaTblClaveSaicaId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdFederalizacionTblFederalizacionId",
                table: "TblBienesSistemas",
                column: "IdFederalizacionTblFederalizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdInventariosTblInventariosId",
                table: "TblBienesSistemas",
                column: "IdInventariosTblInventariosId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdProveedorTblProveedorId",
                table: "TblBienesSistemas",
                column: "IdProveedorTblProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IProveedorTblProveedorId",
                table: "TblBienesMuebles",
                column: "IProveedorTblProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdClaveCabmsTblClaveCabmsId",
                table: "TblBienesMuebles",
                column: "IdClaveCabmsTblClaveCabmsId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdClaveSaicaTblClaveSaicaId",
                table: "TblBienesMuebles",
                column: "IdClaveSaicaTblClaveSaicaId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdFederalizacionTblFederalizacionId",
                table: "TblBienesMuebles",
                column: "IdFederalizacionTblFederalizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdInventariosTblInventariosId",
                table: "TblBienesMuebles",
                column: "IdInventariosTblInventariosId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_TblClaveCabmsId",
                table: "TblBienesEquMedico",
                column: "TblClaveCabmsId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_TblClaveSaicaId",
                table: "TblBienesEquMedico",
                column: "TblClaveSaicaId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_TblFederalizacionId",
                table: "TblBienesEquMedico",
                column: "TblFederalizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_TblInventariosId",
                table: "TblBienesEquMedico",
                column: "TblInventariosId");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_TblProveedorId",
                table: "TblBienesEquMedico",
                column: "TblProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveCambs_TblClaveCabmsId",
                table: "TblBienesEquMedico",
                column: "TblClaveCabmsId",
                principalTable: "TblClaveCambs",
                principalColumn: "TblClaveCabmsId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveSaica_TblClaveSaicaId",
                table: "TblBienesEquMedico",
                column: "TblClaveSaicaId",
                principalTable: "TblClaveSaica",
                principalColumn: "TblClaveSaicaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblFederalizacion_TblFederalizacionId",
                table: "TblBienesEquMedico",
                column: "TblFederalizacionId",
                principalTable: "TblFederalizacion",
                principalColumn: "TblFederalizacionId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblInventarios_TblInventariosId",
                table: "TblBienesEquMedico",
                column: "TblInventariosId",
                principalTable: "TblInventarios",
                principalColumn: "TblInventariosId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblProveedor_TblProveedorId",
                table: "TblBienesEquMedico",
                column: "TblProveedorId",
                principalTable: "TblProveedor",
                principalColumn: "TblProveedorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblProveedor_IProveedorTblProveedorId",
                table: "TblBienesMuebles",
                column: "IProveedorTblProveedorId",
                principalTable: "TblProveedor",
                principalColumn: "TblProveedorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_IdClaveCabmsTblClaveCabmsId",
                table: "TblBienesMuebles",
                column: "IdClaveCabmsTblClaveCabmsId",
                principalTable: "TblClaveCambs",
                principalColumn: "TblClaveCabmsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblClaveSaica_IdClaveSaicaTblClaveSaicaId",
                table: "TblBienesMuebles",
                column: "IdClaveSaicaTblClaveSaicaId",
                principalTable: "TblClaveSaica",
                principalColumn: "TblClaveSaicaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblFederalizacion_IdFederalizacionTblFeder~",
                table: "TblBienesMuebles",
                column: "IdFederalizacionTblFederalizacionId",
                principalTable: "TblFederalizacion",
                principalColumn: "TblFederalizacionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_IdInventariosTblInventarios~",
                table: "TblBienesMuebles",
                column: "IdInventariosTblInventariosId",
                principalTable: "TblInventarios",
                principalColumn: "TblInventariosId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblClaveCambs_IdClaveCabmsTblClaveCabmsId",
                table: "TblBienesSistemas",
                column: "IdClaveCabmsTblClaveCabmsId",
                principalTable: "TblClaveCambs",
                principalColumn: "TblClaveCabmsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblClaveSaica_IdClaveSaicaTblClaveSaicaId",
                table: "TblBienesSistemas",
                column: "IdClaveSaicaTblClaveSaicaId",
                principalTable: "TblClaveSaica",
                principalColumn: "TblClaveSaicaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblFederalizacion_IdFederalizacionTblFede~",
                table: "TblBienesSistemas",
                column: "IdFederalizacionTblFederalizacionId",
                principalTable: "TblFederalizacion",
                principalColumn: "TblFederalizacionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblInventarios_IdInventariosTblInventario~",
                table: "TblBienesSistemas",
                column: "IdInventariosTblInventariosId",
                principalTable: "TblInventarios",
                principalColumn: "TblInventariosId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblProveedor_IdProveedorTblProveedorId",
                table: "TblBienesSistemas",
                column: "IdProveedorTblProveedorId",
                principalTable: "TblProveedor",
                principalColumn: "TblProveedorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveCambs",
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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveCambs_IdClaveCambsTblClaveCab~",
                table: "TblInstrumentalMedico",
                column: "IdClaveCambsTblClaveCabmsId",
                principalTable: "TblClaveCambs",
                principalColumn: "TblClaveCabmsId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveSaica_IdClaveSaicaTblClaveSai~",
                table: "TblInstrumentalMedico",
                column: "IdClaveSaicaTblClaveSaicaId",
                principalTable: "TblClaveSaica",
                principalColumn: "TblClaveSaicaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblFederalizacion_IdFederalizacionTbl~",
                table: "TblInstrumentalMedico",
                column: "IdFederalizacionTblFederalizacionId",
                principalTable: "TblFederalizacion",
                principalColumn: "TblFederalizacionId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblInventarios_IdInventariosTblInvent~",
                table: "TblInstrumentalMedico",
                column: "IdInventariosTblInventariosId",
                principalTable: "TblInventarios",
                principalColumn: "TblInventariosId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblProveedor_IdProveedorTblProveedorId",
                table: "TblInstrumentalMedico",
                column: "IdProveedorTblProveedorId",
                principalTable: "TblProveedor",
                principalColumn: "TblProveedorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInventarios_CatTipoDeBien_CatTipoDeBienId",
                table: "TblInventarios",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TblProveedor_CatTipoDeBien_CatTipoDeBienId",
                table: "TblProveedor",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveCambs_TblClaveCabmsId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveSaica_TblClaveSaicaId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblFederalizacion_TblFederalizacionId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblInventarios_TblInventariosId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblProveedor_TblProveedorId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblProveedor_IProveedorTblProveedorId",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_IdClaveCabmsTblClaveCabmsId",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblClaveSaica_IdClaveSaicaTblClaveSaicaId",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFederalizacion_IdFederalizacionTblFeder~",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_IdInventariosTblInventarios~",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblClaveCambs_IdClaveCabmsTblClaveCabmsId",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblClaveSaica_IdClaveSaicaTblClaveSaicaId",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblFederalizacion_IdFederalizacionTblFede~",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblInventarios_IdInventariosTblInventario~",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblProveedor_IdProveedorTblProveedorId",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveCambs");

            migrationBuilder.DropForeignKey(
                name: "FK_TblFederalizacion_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFederalizacion");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveCambs_IdClaveCambsTblClaveCab~",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveSaica_IdClaveSaicaTblClaveSai~",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblFederalizacion_IdFederalizacionTbl~",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblInventarios_IdInventariosTblInvent~",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblProveedor_IdProveedorTblProveedorId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInventarios_CatTipoDeBien_CatTipoDeBienId",
                table: "TblInventarios");

            migrationBuilder.DropForeignKey(
                name: "FK_TblProveedor_CatTipoDeBien_CatTipoDeBienId",
                table: "TblProveedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblProveedor",
                table: "TblProveedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblInventarios",
                table: "TblInventarios");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdClaveCambsTblClaveCabmsId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdClaveSaicaTblClaveSaicaId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdFederalizacionTblFederalizacionId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdInventariosTblInventariosId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdProveedorTblProveedorId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblFederalizacion",
                table: "TblFederalizacion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblClaveSaica",
                table: "TblClaveSaica");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblClaveCambs",
                table: "TblClaveCambs");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdClaveCabmsTblClaveCabmsId",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdClaveSaicaTblClaveSaicaId",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdFederalizacionTblFederalizacionId",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdInventariosTblInventariosId",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdProveedorTblProveedorId",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IProveedorTblProveedorId",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdClaveCabmsTblClaveCabmsId",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdClaveSaicaTblClaveSaicaId",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdFederalizacionTblFederalizacionId",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdInventariosTblInventariosId",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_TblClaveCabmsId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_TblClaveSaicaId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_TblFederalizacionId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_TblInventariosId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_TblProveedorId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "TblProveedorId",
                table: "TblProveedor");

            migrationBuilder.DropColumn(
                name: "TblInventariosId",
                table: "TblInventarios");

            migrationBuilder.DropColumn(
                name: "IdClaveCambsTblClaveCabmsId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdClaveSaicaTblClaveSaicaId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdFederalizacionTblFederalizacionId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdInventariosTblInventariosId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdProveedorTblProveedorId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "TblFederalizacionId",
                table: "TblFederalizacion");

            migrationBuilder.DropColumn(
                name: "TblClaveSaicaId",
                table: "TblClaveSaica");

            migrationBuilder.DropColumn(
                name: "TblClaveCabmsId",
                table: "TblClaveCambs");

            migrationBuilder.DropColumn(
                name: "IdClaveCabmsTblClaveCabmsId",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdClaveSaicaTblClaveSaicaId",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdFederalizacionTblFederalizacionId",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdInventariosTblInventariosId",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdProveedorTblProveedorId",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IProveedorTblProveedorId",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdClaveCabmsTblClaveCabmsId",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdClaveSaicaTblClaveSaicaId",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdFederalizacionTblFederalizacionId",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdInventariosTblInventariosId",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "TblClaveCabmsId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "TblClaveSaicaId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "TblFederalizacionId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "TblInventariosId",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "TblProveedorId",
                table: "TblBienesEquMedico");

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblProveedor",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "TblProveedor",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblInventarios",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "TblInventarios",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCambsid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveSaicaid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFederalizacionid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventariosid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProveedorid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblFederalizacion",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "TblFederalizacion",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "TblClaveSaica",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "CatTipoDeBienId",
                table: "TblClaveCambs",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "TblClaveCambs",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCabmsid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveSaicaid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFederalizacionid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventariosid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProveedorid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IProveedorid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCabmsid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveSaicaid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFederalizacionid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventariosid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCabmsid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveSaicaid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFederalizacionid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventarioid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProveedorid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblProveedor",
                table: "TblProveedor",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblInventarios",
                table: "TblInventarios",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblFederalizacion",
                table: "TblFederalizacion",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblClaveSaica",
                table: "TblClaveSaica",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblClaveCambs",
                table: "TblClaveCambs",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdClaveCambsid",
                table: "TblInstrumentalMedico",
                column: "IdClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdClaveSaicaid",
                table: "TblInstrumentalMedico",
                column: "IdClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdFederalizacionid",
                table: "TblInstrumentalMedico",
                column: "IdFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdInventariosid",
                table: "TblInstrumentalMedico",
                column: "IdInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdProveedorid",
                table: "TblInstrumentalMedico",
                column: "IdProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdClaveCabmsid",
                table: "TblBienesSistemas",
                column: "IdClaveCabmsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdClaveSaicaid",
                table: "TblBienesSistemas",
                column: "IdClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdFederalizacionid",
                table: "TblBienesSistemas",
                column: "IdFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdInventariosid",
                table: "TblBienesSistemas",
                column: "IdInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdProveedorid",
                table: "TblBienesSistemas",
                column: "IdProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IProveedorid",
                table: "TblBienesMuebles",
                column: "IProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdClaveCabmsid",
                table: "TblBienesMuebles",
                column: "IdClaveCabmsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdClaveSaicaid",
                table: "TblBienesMuebles",
                column: "IdClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdFederalizacionid",
                table: "TblBienesMuebles",
                column: "IdFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdInventariosid",
                table: "TblBienesMuebles",
                column: "IdInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdClaveCabmsid",
                table: "TblBienesEquMedico",
                column: "IdClaveCabmsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdClaveSaicaid",
                table: "TblBienesEquMedico",
                column: "IdClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdFederalizacionid",
                table: "TblBienesEquMedico",
                column: "IdFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdInventarioid",
                table: "TblBienesEquMedico",
                column: "IdInventarioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdProveedorid",
                table: "TblBienesEquMedico",
                column: "IdProveedorid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveCambs_IdClaveCabmsid",
                table: "TblBienesEquMedico",
                column: "IdClaveCabmsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveSaica_IdClaveSaicaid",
                table: "TblBienesEquMedico",
                column: "IdClaveSaicaid",
                principalTable: "TblClaveSaica",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblFederalizacion_IdFederalizacionid",
                table: "TblBienesEquMedico",
                column: "IdFederalizacionid",
                principalTable: "TblFederalizacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblInventarios_IdInventarioid",
                table: "TblBienesEquMedico",
                column: "IdInventarioid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblProveedor_IdProveedorid",
                table: "TblBienesEquMedico",
                column: "IdProveedorid",
                principalTable: "TblProveedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblProveedor_IProveedorid",
                table: "TblBienesMuebles",
                column: "IProveedorid",
                principalTable: "TblProveedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_IdClaveCabmsid",
                table: "TblBienesMuebles",
                column: "IdClaveCabmsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblClaveSaica_IdClaveSaicaid",
                table: "TblBienesMuebles",
                column: "IdClaveSaicaid",
                principalTable: "TblClaveSaica",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblFederalizacion_IdFederalizacionid",
                table: "TblBienesMuebles",
                column: "IdFederalizacionid",
                principalTable: "TblFederalizacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_IdInventariosid",
                table: "TblBienesMuebles",
                column: "IdInventariosid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblClaveCambs_IdClaveCabmsid",
                table: "TblBienesSistemas",
                column: "IdClaveCabmsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblClaveSaica_IdClaveSaicaid",
                table: "TblBienesSistemas",
                column: "IdClaveSaicaid",
                principalTable: "TblClaveSaica",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblFederalizacion_IdFederalizacionid",
                table: "TblBienesSistemas",
                column: "IdFederalizacionid",
                principalTable: "TblFederalizacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblInventarios_IdInventariosid",
                table: "TblBienesSistemas",
                column: "IdInventariosid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblProveedor_IdProveedorid",
                table: "TblBienesSistemas",
                column: "IdProveedorid",
                principalTable: "TblProveedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblClaveCambs_CatTipoDeBien_CatTipoDeBienId",
                table: "TblClaveCambs",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblFederalizacion_CatTipoDeBien_CatTipoDeBienId",
                table: "TblFederalizacion",
                column: "CatTipoDeBienId",
                principalTable: "CatTipoDeBien",
                principalColumn: "CatTipoDeBienId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveCambs_IdClaveCambsid",
                table: "TblInstrumentalMedico",
                column: "IdClaveCambsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveSaica_IdClaveSaicaid",
                table: "TblInstrumentalMedico",
                column: "IdClaveSaicaid",
                principalTable: "TblClaveSaica",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblFederalizacion_IdFederalizacionid",
                table: "TblInstrumentalMedico",
                column: "IdFederalizacionid",
                principalTable: "TblFederalizacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblInventarios_IdInventariosid",
                table: "TblInstrumentalMedico",
                column: "IdInventariosid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblProveedor_IdProveedorid",
                table: "TblInstrumentalMedico",
                column: "IdProveedorid",
                principalTable: "TblProveedor",
                principalColumn: "id",
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
        }
    }
}
