using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class detalle_actasLN
    {
        public void Insertar(int id_acta, int id_partido, int total_votos1, int total_votos2)
        {

            try
            {

                detalle_actasAD objdetalle_ActasAD = new detalle_actasAD();
                objdetalle_ActasAD.Insertar(id_acta, id_partido, total_votos1, total_votos2);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
