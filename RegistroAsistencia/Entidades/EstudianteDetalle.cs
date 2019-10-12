using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistencia.Entidades
{
    public class EstudianteDetalle
    {
        [Key]
        public int Id { get; set; }
        public int AsistenciaId { get; set; }
        public string Nombres { get; set; }
        public bool Presente { get; set; }

        public EstudianteDetalle()
        {
            Id = 0;
            AsistenciaId = 0;
            Nombres = string.Empty;
            Presente = false;
        }

        public EstudianteDetalle(int Id, int AsistenciaId, string Nombres, bool Presente)
        {
            this.Id = Id;
            this.AsistenciaId = AsistenciaId;
            this.Nombres = Nombres;
            this.Presente = Presente;
        }
    }
}
