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
    #region  Metodos de consultas de listas
    public class BusinessInventarioMobiliario
    {
        private sicobimContext _objsicobimContext;
        IInventarioService _InventarioServiceMobiliario;


        public BusinessInventarioMobiliario(IInventarioService objInventarioMobiliario, sicobimContext sicobimContext)
        {
            _InventarioServiceMobiliario = objInventarioMobiliario;
            _objsicobimContext = sicobimContext;

        }
        /// <summary>
        /// consulta por medio de una lista los mobiliario administrativo
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetTblBienes()
        {
            try
            {
                List<TblBienesMuebles> lstBienes = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().ToList();
                lstBienes = resul;

                if (lstBienes == null || lstBienes.Count <=0) throw new System.Exception("No se encontraron resultados"); 
                return new RespuestaApi<TblBienesMuebles>
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienes

                };
            }

            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>()
                {
                    Mensaje = ex.Message
                };
            }
        }

        /// <summary>
        /// consulta de equipo medico por federalizacion 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsultaFederalizacion()
        {
            try
            {
                List<TblBienesMuebles> lstFederalizacionmobiliario = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.IdFederalizacionid).ToList();
                lstFederalizacionmobiliario = resul;
                if (lstFederalizacionmobiliario == null || lstFederalizacionmobiliario.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblBienesMuebles>
                {
                    correcto = true,
                    ObjetoRespuesta = lstFederalizacionmobiliario

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblBienesMuebles>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// Consulta de bienes por clave cabms 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConcultaCabms()
        {
            try
            {
                List<TblBienesMuebles> ltsCabmsmobiliario = null;

                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.IdClaveCabmsid).ToList();
                ltsCabmsmobiliario = resul;
                if (ltsCabmsmobiliario == null || ltsCabmsmobiliario.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsCabmsmobiliario

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblBienesMuebles>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// Colsulta de bienes sistemas por inventario
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsultaInventario()
        {
            try
            {
                List<TblBienesMuebles> ltsInventariomobiliario = null;

                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.IdInventarioid).ToList();
                ltsInventariomobiliario = resul;
                if (ltsInventariomobiliario == null || ltsInventariomobiliario.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsInventariomobiliario

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblBienesMuebles>()
                {
                    Mensaje = ex.Message
                };
            }

        }
        /// <summary>
        /// Consulta de bienes equipo médico por proveedor
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsulataProveedor()
        {
            try
            {
                List<TblBienesMuebles> ltsProveedormobiliario = null;

                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.IdProveedorid).ToList();
                if (ltsProveedormobiliario == null || ltsProveedormobiliario.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsProveedormobiliario

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblBienesMuebles>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// Consulta de bienes equipo médico por factura
        /// </summary>
        /// <param name="factura"></param>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConcultaPorFactura()
        {
            try
            {
                List<TblBienesMuebles> lstBienesFactura = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.IdFacturasid).ToList();
                lstBienesFactura = resul;


                if (lstBienesFactura == null || lstBienesFactura.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesFactura
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes equipo médico por clave saica
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsultaClaveSaica()
        {
            try
            {
                List<TblBienesMuebles> lstBienesClaveSaica = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.IdClaveSaicaid).ToList();
                lstBienesClaveSaica = resul;


                if (lstBienesClaveSaica == null || lstBienesClaveSaica.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesClaveSaica
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Te retorna las facturas por tipo de bien equipo mèdico 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblFacturas> GetFacturasTipoInventario(int idBienMobiliario)
        {

            try
            {
                List<TblFacturas> lstFacturasporInventario = null;
                var resul = _objsicobimContext.TblFacturas.Where(x => x.CatTipoDeBienId == idBienMobiliario).ToList();
                lstFacturasporInventario = resul;
                if (lstFacturasporInventario == null || lstFacturasporInventario.Count <= 0)
                    throw new System.Exception("No existen registros con el bien mueble insertado, favor de verificar");
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
        /// Consulta de bienes equipo médico por contrato
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsultaContrato()
        {
            try
            {
                List<TblBienesMuebles> lstBienesContrato = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.IdContratoBienid).ToList();
                lstBienesContrato = resul;


                if (lstBienesContrato == null || lstBienesContrato.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesContrato
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta de bienes equipo médico por resguardatario
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsultarResguardatario()
        {
            try
            {
                List<TblBienesMuebles> lstBienesPorResguardatario = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.IdResguardatariosid).ToList();
                lstBienesPorResguardatario = resul;


                if (lstBienesPorResguardatario == null || lstBienesPorResguardatario.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesPorResguardatario
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes equipo médico por estado fisico del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsultaEstadoFisicoBien()
        {
            try
            {
                List<TblBienesMuebles> lstestadofisico = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.CatEstadoDelBienid).ToList();
                lstestadofisico = resul;


                if (lstestadofisico == null || lstestadofisico.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstestadofisico
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes equipo médico por garantia del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsultaporGarantia()
        {
            try
            {
                List<TblBienesMuebles> lstbiengarantia = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.CatGarantiaid).ToList();
                lstbiengarantia = resul;


                if (lstbiengarantia == null || lstbiengarantia.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbiengarantia
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por piso del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsultaPorPiso()
        {
            try
            {
                List<TblBienesMuebles> lstbienporpiso = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.CatPisosid).ToList();
                lstbienporpiso = resul;


                if (lstbienporpiso == null || lstbienporpiso.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporpiso
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por tipo de entrada del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsultaporTipodeEntrada()
        {
            try
            {
                List<TblBienesMuebles> lstbienporentrada = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.CatTipoEntradaid).ToList();
                lstbienporentrada = resul;


                if (lstbienporentrada == null || lstbienporentrada.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporentrada
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por tipo de partida presupuestas del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsultaporTipodePartida()
        {
            try
            {
                List<TblBienesMuebles> lstbienporpartida = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.CatTipoPartidaid).ToList();
                lstbienporpartida = resul;


                if (lstbienporpartida == null || lstbienporpartida.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporpartida
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por area y su servicio del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsultaporservicio()
        {
            try
            {
                List<TblBienesMuebles> lstbienporservicio = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.Catservicioid
                ).ToList();
                lstbienporservicio = resul;


                if (lstbienporservicio == null || lstbienporservicio.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporservicio
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>
                { Mensaje = ex.Message };
            }
        }
        public RespuestaApi<TblBienesMuebles> GetConsultaporArea()
        {
            try
            {
                List<TblBienesMuebles> lstbienporarea = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.Catareaid
                ).ToList();
                lstbienporarea = resul;


                if (lstbienporarea == null || lstbienporarea.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporarea
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes Equipo Medico por costo unitario ""individual"
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesMuebles> GetConsultaPorPrecioUnitario()
        {
            try
            {
                List<TblBienesMuebles> lstbienporcosto = null;
                var resul = _InventarioServiceMobiliario.GetTblBienes().OrderBy(x => x.Costounitario
                ).ToList();
                lstbienporcosto = resul;


                if (lstbienporcosto == null || lstbienporcosto.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesMuebles>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporcosto
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesMuebles>
                { Mensaje = ex.Message };
            }
        }




        #endregion


        #region Metodos para guardar

        public TblFacturas GuardarFacturaInventarioMobiliario(TblFacturas tblFacturas)
        {

            return _InventarioServiceMobiliario.GuardarTblFacturas(tblFacturas);

        }
        public TblBienesMuebles GuardarTblBienesMuebles(TblBienesMuebles tblBienes)
        {

            return _InventarioServiceMobiliario.GuardarTblBienesMuebles(tblBienes);

        }
        public TblClaveSaica GuardarTblClaveSaica(TblClaveSaica tblClaveSaica)
        {

            return _InventarioServiceMobiliario.GuardarTblClaveSaica(tblClaveSaica);

        }
        public TblContratoBien GuardarTblContratoBien(TblContratoBien tblContratoBien)
        {

            return _InventarioServiceMobiliario.GuardarTblContratoBien(tblContratoBien);

        }
        public RespuestaApi<TblFederalizacion> GuardarTblFederalizacion(TblFederalizacion tblFederalizacion)
        {
            TblFederalizacion objfederalizacion = new TblFederalizacion();
            try
            {
                if (_objsicobimContext.TblFederalizacion.Any(x => x.Federalizacion == tblFederalizacion.Federalizacion))
                    throw new AppException("Error, el numero de federalización ya existe");

                objfederalizacion = _InventarioServiceMobiliario.GuardarTblFederalizacion(tblFederalizacion);

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

                objtblInventarios = _InventarioServiceMobiliario.GuardarTblInventarios(tblInventarios);

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

            return _InventarioServiceMobiliario.GuardarTblProveedor(tblProveedor);

        }
        public TblClaveCabms GuardarTblClaveCabms(TblClaveCabms tblClaveCabms)
        {

            return _InventarioServiceMobiliario.GuardarTblClaveCabms(tblClaveCabms);

        }




        #endregion










    }
}
