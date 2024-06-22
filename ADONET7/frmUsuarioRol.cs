using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace ADONET7
{
    public partial class frmUsuarioRol : Form
    {
        public frmUsuarioRol()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            TXInserUserInsertRol();
            MessageBox.Show("Rol y Usuario Creado");
        }
        public void InsertUser(int rolId,
                           string name, string userName, string password, string email,
                           string firstLastName, string secondLastName,
                           int regionId, string firmPath, int clinicId)
        {
            using (SqlConnection connection = new SqlConnection(Coneccion.cadena))
            {
                using (SqlCommand command = new SqlCommand("USP_InsertUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@UserName", userName);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@FirstLastName", firstLastName);
                    command.Parameters.AddWithValue("@SecondLastName", secondLastName);
                    command.Parameters.AddWithValue("@RoleId", rolId);
                    command.Parameters.AddWithValue("@RegioID", regionId);
                    command.Parameters.AddWithValue("@FirmPath", firmPath);
                    command.Parameters.AddWithValue("@ClinicID", clinicId);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        int InsertRol(string rolName)
        {
            int rolId = 0;
            using (var connection = new SqlConnection(Coneccion.cadena))
            {

                connection.Open();
                SqlCommand command = new SqlCommand("USP_InsertRoleSalida", connection);
                command.CommandType = CommandType.StoredProcedure;

                //Enviar los parámetros
                SqlParameter parameter = new SqlParameter("@Name", SqlDbType.VarChar, 50);
                parameter.Value = rolName;
                command.Parameters.Add(parameter);

                SqlParameter parameter2 = new SqlParameter("@RoleID", SqlDbType.Int);
                parameter2.Direction = ParameterDirection.Output;
                command.Parameters.Add(parameter2);        
                command.ExecuteNonQuery();

                rolId = Convert.ToInt32( parameter2.Value);

                return rolId;

            }
        }

        public void TXInserUserInsertRol()
        {
            

            try
            {
                int rolId = 0;
                //Insertar el Rol
                rolId = InsertRol(txtRol.Text);
                //Devolver el ID recién registrado
                //Insertar el usuario tomando el ID Devuelto
                InsertUser(rolId, txtName.Text, txtUserName.Text, txtPassword.Text, txtEmail.Text, txtFirstLastName.Text,
                    txtSecondLastName.Text, Convert.ToInt32(txtRegionID.Text), txtFirma.Text, Convert.ToInt32(txtClinicID.Text));
            }
            catch (Exception ex)
            {
                //Rollback de forma manual
                //DeleteRol();
                //DeleteUser();


                throw;
            }
          
        }
    }
}
