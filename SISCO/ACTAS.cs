using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MEP.Windows.Controls;
using AccesoDatos;
using Entidades;
using LogicaNegocio;

namespace SISCO
{
    public partial class ACTAS : Form
    {
        public int id_proceso_electoral;
        private int doc = 0;
        string regional = "ACTA REGIONAL";
        string municipal = "ACTA MUNICIPAL";
        int codigoSeleccionado=-1;
        int codigoSeleccionado1 = -1;
        private string palabra = null;
        int total_Automatico_ProvincialR = 0;
        int total_Automatico_DistritalR = 0;
        int total_Automatico_ProvincialM = 0;
        int total_Automatico_DistritalM = 0;
        private List<orgPoliticaV> listaPartidos = null;
        private List<orgPoliticaV> listaPartidos1 = null;
        private int existeNroMesa = 0;
        public int id_acta_regional = 0, id_acta_municipal = 0;
        public ACTAS()
        {
            InitializeComponent();
        }
        private void CargarPartidoRegional()
        {
            dgvOrganizacionRegional.AutoGenerateColumns = false;
            dgvOrganizacionRegional.DataSource = partidoAD.ListaOrganizacionRegional();

            foreach (DataGridViewRow row in dgvOrganizacionRegional.Rows)
            {
                row.Height = 100;
                DataRowView rows = row.DataBoundItem as DataRowView;
                row.Cells["LOGO"].Value = ConvertirImagen.ByteArrayToImage((byte[])rows["logo"]);
            }
        }
        private void CabecerRegional()
        {
            DataTable cabReg;
            cabReg = actasAD.CargaCabecerRegional(txtNroVotacion.Text, cboxTipoMesa.Text);
            if(cabReg.Rows.Count!=0)
            {
                foreach (DataRow row in cabReg.Rows)
                {
                    if (cboxTipoMesa.Text =="ACTA REGIONAL" || tabControl1.SelectedTab == tabPage1)
                    {
                        lblverificadoRegional.Visible = true; lblverificadoRegional.Text = "VERIFICADO";

                        txtVotosBlancoPRegional.Text = row[2].ToString();
                        txtVotosBlancoDRegional.Text = row[3].ToString();

                        txtVotosNulosPRegional.Text = row[6].ToString();
                        txtVotosNulosDRegional.Text = row[7].ToString();

                        txtVotosInpugPRegional.Text = row[4].ToString();
                        txtVotosInpugDRegional.Text = row[5].ToString();

                        txtTotalVotosEmiPRegional.Text = row[0].ToString();
                        txtTotalVotosEmiDRegional.Text = row[1].ToString();
                    }
                    else if (cboxTipoMesa.Text =="ACTA MUNICIPAL" || tabControl1.SelectedTab == tabPage3)
                    {
                        lblVerificadoMunicipal.Visible = true; lblVerificadoMunicipal.Text = "VERIFICADO";

                        txtvblancoP.Text = row[2].ToString();
                        txtvBlancoD.Text = row[3].ToString();

                        txtvNulosP.Text = row[6].ToString();
                        txtvNulosD.Text = row[7].ToString();

                        txtinpugnadosP.Text = row[4].ToString();
                        txtvInpugnadosD.Text = row[5].ToString();

                        txtTotalEmitidosP.Text = row[0].ToString();
                        txtvEmitidosD.Text = row[1].ToString();
                    }
                    
                }
                
            }
            else
            {
                MessageBox.Show(" NO EXISTE DATOS DE CABECERA.", "Aviso!", MessageBoxButtons.OK);
            }
        }
        private void CargarPartidoRegionalVerficado()
        {
            dgvOrganizacionRegional.AutoGenerateColumns = false;
            dgvOrganizacionRegional.DataSource = partidoAD.ListaOrganizacionRegionalVERIFICADO(txtNroVotacion.Text, cboxTipoMesa.Text);

            foreach (DataGridViewRow row in dgvOrganizacionRegional.Rows)
            {
                row.Height = 100;
                DataRowView rows = row.DataBoundItem as DataRowView;
                row.Cells["LOGO"].Value = ConvertirImagen.ByteArrayToImage((byte[])rows["logo"]);
            }
        }
        private void CargarPartidoMunicipalVerificado()
        {
            DataTable dtt;
            int id_acta_verificado = 0;
            
            dtt = actasAD.ValidarIdActa(txtNroVotacion.Text, cboxTipoMesa.Text);
            foreach(DataRow row in dtt.Rows)
            {
                id_acta_verificado = Convert.ToInt32(row[0].ToString());
            }
            dgvOrganizacion.AutoGenerateColumns = false;
            dgvOrganizacion.DataSource = partidoAD.ListaOrganizacionMunicipalVERIFICADO(id_acta_verificado);
            foreach (DataGridViewRow row in dgvOrganizacion.Rows)
            {
                row.Height = 100;
                DataRowView rows = row.DataBoundItem as DataRowView;
                row.Cells["LOGO1"].Value = ConvertirImagen.ByteArrayToImage((byte[])rows["logo1"]);
                string valor = "SIN CANDIDATO";
                if (valor == Convert.ToString(row.Cells["PROV"].Value))
                {
                    row.Cells["VOTOPROV"].ReadOnly = true;
                    row.Cells["VOTOPROV"].Style.BackColor = Color.DarkRed;
                }
                else if (valor == Convert.ToString(row.Cells["DISTR"].Value))
                {
                    row.Cells["VOTODISTR"].ReadOnly = true;
                    row.Cells["VOTODISTR"].Style.BackColor = Color.DarkRed;
                }

            }
        }
        private void CargarPartidoMunicipal()
        {
            dgvOrganizacion.AutoGenerateColumns = false;
            dgvOrganizacion.DataSource = partidoAD.ListaOrganizacionMunicipal();

            foreach (DataGridViewRow row in dgvOrganizacion.Rows)
            {
                row.Height = 100;
                DataRowView rows = row.DataBoundItem as DataRowView;
                row.Cells["LOGO1"].Value = ConvertirImagen.ByteArrayToImage((byte[])rows["logo1"]);
                string valor  = "SIN CANDIDATO";
                if (valor == Convert.ToString(row.Cells["PROV"].Value))
                {
                    row.Cells["VOTOPROV"].ReadOnly = true;
                    row.Cells["VOTOPROV"].Style.BackColor = Color.FromArgb(1,99,174);
                }
                else if (valor == Convert.ToString(row.Cells["DISTR"].Value))
                {
                    row.Cells["VOTODISTR"].ReadOnly = true;
                    row.Cells["VOTODISTR"].Style.BackColor = Color.FromArgb(1,99,174);
                }
                
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNroVotacion.Text == "ESCRIBIR NRO MESA DE VOTACION" || txtNroVotacion.Text.Equals("") || cboxTipoMesa.Text == "SELECCIONE..")
            {
                MessageBox.Show("ESCRIBE UN NRO DE MESA VALIDOS y/o SELECCIONE TIPO DE ACTA ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNroVotacion.ResetText();
                dgvOrganizacion.DataSource = null;
                txtNroVotacion.Focus();
            }
            else
            {
                palabra = Convert.ToString(txtNroVotacion.Text);
                actasV objActasV;
                mesasLN objMesaLN = new mesasLN();
                objActasV = objMesaLN.BusquedaActasxMesas(palabra, Convert.ToString(cboxTipoMesa.Text));
                if (objActasV != null)
                {
                    existeNroMesa = 1;
                    switch (objActasV.ESTADO)
                    {
                        case "REGISTRADO":
                            MessageBox.Show("EL NRO DE MESA " + palabra + " YA SE ENCUENTRA REGISTRADO! ", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        case "VERIFICADO":
                            MessageBox.Show(" EL NRO DE MESA DE SUFRAGIO " + palabra + " FALTA SU VERIFICACION.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            switch (cboxTipoMesa.Text)
                            {
                                case "ACTA REGIONAL":
                                    tabControl1.SelectedTab = tabPage1;
                                    lblNroMesaRegional.Text = objActasV.NRO_MESA;
                                    lblDeparRegional.Text = objActasV.DEPARTAMENTO;
                                    lblProvRegional.Text = objActasV.PROVINCIA;
                                    lblDistrRegional.Text = objActasV.DISTRITO;
                                    lblTotalElectoresRegional.Text = Convert.ToString(objActasV.TOTAL_HABILES);
                                    CargarPartidoRegionalVerficado();
                                    CabecerRegional();
                                    dgvOrganizacionRegional.CurrentCell = dgvOrganizacionRegional.Rows[0].Cells[4];
                                    dgvOrganizacionRegional.BeginEdit(true);
                                    break;
                                case "ACTA MUNICIPAL":
                                    tabControl1.SelectedTab = tabPage3;
                                    break;
                            }
                            //if (tabControl1.SelectedTab == tabPage1)
                            //{
                            //    lblNroMesaRegional.Text = objActasV.NRO_MESA;
                            //    lblDeparRegional.Text = objActasV.DEPARTAMENTO;
                            //    lblProvRegional.Text = objActasV.PROVINCIA;
                            //    lblDistrRegional.Text = objActasV.DISTRITO;
                            //    lblTotalElectoresRegional.Text = Convert.ToString(objActasV.TOTAL_HABILES);
                            //    CargarPartidoRegionalVerficado();
                            //    CabecerRegional();
                            //    dgvOrganizacionRegional.CurrentCell = dgvOrganizacionRegional.Rows[0].Cells[4];
                            //    dgvOrganizacionRegional.BeginEdit(true);
                            //}
                            //else if (tabControl1.SelectedTab == tabPage3)
                            //{
                            //    lblNroMesa.Text = objActasV.NRO_MESA;
                            //    lblDepartamento.Text = objActasV.DEPARTAMENTO;
                            //    lblProvincia.Text = objActasV.PROVINCIA;
                            //    lblDistrito.Text = objActasV.DISTRITO;
                            //    lblTotalElectores.Text = Convert.ToString(objActasV.TOTAL_HABILES);
                            //    CargarPartidoMunicipalVerificado();
                            //    CabecerRegional();
                            //    dgvOrganizacion.CurrentCell = dgvOrganizacion.Rows[0].Cells[6];
                            //    dgvOrganizacion.BeginEdit(true);

                            //}
                            break;
                        case "SIN REGISTRAR":
                            MessageBox.Show(" EL NRO DE MESA DE SUFRAGIO " + palabra + " EXISTE EN LA BASE DE DATOS.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            if (tabControl1.SelectedTab == tabPage1)
                            {
                                lblNroMesaRegional.Text = objActasV.NRO_MESA;
                                lblDeparRegional.Text = objActasV.DEPARTAMENTO;
                                lblProvRegional.Text = objActasV.PROVINCIA;
                                lblDistrRegional.Text = objActasV.DISTRITO;
                                lblTotalElectoresRegional.Text = Convert.ToString(objActasV.TOTAL_HABILES);

                                CargarPartidoRegional();
                                dgvOrganizacionRegional.CurrentCell = dgvOrganizacionRegional.Rows[0].Cells[4];
                                dgvOrganizacionRegional.BeginEdit(true);


                            }
                            else if (tabControl1.SelectedTab == tabPage3)
                            {
                                lblNroMesa.Text = objActasV.NRO_MESA;
                                lblDepartamento.Text = objActasV.DEPARTAMENTO;
                                lblProvincia.Text = objActasV.PROVINCIA;
                                lblDistrito.Text = objActasV.DISTRITO;
                                lblTotalElectores.Text = Convert.ToString(objActasV.TOTAL_HABILES);

                                CargarPartidoMunicipal();
                                dgvOrganizacion.CurrentCell = dgvOrganizacion.Rows[0].Cells[6];
                                dgvOrganizacion.BeginEdit(true);

                            }
                            break;
                    }                   
                }
                else
                {
                    MessageBox.Show("EL NRO DE MESA NO EXISTE EN LA BASE DE DATOS.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNroVotacion.ResetText();
                    dgvOrganizacion.DataSource = null;
                    txtNroVotacion.Focus();
                }
            }
            

        }
        private void ACTAS_Load(object sender, EventArgs e)
        {
            txtNroVotacion.Focus();
            List<string> TipoMesa = new List<string>();
            TipoMesa.Add("SELECCIONE..");
            TipoMesa.Add("ACTA REGIONAL");
            TipoMesa.Add("ACTA MUNICIPAL");
            cboxTipoMesa.DataSource = TipoMesa;
            
        }
        private void txtNroVotacion_MouseEnter(object sender, EventArgs e)
        {
            if (txtNroVotacion.Text == "ESCRIBIR NRO MESA DE VOTACION")
            {
                txtNroVotacion.ResetText();
                //txtNroVotacion.ForeColor = Color.DarkBlue;
            }
        }
        private void txtNroVotacion_MouseLeave(object sender, EventArgs e)
        {
            if (txtNroVotacion.Text == "")
            {
                txtNroVotacion.Text = "ESCRIBIR NRO MESA DE VOTACION";
                //txtNroVotacion.ForeColor = Color.DarkBlue;
            }
        }
        private void cboxTipoMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (regional == Convert.ToString(cboxTipoMesa.Text))
            {
                tabControl1.Visible = true;
                tabPage1.Parent = tabControl1;
                tabControl1.SelectedTab = tabPage1; 
            }
            else if (municipal == Convert.ToString(cboxTipoMesa.Text))
            {
                tabControl1.Visible = true;
                tabPage3.Parent = tabControl1;
                tabControl1.SelectedTab = tabPage3;
            }
            else
            {
                tabControl1.Visible = false;
                tabPage1.Parent = null;
                tabPage3.Parent = null;
            }
        }
        private void txtNroVotacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                this.btnBuscar.PerformClick();
            }
        }
        private void ACTAS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void dgvOrganizacion_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{UP}");
            SendKeys.Send("{TAB}");
            int Total_provincial = 0;
            int Total_distrital = 0;
            foreach (DataGridViewRow row in dgvOrganizacion.Rows)
            {
                Total_provincial += Convert.ToInt32(row.Cells[6].Value); 
                Total_distrital += Convert.ToInt32(row.Cells[7].Value);
            }
            total_Automatico_ProvincialM = Total_provincial;
            total_Automatico_DistritalM = Total_distrital;
        }
        private void txtvblancoP_TextChanged(object sender, EventArgs e)
         {
            try
            {
                doc = Convert.ToInt32(txtvblancoP.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtvblancoP.ResetText();
                }
            }
        }
        private void txtvNulosP_TextChanged(object sender, EventArgs e)
         {
            try
            {
                doc = Convert.ToInt32(txtvNulosP.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtvNulosP.ResetText();
                }
            }
        }
        private void txtinpugnadosP_TextChanged(object sender, EventArgs e)
         {
            try
            {
                doc = Convert.ToInt32(txtinpugnadosP.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtinpugnadosP.ResetText();
                }
            }
        }
        private void txtTotalEmitidosP_TextChanged(object sender, EventArgs e)
         {
            try
            {
                doc = Convert.ToInt32(txtTotalEmitidosP.Text);
                int doc1 = Convert.ToInt32(txtvblancoP.Text);
                int doc2 = Convert.ToInt32(txtvNulosP.Text);
                int doc3 = Convert.ToInt32(txtinpugnadosP.Text);
                int suma = 0;
                suma = doc1 + doc2 + doc3;
                int total = suma + total_Automatico_ProvincialM;
                txtTotalAutomaticoP.Text = Convert.ToString(total);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtTotalEmitidosP.ResetText();
                }
            }
        }
        private void txtvBlancoD_TextChanged(object sender, EventArgs e)
         {
            try
            {
                doc = Convert.ToInt32(txtvBlancoD.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtvBlancoD.ResetText();
                }
            }
        }
        private void txtvNulosD_TextChanged(object sender, EventArgs e)
         {
            try
            {
                doc = Convert.ToInt32(txtvNulosD.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtvNulosD.ResetText();
                }
            }

        }
        private void txtvInpugnadosD_TextChanged(object sender, EventArgs e)
         {
            try
            {
                doc = Convert.ToInt32(txtvInpugnadosD.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtvInpugnadosD.ResetText();
                }
            }
        }
        private void txtvEmitidosD_TextChanged(object sender, EventArgs e)
         {
            try
            {
                doc = Convert.ToInt32(txtvEmitidosD.Text);
                int docu1 = Convert.ToInt32(txtvBlancoD.Text);
                int docu2 = Convert.ToInt32(txtvNulosD.Text);
                int docu3 = Convert.ToInt32(txtvInpugnadosD.Text);
                int suma1 = 0;
                suma1 = docu1 + docu2 + docu3;
                int total1 = suma1 + total_Automatico_DistritalM;
                txtTotalAutomaticoD.Text = Convert.ToString(total1);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtvEmitidosD.ResetText();
                }
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            sender = MessageBox.Show("DESEA GUARDAR EL REGISTRO DEL ACTA DE VOTACION.?", "Advertencia!", MessageBoxButtons.YesNo);
            if (sender.Equals(DialogResult.Yes)) {
                if ((txtvblancoP.Text.Equals("")) || (txtvNulosP.Text.Equals("")) || (txtinpugnadosP.Text.Equals("")) || (txtTotalEmitidosP.Text.Equals("")))
                {
                    MessageBox.Show("RELLENE LOS DATOS POR FAVOR.", "Error!", MessageBoxButtons.OK);
                }
                else
                {
                    mesas oMesas;
                    actasLN obj = new actasLN();
                    mesasLN oMesasLN = new mesasLN();
                    DataTable dty;
                    int id_mesa = 0;
                    oMesas = oMesasLN.validarMesa(lblNroMesa.Text, Convert.ToString(cboxTipoMesa.Text));
                    if(oMesas !=null)
                    {
                        if(lblVerificadoMunicipal.Text == "VERIFICADO")
                        {
                            int id_acta_vv = 0;
                            DataTable dtMuni;
                            dtMuni = actasAD.ValidarIdActa(txtNroVotacion.Text, cboxTipoMesa.Text);
                            foreach (DataRow row in dtMuni.Rows)
                            {
                                id_acta_vv = Convert.ToInt32(row[0].ToString());
                            }
                            id_mesa = oMesas.ID;
                            actasAD.ActualizarActa(Convert.ToInt32(txtvblancoP.Text), Convert.ToInt32(txtvBlancoD.Text), Convert.ToInt32(txtvNulosP.Text), Convert.ToInt32(txtvNulosD.Text), Convert.ToInt32(txtinpugnadosP.Text), Convert.ToInt32(txtvInpugnadosD.Text), Convert.ToInt32(txtTotalEmitidosP.Text), Convert.ToInt32(txtvEmitidosD.Text), id_acta_vv);
                            string estado = "REGISTRADO";
                            oMesasLN.CambiarEstadoMesa(estado, id_mesa);
                            foreach (DataGridViewRow fila in dgvOrganizacion.Rows)
                            {
                                int id_partido = Convert.ToInt32(fila.Cells["ID1"].Value.ToString());
                                int total_provincia = Convert.ToInt32(fila.Cells["VOTOPROV"].Value.ToString());
                                int total_distrital = Convert.ToInt32(fila.Cells["VOTODISTR"].Value.ToString());
                                detalle_actasAD.ActualizarDetalleActa(total_provincia, total_distrital, id_partido, id_acta_vv);
                            }
                        }
                        else
                        {
                            id_mesa = oMesas.ID;
                            obj.Insertar(lblElecciones.Text, Convert.ToInt32(id_mesa), Convert.ToInt32(txtvblancoP.Text), Convert.ToInt32(txtvBlancoD.Text), Convert.ToInt32(txtvNulosP.Text), Convert.ToInt32(txtvNulosD.Text), Convert.ToInt32(txtinpugnadosP.Text), Convert.ToInt32(txtvInpugnadosD.Text), Convert.ToInt32(txtTotalEmitidosP.Text), Convert.ToInt32(txtvEmitidosD.Text));
                            dty = actasAD.ValidarIdActa(lblNroMesa.Text, cboxTipoMesa.Text);
                            if (dty.Rows.Count != 0)
                            {
                                foreach (DataRow row in dty.Rows)
                                {
                                    id_acta_municipal = Convert.ToInt32(row[0].ToString());
                                }
                                string estado = "VERIFICADO";
                                oMesasLN.CambiarEstadoMesa(estado, id_mesa);
                                detalle_actasLN oDetalle = new detalle_actasLN();
                                foreach (DataGridViewRow fila in dgvOrganizacion.Rows)
                                {
                                    int id_partido = Convert.ToInt32(fila.Cells["ID1"].Value.ToString());
                                    int total_provincia = Convert.ToInt32(fila.Cells["VOTOPROV"].Value.ToString());
                                    int total_distrital = Convert.ToInt32(fila.Cells["VOTODISTR"].Value.ToString());
                                    oDetalle.Insertar(id_acta_municipal, id_partido, total_provincia, total_distrital);
                                }
                            }
                            else
                            {
                                MessageBox.Show("NO SE REGISTRO EL ACTA CORRECTAMENTE.", "Aviso!", MessageBoxButtons.OK);
                            }
                        }
                        
                                              
                    }
                              
                    MessageBox.Show("EL ACTA SE GUARDO CON EXITO.", "Aviso!", MessageBoxButtons.OK);
                    try
                    {
                        int j=0;
                        while(dgvOrganizacion.Rows.Count > 0){
                            dgvOrganizacion.Rows.RemoveAt(j);
                        }
                    }catch(Exception ex)
                    { }
                    
                    lblNroMesa.Text = "000000";
                    lblDepartamento.Text = "DEPARTAMENTO";
                    lblProvincia.Text = "PROVINCIA";
                    lblDistrito.Text = "DISTRITO";
                    lblTotalElectores.Text = "000";
                    txtvBlancoD.ResetText();
                    txtvblancoP.ResetText();
                    txtvNulosP.ResetText();
                    txtvNulosD.ResetText();
                    txtinpugnadosP.ResetText();
                    txtvInpugnadosD.ResetText();
                    txtvEmitidosD.ResetText();
                    txtTotalEmitidosP.ResetText();

                    txtTotalAutomaticoP.ResetText();
                    txtTotalAutomaticoD.ResetText();

                    lblVerificadoMunicipal.Visible = false; lblVerificadoMunicipal.Text = "NO ESPECIFICADO";
                    txtNroVotacion.Text="ESCRIBIR NRO MESA DE VOTACION";
                    txtNroVotacion.Focus();
                    
                }
            }
        }
        private void dgvOrganizacionRegional_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SendKeys.Send("{UP}");
            SendKeys.Send("{TAB}");

