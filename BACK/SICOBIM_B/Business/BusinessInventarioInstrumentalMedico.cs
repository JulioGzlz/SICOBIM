using SICOBIM_B.Common;

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
        private sicobimContext _objsicobimContext;
        IInventarioService _inventarioServiceInstrumentalMedico;


        public BusinessInventarioInstrumentalMedico(IInventarioService objInstrumental, sicobimContext sicobimContext)
        {
            _inventarioServiceInstrumentalMedico = objInstrumental;
            _objsicobimContext = sicobimContext;

        }

        public RespuestaApi<TblInstrumentalMedico> GetInstrumental() //esto se tienes que llamar en el controlador que le pertenece
        {
            try
            {
                List<TblInstrumentalMedico> lstInstrumental = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().ToList();
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
