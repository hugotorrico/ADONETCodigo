using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
namespace WpfADONET
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string cadena = "Server=DESKTOP-BCQFL9J\\SQLEXPRESS; " +
                        "Initial Catalog=WICMonitoriaDBDev; Integrated Security=True;trustservercertificate=True";

        public MainWindow()
        {
            InitializeComponent();

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
                    
                    //dgvDemo.Items.Add(new { id = Id.ToString() });                        
                    //dgvDemo.Rows.Add(Id.ToString(), nombre, cantidad);

                }

                reader.Close();

            }

        }
    }
}