            int Total_provincial = 0;
            int Total_distrital = 0;
            
            
            foreach (DataGridViewRow row in dgvOrganizacionRegional.Rows)
            {
                Total_provincial += Convert.ToInt32(row.Cells[4].Value);
                Total_distrital += Convert.ToInt32(row.Cells[5].Value);
            }
            total_Automatico_ProvincialR = Total_provincial;
            total_Automatico_DistritalR = Total_distrital;


            

        }
        private void btnGuardarRegional_Click(object sender, EventArgs e)
        {
            sender = MessageBox.Show("DESEA GUARDAR EL REGISTRO DEL ACTA DE VOTACION.?", "Advertencia!", MessageBoxButtons.YesNo);
            if (sender.Equals(DialogResult.Yes))
            {
                if ((txtVotosBlancoPRegional.Text.Equals("")) || (txtVotosNulosPRegional.Text.Equals("")) || (txtVotosInpugPRegional.Text.Equals("")) || (txtTotalVotosEmiPRegional.Text.Equals("")))
                {
                    MessageBox.Show("RELLENE LOS DATOS POR FAVOR.", "Error!", MessageBoxButtons.OK);
                }
                else
                {
                    mesas oMesas1;
                    actasLN obj1 = new actasLN();
                    mesasLN oMesasLN1 = new mesasLN();
                    int id_mesa = 0;
                    DataTable dtx;
                    oMesas1 = oMesasLN1.validarMesa(lblNroMesaRegional.Text, Convert.ToString(cboxTipoMesa.Text));
                    if (oMesas1 != null)
                    {
                        if(lblverificadoRegional.Text == "VERIFICADO")
                        {
                            int id_acta_v = 0;
                            DataTable dtRegio;
                            dtRegio = actasAD.ValidarIdActa(txtNroVotacion.Text, cboxTipoMesa.Text);
                            foreach(DataRow row in dtRegio.Rows)
                            {
                                id_acta_v = Convert.ToInt32(row[0].ToString());
                            }
                            id_mesa = oMesas1.ID;
                            actasAD.ActualizarActa(Convert.ToInt32(txtVotosBlancoPRegional.Text), Convert.ToInt32(txtVotosBlancoDRegional.Text), Convert.ToInt32(txtVotosNulosPRegional.Text), Convert.ToInt32(txtVotosNulosDRegional.Text), Convert.ToInt32(txtVotosInpugPRegional.Text), Convert.ToInt32(txtVotosInpugDRegional.Text), Convert.ToInt32(txtTotalVotosEmiPRegional.Text), Convert.ToInt32(txtTotalVotosEmiDRegional.Text), id_acta_v);
                            string estado = "REGISTRADO";
                            oMesasLN1.CambiarEstadoMesa(estado, id_mesa);
                            foreach (DataGridViewRow fila in dgvOrganizacionRegional.Rows)
                            {
                                int id_partido = Convert.ToInt32(fila.Cells["ID"].Value.ToString());
                                int total_provincia = Convert.ToInt32(fila.Cells["VOTOREG"].Value.ToString());
                                int total_distrital = Convert.ToInt32(fila.Cells["VOTOCONS"].Value.ToString());
                                detalle_actasAD.ActualizarDetalleActa(total_provincia, total_distrital, id_partido, id_acta_v);
                            }
                        }
                        else
                        {
                            id_mesa = oMesas1.ID;
                            obj1.Insertar(lblEleccionesRegional.Text, Convert.ToInt32(id_mesa), Convert.ToInt32(txtVotosBlancoPRegional.Text), Convert.ToInt32(txtVotosBlancoDRegional.Text), Convert.ToInt32(txtVotosNulosPRegional.Text), Convert.ToInt32(txtVotosNulosDRegional.Text), Convert.ToInt32(txtVotosInpugPRegional.Text), Convert.ToInt32(txtVotosInpugDRegional.Text), Convert.ToInt32(txtTotalVotosEmiPRegional.Text), Convert.ToInt32(txtTotalVotosEmiDRegional.Text));
                            dtx = actasAD.ValidarIdActa(lblNroMesaRegional.Text, cboxTipoMesa.Text);
                            if (dtx.Rows.Count != 0)
                            {
                                foreach (DataRow row in dtx.Rows)
                                {
                                    id_acta_regional = Convert.ToInt32(row[0].ToString());
                                }
                                string estado = "VERIFICADO";
                                oMesasLN1.CambiarEstadoMesa(estado, id_mesa);
                                detalle_actasLN oDetalle1 = new detalle_actasLN();
                                foreach (DataGridViewRow fila in dgvOrganizacionRegional.Rows)
                                {
                                    int id_partido = Convert.ToInt32(fila.Cells["ID"].Value.ToString());
                                    int total_provincia = Convert.ToInt32(fila.Cells["VOTOREG"].Value.ToString());
                                    int total_distrital = Convert.ToInt32(fila.Cells["VOTOCONS"].Value.ToString());
                                    oDetalle1.Insertar(id_acta_regional, id_partido, total_provincia, total_distrital);
                                }
                            }
                            else
                            {
                                MessageBox.Show("NO SE REGISTRO EL ACTA CORRECTAMENTE.", "Aviso!", MessageBoxButtons.OK);
                            }
                        }
                    }

                    MessageBox.Show("EL ACTA SE GUARDO CON EXITO.", "Aviso!", MessageBoxButtons.OK);
                    try
                    {
                        int j = 0;
                        while (dgvOrganizacionRegional.Rows.Count > 0)
                        {
                            dgvOrganizacionRegional.Rows.RemoveAt(j);
                        }
                    }
                    catch (Exception ex)
                    { }

                    lblNroMesaRegional.Text = "000000";
                    lblDeparRegional.Text = "DEPARTAMENTO";
                    lblProvRegional.Text = "PROVINCIA";
                    lblDistrRegional.Text = "DISTRITO";
                    lblTotalElectoresRegional.Text = "000";
                    txtVotosBlancoPRegional.ResetText();
                    txtVotosBlancoDRegional.ResetText();
                    txtVotosNulosPRegional.ResetText();
                    txtVotosNulosDRegional.ResetText();
                    txtVotosInpugPRegional.ResetText();
                    txtVotosInpugDRegional.ResetText();
                    txtTotalVotosEmiPRegional.ResetText();
                    txtTotalVotosEmiDRegional.ResetText();

                    txttotalVotosAutomaticoP.ResetText();
                    txtTotalVotosAutomaticoD.ResetText();

                    txtNroVotacion.Text = "ESCRIBIR NRO MESA DE VOTACION";
                    lblverificadoRegional.Visible = false; lblverificadoRegional.Text = "NO ESPECIFICADO";
                    txtNroVotacion.Focus();

                }
            }
        }
        private void dgvOrganizacionRegional_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
     
       
        }
        private void dgvOrganizacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvOrganizacionRegional_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");

            }
        }
        private void dgvOrganizacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendKeys.Send("{TAB}");

            }
        }
        private void txtVotosBlancoPRegional_TextChanged(object sender, EventArgs e)
        {
            try
           {
                doc = Convert.ToInt32(txtVotosBlancoPRegional.Text);
          
           }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtVotosBlancoPRegional.ResetText();
                }
            }
            
        }
        private void txtVotosNulosPRegional_TextChanged(object sender, EventArgs e)
        {
            try
            {
                doc = Convert.ToInt32(txtVotosNulosPRegional.Text);

            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtVotosNulosPRegional.ResetText();
                }
            }
        }
        private void txtVotosInpugPRegional_TextChanged(object sender, EventArgs e)
        {
            try
            {
                doc = Convert.ToInt32(txtVotosInpugPRegional.Text);

            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtVotosInpugPRegional.ResetText();
                }
            }
        }
        private void txtTotalVotosEmiPRegional_TextChanged(object sender, EventArgs e)
        {
            try
            {
                doc = Convert.ToInt32(txtTotalVotosEmiPRegional.Text);
                int doc1 = Convert.ToInt32(txtVotosBlancoPRegional.Text);
                int doc2 = Convert.ToInt32(txtVotosNulosPRegional.Text);
                int doc3 = Convert.ToInt32(txtVotosInpugPRegional.Text);
                int suma = 0;
                suma = doc1 + doc2 + doc3;
                int total = suma + total_Automatico_ProvincialR;
                txttotalVotosAutomaticoP.Text = Convert.ToString(total);

            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtTotalVotosEmiPRegional.ResetText();
                }
            }
            
        }
        private void txtVotosBlancoDRegional_TextChanged(object sender, EventArgs e)
        {
            try
            {
                doc = Convert.ToInt32(txtVotosBlancoDRegional.Text);

            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtVotosBlancoDRegional.ResetText();
                }
            }
        }
        private void txtVotosNulosDRegional_TextChanged(object sender, EventArgs e)
        {
            try
            {
                doc = Convert.ToInt32(txtVotosNulosDRegional.Text);

            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtVotosNulosDRegional.ResetText();
                }
            }
        }
        private void txtVotosInpugDRegional_TextChanged(object sender, EventArgs e)
        {
            try
            {
                doc = Convert.ToInt32(txtVotosInpugDRegional.Text);

            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtVotosInpugDRegional.ResetText();
                }
            }
        }
        private void txtTotalVotosEmiDRegional_TextChanged(object sender, EventArgs e)
        {
            try
            {
                doc = Convert.ToInt32(txtTotalVotosEmiDRegional.Text);
                int docu1 = Convert.ToInt32(txtVotosBlancoDRegional.Text);
                int docu2 = Convert.ToInt32(txtVotosNulosDRegional.Text);
                int docu3 = Convert.ToInt32(txtVotosInpugDRegional.Text);
                int suma1 = 0;
                suma1 = docu1 + docu2 + docu3;
                int total1 = suma1 + total_Automatico_DistritalR;
                txtTotalVotosAutomaticoD.Text = Convert.ToString(total1);

            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("La cadena de entrada no tiene el formato correcto."))
                {
                    txtTotalVotosEmiDRegional.ResetText();
                }
            }
            
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
