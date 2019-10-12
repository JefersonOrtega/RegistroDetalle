using RegistroAsistencia.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAsistencia.BLL
{
    class AsistenciaRepositorio : RepositorioBase<Asistencias>
    {
        public override bool Modificar(Asistencias asistencia)
        {

            var Anterior = base._contexto.Asistencias.Find(asistencia.AsistenciaId);
            foreach (var item in Anterior.Estudiantes)
            {
                if (!asistencia.Estudiantes.Exists(d => d.Id == item.Id))
                    base._contexto.Entry(item).State = EntityState.Deleted;
            }

            bool paso = base.Modificar(asistencia);
            return paso;
        }

        public override Asistencias Buscar(int id)
        {
            Asistencias asistencia = new Asistencias();

            asistencia.Estudiantes.Count(); //COunt para hacer al lazyloading cargar los detalles

            return base.Buscar(id);
        }

    }
}
