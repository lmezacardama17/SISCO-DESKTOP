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
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cboxTipoCandidato);
            this.groupBox1.Controls.Add(this.txtLugarPostula);
            this.groupBox1.Controls.Add(this.cboxPartido);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtLiderPolitico);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
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
            this.cboxTipoCandidato.Location = new System.Drawing.Point(26, 102);
            this.cboxTipoCandidato.Name = "cboxTipoCandidato";
            this.cboxTipoCandidato.Size = new System.Drawing.Size(466, 25);
            this.cboxTipoCandidato.TabIndex = 2;
            // 
            // txtLugarPostula
            // 
            this.txtLugarPostula.BackColor = System.Drawing.SystemColors.Control;
            this.txtLugarPostula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLugarPostula.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLugarPostula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.txtLugarPostula.Location = new System.Drawing.Point(29, 156);
            this.txtLugarPostula.Name = "txtLugarPostula";
            this.txtLugarPostula.Size = new System.Drawing.Size(471, 16);
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
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(28, 191);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtLiderPolitico
            // 
            this.txtLiderPolitico.BackColor = System.Drawing.SystemColors.Control;
            this.txtLiderPolitico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLiderPolitico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLiderPolitico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.txtLiderPolitico.Location = new System.Drawing.Point(29, 64);
            this.txtLiderPolitico.Name = "txtLiderPolitico";
            this.txtLiderPolitico.Size = new System.Drawing.Size(471, 16);
            this.txtLiderPolitico.TabIndex = 1;
            this.txtLiderPolitico.Text = "NOMBRE COMPLETO DEL CANDIDATO";
            this.txtLiderPolitico.MouseEnter += new System.EventHandler(this.txtLiderPolitico_MouseEnter);
            this.txtLiderPolitico.MouseLeave += new System.EventHandler(this.txtLiderPolitico_MouseLeave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 19);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape2});
            this.shapeContainer1.Size = new System.Drawing.Size(508, 237);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 25;
            this.lineShape4.X2 = 493;
            this.lineShape4.Y1 = 161;
            this.lineShape4.Y2 = 161;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 24;
            this.lineShape2.X2 = 492;
            this.lineShape2.Y1 = 70;
            this.lineShape2.Y2 = 70;
            // 
            // CANDIDATOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.ComboBox cboxTipoCandidato;
    }
}