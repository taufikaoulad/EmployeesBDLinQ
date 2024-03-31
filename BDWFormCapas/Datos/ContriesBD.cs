using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesBDLinQ.Datos
{
    public class ContriesBD
    {
        /*BDConnect bdConnect = new BDConnect();

        public void InsertarCountries(Countries countrie)
        {
            using (SqlConnection connection = bdConnect.AbrirConexion())
            {
                try
                {
                    string query = "INSERT INTO countries(country_id, country_name, region_id) " +
                                   "VALUES(@CountryId,@CountryName,@RegionId);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CountryId", countrie.CountryId);
                        command.Parameters.AddWithValue("@CountryName", countrie.CountryName);
                        command.Parameters.AddWithValue("@RegionId", countrie.RegionId);

                        //command.ExecuteNonQuery();
                        int num = command.ExecuteNonQuery();
                        MessageBox.Show($"{num} filas insertadas: ");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar una país: " + ex.Message);
                }
                finally
                {
                    bdConnect.CerrarConexion(connection);
                }
            }
        }*/
    }
}
