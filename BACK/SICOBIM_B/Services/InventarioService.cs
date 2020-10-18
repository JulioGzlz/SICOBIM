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
        IEnumerable<CatEstadoDelBien> GetCatEstadoDelBien();
        IEnumerable<CatGarantia> GetCatGarantia();
        IEnumerable<CatPisos> GetCatPisos();
        IEnumerable<CatServicio> GetCatServicios();
        IEnumerable<CatTipoDeBien> GetCatTipoDeBien();
        IEnumerable<CatTipoEntrada> GetCatTipoEntrada();
        IEnumerable<CatTipoPartida> GetCatTipoPartida();
        IEnumerable<CatTipoSalida> GetCatTipoSalida();
        IEnumerable<CatUnidadDestino> GetCatUnidadDestino();


    }

    public class InventarioService : IInventarioService
    {

        private ApplicationDbContext _applicationDbContext;

        public InventarioService(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }



        public IEnumerable<CatTipoEntrada> GetCatTipoEntrada()
        {
            return _applicationDbContext.catTipoEntrada;
        }

        public IEnumerable<TblBienes> GetTblBienes()
        {
            return _applicationDbContext.tblBienes;
        }

        public IEnumerable<CatEstadoDelBien> GetCatEstadoDelBien()
        {
            return _applicationDbContext.catEstadoDelBien;
        }

        public IEnumerable<CatGarantia> GetCatGarantia()
        {
            return _applicationDbContext.catGarantia;
        }

        public IEnumerable<CatPisos> GetCatPisos()
        {
            return _applicationDbContext.catPisos;
        }

        public IEnumerable<CatServicio> GetCatServicios()
        {
            return _applicationDbContext.catServicio;
        }

        public IEnumerable<CatTipoDeBien> GetCatTipoDeBien()
        {
            return _applicationDbContext.catTipoDeBien;
        }

        public IEnumerable<CatTipoPartida> GetCatTipoPartida()
        {
            return _applicationDbContext.catTipoPartida;
        }

        public IEnumerable<CatTipoSalida> GetCatTipoSalida()
        {
            return _applicationDbContext.catTipoSalida;
        }

        public IEnumerable<CatUnidadDestino> GetCatUnidadDestino()
        {
            return _applicationDbContext.catUnidadDestino;
        }

        public IEnumerable<TblBienesEquMedico> GetTblBienesEquMedicos()
        {
            return _applicationDbContext.tblBienesEquMedicos;
        }

        public IEnumerable<TblBienesSistemas> GetTblBienesSistemas()
        {
            return _applicationDbContext.tblBienesSistemas;
        }

        public IEnumerable<TblInstrumentalMedico> GetTblInstrumentalMedico()
        {
            return _applicationDbContext.tblInstrumentalMedico;
        }

    }
}
