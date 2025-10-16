using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class candidato
    {
        private int _id;
        private int _id_proceso_electoral;
        private int _id_partido;
        private string _nombre_completo;
        private string _tipo_candidato;
        private string _postula;

        public int ID
        { get { return _id; } set { _id = value; } }

        public int ID_PROCESO_ELECTORAL
        { get { return _id_proceso_electoral; } set { _id_proceso_electoral = value; } }

        public int ID_PARTIDO
        { get { return _id_partido; } set { _id_partido = value; } }

        public string  NOMBRE_COMPLETO
        { get { return _nombre_completo; } set { _nombre_completo = value; } }

        public string TIPO_CANDIDATO
        { get { return _tipo_candidato; } set { _tipo_candidato = value; } }

        public string POSTULA
        { get { return _postula; } set { _postula = value; } }

        public candidato(int id, int id_proceso_electoral, int id_partido, string nombre_completo, string tipo_candidato, string postula)
        {
            _id = id;
            _id_proceso_electoral = id_proceso_electoral;
            _id_partido = id_partido;
            _nombre_completo = nombre_completo;
            _tipo_candidato = tipo_candidato;
            _postula = postula;
        }


    }
}
