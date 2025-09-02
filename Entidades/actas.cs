using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class actas
    {
        private int _id;
        private string _descripcion;
        private int _id_mesa;
        private int _votos_blanco1;
        private int _votos_blanco2;
        private int _votos_nulos1;
        private int _votos_nulos2;
        private int _votos_inpugnados1;
        private int _votos_inpugnados2;
        private int _total_emitidos1;
        private int _total_emitidos2;

        public int ID
        { get { return _id; } set { _id = value; } }
        public string DESCRIPCION
        { get { return _descripcion; } set { _descripcion = value; } }
        public int ID_MESA
        { get { return _id_mesa; } set { _id_mesa = value; } }
        public int VOTOS_BLANCOS1
        { get { return _votos_blanco1; } set { _votos_blanco1 = value; } }
        public int VOTOS_BLANCOS2
        { get { return _votos_blanco2; } set { _votos_blanco2 = value; } }
        public int VOTOS_NULOS1
        { get { return _votos_nulos1; } set { _votos_nulos1 = value; } }
        public int VOTOS_NULOS2
        { get { return _votos_nulos2; } set { _votos_nulos2 = value; } }
        public int VOTOS_INPUGNADOS1
        { get { return _votos_inpugnados1; } set { _votos_inpugnados1 = value; } }
        public int VOTOS_INPUGNADOS2
        { get { return _votos_inpugnados2; } set { _votos_inpugnados2 = value; } }
        public int TOTAL_EMITIDOS1
        { get { return _total_emitidos1; } set { _total_emitidos1 = value; } }
        public int TOTAL_EMITIDOS2
        { get { return _total_emitidos2; } set { _total_emitidos2 = value; } }

        public actas(int id, string descripcion, int id_mesa, int votos_blanco1, int votos_blanco2, int votos_nulos1, int votos_nulos2, int votos_inpugnados1, int votos_inpugnados2, int total_emitidos1, int total_emitidos2)
        {
            _id = id;
            _descripcion = descripcion;
            _id_mesa = id_mesa;
            _votos_blanco1 = votos_blanco1;
            _votos_blanco2 = votos_blanco2;
            _votos_nulos1 = votos_nulos1;
            _votos_nulos2 = votos_nulos2;
            _votos_inpugnados1 = votos_inpugnados1;
            _votos_inpugnados2 = votos_inpugnados2;
            _total_emitidos1 = total_emitidos1;
            _total_emitidos2 = total_emitidos2;
        }

    }
}
