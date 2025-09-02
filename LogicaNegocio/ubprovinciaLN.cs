using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class ubprovinciaLN
    {
        public List<ubprovincia> ListaAñidada(int selec_id_departamento)
        {
            try
            {
                ubprovinciaAD oProv = new ubprovinciaAD();
                return oProv.ListaAñidada(selec_id_departamento);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
