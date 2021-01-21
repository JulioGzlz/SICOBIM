using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class tb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "costounitario",
                table: "TblInstrumentalMedico",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "costounitario",
                table: "TblBienesSistemas",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "costounitario",
                table: "TblBienesMuebles",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "costounitario",
                table: "TblBienesEquMedico",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "costounitario",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "costounitario",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "costounitario",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "costounitario",
                table: "TblBienesEquMedico");
        }
    }
}
