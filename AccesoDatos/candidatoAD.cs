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
    public class candidatoAD
    {
        ConexionSQL oConexion = new ConexionSQL();

        public void Insertar(int id_partido, string nombre_completo, string tipo_candidato, string postula)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                oConexion.conectar();
                cmd.CommandText = "INSERT INTO candidato VALUES('" + id_partido + "','" + nombre_completo + "','" + tipo_candidato + "','"+ postula +"')";
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
