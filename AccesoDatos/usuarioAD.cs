using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace AccesoDatos
{
      public class usuarioAD
    {
        ConexionSQL oConexion = new ConexionSQL();
        public usuario validar(string login, string clave)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "SELECT dni, login, clave, nombre_completo, fecha_naci, tipo, fecha_registro, estado FROM usuario WHERE (login = '" + login + "') AND (clave = '" + clave + "')";
                cmd.Connection = oConexion.conexion;
                oConexion.conexion.Open();
                SqlDataReader resultado = cmd.ExecuteReader();
                usuario oUsuario = null;
                while (resultado.Read())
                {
                    oUsuario = new usuario(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2), resultado.GetString(3), resultado.GetString(4),resultado.GetInt32(5),resultado.GetString(6),resultado.GetInt32(7));
                }
                return oUsuario;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public usuario validarDNI(string dni)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "SELECT dni, login, clave, nombre_completo, fecha_naci, tipo, fecha_registro, estado FROM usuario WHERE dni ='" + dni + "'";
                cmd.Connection = oConexion.conexion;
                oConexion.conexion.Open();
                SqlDataReader resultado = cmd.ExecuteReader();
                usuario oUsuario = null;
                while (resultado.Read())
                {
                    oUsuario = new usuario(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2), resultado.GetString(3), resultado.GetString(4), resultado.GetInt32(5), resultado.GetString(6), resultado.GetInt32(7));
                }
                return oUsuario;
            }
            catch (Exception ex)
            {
                cmd.Connection.Close();
                throw new Exception(ex.Message);
            }
        }
        public void Insertar(string dni, string login, string clave, string nombre_completo, string fecha_naci, int tipo, string fecha_registro, int estado)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "INSERT INTO usuario VALUES('" + dni + "','" + login + "','" + clave + "','" + nombre_completo + "','" + fecha_naci + "','" + tipo + "','" + fecha_registro + "','" + estado + "')";
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
        public void CambiarClave(string dni, string claveNueva)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "UPDATE usuario SET clave = '" + claveNueva + "' WHERE dni = '" + dni + "' ";
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
        public void eliminarUsuario(string dni)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "DELETE FROM usuario WHERE dni = '" + dni + "'";
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

        public void ActualizarUsuario(string dni, string login, string nombre_completo, string fecha_naci, int tipo, int estado)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "UPDATE usuario SET dni = '" + dni + "', login = '" + login + "', nombre_completo = '" + nombre_completo + "', fecha_naci = '" + fecha_naci + "', tipo = '" + tipo + "', estado = '" + estado + "'  WHERE dni = '" + dni + "' ";
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
        public List<usuario> BusquedaUsuario(string dni, string nombre_completo)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "select dni, login, clave, nombre_completo, fecha_naci, tipo, fecha_registro, estado from usuario where ((dni like '" + dni + "%') or ( nombre_completo like '" + nombre_completo + "%'))";
                cmd.Connection = oConexion.conexion;
                oConexion.conexion.Open();
                SqlDataReader resultado = cmd.ExecuteReader();
                List<usuario> coleccion = new List<usuario>();
                while (resultado.Read())
                {
                    coleccion.Add(new usuario(resultado.GetString(0), resultado.GetString(1), resultado.GetString(2), resultado.GetString(3), resultado.GetString(4), resultado.GetInt32(5), resultado.GetString(6), resultado.GetInt32(7)));
                }
                return coleccion;
            }
            catch (Exception ex)
            {
                cmd.Connection.Close();
                throw new Exception(ex.Message);
            }
        }

        
    }
}
