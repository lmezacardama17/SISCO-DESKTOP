using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ubdepartamento
    {
        private int _iddepa;
        private string _departamento;

        public int IDDEPA
        { get { return _iddepa; } set { _iddepa = value; } }

        public string DEPARTAMENTO
        { get { return _departamento; } set { _departamento = value; } }

        public ubdepartamento(int iddepa, string departamento)
        {
            _iddepa = iddepa;
            _departamento = departamento;
          
        }
    }
}
