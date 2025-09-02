using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class ubdistritoAD
    {
        ConexionSQL oConexion = new ConexionSQL();

        public List<ubdistrito> ListaAñidada(int selec_id_provincia)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "select d.idDist, d.distrito, d.idProv  from ubdistrito d inner join ubprovincia p on p.idProv=d.idProv where d.idProv='" + selec_id_provincia + "'order by d.distrito";
                cmd.Connection = oConexion.conexion;
                oConexion.conexion.Open();
                SqlDataReader resultado = cmd.ExecuteReader();
                List<ubdistrito> coleccion = new List<ubdistrito>();
                while (resultado.Read())
                {
                    coleccion.Add(new ubdistrito(resultado.GetInt32(0), resultado.GetString(1), resultado.GetInt32(2)));
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
