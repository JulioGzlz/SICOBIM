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
    public class BusinessInventarioSistemas
    {
  
        private sicobimContext _objsicobimContext;
        IInventarioService _inventarioServiceSistemas;


        public BusinessInventarioSistemas(IInventarioService objSistemas, sicobimContext sicobimContext)
        {
            _inventarioServiceSistemas = objSistemas;
            _objsicobimContext = sicobimContext;

        }
        #region  Metodos de consultas de listas
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
                List<TblBienesSistemas> ltsCabmsSistemas = null;

                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdClaveCabmsid).ToList();
                ltsCabmsSistemas = resul;
                if (ltsCabmsSistemas == null || ltsCabmsSistemas.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsCabmsSistemas

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

                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdInventarioid).ToList();
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
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.IdFacturasid).ToList();
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
        public RespuestaApi<TblFacturas> GetFacturasTipoInventario(int idBienSistema)
        {
       
            try
            {
                List<TblFacturas>  lstFacturasporInventario= null; var resul = _objsicobimContext.TblFacturas.Where(x => x.CatTipoDeBienId == idBienSistema).ToList();
                lstFacturasporInventario = resul;
                if (lstFacturasporInventario == null  || lstFacturasporInventario.Count <= 0)
                    throw new System.Exception("No existen registros con el Bien sistema insertado, favor de verificar");
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
                List<TblBienesSistemas> lstbienporentrada = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.CatTipoEntradaid).ToList();
                lstbienporentrada = resul;


                if (lstbienporentrada == null || lstbienporentrada.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporentrada
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por tipo de partida presupuestas del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaporTipodePartida()
        {
            try
            {
                List<TblBienesSistemas> lstbienporpartida = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.CatTipoPartidaid).ToList();
                lstbienporpartida = resul;


                if (lstbienporpartida == null || lstbienporpartida.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporpartida
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por area y su servicio del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaporservicio()
        {
            try
            {
                List<TblBienesSistemas> lstbienporservicio = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.Catservicioid
                ).ToList();
                lstbienporservicio = resul;


                if (lstbienporservicio == null || lstbienporservicio.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporservicio
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta del bien sistemas medico por area 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaporArea()
        {
            try
            {
                List<TblBienesSistemas> lstbienporarea = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.Catareaid
                ).ToList();
                lstbienporarea = resul;


                if (lstbienporarea == null || lstbienporarea.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporarea
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes Equipo Medico por costo unitario ""individual"
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesSistemas> GetConsultaPorPrecioUnitario()
        {
            try
            {
                List<TblBienesSistemas> lstbienporcosto = null;
                var resul = _inventarioServiceSistemas.GetTblBienesSistemas().OrderBy(x => x.Costounitario
                ).ToList();
                lstbienporcosto = resul;


                if (lstbienporcosto == null || lstbienporcosto.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesSistemas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporcosto
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesSistemas>
                { Mensaje = ex.Message };
            }
        }
        #endregion

        #region Metodos para guardar

        public TblFacturas GuardarFacturaInventariSistemas(TblFacturas tblFacturas)
        {

            return _inventarioServiceSistemas.GuardarTblFacturas(tblFacturas);

        }
        public TblBienesSistemas GuardarTblSistemas(TblBienesSistemas tblBienesSistemas)
        {

            return _inventarioServiceSistemas.GuardarTblBienesSistemas(tblBienesSistemas);

        }
        public TblClaveSaica GuardarTblClaveSaica(TblClaveSaica tblClaveSaica)
        {

            return _inventarioServiceSistemas.GuardarTblClaveSaica(tblClaveSaica);

        }
        public TblContratoBien GuardarTblContratoBien(TblContratoBien tblContratoBien)
        {

            return _inventarioServiceSistemas.GuardarTblContratoBien(tblContratoBien);

        }
        public RespuestaApi<TblFederalizacion> GuardarTblFederalizacion(TblFederalizacion tblFederalizacion)
        {
            TblFederalizacion objfederalizacion = new TblFederalizacion();
            try
            {
                if (_objsicobimContext.TblFederalizacion.Any(x => x.Federalizacion == tblFederalizacion.Federalizacion))
                    throw new AppException("Error, el numero de federalización ya existe");

                objfederalizacion = _inventarioServiceSistemas.GuardarTblFederalizacion(tblFederalizacion);

                return new RespuestaApi<TblFederalizacion>()
                {
                    Mensaje = "Registro guardado correctamente",
                    correcto = true,
                    objGenerics = objfederalizacion
                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblFederalizacion>()
                {
                    Mensaje = ex.Message,
                    correcto = false,
                    objGenerics = objfederalizacion
                };
            }
        }
        /// <summary>
        /// Guarda y valida que no se duplique el numero de inventario en la BD
        /// </summary>
        /// <param name="tblInventarios"></param>
        /// <returns>Obj de tipo tblIventarios, para obtener el Id de su llave primaria</returns>
        public RespuestaApi<TblInventarios> GuardarTblInventarios(TblInventarios tblInventarios)
        {
            TblInventarios objtblInventarios = new TblInventarios();
            try
            {
                if (_objsicobimContext.TblInventarios.Any(x => x.NumeroInventario == tblInventarios.NumeroInventario))
                    throw new AppException("Error, el numero de inventario ya existe");

                objtblInventarios = _inventarioServiceSistemas.GuardarTblInventarios(tblInventarios);

                return new RespuestaApi<TblInventarios>()
                {
                    Mensaje = "Registro guardado correctamente",
                    correcto = true,
                    objGenerics = objtblInventarios
                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblInventarios>()
                {
                    Mensaje = ex.Message,
                    correcto = false,
                    objGenerics = objtblInventarios
                };
            }
        }
        public TblProveedor GuardarTblProveedor(TblProveedor tblProveedor)
        {

            return _inventarioServiceSistemas.GuardarTblProveedor(tblProveedor);

        }
        public TblClaveCabms GuardarTblClaveCabms(TblClaveCabms tblClaveCabms)
        {

            return _inventarioServiceSistemas.GuardarTblClaveCabms(tblClaveCabms);

        }




        #endregion
    }
}
