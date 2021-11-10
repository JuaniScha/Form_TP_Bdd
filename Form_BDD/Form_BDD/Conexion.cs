using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Form_BDD
{
    public static class Conexion
    {
        static string connectionString = "Data Source=(local);Initial Catalog=nombre_BDD;Integrated Security=true";       

        public static SqlConnection conexionBDD = new SqlConnection();

        public static void AbrirConexion()
        {
            try
            {
                conexionBDD.ConnectionString = connectionString;
                conexionBDD.Open();
                MessageBox.Show("Conexión establecida");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en la conexión: " + ex.Message);
                Application.Exit();
            }
        }

        public static void CerrarConexion()
        {
            conexionBDD.Close();
        }
    }
}
