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
    public class BusinessInventarioEquipoMedico
    {


        private sicobimContext _objsicobimContext;
        IInventarioService _inventarioServiceEquipoMedico;

        #region  Metodos de consultas de listas


        public BusinessInventarioEquipoMedico(IInventarioService objEquipoMedico, sicobimContext sicobimContext)
        {
            _inventarioServiceEquipoMedico = objEquipoMedico;
            _objsicobimContext = sicobimContext;

        }
        /// <summary>
        /// consulta por medio de una lista los equipos médicos 
        /// </summary>
        /// <returns></returns> 
        public RespuestaApi<TblBienesEquMedico> GetEquipoMedico() 
        {
            try
            {
                List<TblBienesEquMedico> lstEquipoMedico = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().ToList();
                lstEquipoMedico = resul;

                if (lstEquipoMedico == null || lstEquipoMedico.Count <=0 )
                    throw new System.Exception("No se encontraron resultados");
              
                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstEquipoMedico

                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblBienesEquMedico> { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// consulta de equipo medico por federalizacion 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsultaFederalizacion() 
        {
            try
            {
                List<TblBienesEquMedico> lstEquipoMedicoFederalizacion = null; 
                var resul =_inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.IdFederalizacionid).ToList();
                lstEquipoMedicoFederalizacion = resul;
                if (lstEquipoMedicoFederalizacion == null || lstEquipoMedicoFederalizacion.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

        
                return new RespuestaApi<TblBienesEquMedico>
                {
                    correcto = true,
                    ObjetoRespuesta = lstEquipoMedicoFederalizacion

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblBienesEquMedico>()
                {
                    Mensaje = ex.Message
                };
            }
        }

        /// <summary>
        /// Consulta de bienes por clave cabms 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConcultaCabms()
        {
            try
            {
                List<TblBienesEquMedico> ltsCabmsequipmedico = null;

                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.IdClaveCabmsid).ToList();
                ltsCabmsequipmedico = resul;
                if (ltsCabmsequipmedico == null || ltsCabmsequipmedico.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsCabmsequipmedico

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblBienesEquMedico>()
                {
                    Mensaje = ex.Message
                };
            }
        }

            /// <summary>
            /// Colsulta de bienes sistemas por inventario
            /// </summary>
            /// <returns></returns>
            public RespuestaApi<TblBienesEquMedico> GetConsultaInventario()
            {
                try
                {
                    List<TblBienesEquMedico> ltsInventarioequipmedico = null;

                    var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.IdInventarioid).ToList();
                ltsInventarioequipmedico = resul;
                    if (ltsInventarioequipmedico == null || ltsInventarioequipmedico.Count <= 0)
                        throw new System.Exception("No se encontraron resultados");

                    return new RespuestaApi<TblBienesEquMedico>
                    {
                        correcto = true,
                        ObjetoRespuesta = ltsInventarioequipmedico

                    };

                }
                catch (Exception ex)
                {
                    return new RespuestaApi<TblBienesEquMedico>()
                    {
                        Mensaje = ex.Message
                    };
                }

            }

        /// <summary>
        /// Consulta de bienes equipo médico por proveedor
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsulataProveedor()
        {
            try
            {
                List<TblBienesEquMedico> ltsProveedorequipomedico = null;

                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.IdProveedorid).ToList();
                if (ltsProveedorequipomedico == null || ltsProveedorequipomedico.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>
                {
                    correcto = true,
                    ObjetoRespuesta = ltsProveedorequipomedico

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblBienesEquMedico>()
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
        public RespuestaApi<TblBienesEquMedico> GetConcultaPorFactura()
        {
            try
            {
                List<TblBienesEquMedico> lstBienesFactura = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.IdFacturasid).ToList();
                lstBienesFactura = resul;


                if (lstBienesFactura == null || lstBienesFactura.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesFactura
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesEquMedico>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta de bienes equipo médico por clave saica
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsultaClaveSaica()
        {
            try
            {
                List<TblBienesEquMedico> lstBienesClaveSaica = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.IdClaveSaicaid).ToList();
                lstBienesClaveSaica = resul;


                if (lstBienesClaveSaica == null || lstBienesClaveSaica.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesClaveSaica
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesEquMedico>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Te retorna las facturas por tipo de bien equipo mèdico 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblFacturas> GetFacturasTipoInventario(int idBienEquipMedico)
        {

            try
            {
                List<TblFacturas> lstFacturasporInventario = null;
                var resul = _objsicobimContext.TblFacturas.Where(x => x.CatTipoDeBienId == idBienEquipMedico).ToList();
                lstFacturasporInventario = resul;
                if (lstFacturasporInventario == null || lstFacturasporInventario.Count <= 0)
                    throw new System.Exception("No existen registros con el bien equipo mèdico insertado, favor de verificar");
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
        public RespuestaApi<TblBienesEquMedico> GetConsultaContrato()
        {
            try
            {
                List<TblBienesEquMedico> lstBienesContrato = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.IdContratoBienid).ToList();
                lstBienesContrato = resul;


                if (lstBienesContrato == null || lstBienesContrato.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesContrato
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesEquMedico>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta de bienes equipo médico por resguardatario
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsultarResguardatario()
        {
            try
            {
                List<TblBienesEquMedico> lstBienesPorResguardatario = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.IdResguardatariosid).ToList();
                lstBienesPorResguardatario = resul;


                if (lstBienesPorResguardatario == null || lstBienesPorResguardatario.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesPorResguardatario
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesEquMedico>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta de bienes equipo médico por estado fisico del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsultaEstadoFisicoBien()
        {
            try
            {
                List<TblBienesEquMedico> lstestadofisico = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.CatEstadoDelBienid).ToList();
                lstestadofisico = resul;


                if (lstestadofisico == null || lstestadofisico.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstestadofisico
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesEquMedico>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta de bienes equipo médico por garantia del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsultaporGarantia()
        {
            try
            {
                List<TblBienesEquMedico> lstbiengarantia = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.CatGarantiaid).ToList();
                lstbiengarantia = resul;


                if (lstbiengarantia == null || lstbiengarantia.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbiengarantia
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesEquMedico>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta de bienes sistemas por piso del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsultaPorPiso()
        {
            try
            {
                List<TblBienesEquMedico> lstbienporpiso = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.CatPisosid).ToList();
                lstbienporpiso = resul;


                if (lstbienporpiso == null || lstbienporpiso.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporpiso
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesEquMedico>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta de bienes sistemas por tipo de entrada del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsultaporTipodeEntrada()
        {
            try
            {
                List<TblBienesEquMedico> lstbienporentrada = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.CatTipoEntradaid).ToList();
                lstbienporentrada = resul;


                if (lstbienporentrada == null || lstbienporentrada.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporentrada
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesEquMedico>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta de bienes sistemas por tipo de partida presupuestas del bien
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsultaporTipodePartida()
        {
            try
            {
                List<TblBienesEquMedico> lstbienporpartida = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.CatTipoPartidaid).ToList();
                lstbienporpartida = resul;


                if (lstbienporpartida == null || lstbienporpartida.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporpartida
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesEquMedico>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta de bienes Equipo medico por servicio
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsultaporservicio()
        {
            try
            {
                List<TblBienesEquMedico> lstbienporservicio = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.Catservicioid
                ).ToList();
                lstbienporservicio = resul;


                if (lstbienporservicio == null || lstbienporservicio.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporservicio
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesEquMedico>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta del bien equipo medico por area 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsultaporArea()
        {
            try
            {
                List<TblBienesEquMedico> lstbienporarea = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.Catareaid
                ).ToList();
                lstbienporarea = resul;


                if (lstbienporarea == null || lstbienporarea.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporarea
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesEquMedico>
                { Mensaje = ex.Message };
            }
        }

        /// <summary>
        /// Consulta de bienes Equipo Medico por costo unitario ""individual"
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsultaPorPrecioUnitario()
        {
            try
            {
                List<TblBienesEquMedico> lstbienporcosto = null;
                var resul = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.Costounitario
                ).ToList();
                lstbienporcosto = resul;


                if (lstbienporcosto == null || lstbienporcosto.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstbienporcosto
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<TblBienesEquMedico>
                { Mensaje = ex.Message };
            }
        }




        #endregion


        #region Metodos para guardar

        public TblFacturas GuardarFacturaInventarioEquipoMedico( TblFacturas tblFacturas)
        {

            return _inventarioServiceEquipoMedico.GuardarTblFacturas(tblFacturas);

        }





        /// <summary>
        /// Guarda todos los bienes del Equipo Medico, tras una serie de validaciones en numeros de inventarios y federalización
        /// </summary>
        /// <param name="tblBienesEquMedico"></param>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GuardarTblEquiMedico(TblBienesEquMedico tblBienesEquMedico)
        {

            TblBienesEquMedico objTblBienesEquipoMedico = new TblBienesEquMedico();
            try
            {

                objTblBienesEquipoMedico = _inventarioServiceEquipoMedico.GuardarTblBienesEquMedico(tblBienesEquMedico);

                return new RespuestaApi<TblBienesEquMedico>()
                {
                    correcto = true,
                    Mensaje = "El registro se guardo con éxito"
                    
                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblBienesEquMedico>()
                {
                    Mensaje = ex.Message                
                };

            }

        }

        public TblClaveSaica GuardarTblClaveSaica(TblClaveSaica tblClaveSaica)
        {

            return _inventarioServiceEquipoMedico.GuardarTblClaveSaica(tblClaveSaica);

        }
        public TblContratoBien GuardarTblContratoBien(TblContratoBien tblContratoBien)
        {

            return _inventarioServiceEquipoMedico.GuardarTblContratoBien(tblContratoBien);

        }
        public TblFederalizacion GuardarTblFederalizacion(TblFederalizacion tblFederalizacion)
        {

            return _inventarioServiceEquipoMedico.GuardarTblFederalizacion(tblFederalizacion);

        }

        /// <summary>
        /// Guarda y valida que no se duplique el numero de inventario en la BD
        /// </summary>
        /// <param name="tblInventarios"></param>
        /// <returns>Obj de tipo tblIventarios, para obtener el Id de su llave primaria</returns>
        public  RespuestaApi<TblInventarios> GuardarTblInventarios(TblInventarios tblInventarios)
        {
            TblInventarios objtblInventarios = new TblInventarios();
            try
            {            
                if (_objsicobimContext.TblInventarios.Any(x => x.NumeroInventario == tblInventarios.NumeroInventario))
                    throw new AppException("Error, el numero de inventario ya existe");

                 objtblInventarios = _inventarioServiceEquipoMedico.GuardarTblInventarios(tblInventarios);

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

            return _inventarioServiceEquipoMedico.GuardarTblProveedor(tblProveedor);

        }
        public TblClaveCabms GuardarTblClaveCabms(TblClaveCabms tblClaveCabms)
        {

            return _inventarioServiceEquipoMedico.GuardarTblClaveCabms(tblClaveCabms);

        }




    #endregion
}



}

