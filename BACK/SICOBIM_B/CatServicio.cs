using System;
using System.Collections.Generic;

namespace SICOBIM_B
{
    public partial class CatServicio
    {
        public CatServicio()
        {
            TblAreaServicio = new HashSet<TblAreaServicio>();
            TblResguardatarios = new HashSet<TblResguardatarios>();
        }

        public int Id { get; set; }
        public string Servicio { get; set; }
        public int UsuarioAlta { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaMod { get; set; }
        public bool Activo { get; set; }
        public string Descripcion { get; set; }
        public int IdusuarioMod { get; set; }

        public virtual ICollection<TblAreaServicio> TblAreaServicio { get; set; }
        public virtual ICollection<TblResguardatarios> TblResguardatarios { get; set; }
    }
}
