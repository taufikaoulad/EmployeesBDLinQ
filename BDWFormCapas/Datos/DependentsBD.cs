using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesBDLinQ.Datos
{
    public class DependentsBD
    {
        /*BDConnect bdConnect = new BDConnect();

        public void InsertarDependents(Dependents dependents)
        {
            using (SqlConnection connection = bdConnect.AbrirConexion())
            {
                try
                {
                    string query = "INSERT INTO dependents(first_name,last_name,relationship,employee_id) " +
                                   "VALUES (@FirstName,@LastName,@Relationship,@EmployeeId);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@FirstName", dependents.FirstName);
                        command.Parameters.AddWithValue("@LastName", dependents.LastName);
                        command.Parameters.AddWithValue("@Relationship", dependents.Relationship);
                        command.Parameters.AddWithValue("@EmployeeId", dependents.EmployeeId);

                        //command.ExecuteNonQuery();
                        int num = command.ExecuteNonQuery();
                        MessageBox.Show($"{num} filas insertadas: ");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar una dependent: " + ex.Message);
                }
                finally
                {
                    bdConnect.CerrarConexion(connection);
                }
            }
        }*/
    }
}
