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
        internal int codigoPartidoseleccionado = -1;
        private string palabra = null;
              
        public PARTIDOS()
        {
            InitializeComponent();
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
            //partidoLN oPartidoLN = new partidoLN();
            //listaPartidos = oPartidoLN.BusquedaPartido(palabra);
            //dgvPartidos.DataSource = listaPartidos;
            //lblencontrados.Text = Convert.ToString(listaPartidos.Count.ToString());

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
                //txtNomPolitico.ForeColor = Color.DarkBlue;
            }
        }

        private void txtNomPolitico_MouseLeave(object sender, EventArgs e)
        {
            if (txtNomPolitico.Text == "")
            {
                txtNomPolitico.Text = "NOMBRE DE LA ORGANIZACION POLITICA";
                //txtNomPolitico.ForeColor = Color.DarkBlue;
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
                else {
                    partidoAD.Insertar(txtNomPolitico.Text, ConvertirImagen.ImageToByteArray(pictureBox1.Image), 0, Convert.ToInt32(ordentxt.Value));
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
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
           
             
        }

        private void txtBuscar_MouseEnter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "BUSCAR POR / NOMBRE  DE ORGANIZACION POLITICO")
            {
                txtBuscar.ResetText();
                //txtBuscar.ForeColor = Color.DarkBlue;
            }
        }
        private void txtBuscar_MouseLeave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR / NOMBRE  DE ORGANIZACION POLITICO";
                //txtBuscar.ForeColor = Color.DarkBlue;
            }
        }

        private void dgvPartidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            codigoPartidoseleccionado = Convert.ToInt32(this.dgvPartidos.CurrentRow.Cells["id"].Value);
            txtNomPolitico.ResetText();
            txtNomPolitico.Text = Convert.ToString(this.dgvPartidos.CurrentRow.Cells["nombre_politico"].Value);
            pictureBox1.Image = ConvertirImagen.ByteArrayToImage((byte[])dgvPartidos.CurrentRow.Cells["logo"].Value);
            ordentxt.Value = Convert.ToInt32(this.dgvPartidos.CurrentRow.Cells["orden"].Value);
            btnActualizar.Visible = true;
            btnGuardar.Enabled = false;

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

              

    }
}
