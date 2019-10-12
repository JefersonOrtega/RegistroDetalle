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
    public partial class rAsistencia : Form
    {
        public List<EstudianteDetalle> Detalle { get; set; }
        public rAsistencia()
        {
            InitializeComponent();
            this.Detalle = new List<EstudianteDetalle>();
        }

        
        public void Limpiar()
        {
            MyerrorProvider.Clear();
            AsistenciaIdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            AsignaturaComboBox.ResetText();
            PresenteCheckBox.Checked = false;
            CantidadtextBox.Text = string.Empty;

            this.Detalle = new List<EstudianteDetalle>();
            CargarGrid();
        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalle;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void LlenarCampos(Asistencias asistencia)
        {
            AsistenciaIdnumericUpDown.Value = asistencia.AsistenciaId;
            FechadateTimePicker.Value = asistencia.Fecha;
            //AsignaturaComboBox.SelectedIndex=asistencia.AsignaturaId; //Revisar
            CantidadtextBox.Text = Convert.ToString(asistencia.Cantidad);

            this.Detalle = asistencia.Estudiantes;
            CargarGrid();
        }

        private Asistencias LlenarClase()
        {
            Asistencias asistencia = new Asistencias();

            asistencia.AsistenciaId = Convert.ToInt32(AsistenciaIdnumericUpDown.Value);
            asistencia.Fecha = FechadateTimePicker.Value;
            //asistencia.AsignaturaId = AsignaturaComboBox.SelectedIndex+1; //+1 porque el indice del CB comienza en 0, pero el id de asignatura comienza en 1
            asistencia.Cantidad = Convert.ToInt32(CantidadtextBox.Text);

            asistencia.Estudiantes = this.Detalle;

            return asistencia;
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(AsignaturaComboBox.Text))
            {
                MyerrorProvider.SetError(AsignaturaComboBox, "Debe seleccionar una asignatura");
                AsignaturaComboBox.Focus();
                paso = false;
            }
            if (string.IsNullOrWhiteSpace(EstudianteComboBox.Text))
            {
                MyerrorProvider.SetError(EstudianteComboBox, "Debe seleccionar un estudiante");
                EstudianteComboBox.Focus();
                paso = false;
            }

            if (this.Detalle.Count == 0)
            {
                MyerrorProvider.SetError(DetalledataGridView, "Debe agregar algun registr de asistencia");
                EstudianteComboBox.Focus();
                paso = false;
            }

            return paso;

        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();
            Asistencias asistencia = repositorio.Buscar((int)AsistenciaIdnumericUpDown.Value);
            return (asistencia != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Asistencias asistencia;
            bool paso = false;

            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();

            if (!Validar())
                return;

            asistencia = LlenarClase();

            //Determinar si es guargar o modificar
            if (AsistenciaIdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(asistencia);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe");
                    return;
                }
                paso = repositorio.Modificar(asistencia);
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


        

        private void RAsistencia_Load(object sender, EventArgs e)
        {
            /*RepositorioBase<Estudiante> repositorioEstudiante = new RepositorioBase<Estudiante>();
            foreach (var auxiliar in repositorioEstudiante.GetList(p => true))
            {
                EstudianteComboBox.Items.Add(auxiliar.Nombres);
            }
            RepositorioBase<Asignaturas> repositorioAsignatura = new RepositorioBase<Asignaturas>();
            foreach (var auxiliar in repositorioAsignatura.GetList(p => true))
            {
                AsignaturaComboBox.Items.Add(auxiliar.Nombre);
            }*/
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            int id;
            int.TryParse(AsistenciaIdnumericUpDown.Text, out id);

            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();
            Limpiar();

            if (repositorio.Buscar(id) != null)
            {
                if (repositorio.Eliminar(id))
                    MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MyerrorProvider.SetError(AsistenciaIdnumericUpDown, "No se puede eliminar un registro que no existe");
                AsistenciaIdnumericUpDown.Focus();
            }
                
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(AsistenciaIdnumericUpDown.Text, out id);

            Asistencias asistencia = new Asistencias();

            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();

            Limpiar();

            asistencia = repositorio.Buscar(id);

            if (asistencia != null)
            {
                LlenarCampos(asistencia);
            }
            else
            {
                MessageBox.Show("Registro No encontrado");
            }
        }

        private void AgregarEstudianteButton_Click(object sender, EventArgs e)
        {
            rEstudiantes rEstudiantes = new rEstudiantes();
            rEstudiantes.ShowDialog();

            EstudianteComboBox.Items.Clear();
            RepositorioBase<EstudianteDetalle> repositorio = new RepositorioBase<EstudianteDetalle>();
            foreach(var auxiliar in repositorio.GetList(p => true))
            {
                EstudianteComboBox.Items.Add(auxiliar.Nombres);
            }
        }

        private void AgregarAsignaturaButton_Click(object sender, EventArgs e)
        {
            rAsignatura rAsignatura = new rAsignatura();
            rAsignatura.ShowDialog();
            
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            foreach (var auxiliar in repositorio.GetList(p => true))
            {
                AsignaturaComboBox.Items.Add(auxiliar.Nombre);
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AgregarPresente_Click(object sender, EventArgs e)
        {
            if (EstudianteComboBox.Text.Trim().Length >0) //Si no esta vacio el combobox
            {
                if (DetalledataGridView.DataSource != null)
                    this.Detalle = (List<EstudianteDetalle>)DetalledataGridView.DataSource;

                this.Detalle.Add(
                    new EstudianteDetalle(
                        Id: 0,
                        AsistenciaId: (int)AsistenciaIdnumericUpDown.Value,
                        Nombres: EstudianteComboBox.Text,
                        Presente: PresenteCheckBox.Checked
                        )
                    );
                CargarGrid();
                CantidadtextBox.Text = DetalledataGridView.Rows.Count.ToString();
                EstudianteComboBox.Text = "";
                PresenteCheckBox.Checked = false;

            }
            else
            {
                MyerrorProvider.Clear();
                MyerrorProvider.SetError(EstudianteComboBox, "No hay ningún estudiante seleccionado");
                EstudianteComboBox.Focus();
            }
        }
    }
}
