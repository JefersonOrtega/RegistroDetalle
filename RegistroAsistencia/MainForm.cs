using RegistroAsistencia.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAsistencia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsistencia rAsistencia = new rAsistencia();
            rAsistencia.MdiParent = this;
            rAsistencia.Show();
        }
    }
}
