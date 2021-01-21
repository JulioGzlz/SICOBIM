using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SICOBIM_B.Migrations
{
    public partial class tb3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_IdInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblProveedor_IProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblInventarios_IdInventariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblInventarios_IdInventariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidas_TblBienesSistemas_TblBienesSistemasId",
                table: "TblSalidas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidas_TblInstrumentalMedico_TblInstrumentalMedicoId",
                table: "TblSalidas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblInstrumentalMedico",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdInventariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblBienesSistemas",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdInventariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblBienesMuebles",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "id",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdInventariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "id",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdInventariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "id",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.AddColumn<int>(
                name: "TblInstrumentalMedicoId",
                table: "TblInstrumentalMedico",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventarioid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblBienesSistemasId",
                table: "TblBienesSistemas",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventarioid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TblBienesMueblesId",
                table: "TblBienesMuebles",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventarioid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProveedorid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "descripcion",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblInstrumentalMedico",
                table: "TblInstrumentalMedico",
                column: "TblInstrumentalMedicoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblBienesSistemas",
                table: "TblBienesSistemas",
                column: "TblBienesSistemasId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblBienesMuebles",
                table: "TblBienesMuebles",
                column: "TblBienesMueblesId");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdInventarioid",
                table: "TblInstrumentalMedico",
                column: "IdInventarioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdInventarioid",
                table: "TblBienesSistemas",
                column: "IdInventarioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdInventarioid",
                table: "TblBienesMuebles",
                column: "IdInventarioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdProveedorid",
                table: "TblBienesMuebles",
                column: "IdProveedorid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_IdInventarioid",
                table: "TblBienesMuebles",
                column: "IdInventarioid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblProveedor_IdProveedorid",
                table: "TblBienesMuebles",
                column: "IdProveedorid",
                principalTable: "TblProveedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblInventarios_IdInventarioid",
                table: "TblBienesSistemas",
                column: "IdInventarioid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblInventarios_IdInventarioid",
                table: "TblInstrumentalMedico",
                column: "IdInventarioid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidas_TblBienesSistemas_TblBienesSistemasId",
                table: "TblSalidas",
                column: "TblBienesSistemasId",
                principalTable: "TblBienesSistemas",
                principalColumn: "TblBienesSistemasId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidas_TblInstrumentalMedico_TblInstrumentalMedicoId",
                table: "TblSalidas",
                column: "TblInstrumentalMedicoId",
                principalTable: "TblInstrumentalMedico",
                principalColumn: "TblInstrumentalMedicoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_IdInventarioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblProveedor_IdProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblInventarios_IdInventarioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblInventarios_IdInventarioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidas_TblBienesSistemas_TblBienesSistemasId",
                table: "TblSalidas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidas_TblInstrumentalMedico_TblInstrumentalMedicoId",
                table: "TblSalidas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblInstrumentalMedico",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdInventarioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblBienesSistemas",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdInventarioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TblBienesMuebles",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdInventarioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "TblInstrumentalMedicoId",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdInventarioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "TblBienesSistemasId",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdInventarioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "TblBienesMueblesId",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdInventarioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "descripcion",
                table: "TblBienesEquMedico");

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdInventariosid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdInventariosid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdInventariosid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IProveedorid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblInstrumentalMedico",
                table: "TblInstrumentalMedico",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblBienesSistemas",
                table: "TblBienesSistemas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TblBienesMuebles",
                table: "TblBienesMuebles",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdInventariosid",
                table: "TblInstrumentalMedico",
                column: "IdInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdInventariosid",
                table: "TblBienesSistemas",
                column: "IdInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdInventariosid",
                table: "TblBienesMuebles",
                column: "IdInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IProveedorid",
                table: "TblBienesMuebles",
                column: "IProveedorid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_IdInventariosid",
                table: "TblBienesMuebles",
                column: "IdInventariosid",
                principalTable: "TblInventarios",
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
                name: "FK_TblBienesSistemas_TblInventarios_IdInventariosid",
                table: "TblBienesSistemas",
                column: "IdInventariosid",
                principalTable: "TblInventarios",
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
                name: "FK_TblSalidas_TblBienesSistemas_TblBienesSistemasId",
                table: "TblSalidas",
                column: "TblBienesSistemasId",
                principalTable: "TblBienesSistemas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidas_TblInstrumentalMedico_TblInstrumentalMedicoId",
                table: "TblSalidas",
                column: "TblInstrumentalMedicoId",
                principalTable: "TblInstrumentalMedico",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
