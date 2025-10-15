using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Entidades
{
    public class partido
    {
        private int _id;
        private string _nombre_politico;
        private byte[] _logo;
        private int _dato;
        private int _orden;
        private string _estado;
      
        public int ID
        { get { return _id; } set { _id = value; } }

        public string NOMBRE_POLITICO
        { get { return _nombre_politico; } set { _nombre_politico = value; } }

        public byte[] LOGO
        { get { return _logo; } set { _logo = value; } }

        public int DATO
        { get { return _dato; } set { _dato = value; } }
        public int ORDEN
        { get { return _orden; } set { _orden = value; } }
        public string ESTADO
        { get { return _estado; } set { _estado = value; } }
        public partido(int id, string nombre_politico, byte[] logo, int dato, int orden, string estado)
        {
            _id = id;
            _nombre_politico = nombre_politico;
            _logo = logo;
            _dato = dato;
            _orden = orden;
            _estado = estado;
        }
    }
}
