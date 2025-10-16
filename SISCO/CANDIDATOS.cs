using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaNegocio;
using AccesoDatos;

namespace SISCO
{
    public partial class CANDIDATOS : Form
    {
        public int id_proceso_electoral, id_candidato_selec;
        string tipo_proceso_candidato = "";
        public CANDIDATOS()
        {
            InitializeComponent();
        }
        public void buscarCandidato()
        {
            dgvCandidato.AutoGenerateColumns = false;
            dgvCandidato.DataSource = candidatoAD.BuscarListadoCandidato(id_proceso_electoral, txtBuscar.Text);
            lblencontrados.Text = dgvCandidato.RowCount.ToString();
            foreach (DataGridViewRow row in dgvCandidato.Rows)
            {
                row.Height = 100;
                DataRowView rows = row.DataBoundItem as DataRowView;
                row.Cells["LOGO"].Value = ConvertirImagen.ByteArrayToImage((byte[])rows["logo"]);
            }
        }
        public void cargaCombobox()
        {
            DataTable dt;
            dt = proceso_electoralAD.ListaProcesoElectoralCandidato(id_proceso_electoral);
            cboxProceso.DataSource = dt;
            cboxProceso.DisplayMember = "descripcion";
            cboxProceso.ValueMember = "id";
            //cboxProceso.SelectedValue = id_proceso_electoral;

            cboxPartido.DataSource = partidoAD.CargarListado();
            cboxPartido.ValueMember = "id";
            cboxPartido.DisplayMember = "nombre_politico";

            foreach (DataRow row in dt.Rows)
            {
                tipo_proceso_candidato = row[4].ToString();
            }
            switch (tipo_proceso_candidato)
            {
                case "REGIONAL":
                    List<string> TipoList = new List<string>();
                    TipoList.Add("<SELECIONE..>");
                    TipoList.Add("CANDIDATO REGIONAL");
                    TipoList.Add("CANDIDATO PROVINCIAL");
                    TipoList.Add("CANDIDATO DISTRITAL");
                    cboxTipoCandidato.DataSource = TipoList;
                    break;
                case "NACIONAL":
                    List<string> TipoList2 = new List<string>();
                    TipoList2.Add("<SELECIONE..>");
                    TipoList2.Add("CANDIDATO PRESIDENCIAL");
                    TipoList2.Add("CANDIDATO CONGRESAL");
                    TipoList2.Add("CANDIDATO SENADOR");
                    TipoList2.Add("CANDIDATO DIPUTADO");
                    TipoList2.Add("CANDIDATO PARLAMENTO");
                    cboxTipoCandidato.DataSource = TipoList2;
                    break;
            }     

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sender = MessageBox.Show("DESEA GUARDAR EL REGISTRO DEL CANDIDATO.?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sender.Equals(DialogResult.Yes))
            {
                if ((txtLiderPolitico.Text == "NOMBRE COMPLETO DEL CANDIDATO") || (txtLiderPolitico.Text.Equals("")) || (txtLugarPostula.Text == "NOMBRE REGION / PROVINCIA / DISTRITO A POSTULAR") || (txtLugarPostula.Text.Equals("")))
                {
                    MessageBox.Show("Rellene los campos Por Favor.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    candidatoLN candidatoLN = new candidatoLN();
                    candidatoLN.Insertar(Convert.ToInt32(cboxProceso.SelectedValue), Convert.ToInt32(cboxPartido.SelectedValue), txtLiderPolitico.Text, cboxTipoCandidato.Text, txtLugarPostula.Text);
                    MessageBox.Show("SE HA REGISTRADO CORRECTAMENTE", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtLiderPolitico.Text = "NOMBRE COMPLETO DEL CANDIDATO";
                    txtLugarPostula.Text = "NOMBRE REGION / PROVINCIA / DISTRITO A POSTULAR";
                    buscarCandidato();
                }
            }
                
        }
        private void CANDIDATOS_Load(object sender, EventArgs e)
        {
            cargaCombobox();
            
        }
        private void txtLiderPolitico_MouseEnter(object sender, EventArgs e)
        {
            if (txtLiderPolitico.Text == "NOMBRE COMPLETO DEL CANDIDATO")
            {
                txtLiderPolitico.ResetText();
                txtLiderPolitico.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtLugarPostula_MouseEnter(object sender, EventArgs e)
        {
            if (txtLugarPostula.Text == "NOMBRE REGION / PROVINCIA / DISTRITO A POSTULAR")
            {
                txtLugarPostula.ResetText();
                txtLugarPostula.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtLiderPolitico_MouseLeave(object sender, EventArgs e)
        {
            if (txtLiderPolitico.Text == "")
            {
                txtLiderPolitico.Text = "NOMBRE COMPLETO DEL CANDIDATO";
                txtLiderPolitico.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtLugarPostula_MouseLeave(object sender, EventArgs e)
        {
            if (txtLugarPostula.Text == "")
            {
                txtLugarPostula.Text = "NOMBRE REGION / PROVINCIA / DISTRITO A POSTULAR";
                txtLugarPostula.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void CANDIDATOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void txtBuscar_MouseLeave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR / NOMBRE  DEL CANDIDATO";
                txtBuscar.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtBuscar_MouseEnter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "BUSCAR POR / NOMBRE  DEL CANDIDATO")
            {
                txtBuscar.ResetText();
                txtBuscar.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            buscarCandidato();
        }
        private void dgvCandidato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_candidato_selec = Convert.ToInt32(this.dgvCandidato.CurrentRow.Cells["id"].Value);
            if (dgvCandidato.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                sender = MessageBox.Show("DESEA ELIMINAR EL CANDIDATO POLITICO ", "Mensaje!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sender.Equals(DialogResult.Yes))
                {
                    candidatoAD.EliminarCandidato(id_candidato_selec);
                    MessageBox.Show("SE HA ELIMINADO CORRECTAMENTE!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buscarCandidato();
                }
            }
        }
    }
}
