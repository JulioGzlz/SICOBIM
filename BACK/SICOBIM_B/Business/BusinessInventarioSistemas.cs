using SICOBIM_B.Common;

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
        private sicobimContext _objsicobimContext;
        IInventarioService _inventarioServiceSistemas;


        public BusinessInventarioSistemas(IInventarioService objSistemas, sicobimContext sicobimContext)
        {
            _inventarioServiceSistemas = objSistemas;
            _objsicobimContext = sicobimContext;

        }

        /// <summary>
        /// Te retorna la lista de Bienes de tipo sistema 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetSistemas()
        {
            try
            {
                List<TblBienesSistemas> lstSistemas = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().ToList();
                lstSistemas = resul;

                if (lstSistemas == null || lstSistemas.Count <= 0)
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
        public RespuestaApi<TblBienesSistemas> GetConsultaFederalizacion() 
        {
            try
            {
                List<TblBienesSistemas> ltsFederalizacionSistemas = null;

                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdFederalizacionid).ToList();
               ltsFederalizacionSistemas = resul;

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

                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdClaveCabmsid).ToList();
                ltsCabmsSitemas = resul;
                if (ltsCabmsSitemas == null || ltsCabmsSitemas.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsCabmsSitemas

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
        /// Colsulta de bienes sistemas por inventario
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaInventario()
        {
            try
            {
                List<TblBienesSistemas> ltsInventarioSitemas = null;

                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdInventariosid).ToList();
                ltsInventarioSitemas = resul;
                if (ltsInventarioSitemas == null || ltsInventarioSitemas.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsInventarioSitemas

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
        /// Consulta de bienes sistemas por proveedor
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsulataProveedor()
        {
            try
            {
                List<TblBienesSistemas> ltsProveedorSistemas = null;

                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdProveedorid).ToList();
                if (ltsProveedorSistemas == null || ltsProveedorSistemas.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsProveedorSistemas

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
        /// Consulta de bienes sistemas por factura
        /// </summary>
        /// <param name="factura"></param>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetTblBienesPorFactura()
        {
            try
            {
                List<TblBienesSistemas> lstBienesFactura = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdFacturasIdFactura).ToList();
                lstBienesFactura = resul;


                if (lstBienesFactura == null || lstBienesFactura.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesFactura
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por clave saica
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaClaveSaica()
        {
            try
            {
                List<TblBienesSistemas> lstBienesClaveSaica = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdClaveSaicaid).ToList();
                lstBienesClaveSaica = resul;


                if (lstBienesClaveSaica == null || lstBienesClaveSaica.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesClaveSaica
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }




        /// <summary>
        /// Te retorna las facturas por tipo de bien sistemas 
        /// </summary>
        /// <param name="idBienSistema"></param>
        /// <returns></returns>
        public RespuestaApi<TblFacturas> GetFacturasTipoInventario(int idBien)
        {
       
            try
            {
                List<TblFacturas>  lstFacturasporInventario= null; var resul = _objsicobimContext.TblFacturas.Where(x => x.CatTipoDeBienId == idBien).ToList();
                lstFacturasporInventario = resul;
                if (lstFacturasporInventario == null  || lstFacturasporInventario.Count <= 0)
                    throw new System.Exception("No existen registros con el Bien Sistema insertado, favor de verificar");
                return new RespuestaApi<TblFacturas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstFacturasporInventario

                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblFacturas>()
                {
                    Mensaje = ex.Message
                };
            }

        }
        /// <summary>
        /// Consulta de bienes sistemas por contrato
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaContrato()
        {
            try
            {
                List<TblBienesSistemas> lstBienesContrato = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdContratoBienid).ToList();
                lstBienesContrato = resul;


                if (lstBienesContrato == null || lstBienesContrato.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesContrato
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta de bienes sistemas por resguardatario
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultarResguardatario()
        {
            try
            {
                List<TblBienesSistemas> lstBienesPorResguardatario = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdResguardatariosid).ToList();
                lstBienesPorResguardatario = resul;


                if (lstBienesPorResguardatario == null || lstBienesPorResguardatario.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesPorResguardatario
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por estado fisico del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaEstadoFisicoBien()
        {
            try
            {
                List<TblBienesSistemas> lstestadofisico = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.CatEstadoDelBienid).ToList();
                lstestadofisico = resul;


                if (lstestadofisico == null || lstestadofisico.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstestadofisico
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por garantia del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaporGarantia()
        {
            try
            {
                List<TblBienesSistemas> lstbiengarantia = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.CatGarantiaid).ToList();
                lstbiengarantia = resul;


                if (lstbiengarantia == null || lstbiengarantia.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbiengarantia
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por piso del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaPorPiso()
        {
            try
            {
                List<TblBienesSistemas> lstbienporpiso = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.CatPisosid).ToList();
                lstbienporpiso = resul;


                if (lstbienporpiso == null || lstbienporpiso.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporpiso
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por tipo de entrada del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaporTipodeEntrada()
        {
            try
            {
                List<TblBienesSistemas> lstbienpoentrada = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.CatTipoEntradaid).ToList();
                lstbienpoentrada = resul;


                if (lstbienpoentrada == null || lstbienpoentrada.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienpoentrada
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }


    }
}
