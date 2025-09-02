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
    public class detalle_actasAD
    {
        ConexionSQL oConexion = new ConexionSQL();

        public void Insertar(int id_acta, int id_partido, int total_votos1, int total_votos2)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "INSERT INTO detalle_acta VALUES('" + id_acta + "','" + id_partido + "','" + total_votos1 + "','" + total_votos2 + "')";
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
        public static void ActualizarDetalleActa(int total_votos1, int total_votos2, int id_partido, int id_acta)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                conn.Open();

                string query = @"UPDATE detalle_acta SET
                                   total_votos1=@total_votos1,
                                   total_votos2=@total_votos2
                                 WHERE id_acta = @id_acta and id_partido=@id_partido";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@total_votos1", total_votos1);
                cmd.Parameters.AddWithValue("@total_votos2", total_votos2);
                cmd.Parameters.AddWithValue("@id_partido", id_partido);
                cmd.Parameters.AddWithValue("@id_acta", id_acta);
                int exito = cmd.ExecuteNonQuery();
                if (exito == 1)
                {
                    cmd.Connection.Close();
                }

            }

        }
    }
}
