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
    public partial class REPORTE_ACTAS : Form
    {
        private int selecionProv = 0;
        private int selecionDist = 0;
        private List<ubprovincia> lista = null;
        private List<ubdistrito> listaDistrito = null;
        public REPORTE_ACTAS()
        {
            InitializeComponent();
        }

        private void REPORTE_ACTAS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DSetPrincipal.Reporte_x_Actas_x_Partido' Puede moverla o quitarla según sea necesario.
            //this.Reporte_x_Actas_x_PartidoTableAdapter.Fill(this.DSetPrincipal.Reporte_x_Actas_x_Partido);
            // TODO: esta línea de código carga datos en la tabla 'DSetPrincipal.Reporte_x_Actas_x_Partido' Puede moverla o quitarla según sea necesario.
            //List<string> estado = new List<string>();
            //estado.Add("SELECCIONE..");
            //estado.Add("ACTA MUNICIPAL");
            //estado.Add("ACTA REGIONAL");
            //cboxEstado.DataSource = estado;
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
            this.Reporte_x_Actas_x_PartidoTableAdapter.Fill(this.DSetPrincipal.Reporte_x_Actas_x_Partido, id_ubigeo);
            this.reportViewer1.RefreshReport();
        }
    }
}
