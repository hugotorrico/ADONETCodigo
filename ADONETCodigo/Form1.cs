using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADONETCodigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvDemo.AutoGenerateColumns = false;
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            //Nombre Servidor
            //Nombre Base Datos
            //Usuario Password (Autenticación)            
            SqlConnection connection = new SqlConnection("Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
                "Initial Catalog=WICMonitoriaDBDev; Integrated Security=True;trustservercertificate=True");

            connection.Open();
                        
            //Inyección SQL :Mala Práctica!!!!!!!!
            SqlCommand cmd = new SqlCommand("Select  * from Clinics", connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            DataTable dataTableClinics = new DataTable();

            sqlDataAdapter.Fill(dataTableClinics);
          
            dgvDemo.DataSource = dataTableClinics;
                
            connection.Close();



        }

        private void btnDemo2_Click(object sender, EventArgs e)
        {
                   
            SqlConnection connection = new SqlConnection("Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
                "Initial Catalog=WICMonitoriaDBDev; Integrated Security=True;trustservercertificate=True");

            connection.Open();

            SqlCommand cmd = new SqlCommand("Select  * from Clinics", connection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            //No se debe usar DATASET porque son objetos muy grandes   
            DataSet dsClinics = new DataSet();

            sqlDataAdapter.Fill(dsClinics);
            
            dgvDemo.DataSource = dsClinics.Tables[0];

            connection.Close();

        }

        private void btnDemo3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
              "Initial Catalog=WICMonitoriaDBDev; Integrated Security=True;trustservercertificate=True");

            connection.Open();

            SqlCommand cmd = new SqlCommand("USP_GetClinics", connection);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

            DataTable dataTableClinics = new DataTable();

            sqlDataAdapter.Fill(dataTableClinics);

            dgvDemo.DataSource = dataTableClinics;

            connection.Close();
        }
    }
}
