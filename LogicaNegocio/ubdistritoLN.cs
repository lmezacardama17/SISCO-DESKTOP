using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class ubdistritoLN
    {

        public List<ubdistrito> ListaAñidada(int selec_id_provincia)
        {
            try
            {
                ubdistritoAD oDistritoAD = new ubdistritoAD();
                return oDistritoAD.ListaAñidada(selec_id_provincia);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
