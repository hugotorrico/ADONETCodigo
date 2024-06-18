
using System.Data.SqlClient;
using System.Data;
namespace ADONET7
{
    public partial class Form1 : Form
    {
        string cadena = "Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
                          "Initial Catalog=WICMonitoriaDBDev; Integrated Security=True;trustservercertificate=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
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
                    string nombre = reader["ClinicName"] != DBNull.Value ? Convert.ToString(reader["ClinicName"]) : "";
                    int cantidad = reader["cantidad"] != DBNull.Value ? Convert.ToInt32(reader["cantidad"]) : 0;
                    dgvDemo.Rows.Add(Id.ToString(), nombre, cantidad);
                }

                reader.Close();

            }
        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            dgvDemo.Rows.Clear();
            //Abrir la cadena de conexión
            using (var connection = new SqlConnection(cadena))
            {

                //Usar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("USP_GetClinicsByName", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                parameter.Value = txtName.Text;
                cmd.Parameters.Add(parameter);


                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                //Recorrer el data reader
                while (reader.Read())
                {
                    //int Id = reader.GetInt32(0);
                    //string nombre = reader.GetString(1);

                    int Id = reader["ClinicID"] != DBNull.Value ? Convert.ToInt32(reader["ClinicID"]) : 0;
                    string nombre = reader["ClinicName"] != DBNull.Value ? Convert.ToString(reader["ClinicName"]) : "";
                    int cantidad = reader["cantidad"] != DBNull.Value ? Convert.ToInt32(reader["cantidad"]) : 0;
                    dgvDemo.Rows.Add(Id.ToString(), nombre, cantidad);
                }


                reader.Close();

            }
        }
    }
}
