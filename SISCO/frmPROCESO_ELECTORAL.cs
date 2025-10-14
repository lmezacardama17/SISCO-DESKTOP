using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace SISCO
{
    public partial class frmPROCESO_ELECTORAL : Form
    {
        public int id_tipo_user; 
        public string nombre_completo, dni_user;
        Form1 oFormulario = new Form1();
        public frmPROCESO_ELECTORAL()
        {
            InitializeComponent();
        }
        public void CargaCombobox()
        {
            DataTable dt;
            dt = proceso_electoralAD.ListaProcesoElectoral();
            cboxProceso.DataSource = dt;
            cboxProceso.DisplayMember = "descripcion";
            cboxProceso.ValueMember = "id";
        }
        public void IngresarProceso(object sender)
        {
            sender = MessageBox.Show("DESEA INGRESAR AL PROCESO ELECTORAL?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sender.Equals(DialogResult.Yes))
            {
                DataTable dtx;
                dtx = proceso_electoralAD.validarProcesoElectoralIngreso(Convert.ToInt32(cboxProceso.SelectedValue), dtpFechaIngreso.Text);
                if (dtx.Rows.Count > 0)
                {
                    this.Hide();
                    string fecha = Convert.ToString(System.DateTime.Now.ToLocalTime());
                    switch (id_tipo_user)
                    {
                        case 1:
                            MessageBox.Show("ERES UN ADMINISTRADOR!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case 2:
                            MessageBox.Show("ERES UN USUARIO!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            oFormulario.btnSeguridad.Visible = false;
                            oFormulario.btnReportes.Visible = false;
                            break;
                        default:
                            MessageBox.Show("ERES UN USUARIO OPERADOR!", "OK!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            oFormulario.btnSeguridad.Visible = false;
                            oFormulario.btnReportes.Visible = false;
                            oFormulario.btnCandidatos.Visible = false;
                            oFormulario.Partidos.Visible = false;
                            oFormulario.btnMesas.Visible = false;
                            break;
                    }
                    oFormulario.lblUsuario.Text = nombre_completo;
                    oFormulario.lblFechaIngreso.Text = fecha;
                    oFormulario.id_proceso_electoral = Convert.ToInt32(cboxProceso.SelectedValue);
                    oFormulario.dni_user = dni_user;
                    oFormulario.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("NO EXISTE PROCESO ELECTORAL DEL AÑO SELECCIONADO!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmProcesoElectoral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            IngresarProceso(sender);
        }
        private void frmPROCESO_ELECTORAL_Load(object sender, EventArgs e)
        {
            CargaCombobox();
        }
    }
}
