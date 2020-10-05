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
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        public string RFC { get; set; }
        public string plaza { get; set; }
        public string numeroempleado { get; set; }
        public string cargo { get; set; }
        public int idSexo { get; set; }
      
        public int idturno { get; set; }
      
        public int idtipocontrato { get; set; }

        public int idServicio { get; set; }
       

     
  
    }
}
