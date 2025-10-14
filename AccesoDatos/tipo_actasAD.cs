using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace AccesoDatos
{
    public class tipo_actasAD
    {
        public static DataTable ListaTipoActaProceso(string tipoproceso)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"select * from tipo_acta where tipo_proceso='"+tipoproceso+"' order by id";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
    }
}
