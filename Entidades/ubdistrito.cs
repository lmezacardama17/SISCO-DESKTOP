using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ubdistrito
    {
        private int _iddist;
        private string _distrito;
        private int _idprov;

        public int IDDIST
        { get { return _iddist; } set { _iddist = value; } }

        public string DISTRITO
        { get { return _distrito; } set { _distrito = value; } }

        public int IDPROV
        { get { return _idprov; } set { _idprov = value; } }

        public ubdistrito(int iddist, string distrito, int idprov)
        {
            _iddist = iddist;
            _distrito = distrito;
            _idprov = idprov;
        }
    }
}
