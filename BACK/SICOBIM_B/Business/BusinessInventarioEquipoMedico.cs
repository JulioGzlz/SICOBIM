using SICOBIM_B.Common;
using SICOBIM_B.Data;
using SICOBIM_B.Entities;
using SICOBIM_B.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Business
{
    public class BusinessInventarioEquipoMedico
    {
        private ApplicationDbContext _objApplicationDbContext;
        IInventarioService _inventarioServiceEquipoMedico;
        BusinessInventarioEquipoMedico _objBEnventarioEquipoMedico;

        public BusinessInventarioEquipoMedico(IInventarioService objEquipoMedico, ApplicationDbContext applicationDbContext, BusinessInventarioEquipoMedico businessInventarioEquipoMedico)
        {
            _inventarioServiceEquipoMedico = objEquipoMedico;
            _objApplicationDbContext = applicationDbContext;
            _objBEnventarioEquipoMedico = businessInventarioEquipoMedico;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetEquipoMedico() //esto se tienes que llamar en el controlador que le pertenece
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
        /// 
        /// </summary>
        /// <returns></returns>
        public RespuestaApi<TblBienesEquMedico> GetConsultaFederalizacion() //esto se tienes que llamar en el controlador que le pertenece
        {
            try
            {
                List<TblBienesEquMedico> lstEquipoMedicoFederalizacion = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.tblFederalizacion).ToList();
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
        /// 
        /// </summary>
        /// <param name="idBienSistema"></param>
        /// <returns></returns>
        public List<TblFacturas> getFacturasTipoInventario(int idBienSistema)
        {
            List<TblFacturas> tblFacturastipoinventario = new List<TblFacturas>();
            try
            {              
                tblFacturastipoinventario = _objApplicationDbContext.tblFacturas.Where(x => x.IdBienesSistema.id == idBienSistema).ToList();

                if (tblFacturastipoinventario.Count <= 0 || tblFacturastipoinventario == null)
                    throw new System.Exception("No existen registros con el Bien Sistema insertado, favor de verificar");
               
            }
            catch (Exception ex)
            {
              string m =  ex.Message;
            }
            return tblFacturastipoinventario;
        }
        /// <summary>
        /// Retorna un objeto de tipo TblFacturas
        /// </summary>
        /// <param name="factura">Parametro para la busqueda de una factura en especifico</param>
        /// <returns></returns>
        public TblFacturas getFactura (string factura)
        {
            TblFacturas tblFacturas = new TblFacturas();
            try
            {
               
                tblFacturas = _objApplicationDbContext.tblFacturas.Where(x => x.factura == factura).SingleOrDefault();
                //if (  )

                   
            }
            catch (Exception ex)
            {
              
             
            }
            return tblFacturas;
        }

        public RespuestaApi<TblFacturas> getFacturasPorCosto (int idBienSistema, double costo )
        {
            List<TblFacturas> tblFacturasPorCosto = new List<TblFacturas>();

            try
            {
                var result = _objBEnventarioEquipoMedico.getFacturasTipoInventario(idBienSistema);

                tblFacturasPorCosto = _objApplicationDbContext.tblFacturas.Where(x => x.IdBienesSistema.id == idBienSistema && x.costoTotal == costo).ToList();

                return new RespuestaApi<TblFacturas>()
                {
                    correcto = true,
                    ObjetoRespuesta = tblFacturasPorCosto
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


    }











}
