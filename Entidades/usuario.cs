using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class usuario
    {
        private string _dni;
        private string _login;
        private string _clave;
        private string _nombre_completo;
        private string _fecha_naci;
        private int _tipo;
        private string _fecha_registro;
        private int _estado;
       
        public string DNI
        { get { return _dni; } set { _dni = value; } }

        public string LOGIN
        { get { return _login; } set {_login = value; } }

        public string CLAVE
        { get { return _clave; } set { _clave = value; } }

        public string NOMBRE_COMPLETO
        { get { return _nombre_completo; } set { _nombre_completo = value; } }

        public string FECHA_NACI
        { get { return _fecha_naci; } set { _fecha_naci = value; } }

        public int TIPO
        { get { return _tipo; } set { _tipo = value; } }

        public string FECHA_REGISTRO
        { get { return _fecha_registro; } set { _fecha_registro = value; } }

        public int ESTADO
        { get { return _estado; } set { _estado = value; } }

        public usuario(string dni, string login, string clave, string nombre_completo, string fecha_naci, int tipo, string fecha_registro, int estado)
        {
            _dni = dni;
            _login = login;
            _clave = clave;
            _nombre_completo = nombre_completo;
            _fecha_naci = fecha_naci;
            _tipo = tipo;
            _fecha_registro = fecha_registro;
            _estado = estado;
                       
        }
    }
}
