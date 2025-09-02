using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace LogicaNegocio
{
    public class candidatoLN
    {
        public void Insertar(int id_partido, string nombre_completo, string tipo_candidato, string postula)
        {
            try
            {
                candidatoAD objCandiAD = new candidatoAD();
                objCandiAD.Insertar(id_partido, nombre_completo, tipo_candidato, postula);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
