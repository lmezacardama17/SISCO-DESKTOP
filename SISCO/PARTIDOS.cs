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
using System.Drawing.Imaging;
using AccesoDatos;

namespace SISCO
{
    public partial class PARTIDOS : Form
    {
        public int id_proceso_electoral;
        internal int codigoPartidoseleccionado = -1;
        private string palabra = null;              
        public PARTIDOS()
        {
            InitializeComponent();
        }
        public void cargaCombobox()
        {
            DataTable dt;
            dt = proceso_electoralAD.ListaProcesoElectoral();
            cboxProceso.DataSource = dt;
            cboxProceso.DisplayMember = "descripcion";
            cboxProceso.ValueMember = "id";
            cboxProceso.SelectedValue = id_proceso_electoral;
        }
        private void cargar()
        {
            dgvPartidos.AutoGenerateColumns = false;
            dgvPartidos.DataSource = partidoAD.CargarListado();
            lblencontrados.Text = dgvPartidos.RowCount.ToString();
            foreach (DataGridViewRow row in dgvPartidos.Rows)
            {
                row.Height = 100;
                DataRowView rows = row.DataBoundItem as DataRowView;
                row.Cells["LOGO"].Value = ConvertirImagen.ByteArrayToImage((byte[])rows["logo"]);
            }
        }
        private void BuscarPartido()
        {
            palabra = Convert.ToString(txtBuscar.Text);
            dgvPartidos.AutoGenerateColumns = false;
            dgvPartidos.DataSource = partidoAD.BuscarListado(palabra);
            lblencontrados.Text = dgvPartidos.RowCount.ToString();            
            foreach (DataGridViewRow row in dgvPartidos.Rows)
            {
                row.Height = 100;
                DataRowView rows = row.DataBoundItem as DataRowView;
                row.Cells["LOGO"].Value = ConvertirImagen.ByteArrayToImage((byte[])rows["logo"]);
            }
        }
        private void txtNomPolitico_MouseEnter(object sender, EventArgs e)
        {
            if (txtNomPolitico.Text == "NOMBRE DE LA ORGANIZACION POLITICA")
            {
                txtNomPolitico.ResetText();
                txtNomPolitico.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtNomPolitico_MouseLeave(object sender, EventArgs e)
        {
            if (txtNomPolitico.Text == "")
            {
                txtNomPolitico.Text = "NOMBRE DE LA ORGANIZACION POLITICA";
                txtNomPolitico.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Archivo JPG|*.jpg";

            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
            }        
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sender = MessageBox.Show("DESEAR GUARDAR EL REGISTRO DEL PARTIDO POLITICO?", "Advertencia!", MessageBoxButtons.YesNo);

            if (sender.Equals(DialogResult.Yes))
            {
                if ((txtNomPolitico.Text == "NOMBRE DE LA ORGANIZACION POLITICA") || txtNomPolitico.Text.Equals(""))
                {
                    MessageBox.Show("RELLENE LOS CAMPOS POR FAVOR.", "Error!", MessageBoxButtons.OK);
                }
                else 
                {
                    partidoAD.Insertar(txtNomPolitico.Text, ConvertirImagen.ImageToByteArray(pictureBox1.Image), 0, Convert.ToInt32(ordentxt.Value), "ACTIVO");
                    MessageBox.Show("SE HA REGISTRADO CORRECTAMENTE.", "Aviso!", MessageBoxButtons.OK);
                    txtNomPolitico.ResetText();
                    pictureBox1.Image = null;
                    txtBuscar.Focus();
                    cargar();
                }
            }
            
        }
        private void PARTIDOS_Load(object sender, EventArgs e)
        {
            cargaCombobox();
        }
        private void txtBuscar_MouseEnter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "BUSCAR POR / NOMBRE  DE ORGANIZACION POLITICO")
            {
                txtBuscar.ResetText();
                txtBuscar.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtBuscar_MouseLeave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR / NOMBRE  DE ORGANIZACION POLITICO";
                txtBuscar.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            partidoAD.ActualizarPartido(txtNomPolitico.Text, ConvertirImagen.ImageToByteArray(pictureBox1.Image), Convert.ToInt32(ordentxt.Value), codigoPartidoseleccionado);
            MessageBox.Show("SE HA ACTUALIZADO CORRECTAMENTE.", "Aviso!", MessageBoxButtons.OK);
            txtNomPolitico.ResetText();
            pictureBox1.Image = null;
            btnActualizar.Visible = false;
            btnGuardar.Enabled = true;
            txtBuscar.Focus();
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarPartido();
        }
        private void PARTIDOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void dgvPartidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoPartidoseleccionado = Convert.ToInt32(this.dgvPartidos.CurrentRow.Cells["id"].Value);
            string estado_par = dgvPartidos.CurrentRow.Cells["estado"].Value.ToString();
            if (dgvPartidos.Columns[e.ColumnIndex].Name == "Cambiar")
            {
                sender = MessageBox.Show("DESEA CAMBIAR ESTADO DEL PARTIDO POLITICO ", "Mensaje!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sender.Equals(DialogResult.Yes))
                {
                    switch (estado_par)
                    {
                        case "ACTIVO":
                            partidoAD.ActualizarEstadoPartido("INACTIVO", codigoPartidoseleccionado);
                            MessageBox.Show("SE HA ACTUALIZADO CORRECTAMENTE!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargar();
                            break;
                        case "INACTIVO":
                            partidoAD.ActualizarEstadoPartido("" +
                                "ACTIVO", codigoPartidoseleccionado);
                            MessageBox.Show("SE HA ACTUALIZADO CORRECTAMENTE!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            cargar();
                            break;
                    }
                }
            }
            if (dgvPartidos.Columns[e.ColumnIndex].Name == "editar")
            {
                sender = MessageBox.Show("DESEA EDITAR EL PARTIDO POLITICO ", "Mensaje!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sender.Equals(DialogResult.Yes))
                {
                    txtNomPolitico.ResetText();
                    txtNomPolitico.Text = Convert.ToString(this.dgvPartidos.CurrentRow.Cells["nombre_politico"].Value);
                    pictureBox1.Image = ConvertirImagen.ByteArrayToImage((byte[])dgvPartidos.CurrentRow.Cells["logo"].Value);
                    ordentxt.Value = Convert.ToInt32(this.dgvPartidos.CurrentRow.Cells["orden"].Value);
                    btnActualizar.Visible = true;
                    btnGuardar.Enabled = false;
                }
                    
            }
            if (dgvPartidos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                sender = MessageBox.Show("DESEA ELIMINAR EL PARTIDO POLITICO ", "Mensaje!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sender.Equals(DialogResult.Yes))
                {
                    partidoAD.EliminarPartido(codigoPartidoseleccionado);
                    MessageBox.Show("SE HA ELIMINADO CORRECTAMENTE!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }
            }
            
        }
        private void dgvPartidos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string estado0;
            if (dgvPartidos.Columns[e.ColumnIndex].Name == "estado")
            {
                estado0 = dgvPartidos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                switch (estado0)
                {
                    case "INACTIVO":
                        dgvPartidos.Rows[e.RowIndex].Cells["estado"].ReadOnly = true;
                        dgvPartidos.Rows[e.RowIndex].Cells["estado"].Style.ForeColor = Color.Red;
                        break;
                    case "ACTIVO":
                        dgvPartidos.Rows[e.RowIndex].Cells["estado"].ReadOnly = true;
                        dgvPartidos.Rows[e.RowIndex].Cells["estado"].Style.ForeColor = Color.Green;
                        break;
                }

            }
        }
    }
}
