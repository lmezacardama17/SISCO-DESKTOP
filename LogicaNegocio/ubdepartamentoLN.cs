using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class ubdepartamentoLN
    {
        public List<ubdepartamento> Listado()
        {
            try
            {
                ubdepartamentoAD oDepa = new ubdepartamentoAD();
                return oDepa.Listado();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
