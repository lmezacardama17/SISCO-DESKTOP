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
    public partial class frmEDITAR_PROCESO_ELECTORAL : Form
    {
        public int id_proceso_electoral;
        public string select_tipo_proceso = "";

        public frmEDITAR_PROCESO_ELECTORAL()
        {
            InitializeComponent();
        }
        public void CargaProcesoElectoral()
        {
            DataTable dty, dtz;

            dty = proceso_electoralAD.CargaProcesoElectoralCabecera(id_proceso_electoral);
            if (dty.Rows.Count > 0)
            {
                foreach (DataRow row in dty.Rows)
                {
                    txtproceso.Text = row[1].ToString();
                    txtano.Text = row[2].ToString();

                    select_tipo_proceso = row[4].ToString();

                    dtz = proceso_electoralAD.CargaProcesoElectoralDetalle(id_proceso_electoral);
                    foreach (DataRow row1 in dtz.Rows)
                    {
                        string id_e, des_e, tip_e, esta_e;
                        id_e = row1[1].ToString();
                        des_e = row1[2].ToString();
                        tip_e = row1[3].ToString();
                        esta_e = row1[4].ToString();

                        dgvTipoActa.Rows.Add(id_e, des_e, tip_e, esta_e);
                    }
                }

            }
            else
            {
                MessageBox.Show("EL PROCESO ELECTORAL NO CUENTA CON DETALLE!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            List<string> tipoActa = new List<string>();
            tipoActa.Add("NACIONAL");
            tipoActa.Add("REGIONAL");
            cboxTipoProceso.DataSource = tipoActa;
            cboxTipoProceso.SelectedItem = select_tipo_proceso;

        }        
        private void frmEditarPROCESO_ELECTORAL_Load(object sender, EventArgs e)
        {
           CargaProcesoElectoral();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmEDITAR_PROCESO_ELECTORAL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            sender = MessageBox.Show("DESEA EDITAR EL PROCESO ELECTORAL?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sender.Equals(DialogResult.Yes))
            {
                DateTime fecha_r = DateTime.Now.ToLocalTime();
                proceso_electoralAD.ActualizarPorcesoElectotalCabecera(txtproceso.Text, txtano.Text, fecha_r, cboxTipoProceso.Text, id_proceso_electoral);
                foreach (DataGridViewRow filita in dgvTipoActa.Rows)
                {
                    int id_tipo_acta_e;
                    id_tipo_acta_e = Convert.ToInt32(filita.Cells["id"].Value.ToString());

                    proceso_electoralAD.InsertarDetalle(id_proceso_electoral, id_tipo_acta_e);
                }
                MessageBox.Show("SE HA REGISTRADO CORRECTAMENTE!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
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
        private void cboxTipoProceso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            sender = MessageBox.Show("DESEA CAMBIAR TIPO DE PROCESO ELECTORAL?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (sender.Equals(DialogResult.Yes))
            {
                proceso_electoralAD.EliminarPorcesoElectotalDetalle(id_proceso_electoral);
                string seleccionTipo = cboxTipoProceso.Text;

                dgvTipoActa.AutoGenerateColumns = false;
                dgvTipoActa.Rows.Clear();
                DataTable dx = tipo_actasAD.ListaTipoActaProceso(seleccionTipo);
                if (dx.Rows.Count > 0)
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
                    MessageBox.Show("TIPO DE PROCESO NO TIENE ACTAS REGISTRADAS!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEntrar.Enabled = false;
                }
            }            
            
        }
    }
}
