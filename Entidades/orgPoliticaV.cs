using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class orgPoliticaV
    {
        private int _id_partido;
        private string _orgPolitica;
        //private string _logo;
        private int _total_provincia;
        private int _total_distrito;

        public int ID
        { get { return _id_partido; } set { _id_partido = value; } }
        
        public string ORGANIZACION_POLITICA
        { get { return _orgPolitica; } set { _orgPolitica = value; } }

        //public string LOGO
        //{ get { return _logo; } set { _logo = value; } }

        public int TOTAL_PROVINCIA
        { get { return _total_provincia; } set { _total_provincia = value; } }

        public int TOTAL_DISTRITO
        { get { return _total_distrito; } set { _total_distrito = value; } }

        public orgPoliticaV(int id_partido, string orgPolitica, int total_provincia, int total_distrito)
        {
            _id_partido = id_partido;
            _orgPolitica = orgPolitica;
            //_logo = logo;
            _total_provincia = total_provincia;
            _total_distrito = total_distrito;
        }
    }
}
