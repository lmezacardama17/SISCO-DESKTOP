using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop;
using System.Text.RegularExpressions;
using Entidades;
using LogicaNegocio;
using AccesoDatos;

namespace SISCO
{
    public partial class MESAS : Form
    {
        public int id_proceso_electoral, doc = 0, existeMesa = 0, selecionProv = 0, selecionDist = 0;
        private List<ubprovincia> lista = null;
        private List<ubdistrito> listaDistrito = null;
        private List<mesas> listaMesas = null;
        private string palabra = null;
        string regional = "ACTA REGIONAL";
        string municipal = "ACTA MUNICIPAL";
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        public MESAS()
        {
            InitializeComponent();
        }
        public void CargaCombobox()
        {
            DataTable dt, dtx;
            dt = proceso_electoralAD.ListaProcesoElectoralCandidato(id_proceso_electoral);
            cboxProceso.DataSource = dt;
            cboxProceso.DisplayMember = "descripcion";
            cboxProceso.ValueMember = "id";

            dtx = mesasAD.CargarTipoMesaProcesoElectoral(id_proceso_electoral);
            cboxTipoMesa.DataSource = dtx;
            cboxTipoMesa.DisplayMember = "descripcion";
            cboxTipoMesa.ValueMember = "id";

            ubdepartamentoLN objDepa = new ubdepartamentoLN();
            cboxDepartamento.DataSource = objDepa.Listado();
            cboxDepartamento.ValueMember = "idDepa";
            cboxDepartamento.DisplayMember = "departamento";
            btnExaminar.Enabled = false;
        }
        private void MESAS_Load(object sender, EventArgs e)
        {
            CargaCombobox();

        }
        private void cboxDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selecionProv = Convert.ToInt32(cboxDepartamento.SelectedValue);

