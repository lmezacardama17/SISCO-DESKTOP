using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ubprovincia
    {
        private int _idprov;
        private string _provincia;
        private int _iddepa;

        public int IDPROV
        { get { return _idprov; } set { _idprov = value; } }

        public string PROVINCIA
        { get { return _provincia; } set { _provincia = value; } }

        public int IDDEPA
        { get { return _iddepa; } set { _iddepa = value; } }

        public ubprovincia(int idprov, string provincia, int iddepa)
        {
            _idprov = idprov;
            _provincia = provincia;
            _iddepa = iddepa;
        }

    }
}
