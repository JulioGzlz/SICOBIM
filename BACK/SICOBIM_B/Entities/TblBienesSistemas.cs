using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblBienesSistemas")]
    public class TblBienesSistemas
    {
        public int id { get; set; }


        public TblFederalizacion IdFederalizacion
        {
            get;
            set;
        }

        public TblInventarios IdInventarios
        {
            get;
            set;
        }


        public string marca { get; set; }
        public string modelo { get; set; }
        public string serie { get; set; }
        public int cantidad { get; set; }

        public TblContratoBien IdContratoBien
        {
            get;
            set;
        }

       
        public TblProveedor IdProveedor
        {
            get;
            set;
        }


        public TblFacturas IdFacturas
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

        public TblClaveCabms IdClaveCabms
        {
            get;
            set;
        }



        public TblClaveSaica IdClaveSaica
        {
            get;
            set;
        }


        public CatTipoEntrada catTipoEntrada
        {
            get;
            set;
        }
        

        public TblAreaServicio IdAreaServicio
        {
            get;
            set;
        }

        public CatPisos catPisos

        {
            get;
            set;
        }

        public TblResguardatarios IdResguardatarios
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



  

    }
}
