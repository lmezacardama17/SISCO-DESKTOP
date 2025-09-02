using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;

namespace SISCO
{
    public partial class REPORTE_MESAS : Form
    {
        private int selecionProv = 0;
        private int selecionDist = 0;
        private List<ubprovincia> lista = null;
        private List<ubdistrito> listaDistrito = null;
        public REPORTE_MESAS()
        {
            InitializeComponent();
        }
        public void CargaCombox()
        {
            List<string> tipo = new List<string>();
            tipo.Add("SELECCIONE..");
            tipo.Add("ACTA REGIONAL");
            tipo.Add("ACTA MUNICIPAL");
            cboxTipoActa.DataSource = tipo;

            ubdepartamentoLN objDepa = new ubdepartamentoLN();
            cboxDepartamento.DataSource = objDepa.Listado();
            cboxDepartamento.ValueMember = "idDepa";
            cboxDepartamento.DisplayMember = "departamento";
            cboxDepartamento.SelectedValue = 16;

            ubprovinciaLN objProvincia = new ubprovinciaLN();
            lista = objProvincia.ListaAñidada(16);
            cboxProvincia.DataSource = lista;
            cboxProvincia.ValueMember = "idProv";
            cboxProvincia.DisplayMember = "provincia";
            cboxProvincia.SelectedValue = 137;

            ubdistritoLN objDistrito = new ubdistritoLN();
            listaDistrito = objDistrito.ListaAñidada(137);
            cboxDistrito.DataSource = listaDistrito;
            cboxDistrito.ValueMember = "idDist";
            cboxDistrito.DisplayMember = "distrito";
        }
        private void REPORTE_MESAS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSetPrincipal.STP_MESASXCOLEGIOS' Puede moverla o quitarla según sea necesario.
            
            // TODO: esta línea de código carga datos en la tabla 'DSetPrincipal.Reporte_de_Mesas' Puede moverla o quitarla según sea necesario.
            
            List<string> estado = new List<string>();
            estado.Add("SELECCIONE..");
            estado.Add("REGISTRADO");
            estado.Add("VERIFICADO");
            estado.Add("SIN REGISTRAR");
            cboxEstado.DataSource = estado;

            ubdepartamentoLN objDepa = new ubdepartamentoLN();
            cboxDepa.DataSource = objDepa.Listado();
            cboxDepa.ValueMember = "idDepa";
            cboxDepa.DisplayMember = "departamento";
            cboxDepa.SelectedValue = 16;

            ubprovinciaLN objProvincia = new ubprovinciaLN();
            lista = objProvincia.ListaAñidada(16);
            cboxProv.DataSource = lista;
            cboxProv.ValueMember = "idProv";
            cboxProv.DisplayMember = "provincia";
            cboxProv.SelectedValue = 137;

            ubdistritoLN objDistrito = new ubdistritoLN();
            listaDistrito = objDistrito.ListaAñidada(137);
            cboxDist.DataSource = listaDistrito;
            cboxDist.ValueMember = "idDist";
            cboxDist.DisplayMember = "distrito";
            CargaCombox();
            //this.reportViewer1.RefreshReport();
        }

        private void cboxDepa_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selecionProv = Convert.ToInt32(cboxDepa.SelectedValue);

            ubprovinciaLN objProvincia = new ubprovinciaLN();
            lista = objProvincia.ListaAñidada(selecionProv);
            cboxProv.DataSource = lista;
            cboxProv.ValueMember = "idProv";
            cboxProv.DisplayMember = "provincia";
        }

        private void cboxProv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selecionDist = Convert.ToInt32(cboxProv.SelectedValue);

            ubdistritoLN objDistrito = new ubdistritoLN();
            listaDistrito = objDistrito.ListaAñidada(selecionDist);
            cboxDist.DataSource = listaDistrito;
            cboxDist.ValueMember = "idDist";
            cboxDist.DisplayMember = "distrito";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id_ubigeo = Convert.ToInt32(cboxDist.SelectedValue);
            string estado = Convert.ToString(cboxEstado.Text);
            this.Reporte_de_MesasTableAdapter.Fill(this.DSetPrincipal.Reporte_de_Mesas, id_ubigeo,estado);
            this.reportViewer1.RefreshReport();
            //this.Reporte_de_MesasTableAdapter.Fill(this.cboxDist.SelectedValue(), Convert.ToString(cboxEstado.Text));
        }

        private void btnBuscarCOL_Click(object sender, EventArgs e)
        {
            int id_ubigeo = Convert.ToInt32(cboxDistrito.SelectedValue);
            string tipo = Convert.ToString(cboxTipoActa.Text);
            this.STP_MESASXCOLEGIOSTableAdapter.Fill(this.DSetPrincipal.STP_MESASXCOLEGIOS,tipo, id_ubigeo);
            this.reportViewer2.RefreshReport();
        }
    }
}
