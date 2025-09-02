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
    public class actasAD
    {
        ConexionSQL oConexion = new ConexionSQL();

        public int devuelveNroReg()
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                int intValor = 0;
                oConexion.conectar();
                cmd.CommandText = "SELECT * FROM acta";
                cmd.Connection = oConexion.conexion;
                oConexion.conexion.Open();
                SqlDataReader tblResultado = cmd.ExecuteReader();
                while (tblResultado.Read())
                {
                    intValor = intValor + 1;
                }
                return intValor;
            }
            catch (Exception ex)
            {
                cmd.Connection.Close();
                throw new Exception(ex.Message);
            }
        }
        
        public void Insertar(string descripcion, int id_mesa, int votos_blanco1, int votos_blanco2, int votos_nulos1, int votos_nulos2, int votos_inpugnados1, int votos_inpugnados2, int total_emitidos1, int total_emitidos2)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "INSERT INTO acta VALUES('" + descripcion + "','" + id_mesa + "','" + votos_blanco1 + "','" + votos_blanco2 + "','" + votos_nulos1 + "','" + votos_nulos2 + "','"+ votos_inpugnados1 +"','"+ votos_inpugnados2 +"','"+ total_emitidos1 +"','"+ total_emitidos2 +"')";
                cmd.Connection = oConexion.conexion;
                oConexion.conexion.Open();
                int exito = cmd.ExecuteNonQuery();
                if (exito == 1)
                {
                    cmd.Connection.Close();
                }
            }
            catch (Exception ex)
            {
                cmd.Connection.Close();
                throw new Exception(ex.Message);
            }

        }
        public static DataTable ValidarIdActa(string numero, string tipo_acta)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"select a.id, a.descripcion, a.total_emitidos1, a.total_emitidos2, m.tipo, m.estado from acta a
                                    inner join mesa m on a.id_mesa=m.id
                                  WHERE ( m.numero ='" + numero + "' and m.tipo='"+ tipo_acta +"')";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static DataTable CargaCabecerRegional(string numero, string tipo)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"select A.total_emitidos1,A.total_emitidos2,A.votos_blanco1,A.votos_blanco2,A.votos_inpugnados1,A.votos_inpugnados2,A.votos_nulos1, A.votos_nulos2
                                    from acta a
                                    inner join mesa m on m.id=a.id_mesa
                                 where m.numero='" + numero + "' and m.tipo='" + tipo + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static void ActualizarActa(int votos_blanco1, int votos_blanco2, int votos_nulos1, int votos_nulos2, int votos_inpugnados1, int votos_inpugnados2, int total_emitidos1, int total_emitidos2, int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                conn.Open();

                string query = @"UPDATE acta SET
                                   votos_blanco1=@votos_blanco1
                                  ,votos_blanco2=@votos_blanco2
                                  ,votos_nulos1=@votos_nulos1
                                  ,votos_nulos2=@votos_nulos2
                                  ,votos_inpugnados1=@votos_inpugnados1
                                  ,votos_inpugnados2=@votos_inpugnados2
                                  ,total_emitidos1=@total_emitidos1
                                  ,total_emitidos2=@total_emitidos2
                                 WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@votos_blanco1", votos_blanco1);
                cmd.Parameters.AddWithValue("@votos_blanco2", votos_blanco2);
                cmd.Parameters.AddWithValue("@votos_nulos1", votos_nulos1);
                cmd.Parameters.AddWithValue("@votos_nulos2", votos_nulos2);
                cmd.Parameters.AddWithValue("@votos_inpugnados1", votos_inpugnados1);
                cmd.Parameters.AddWithValue("@votos_inpugnados2", votos_inpugnados2);
                cmd.Parameters.AddWithValue("@total_emitidos1", total_emitidos1);
                cmd.Parameters.AddWithValue("@total_emitidos2", total_emitidos2);
                cmd.Parameters.AddWithValue("@id", id);
                int exito = cmd.ExecuteNonQuery();
                if (exito == 1)
                {
                    cmd.Connection.Close();
                }

            }

        }
    }
}
