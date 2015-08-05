using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void ingresarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            LogIn ver = new LogIn();
            ver.Show();
            this.Close();
        }

        private void mCotizacion_Click(object sender, EventArgs e)
        {

        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresoSucursal ver = new IngresoSucursal();
            ver.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAseguradora ver = new frmAseguradora();
            ver.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
