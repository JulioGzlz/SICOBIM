using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SICOBIM_B.Models
{
    public class ModeloRegistro
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string SecondName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        public bool Activo { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaMod { get; set; }
        public int IdUsuarioAlta { get; set; }
        public int UsuarioMod { get; set; }
        public int idSexo { get; set; }
        public string RFC { get; set; }
        public string cargo { get; set; }
        public int idtipocontrato { get; set; }
        public int idturno { get; set; }
        public string Numeroempleado { get; set; }
        public string plaza { get; set; }
        public int idArea { get; set; }
        public int idServicio { get; set; }
        public int idRol { get; set; }


    }
}
