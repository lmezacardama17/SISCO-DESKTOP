using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AccesoDatos;
using LogicaNegocio;
using Entidades;

namespace SISCO
{
    public partial class LOGIN : Form
    {
        int contador = 0, oportunidad = 3, total = 0;
        int estado = 0;
        private int existeUsuarioAsociado = 0;
        string Incriptado = "";
        public LOGIN()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void txtlogin_Enter(object sender, EventArgs e)
        {
            if(txtlogin.Text=="USUARIO"){
                txtlogin.ResetText();
                //txtlogin.ForeColor = Color.DarkBlue;
            }
        }
        private void txtlogin_Leave(object sender, EventArgs e)
        {
            if(txtlogin.Text == ""){
                txtlogin.Text = "USUARIO";
                //txtlogin.ForeColor = Color.DarkBlue;
            }
        }
        private void txtclave_Enter(object sender, EventArgs e)
        {
            if (txtclave.Text == "PASSWORD")
            {
                txtclave.ResetText();
                txtclave.ForeColor = Color.Black;
                txtclave.UseSystemPasswordChar = true;
            }
        }
        private void txtclave_Leave(object sender, EventArgs e)
        {
            if (txtclave.Text == "")
            {
                txtclave.Text = "PASSWORD";
                //txtclave.ForeColor = Color.DarkBlue;
                txtclave.UseSystemPasswordChar = false;
            }
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Incriptacion oIncriptar = new Incriptacion();
            Incriptado = oIncriptar.Encriptar(txtclave.Text);
            frmPROCESO_ELECTORAL objproceso = new frmPROCESO_ELECTORAL();

            usuario objUsuario;
            usuarioLN objUsuarioLN = new usuarioLN();
            objUsuario = objUsuarioLN.validarUsuario(txtlogin.Text, Incriptado);
            contador++;
            total = oportunidad - contador;

            if (objUsuario != null)
            {

                if (objUsuario.ESTADO == 2)
                {
                    MessageBox.Show("EL USUARIO ESTA INACTIVO COMUNIQUESE CON EL ADMINISTRADOR DEL SISTEMA", " Usuario Desahabilitado!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtlogin.Clear();
                    txtclave.Clear();
                    txtlogin.Focus();
                }
                else
                {
                    DataTable dt = proceso_electoralAD.ListaProcesoElectoral();
                    if (dt.Rows.Count > 0)
                    {
                        this.Hide();
                        objproceso.id_tipo_user = objUsuario.TIPO;
                        objproceso.nombre_completo =  objUsuario.NOMBRE_COMPLETO;
                        objproceso.dni_user = objUsuario.DNI;
                        objproceso.ShowDialog();
                    }
                    else
                    {
                        switch (objUsuario.TIPO)
                        {
                            case 1:
                                sender = MessageBox.Show("DESEA REGISTRAR EL NUEVO PROCESO ELECTORAL!?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                                if (sender.Equals(DialogResult.Yes))
                                {
                                    this.Hide();
                                    frmNUEVO_PROCESO_ELECTORAL objpro = new frmNUEVO_PROCESO_ELECTORAL();
                                    objpro.ShowDialog();                                    
                                }
                                break;
                            default:
                                MessageBox.Show("NO EXISTE NINGUN PROCESO ELECTORAL EN EL SISTEMA SISCO!", "Mensaje!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                this.Close();
                                break;

                        }
                    }
                    
                }
            }
            else 
            {
                if (contador == 3) 
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("SU USUARIO  y/o CLAVE SON INCORRECTOS. QUEDAN " + total + " INTENTOS.", "Datos Incorrectos!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtlogin.Clear();
                    txtclave.Clear();
                    txtlogin.Focus();
                }            
            }
            
        }
        private void txtclave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                this.btnEntrar.PerformClick();
            }
        }
        private void txtlogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CAMBIAR_CLAVE obj = new CAMBIAR_CLAVE();
            obj.Show();
        }
        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

      



    }
}
