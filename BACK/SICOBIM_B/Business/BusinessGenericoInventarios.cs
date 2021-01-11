using SICOBIM_B.Common;
using SICOBIM_B.Entities;
using SICOBIM_B.Helpers;
using SICOBIM_B.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Business
{
    public class BusinessGenericoInventarios
    {
        private sicobimContext _objsicobimContext;
        IInventarioService _InventarioServiceGenerico;


        public BusinessGenericoInventarios(IInventarioService InventarioServiceGenerico, sicobimContext sicobimContext)
        {
            _InventarioServiceGenerico = InventarioServiceGenerico;
            _objsicobimContext = sicobimContext;

        }

        public bool GetExistenciaInventarios(string numeroinventario)
        {
            try
            {
                if (_objsicobimContext.TblInventarios.Any(x => x.NumeroInventario == numeroinventario))
                    throw new AppException("El numero de Inventario \"" + numeroinventario + "\" ya éxiste");

            }
            catch (Exception)
            {

                throw;
            }

            //if (_context.CtrlUsuarios.Any(x => x.Username == user.Username))
            //    throw new AppException("Username \"" + user.Username + "\" is already taken");

            return false;



        }


        //public RespuestaApi<TblInventarios> GetNumerosDeInventariosTipoInventario(int IdBien)
        //{

        //    try
        //    {
        //       TblInventarios lstInventariosportipodemobiliario = null;
             


        //        return new RespuestaApi<TblInventarios>()
        //        {
        //            correcto = true,
        //            ObjetoRespuesta = lstInventariosportipodemobiliario

        //        };
        //    }
        //    catch (Exception ex)
        //    {
        //        return new RespuestaApi<TblInventarios>()
        //        {
        //            Mensaje = ex.Message
        //        };
        //    }

        //}

    }
}
