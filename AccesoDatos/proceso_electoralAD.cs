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
        public static DataTable BuscarProcesoElectoral(string descripcion, string ano)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"select id, descripcion, ano, tipo_proceso, estado from proceso_electoral where (descripcion like '%"+descripcion+"%' or ano like '%"+ano+"%') order by id ";
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
        public static void ActualizarPorcesoElectotal(string estado, int id_proceso_electoral)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                string query = "UPDATE proceso_electoral SET estado=@estado WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@id", id_proceso_electoral);
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
        public static void ActualizarPorcesoElectotalCabecera(string descripcion, string ano, DateTime fecha_registro, string tipo_proceso, int id_proceso_electoral)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                string query = @"UPDATE proceso_electoral SET 
                                descripcion=@descripcion,
                                ano=@ano,
                                fecha_registro=@fecha_registro,
                                tipo_proceso=@tipo_proceso
                                WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@ano", ano);
                cmd.Parameters.AddWithValue("@fecha_registro", fecha_registro);
                cmd.Parameters.AddWithValue("@tipo_proceso", tipo_proceso);
                cmd.Parameters.AddWithValue("@id", id_proceso_electoral);
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
        public static void EliminarPorcesoElectotalCabecera(int id_proceso_electoral)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                string query = "DELETE FROM proceso_electoral WHERE id=@id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id_proceso_electoral);
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
        public static void EliminarPorcesoElectotalDetalle(int id_proceso_electoral)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                string query = "DELETE FROM detalle_proceso_electoral WHERE id_proceso_electoral=@id_proceso_electoral";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id_proceso_electoral", id_proceso_electoral);
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
        public static DataTable CargaProcesoElectoralCabecera(int id_proceso_electoral)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"select * from proceso_electoral where id='"+id_proceso_electoral+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static DataTable CargaProcesoElectoralDetalle(int id_proceso_electoral)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"select dpe.id_proceso_electoral, dpe.id_tipo_acta, ta.descripcion, ta.tipo_proceso, ta.estado
                                    from detalle_proceso_electoral dpe inner join
                                    tipo_acta ta on ta.id=dpe.id_tipo_acta
                                where dpe.id_proceso_electoral='" + id_proceso_electoral + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
    }
}
