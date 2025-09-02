namespace SISCO
{
    partial class CANDIDATOS
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
            this.cboxTipoCandidato = new System.Windows.Forms.ComboBox();
            this.txtLugarPostula = new System.Windows.Forms.TextBox();
            this.cboxPartido = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtLiderPolitico = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cboxTipoCandidato);
            this.groupBox1.Controls.Add(this.txtLugarPostula);
            this.groupBox1.Controls.Add(this.cboxPartido);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtLiderPolitico);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE CANDIDATOS - ERM 2022";
            // 
            // cboxTipoCandidato
            // 
            this.cboxTipoCandidato.BackColor = System.Drawing.SystemColors.Control;
            this.cboxTipoCandidato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoCandidato.ForeColor = System.Drawing.Color.Black;
            this.cboxTipoCandidato.FormattingEnabled = true;
            this.cboxTipoCandidato.Location = new System.Drawing.Point(26, 82);
            this.cboxTipoCandidato.Name = "cboxTipoCandidato";
            this.cboxTipoCandidato.Size = new System.Drawing.Size(466, 25);
            this.cboxTipoCandidato.TabIndex = 2;
            // 
            // txtLugarPostula
            // 
            this.txtLugarPostula.BackColor = System.Drawing.Color.White;
            this.txtLugarPostula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLugarPostula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLugarPostula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.txtLugarPostula.Location = new System.Drawing.Point(26, 113);
            this.txtLugarPostula.Name = "txtLugarPostula";
            this.txtLugarPostula.Size = new System.Drawing.Size(463, 23);
            this.txtLugarPostula.TabIndex = 3;
            this.txtLugarPostula.Text = "NOMBRE REGION / PROVINCIA / DISTRITO A POSTULAR";
            this.txtLugarPostula.MouseEnter += new System.EventHandler(this.txtLugarPostula_MouseEnter);
            this.txtLugarPostula.MouseLeave += new System.EventHandler(this.txtLugarPostula_MouseLeave);
            // 
            // cboxPartido
            // 
            this.cboxPartido.BackColor = System.Drawing.SystemColors.Control;
            this.cboxPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxPartido.ForeColor = System.Drawing.Color.Black;
            this.cboxPartido.FormattingEnabled = true;
            this.cboxPartido.Location = new System.Drawing.Point(26, 22);
            this.cboxPartido.Name = "cboxPartido";
            this.cboxPartido.Size = new System.Drawing.Size(466, 25);
            this.cboxPartido.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(26, 142);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtLiderPolitico
            // 
            this.txtLiderPolitico.BackColor = System.Drawing.Color.White;
            this.txtLiderPolitico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLiderPolitico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLiderPolitico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.txtLiderPolitico.Location = new System.Drawing.Point(26, 53);
            this.txtLiderPolitico.Name = "txtLiderPolitico";
            this.txtLiderPolitico.Size = new System.Drawing.Size(466, 23);
            this.txtLiderPolitico.TabIndex = 1;
            this.txtLiderPolitico.Text = "NOMBRE COMPLETO DEL CANDIDATO";
            this.txtLiderPolitico.MouseEnter += new System.EventHandler(this.txtLiderPolitico_MouseEnter);
            this.txtLiderPolitico.MouseLeave += new System.EventHandler(this.txtLiderPolitico_MouseLeave);
            // 
            // CANDIDATOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 283);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "CANDIDATOS";
            this.Text = "CANDIDATOS";
            this.Load += new System.EventHandler(this.CANDIDATOS_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CANDIDATOS_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLugarPostula;
        private System.Windows.Forms.ComboBox cboxPartido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtLiderPolitico;
        private System.Windows.Forms.ComboBox cboxTipoCandidato;
    }
}