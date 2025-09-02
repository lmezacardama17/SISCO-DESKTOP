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
    public class ubprovinciaAD
    {
        ConexionSQL oConexion = new ConexionSQL();

        public List<ubprovincia> ListaAñidada(int selec_id_departamento)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "select p.idProv, p.provincia, p.idDepa  from ubprovincia p inner join ubdepartamento d on d.idDepa=p.idDepa where d.idDepa='" + selec_id_departamento + "'order by p.provincia";
                cmd.Connection = oConexion.conexion;
                oConexion.conexion.Open();
                SqlDataReader resultado = cmd.ExecuteReader();
                List<ubprovincia> coleccion = new List<ubprovincia>();
                while (resultado.Read())
                {
                    coleccion.Add(new ubprovincia(resultado.GetInt32(0), resultado.GetString(1), resultado.GetInt32(2)));
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
