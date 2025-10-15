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
using Entidades;
using AccesoDatos;

namespace SISCO
{
    public partial class SEGURIDAD : Form
    {
        private int doc = 0;
        private int existeUsuario = 0;
        string Incriptado = "";
        private List<usuario> listaUsuario = null;
        private string palabra = null;
        internal string dniseleccionado = "";
        public int id_proceso_electoral=0; 
        public SEGURIDAD()
        {
            InitializeComponent();
        }
        public void BuscarUsuario()
        {
            dgvUsuarios.AutoGenerateColumns = false;
            dgvUsuarios.Rows.Clear();
            palabra = Convert.ToString(txtBuscar.Text);
            usuarioLN oUsuarioLN = new usuarioLN();
            listaUsuario = oUsuarioLN.BusquedaUsuario(palabra, palabra);
            if (listaUsuario!=null)
            {
                foreach (usuario usuario in listaUsuario)
                {
                    string dni_e, login_e, clave_e, nom_e, fecha_e, tipo_final="", fecha_reg_e, estado_final="";
                    int tipo_e, esta_e;
                    dni_e =  usuario.DNI;
                    login_e = usuario.LOGIN;
                    clave_e = usuario.CLAVE;
                    nom_e = usuario.NOMBRE_COMPLETO;
                    fecha_e = usuario.FECHA_NACI;
                    tipo_e = usuario.TIPO;
                    fecha_reg_e = usuario.FECHA_REGISTRO;
                    esta_e = usuario.ESTADO;

                    switch (tipo_e)
                    {
                        case 1:
                            tipo_final = "ADMINISTRADOR";
                            break;
                        case 2:
                            tipo_final = "USUARIO";
                            break;
                        case 3:
                            tipo_final = "OPERADOR";
                            break;
                    }
                    switch (esta_e)
                    {
                        case 1:
                            estado_final = "ACTIVO";
                            break;
                        case 2:
                            estado_final = "INACTIVO";
                            break;
                    }

                    dgvUsuarios.Rows.Add(dni_e, login_e, clave_e, nom_e, fecha_e, tipo_final, fecha_reg_e, estado_final);
                }
                //dgvUsuarios.DataSource = listaUsuario;
                lblencontrados.Text = Convert.ToString(listaUsuario.Count.ToString());
            }
            else
            {
                MessageBox.Show("NO SE HA ENCONTRADOS RESULTADOS!","Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
            
        }
        public void CargaCombobox()
        {
            cboxTipo.DataSource = CargarTablaTipo();
            cboxTipo.DisplayMember = "Descripcion";
            cboxTipo.ValueMember = "Id";

            cboxEstado.DataSource = CargarTablaEstado();
            cboxEstado.DisplayMember = "Estado";
            cboxEstado.ValueMember = "Id";
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            sender = MessageBox.Show("DESEAR GUARDAR EL REGISTRO DEL USUARIO?", "Advertencia!", MessageBoxButtons.YesNo);
            if (sender.Equals(DialogResult.Yes))
            {
                if ((txtDni.Text == "DNI") || txtDni.Text.Equals("") || (txtLogin.Text == "LOGIN O CORREO ELECTRONICO") || txtLogin.Text.Equals("") || (txtclave.Text == "PASSWORD") || txtclave.Text.Equals("") || (txtNomCompleto.Text == "NOMBRES COMPLETOS DE USUARIO") || txtNomCompleto.Text.Equals(""))
                {
                    MessageBox.Show("RELLENE LOS CAMPOS POR FAVOR.", "Error!", MessageBoxButtons.OK);
                }
                else
                {
                    usuario objUsuario;
                    usuarioLN oUsuarioLN = new usuarioLN();
                    objUsuario = oUsuarioLN.validarDNI(txtDni.Text);
                    if(objUsuario!=null)
                    {
                        existeUsuario = 1;
                        MessageBox.Show("EL NRO "+ txtDni.Text +" YA ESTA REGISTRADO EN LA BASE DE DATOS.!", "Error!", MessageBoxButtons.OK);
                        txtDni.Text = "DNI";
                        txtLogin.Text = "LOGIN O CORREO ELECTRONICO";
                        txtclave.Text = "PASSWORD";
                        txtNomCompleto.Text = "NOMBRES COMPLETOS DE USUARIO";
                        txtDni.Focus();
                    }
                    else
                    {
                        Incriptacion oIncriptar = new Incriptacion();
                        Incriptado = oIncriptar.Encriptar(txtclave.Text);
                        usuarioLN oUserLN = new usuarioLN();
                        oUserLN.Insertar(txtDni.Text, txtLogin.Text, Incriptado, txtNomCompleto.Text, Convert.ToString(fechaNaci.Value.ToShortDateString()), Convert.ToInt32(cboxTipo.SelectedValue), Convert.ToString(System.DateTime.Now.ToLocalTime()), Convert.ToInt32(cboxEstado.SelectedValue));
                        MessageBox.Show("DATOS REGISTRADO CORRECTAMENTE.", "Aviso!", MessageBoxButtons.OK);
                        txtDni.Text = "DNI";
                        txtLogin.Text = "LOGIN O CORREO ELECTRONICO";
                        txtclave.Text = "PASSWORD";
                        txtNomCompleto.Text = "NOMBRES COMPLETOS DE USUARIO";
                        txtDni.Focus();
                    }
                    
                }
            }

        }
        private DataTable CargarTablaTipo()
        {
            // Simulamos una tabla cargada por SQL
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Descripcion");
            tabla.Rows.Add("1", "ADMINISTRADOR");
            tabla.Rows.Add("2", "USUARIO");
            tabla.Rows.Add("3", "OPERADOR");
            // Añadimos en la primera fila un nuevo Item
            DataRow filaprimera = tabla.NewRow();
            filaprimera["Id"] = "0";
            filaprimera["Descripcion"] = "--SELECCIONE--";
            tabla.Rows.InsertAt(filaprimera, 0); 
            return tabla;
        }
        private DataTable CargarTablaEstado()
        {
            // Simulamos una tabla cargada por SQL
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Estado");
            tabla.Rows.Add("1", "ACTIVO");
            tabla.Rows.Add("2", "INACTIVO");
            // Añadimos en la primera fila un nuevo Item
            DataRow filaprimera = tabla.NewRow();
            filaprimera["Id"] = "0";
            filaprimera["Estado"] = "--SELECCIONE--";
            tabla.Rows.InsertAt(filaprimera, 0);
            return tabla;
        }
        private void SEGURIDAD_Load(object sender, EventArgs e)
        {
            CargaCombobox();           
        }
        private void chboxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxMostrar.Checked == true)
            {
                chboxDesencriptar.Visible = true;
                txtclave.UseSystemPasswordChar = false;
            }

            else
            {
                txtclave.UseSystemPasswordChar = true;
                chboxDesencriptar.Visible = false;
            }
        }
        private void txtDni_MouseEnter(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI")
            {
                txtDni.ResetText();
                txtDni.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtLogin_MouseEnter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "LOGIN O CORREO ELECTRONICO")
            {
                txtLogin.ResetText();
                txtLogin.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtclave_MouseEnter(object sender, EventArgs e)
        {
            if (txtclave.Text == "PASSWORD")
            {
                txtclave.ResetText();
                txtclave.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtNomCompleto_MouseEnter(object sender, EventArgs e)
        {
            if (txtNomCompleto.Text == "NOMBRES COMPLETOS DE USUARIO")
            {
                txtNomCompleto.ResetText();
                txtNomCompleto.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtBuscar_MouseEnter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "BUSCAR POR / DNI / NOMBRES / LOGIN")
            {
                txtBuscar.ResetText();
                txtBuscar.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtDni_MouseLeave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "DNI";
                txtDni.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtLogin_MouseLeave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "LOGIN O CORREO ELECTRONICO";
                txtLogin.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtclave_MouseLeave(object sender, EventArgs e)
        {
            if (txtclave.Text == "")
            {
                txtclave.Text = "PASSWORD";
                txtclave.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtNomCompleto_MouseLeave(object sender, EventArgs e)
        {
            if (txtNomCompleto.Text == "")
            {
                txtNomCompleto.Text = "NOMBRES COMPLETOS DE USUARIO";
                txtNomCompleto.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtBuscar_MouseLeave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR / DNI / NOMBRES / LOGIN";
                txtBuscar.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void SEGURIDAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            sender = MessageBox.Show("DESEA ACTUALIZAR EL REGISTRO?", "Advertencia!", MessageBoxButtons.YesNo);

            if (sender.Equals(DialogResult.Yes))
            {
                if ((txtDni.Text == "DNI") || txtDni.Text.Equals("") || (txtLogin.Text == "LOGIN O CORREO ELECTRONICO") || txtLogin.Text.Equals("") || (txtclave.Text == "PASSWORD") || txtclave.Text.Equals("") || (txtNomCompleto.Text == "NOMBRES COMPLETOS DE USUARIO") || txtNomCompleto.Text.Equals(""))
                {
                    MessageBox.Show("Rellene los campos Por Favor.", "Error!", MessageBoxButtons.OK);
                }
                else
                {
                    usuarioLN objUsuario = new usuarioLN();
                    objUsuario.ActualizarUsuario(txtDni.Text, txtLogin.Text, txtNomCompleto.Text, Convert.ToString(fechaNaci.Value.ToShortDateString()), Convert.ToInt32(cboxTipo.SelectedValue), Convert.ToInt32(cboxEstado.SelectedValue));
                    MessageBox.Show("EL USUARIO " + txtLogin.Text + " HA SIDO ACTUALIZADO CORRECTAMENTE.", "Aviso!", MessageBoxButtons.OK);
                    txtDni.Text = "DNI";
                    txtLogin.Text = "LOGIN O CORREO ELECTRONICO";
                    txtclave.Text = "PASSWORD";
                    txtNomCompleto.Text = "NOMBRES COMPLETOS DE USUARIO";
                    btnActualizar.Visible = false;
                    btnGuardar.Enabled = true;
                    txtDni.Focus();
                    BuscarUsuario();
                }
            }

        }
        private void chboxDesencriptar_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxDesencriptar.Checked == true)
            {
                sender = MessageBox.Show("Desencriptar Texto?", "Advertencia!", MessageBoxButtons.YesNo);

                if (sender.Equals(DialogResult.Yes))
                {
                    if ((txtclave.Text.Equals("")))
                    {
                        MessageBox.Show("Rellene los campos Necesarios (*).", "Error!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        Incriptacion oDesancriptar = new Incriptacion();
                        txtclave.Text = oDesancriptar.Desencriptar(txtclave.Text);

                    }
                }

            }
            else
            {
                Incriptacion oDesancriptar = new Incriptacion();
                txtclave.Text = oDesancriptar.Encriptar(txtclave.Text);
            }
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }
        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dniseleccionado = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["DNI"].Value);

            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "editar")
            {
                sender = MessageBox.Show("DESEA EDITAR USUARIO CON DNI: "+dniseleccionado, "Mensaje!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sender.Equals(DialogResult.Yes))
                {
                    string tipo_sel, estado_sel;
                    int select_tipo, select_estado;
                    txtDni.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["DNI"].Value);
                    txtLogin.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["LOGIN"].Value);
                    txtclave.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["CLAVE"].Value);
                    txtNomCompleto.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["NOMBRE_COMPLETO"].Value);
                    fechaNaci.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["FECHA_NACI"].Value);                    
                    tipo_sel = this.dgvUsuarios.CurrentRow.Cells["TIPO"].Value.ToString();
                    estado_sel = this.dgvUsuarios.CurrentRow.Cells["ESTADO"].Value.ToString();
                    switch (tipo_sel)
                    {
                        case "ADMINISTRADOR":
                            select_tipo = 1;
                            cboxTipo.SelectedValue = select_tipo;
                            break;
                        case "USUARIO":
                            select_tipo = 2;
                            cboxTipo.SelectedValue = select_tipo;
                            break;
                        case "OPERADOR":
                            select_tipo = 3;
                            cboxTipo.SelectedValue = select_tipo;
                            break;
                    }
                    switch (estado_sel)
                    {
                        case "ACTIVO":
                            select_estado = 1;
                            cboxEstado.SelectedValue = select_estado;
                            break;
                        case "INACTIVO":
                            select_estado = 2;
                            cboxEstado.SelectedValue = select_estado;
                            break;
                    }

                    btnActualizar.Visible = true;
                    btnGuardar.Enabled = false;
                   
                }

            }
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                sender = MessageBox.Show("DESEA ELIMINAR USUARIO CON DNI: " + dniseleccionado, "Mensaje!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sender.Equals(DialogResult.Yes))
                {
                    usuarioLN objuserLN = new usuarioLN();
                    objuserLN.eliminarUsuario(dniseleccionado);
                    MessageBox.Show("SE HA ELIMINADO CORRECTAMENTE EL USUARIO!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BuscarUsuario();
                }
            }
           
            
        }
        private void dgvUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string estado0;
            if (dgvUsuarios.Columns[e.ColumnIndex].Name == "ESTADO")
            {
                estado0 = dgvUsuarios.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                switch (estado0)
                {
                    case "INACTIVO":
                        dgvUsuarios.Rows[e.RowIndex].Cells["ESTADO"].ReadOnly = true;
                        dgvUsuarios.Rows[e.RowIndex].Cells["ESTADO"].Style.ForeColor = Color.Red;
                        break;
                    case "ACTIVO":
                        dgvUsuarios.Rows[e.RowIndex].Cells["ESTADO"].ReadOnly = true;
                        dgvUsuarios.Rows[e.RowIndex].Cells["ESTADO"].Style.ForeColor = Color.Green;
                        break;
                }

            }
        }
        public void buscarProcesoElectoral()
        {
            dgvProcesoElectoral.AutoGenerateColumns = false;
            dgvProcesoElectoral.Rows.Clear();
            DataTable dyy = proceso_electoralAD.BuscarProcesoElectoral(txtbuscarProceso.Text, txtbuscarProceso.Text);
            if (dyy.Rows.Count > 0)
            {
                string id_e, desc_e, an_e, tipo_e, esta_e;
                foreach (DataRow row in dyy.Rows)
                {
                    id_e = row[0].ToString();
                    desc_e = row[1].ToString();
                    an_e = row[2].ToString();
                    tipo_e = row[3].ToString();
                    esta_e = row[4].ToString();
                    dgvProcesoElectoral.Rows.Add(id_e, desc_e, an_e, tipo_e, esta_e);
                }
                lblproceso.Text = dgvProcesoElectoral.Rows.Count.ToString();
            }
        }
        private void btnNuevoProceso_Click(object sender, EventArgs e)
        {
            frmNUEVO_PROCESO_ELECTORAL objproce = new frmNUEVO_PROCESO_ELECTORAL();
            objproce.ShowDialog();
        }
        private void txtbuscarProceso_MouseEnter(object sender, EventArgs e)
        {
            if (txtbuscarProceso.Text == "BUSCAR POR / PROCESOS ELECTORAL / AÑO")
            {
                txtbuscarProceso.ResetText();
                txtbuscarProceso.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void txtbuscarProceso_MouseLeave(object sender, EventArgs e)
        {
            if (txtbuscarProceso.Text == "")
            {
                txtbuscarProceso.Text = "BUSCAR POR / PROCESOS ELECTORAL / AÑO";
                txtbuscarProceso.ForeColor = Color.FromArgb(1, 99, 174);
            }
        }
        private void btnbuscarProceso_Click(object sender, EventArgs e)
        {
            buscarProcesoElectoral();
        }
        private void dgvProcesoElectoral_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string estado2;
            if (dgvProcesoElectoral.Columns[e.ColumnIndex].Name == "estado1")
            {
                estado2 = dgvProcesoElectoral.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                switch (estado2)
                {
                    case "INACTIVO":
                        dgvProcesoElectoral.Rows[e.RowIndex].Cells["estado1"].ReadOnly = true;
                        dgvProcesoElectoral.Rows[e.RowIndex].Cells["estado1"].Style.ForeColor = Color.Red;
                        break;
                    case "ACTIVO":
                        dgvProcesoElectoral.Rows[e.RowIndex].Cells["estado1"].ReadOnly = true;
                        dgvProcesoElectoral.Rows[e.RowIndex].Cells["estado1"].Style.ForeColor = Color.Green;
                        break;
                }

            }
        }
        private void dgvProcesoElectoral_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_proceso_electoral = Convert.ToInt32(dgvProcesoElectoral.CurrentRow.Cells["id"].Value);
            string estado_pro = dgvProcesoElectoral.CurrentRow.Cells["estado1"].Value.ToString();
            if (dgvProcesoElectoral.Columns[e.ColumnIndex].Name == "Cambiar")
            {
                sender = MessageBox.Show("DESEA CAMBIAR ESTADO DEL PROCESO ELECTORAL ", "Mensaje!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sender.Equals(DialogResult.Yes))
                {
                    switch (estado_pro)
                    {
                        case "ACTIVO":
                            proceso_electoralAD.ActualizarPorcesoElectotal("INACTIVO", id_proceso_electoral);
                            MessageBox.Show("SE HA ACTUALIZADO CORRECTAMENTE!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            buscarProcesoElectoral();
                            break;
                        case "INACTIVO":
                            proceso_electoralAD.ActualizarPorcesoElectotal("ACTIVO", id_proceso_electoral);
                            MessageBox.Show("SE HA ACTUALIZADO CORRECTAMENTE!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            buscarProcesoElectoral();
                            break;
                    }
                    
                }
            }
            if (dgvProcesoElectoral.Columns[e.ColumnIndex].Name == "Editar1")
            {
                frmEDITAR_PROCESO_ELECTORAL objeditar = new frmEDITAR_PROCESO_ELECTORAL();
                objeditar.id_proceso_electoral = id_proceso_electoral;
                objeditar.ShowDialog();
            }
            if (dgvProcesoElectoral.Columns[e.ColumnIndex].Name == "Eliminar1")
            {
                sender = MessageBox.Show("DESEA ELIMINAR EL PROCESO ELECTORAL ", "Mensaje!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (sender.Equals(DialogResult.Yes))
                {
                    DataTable doo = mesasAD.ValidarMesaProcesoElectoral(id_proceso_electoral);
                    if (doo.Rows.Count > 0)
                    {
                        MessageBox.Show("EL PROCESO ELECTORAL CONTIENE MESAS REGISTRADAS EN EL SISTEMA SISCO!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        proceso_electoralAD.EliminarPorcesoElectotalDetalle(id_proceso_electoral);
                        proceso_electoralAD.EliminarPorcesoElectotalCabecera(id_proceso_electoral);
                        MessageBox.Show("SE HA ELIMINADO CORRECTAMENTE!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        buscarProcesoElectoral();
                    }
                }
            }
        }
    }
}
