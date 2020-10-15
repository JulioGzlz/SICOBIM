using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Entities
{
    [Table("TblResguardatarios")]
    public class TblResguardatarios
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidoUno { get; set; }
        public string apellidoDos { get; set; }
        public string RFC { get; set; }
        public string plaza { get; set; }
        public string numeroempleado { get; set; }
        public string cargo { get; set; }
        public int idSexo { get; set; }
        public CatSexo catSexo
        {
            set;
            get;
        }
        public int idServicio { get; set; }
        public CatServicio CatServicio
        {
            set;
            get;
        }
        public int idTurno { get; set; }
        public CatTurno catTurno
        {
            set;
            get;
        }
        public int idEstatus { get; set; }
        public CatEstatus catEstatus
        {
            set;
            get;
        }
        public int idTipoContrato { get; set; }
        public CatTipoContrato catTipoContrato
        {
            set;
            get;
        }
        public int idUsuarioAlta { get; set; }
        public DateTime fechaAlta { get; set; }
        public int usuarioMod { get; set; }
        public DateTime fechaMod { get; set; }
        public bool activo { get; set; }


        public ICollection<TblBienes> tblBienes
        {
            get;
            set;
        }
        public ICollection<TblBienesEquMedico> tblBienesEquMedico
        {
            get;
            set;
        }
        public ICollection<TblBienesSistemas> tblBienesSistemas
        {
            get;
            set;
        }
        public ICollection<TblInstrumentalMedico> tblInstrumentalMedico
        {
            get;
            set;
        }



    }
}
