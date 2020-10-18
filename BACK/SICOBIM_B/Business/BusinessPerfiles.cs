﻿using SICOBIM_B.Common;
using SICOBIM_B.Entities;
using SICOBIM_B.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Business
{
    public class BusinessPerfiles
    {

        ICatalogoPerfilesService _catalogoPerfilesService;


        public BusinessPerfiles(ICatalogoPerfilesService objIcatalogos)
        {
            _catalogoPerfilesService = objIcatalogos;

        }

        public RespuestaApi<CatEstatus> GetEstatus()
        {
            try
            {
                List<CatEstatus> lstEstatus = _catalogoPerfilesService.GetCatEstatus().OrderBy(x => x.descripcion).ToList();
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
  
        public RespuestaApi<CatPermiso> getCatPermiso()
        {
            try
            {
                List<CatPermiso> lstPermisos = new List<CatPermiso>();

                return new RespuestaApi<CatPermiso>()
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
                List<CatRol> lstRoles = new List<CatRol>();

                return new RespuestaApi<CatRol>()
                {
                    correcto = true,
                    ObjetoRespuesta = lstRoles
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
    
    }
}