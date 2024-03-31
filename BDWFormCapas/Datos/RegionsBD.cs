using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeesBDLinQ.Datos
{
    public class RegionsBD
    {
       /* BDConnect bdConnect = new BDConnect();

        public void InsertarRegions(Regions region)
        {
            using (SqlConnection connection = bdConnect.AbrirConexion())
            {
                try
                {
                    string query = "INSERT INTO regions (region_id,region_name) " +
                                   "VALUES (@RegionName);";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RegionName", region.RegionName);

                        //command.ExecuteNonQuery();
                        int num = command.ExecuteNonQuery();
                        MessageBox.Show($"{num} filas insertadas: ");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al insertar una region: " + ex.Message);
                }
                finally
                {
                    bdConnect.CerrarConexion(connection);
                }
            }
        }

        public List<Regions> SelectRegions()
        {
            Regions region = null;
            List<Regions> regions = new List<Regions>();

            using (SqlConnection connection = bdConnect.AbrirConexion())
            {
                try
                {
                    string query = "SELECT * FROM regions;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // ExecuteReader -> obtiene resultados de la consulta SELECT !! Importante
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                region = new Regions(
                                    Convert.ToInt32(reader["region_id"]),
                                    reader["region_name"].ToString()
                                );

                                regions.Add(region);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al seleccionar empleados: " + ex.Message);
                }
                finally
                {
                    bdConnect.CerrarConexion(connection);
                }
            }

            return regions;
        }*/
    }
}
