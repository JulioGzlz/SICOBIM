﻿using SICOBIM_B.Common;
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
        IInventarioService _inventarioService;


        public BusinessInventarioSistemas(IInventarioService objSistemas, ApplicationDbContext applicationDbContext)
        {
            _inventarioService = objSistemas;
            _objApplicationDbContext = applicationDbContext;

        }


        public RespuestaApi<TblBienesSistemas> GetSistemas() //esto se tienes que llamar en el controlador que le pertenece
        {
            try
            {
                List<TblBienesSistemas> lstSistemas = _inventarioService.GetTblBienesSistemas().OrderBy(x => x.idinventario).ToList();
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







    }
}
