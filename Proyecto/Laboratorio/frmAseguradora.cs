using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Laboratorio
{
    public partial class frmAseguradora : Form
    {
        public frmAseguradora()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cod = 4;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into TRASEGURADORA  values ('{0}','{1}')",
            cod, txtNombre.Text), clasConexion.funConexion());
            comando.ExecuteNonQuery();
            //MessageBox.Show("Conectado");
        }
    }
}
