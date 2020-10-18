using SICOBIM_B.Data;
using SICOBIM_B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Services
{
    public interface ICatalogoPerfilesService
    {

        IEnumerable<CatArea> GetCatArea();
        IEnumerable<CatEstadoDelBien> GetCatEstadoDelBien();
        IEnumerable<CatEstatus> GetCatEstatus();
        IEnumerable<CatGarantia> GetCatGarantia();
        IEnumerable<CatPermiso> GetCatPermiso();
        IEnumerable<CatPisos> GetCatPisos();
        IEnumerable<CatRol> GetCatRol();
        IEnumerable<CatServicio> GetCatServicio();
        IEnumerable<CatSexo> GetCatSexo();
        IEnumerable<CatTipoContrato> GetCatTipoContrato();
        IEnumerable<CatTipoDeBien> GetCatTipoDeBien();
        IEnumerable<CatTipoEntrada> GetCatTipoEntrada();
        IEnumerable<CatTipoPartida> GetCatTipoPartida();
        IEnumerable<CatTipoSalida> GetCatTipoSalida();
        IEnumerable<CatTurno> GetCatTurno();
        IEnumerable<CatUnidadDestino> GetCatUnidadDestino();
        

    }

    public class CatalogoPerfilesService : ICatalogoPerfilesService
    {

        private ApplicationDbContext _applicationDbContext;

        public CatalogoPerfilesService(ApplicationDbContext dbContext)
        {
            _applicationDbContext = dbContext;
        }
        /// <summary>
        /// Retorna las areas administrativas y operativas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatArea> GetCatArea()
        {
            return _applicationDbContext.catArea; 
        }
        /// <summary>
        /// Retorna el estatus activo e inactivo
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatEstatus> GetCatEstatus()
        {
            return _applicationDbContext.catEstatus;
        }
        /// <summary>
        /// Retorna los años de garantia de los bienes 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatGarantia> GetCatGarantia()
        {
            return _applicationDbContext.catGarantia;
        }
        /// <summary>
        /// Retorna los permisos de los usuarios
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatPermiso> GetCatPermiso()
        {
            return _applicationDbContext.catPermiso;
        }
        /// <summary>
        /// Retorna los niveles de edificio
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatPisos> GetCatPisos()
        {
            return _applicationDbContext.catPisos;

        }
        /// <summary>
        /// Retorna los roles de los usuarios
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatRol> GetCatRol()
        {
            return _applicationDbContext.catRol;
        }
        /// <summary>
        /// Retorna los servicios(Departamentos) que integran a la unidad
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatServicio> GetCatServicio()
        {
            return _applicationDbContext.catServicio;
        }
        /// <summary>
        /// Retorna el sexo de usuario
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatSexo> GetCatSexo()
        {
            return _applicationDbContext.catSexo;
        }
        /// <summary>
        /// Retorna el tipo de contrato de usuarios y reguardatarios 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatTipoContrato> GetCatTipoContrato()
        {
            return _applicationDbContext.catTipoContrato;
        }
        /// <summary>
        /// Retorna el tipo de bien de acuerdo a su descripción 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatTipoDeBien> GetCatTipoDeBien()
        {
            return _applicationDbContext.catTipoDeBien;
        }
        /// <summary>
        /// Retorna como ingresa el bien a la unidad
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatTipoEntrada> GetCatTipoEntrada()
        {
            return _applicationDbContext.catTipoEntrada;
        }
        /// <summary>
        /// Retorna el tipo de partida de registro saica
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatTipoPartida> GetCatTipoPartida()
        {
            return _applicationDbContext.catTipoPartida;
        }
        /// <summary>
        /// Retorna el tipo de como sale de la unidad 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatTipoSalida> GetCatTipoSalida()
        {
            return _applicationDbContext.catTipoSalida;
        }
        /// <summary>
        /// Retorna el turno en el que se encuentra los usuarios y resguatdatarios
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatTurno> GetCatTurno()
        {
            return _applicationDbContext.catTurno;
        }
        /// <summary>
        /// Retorna los posibles destinos en los que pueden salir los bienes
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatUnidadDestino> GetCatUnidadDestino()
        {
            return _applicationDbContext.catUnidadDestino;
        }
        /// <summary>
        /// Retorna las areas administrativas y operativas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatEstadoDelBien> GetCatEstadoDelBien()
        {
            return _applicationDbContext.catEstadoDelBien;
        }
        /// <summary>
        /// Retorna las areas administrativas y operativas
        /// </summary>
        /// <returns></returns>




    }
}
