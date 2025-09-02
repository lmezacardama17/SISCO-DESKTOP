using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class mesasLN
    {
        public List<mesas> BusquedaMesas(string nro_mesa, string estado)
        {
            try
            {
                mesasAD oMesasAD = new mesasAD();
                return oMesasAD.BusquedaMesas(nro_mesa, estado);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public actasV BusquedaActasxMesas(string nro_mesa, string tipo_acta)
        {
            try
            {
                mesasAD omesasAD = new mesasAD();
                return omesasAD.BusquedaActasxMesas(nro_mesa, tipo_acta);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Insertar(int id_ubigeo, string numero, string institucion, string direccion, int total_habiles, string tipo, string estado)
        {
            try
            {
                mesasAD objMesasAD = new mesasAD();
                objMesasAD.Insertar(id_ubigeo, numero, institucion, direccion, total_habiles,tipo, estado);
             
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public mesas validarMesa(string numero, string tipo)
        {
            try
            {
                mesasAD oMesaAD = new mesasAD();
                return oMesaAD.validarMesa(numero, tipo);
 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void CambiarEstadoMesa(string estado, int id_mesa)
        {
            mesasAD oMesaAD = new mesasAD();
            oMesaAD.CambiarEstadoMesa(estado, id_mesa);
        }

    }
}
