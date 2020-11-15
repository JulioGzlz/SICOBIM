using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class new_tb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidas_TblBienesMuebles_TblBienesMueblesId",
                table: "TblSalidas");

            migrationBuilder.DropIndex(
                name: "IX_TblSalidas_TblBienesMueblesId",
                table: "TblSalidas");

            migrationBuilder.DropColumn(
                name: "TblBienesMueblesId",
                table: "TblSalidas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TblBienesMueblesId",
                table: "TblSalidas",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidas_TblBienesMueblesId",
                table: "TblSalidas",
                column: "TblBienesMueblesId");

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidas_TblBienesMuebles_TblBienesMueblesId",
                table: "TblSalidas",
                column: "TblBienesMueblesId",
                principalTable: "TblBienesMuebles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
