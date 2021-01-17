using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Services
{
  public interface IEntityBase
    {
        long Id { get; set; }
        bool Visible { get; set; }
        DateTime InsertDate { get; set; }
        int InsertUserId { get; set; }
        DateTime? UpdateDate { get; set; }
        int? UpdateUserId { get; set; }
        bool IsNew { get; }

    }
}
