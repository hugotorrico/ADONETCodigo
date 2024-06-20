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

namespace ADONET7
{
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }
        string cadena = "Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
                         "Initial Catalog=WICMonitoriaDBDev; Integrated Security=True;trustservercertificate=True";

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Registrar(txtRol.Text);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar(Convert.ToInt32(txtIDRol.Text), txtRol.Text);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar(Convert.ToInt32(txtIDRol.Text));
        }
        void Registrar(string rolName)
        {
            using (var connection = new SqlConnection(cadena))
            {

                connection.Open();
                SqlCommand command = new SqlCommand("USP_InsertRole", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                parameter.Value = rolName;
                command.Parameters.Add(parameter);

                SqlParameter parameter2 = new SqlParameter("@Enabled", SqlDbType.Bit);
                parameter2.Value = true;
                command.Parameters.Add(parameter2);

                command.ExecuteNonQuery();
                MessageBox.Show("Registro Exitoso");

            }
        }

        void Actualizar(int rolID, string rolName)
        {
            using (var connection = new SqlConnection(cadena))
            {

                connection.Open();
                SqlCommand command = new SqlCommand("USP_UpdateRole", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@RoleName", SqlDbType.VarChar, 50);
                parameter.Value = rolName;
                command.Parameters.Add(parameter);

                SqlParameter parameter2 = new SqlParameter("@RoleID", SqlDbType.Int);
                parameter2.Value = rolID;
                command.Parameters.Add(parameter2);

                command.ExecuteNonQuery();
                MessageBox.Show("Actualización Exitosa");

            }
        }
        void Eliminar(int rolID)
        {
            using (var connection = new SqlConnection(cadena))
            {

                connection.Open();
                SqlCommand command = new SqlCommand("USP_DeleteRole", connection);
                command.CommandType = CommandType.StoredProcedure;


                SqlParameter parameter2 = new SqlParameter("@RoleID", SqlDbType.Int);
                parameter2.Value = rolID;
                command.Parameters.Add(parameter2);

                command.ExecuteNonQuery();
                MessageBox.Show("Eliminación Exitosa");

            }
        }

      
    }
}
