using RegistroAsistencia.BLL;
using RegistroAsistencia.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAsistencia.UI.Registros
{
    public partial class rAsignatura : Form
    {
        public rAsignatura()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            AsignaturaIdNumericUpDown.Value = 0;
            NombreTextBox.Text = string.Empty;
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void LlenarCampos(Asignaturas asignatura)
        {
            AsignaturaIdNumericUpDown.Value = asignatura.AsignaturaId;
            NombreTextBox.Text = asignatura.Nombre;
        }

        private Asignaturas LlenarClase()
        {
            Asignaturas asignatura = new Asignaturas();
            asignatura.AsignaturaId = Convert.ToInt32(AsignaturaIdNumericUpDown.Value);
            asignatura.Nombre = NombreTextBox.Text;

            return asignatura;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas asignatura = repositorio.Buscar((int)AsignaturaIdNumericUpDown.Value);
            return (asignatura != null);
        }




        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            Asignaturas asignatura;
            bool paso = false;

            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            MyErrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
            {
                MyErrorProvider.SetError(NombreTextBox, "Este campo no se puede dejar vacio");
                NombreTextBox.Focus();
                return;
            }


            asignatura = LlenarClase();

            //Determinar si es guargar o modificar
            if (AsignaturaIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(asignatura);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un estudiante que no existe");
                    return;
                }
                paso = repositorio.Modificar(asignatura);
            }

            //Informar el resultado
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void EliminarButton_Click_1(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(AsignaturaIdNumericUpDown.Text, out id);

            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            Limpiar();

            if (repositorio.Buscar(id) != null)
            {
                if (repositorio.Eliminar(id))
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyErrorProvider.SetError(AsignaturaIdNumericUpDown, "No se puede eliminar una asignatura que no existe");
                AsignaturaIdNumericUpDown.Focus();
            }
        }

        private void BuscarButton_Click_1(object sender, EventArgs e)
        {
            int id;
            int.TryParse(AsignaturaIdNumericUpDown.Text, out id);

            Asignaturas asignatura = new Asignaturas();

            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();

            Limpiar();

            asignatura = repositorio.Buscar(id);

            if (asignatura != null)
            {
                LlenarCampos(asignatura);
            }
            else
            {
                MessageBox.Show("Asignatura No encontrado");
            }
        }
    }
}
