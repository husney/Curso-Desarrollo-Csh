using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class Conexion
    {
        SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=prueba;User ID=SA;Password=Triacon2017*;");

      

		    public SqlConnection getConexion()
        {
            try
            {
                con.Open();
                Console.Write("Conectado");
                return con;
            }
            catch (Exception ex)
            {
                Console.Write("error");
                Console.WriteLine(ex.ToString());
                return null;
            }
        }
      

		
	

    }
}
