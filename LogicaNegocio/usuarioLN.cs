using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class usuarioLN
    {
        public usuario validarUsuario(string login, string clave)
        {
            try
            {
                usuarioAD oUsuaAD = new usuarioAD();
                return oUsuaAD.validar(login, clave);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public usuario validarDNI(string dni)
        {
            try
            {
                usuarioAD oUsuario = new usuarioAD();
                return oUsuario.validarDNI(dni);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Insertar(string dni, string login, string clave, string nombre_completo, string fecha_naci, int tipo, string fecha_registro, int estado)
        {
            try
            {
                usuarioAD objUsua = new usuarioAD();
                objUsua.Insertar(dni, login, clave, nombre_completo, fecha_naci, tipo, fecha_registro, estado);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void CambiarClave(string dni, string claveNueva)
        {
            usuarioAD EdiUsuario = new usuarioAD();
            EdiUsuario.CambiarClave(dni, claveNueva);

        }
        public void eliminarUsuario(string dni)
        {
            try
            {
                usuarioAD oUsuarioAD = new usuarioAD();
                oUsuarioAD.eliminarUsuario(dni);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void ActualizarUsuario(string dni, string login, string nombre_completo, string fecha_naci, int tipo, int estado)
        {
            usuarioAD Actua = new usuarioAD();
            Actua.ActualizarUsuario(dni, login, nombre_completo, fecha_naci, tipo, estado);

        }
        public List<usuario> BusquedaUsuario(string dni, string nombre_completo)
        {
            try
            {
                usuarioAD oUsuarioAD = new usuarioAD();
                return oUsuarioAD.BusquedaUsuario(dni, nombre_completo);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
