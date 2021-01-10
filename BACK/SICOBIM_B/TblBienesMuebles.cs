using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class TblBienesMuebles
    {
        public TblBienesMuebles()
        {

            TblSalidas = new HashSet<TblSalidas>();

        }


        public int TblBienesMueblesId { get; set; }
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public int? CatEstadoDelBienid { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public int UsuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }
        public int Cantidad { get; set; }
        public double Costounitario { get; set; }
        public int? CatGarantiaid { get; set; }
        public int? CatTipoEntradaid { get; set; }
        public int? CatTipoPartidaid { get; set; }
        public string Observaciones { get; set; }
        public int? CatPisosid { get; set; }
        public int? IdProveedorid { get; set; }
        public int? Catareaid { get; set; }
        public int? Catservicioid { get; set; }
        public int? IdClaveSaicaid { get; set; }
        public int? IdContratoBienid { get; set; }
        public int? IdFederalizacionid { get; set; }
        public int? IdInventarioid { get; set; }
        public int? IdResguardatariosid { get; set; }
        public int? IdClaveCabmsid { get; set; }
        public int? IdFacturasid { get; set; }
        public int? CatTipoDeBienid { get; set; }

        public virtual CatEstadoDelBien CatEstadoDelBien { get; set; }
        public virtual CatGarantia CatGarantia { get; set; }
        public virtual CatPiso CatPisos { get; set; }
        public virtual CatTipoDeBien CatTipoDeBien { get; set; }
        public virtual CatTipoEntrada CatTipoEntrada { get; set; }
        public virtual CatTipoPartida CatTipoPartida { get; set; }
        public virtual CatArea IdArea { get; set; }
        public virtual CatServicio IdServicio { get; set; }
        public virtual TblClaveCabms IdClaveCabms { get; set; }
        public virtual TblClaveSaica IdClaveSaica { get; set; }
        public virtual TblContratoBien IdContratoBien { get; set; }
        public virtual TblFacturas IdFactura { get; set; }
        public virtual TblFederalizacion IdFederalizacion { get; set; }
        public virtual TblInventarios IdInventario { get; set; }
        public virtual TblResguardatarios IdResguardatarios { get; set; }
        public virtual TblProveedor IdProveedor { get; set; }

        public virtual ICollection<TblSalidas> TblSalidas { get; set; }
    }
}
