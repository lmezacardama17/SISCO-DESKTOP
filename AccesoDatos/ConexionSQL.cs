using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class ConexionSQL
    {
        public SqlConnection conexion; 

        public void conectar() 
        {
            conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=(local);Initial Catalog=SISCO;Persist Security info=True; User ID=sa;Password=z5iisq1zoo5";
            //conexion.ConnectionString = "Data Source=192.168.0.3;Initial Catalog=SISCO;Persist Security info=True; User ID=sa;Password=z5iisq1zoo5";
        }
    }
}
