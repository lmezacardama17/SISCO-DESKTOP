using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class ubdepartamentoAD
    {
        ConexionSQL oConexion = new ConexionSQL();

        public List<ubdepartamento> Listado()
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "SELECT idDepa, departamento from ubdepartamento order by departamento";
                cmd.Connection = oConexion.conexion;
                oConexion.conexion.Open();
                SqlDataReader resultado = cmd.ExecuteReader();
                List<ubdepartamento> coleccion = new List<ubdepartamento>();
                while (resultado.Read())
                {
                    coleccion.Add(new ubdepartamento(resultado.GetInt32(0), resultado.GetString(1)));
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
