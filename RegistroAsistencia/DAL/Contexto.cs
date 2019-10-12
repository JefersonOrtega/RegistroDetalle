using RegistroAsistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistencia.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Asignaturas> Asignaturas { get; set; }
        public DbSet<Asistencias> Asistencias { get; set; }

        public Contexto() : base("ConSrt")
        {

        }

    }
}
