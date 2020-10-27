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

        /// <summary>
        /// Te retorna la lista de Bienes de tipo sistema 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetSistemas() //esto se tienes que llamar en el controlador que le pertenece
        {
            try
            {
                List<TblBienesSistemas> lstSistemas = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().ToList();
                lstSistemas = resul;

                if(lstSistemas == null || lstSistemas.Count <=0 )
                    throw new System.Exception("No se encontraron resultados");
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

        /// <summary>
        /// Muestra una lista de los bienes por Federalizacion
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaFederalizacion() //esto se tienes que llamar en el controlador que le pertenece
        {
            try
            {
                List<TblBienesSistemas> ltsFederalizacionSistemas = null; 
                
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdFederalizacion).ToList();

                if (ltsFederalizacionSistemas == null || ltsFederalizacionSistemas.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsFederalizacionSistemas

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
        /// <summary>
        /// Consulta de bienes por clave cabms 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConcultaCabms()
        {
            try
            {
                List<TblBienesSistemas> ltsCabmsSitemas = null;

                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdClaveCabms).ToList();
                if (ltsCabmsSitemas == null || ltsCabmsSitemas.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsCabmsSitemas

                };

            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// Colsulta de bienes sistemas por inventario
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaInventario()
        {
            try
            {
                List<TblBienesSistemas> ltsInventarioSitemas = null;

                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdInventarios).ToList();
                if (ltsInventarioSitemas == null || ltsInventarioSitemas.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsInventarioSitemas

                };

            }
            catch (Exception)
            {

                throw;
            }

        }
        /// <summary>
        /// Consulta de bienes sistemas por proveedor
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsulataProveedor()
        {
            try
            {
                List<TblBienesSistemas> ltsProveedorSistemas = null;

                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdProveedor).ToList();
                if (ltsProveedorSistemas == null || ltsProveedorSistemas.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsProveedorSistemas

                };

            }
            catch (Exception)
            {

                throw;
            }
        }


            /// <summary>
            /// Te retorna las facturas por tipo de bien 
            /// </summary>
            /// <param name="idBienSistema"></param>
            /// <returns></returns>
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
