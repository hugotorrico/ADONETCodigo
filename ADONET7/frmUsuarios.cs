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
using System.Xml.Linq;

namespace ADONET7
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        string cadena = "Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
                          "Initial Catalog=WICMonitoriaDBDev; Integrated Security=True;trustservercertificate=True";
        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();
            //Abrir la cadena de conexión
            using (var connection = new SqlConnection(cadena))
            {
                //Usar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("USP_BuscarUsuario2", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@Filtro", SqlDbType.VarChar, 50);
                parameter.Value = txtFiltro.Text;
                cmd.Parameters.Add(parameter);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                //Recorrer el data reader
                while (reader.Read())
                {
                   
                    int UserID = reader["UserID"] != DBNull.Value ? Convert.ToInt32(reader["UserID"]) : 0;
                    string UserName = reader["UserName"] != DBNull.Value ? Convert.ToString(reader["UserName"]) : "";
                    string Email = reader["Email"] != DBNull.Value ? Convert.ToString(reader["Email"]) : "";
                    string Name2 = reader["Name"] != DBNull.Value ? Convert.ToString(reader["Name"]) : "";
                    string FirstLastName = reader["FirstLastName"] != DBNull.Value ? Convert.ToString(reader["FirstLastName"]) : "";
                    string RoleName = reader["RoleName"] != DBNull.Value ? Convert.ToString(reader["RoleName"]) : "";
                    dgvUsuarios.Rows.Add(UserID.ToString(),UserName,Email,Name2,FirstLastName,RoleName);
                }


                reader.Close();

            }
        }
    }
}
