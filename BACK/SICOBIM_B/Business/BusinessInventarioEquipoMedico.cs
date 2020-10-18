using SICOBIM_B.Common;
using SICOBIM_B.Data;
using SICOBIM_B.Entities;
using SICOBIM_B.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Business
{
    public class BusinessInventarioEquipoMedico
    {
        private ApplicationDbContext _objApplicationDbContext;
        IInventarioService _inventarioService;

        public BusinessInventarioEquipoMedico(IInventarioService objEquipoMedico, ApplicationDbContext applicationDbContext)
        {
            _inventarioService = objEquipoMedico;
            _objApplicationDbContext = applicationDbContext;

        }

        public RespuestaApi<TblBienesEquMedico> GetEquipoMedico() //esto se tienes que llamar en el controlador que le pertenece
        {
            try
            {
                List<TblBienesEquMedico> lstEquipoMedico = _inventarioService.GetTblBienesEquMedicos().ToList();
                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstEquipoMedico

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblBienesEquMedico> { Mensaje = ex.Message };
            }




        }










    }
}
