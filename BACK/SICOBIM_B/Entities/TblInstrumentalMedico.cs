using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{

    [Table("TblInstrumentalMedico")]
    public class TblInstrumentalMedico
    {
        public int id { get; set; }

        public TblFederalizacion tblFederalizacion
        {
            get;
            set;
        }

        public TblInventarios tblInventarios
        {
            get;
            set;
        }


        public string marca { get; set; }
        public string modelo { get; set; }
        public string serie { get; set; }
        public int cantidad { get; set; }

        public TblContratoBien tblContratoBien
        {
            get;
            set;
        }


        public TblProveedor tblProveedor
        {
            get;
            set;
        }


        public TblFacturas tblFacturas
        {
            get;
            set;
        }

        public CatGarantia catGarantia
        {
            get;
            set;
        }

        public CatTipoPartida catTipoPartida
        {
            get;
            set;
        }

        public TblClaveCambs tblClaveCambs
        {
            get;
            set;
        }



        public TblClaveSaica tblClaveSaica
        {
            get;
            set;
        }


        public CatTipoEntrada catTipoEntrada
        {
            get;
            set;
        }


        public TblAreaServicio tblAreaServicio
        {
            get;
            set;
        }

        public CatPisos catPisos

        {
            get;
            set;
        }

        public TblResguardatarios tblResguardatarios
        {
            get;
            set;
        }
        //FK

        public CatTipoDeBien catTipoDeBienes
        {
            get;
            set;
        }
        //FK

        public CatEstadoDelBien catEstadoDelBien
        {
            get;
            set;
        }

        public String observaciones { get; set; }




        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }

        public ICollection<TblSalidaBien> tblSalidaBien
        {
            get;
            set;
        }
        public ICollection<TblFacturas> TblFacturas
        {
            get;
            set;
        }
        public ICollection<TblProveedor> TblProveedor
        {
            get;
            set;
        }
    }
}
