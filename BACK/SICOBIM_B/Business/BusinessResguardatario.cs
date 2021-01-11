using SICOBIM_B.Common;
using SICOBIM_B.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Business
{
    public class BusinessResguardatario
    {
        private sicobimContext _objsicobimContext;
        IInventarioService _inventarioServiceResguardatarios;
        public BusinessResguardatario(IInventarioService objResguardatario, sicobimContext sicobimContext)
        {
            _inventarioServiceResguardatarios = objResguardatario;
            _objsicobimContext = sicobimContext;
        }


        #region CONSULTAS
        /// <summary>
        /// consulta por medio de una lista los Resguardatario
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetResguardatario()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarios = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().ToList();
                lstResguardatarios = resul;

                if (lstResguardatarios == null || lstResguardatarios.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");

                return new RespuestaApi<TblResguardatarios>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarios

                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios> { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// consulta al resguardatario Por su Nombre
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorNombre()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarionombre = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.Nombre).ToList();
                lstResguardatarionombre = resul;
                if (lstResguardatarionombre == null || lstResguardatarionombre.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarionombre

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// consulta al resguardatario Por su Primer Apellido
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorPrimerApellido()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioPorApellidoUno = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.ApellidoUno).ToList();
                lstResguardatarioPorApellidoUno = resul;
                if (lstResguardatarioPorApellidoUno == null || lstResguardatarioPorApellidoUno.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioPorApellidoUno

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }



        }
        /// <summary>
        /// consulta al resguardatario Por su Segundo Apellido
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorSegundoApellido()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioPorApellidoDos = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.ApellidoDos).ToList();
                lstResguardatarioPorApellidoDos = resul;
                if (lstResguardatarioPorApellidoDos == null || lstResguardatarioPorApellidoDos.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioPorApellidoDos

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }

        }
        /// <summary>
        /// consulta al resguardatario Por su Servicio
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorServicio()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioPorServicio = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.CatServicioid).ToList();
                lstResguardatarioPorServicio = resul;
                if (lstResguardatarioPorServicio == null || lstResguardatarioPorServicio.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioPorServicio

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// consulta al resguardatario Por su Area
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorArea()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioPorArea = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.Catareaid).ToList();
                lstResguardatarioPorArea = resul;
                if (lstResguardatarioPorArea == null || lstResguardatarioPorArea.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioPorArea

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// consulta al resguardatario Por su Turnos
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorTurno()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioPorTurno = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.CatTurnoid).ToList();
                lstResguardatarioPorTurno = resul;
                if (lstResguardatarioPorTurno == null || lstResguardatarioPorTurno.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioPorTurno

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// consulta al resguardatario Por su Estatus
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorEstatus()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioPorEstatus = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.CatEstatusid).ToList();
                lstResguardatarioPorEstatus = resul;
                if (lstResguardatarioPorEstatus == null || lstResguardatarioPorEstatus.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioPorEstatus

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// consulta al resguardatario Por su Contrato
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorContrato()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioPorContrato = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.CatTipoContratoid).ToList();
                lstResguardatarioPorContrato = resul;
                if (lstResguardatarioPorContrato == null || lstResguardatarioPorContrato.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioPorContrato

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// consulta al resguardatario Por si esta activo 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorActivo()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioActivo = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.Activo).ToList();
                lstResguardatarioActivo = resul;
                if (lstResguardatarioActivo == null || lstResguardatarioActivo.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioActivo

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// consulta al resguardatario Por RFC 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorRFC()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioPorRFC = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.Rfc).ToList();
                lstResguardatarioPorRFC = resul;
                if (lstResguardatarioPorRFC == null || lstResguardatarioPorRFC.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioPorRFC

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }
        }

        /// <summary>
        /// consulta al resguardatario Por Cargo 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorCargo()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioPorCargo = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.Cargo).ToList();
                lstResguardatarioPorCargo = resul;
                if (lstResguardatarioPorCargo == null || lstResguardatarioPorCargo.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioPorCargo

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// consulta al resguardatario Por Sexo
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorSexo()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioPorSexo = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.CatSexoid).ToList();
                lstResguardatarioPorSexo = resul;
                if (lstResguardatarioPorSexo == null || lstResguardatarioPorSexo.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioPorSexo

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// consulta al resguardatario Por Numero de Empleado
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorNumeroDeEmpleado()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioPorNumeroEmpleado = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.Numeroempleado).ToList();
                lstResguardatarioPorNumeroEmpleado = resul;
                if (lstResguardatarioPorNumeroEmpleado == null || lstResguardatarioPorNumeroEmpleado.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioPorNumeroEmpleado

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        /// <summary>
        /// consulta al resguardatario Por Tipo de Plaza
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GetConsultaPorNumeroDePlaza()
        {
            try
            {
                List<TblResguardatarios> lstResguardatarioPorPlaza = null;
                var resul = _inventarioServiceResguardatarios.GetTblResguardatarios().OrderBy(x => x.Plaza).ToList();
                lstResguardatarioPorPlaza = resul;
                if (lstResguardatarioPorPlaza == null || lstResguardatarioPorPlaza.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");


                return new RespuestaApi<TblResguardatarios>
                {
                    correcto = true,
                    ObjetoRespuesta = lstResguardatarioPorPlaza

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        #endregion


        #region Metodos para guardar

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tblResguardatarios"></param>
        /// <returns></returns>
        public RespuestaApi<TblResguardatarios> GuardarTblResguardatarios(TblResguardatarios tblResguardatarios)
        {

            return _inventarioServiceResguardatarios.GuardarTblResguardatarios(tblResguardatarios);

        }
    

        #endregion
    }



}

