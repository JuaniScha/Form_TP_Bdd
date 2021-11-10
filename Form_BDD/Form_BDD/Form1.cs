using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Form_BDD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVista_Click(object sender, EventArgs e)
        {
            txtCantidad.Enabled = false;
            txtCodigo.Enabled = false;
            txtDNI.Enabled = false;
            txtFecha.Enabled = false;
            btnCargar.Enabled = false;

            string queryStringVista = "SELECT * FROM nombre_vista";
            SqlCommand comando = new SqlCommand(queryStringVista, Conexion.conexionBDD);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dgvDatos.DataSource = dt;
            dgvDatos.Update();
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            txtCantidad.Enabled = true;
            txtCodigo.Enabled = true;
            txtDNI.Enabled = true;
            txtFecha.Enabled = true;
            btnCargar.Enabled = true;           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCantidad.Enabled = false;
            txtCodigo.Enabled = false;
            txtDNI.Enabled = false;
            txtFecha.Enabled = false;
            btnCargar.Enabled = false;

            Conexion.AbrirConexion();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string queryStringStoredProcedure = ""; //agregar en el sql un select luego del stored procedure
            SqlCommand comando = new SqlCommand(queryStringStoredProcedure, Conexion.conexionBDD);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dgvDatos.DataSource = dt;
            dgvDatos.Update();
        }
    }
}
