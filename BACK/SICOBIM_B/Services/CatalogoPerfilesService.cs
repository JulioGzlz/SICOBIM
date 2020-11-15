
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
        //IEnumerable<CatEstatus> GetCatEstatus();

        IEnumerable<CatEstatus> GetCatEstatus();
        IEnumerable<CatPermiso> GetCatPermiso();
        IEnumerable<CatRol> GetCatRol();
        IEnumerable<CatServicio> GetCatServicio();
        IEnumerable<CatSexo> GetCatSexo();
        IEnumerable<CatTurno> GetCatTurno();
        IEnumerable<CatUnidadDestino> GetCatUnidadDestino();

        IEnumerable<CatTipoPartida> GetCatTipoPartida();
        IEnumerable<CatTipoEntrada> GetCatTipoEntrada();
        IEnumerable<CatTipoDeBien> GetCatTipoDeBien();
        IEnumerable<CatTipoContrato> GetCatTipoContrato();
        IEnumerable<CatTipoSalida> GetCatTipoSalida();






    }

    public class CatalogoPerfilesService : ICatalogoPerfilesService
    {

        private sicobimContext _sicobimContext;

        public CatalogoPerfilesService(sicobimContext dbContext)
        {
            _sicobimContext = dbContext;
        }
        /// <summary>
        /// Retorna las areas administrativas y operativas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatArea> GetCatArea()
        {
            return _sicobimContext.CatArea; 
        }

        public IEnumerable<CatEstadoDelBien> GetCatEstadoDelBien()
        {
            return _sicobimContext.CatEstadoDelBien;
        }

        public IEnumerable<CatEstatus> GetCatEstatus()
        {
            return _sicobimContext.CatEstatus; 
        }



        /// <summary>
        /// Retorna el estatus activo e inactivo
        /// </summary>
        /// <returns></returns>

        /// <summary>
        /// Retorna los permisos de los usuarios
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatPermiso> GetCatPermiso()
        {
            return _sicobimContext.CatPermiso;
        }


        /// <summary>
        /// Retorna los roles de los usuarios
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatRol> GetCatRol()
        {
            return _sicobimContext.CatRol;
        }
        /// <summary>
        /// Retorna los servicios(Departamentos) que integran a la unidad
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatServicio> GetCatServicio()
        {
            return _sicobimContext.CatServicio;
        }
        /// <summary>
        /// Retorna el sexo de usuario
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatSexo> GetCatSexo()
        {
            return _sicobimContext.CatSexo;
        }
        /// <summary>
        /// Retorna el tipo de contrato de usuarios y reguardatarios 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatTipoContrato> GetCatTipoContrato()
        {
            return _sicobimContext.CatTipoContrato;
        }

        public IEnumerable<CatTipoDeBien> GetCatTipoDeBien()
        {
            return _sicobimContext.CatTipoDeBien;
        }

        public IEnumerable<CatTipoEntrada> GetCatTipoEntrada()
        {
            return _sicobimContext.CatTipoEntrada;
        }

        public IEnumerable<CatTipoPartida> GetCatTipoPartida()
        {
            return _sicobimContext.CatTipoPartida;
        }

        public IEnumerable<CatTipoSalida> GetCatTipoSalida()
        {
            return _sicobimContext.CatTipoSalida;
        }

        /// <summary>
        /// Retorna el turno en el que se encuentra los usuarios y resguatdatarios
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatTurno> GetCatTurno()
        {
            return _sicobimContext.CatTurno;
        }

        public IEnumerable<CatUnidadDestino> GetCatUnidadDestino()
        {
            return _sicobimContext.CatUnidadDestino;
        }

        /// <summary>
        /// Retorna las areas administrativas y operativas
        /// </summary>
        /// <returns></returns>




    }
}

