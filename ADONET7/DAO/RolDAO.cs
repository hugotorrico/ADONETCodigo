using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONET7.DAO
{
    public class RolDAO
    {
        public void Registrar(string rolName)
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

            }
        }
        public void Actualizar(int rolID, string rolName)
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
               

            }
        }
        public void Eliminar(int rolID)
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
              

            }
        }

    }
}
