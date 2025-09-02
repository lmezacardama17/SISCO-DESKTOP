namespace SISCO
{
    partial class CAMBIAR_CLAVE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.chboxMostrar = new System.Windows.Forms.CheckBox();
            this.txtConfirmarClave = new System.Windows.Forms.TextBox();
            this.txtnuevaClave = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnValidar);
            this.groupBox1.Controls.Add(this.chboxMostrar);
            this.groupBox1.Controls.Add(this.txtConfirmarClave);
            this.groupBox1.Controls.Add(this.txtnuevaClave);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 185);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CAMBIAR CONTRASEÑA - SIS\'CO";
            // 
            // btnValidar
            // 
            this.btnValidar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.btnValidar.FlatAppearance.BorderSize = 0;
            this.btnValidar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnValidar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(206)))), ((int)(((byte)(229)))));
            this.btnValidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidar.ForeColor = System.Drawing.Color.White;
            this.btnValidar.Location = new System.Drawing.Point(343, 13);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(113, 32);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "VALIDAR";
            this.btnValidar.UseVisualStyleBackColor = false;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // chboxMostrar
            // 
            this.chboxMostrar.AutoSize = true;
            this.chboxMostrar.Enabled = false;
            this.chboxMostrar.Location = new System.Drawing.Point(371, 57);
            this.chboxMostrar.Name = "chboxMostrar";
            this.chboxMostrar.Size = new System.Drawing.Size(85, 21);
            this.chboxMostrar.TabIndex = 5;
            this.chboxMostrar.Text = "MOSTRAR";
            this.chboxMostrar.UseVisualStyleBackColor = true;
            this.chboxMostrar.CheckedChanged += new System.EventHandler(this.chboxMostrar_CheckedChanged);
            // 
            // txtConfirmarClave
            // 
            this.txtConfirmarClave.BackColor = System.Drawing.Color.White;
            this.txtConfirmarClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmarClave.Enabled = false;
            this.txtConfirmarClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.txtConfirmarClave.Location = new System.Drawing.Point(15, 88);
            this.txtConfirmarClave.MaxLength = 10;
            this.txtConfirmarClave.Name = "txtConfirmarClave";
            this.txtConfirmarClave.Size = new System.Drawing.Size(350, 23);
            this.txtConfirmarClave.TabIndex = 3;
            this.txtConfirmarClave.Text = "CONFIRMA TU NUEVA CONTRASEÑA";
            this.txtConfirmarClave.UseSystemPasswordChar = true;
            // 
            // txtnuevaClave
            // 
            this.txtnuevaClave.BackColor = System.Drawing.Color.White;
            this.txtnuevaClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnuevaClave.Enabled = false;
            this.txtnuevaClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.txtnuevaClave.Location = new System.Drawing.Point(15, 57);
            this.txtnuevaClave.MaxLength = 10;
            this.txtnuevaClave.Name = "txtnuevaClave";
            this.txtnuevaClave.Size = new System.Drawing.Size(350, 23);
            this.txtnuevaClave.TabIndex = 2;
            this.txtnuevaClave.Text = "ESCRIBE TU NUEVA CONTRASEÑA";
            this.txtnuevaClave.UseSystemPasswordChar = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(206)))), ((int)(((byte)(229)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(12, 123);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtdni
            // 
            this.txtdni.BackColor = System.Drawing.Color.White;
            this.txtdni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtdni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.txtdni.Location = new System.Drawing.Point(15, 22);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(248, 23);
            this.txtdni.TabIndex = 0;
            this.txtdni.Text = "ESCRIBE TU NRO DE DNI";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackgroundImage = global::SISCO.Properties.Resources.icon_cerrar2;
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCerrar.Location = new System.Drawing.Point(466, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // CAMBIAR_CLAVE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(498, 222);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "CAMBIAR_CLAVE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIAR_CLAVE";
            this.Load += new System.EventHandler(this.CAMBIAR_CLAVE_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CAMBIAR_CLAVE_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chboxMostrar;
        private System.Windows.Forms.TextBox txtConfirmarClave;
        private System.Windows.Forms.TextBox txtnuevaClave;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btnValidar;
    }
}