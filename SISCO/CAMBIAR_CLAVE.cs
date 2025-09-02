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

namespace SISCO
{
    public partial class CAMBIAR_CLAVE : Form
    {
        public CAMBIAR_CLAVE()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CAMBIAR_CLAVE_Load(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            usuario objUsuario;
            usuarioLN oUsuarioLN = new usuarioLN();
            objUsuario = oUsuarioLN.validarDNI(txtdni.Text);
            if(objUsuario!=null)
            {
                MessageBox.Show("NRO DE DNI : " + txtdni.Text + " ESTA REGISTRADO EN LA BASE DE DATOS.", "OK!", MessageBoxButtons.OK);
                txtnuevaClave.Enabled = true;
                txtConfirmarClave.Enabled = true;
                chboxMostrar.Enabled = true;
                btnGuardar.Enabled = true;
                txtnuevaClave.Focus();
            }
            else
            {
                MessageBox.Show("EL NRO DE DNI : " + txtdni.Text + " NO EXISTE EN LA BASE DE DATOS.", "OK!", MessageBoxButtons.OK);
                txtdni.Focus();
            }
        }

        private void CAMBIAR_CLAVE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             sender = MessageBox.Show("DESEA CAMBIAR SU CONTRASEÑA?", "Advertencia!", MessageBoxButtons.YesNo);
             if (sender.Equals(DialogResult.Yes)) 
             {
                 string clave_final = "";
                 Incriptacion oIncripta = new Incriptacion();
                 clave_final = oIncripta.Encriptar(txtConfirmarClave.Text);
                 usuarioLN oUsuaLN = new usuarioLN();
                 oUsuaLN.CambiarClave(txtdni.Text, clave_final);
                 MessageBox.Show("SE CAMBIO SU CONTRASEÑA CON EXITO.", "Aviso!", MessageBoxButtons.OK);
                 CAMBIAR_CLAVE.ActiveForm.Close();
 
             }
       }

        private void chboxMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chboxMostrar.Checked == true)
            {
                txtnuevaClave.UseSystemPasswordChar = false;
                txtConfirmarClave.UseSystemPasswordChar = false;
            }

            else
            {
                txtnuevaClave.UseSystemPasswordChar = true;
                txtConfirmarClave.UseSystemPasswordChar = true;
                
            }
        }
    }
}
