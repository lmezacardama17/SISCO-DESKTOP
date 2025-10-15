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
    public class partidoAD
    {
        ConexionSQL oConexion = new ConexionSQL();

        public static DataTable ListaOrganizacionRegionalVERIFICADO(string numero, string tipo)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"select ROW_NUMBER() OVER (ORDER BY P.orden) AS NRO, P.id AS ID,P.nombre_politico AS ORGANIZACION_POLITICA,
                                    C.tipo_candidato AS REG, P.logo, DA.total_votos1 AS VOTOREG, DA.total_votos2 AS VOTOCONS
                                    from partido p
                                    INNER JOIN candidato C ON P.id=C.id_partido
                                    inner join detalle_acta da on p.id=da.id_partido
                                    inner join acta a on a.id=da.id_acta
                                    inner join mesa m on m.id=a.id_mesa
                                 where m.numero='" + numero + "' and m.tipo='" + tipo + "' AND C.tipo_candidato='CANDIDATO REGIONAL'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static DataTable ListaOrganizacionMunicipalVERIFICADO(int id_acta)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"SELECT ROW_NUMBER() OVER (ORDER BY B.orden) AS NRO1, X.*,B.logo as LOGO1, DA.total_votos1 AS VOTOPROV, DA.total_votos2 AS VOTODISTR
                                    FROM 
                                    (SELECT ID1, ORGANIZACION_POLITICA1,PROV, DISTR FROM(select p.id as ID1, p.nombre_politico AS ORGANIZACION_POLITICA1, 
                                    p.logo AS LOGO1, ISNULL((select c.tipo_candidato from candidato c where c.tipo_candidato='CANDIDATO PROVINCIAL' and c.id_partido = p.id),'SIN CANDIDATO') PROV,
                                    ISNULL((select c.tipo_candidato from candidato c where c.tipo_candidato='CANDIDATO DISTRITAL' and c.id_partido = p.id),'SIN CANDIDATO') DISTR
                                    from partido p 
                                    left join (select c.id_partido, c.nombre_completo, c.tipo_candidato from candidato c where c.tipo_candidato='CANDIDATO PROVINCIAL' or c.tipo_candidato='CANDIDATO DISTRITAL')as p1
                                    on p.id=p1.id_partido) AS A
                                    GROUP by A.ID1, ORGANIZACION_POLITICA1,PROV, DISTR) AS X
                                    INNER JOIN partido B ON X.ID1 = B.id
                                    INNER JOIN detalle_acta DA ON DA.id_partido=B.id AND DA.id_acta='"+ id_acta +"' WHERE PROV<>'SIN CANDIDATO' OR DISTR<>'SIN CANDIDATO' order by B.orden";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static DataTable ListaOrganizacionRegional()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = "Cargar_Partidos_regional";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static DataTable ListaOrganizacionMunicipal()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = "stp_Cargar_Partidos_Municipal";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static DataTable CargarListado()
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = "stp_Cargar_Listado_Partidos";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static DataTable BuscarListado(string nombre_politico)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = "select id, nombre_politico, logo, dato, orden, estado from partido where (nombre_politico like '" + nombre_politico + "%')";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static void Insertar(string nombre_politico, byte[] logo, int dato, int orden, string estado)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                string query = "INSERT INTO partido(nombre_politico,logo,dato,orden, estado) VALUES(@nombre_politico,@logo,@dato,@orden,@estado)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre_politico", nombre_politico);
                cmd.Parameters.Add("@logo", System.Data.SqlDbType.Image).Value = logo;
                cmd.Parameters.AddWithValue("@dato", dato);
                cmd.Parameters.AddWithValue("@orden",orden);
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
        public static void ActualizarPartido(string nombre_politico, byte[] logo, int orden, int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                conn.Open();

                string query = @"UPDATE partido SET
                                        nombre_politico = @nombre_politico, 
                                        logo = @logo,
                                        orden = @orden
                                WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@nombre_politico", nombre_politico);
                cmd.Parameters.Add("@logo", System.Data.SqlDbType.Image).Value = logo;
                cmd.Parameters.AddWithValue("@orden", orden);
                cmd.Parameters.AddWithValue("@id", id);

                int exito = cmd.ExecuteNonQuery();
                if (exito == 1)
                {
                    cmd.Connection.Close();
                }
                
            }
            
        }
        public static void ActualizarEstadoPartido(string estado,  int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                conn.Open();

                string query = @"UPDATE partido SET
                                        estado = @estado
                                WHERE id = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@id", id);

                int exito = cmd.ExecuteNonQuery();
                if (exito == 1)
                {
                    cmd.Connection.Close();
                }

            }

        }
        public static void EliminarPartido(int id)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                conn.Open();

                string query = @"DELETE FROM partido WHERE id = @id";
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
