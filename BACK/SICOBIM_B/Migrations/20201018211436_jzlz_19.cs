using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "idfederalizacion",
                table: "TblBienesEquMedico");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "idfederalizacion",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
