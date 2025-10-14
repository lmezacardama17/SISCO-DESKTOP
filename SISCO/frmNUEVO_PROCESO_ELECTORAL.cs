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
    public partial class frmNUEVO_PROCESO_ELECTORAL : Form
    {
        public int id_proceso_electoral;
        public frmNUEVO_PROCESO_ELECTORAL()
        {
            InitializeComponent();
        }
        public void guardarProceso(object sender)
        {
            sender = MessageBox.Show("DESEA REGISTRAR EL PROCESO ELECTORAL?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sender.Equals(DialogResult.Yes))
            {
                if (txtproceso.Text.Equals("") || dtpAnoProceso.Text.Equals("") || cboxTipoProceso.SelectedItem == null || dgvTipoActa.CurrentRow == null)
                {
                    MessageBox.Show("RELLENE LA CAMPOS OBLIGATORIOS!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    DataTable dty, dtx;
                    dty = proceso_electoralAD.validarProcesoElectoral(cboxTipoProceso.Text, dtpAnoProceso.Text);
                    if (dty.Rows.Count > 0)
                    {
                        MessageBox.Show("PROCESO ELECTORAL YA REGISTRADO EN EL SISTEMA SISCO!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        DateTime fecha_r = DateTime.Now.ToLocalTime();
                        proceso_electoralAD.Insertar(txtproceso.Text, dtpAnoProceso.Text, fecha_r, cboxTipoProceso.Text, "ACTIVO");
                        dtx = proceso_electoralAD.validarProcesoElectoral(cboxTipoProceso.Text, dtpAnoProceso.Text);
                        if (dtx.Rows.Count > 0) { foreach (DataRow row in dtx.Rows) { id_proceso_electoral = Convert.ToInt32(row[0].ToString()); } }

                        foreach (DataGridViewRow filita in dgvTipoActa.Rows)
                        {
                            int id_tipo_acta_e;
                            id_tipo_acta_e = Convert.ToInt32(filita.Cells["id"].Value.ToString());

                            proceso_electoralAD.InsertarDetalle(id_proceso_electoral, id_tipo_acta_e);
                        }
                        MessageBox.Show("SE HA REGISTRADO CORRECTAMENTE!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    }
                }
            }
             
        }
        public void CargaCombobox()
        {
            List<string> tipoActa = new List<string>();
            tipoActa.Add("NACIONAL");
            tipoActa.Add("REGIONAL");
            cboxTipoProceso.DataSource = tipoActa;
        }
        private void frmNUEVO_PROCESO_ELECTORAL_Load(object sender, EventArgs e)
        {
            CargaCombobox();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void frmNUEVO_PROCESO_ELECTORAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void cboxTipoProceso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string seleccionTipo = cboxTipoProceso.Text;

            dgvTipoActa.AutoGenerateColumns = false;
            dgvTipoActa.Rows.Clear();
            DataTable dx = tipo_actasAD.ListaTipoActaProceso(seleccionTipo);
            if (dx.Rows.Count>0)
            {
                btnEntrar.Enabled = true;
                string id_e, desc_e, tipo_e, esta_e;
                foreach (DataRow fila in dx.Rows)
                {
                    id_e = fila[0].ToString();
                    desc_e = fila[1].ToString();
                    tipo_e = fila[2].ToString();
                    esta_e = fila[3].ToString();

                    dgvTipoActa.Rows.Add(id_e, desc_e, tipo_e, esta_e);
                }
                
            }
            else
            {
                MessageBox.Show("TIPO DE PROCESO NO TIENE ACTAS REGISTRADAS!","Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnEntrar.Enabled = false;
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            guardarProceso(sender);
        }
        private void dgvTipoActa_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string estado1;
            if (dgvTipoActa.Columns[e.ColumnIndex].Name == "estado")
            {
                estado1 = dgvTipoActa.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                switch (estado1)
                {
                    case "INACTIVO":
                        dgvTipoActa.Rows[e.RowIndex].Cells["estado"].ReadOnly = true;
                        dgvTipoActa.Rows[e.RowIndex].Cells["estado"].Style.ForeColor = Color.Red;
                        break;
                    case "ACTIVO":
                        dgvTipoActa.Rows[e.RowIndex].Cells["estado"].ReadOnly = true;
                        dgvTipoActa.Rows[e.RowIndex].Cells["estado"].Style.ForeColor = Color.Green;
                        break;                   
                }

            }
        }
    }
}
