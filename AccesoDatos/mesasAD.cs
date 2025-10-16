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
using Entidades;

namespace AccesoDatos
{
    public class mesasAD
    {
        ConexionSQL oConexion = new ConexionSQL();

        public static DataTable ValidarMesaProcesoElectoral(int id_proceso_electoral)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"select * from proceso_electoral pl inner join mesa m on m.id_proceso_electoral=pl.id where pl.id='"+id_proceso_electoral+"'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public static DataTable CargarTipoMesaProcesoElectoral(int id_proceso_electoral)
        {
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SISCO.Properties.Settings.SISCOConnectionString"].ToString()))
            {
                DataTable dt = new DataTable();
                string query = @"select    ta.id,
	                                       ta.descripcion,
	                                       ta.estado 
                                    from detalle_proceso_electoral dpe
                                    inner join tipo_acta ta on dpe.id_tipo_acta=ta.id
                                    where dpe.id_proceso_electoral='" + id_proceso_electoral + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adap = new SqlDataAdapter(cmd);
                adap.Fill(dt);
                return dt;
            }
        }
        public List<mesas> BusquedaMesas(string nro_mesa, string estado)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "select id, id_ubigeo, numero, institucion, direccion, total_habiles, tipo, estado from mesa where (numero like '" + nro_mesa + "%') or (estado like '" + estado +"%')";
                cmd.Connection = oConexion.conexion;
                oConexion.conexion.Open();
                SqlDataReader resultado = cmd.ExecuteReader();
                List<mesas> coleccion = new List<mesas>();
                while (resultado.Read())
                {
                    coleccion.Add(new mesas(resultado.GetInt32(0), resultado.GetInt32(1), resultado.GetString(2), resultado.GetString(3), resultado.GetString(4), resultado.GetInt32(5),resultado.GetString(6),resultado.GetString(7)));
                }
                return coleccion;
            }
            catch (Exception ex)
            {
                cmd.Connection.Close();
                throw new Exception(ex.Message);
            }
        }
        public actasV BusquedaActasxMesas(string nro_mesa, string tipo_acta)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "select m.id, m.numero, dep.departamento, p.provincia, d.distrito, m.total_habiles, m.estado from mesa m inner join ubdistrito d on m.id_ubigeo=d.idDist inner join ubprovincia p on d.idProv=p.idProv inner join ubdepartamento dep on p.idDepa=dep.idDepa where (m.numero = '" + nro_mesa + "') and (m.tipo = '" + tipo_acta + "')";
                cmd.Connection = oConexion.conexion;
                oConexion.conexion.Open();
                SqlDataReader resultado = cmd.ExecuteReader();
                actasV oActasV = null;
                while (resultado.Read())
                {
                    oActasV = new actasV(resultado.GetInt32(0), resultado.GetString(1), resultado.GetString(2), resultado.GetString(3), resultado.GetString(4), resultado.GetInt32(5),resultado.GetString(6));
                }
                return oActasV;
            }
            catch (Exception ex)
            {
                cmd.Connection.Close();
                throw new Exception(ex.Message);
            }
        }
        public void Insertar(int id_ubigeo, string numero, string institucion, string direccion, int total_habiles, string tipo, string estado)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "INSERT INTO mesa VALUES('" + id_ubigeo + "','" + numero + "','" + institucion + "','" + direccion + "','" + total_habiles + "','" + tipo + "','"+ estado +"')";
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
        public mesas validarMesa(string numero, string tipo)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "select * from mesa m where m.numero ='" + numero + "' and  m.tipo ='" + tipo + "' ";
                cmd.Connection = oConexion.conexion;
                oConexion.conexion.Open();
                SqlDataReader resultado = cmd.ExecuteReader();
                mesas oMesas = null;
                while (resultado.Read())
                {
                    oMesas = new mesas(resultado.GetInt32(0), resultado.GetInt32(1), resultado.GetString(2), resultado.GetString(3), resultado.GetString(4), resultado.GetInt32(5),resultado.GetString(6),resultado.GetString(7));
                }
                return oMesas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstadoMesa(string estado, int id_mesa)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "UPDATE mesa SET estado = '" + estado + "' WHERE id = '" + id_mesa + "' ";
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
    }
}
