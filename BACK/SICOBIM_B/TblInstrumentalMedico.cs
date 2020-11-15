using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class TblInstrumentalMedico
    {
        public TblInstrumentalMedico()
        {
            TblSalidas = new HashSet<TblSalidas>();
        }

        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public int Cantidad { get; set; }
        public int? CatGarantiaid { get; set; }
        public int? CatTipoPartidaid { get; set; }
        public int? CatTipoEntradaid { get; set; }
        public int? CatPisosid { get; set; }
        public int? CatEstadoDelBienid { get; set; }
        public string Observaciones { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public int UsuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }
        public int? IdAreaServicioid { get; set; }
        public int? IdClaveCambsid { get; set; }
        public int? IdClaveSaicaid { get; set; }
        public int? IdContratoBienid { get; set; }
        public int? IdFederalizacionid { get; set; }
        public int? IdInventariosid { get; set; }
        public int? IdProveedorid { get; set; }
        public int? IdResguardatariosid { get; set; }
        public int? IdFacturasIdFactura { get; set; }
        public int? CatTipoDeBienesCatTipoDeBienId { get; set; }

        public virtual CatEstadoDelBien CatEstadoDelBien { get; set; }
        public virtual CatGarantia CatGarantia { get; set; }
        public virtual CatPiso CatPisos { get; set; }
        public virtual CatTipoDeBien CatTipoDeBienesCatTipoDeBien { get; set; }
        public virtual CatTipoEntrada CatTipoEntrada { get; set; }
        public virtual CatTipoPartida CatTipoPartida { get; set; }
        public virtual TblAreaServicio IdAreaServicio { get; set; }
        public virtual TblClaveCambs IdClaveCambs { get; set; }
        public virtual TblClaveSaica IdClaveSaica { get; set; }
        public virtual TblContratoBien IdContratoBien { get; set; }
        public virtual TblFacturas IdFacturasIdFacturaNavigation { get; set; }
        public virtual TblFederalizacion IdFederalizacion { get; set; }
        public virtual TblInventarios IdInventarios { get; set; }
        public virtual TblProveedor IdProveedor { get; set; }
        public virtual TblResguardatarios IdResguardatarios { get; set; }
        public virtual ICollection<TblSalidas> TblSalidas { get; set; }
    }
}
