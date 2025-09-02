using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class mesas
    {
        private int _id;
        private int _id_ubigeo;
        private string _numero;
        private string _institucion;
        private string _direccion;
        private int _total_habiles;
        private string _tipo;
        private string _estado;

        public int ID
        { get { return _id; } set { _id = value; } }

        public int ID_UBIGEO
        { get { return _id_ubigeo; } set { _id_ubigeo = value; } }

        public string NUMERO
        { get { return _numero; } set { _numero = value; } }

        public string INSTITUCION
        { get { return _institucion; } set { _institucion = value; } }

        public string DIRECCION
        { get { return _direccion; } set { _direccion = value; } }

        public int TOTAL_HABILES
        { get { return _total_habiles; } set { _total_habiles = value; } }

        public string TIPO
        { get { return _tipo; } set { _tipo = value; } }

        public string ESTADO
        { get { return _estado; } set { _estado = value; } }
        public mesas(int id, int id_ubigeo, string numero, string institucion, string direccion, int total_habiles, string tipo, string estado)
        {
            _id = id;
            _id_ubigeo = id_ubigeo;
            _numero = numero;
            _institucion = institucion;
            _direccion = direccion;
            _total_habiles = total_habiles;
            _tipo = tipo;
            _estado = estado;
        }

    }
}