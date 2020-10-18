using SICOBIM_B.Common;
using SICOBIM_B.Entities;
using SICOBIM_B.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Business
{
	public class BusinessPerfiles
	{

		ICatalogoPerfilesService _catalogoPerfilesService;


		public BusinessPerfiles(ICatalogoPerfilesService objIcatalogos)
		{
			_catalogoPerfilesService = objIcatalogos;

		}

        public RepuestaApi<CatEstatus> GetEstatus()
        {
            try
            {
                IEnumerable<CatEstatus> lstEstatus = _catalogoPerfilesService.GetCatEstatus();
                return new RepuestaApi<CatEstatus>
                {
                    correcto = true,
                    ObjetoRespuesta = lstEstatus

                };
            }

            catch (Exception ex)
            {

                return new RepuestaApi<CatEstatus>()
                {
                    Mensaje = ex.Message
                };
            }
        }
    }
}
