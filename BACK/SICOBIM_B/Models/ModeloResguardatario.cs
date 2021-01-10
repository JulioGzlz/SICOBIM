using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Models
{
    public class ModeloResguardatario
    {
        public string Nombre { get; set; }
        public string ApellidoUno { get; set; }
        public string ApellidoDos { get; set; }
        public int Catareaid { get; set; }
        public int CatServicioid { get; set; }
        public int CatTurnoid { get; set; }
        public int CatEstatusid { get; set; }
        public int CatTipoContratoid { get; set; }
        public int IdUsuarioAlta { get; set; }
        public string RFC { get; set; }
        public string Cargo { get; set; }
        public int CatSexoid { get; set; }
        public string Numeroempleado { get; set; }
        public string Plaza { get; set; }


    }
}
