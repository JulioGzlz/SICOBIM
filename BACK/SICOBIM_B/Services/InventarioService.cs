using SICOBIM_B.Data;
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
        IEnumerable<TblBienes> GetTblBienes();
        IEnumerable<TblBienesEquMedico> GetTblBienesEquMedicos();
        IEnumerable<TblBienesSistemas> GetTblBienesSistemas();
        IEnumerable<TblInstrumentalMedico> GetTblInstrumentalMedico();
        IEnumerable<TblAreaServicio> GetTblAreaServicio();
        IEnumerable<TblClaveCabms> GetTblClaveCambs();
        IEnumerable<TblClaveSaica> GetTblClaveSaica();
        IEnumerable<TblConfPerfil> GetTblConfPerfil();
        IEnumerable<TblContratoBien> GetTblContratoBien();
        IEnumerable<TblFacturas> GetTblFacturas();
        IEnumerable<TblFederalizacion> GetTblFederalizacion();
        IEnumerable<TblInventarios> GetTblInventarios();
        IEnumerable<TblProveedor> GetTblProveedor();
        IEnumerable<TblResguardatarios> GetTblResguardatarios();
        IEnumerable<TblSalidaBienEquMedico> GetTblSalidaBienEquMedico();
        IEnumerable<TblSalidaBienInstrumentalMedico> GetTblSalidaBienInstrumentalMedico();
        IEnumerable<TblSalidaBienMobiliario> GetTblSalidaBienMobiliario();
        IEnumerable<TblSalidaBienSistemas> GetTblSalidaBienSistema();
        #endregion

        #region Guardado de los objetos de las entidades
        TblBienesEquMedico GuardarTblBienesEquMedico(TblBienesEquMedico tblBienesEquMedico);
        TblFacturas GuardarTblFacturas(TblFacturas tblFacturas);
        TblClaveSaica GuardarTblClaveSaica(TblClaveSaica tblClaveSaica);
        TblContratoBien GuardarTblContratoBien(TblContratoBien tblContratoBien);

        TblFederalizacion GuardarTblFederalizacion(TblFederalizacion tblFederalizacion);

        TblInventarios GuardarTblInventarios(TblInventarios tblInventarios);

        TblProveedor GuardarTblProveedor(TblProveedor tblProveedor);

         TblClaveCabms GuardarTblClaveCabms(TblClaveCabms tblClaveCabms);





        #endregion

    }

    public class InventarioService : IInventarioService
    {
        

        private ApplicationDbContext _applicationDbContext;

        public InventarioService(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }
        #region Retorno de consultas de las tablas
        public IEnumerable<TblAreaServicio> GetTblAreaServicio()
        {
            return _applicationDbContext.tblAreaServicio;
        }

        public IEnumerable<TblBienes> GetTblBienes()
        {
            return _applicationDbContext.tblBienes;

        }
        public IEnumerable<TblBienesEquMedico> GetTblBienesEquMedicos()
        {
            return _applicationDbContext.tblBienesEquMedicos;
        }

        public IEnumerable<TblBienesSistemas> GetTblBienesSistemas()
        {
            return _applicationDbContext.tblBienesSistemas;
        }

        public IEnumerable<TblClaveCabms> GetTblClaveCambs()
        {
            return _applicationDbContext.tblClaveCambs;
        }

        public IEnumerable<TblClaveSaica> GetTblClaveSaica()
        {
            return _applicationDbContext.tblClaveSaica;
        }

        public IEnumerable<TblConfPerfil> GetTblConfPerfil()
        {
            return _applicationDbContext.tblConfPerfil;
        }

        public IEnumerable<TblContratoBien> GetTblContratoBien()
        {
            return _applicationDbContext.tblContratoBien;
        }

        public IEnumerable<TblFacturas> GetTblFacturas()
        {
            return _applicationDbContext.tblFacturas;
        }

        public IEnumerable<TblFederalizacion> GetTblFederalizacion()
        {
            return _applicationDbContext.tblFederalizacion;
        }

        public IEnumerable<TblInstrumentalMedico> GetTblInstrumentalMedico()
        {
            return _applicationDbContext.tblInstrumentalMedico;
        }

        public IEnumerable<TblInventarios> GetTblInventarios()
        {
            return _applicationDbContext.tblInventarios;
        }

        public IEnumerable<TblProveedor> GetTblProveedor()
        {
            return _applicationDbContext.tblProveedor;
        }

        public IEnumerable<TblResguardatarios> GetTblResguardatarios()
        {
            return _applicationDbContext.tblResguardatarios;
        }

        public IEnumerable<TblSalidaBienEquMedico> GetTblSalidaBienEquMedico()
        {
            return _applicationDbContext.tblSalidaBienEquMedico;
        }
        public IEnumerable<TblSalidaBienInstrumentalMedico> GetTblSalidaBienInstrumentalMedico()
        {
            return _applicationDbContext.tblSalidaBienInstrumentalMedico;
        }

        public IEnumerable<TblSalidaBienMobiliario> GetTblSalidaBienMobiliario()
        {
            return _applicationDbContext.tblSalidaBienMobiliario;
        }

        public IEnumerable<TblSalidaBienSistemas> GetTblSalidaBienSistema()
        {
            return _applicationDbContext.tblSalidaBienSistema;
        }
        #endregion


        #region Guardado de mis objetos
        public TblBienesEquMedico GuardarTblBienesEquMedico(TblBienesEquMedico tblBienesEquMedico)
        {
            _applicationDbContext.tblBienesEquMedicos.Add(tblBienesEquMedico);
            _applicationDbContext.SaveChanges();

            return tblBienesEquMedico;
        }


        public TblFacturas GuardarTblFacturas(TblFacturas tblFacturas)
        {
            _applicationDbContext.tblFacturas.Add(tblFacturas);
            _applicationDbContext.SaveChanges();


            return tblFacturas;
        }
        public TblClaveSaica GuardarTblClaveSaica(TblClaveSaica tblClaveSaica)
        {
            _applicationDbContext.tblClaveSaica.Add(tblClaveSaica);
            _applicationDbContext.SaveChanges();


            return tblClaveSaica;
        }
        public TblContratoBien GuardarTblContratoBien(TblContratoBien tblContratoBien)
        {
            _applicationDbContext.tblContratoBien.Add(tblContratoBien);
            _applicationDbContext.SaveChanges();


            return tblContratoBien;
        }
        public TblFederalizacion GuardarTblFederalizacion(TblFederalizacion tblFederalizacion)
        {
            _applicationDbContext.tblFederalizacion.Add(tblFederalizacion);
            _applicationDbContext.SaveChanges();


            return tblFederalizacion;
        }
        public TblInventarios GuardarTblInventarios(TblInventarios tblInventarios)
        {
            _applicationDbContext.tblInventarios.Add(tblInventarios);
            _applicationDbContext.SaveChanges();


            return tblInventarios;
        }
        public TblProveedor GuardarTblProveedor(TblProveedor tblProveedor)
        {
            _applicationDbContext.tblProveedor.Add(tblProveedor);
            _applicationDbContext.SaveChanges();


            return tblProveedor;
        }
        public TblClaveCabms GuardarTblClaveCabms(TblClaveCabms tblClaveCabms)
        {
            _applicationDbContext.tblClaveCambs.Add(tblClaveCabms);
            _applicationDbContext.SaveChanges();


            return tblClaveCabms;
        }



        #endregion
    }


}
