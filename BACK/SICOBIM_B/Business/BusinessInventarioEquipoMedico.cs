using SICOBIM_B.Common;

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
        #region  Metodos de consultas de listas
        //private sicobimContext _objsicobimContext;
        IInventarioService _inventarioServiceEquipoMedico;

        //BusinessInventarioEquipoMedico _objBEnventarioEquipoMedico;

        public BusinessInventarioEquipoMedico(IInventarioService objEquipoMedico)
        {
            _inventarioServiceEquipoMedico = objEquipoMedico;
            //_objsicobimContext = sicobimContext;
            //_objBEnventarioEquipoMedico = businessInventarioEquipoMedico;

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
                List<TblBienesEquMedico> lstEquipoMedicoFederalizacion = _inventarioServiceEquipoMedico.GetTblBienesEquMedicos().OrderBy(x => x.IdFederalizacionid).ToList();
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
        /// <param name="idBienEquipoMedico"></param>
        /// <returns></returns>
        //public List<TblFacturas> getFacturasTipoInventario(int idBienEquipoMedico)
        //{
        //    List<TblFacturas> tblFacturastipoinventario = new List<TblFacturas>();
        //    try
        //    {              
        //        tblFacturastipoinventario = _objsicobimContext.tblFacturas.Where(x => x.IdBienesEquMedico.id == idBienEquipoMedico).ToList();

        //        if (tblFacturastipoinventario.Count <= 0 || tblFacturastipoinventario == null)
        //            throw new System.Exception("No existen registros con el Bien Equipo Médico insertado, favor de verificar");

        //    }
        //    catch (Exception ex)
        //    {
        //      string m =  ex.Message;
        //    }
        //    return tblFacturastipoinventario;
        //}
        /// <summary>
        /// Retorna un objeto de tipo TblFacturas
        /// </summary>
        /// <param name="factura">Parametro para la busqueda de una factura en especifico</param>
        /// <returns></returns>
        //public TblFacturas getFactura (string factura)
        //{
        //    TblFacturas tblFacturas = new TblFacturas();
        //    try
        //    {

        //        tblFacturas = _objsicobimContext.tblFacturas.Where(x => x.factura == factura).SingleOrDefault();
        //        //if (  )


        //    }
        //    catch (Exception ex)
        //    {


        //    }
        //    return tblFacturas;
        //}

        //public RespuestaApi<TblFacturas> getFacturasPorCosto (int idBienEquipoMedico, double costo )
        //{
        //    List<TblFacturas> tblFacturasPorCosto = new List<TblFacturas>();

        //    try
        //    {
        //        var result = _objBEnventarioEquipoMedico.getFacturasTipoInventario(idBienEquipoMedico);

        //        tblFacturasPorCosto = _objsicobimContext.tblFacturas.Where(x => x.IdBienesEquMedico.id == idBienEquipoMedico && x.costoTotal == costo).ToList();

        //        return new RespuestaApi<TblFacturas>()
        //        {
        //            correcto = true,
        //            ObjetoRespuesta = tblFacturasPorCosto
        //        };

        //    }
        //    catch (Exception ex)
        //    {

        //        return new RespuestaApi<TblFacturas>()
        //        {
        //            Mensaje = ex.Message
        //        };
        //    }

        //}
        #endregion


        #region Metodos para guardar

        public TblFacturas GuardarFacturaInventarioEquipoMedico( TblFacturas tblFacturas)
        {

            return _inventarioServiceEquipoMedico.GuardarTblFacturas(tblFacturas);

        }
        public TblBienesEquMedico GuardarTblEquiMedico(TblBienesEquMedico tblBienesEquMedico)
        {

            return _inventarioServiceEquipoMedico.GuardarTblBienesEquMedico(tblBienesEquMedico);

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
        public TblInventarios GuardarTblInventarios(TblInventarios tblInventarios)
        {

            return _inventarioServiceEquipoMedico.GuardarTblInventarios(tblInventarios);

        }
        public TblProveedor GuardarTblProveedor(TblProveedor tblProveedor)
        {

            return _inventarioServiceEquipoMedico.GuardarTblProveedor(tblProveedor);

        }
        public TblClaveCambs GuardarTblClaveCabms(TblClaveCambs tblClaveCabms)
        {

            return _inventarioServiceEquipoMedico.GuardarTblClaveCabms(tblClaveCabms);

        }




        #endregion
    }











}
