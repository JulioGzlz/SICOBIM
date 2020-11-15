
using SICOBIM_B.Entities;
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
        IEnumerable<TblAreaServicio> GetTblAreaServicio();
        IEnumerable<TblClaveCambs> GetTblClaveCambs();
        IEnumerable<TblClaveSaica> GetTblClaveSaica();
        IEnumerable<TblConfPerfil> GetTblConfPerfil();
        IEnumerable<TblContratoBien> GetTblContratoBien();
        IEnumerable<TblFacturas> GetTblFacturas();
        IEnumerable<TblFederalizacion> GetTblFederalizacion();
        IEnumerable<TblInventarios> GetTblInventarios();
        IEnumerable<TblProveedor> GetTblProveedor();
        IEnumerable<TblResguardatarios> GetTblResguardatarios();

        #endregion

        #region Guardado de los objetos de las entidades
        TblBienesEquMedico GuardarTblBienesEquMedico(TblBienesEquMedico tblBienesEquMedico);
        TblFacturas GuardarTblFacturas(TblFacturas tblFacturas);
        TblClaveSaica GuardarTblClaveSaica(TblClaveSaica tblClaveSaica);
        TblContratoBien GuardarTblContratoBien(TblContratoBien tblContratoBien);

        TblFederalizacion GuardarTblFederalizacion(TblFederalizacion tblFederalizacion);

        TblInventarios GuardarTblInventarios(TblInventarios tblInventarios);

        TblProveedor GuardarTblProveedor(TblProveedor tblProveedor);

        TblClaveCambs GuardarTblClaveCabms(TblClaveCambs tblClaveCabms);





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
        public IEnumerable<TblAreaServicio> GetTblAreaServicio()
        {
            return _sicobimContext.TblAreaServicio;
        }

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

        public IEnumerable<TblClaveCambs> GetTblClaveCambs()
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

      
        #endregion


        #region Guardado de mis objetos
        public TblBienesEquMedico GuardarTblBienesEquMedico(TblBienesEquMedico tblBienesEquMedico)
        {
            _sicobimContext.TblBienesEquMedico.Add(tblBienesEquMedico);
            _sicobimContext.SaveChanges();

            return tblBienesEquMedico;
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
        public TblClaveCambs GuardarTblClaveCabms(TblClaveCambs tblClaveCabms)
        {
            _sicobimContext.TblClaveCambs.Add(tblClaveCabms);
            _sicobimContext.SaveChanges();


            return tblClaveCabms;
        }



        #endregion
    }


}
