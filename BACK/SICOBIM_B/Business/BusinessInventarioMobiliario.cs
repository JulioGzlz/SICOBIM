using SICOBIM_B.Common;
using SICOBIM_B.Entities;
using SICOBIM_B.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Business
{
    public class BusinessInventarioMobiliario
    {
        IInventarioService _InventarioServiceMobiliario;


        public BusinessInventarioMobiliario(IInventarioService objInventarioMobiliario)
        {
            _InventarioServiceMobiliario = objInventarioMobiliario;

        }

        public RespuestaApi<TblBienes> GetTblBienes()
        {
            try
            {
                IEnumerable<TblBienes> lstBienes = _InventarioServiceMobiliario.GetTblBienes();
                return new RespuestaApi<TblBienes>
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienes

                };
            }

            catch (Exception ex)
            {

                return new RespuestaApi<TblBienes>()
                {
                    Mensaje = ex.Message
                };
            }
        }










    }
}
