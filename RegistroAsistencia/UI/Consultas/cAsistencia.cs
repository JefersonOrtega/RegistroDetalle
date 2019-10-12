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

namespace RegistroAsistencia.UI.Consultas
{
    public partial class cAsistencia : Form
    {
        public cAsistencia()
        {
            InitializeComponent();
        }

        private void ConsultarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asistencias> repositorio = new RepositorioBase<Asistencias>();
            
            var listado = new List<Asistencias>();
            if (CriterioTextBox.Text.Trim().Length > 0)
            {
                switch (FiltrarComboBox.SelectedItem)
                {
                    case 0: //Todo
                        {

                            listado = repositorio.GetList(p => true);
                            break;
                        }

                    case 1: //Id
                        {
                            int id = Convert.ToInt32(CriterioTextBox.Text);
                            listado = repositorio.GetList(p => p.AsignaturaId == id);
                            break;
                        }

                    case 3: //Cantidad
                        {
                            int cantidad = Convert.ToInt32(CriterioTextBox.Text);
                            listado = repositorio.GetList(p => p.Cantidad==cantidad);
                            break;
                        }

                    
                }
                listado = listado.Where(c => c.Fecha.Date >= DesdeDateTimePicker.Value.Date && c.Fecha.Date <= HastaDateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }
            ConsultaDataGridView.DataSource = null;
            ConsultaDataGridView.DataSource = listado;
        }
    }
}
