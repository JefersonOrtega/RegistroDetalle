﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistencia.Entidades
{
    public class Asignaturas
    {
        [Key]
        public int AsignaturaId { get; set; }
        public string Nombre { get; set; }

        public Asignaturas()
        {
            AsignaturaId = 0;
            Nombre = string.Empty;
        }
    }
}
