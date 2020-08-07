using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Formulario_BD.Models
{
    public class Persona
    {
        [Key]
        public int idPersona { get; set; }

        [Required]
        public string nombre{ get; set; }
        public float peso { get; set; }
    }
}
