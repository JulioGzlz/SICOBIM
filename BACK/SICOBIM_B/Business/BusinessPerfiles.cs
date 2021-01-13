using SICOBIM_B.Common;

using SICOBIM_B.Entities;
using SICOBIM_B.Helpers;
using SICOBIM_B.Models;
using SICOBIM_B.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Business
{
    public class BusinessPerfiles
    {
        IInventarioService _tblPerfilesService;
        private sicobimContext _objsicobimContext;

        ICatalogoPerfilesService _catalogoPerfilesService;
        IUserService _userService;


        public BusinessPerfiles(ICatalogoPerfilesService objIcatalogos, sicobimContext sicobimContext, IInventarioService objperfil, IUserService userService)
        {
            _catalogoPerfilesService = objIcatalogos;
            _objsicobimContext = sicobimContext;
            _tblPerfilesService = objperfil;
            _userService = userService;

        }

        public RespuestaApi<CatEstatus> GetEstatus()
        {
            try
            {
                List<CatEstatus> lstEstatus = _catalogoPerfilesService.GetCatEstatus().OrderBy(x => x.Descripcion).ToList();
                return new RespuestaApi<CatEstatus>
                {
                    correcto = true,
                    ObjetoRespuesta = lstEstatus

                };
            }

            catch (Exception ex)
            {
                return new RespuestaApi<CatEstatus>()
                {
                    Mensaje = ex.Message
                };
            }
        }

        /// <summary>
        /// obtener los sexos de la tabla CatSexo
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<CatSexo> GetCatSexo()
        {
            try
            {
                List<CatSexo> lstSexos = _catalogoPerfilesService.GetCatSexo().ToList();
                return new RespuestaApi<CatSexo>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstSexos

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatSexo> { Mensaje = ex.Message };
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<CatArea> getCatArea()
        {
            try
            {
                List<CatArea> lstAreas = _catalogoPerfilesService.GetCatArea().ToList();
                return new RespuestaApi<CatArea>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstAreas
                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatArea> { Mensaje = ex.Message };
            }
        }


        public RespuestaApi<CatEstadoDelBien> GetCatEstadoDelBien()
        {
            try
            {
                List<CatEstadoDelBien> lstCatEstadoBien = new List<CatEstadoDelBien>();

                return new RespuestaApi<CatEstadoDelBien>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstCatEstadoBien
                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatEstadoDelBien>
                {
                    Mensaje = ex.Message
                };
            }
        }

        public RespuestaApi<CatGarantia> getCatGarantia()
        {
            try
            {
                List<CatGarantia> lstGarantias = new List<CatGarantia>();


                return new RespuestaApi<CatGarantia>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstGarantias
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<CatGarantia>
                {
                    Mensaje = ex.Message
                };
            }
        }
  
        //public RespuestaApi<CatPermiso> getCatPermiso()
        //{
        //    try
        //    {
        //        List<CatPermiso> lstPermisos = new List<CatPermiso>();

        //        return new RespuestaApi<CatPermiso>()
        //        {
        //            correcto = true,
        //            ObjetoRespuesta = lstPermisos
        //        };

        //    }
        //    catch (Exception ex)
        //    {
        //        return new RespuestaApi<CatPermiso>()
        //        {
        //            Mensaje = ex.Message
        //        };
        //    }
        //}
        public RespuestaApi<CatPermiso> getCatPermiso()
        {
            try
            {
                List<CatPermiso> lstPermisos = null;
                var resul = _catalogoPerfilesService.GetCatPermiso().ToList();
                lstPermisos = resul;

                if (lstPermisos == null || lstPermisos.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");
                return new RespuestaApi<CatPermiso>
                {
                    correcto = true,
                    ObjetoRespuesta = lstPermisos

                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatPermiso>()
                {
                    Mensaje = ex.Message
                };
            }
        }


        public RespuestaApi<CatPisos> getCatPisos()
        {
            try
            {
                List<CatPisos> lstPisos = new List<CatPisos>();

                return new RespuestaApi<CatPisos>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstPisos
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<CatPisos>()
                {
                    Mensaje = ex.Message
                };
            }
        }
   
        public RespuestaApi<CatRol> getRoles()
        {
            try
            {
                List<CatRol> lstRol = null;
                var resul = _catalogoPerfilesService.GetCatRol().ToList();
                lstRol = resul;

                if (lstRol == null || lstRol.Count <= 0)
                    throw new System.Exception("No se encontraron resultados");
                return new RespuestaApi<CatRol>
                {
                    correcto = true,
                    ObjetoRespuesta = lstRol

                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatRol>()
                {
                    Mensaje = ex.Message
                };
            }
        }
        
        public List<TblConfPerfil> getRolPerfil(int IdPerfil)
        {
            List<TblConfPerfil> lstperfil = null;
            try
            {
               
                var resul =_objsicobimContext.TblConfPerfil.Where(x => x.IdPermisoid == IdPerfil).ToList();
                lstperfil = resul;

                if (lstperfil == null || lstperfil.Count <= 0)
                    throw new System.Exception("No existen registros con Perfil insertado, favor de verificar");

                return lstperfil;
         
            }
            catch (Exception ex)
            {
              
            }
            return lstperfil;
        }
       

        public RespuestaApi<CatServicio> getServicios()
        {

            try
            {
                List<CatServicio> lstServicios = _catalogoPerfilesService.GetCatServicio().ToList();

                return new RespuestaApi<CatServicio>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstServicios

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatServicio>()
                {
                    Mensaje = ex.Message
                };
            }
        }
    

        public RespuestaApi<CatTipoContrato> getContratos()
        {

            try
            {

                List<CatTipoContrato> lstContratos = _catalogoPerfilesService.GetCatTipoContrato().ToList();

                return new RespuestaApi<CatTipoContrato>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstContratos
                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatTipoContrato>()
                {
                    Mensaje = ex.Message
                };
            }
        }


        public RespuestaApi<CatTipoDeBien> getTipoBienes()
        {
            try
            {
                List<CatTipoDeBien> lstTipoBienes = _catalogoPerfilesService.GetCatTipoDeBien().ToList();


                return new RespuestaApi<CatTipoDeBien>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstTipoBienes
                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatTipoDeBien>()
                {
                    Mensaje = ex.Message
                };                
            }
        }

        public RespuestaApi<CatTipoEntrada> getTipoEntrada()
        {
            try
            {
                List<CatTipoEntrada> lstEntradas = _catalogoPerfilesService.GetCatTipoEntrada().ToList();

                return new RespuestaApi<CatTipoEntrada>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstEntradas
                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatTipoEntrada>()
                {
                    Mensaje = ex.Message
                };
            }
        }
    
        public RespuestaApi<CatTipoPartida> getTipoPartidad()
        {
            try
            {
                List<CatTipoPartida> lstPartidadas = _catalogoPerfilesService.GetCatTipoPartida().ToList();

                return new RespuestaApi<CatTipoPartida>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstPartidadas
                };

            }
            catch (Exception ex)
            {

                return new RespuestaApi<CatTipoPartida>()
                {
                    Mensaje = ex.Message
                };
            }
        }
   
        public RespuestaApi<CatTipoSalida> getTipoSalida()
        {
            try
            {
                List<CatTipoSalida> lstSalidas = _catalogoPerfilesService.GetCatTipoSalida().ToList();


                return new RespuestaApi<CatTipoSalida>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstSalidas
                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatTipoSalida>()
                {
                    Mensaje = ex.Message
                };
            }
        }


        public RespuestaApi<CatTurno> getCatTurnos()
        {
            try
            {
                List<CatTurno> lstTurnos = _catalogoPerfilesService.GetCatTurno().ToList();

                return new RespuestaApi<CatTurno>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstTurnos
                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatTurno>()
                {
                    Mensaje = ex.Message
                };
            }
        }
    
        public RespuestaApi<CatUnidadDestino> getUnidadDestino()
        {
            try
            {
                List<CatUnidadDestino> lstUnidadesDestino = _catalogoPerfilesService.GetCatUnidadDestino().ToList();


                return new RespuestaApi<CatUnidadDestino>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstUnidadesDestino
                };
            }
            catch (Exception ex)
            {

                return new RespuestaApi<CatUnidadDestino>()
                {
                    Mensaje = ex.Message
                };            
            }
        }
        
        public RespuestaApi<CatEstadoDelBien> getEstadoBien()
        {
            try
            {
                List<CatEstadoDelBien> lstEstadoBien = _catalogoPerfilesService.GetCatEstadoDelBien().ToList();


                return new RespuestaApi<CatEstadoDelBien>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstEstadoBien
                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatEstadoDelBien>()
                {
                    Mensaje = ex.Message
                };
            }
        }

        public RespuestaApi<CatEstadoDelBien> getEstadoBienActivos()
        {
            try
            {

                List<CatEstadoDelBien> lstBienesActivos = _objsicobimContext.CatEstadoDelBien.OrderBy(x => x.Activo == true).ToList();

                return new RespuestaApi<CatEstadoDelBien>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstBienesActivos
                };
            }
            catch (Exception ex)
            {
                return new RespuestaApi<CatEstadoDelBien>()
                {
                    Mensaje = ex.Message
                };
            }
        }

        /// <summary>
        /// Guardado de registro de usuarios en el sistema
        /// </summary>
        /// <param name="modeloRegistro">Cuerpo JSON</param>
        /// <returns>No debe retorna un objeto debido al guardado del pass</returns>
        public RespuestaApi<CtrlUsuarios> registroUsuarios(ModeloRegistro modeloRegistro)
        {
            CtrlUsuarios objCtrlUsuarios = new CtrlUsuarios();
            objCtrlUsuarios.FirstName = modeloRegistro.FirstName;
            objCtrlUsuarios.LastName = modeloRegistro.LastName;
            objCtrlUsuarios.Username = modeloRegistro.Username;
            objCtrlUsuarios.Activo = true;
            objCtrlUsuarios.IdUsuarioAlta = 1;
            objCtrlUsuarios.UsuarioMod = 1;
            objCtrlUsuarios.CatSexoid = modeloRegistro.idSexo;
            objCtrlUsuarios.Rfc = modeloRegistro.RFC;
            objCtrlUsuarios.Cargo = modeloRegistro.cargo;
            objCtrlUsuarios.CatEstatusid = 1; //Que estatus son?, no esta en el Model favor de ponerlo
            objCtrlUsuarios.CatTipoContratoid = modeloRegistro.idtipocontrato;
            objCtrlUsuarios.CatTurnoid = modeloRegistro.idturno;
            objCtrlUsuarios.Numeroempleado = modeloRegistro.numeroempleado;
            objCtrlUsuarios.Plaza = modeloRegistro.plaza;
            objCtrlUsuarios.Catareaid = 1; // Este no esta en modelo favor de ponerlo
            objCtrlUsuarios.Catservicioid = modeloRegistro.idServicio;
            objCtrlUsuarios.CatRolid = 1;  // Este no esta en modelo favor de ponerlo
            objCtrlUsuarios.FechaAlta = DateTime.Now;
            objCtrlUsuarios.FechaMod = DateTime.Now;

            try
            {

                if(_objsicobimContext.CtrlUsuarios.Any( x => x.Username == modeloRegistro.Username))
                    throw new AppException("El usuario  \"" + modeloRegistro.Username + "\" ya existe");

                //Mando a llamar el service
                objCtrlUsuarios = _userService.Create(objCtrlUsuarios, modeloRegistro.Password);

                return new RespuestaApi<CtrlUsuarios>(){
                    correcto = true,
                    Mensaje = "El registro fue guardado éxitosamente",
                   // objGenerics = objCtrlUsuarios //OJO!  ESTE OBJ NO se debe retornar ya que retorna un obj éxitoso desde el service INCLUYENDO EL PASSWORD

                };

            }
            catch (Exception ex)
            {
                return new RespuestaApi<CtrlUsuarios>()
                {
                    Mensaje = ex.Message
                };
            }
          
        }

    }
}