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
    public class BusinessInventarioSistemas
    {
        private ApplicationDbContext _objApplicationDbContext;
        IInventarioService _inventarioServiceSistemas;


        public BusinessInventarioSistemas(IInventarioService objSistemas, ApplicationDbContext applicationDbContext)
        {
            _inventarioServiceSistemas = objSistemas;
            _objApplicationDbContext = applicationDbContext;

        }


        public RespuestaApi<TblBienesSistemas> GetSistemas() //esto se tienes que llamar en el controlador que le pertenece
        {
            try
            {
                List<TblBienesSistemas> lstSistemas = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.id).ToList();
                return new RespuestaApi<TblBienesSistemas>
                {
                    correcto = true,
                    ObjetoRespuesta = lstSistemas

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblBienesSistemas>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        public List<TblFacturas> getFacturasTipoInventario(int idBienSistema)
        {
            List<TblFacturas> tblFacturastipoinventario = new List<TblFacturas>();
            try
            {
                tblFacturastipoinventario = _objApplicationDbContext.tblFacturas.Where(x => x.CatTipoDeBien.id == idBienSistema).ToList();

                if (tblFacturastipoinventario.Count <= 0 || tblFacturastipoinventario == null)
                    throw new System.Exception("No existen registros con el Bien Sistema insertado, favor de verificar");

            }
            catch (Exception ex)
            {
                string m = ex.Message;
            }
            return tblFacturastipoinventario;
        }

        public List<TblBienesSistemas> GetTblBienesPorFactura (string factura)
        {
            return _objApplicationDbContext.tblBienesSistemas.Where(x => x.IdFacturas.factura == factura).ToList();

        }







    }
}
