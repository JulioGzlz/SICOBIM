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
        IInventarioService _InventarioService;


        public BusinessInventarioMobiliario(IInventarioService objInventarioMobiliario)
        {
            _InventarioService = objInventarioMobiliario;

        }

        public RepuestaApi<TblBienes> GetTblBienes()
        {
            try
            {
                IEnumerable<TblBienes> lstBienes = _InventarioService.GetTblBienes();
                return new RepuestaApi<TblBienes>
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienes

                };
            }

            catch (Exception ex)
            {

                return new RepuestaApi<TblBienes>()
                {
                    Mensaje = ex.Message
                };
            }
        }










    }
}
