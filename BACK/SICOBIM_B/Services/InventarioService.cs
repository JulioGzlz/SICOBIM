
using SICOBIM_B.Common;
using SICOBIM_B.Entities;
using SICOBIM_B.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Services
{
    public interface IInventarioService
    {
        #region Consulta de tablas, se retornan LISTAS 
        IEnumerable<TblBienesMuebles> GetTblBienes();
        IEnumerable<TblBienesEquMedico> GetTblBienesEquMedicos();
        IEnumerable<TblBienesSistemas> GetTblBienesSistemas();
        IEnumerable<TblInstrumentalMedico> GetTblInstrumentalMedico();
        IEnumerable<TblClaveCabms> GetTblClaveCambs();
        IEnumerable<TblClaveSaica> GetTblClaveSaica();
        IEnumerable<TblConfPerfil> GetTblConfPerfil();
        IEnumerable<TblContratoBien> GetTblContratoBien();
        IEnumerable<TblFacturas> GetTblFacturas();
        IEnumerable<TblFederalizacion> GetTblFederalizacion();
        IEnumerable<TblInventarios> GetTblInventarios();
        IEnumerable<TblProveedor> GetTblProveedor();
        IEnumerable<TblResguardatarios> GetTblResguardatarios();
        IEnumerable<TblSalidasBien> GetTblSalidasBien();

        #endregion

        #region Guardado de los objetos de las entidades
        TblBienesEquMedico GuardarTblBienesEquMedico (TblBienesEquMedico tblBienesEquMedico);
        TblBienesMuebles GuardarTblBienesMuebles(TblBienesMuebles tblBienesMuebles);
        TblBienesSistemas GuardarTblBienesSistemas(TblBienesSistemas tblBienesSistemas);
        TblInstrumentalMedico GuardarTblInstrumentalMedico(TblInstrumentalMedico tblInstrumentalMedico);
        TblFacturas GuardarTblFacturas(TblFacturas tblFacturas);
        TblClaveSaica GuardarTblClaveSaica(TblClaveSaica tblClaveSaica);
        TblContratoBien GuardarTblContratoBien(TblContratoBien tblContratoBien);
        TblFederalizacion GuardarTblFederalizacion(TblFederalizacion tblFederalizacion);
       TblInventarios GuardarTblInventarios(TblInventarios tblInventarios);
        TblProveedor GuardarTblProveedor(TblProveedor tblProveedor);
        TblClaveCabms GuardarTblClaveCabms(TblClaveCabms tblClaveCabms);
        RespuestaApi<TblResguardatarios> GuardarTblResguardatarios(TblResguardatarios tblResguardatarios);




        #endregion

    }

    public class InventarioService : IInventarioService
    {
        

        private sicobimContext _sicobimContext;


        public InventarioService(sicobimContext dbContext)
        {
            _sicobimContext = dbContext;
        }
        #region Retorno de consultas de las tablas


        public IEnumerable<TblBienesMuebles> GetTblBienes()
        {
            return _sicobimContext.TblBienesMuebles;

        }
        public IEnumerable<TblBienesEquMedico> GetTblBienesEquMedicos()
        {
            return _sicobimContext.TblBienesEquMedico;
        }

        public IEnumerable<TblBienesSistemas> GetTblBienesSistemas()
        {
            return _sicobimContext.TblBienesSistemas;
        }

        public IEnumerable<TblClaveCabms> GetTblClaveCambs()
        {
            return _sicobimContext.TblClaveCambs;
        }

        public IEnumerable<TblClaveSaica> GetTblClaveSaica()
        {
            return _sicobimContext.TblClaveSaica;
        }

        public IEnumerable<TblConfPerfil> GetTblConfPerfil()
        {
            return _sicobimContext.TblConfPerfil;
        }

        public IEnumerable<TblContratoBien> GetTblContratoBien()
        {
            return _sicobimContext.TblContratoBien;
        }

        public IEnumerable<TblFacturas> GetTblFacturas()
        {
            return _sicobimContext.TblFacturas;
        }

        public IEnumerable<TblFederalizacion> GetTblFederalizacion()
        {
            return _sicobimContext.TblFederalizacion;
        }

        public IEnumerable<TblInstrumentalMedico> GetTblInstrumentalMedico()
        {
            return _sicobimContext.TblInstrumentalMedico;
        }

        public IEnumerable<TblInventarios> GetTblInventarios()
        {
            return _sicobimContext.TblInventarios;
        }

        public IEnumerable<TblProveedor> GetTblProveedor()
        {
            return _sicobimContext.TblProveedor;
        }

        public IEnumerable<TblResguardatarios> GetTblResguardatarios()
        {
            return _sicobimContext.TblResguardatarios;
        }
        public IEnumerable<TblSalidasBien> GetTblSalidasBien()
        {
            return _sicobimContext.TblSalidasBien;

        }

        
        #endregion


        #region Guardado de mis objetos
        public TblBienesEquMedico GuardarTblBienesEquMedico (TblBienesEquMedico tblBienesEquMedico)
        {

             _sicobimContext.TblBienesEquMedico.Add(tblBienesEquMedico);
             _sicobimContext.SaveChanges();

            return tblBienesEquMedico;
        }
    
        public RespuestaApi<TblResguardatarios> GuardarTblResguardatarios(TblResguardatarios tblResguardatarios)
        {
            try
            {
                if (_sicobimContext.TblResguardatarios.Any(x => x.Numeroempleado == tblResguardatarios.Numeroempleado))
                    throw new AppException("Este numero de resguardatario \"" + tblResguardatarios.Numeroempleado +
                        "\"ya se encuentra registrado");

                _sicobimContext.TblResguardatarios.Add(tblResguardatarios);
                _sicobimContext.SaveChanges();

            }
            catch (Exception ex)
            {
                return new RespuestaApi<TblResguardatarios>()
                {
                    Mensaje = ex.Message
                };

            }

            return new RespuestaApi<TblResguardatarios>()
            {
                correcto = true,
                Mensaje = "Registro guardado con éxito"

            };

        }




        public TblBienesMuebles GuardarTblBienesMuebles(TblBienesMuebles tblBienes)
        {
            _sicobimContext.TblBienesMuebles.Add(tblBienes);
            _sicobimContext.SaveChanges();

            return tblBienes;
        }
        public TblBienesSistemas GuardarTblBienesSistemas(TblBienesSistemas tblBienesSistemas)
        {
            _sicobimContext.TblBienesSistemas.Add(tblBienesSistemas);
            _sicobimContext.SaveChanges();

            return tblBienesSistemas;
        }
        public TblInstrumentalMedico GuardarTblInstrumentalMedico(TblInstrumentalMedico tblInstrumentalMedico)
        {
            _sicobimContext.TblInstrumentalMedico.Add(tblInstrumentalMedico);
            _sicobimContext.SaveChanges();

            return tblInstrumentalMedico;
        }

        public TblFacturas GuardarTblFacturas(TblFacturas tblFacturas)
        {
            _sicobimContext.TblFacturas.Add(tblFacturas);
            _sicobimContext.SaveChanges();


            return tblFacturas;
        }
        public TblClaveSaica GuardarTblClaveSaica(TblClaveSaica tblClaveSaica)
        {
            _sicobimContext.TblClaveSaica.Add(tblClaveSaica);
            _sicobimContext.SaveChanges();


            return tblClaveSaica;
        }
        public TblContratoBien GuardarTblContratoBien(TblContratoBien tblContratoBien)
        {
            _sicobimContext.TblContratoBien.Add(tblContratoBien);
            _sicobimContext.SaveChanges();


            return tblContratoBien;
        }
        public TblFederalizacion GuardarTblFederalizacion(TblFederalizacion tblFederalizacion)
        {
            _sicobimContext.TblFederalizacion.Add(tblFederalizacion);
            _sicobimContext.SaveChanges();


            return tblFederalizacion;
        }



        public TblInventarios GuardarTblInventarios(TblInventarios tblInventarios)
        {
            _sicobimContext.TblInventarios.Add(tblInventarios);
            _sicobimContext.SaveChanges();
            return tblInventarios;

        }

        public TblProveedor GuardarTblProveedor(TblProveedor tblProveedor)
        {
            _sicobimContext.TblProveedor.Add(tblProveedor);
            _sicobimContext.SaveChanges();


            return tblProveedor;
        }
        public TblClaveCabms GuardarTblClaveCabms(TblClaveCabms tblClaveCabms)
        {
            _sicobimContext.TblClaveCambs.Add(tblClaveCabms);
            _sicobimContext.SaveChanges();


            return tblClaveCabms;
        }

        



        #endregion
    }


}
