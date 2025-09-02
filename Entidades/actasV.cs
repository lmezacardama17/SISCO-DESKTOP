using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class actasV
    {
        private int _id_mesa;
        private string _nro_mesa;
        private string _departamento;
        private string _provincia;
        private string _distrito;
        private int _total_habiles;
        private string _estado;

        public int ID_MESA
        { get { return _id_mesa; } set { _id_mesa = value; } }

        public string NRO_MESA
        { get { return _nro_mesa; } set { _nro_mesa = value; } }

        public string DEPARTAMENTO
        { get { return _departamento; } set { _departamento = value; } }

        public string PROVINCIA
        { get { return _provincia; } set { _provincia = value; } }

        public string DISTRITO
        { get { return _distrito; } set { _distrito = value; } }

        public int TOTAL_HABILES
        { get { return _total_habiles; } set { _total_habiles = value; } }

        public string ESTADO
        { get { return _estado; } set { _estado = value; } }
        public actasV(int id_mesa, string nro_mesa, string departamento, string provincia, string distrito, int total_habiles, string estado)
        {
            _id_mesa = id_mesa;
            _nro_mesa = nro_mesa;
            _departamento = departamento;
            _provincia = provincia;
            _distrito = distrito;
            _total_habiles = total_habiles;
            _estado = estado;
        }

    }
}
