using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Laboratorio
{
    class clasConexion
    {
        public static MySqlConnection funConexion()
        {

            MySqlConnection Conexion = new MySqlConnection("server=localhost;userid=root;password= ;database=laboratorio");
            Conexion.Open();
            return Conexion;
        }
        
    }
}
