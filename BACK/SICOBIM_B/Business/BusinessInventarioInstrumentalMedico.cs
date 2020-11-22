using SICOBIM_B.Common;

using SICOBIM_B.Entities;
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
                //lstInstrumental = resul;
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
        /// Consulta de bienes por clave cabms 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblInstrumentalMedico> GetConcultaCabms()
        {
            try
            {
                List<TblInstrumentalMedico> ltsCabmsInstrumental = null;

                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.IdClaveCambsid).ToList();
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

                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.IdInventariosid).ToList();
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
        public RespuestaApi<TblInstrumentalMedico> GetTblBienesPorFactura()
        {
            try
            {
                List<TblInstrumentalMedico> lstBienesFactura = null;
                var resul = _inventarioServiceInstrumentalMedico.GetTblInstrumentalMedico().OrderBy(x => x.IdFacturasIdFactura).ToList();
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
        public RespuestaApi<TblFacturas> GetFacturasTipoInventario(int idBien)
        {

            try
            {
                List<TblFacturas> lstFacturasporInventario = null; var resul = _objsicobimContext.TblFacturas.Where(x => x.CatTipoDeBienId == idBien).ToList();
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

        #endregion
    }



}

