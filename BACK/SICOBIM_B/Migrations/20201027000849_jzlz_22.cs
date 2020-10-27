using Microsoft.EntityFrameworkCore.Migrations;

namespace SICOBIM_B.Migrations
{
    public partial class jzlz_22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblInventarios_idInventarioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblAreaServicio_tblAreaServicioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveCambs_tblClaveCambsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveSaica_tblClaveSaicaid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblContratoBien_tblContratoBienid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_tblFacturasid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblFederalizacion_tblFederalizacionid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblProveedor_tblProveedorid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblResguardatarios_tblResguardatariosid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblAreaServicio_tblAreaServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_tblClaveCambsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblClaveSaica_tblClaveSaicaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblContratoBien_tblContratoBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_tblFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFederalizacion_tblFederalizacionid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_tblInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblProveedor_tblProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblResguardatarios_tblResguardatariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblAreaServicio_tblAreaServicioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblClaveCambs_tblClaveCambsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblClaveSaica_tblClaveSaicaid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblContratoBien_tblContratoBienid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_tblFacturasid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblFederalizacion_tblFederalizacionid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblInventarios_tblInventariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblProveedor_tblProveedorid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblResguardatarios_tblResguardatariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblAreaServicio_tblAreaServicioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveCambs_tblClaveCambsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveSaica_tblClaveSaicaid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblContratoBien_tblContratoBienid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_tblFacturasid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblFederalizacion_tblFederalizacionid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblInventarios_tblInventariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblProveedor_tblProveedorid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblResguardatarios_tblResguardatarios~",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_TblBienesMuebles_tblbienesid",
                table: "TblSalidaBien");

            migrationBuilder.DropIndex(
                name: "IX_TblSalidaBien_tblbienesid",
                table: "TblSalidaBien");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_tblAreaServicioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_tblClaveCambsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_tblClaveSaicaid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_tblContratoBienid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_tblFacturasid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_tblFederalizacionid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_tblInventariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_tblProveedorid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_tblResguardatariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_tblAreaServicioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_tblClaveCambsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_tblClaveSaicaid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_tblContratoBienid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_tblFacturasid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_tblFederalizacionid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_tblInventariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_tblProveedorid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_tblResguardatariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblAreaServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblClaveCambsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblClaveSaicaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblContratoBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblFederalizacionid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_tblResguardatariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_tblAreaServicioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_tblClaveCambsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_tblClaveSaicaid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_tblContratoBienid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_tblFacturasid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_tblFederalizacionid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_tblProveedorid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_tblResguardatariosid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idbien",
                table: "TblSalidaBien");

            migrationBuilder.DropColumn(
                name: "idtiposalida",
                table: "TblSalidaBien");

            migrationBuilder.DropColumn(
                name: "idunidaddestino",
                table: "TblSalidaBien");

            migrationBuilder.DropColumn(
                name: "tblbienesid",
                table: "TblSalidaBien");

            migrationBuilder.DropColumn(
                name: "idEstatus",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "idServicio",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "idSexo",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "idTipoContrato",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "idTurno",
                table: "TblResguardatarios");

            migrationBuilder.DropColumn(
                name: "idAñosGarantia",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idEstadoFisico",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idResguardatario",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idServicio",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idTipoBien",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idclaveCambs",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idclaveSaica",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idcontrato",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "identrada",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idfactura",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idfederalizacion",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idinventario",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idpiso",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idproveedor",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "idtipopartida",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "tblAreaServicioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "tblClaveCambsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "tblClaveSaicaid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "tblContratoBienid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "tblFacturasid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "tblFederalizacionid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "tblInventariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "tblProveedorid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "tblResguardatariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "facturas",
                table: "TblFacturas");

            migrationBuilder.DropColumn(
                name: "idAñosGarantia",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idEstadoFisico",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idResguardatario",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idServicio",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idTipoBien",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idclaveCambs",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idclaveSaica",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idcontrato",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "identrada",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idfactura",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idfederalizacion",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idinventario",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idpiso",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idproveedor",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idtipopartida",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "tblAreaServicioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "tblClaveCambsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "tblClaveSaicaid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "tblContratoBienid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "tblFacturasid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "tblFederalizacionid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "tblInventariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "tblProveedorid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "tblResguardatariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "idAñosGarantia",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idEstadoFisico",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idResguardatario",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idServicio",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idTipoBien",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idclaveCambs",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idclaveSaica",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idcontrato",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "identrada",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idfactura",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idfederalizacion",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idinventario",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idpiso",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idproveedor",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idtipopartida",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblAreaServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblClaveCambsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblClaveSaicaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblContratoBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblFederalizacionid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "tblResguardatariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "idAñosGarantia",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idEstadoFisico",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idResguardatario",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idServicio",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idTipoBien",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idclaveCambs",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idclaveSaica",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idcontrato",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "identrada",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idfactura",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idpiso",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idproveedor",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idtipopartida",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "tblAreaServicioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "tblClaveCambsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "tblClaveSaicaid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "tblContratoBienid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "tblFacturasid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "tblFederalizacionid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "tblProveedorid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "tblResguardatariosid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "idarea",
                table: "TblAreaServicio");

            migrationBuilder.DropColumn(
                name: "idservicio",
                table: "TblAreaServicio");

            migrationBuilder.RenameColumn(
                name: "idInventarioid",
                table: "TblBienesEquMedico",
                newName: "IdInventarioid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienesEquMedico_idInventarioid",
                table: "TblBienesEquMedico",
                newName: "IX_TblBienesEquMedico_IdInventarioid");

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienid",
                table: "TblSalidaBien",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Idbienesid",
                table: "TblSalidaBien",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienid",
                table: "TblProveedor",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienid",
                table: "TblInventarios",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAreaServicioid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCambsid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveSaicaid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdContratoBienid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFederalizacionid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventariosid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProveedorid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdResguardatariosid",
                table: "TblInstrumentalMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienid",
                table: "TblFederalizacion",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienid",
                table: "TblFacturas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "factura",
                table: "TblFacturas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienid",
                table: "TblContratoBien",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienid",
                table: "TblClaveSaica",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CatTipoDeBienid",
                table: "TblClaveCambs",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAreaServicioid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCambsid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveSaicaid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdContratoBienid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFederalizacionid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventariosid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProveedorid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdResguardatariosid",
                table: "TblBienesSistemas",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IProveedorid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAreaServicioid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCambsid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveSaicaid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdContratoBienid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFederalizacionid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdInventariosid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdResguardatariosid",
                table: "TblBienesMuebles",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdAreaServicioid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveCambsid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdClaveSaicaid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdContratoBienid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFacturasid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdFederalizacionid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdProveedorid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdResguardatariosid",
                table: "TblBienesEquMedico",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidaBien_CatTipoDeBienid",
                table: "TblSalidaBien",
                column: "CatTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidaBien_Idbienesid",
                table: "TblSalidaBien",
                column: "Idbienesid");

            migrationBuilder.CreateIndex(
                name: "IX_TblProveedor_CatTipoDeBienid",
                table: "TblProveedor",
                column: "CatTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInventarios_CatTipoDeBienid",
                table: "TblInventarios",
                column: "CatTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdAreaServicioid",
                table: "TblInstrumentalMedico",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdClaveCambsid",
                table: "TblInstrumentalMedico",
                column: "IdClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdClaveSaicaid",
                table: "TblInstrumentalMedico",
                column: "IdClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdContratoBienid",
                table: "TblInstrumentalMedico",
                column: "IdContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasid",
                table: "TblInstrumentalMedico",
                column: "IdFacturasid");

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
                name: "IX_TblInstrumentalMedico_IdResguardatariosid",
                table: "TblInstrumentalMedico",
                column: "IdResguardatariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblFederalizacion_CatTipoDeBienid",
                table: "TblFederalizacion",
                column: "CatTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblFacturas_CatTipoDeBienid",
                table: "TblFacturas",
                column: "CatTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblContratoBien_CatTipoDeBienid",
                table: "TblContratoBien",
                column: "CatTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblClaveSaica_CatTipoDeBienid",
                table: "TblClaveSaica",
                column: "CatTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblClaveCambs_CatTipoDeBienid",
                table: "TblClaveCambs",
                column: "CatTipoDeBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdAreaServicioid",
                table: "TblBienesSistemas",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdClaveCambsid",
                table: "TblBienesSistemas",
                column: "IdClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdClaveSaicaid",
                table: "TblBienesSistemas",
                column: "IdClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdContratoBienid",
                table: "TblBienesSistemas",
                column: "IdContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_IdFacturasid",
                table: "TblBienesSistemas",
                column: "IdFacturasid");

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
                name: "IX_TblBienesSistemas_IdResguardatariosid",
                table: "TblBienesSistemas",
                column: "IdResguardatariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IProveedorid",
                table: "TblBienesMuebles",
                column: "IProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdAreaServicioid",
                table: "TblBienesMuebles",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdClaveCambsid",
                table: "TblBienesMuebles",
                column: "IdClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdClaveSaicaid",
                table: "TblBienesMuebles",
                column: "IdClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdContratoBienid",
                table: "TblBienesMuebles",
                column: "IdContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdFacturasid",
                table: "TblBienesMuebles",
                column: "IdFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdFederalizacionid",
                table: "TblBienesMuebles",
                column: "IdFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdInventariosid",
                table: "TblBienesMuebles",
                column: "IdInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_IdResguardatariosid",
                table: "TblBienesMuebles",
                column: "IdResguardatariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdAreaServicioid",
                table: "TblBienesEquMedico",
                column: "IdAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdClaveCambsid",
                table: "TblBienesEquMedico",
                column: "IdClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdClaveSaicaid",
                table: "TblBienesEquMedico",
                column: "IdClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdContratoBienid",
                table: "TblBienesEquMedico",
                column: "IdContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdFacturasid",
                table: "TblBienesEquMedico",
                column: "IdFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdFederalizacionid",
                table: "TblBienesEquMedico",
                column: "IdFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdProveedorid",
                table: "TblBienesEquMedico",
                column: "IdProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_IdResguardatariosid",
                table: "TblBienesEquMedico",
                column: "IdResguardatariosid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblAreaServicio_IdAreaServicioid",
                table: "TblBienesEquMedico",
                column: "IdAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveCambs_IdClaveCambsid",
                table: "TblBienesEquMedico",
                column: "IdClaveCambsid",
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
                name: "FK_TblBienesEquMedico_TblContratoBien_IdContratoBienid",
                table: "TblBienesEquMedico",
                column: "IdContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_IdFacturasid",
                table: "TblBienesEquMedico",
                column: "IdFacturasid",
                principalTable: "TblFacturas",
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
                name: "FK_TblBienesEquMedico_TblResguardatarios_IdResguardatariosid",
                table: "TblBienesEquMedico",
                column: "IdResguardatariosid",
                principalTable: "TblResguardatarios",
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
                name: "FK_TblBienesMuebles_TblAreaServicio_IdAreaServicioid",
                table: "TblBienesMuebles",
                column: "IdAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_IdClaveCambsid",
                table: "TblBienesMuebles",
                column: "IdClaveCambsid",
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
                name: "FK_TblBienesMuebles_TblContratoBien_IdContratoBienid",
                table: "TblBienesMuebles",
                column: "IdContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_IdFacturasid",
                table: "TblBienesMuebles",
                column: "IdFacturasid",
                principalTable: "TblFacturas",
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
                name: "FK_TblBienesMuebles_TblResguardatarios_IdResguardatariosid",
                table: "TblBienesMuebles",
                column: "IdResguardatariosid",
                principalTable: "TblResguardatarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblAreaServicio_IdAreaServicioid",
                table: "TblBienesSistemas",
                column: "IdAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblClaveCambs_IdClaveCambsid",
                table: "TblBienesSistemas",
                column: "IdClaveCambsid",
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
                name: "FK_TblBienesSistemas_TblContratoBien_IdContratoBienid",
                table: "TblBienesSistemas",
                column: "IdContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_IdFacturasid",
                table: "TblBienesSistemas",
                column: "IdFacturasid",
                principalTable: "TblFacturas",
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
                name: "FK_TblBienesSistemas_TblResguardatarios_IdResguardatariosid",
                table: "TblBienesSistemas",
                column: "IdResguardatariosid",
                principalTable: "TblResguardatarios",
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
                name: "FK_TblInstrumentalMedico_TblAreaServicio_IdAreaServicioid",
                table: "TblInstrumentalMedico",
                column: "IdAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
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
                name: "FK_TblInstrumentalMedico_TblContratoBien_IdContratoBienid",
                table: "TblInstrumentalMedico",
                column: "IdContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_IdFacturasid",
                table: "TblInstrumentalMedico",
                column: "IdFacturasid",
                principalTable: "TblFacturas",
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
                name: "FK_TblInstrumentalMedico_TblResguardatarios_IdResguardatariosid",
                table: "TblInstrumentalMedico",
                column: "IdResguardatariosid",
                principalTable: "TblResguardatarios",
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

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_TblBienesMuebles_Idbienesid",
                table: "TblSalidaBien",
                column: "Idbienesid",
                principalTable: "TblBienesMuebles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblAreaServicio_IdAreaServicioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveCambs_IdClaveCambsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveSaica_IdClaveSaicaid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblContratoBien_IdContratoBienid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_IdFacturasid",
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
                name: "FK_TblBienesEquMedico_TblResguardatarios_IdResguardatariosid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblProveedor_IProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblAreaServicio_IdAreaServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_IdClaveCambsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblClaveSaica_IdClaveSaicaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblContratoBien_IdContratoBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_IdFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblFederalizacion_IdFederalizacionid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_IdInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesMuebles_TblResguardatarios_IdResguardatariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblAreaServicio_IdAreaServicioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblClaveCambs_IdClaveCambsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblClaveSaica_IdClaveSaicaid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblContratoBien_IdContratoBienid",
                table: "TblBienesSistemas");

            migrationBuilder.DropForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_IdFacturasid",
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
                name: "FK_TblBienesSistemas_TblResguardatarios_IdResguardatariosid",
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
                name: "FK_TblInstrumentalMedico_TblAreaServicio_IdAreaServicioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveCambs_IdClaveCambsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveSaica_IdClaveSaicaid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblContratoBien_IdContratoBienid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_IdFacturasid",
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
                name: "FK_TblInstrumentalMedico_TblResguardatarios_IdResguardatariosid",
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

            migrationBuilder.DropForeignKey(
                name: "FK_TblSalidaBien_TblBienesMuebles_Idbienesid",
                table: "TblSalidaBien");

            migrationBuilder.DropIndex(
                name: "IX_TblSalidaBien_CatTipoDeBienid",
                table: "TblSalidaBien");

            migrationBuilder.DropIndex(
                name: "IX_TblSalidaBien_Idbienesid",
                table: "TblSalidaBien");

            migrationBuilder.DropIndex(
                name: "IX_TblProveedor_CatTipoDeBienid",
                table: "TblProveedor");

            migrationBuilder.DropIndex(
                name: "IX_TblInventarios_CatTipoDeBienid",
                table: "TblInventarios");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdAreaServicioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdClaveCambsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdClaveSaicaid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdContratoBienid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdFacturasid",
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

            migrationBuilder.DropIndex(
                name: "IX_TblInstrumentalMedico_IdResguardatariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblFederalizacion_CatTipoDeBienid",
                table: "TblFederalizacion");

            migrationBuilder.DropIndex(
                name: "IX_TblFacturas_CatTipoDeBienid",
                table: "TblFacturas");

            migrationBuilder.DropIndex(
                name: "IX_TblContratoBien_CatTipoDeBienid",
                table: "TblContratoBien");

            migrationBuilder.DropIndex(
                name: "IX_TblClaveSaica_CatTipoDeBienid",
                table: "TblClaveSaica");

            migrationBuilder.DropIndex(
                name: "IX_TblClaveCambs_CatTipoDeBienid",
                table: "TblClaveCambs");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdAreaServicioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdClaveCambsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdClaveSaicaid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdContratoBienid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesSistemas_IdFacturasid",
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
                name: "IX_TblBienesSistemas_IdResguardatariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdAreaServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdClaveCambsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdClaveSaicaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdContratoBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdFederalizacionid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesMuebles_IdResguardatariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdAreaServicioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdClaveCambsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdClaveSaicaid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdContratoBienid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdFacturasid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdFederalizacionid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdProveedorid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropIndex(
                name: "IX_TblBienesEquMedico_IdResguardatariosid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienid",
                table: "TblSalidaBien");

            migrationBuilder.DropColumn(
                name: "Idbienesid",
                table: "TblSalidaBien");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienid",
                table: "TblProveedor");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienid",
                table: "TblInventarios");

            migrationBuilder.DropColumn(
                name: "IdAreaServicioid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdClaveCambsid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdClaveSaicaid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdContratoBienid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "IdFacturasid",
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
                name: "IdResguardatariosid",
                table: "TblInstrumentalMedico");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienid",
                table: "TblFederalizacion");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienid",
                table: "TblFacturas");

            migrationBuilder.DropColumn(
                name: "factura",
                table: "TblFacturas");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienid",
                table: "TblContratoBien");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienid",
                table: "TblClaveSaica");

            migrationBuilder.DropColumn(
                name: "CatTipoDeBienid",
                table: "TblClaveCambs");

            migrationBuilder.DropColumn(
                name: "IdAreaServicioid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdClaveCambsid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdClaveSaicaid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdContratoBienid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IdFacturasid",
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
                name: "IdResguardatariosid",
                table: "TblBienesSistemas");

            migrationBuilder.DropColumn(
                name: "IProveedorid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdAreaServicioid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdClaveCambsid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdClaveSaicaid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdContratoBienid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdFacturasid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdFederalizacionid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdInventariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdResguardatariosid",
                table: "TblBienesMuebles");

            migrationBuilder.DropColumn(
                name: "IdAreaServicioid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdClaveCambsid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdClaveSaicaid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdContratoBienid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdFacturasid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdFederalizacionid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdProveedorid",
                table: "TblBienesEquMedico");

            migrationBuilder.DropColumn(
                name: "IdResguardatariosid",
                table: "TblBienesEquMedico");

            migrationBuilder.RenameColumn(
                name: "IdInventarioid",
                table: "TblBienesEquMedico",
                newName: "idInventarioid");

            migrationBuilder.RenameIndex(
                name: "IX_TblBienesEquMedico_IdInventarioid",
                table: "TblBienesEquMedico",
                newName: "IX_TblBienesEquMedico_idInventarioid");

            migrationBuilder.AddColumn<int>(
                name: "idbien",
                table: "TblSalidaBien",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idtiposalida",
                table: "TblSalidaBien",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idunidaddestino",
                table: "TblSalidaBien",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tblbienesid",
                table: "TblSalidaBien",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idEstatus",
                table: "TblResguardatarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idServicio",
                table: "TblResguardatarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idSexo",
                table: "TblResguardatarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTipoContrato",
                table: "TblResguardatarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTurno",
                table: "TblResguardatarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idAñosGarantia",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idEstadoFisico",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idResguardatario",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idServicio",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTipoBien",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idclaveCambs",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "idclaveSaica",
                table: "TblInstrumentalMedico",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idcontrato",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "identrada",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idfactura",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idfederalizacion",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idinventario",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idpiso",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idproveedor",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idtipopartida",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tblAreaServicioid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblClaveCambsid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblClaveSaicaid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblContratoBienid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblFacturasid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblFederalizacionid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblInventariosid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblProveedorid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblResguardatariosid",
                table: "TblInstrumentalMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "facturas",
                table: "TblFacturas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idAñosGarantia",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idEstadoFisico",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idResguardatario",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idServicio",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTipoBien",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idclaveCambs",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "idclaveSaica",
                table: "TblBienesSistemas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idcontrato",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "identrada",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idfactura",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idfederalizacion",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idinventario",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idpiso",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idproveedor",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idtipopartida",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tblAreaServicioid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblClaveCambsid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblClaveSaicaid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblContratoBienid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblFacturasid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblFederalizacionid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblInventariosid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblProveedorid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblResguardatariosid",
                table: "TblBienesSistemas",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idAñosGarantia",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idEstadoFisico",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idResguardatario",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idServicio",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTipoBien",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idclaveCambs",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "idclaveSaica",
                table: "TblBienesMuebles",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idcontrato",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "identrada",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idfactura",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idfederalizacion",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idinventario",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idpiso",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idproveedor",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idtipopartida",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tblAreaServicioid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblClaveCambsid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblClaveSaicaid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblContratoBienid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblFacturasid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblFederalizacionid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblInventariosid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblProveedorid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblResguardatariosid",
                table: "TblBienesMuebles",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idAñosGarantia",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idEstadoFisico",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idResguardatario",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idServicio",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idTipoBien",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idclaveCambs",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "idclaveSaica",
                table: "TblBienesEquMedico",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idcontrato",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "identrada",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idfactura",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idpiso",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idproveedor",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idtipopartida",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "tblAreaServicioid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblClaveCambsid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblClaveSaicaid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblContratoBienid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblFacturasid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblFederalizacionid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblProveedorid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tblResguardatariosid",
                table: "TblBienesEquMedico",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idarea",
                table: "TblAreaServicio",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idservicio",
                table: "TblAreaServicio",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TblSalidaBien_tblbienesid",
                table: "TblSalidaBien",
                column: "tblbienesid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblAreaServicioid",
                table: "TblInstrumentalMedico",
                column: "tblAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblClaveCambsid",
                table: "TblInstrumentalMedico",
                column: "tblClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblClaveSaicaid",
                table: "TblInstrumentalMedico",
                column: "tblClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblContratoBienid",
                table: "TblInstrumentalMedico",
                column: "tblContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblFacturasid",
                table: "TblInstrumentalMedico",
                column: "tblFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblFederalizacionid",
                table: "TblInstrumentalMedico",
                column: "tblFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblInventariosid",
                table: "TblInstrumentalMedico",
                column: "tblInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblProveedorid",
                table: "TblInstrumentalMedico",
                column: "tblProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblInstrumentalMedico_tblResguardatariosid",
                table: "TblInstrumentalMedico",
                column: "tblResguardatariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblAreaServicioid",
                table: "TblBienesSistemas",
                column: "tblAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblClaveCambsid",
                table: "TblBienesSistemas",
                column: "tblClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblClaveSaicaid",
                table: "TblBienesSistemas",
                column: "tblClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblContratoBienid",
                table: "TblBienesSistemas",
                column: "tblContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblFacturasid",
                table: "TblBienesSistemas",
                column: "tblFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblFederalizacionid",
                table: "TblBienesSistemas",
                column: "tblFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblInventariosid",
                table: "TblBienesSistemas",
                column: "tblInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblProveedorid",
                table: "TblBienesSistemas",
                column: "tblProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesSistemas_tblResguardatariosid",
                table: "TblBienesSistemas",
                column: "tblResguardatariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblAreaServicioid",
                table: "TblBienesMuebles",
                column: "tblAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblClaveCambsid",
                table: "TblBienesMuebles",
                column: "tblClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblClaveSaicaid",
                table: "TblBienesMuebles",
                column: "tblClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblContratoBienid",
                table: "TblBienesMuebles",
                column: "tblContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblFacturasid",
                table: "TblBienesMuebles",
                column: "tblFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblFederalizacionid",
                table: "TblBienesMuebles",
                column: "tblFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblInventariosid",
                table: "TblBienesMuebles",
                column: "tblInventariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblProveedorid",
                table: "TblBienesMuebles",
                column: "tblProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesMuebles_tblResguardatariosid",
                table: "TblBienesMuebles",
                column: "tblResguardatariosid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblAreaServicioid",
                table: "TblBienesEquMedico",
                column: "tblAreaServicioid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblClaveCambsid",
                table: "TblBienesEquMedico",
                column: "tblClaveCambsid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblClaveSaicaid",
                table: "TblBienesEquMedico",
                column: "tblClaveSaicaid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblContratoBienid",
                table: "TblBienesEquMedico",
                column: "tblContratoBienid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblFacturasid",
                table: "TblBienesEquMedico",
                column: "tblFacturasid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblFederalizacionid",
                table: "TblBienesEquMedico",
                column: "tblFederalizacionid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblProveedorid",
                table: "TblBienesEquMedico",
                column: "tblProveedorid");

            migrationBuilder.CreateIndex(
                name: "IX_TblBienesEquMedico_tblResguardatariosid",
                table: "TblBienesEquMedico",
                column: "tblResguardatariosid");

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblInventarios_idInventarioid",
                table: "TblBienesEquMedico",
                column: "idInventarioid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblAreaServicio_tblAreaServicioid",
                table: "TblBienesEquMedico",
                column: "tblAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveCambs_tblClaveCambsid",
                table: "TblBienesEquMedico",
                column: "tblClaveCambsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblClaveSaica_tblClaveSaicaid",
                table: "TblBienesEquMedico",
                column: "tblClaveSaicaid",
                principalTable: "TblClaveSaica",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblContratoBien_tblContratoBienid",
                table: "TblBienesEquMedico",
                column: "tblContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblFacturas_tblFacturasid",
                table: "TblBienesEquMedico",
                column: "tblFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblFederalizacion_tblFederalizacionid",
                table: "TblBienesEquMedico",
                column: "tblFederalizacionid",
                principalTable: "TblFederalizacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblProveedor_tblProveedorid",
                table: "TblBienesEquMedico",
                column: "tblProveedorid",
                principalTable: "TblProveedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesEquMedico_TblResguardatarios_tblResguardatariosid",
                table: "TblBienesEquMedico",
                column: "tblResguardatariosid",
                principalTable: "TblResguardatarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblAreaServicio_tblAreaServicioid",
                table: "TblBienesMuebles",
                column: "tblAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblClaveCambs_tblClaveCambsid",
                table: "TblBienesMuebles",
                column: "tblClaveCambsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblClaveSaica_tblClaveSaicaid",
                table: "TblBienesMuebles",
                column: "tblClaveSaicaid",
                principalTable: "TblClaveSaica",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblContratoBien_tblContratoBienid",
                table: "TblBienesMuebles",
                column: "tblContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblFacturas_tblFacturasid",
                table: "TblBienesMuebles",
                column: "tblFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblFederalizacion_tblFederalizacionid",
                table: "TblBienesMuebles",
                column: "tblFederalizacionid",
                principalTable: "TblFederalizacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblInventarios_tblInventariosid",
                table: "TblBienesMuebles",
                column: "tblInventariosid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblProveedor_tblProveedorid",
                table: "TblBienesMuebles",
                column: "tblProveedorid",
                principalTable: "TblProveedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesMuebles_TblResguardatarios_tblResguardatariosid",
                table: "TblBienesMuebles",
                column: "tblResguardatariosid",
                principalTable: "TblResguardatarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblAreaServicio_tblAreaServicioid",
                table: "TblBienesSistemas",
                column: "tblAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblClaveCambs_tblClaveCambsid",
                table: "TblBienesSistemas",
                column: "tblClaveCambsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblClaveSaica_tblClaveSaicaid",
                table: "TblBienesSistemas",
                column: "tblClaveSaicaid",
                principalTable: "TblClaveSaica",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblContratoBien_tblContratoBienid",
                table: "TblBienesSistemas",
                column: "tblContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblFacturas_tblFacturasid",
                table: "TblBienesSistemas",
                column: "tblFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblFederalizacion_tblFederalizacionid",
                table: "TblBienesSistemas",
                column: "tblFederalizacionid",
                principalTable: "TblFederalizacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblInventarios_tblInventariosid",
                table: "TblBienesSistemas",
                column: "tblInventariosid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblProveedor_tblProveedorid",
                table: "TblBienesSistemas",
                column: "tblProveedorid",
                principalTable: "TblProveedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblBienesSistemas_TblResguardatarios_tblResguardatariosid",
                table: "TblBienesSistemas",
                column: "tblResguardatariosid",
                principalTable: "TblResguardatarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblAreaServicio_tblAreaServicioid",
                table: "TblInstrumentalMedico",
                column: "tblAreaServicioid",
                principalTable: "TblAreaServicio",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveCambs_tblClaveCambsid",
                table: "TblInstrumentalMedico",
                column: "tblClaveCambsid",
                principalTable: "TblClaveCambs",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblClaveSaica_tblClaveSaicaid",
                table: "TblInstrumentalMedico",
                column: "tblClaveSaicaid",
                principalTable: "TblClaveSaica",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblContratoBien_tblContratoBienid",
                table: "TblInstrumentalMedico",
                column: "tblContratoBienid",
                principalTable: "TblContratoBien",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblFacturas_tblFacturasid",
                table: "TblInstrumentalMedico",
                column: "tblFacturasid",
                principalTable: "TblFacturas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblFederalizacion_tblFederalizacionid",
                table: "TblInstrumentalMedico",
                column: "tblFederalizacionid",
                principalTable: "TblFederalizacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblInventarios_tblInventariosid",
                table: "TblInstrumentalMedico",
                column: "tblInventariosid",
                principalTable: "TblInventarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblProveedor_tblProveedorid",
                table: "TblInstrumentalMedico",
                column: "tblProveedorid",
                principalTable: "TblProveedor",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblInstrumentalMedico_TblResguardatarios_tblResguardatarios~",
                table: "TblInstrumentalMedico",
                column: "tblResguardatariosid",
                principalTable: "TblResguardatarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TblSalidaBien_TblBienesMuebles_tblbienesid",
                table: "TblSalidaBien",
                column: "tblbienesid",
                principalTable: "TblBienesMuebles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
