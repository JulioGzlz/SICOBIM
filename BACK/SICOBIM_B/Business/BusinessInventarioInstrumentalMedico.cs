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
    public class BusinessInventarioInstrumentalMedico
    {
        #region Metodos de consultas de listas

        private sicobimContext _objsicobimContext;
        IInventarioService _inventarioServiceInstrumentalMedico;


        public BusinessInventarioInstrumentalMedico(IInventarioService objInstrumental, sicobimContext sicobimContext)
        {
            _inventarioServiceInstrumentalMedico = objInstrumental;
            _objsicobimContext = sicobimContext;

        }
        /// <summary>
        /// consulta por medio de una lista el intrumental médico 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetInstrumental()
        {
            try
            {
                List<TblInstrumentalMedico> lstInstrumental = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().ToList();
                if (lstInstrumental == null || lstInstrumental.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");
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
        /// <summary>
        /// consulta de instrumental medico por federalización
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsultaFederalizacion()
        {
            try
            {
                List<TblInstrumentalMedico> lstEquipoMedicoFederalizacion = null; 
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.IdFederalizacionid).ToList();

                lstEquipoMedicoFederalizacion = resul;
                if (lstEquipoMedicoFederalizacion == null || lstEquipoMedicoFederalizacion.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");
                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstEquipoMedicoFederalizacion

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblInstrumentalMedico>()
                {
                     Mensaje = ex.Message 
                };
            }
        }
        /// <summary>
        /// Consulta de Instrumental medico por clave cabms 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConcultaCabms()
        {
            try
            {
                List<TblInstrumentalMedico> ltsCabmsInstrumental = null;

                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.IdClaveCabmsid).ToList();
                ltsCabmsInstrumental = resul;
                if (ltsCabmsInstrumental == null || ltsCabmsInstrumental.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsCabmsInstrumental

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    Mensaje = ex.Message
                };
            }

        }
        /// <summary>
        /// Colsulta de bienes sistemas por inventario
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsultaInventario()
        {
            try
            {
                List<TblInstrumentalMedico> ltsInventarioInstrumental = null;

                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.IdInventarioid).ToList();
                ltsInventarioInstrumental = resul;
                if (ltsInventarioInstrumental == null || ltsInventarioInstrumental.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsInventarioInstrumental

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    Mensaje = ex.Message
                };
            }

        }
        /// <summary>
        /// Consulta de bienes sistemas por proveedor
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsulataProveedor()
        {
            try
            {
                List<TblInstrumentalMedico> ltsProveedorInstrumental = null;

                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.IdProveedorid).ToList();
                if (ltsProveedorInstrumental == null || ltsProveedorInstrumental.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsProveedorInstrumental

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblInstrumentalMedico>()
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
        public RespuestaApi<TblInstrumentalMedico> GetFacturasEquipoMedico()
        {
            try
            {
                List<TblInstrumentalMedico> lstBienesFactura = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.IdFacturasid).ToList();
                lstBienesFactura = resul;


                if (lstBienesFactura == null || lstBienesFactura.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesFactura
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblInstrumentalMedico>
                { Mensaje = ex.Message };
            }
        }

        public RespuestaApi<TblFacturas> GetConsultaPorFactura(string numFactura, string year)
        {
            try
            {
                List<TblFacturas> lstBienesFactura = null;
                if (numFactura != null && year == null)
                {
                    var resul = _objsicobimContext.TblFacturas.Where(x => x.Factura == numFactura).ToList();
                    lstBienesFactura = resul;
                }   

                if (lstBienesFactura == null || lstBienesFactura.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblFacturas>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesFactura
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblFacturas>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por clave saica
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsultaClaveSaica()
        {
            try
            {
                List<TblInstrumentalMedico> lstBienesClaveSaica = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.IdClaveSaicaid).ToList();
                lstBienesClaveSaica = resul;


                if (lstBienesClaveSaica == null || lstBienesClaveSaica.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesClaveSaica
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblInstrumentalMedico>
                { Mensaje = ex.Message };
            }
        }
        public RespuestaApi<TblFacturas> GetFacturasTipoInventario(int idBieninstrumental) 
        {

            try
            {
                List<TblFacturas> lstFacturasporInventario = null; 
                var resul = _objsicobimContext.TblFacturas.Where(x => x.CatTipoDeBienId == idBieninstrumental).ToList();
                lstFacturasporInventario = resul;
                if (lstFacturasporInventario == null || lstFacturasporInventario.Count <= 0)
                    throw new System.Exception("No existen registros con el Bien insertado, favor de verificar");
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
        public RespuestaApi<TblInstrumentalMedico> GetConsultaContrato()
        {
            try
            {
                List<TblInstrumentalMedico> lstBienesContrato = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.IdContratoBienid).ToList();
                lstBienesContrato = resul;


                if (lstBienesContrato == null || lstBienesContrato.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesContrato
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblInstrumentalMedico>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes sistemas por resguardatario
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsultarResguardatario()
        {
            try
            {
                List<TblInstrumentalMedico> lstBienesPorResguardatario = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.IdResguardatariosid).ToList();
                lstBienesPorResguardatario = resul;


                if (lstBienesPorResguardatario == null || lstBienesPorResguardatario.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesPorResguardatario
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblInstrumentalMedico>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes Instrumental médico por estado fisico del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsultaEstadoFisicoBien()
        {
            try
            {
                List<TblInstrumentalMedico> lstestadofisico = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.CatEstadoDelBienid).ToList();
                lstestadofisico = resul;


                if (lstestadofisico == null || lstestadofisico.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstestadofisico
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblInstrumentalMedico>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes instrumental médico por garantia del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsultaporGarantia()
        {
            try
            {
                List<TblInstrumentalMedico> lstbiengarantia = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.CatGarantiaid).ToList();
                lstbiengarantia = resul;


                if (lstbiengarantia == null || lstbiengarantia.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbiengarantia
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblInstrumentalMedico>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes Instrumental médico por piso del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsultaPorPiso()
        {
            try
            {
                List<TblInstrumentalMedico> lstbienporpiso = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.CatPisosid).ToList();
                lstbienporpiso = resul;


                if (lstbienporpiso == null || lstbienporpiso.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporpiso
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblInstrumentalMedico>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes Instrumental médico por tipo de entrada del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsultaporTipodeEntrada()
        {
            try
            {
                List<TblInstrumentalMedico> lstbienporentrada = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.CatTipoEntradaid).ToList();
                lstbienporentrada = resul;


                if (lstbienporentrada == null || lstbienporentrada.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporentrada
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblInstrumentalMedico>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes Instrumental médico por tipo de partida presupuestas del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsultaporTipodePartida()
        {
            try
            {
                List<TblInstrumentalMedico> lstbienporpartida = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.CatTipoPartidaid).ToList();
                lstbienporpartida = resul;


                if (lstbienporpartida == null || lstbienporpartida.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporpartida
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblInstrumentalMedico>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes Instrumental médico por servicio del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsultaporservicio()
        {
            try
            {
                List<TblInstrumentalMedico> lstbienporservicio = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.Catservicioid
                ).ToList();
                lstbienporservicio = resul;


                if (lstbienporservicio == null || lstbienporservicio.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporservicio
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblInstrumentalMedico>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de Instrumental medico por arae 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsultaporArea()
        {
            try
            {
                List<TblInstrumentalMedico> lstbienporarea = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.Catareaid
                ).ToList();
                lstbienporarea = resul;


                if (lstbienporarea == null || lstbienporarea.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporarea
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblInstrumentalMedico>
                { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// Consulta de bienes Instrumental Medico por costo unitario ""individual"
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConsultaPorPrecioUnitario()
        {
            try
            {
                List<TblInstrumentalMedico> lstbienporcosto = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.Costounitario
                ).ToList();
                lstbienporcosto = resul;


                if (lstbienporcosto == null || lstbienporcosto.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblInstrumentalMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporcosto
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblInstrumentalMedico>
                { Mensaje = ex.Message };
            }
        }
        #endregion
        #region Metodos para guardar

        public TblFacturas GuardarFacturaInventarioEquipoMedico(TblFacturas tblFacturas)
        {

            return _inventarioServiceInstrumentalMedico.GuardarTblFacturas(tblFacturas);

        }
        public TblInstrumentalMedico GuardarTblInstrumentalMedico(TblInstrumentalMedico tblInstrumentalMedico)
        {

            return _inventarioServiceInstrumentalMedico.GuardarTblInstrumentalMedico(tblInstrumentalMedico);

        }
        public TblClaveSaica GuardarTblClaveSaica(TblClaveSaica tblClaveSaica)
        {

            return _inventarioServiceInstrumentalMedico.GuardarTblClaveSaica(tblClaveSaica);

        }
        public TblContratoBien GuardarTblContratoBien(TblContratoBien tblContratoBien)
        {

            return _inventarioServiceInstrumentalMedico.GuardarTblContratoBien(tblContratoBien);

        }
        public RespuestaApi<TblFederalizacion> GuardarTblFederalizacion(TblFederalizacion tblFederalizacion)
        {
            TblFederalizacion objfederalizacion = new TblFederalizacion();
            try
            {
                if (_objsicobimContext.TblFederalizacion.Any(x => x.Federalizacion == tblFederalizacion.Federalizacion))
                    throw new AppException("Error, el numero de federalización ya existe");

                objfederalizacion = _inventarioServiceInstrumentalMedico.GuardarTblFederalizacion(tblFederalizacion);

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

                objtblInventarios = _inventarioServiceInstrumentalMedico.GuardarTblInventarios(tblInventarios);

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

            return _inventarioServiceInstrumentalMedico.GuardarTblProveedor(tblProveedor);

        }
        public TblClaveCabms GuardarTblClaveCabms(TblClaveCabms tblClaveCabms)
        {

            return _inventarioServiceInstrumentalMedico.GuardarTblClaveCabms(tblClaveCabms);

        }




        #endregion
    }



}

