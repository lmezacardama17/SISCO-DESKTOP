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
    public class proceso_electoralAD
    {
        public static DataTable ListaProcesoElectoral()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"select * from proceso_electoral where estado='ACTIVO'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static DataTable validarProcesoElectoralIngreso(int id, string ano)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"select * from proceso_electoral where id='" + id + "' and ano='" + ano + "' order by id ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static DataTable validarProcesoElectoral(string proceso, string ano)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"select * from proceso_electoral where tipo_proceso='"+proceso+"' and ano='"+ano+"' order by id ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static void Insertar(string descripcion, string ano, DateTime fecha_registro, string tipo_proceso, string estado)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                string query = "INSERT INTO proceso_electoral(descripcion, ano, fecha_registro, tipo_proceso, estado) VALUES(@descripcion, @ano, @fecha_registro, @tipo_proceso, @estado)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@ano", ano);
                cmd.Parameters.AddWithValue("@fecha_registro", fecha_registro);
                cmd.Parameters.AddWithValue("@tipo_proceso", tipo_proceso);
                cmd.Parameters.AddWithValue("@estado", estado);              
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
        public static void InsertarDetalle(int id_proceso_electoral, int id_tipo_acta)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                string query = "INSERT INTO detalle_proceso_electoral(id_proceso_electoral, id_tipo_acta) VALUES(@id_proceso_electoral, @id_tipo_acta)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@id_proceso_electoral", id_proceso_electoral);
                cmd.Parameters.AddWithValue("@id_tipo_acta", id_tipo_acta);
                conn.Open();
                try
                {
                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
