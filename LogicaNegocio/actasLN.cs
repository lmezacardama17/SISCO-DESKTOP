using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class actasLN
    {
        public int devuelveNroReg()
        {
            try
            {
                actasAD oActasAD = new actasAD();
                return oActasAD.devuelveNroReg();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Insertar(string descripcion, int id_mesa, int votos_blanco1, int votos_blanco2, int votos_nulos1, int votos_nulos2, int votos_inpugnados1, int votos_inpugnados2, int total_emitidos1, int total_emitidos2)
        {
            try
            {
                actasAD objActasAD = new actasAD();
                objActasAD.Insertar(descripcion, id_mesa, votos_blanco1, votos_blanco2, votos_nulos1, votos_nulos2, votos_inpugnados1, votos_inpugnados2, total_emitidos1, total_emitidos2);
                
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
