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
        public SEGURIDAD()
        {
            InitializeComponent();
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
            tabla.Rows.Add("3", "LIMITADO");
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
            cboxTipo.DataSource = CargarTablaTipo();
            cboxTipo.DisplayMember = "Descripcion";
            cboxTipo.ValueMember = "Id";

            cboxEstado.DataSource = CargarTablaEstado();
            cboxEstado.DisplayMember = "Estado";
            cboxEstado.ValueMember = "Id";
           
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
                txtDni.ForeColor = Color.DarkBlue;
            }
        }

        private void txtLogin_MouseEnter(object sender, EventArgs e)
        {
            if (txtLogin.Text == "LOGIN O CORREO ELECTRONICO")
            {
                txtLogin.ResetText();
                txtLogin.ForeColor = Color.DarkBlue;
            }
        }

        private void txtclave_MouseEnter(object sender, EventArgs e)
        {
            if (txtclave.Text == "PASSWORD")
            {
                txtclave.ResetText();
                txtclave.ForeColor = Color.DarkBlue;
            }
        }

        private void txtNomCompleto_MouseEnter(object sender, EventArgs e)
        {
            if (txtNomCompleto.Text == "NOMBRES COMPLETOS DE USUARIO")
            {
                txtNomCompleto.ResetText();
                txtNomCompleto.ForeColor = Color.DarkBlue;
            }
        }

        private void txtBuscar_MouseEnter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "BUSCAR POR / DNI / NOMBRES / LOGIN")
            {
                txtBuscar.ResetText();
                txtBuscar.ForeColor = Color.DarkBlue;
            }
        }

        private void txtDni_MouseLeave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "DNI";
                txtDni.ForeColor = Color.DarkBlue;
            }
        }

        private void txtLogin_MouseLeave(object sender, EventArgs e)
        {
            if (txtLogin.Text == "")
            {
                txtLogin.Text = "LOGIN O CORREO ELECTRONICO";
                txtLogin.ForeColor = Color.DarkBlue;
            }
        }

        private void txtclave_MouseLeave(object sender, EventArgs e)
        {
            if (txtclave.Text == "")
            {
                txtclave.Text = "PASSWORD";
                txtclave.ForeColor = Color.DarkBlue;
            }
        }

        private void txtNomCompleto_MouseLeave(object sender, EventArgs e)
        {
            if (txtNomCompleto.Text == "")
            {
                txtNomCompleto.Text = "NOMBRES COMPLETOS DE USUARIO";
                txtNomCompleto.ForeColor = Color.DarkBlue;
            }
        }

        private void txtBuscar_MouseLeave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "BUSCAR POR / DNI / NOMBRES / LOGIN";
                txtBuscar.ForeColor = Color.DarkBlue;
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            palabra = Convert.ToString(txtBuscar.Text);
            usuarioLN oUsuarioLN = new usuarioLN();
            listaUsuario = oUsuarioLN.BusquedaUsuario(palabra, palabra);
            dgvUsuarios.DataSource = listaUsuario;
            lblencontrados.Text = Convert.ToString(listaUsuario.Count.ToString());
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dniseleccionado = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["DNI"].Value);
            txtDni.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["DNI"].Value);
            txtLogin.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["LOGIN"].Value);
            txtclave.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["CLAVE"].Value);
            txtNomCompleto.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["NOMBRE_COMPLETO"].Value);
            fechaNaci.Text = Convert.ToString(this.dgvUsuarios.CurrentRow.Cells["FECHA_NACI"].Value);
             usuario obj;
            usuarioLN objUser = new usuarioLN();
            obj=objUser.validarDNI(txtDni.Text);
            if (obj != null)
            {
                if (obj.TIPO == 1)
                {
                    List<string> tipoUser = new List<string>();
                    tipoUser.Add("ADMINISTRADOR");
                    tipoUser.Add("USUARIO");
                    tipoUser.Add("LIMITADO");
                    cboxTipo.DataSource = tipoUser;
                }
                else if (obj.TIPO == 2)
                {
                    List<string> tipoUser = new List<string>();
                    tipoUser.Add("USUARIO");
                    tipoUser.Add("LIMITADO");
                    tipoUser.Add("ADMINISTRADOR");
                    cboxTipo.DataSource = tipoUser;
                }
                else
                {
                    List<string> tipoUser = new List<string>();
                    tipoUser.Add("LIMITADO");
                    tipoUser.Add("USUARIO");
                    tipoUser.Add("ADMINISTRADOR");
                    cboxTipo.DataSource = tipoUser;
                }
                if (obj.ESTADO == 2)
                {
                    List<string> estado = new List<string>();
                    estado.Add("INACTIVO");
                    estado.Add("ACTIVO");
                    cboxEstado.DataSource = estado;
                }
                else
                {
                    List<string> estado = new List<string>();
                    estado.Add("ACTIVO");
                    estado.Add("INACTIVO");
                    cboxEstado.DataSource = estado;
                }
                btnActualizar.Visible = true;
                btnGuardar.Enabled = false;
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
                    int estado;
                    int tipo_user;
                    if (cboxEstado.SelectedValue == "ACTIVO")
                    {
                        estado = 1;
                    }
                    else
                    {
                        estado = 2;
                    }
                    if (cboxTipo.SelectedValue == "ADMINISTRADOR")
                    {
                        tipo_user = 1;
                    }
                    else if (cboxTipo.SelectedValue == "USUARIO")
                    {
                        tipo_user = 2;
                    }
                    else
                    {
                        tipo_user = 3;
                    }

                    usuarioLN objUsuario = new usuarioLN();
                    objUsuario.ActualizarUsuario(txtDni.Text, txtLogin.Text, txtNomCompleto.Text, Convert.ToString(fechaNaci.Value.ToShortDateString()), tipo_user, estado);
                    MessageBox.Show("EL USUARIO " + txtLogin.Text + " HA SIDO ACTUALIZADO CORRECTAMENTE.", "Aviso!", MessageBoxButtons.OK);
                    txtDni.Text = "DNI";
                    txtLogin.Text = "LOGIN O CORREO ELECTRONICO";
                    txtclave.Text = "PASSWORD";
                    txtNomCompleto.Text = "NOMBRES COMPLETOS DE USUARIO";
                    btnActualizar.Visible = false;
                    btnGuardar.Enabled = true;
                    txtDni.Focus();
                    
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
    }
}
