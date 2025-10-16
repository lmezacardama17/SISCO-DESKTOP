using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace AccesoDatos
{
    public class candidatoAD
    {
        ConexionSQL oConexion = new ConexionSQL();

        public void Insertar(int id_proceso, int id_partido, string nombre_completo, string tipo_candidato, string postula)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "INSERT INTO candidato VALUES('"+id_proceso+"',  '" + id_partido + "','" + nombre_completo + "','" + tipo_candidato + "','"+ postula +"')";
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
        public static DataTable BuscarListadoCandidato(int id_proceso, string nombre_candidato)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"SELECT c.id,
                                        p.logo,
                                        c.nombre_completo,
                                        c.tipo_candidato,
                                        c.postula
                                        FROM candidato c
                                        inner join partido p on c.id_partido=p.id
                                        where id_proceso_electoral ='"+id_proceso+"' and (c.nombre_completo like '%" + nombre_candidato + "%')";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static void EliminarCandidato(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                conn.Open();

                string query = @"DELETE FROM candidato WHERE id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
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