            ubprovinciaLN objProvincia = new ubprovinciaLN();
            lista = objProvincia.ListaAñidada(selecionProv);
            cboxProvincia.DataSource = lista;
            cboxProvincia.ValueMember = "idProv";
            cboxProvincia.DisplayMember = "provincia";
            cboxProvincia.Enabled = true;
        }
        private void cboxProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
            selecionDist = Convert.ToInt32(cboxProvincia.SelectedValue);
            ubdistritoLN objDistrito = new ubdistritoLN();
            listaDistrito = objDistrito.ListaAñidada(selecionDist);
            cboxDistrito.DataSource = listaDistrito;
            cboxDistrito.ValueMember = "idDist";
            cboxDistrito.DisplayMember = "distrito";
            cboxDistrito.Enabled = true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (chkCargaMasiva.Checked==true) 
            {
                sender = MessageBox.Show("DESEA GUARDAR LA MIGRACION DEL ARCHIVO EXCEL A LA BD DE MESAS DE VOTACION.?", "Advertencia!", MessageBoxButtons.YesNo);
                if (sender.Equals(DialogResult.Yes)) {
                    if (dgvMesas.DataSource == null)
                    {
                        MessageBox.Show("CARGUE DATA PARA IMPORTAR POR FAVOR.", "Error!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        mesasLN objMesasLN = new mesasLN();
                        foreach (DataGridViewRow row in dgvMesas.Rows)
                        {
                            int id_ubigeo = Convert.ToInt32(row.Cells[0].Value.ToString());
                            string numero = row.Cells[1].Value.ToString();
                            string institucion = row.Cells[2].Value.ToString();
                            string direccion = row.Cells[3].Value.ToString();
                            int total_habiles = Convert.ToInt32(row.Cells[4].Value.ToString());
                            string tipo = row.Cells[5].Value.ToString();
                            string estado = "SIN REGISTRAR";
                            objMesasLN.Insertar(id_ubigeo, numero, institucion, direccion, total_habiles, tipo, estado);
                        }
                      
                        MessageBox.Show("SE HA IMPORTADO CORRECTAMENTE.", "Aviso!", MessageBoxButtons.OK);
                        dgvMesas.DataSource = null;
                    }
                }
            }
            else
            {
                sender = MessageBox.Show("DESEAR GUARDAR EL REGISTRO DE MESA DE VOTACION.?", "Advertencia!", MessageBoxButtons.YesNo);
                if (sender.Equals(DialogResult.Yes))
                {
                    if ((txtNroMesa.Text == "NUMERO DE MESA") || (txtnomColegio.Text == "INSTITUCION / COLEGIO") || (txtDireLugar.Text == "DIRECCION / LUGAR DE LA MESA DE VOTACION") || (txtNroVotantes.Text == "NUMERO DE VOTANTES HABILES"))
                    {
                        MessageBox.Show("RELLENE LOS CAMPOS POR FAVOR.", "Error!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        mesas objMesas;
                        mesasLN oMesasLN1 = new mesasLN();
                        objMesas = oMesasLN1.validarMesa(txtNroMesa.Text, cboxTipoMesa.Text);
                        if(objMesas!=null){
                            existeMesa = 1;
                            MessageBox.Show("El NRO DE MESA YA EXISTE EN LA BASE DE DATOS. ", "Aviso!", MessageBoxButtons.OK);
                            txtNroMesa.ResetText();
                            txtnomColegio.ResetText();
                            txtDireLugar.ResetText();
                            txtNroVotantes.ResetText();
                            txtNroMesa.Focus();
                        }else
                        {
                            if (regional == Convert.ToString(cboxTipoMesa.SelectedValue))
                            {
                                mesasLN oMesasLN = new mesasLN();
                                string estado = "SIN REGISTRAR";
                                oMesasLN.Insertar(Convert.ToInt32(cboxDistrito.SelectedValue), txtNroMesa.Text, txtnomColegio.Text, txtDireLugar.Text, Convert.ToInt32(txtNroVotantes.Text), Convert.ToString(cboxTipoMesa.Text), estado);
                                MessageBox.Show("SE HA REGISTRADO CORRECTAMENTE", "Aviso!", MessageBoxButtons.OK);
                                txtNroMesa.ResetText();
                                txtnomColegio.ResetText();
                                txtDireLugar.ResetText();
                                txtNroVotantes.ResetText();
                                txtNroMesa.Focus();

                            }
                            else if (municipal == Convert.ToString(cboxTipoMesa.SelectedValue))
                            {
                                mesasLN oMesasLN = new mesasLN();
                                string estado = "SIN REGISTRAR";
                                oMesasLN.Insertar(Convert.ToInt32(cboxDistrito.SelectedValue), txtNroMesa.Text, txtnomColegio.Text, txtDireLugar.Text, Convert.ToInt32(txtNroVotantes.Text), Convert.ToString(cboxTipoMesa.Text), estado);
                                MessageBox.Show("SE HA REGISTRADO CORRECTAMENTE.", "Aviso!", MessageBoxButtons.OK);
                                txtNroMesa.ResetText();
                                txtnomColegio.ResetText();
                                txtDireLugar.ResetText();
                                txtNroVotantes.ResetText();
                                txtNroMesa.Focus();
                            }
                            else
                            {
                                MessageBox.Show("NO SE PUEDE REGISTRAR OTRO TIPO DE NRO MESA.", "Aviso!", MessageBoxButtons.OK);
                                txtBuscarMesa.Focus();
                            }
                        
                        }
                        
                    }
                }
            }
           
        }
        private void txtNroMesa_MouseEnter(object sender, EventArgs e)
        {
            if (txtNroMesa.Text == "NUMERO DE MESA")
            {
                txtNroMesa.ResetText();
                txtNroMesa.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtnomColegio_MouseEnter(object sender, EventArgs e)
        {
            if (txtnomColegio.Text == "INSTITUCION / COLEGIO")
            {
                txtnomColegio.ResetText();
                txtnomColegio.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtDireLugar_MouseEnter(object sender, EventArgs e)
        {
            if (txtDireLugar.Text == "DIRECCION / LUGAR DE LA MESA DE VOTACION")
            {
                txtDireLugar.ResetText();
                txtDireLugar.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtNroVotantes_MouseEnter(object sender, EventArgs e)
        {
            if (txtNroVotantes.Text == "NUMERO DE VOTANTES HABILES")
            {
                txtNroVotantes.ResetText();
                txtNroVotantes.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (txtBuscarMesa.Text == "BUSCAR NUMEROS DE MESA")
            {
                txtBuscarMesa.ResetText();
                txtBuscarMesa.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtNroMesa_MouseLeave(object sender, EventArgs e)
        {
            if (txtNroMesa.Text == "")
            {
                txtNroMesa.Text = "NUMERO DE MESA";
                txtNroMesa.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtnomColegio_MouseLeave(object sender, EventArgs e)
        {
            if (txtnomColegio.Text == "")
            {
                txtnomColegio.Text = "INSTITUCION / COLEGIO";
                txtnomColegio.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtDireLugar_MouseLeave(object sender, EventArgs e)
        {
            if (txtDireLugar.Text == "")
            {
                txtDireLugar.Text = "DIRECCION / LUGAR DE LA MESA DE VOTACION";
                txtDireLugar.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtNroVotantes_MouseLeave(object sender, EventArgs e)
        {
            if (txtNroVotantes.Text == "")
            {
                txtNroVotantes.Text = "NUMERO DE VOTANTES HABILES";
                txtNroVotantes.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtBuscarMesa_MouseLeave(object sender, EventArgs e)
        {
            if (txtBuscarMesa.Text == "")
            {
                txtBuscarMesa.Text = "BUSCAR NUMEROS DE MESA";
                txtBuscarMesa.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void btnExaminar_Click(object sender, EventArgs e)
        {
            dgvMesas.DataSource = null;
            openFileDialog1.Filter = "XML Files (*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb) |*.xml; *.xls; *.xlsx; *.xlsm; *.xlsb";//open file format define Excel Files(.xls)|*.xls| Excel Files(.xlsx)|*.xlsx|
            openFileDialog1.FilterIndex = 3;
            openFileDialog1.Multiselect = false;        //not allow multiline selection at the file selection level
            openFileDialog1.Title = "Open Text File-R13";   //define the name of openfileDialog
            openFileDialog1.InitialDirectory = @"Desktop";
            openFileDialog1.ShowDialog();
        }

        private void txtNroVotantes_TextChanged(object sender, EventArgs e)
        {
            try
            {
                doc = Convert.ToInt32(txtNroVotantes.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtNroVotantes.ResetText();
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string filePath = openFileDialog1.FileName;
            string extension = Path.GetExtension(filePath);
            string header = "SI";
            string conStr, sheetName;

            conStr = string.Empty;
            switch (extension)
            {

                case ".xls": //Excel 97-03
                    conStr = string.Format(Excel03ConString, filePath, header);
                    break;

                case ".xlsx": //Excel 07
                    conStr = string.Format(Excel07ConString, filePath, header);
                    break;
            }

            //Get the name of the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    con.Open();
                    DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                    con.Close();
                }
            }

            //Read Data from the First Sheet.
            using (OleDbConnection con = new OleDbConnection(conStr))
            {
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    using (OleDbDataAdapter oda = new OleDbDataAdapter())
                    {
                        DataTable dt = new DataTable();
                        cmd.CommandText = "SELECT * From [" + sheetName + "]";
                        cmd.Connection = con;
                        con.Open();
                        oda.SelectCommand = cmd;
                        oda.Fill(dt);
                        con.Close();
                        dgvMesas.DataSource = dt;
                        lblAgregados.Text = Convert.ToString(dt.Rows.Count);
                                              
                    }
                }
            }
        }

        private void txtBuscarMesa_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void chkCargaMasiva_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCargaMasiva.Checked == true)
            {                
                cboxTipoMesa.Enabled = false;
                cboxDepartamento.Enabled = false;
                btnExaminar.Enabled = true;
            }
            else 
            {
                CargaCombobox();
                cboxTipoMesa.Enabled = true;
                cboxDepartamento.Enabled = true;
                btnExaminar.Enabled = false;
            }       
        }
        private void MESAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            palabra = Convert.ToString(txtBuscarMesa.Text);
            mesasLN oMesasLN = new mesasLN();
            listaMesas = oMesasLN.BusquedaMesas(palabra, palabra);
            dgvMesas.DataSource = listaMesas;
            lblAgregados.Text = Convert.ToString(listaMesas.Count.ToString());
        }
    }
}
