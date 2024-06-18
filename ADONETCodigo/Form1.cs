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
        string cadena = "Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
                           "Initial Catalog=WICMonitoriaDBDev; Integrated Security=True;trustservercertificate=True";

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
            SqlConnection connection = new SqlConnection(cadena);

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

            SqlConnection connection = new SqlConnection(cadena);

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

            SqlConnection connection = null;
            SqlCommand cmd = null;
            SqlDataAdapter sqlDataAdapter = null;
            DataTable dataTableClinics = null;
            try
            {
                connection = new SqlConnection(cadena);


                connection.Open();
                cmd = new SqlCommand("USP_GetClinics", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                sqlDataAdapter = new SqlDataAdapter(cmd);

                dataTableClinics = new DataTable();

                sqlDataAdapter.Fill(dataTableClinics);

                dgvDemo.DataSource = dataTableClinics;

                connection.Close();

                MessageBox.Show(dataTableClinics.Rows.Count.ToString());


            }
            catch (Exception)
            {
                connection.Close();

                throw;
            }
            finally
            {
                connection = null;
                cmd = null;
                sqlDataAdapter = null;
                dataTableClinics = null;
            }

        }


        private void btnUsing_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(cadena))
            {

                SqlCommand cmd = new SqlCommand("USP_GetClinics", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

                //No se debe usar DATASET porque son objetos muy grandes   
                DataSet dsClinics = new DataSet();

                sqlDataAdapter.Fill(dsClinics);

                dgvDemo.DataSource = dsClinics.Tables[0];

            }

        }

        private void btnDemoDR_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(cadena))
            {

                SqlCommand cmd = new SqlCommand("USP_GetClinics", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    //int Id = reader.GetInt32(0);
                    //string nombre = reader.GetString(1);

                    int Id = reader["ClinicID"] != DBNull.Value ? Convert.ToInt32(reader["ClinicID"]) : 0;
                    string nombre = reader["ClinicName"] !=DBNull.Value ? Convert.ToString(reader["ClinicName"]):"";
                    int cantidad = reader["cantidad"] !=DBNull.Value ? Convert.ToInt32(reader["cantidad"]): 0 ;
                    dgvDemo.Rows.Add(Id.ToString(), nombre,cantidad);
                }

                reader.Close();

            }

        }

        
    }
}
