using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistencia.Entidades
{
    class Estudiante
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public bool Presente { get; set; }

        public Estudiante()
        {
            Id = 0;
            Nombres = string.Empty;
            Presente = false;
        }
    }
}
