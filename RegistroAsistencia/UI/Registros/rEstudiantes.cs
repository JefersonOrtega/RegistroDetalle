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
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            EstudianteIdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;    
        }
        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void LlenarCampos(Estudiante estudiante)
        {
            EstudianteIdNumericUpDown.Value = estudiante.Id;
            NombresTextBox.Text = estudiante.Nombres;
        }

        private Estudiante LlenarClase()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.Id = Convert.ToInt32(EstudianteIdNumericUpDown.Value);
            estudiante.Nombres = NombresTextBox.Text;

            return estudiante;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            Estudiante estudiante = repositorio.Buscar((int)EstudianteIdNumericUpDown.Value);
            return (estudiante != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Estudiante estudiante;
            bool paso = false;

            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            MyErrorProvider.Clear();
            if (string.IsNullOrWhiteSpace(NombresTextBox.Text))
            {
                MyErrorProvider.SetError(NombresTextBox, "Este campo no se puede dejar vacio");
                NombresTextBox.Focus();
                return;
            }
                

            estudiante = LlenarClase();

            //Determinar si es guargar o modificar
            if (EstudianteIdNumericUpDown.Value == 0)
                paso = repositorio.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un estudiante que no existe");
                    return;
                }
                paso = repositorio.Modificar(estudiante);
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

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(EstudianteIdNumericUpDown.Text, out id);

            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();
            Limpiar();

            if (repositorio.Buscar(id) != null)
            {
                if (repositorio.Eliminar(id))
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyErrorProvider.SetError(EstudianteIdNumericUpDown, "No se puede eliminar un registro que no existe");
                EstudianteIdNumericUpDown.Focus();
            }
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(EstudianteIdNumericUpDown.Text, out id);

            Estudiante estudiante = new Estudiante();

            RepositorioBase<Estudiante> repositorio = new RepositorioBase<Estudiante>();

            Limpiar();

            estudiante = repositorio.Buscar(id);

            if (estudiante != null)
            {
                LlenarCampos(estudiante);
            }
            else
            {
                MessageBox.Show("Estudiante No encontrado");
            }
        }
    }
}
