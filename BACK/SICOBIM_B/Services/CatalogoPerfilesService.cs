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
        //IEnumerable<CatEstatus> GetCatEstatus();

        IEnumerable<CatEstatus> GetCatEstatus();
        IEnumerable<CatPermiso> GetCatPermiso();
        IEnumerable<CatRol> GetCatRol();
        IEnumerable<CatServicio> GetCatServicio();
        IEnumerable<CatSexo> GetCatSexo();
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

        /// <summary>
        /// Retorna los permisos de los usuarios
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatPermiso> GetCatPermiso()
        {
            return _applicationDbContext.catPermiso;
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
        /// Retorna el turno en el que se encuentra los usuarios y resguatdatarios
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CatTurno> GetCatTurno()
        {
            return _applicationDbContext.catTurno;
        }

        /// <summary>
        /// Retorna las areas administrativas y operativas
        /// </summary>
        /// <returns></returns>




    }
}

