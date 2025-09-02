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
        public CANDIDATOS()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sender = MessageBox.Show("DESEA GUARDAR EL REGISTRO DEL CANDIDATO.?", "Advertencia!", MessageBoxButtons.YesNo);
            if (sender.Equals(DialogResult.Yes))
            {
                if ((txtLiderPolitico.Text == "NOMBRE COMPLETO DEL CANDIDATO") || (txtLiderPolitico.Text.Equals("")) || (txtLugarPostula.Text == "NOMBRE REGION / PROVINCIA / DISTRITO A POSTULAR") || (txtLugarPostula.Text.Equals("")))
                {
                    MessageBox.Show("Rellene los campos Por Favor.", "Error!", MessageBoxButtons.OK);
                }
                else
                {
                    candidatoLN candidatoLN = new candidatoLN();
                    candidatoLN.Insertar(Convert.ToInt32(cboxPartido.SelectedValue), txtLiderPolitico.Text, cboxTipoCandidato.Text, txtLugarPostula.Text);
                    MessageBox.Show("SE HA REGISTRADO CORRECTAMENTE", "Aviso!", MessageBoxButtons.OK);
                    txtLiderPolitico.Text = "NOMBRE COMPLETO DEL CANDIDATO";
                    txtLugarPostula.Text = "NOMBRE REGION / PROVINCIA / DISTRITO A POSTULAR";
                }
            }
                
        }

        private void CANDIDATOS_Load(object sender, EventArgs e)
        {
            List<string> TipoList = new List<string>();
            TipoList.Add("<SELECIONE..>");
            TipoList.Add("CANDIDATO REGIONAL");
            TipoList.Add("CANDIDATO PROVINCIAL");
            TipoList.Add("CANDIDATO DISTRITAL");
            cboxTipoCandidato.DataSource = TipoList;

            cboxPartido.DataSource = partidoAD.CargarListado();
            cboxPartido.ValueMember = "id";
            cboxPartido.DisplayMember = "nombre_politico";
        }

        private void txtLiderPolitico_MouseEnter(object sender, EventArgs e)
        {
            if (txtLiderPolitico.Text == "NOMBRE COMPLETO DEL CANDIDATO")
            {
                txtLiderPolitico.ResetText();
                //txtLiderPolitico.ForeColor = Color.DarkBlue;
            }
        }

        private void txtLugarPostula_MouseEnter(object sender, EventArgs e)
        {
            if (txtLugarPostula.Text == "NOMBRE REGION / PROVINCIA / DISTRITO A POSTULAR")
            {
                txtLugarPostula.ResetText();
                //txtLugarPostula.ForeColor = Color.DarkBlue;
            }
        }

        private void txtLiderPolitico_MouseLeave(object sender, EventArgs e)
        {
            if (txtLiderPolitico.Text == "")
            {
                txtLiderPolitico.Text = "NOMBRE COMPLETO DEL CANDIDATO";
                //txtLiderPolitico.ForeColor = Color.DarkBlue;
            }
        }

        private void txtLugarPostula_MouseLeave(object sender, EventArgs e)
        {
            if (txtLugarPostula.Text == "")
            {
                txtLugarPostula.Text = "NOMBRE REGION / PROVINCIA / DISTRITO A POSTULAR";
                //txtLugarPostula.ForeColor = Color.DarkBlue;
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
    }
}
