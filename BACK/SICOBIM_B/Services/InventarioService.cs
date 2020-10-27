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
        IEnumerable<TblSalidaBien> GetTblSalidaBien();




    }

    public class InventarioService : IInventarioService
    {

        private ApplicationDbContext _applicationDbContext;

        public InventarioService(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }

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

        public IEnumerable<TblSalidaBien> GetTblSalidaBien()
        {
            return _applicationDbContext.tblSalidaBien;
        }
    }
 

}
