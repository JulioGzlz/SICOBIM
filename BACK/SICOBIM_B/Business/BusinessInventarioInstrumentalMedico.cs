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
    public class BusinessInventarioInstrumentalMedico
    {
        private ApplicationDbContext _objApplicationDbContext;
        IInventarioService _inventarioService;


        public BusinessInventarioInstrumentalMedico(IInventarioService objInstrumental, ApplicationDbContext applicationDbContext)
        {
            _inventarioService = objInstrumental;
            _objApplicationDbContext = applicationDbContext;

        }

        public RespuestaApi<TblInstrumentalMedico> GetInstrumental() //esto se tienes que llamar en el controlador que le pertenece
        {
            try
            {
                List<TblInstrumentalMedico> lstInstrumental = _inventarioService.GetTblInstrumentalMedico().ToList();
                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstInstrumental

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblInstrumentalMedico> { Mensaje = ex.Message };
            }




        }
     





        }
}
