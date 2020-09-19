using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace Controller
{
    public class Control : IDisposable
    {
        public void Dispose( ){ }

        public void probarConexion()
        {
            using(DataAccess.Conexion con = new DataAccess.Conexion())
            {
                SqlConnection c = con.getConexion();
            }
        }

        public bool guardarFoto()
        {
            using(DataAccess.Conexion con = new DataAccess.Conexion())
            {
                SqlConnection c = con.getConexion();
                string query = "INSERT INTO imagen (IMG) VALUES(@imagen)";
                

                try
                {
                    SqlCommand comando = new SqlCommand(query, c);


                }
                catch(Exception ex)
                {

                }
            }
            return false;
        }

        
    }
}
