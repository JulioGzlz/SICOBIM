using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Services
{
  public interface IEntityBase
    {
        int Id { get; set; }
        bool Activo { get; set; }
        DateTime FechaAlta { get; set; }
        int IdUsuarioAlta { get; set; }
        DateTime? FechaMod { get; set; }
        int? UsuarioMod { get; set; }

    }
}
