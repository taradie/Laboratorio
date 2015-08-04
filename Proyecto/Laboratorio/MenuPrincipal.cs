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
            IngresoPaciente ver = new IngresoPaciente();
            ver.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            LogIn ver = new LogIn();
            ver.Show();
            this.Close();
        }
    }
}
