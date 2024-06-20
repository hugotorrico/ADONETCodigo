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
            Listar("");
        }
        
        #region Eventos
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Registrar(txtRol.Text);
            Listar("");
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar(Convert.ToInt32(txtIDRol.Text), txtRol.Text);
            Listar("");
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar(Convert.ToInt32(txtIDRol.Text));
            Listar("");
        }
        #endregion

        #region Funciones

        void Listar(string rolname)
        {
            dgvRoles.Rows.Clear();
            //Abrir la cadena de conexión
            using (var connection = new SqlConnection(Coneccion.cadena))
            {
                //Usar el procedimiento almacenado
                SqlCommand cmd = new SqlCommand("USP_GetRoles", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@RoleName", SqlDbType.VarChar, 50);
                parameter.Value = rolname;
                cmd.Parameters.Add(parameter);

                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                //Recorrer el data reader
                while (reader.Read())
                {

                    int RoleID = reader["RoleID"] != DBNull.Value ? Convert.ToInt32(reader["RoleID"]) : 0;                   
                    string RoleName = reader["RoleName"] != DBNull.Value ? Convert.ToString(reader["RoleName"]) : "";
                    dgvRoles.Rows.Add(RoleID.ToString(), RoleName);

                }


                reader.Close();

            }
        }
        void Registrar(string rolName)
        {
            using (var connection = new SqlConnection(Coneccion.cadena))
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
            using (var connection = new SqlConnection(Coneccion.cadena))
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
            using (var connection = new SqlConnection(Coneccion.cadena))
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

        #endregion
    }
}
