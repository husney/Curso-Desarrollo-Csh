using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Conexion : IDisposable
    {

        SqlConnection con;

        public void Dispose(){}

        public SqlConnection getConexion()
        {
            try
            {
                con = new SqlConnection("Data Source=localhost; Initial Catalog=prueba; User ID=SA;Password=Triacon2017*");
                con.Open();
                Console.WriteLine("Conectado...");             
                return con;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("Error...");
                return null;
            }
        }

    }
}
