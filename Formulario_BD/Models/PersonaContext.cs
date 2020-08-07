using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formulario_BD.Models
{
    public class PersonaContext : DbContext
    {

        public PersonaContext(DbContextOptions<PersonaContext> opcion):base(opcion)
        {

        }

        public DbSet<Persona> Personas { get; set; }
    }
}
