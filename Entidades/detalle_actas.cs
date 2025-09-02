using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class detalle_actas
    {
        private int _id_acta;
        private int _id_partido;
        private int _total_votos1;
        private int _total_votos2;

        public int ID_ACTA
        { get { return _id_acta; } set { _id_acta = value; } }
        public int ID_PARTIDO
        { get { return _id_partido; } set { _id_partido = value; } }
        public int TOTAL_VOTOS1
        { get { return _total_votos1; } set { _total_votos1 = value; } }
        public int TOTAL_VOTOS2
        { get { return _total_votos2; } set { _total_votos2 = value; } }

        public detalle_actas(int id_acta, int id_partido, int total_votos1, int total_votos2)
        {
            _id_acta = id_acta;
            _id_partido = id_partido;
            _total_votos1 = total_votos1;
            _total_votos2 = total_votos2;
        }
    }
}
