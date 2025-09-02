namespace SISCO
{
    partial class MESAS
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
            this.chkCargaMasiva = new System.Windows.Forms.CheckBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.cboxTipoMesa = new System.Windows.Forms.ComboBox();
            this.cboxDistrito = new System.Windows.Forms.ComboBox();
            this.cboxProvincia = new System.Windows.Forms.ComboBox();
            this.txtNroVotantes = new System.Windows.Forms.TextBox();
            this.txtDireLugar = new System.Windows.Forms.TextBox();
            this.cboxDepartamento = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtnomColegio = new System.Windows.Forms.TextBox();
            this.txtNroMesa = new System.Windows.Forms.TextBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAgregados = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.txtBuscarMesa = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.chkCargaMasiva);
            this.groupBox1.Controls.Add(this.btnExaminar);
            this.groupBox1.Controls.Add(this.cboxTipoMesa);
            this.groupBox1.Controls.Add(this.cboxDistrito);
            this.groupBox1.Controls.Add(this.cboxProvincia);
            this.groupBox1.Controls.Add(this.txtNroVotantes);
            this.groupBox1.Controls.Add(this.txtDireLugar);
            this.groupBox1.Controls.Add(this.cboxDepartamento);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtnomColegio);
            this.groupBox1.Controls.Add(this.txtNroMesa);
            this.groupBox1.Controls.Add(this.shapeContainer1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 243);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE MESAS DE LOS LOCALES DE VOTACION";
            // 
            // chkCargaMasiva
            // 
            this.chkCargaMasiva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkCargaMasiva.AutoSize = true;
            this.chkCargaMasiva.Location = new System.Drawing.Point(669, 171);
            this.chkCargaMasiva.Name = "chkCargaMasiva";
            this.chkCargaMasiva.Size = new System.Drawing.Size(126, 21);
            this.chkCargaMasiva.TabIndex = 9;
            this.chkCargaMasiva.Text = "CARGA MASIVA";
            this.chkCargaMasiva.UseVisualStyleBackColor = true;
            this.chkCargaMasiva.CheckedChanged += new System.EventHandler(this.chkCargaMasiva_CheckedChanged);
            // 
            // btnExaminar
            // 
            this.btnExaminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.Location = new System.Drawing.Point(669, 198);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(130, 39);
            this.btnExaminar.TabIndex = 10;
            this.btnExaminar.Text = "EXAMINAR";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // cboxTipoMesa
            // 
            this.cboxTipoMesa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxTipoMesa.BackColor = System.Drawing.SystemColors.Control;
            this.cboxTipoMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoMesa.ForeColor = System.Drawing.Color.Black;
            this.cboxTipoMesa.FormattingEnabled = true;
            this.cboxTipoMesa.Location = new System.Drawing.Point(530, 23);
            this.cboxTipoMesa.Name = "cboxTipoMesa";
            this.cboxTipoMesa.Size = new System.Drawing.Size(269, 25);
            this.cboxTipoMesa.TabIndex = 4;
            this.cboxTipoMesa.SelectedIndexChanged += new System.EventHandler(this.cboxTipoMesa_SelectedIndexChanged);
            // 
            // cboxDistrito
            // 
            this.cboxDistrito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxDistrito.BackColor = System.Drawing.SystemColors.Control;
            this.cboxDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDistrito.ForeColor = System.Drawing.Color.Black;
            this.cboxDistrito.FormattingEnabled = true;
            this.cboxDistrito.Location = new System.Drawing.Point(530, 122);
            this.cboxDistrito.Name = "cboxDistrito";
            this.cboxDistrito.Size = new System.Drawing.Size(269, 25);
            this.cboxDistrito.TabIndex = 7;
            this.cboxDistrito.Visible = false;
            // 
            // cboxProvincia
            // 
            this.cboxProvincia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxProvincia.BackColor = System.Drawing.SystemColors.Control;
            this.cboxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProvincia.ForeColor = System.Drawing.Color.Black;
            this.cboxProvincia.FormattingEnabled = true;
            this.cboxProvincia.Location = new System.Drawing.Point(530, 91);
            this.cboxProvincia.Name = "cboxProvincia";
            this.cboxProvincia.Size = new System.Drawing.Size(269, 25);
            this.cboxProvincia.TabIndex = 6;
            this.cboxProvincia.Visible = false;
            this.cboxProvincia.SelectionChangeCommitted += new System.EventHandler(this.cboxProvincia_SelectionChangeCommitted);
            // 
            // txtNroVotantes
            // 
            this.txtNroVotantes.BackColor = System.Drawing.SystemColors.Control;
            this.txtNroVotantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroVotantes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroVotantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.txtNroVotantes.Location = new System.Drawing.Point(28, 152);
            this.txtNroVotantes.Name = "txtNroVotantes";
            this.txtNroVotantes.Size = new System.Drawing.Size(471, 16);
            this.txtNroVotantes.TabIndex = 3;
            this.txtNroVotantes.Text = "NUMERO DE VOTANTES HABILES";
            this.txtNroVotantes.TextChanged += new System.EventHandler(this.txtNroVotantes_TextChanged);
            this.txtNroVotantes.MouseEnter += new System.EventHandler(this.txtNroVotantes_MouseEnter);
            this.txtNroVotantes.MouseLeave += new System.EventHandler(this.txtNroVotantes_MouseLeave);
            // 
            // txtDireLugar
            // 
            this.txtDireLugar.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireLugar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireLugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.txtDireLugar.Location = new System.Drawing.Point(28, 110);
            this.txtDireLugar.Name = "txtDireLugar";
            this.txtDireLugar.Size = new System.Drawing.Size(471, 16);
            this.txtDireLugar.TabIndex = 2;
            this.txtDireLugar.Text = "DIRECCION / LUGAR DE LA MESA DE VOTACION";
            this.txtDireLugar.MouseEnter += new System.EventHandler(this.txtDireLugar_MouseEnter);
            this.txtDireLugar.MouseLeave += new System.EventHandler(this.txtDireLugar_MouseLeave);
            // 
            // cboxDepartamento
            // 
            this.cboxDepartamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxDepartamento.BackColor = System.Drawing.SystemColors.Control;
            this.cboxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDepartamento.ForeColor = System.Drawing.Color.Black;
            this.cboxDepartamento.FormattingEnabled = true;
            this.cboxDepartamento.Location = new System.Drawing.Point(530, 60);
            this.cboxDepartamento.Name = "cboxDepartamento";
            this.cboxDepartamento.Size = new System.Drawing.Size(269, 25);
            this.cboxDepartamento.TabIndex = 5;
            this.cboxDepartamento.Visible = false;
            this.cboxDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cboxDepartamento_SelectionChangeCommitted);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(530, 198);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(133, 39);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtnomColegio
            // 
            this.txtnomColegio.BackColor = System.Drawing.SystemColors.Control;
            this.txtnomColegio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnomColegio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnomColegio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.txtnomColegio.Location = new System.Drawing.Point(26, 63);
            this.txtnomColegio.Name = "txtnomColegio";
            this.txtnomColegio.Size = new System.Drawing.Size(471, 16);
            this.txtnomColegio.TabIndex = 1;
            this.txtnomColegio.Text = "INSTITUCION / COLEGIO";
            this.txtnomColegio.MouseEnter += new System.EventHandler(this.txtnomColegio_MouseEnter);
            this.txtnomColegio.MouseLeave += new System.EventHandler(this.txtnomColegio_MouseLeave);
            // 
            // txtNroMesa
            // 
            this.txtNroMesa.BackColor = System.Drawing.SystemColors.Control;
            this.txtNroMesa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNroMesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.txtNroMesa.Location = new System.Drawing.Point(27, 23);
            this.txtNroMesa.Name = "txtNroMesa";
            this.txtNroMesa.Size = new System.Drawing.Size(470, 16);
            this.txtNroMesa.TabIndex = 0;
            this.txtNroMesa.Text = "NUMERO DE MESA";
            this.txtNroMesa.MouseEnter += new System.EventHandler(this.txtNroMesa_MouseEnter);
            this.txtNroMesa.MouseLeave += new System.EventHandler(this.txtNroMesa_MouseLeave);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 19);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(799, 221);
            this.shapeContainer1.TabIndex = 0;
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
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 26;
            this.lineShape3.X2 = 494;
            this.lineShape3.Y1 = 116;
            this.lineShape3.Y2 = 116;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 24;
            this.lineShape2.X2 = 492;
            this.lineShape2.Y1 = 70;
            this.lineShape2.Y2 = 70;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 24;
            this.lineShape1.X2 = 494;
            this.lineShape1.Y1 = 30;
            this.lineShape1.Y2 = 30;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "TOTAL REGISTROS : ";
            // 
            // lblAgregados
            // 
            this.lblAgregados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAgregados.AutoSize = true;
            this.lblAgregados.Location = new System.Drawing.Point(411, 223);
            this.lblAgregados.Name = "lblAgregados";
            this.lblAgregados.Size = new System.Drawing.Size(106, 17);
            this.lblAgregados.TabIndex = 7;
            this.lblAgregados.Text = "NO ESPECIFICO";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.dgvMesas);
            this.groupBox2.Controls.Add(this.txtBuscarMesa);
            this.groupBox2.Controls.Add(this.lblAgregados);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.shapeContainer2);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.groupBox2.Location = new System.Drawing.Point(13, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 243);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CRITERIOS DE BUSQUEDA / CARGAR MASIVA DE NUMERO DE MESAS";
            // 
            // dgvMesas
            // 
            this.dgvMesas.AllowUserToAddRows = false;
            this.dgvMesas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMesas.Location = new System.Drawing.Point(6, 55);
            this.dgvMesas.Name = "dgvMesas";
            this.dgvMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMesas.Size = new System.Drawing.Size(793, 165);
            this.dgvMesas.TabIndex = 2;
            // 
            // txtBuscarMesa
            // 
            this.txtBuscarMesa.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscarMesa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarMesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.txtBuscarMesa.Location = new System.Drawing.Point(22, 22);
            this.txtBuscarMesa.Name = "txtBuscarMesa";
            this.txtBuscarMesa.Size = new System.Drawing.Size(471, 16);
            this.txtBuscarMesa.TabIndex = 1;
            this.txtBuscarMesa.Text = "BUSCAR NUMEROS DE MESA";
            this.txtBuscarMesa.TextChanged += new System.EventHandler(this.txtBuscarMesa_TextChanged);
            this.txtBuscarMesa.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.txtBuscarMesa.MouseLeave += new System.EventHandler(this.txtBuscarMesa_MouseLeave);
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 19);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape5});
            this.shapeContainer2.Size = new System.Drawing.Size(802, 221);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 17;
            this.lineShape5.X2 = 485;
            this.lineShape5.Y1 = 23;
            this.lineShape5.Y2 = 23;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(25)))), ((int)(((byte)(33)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(530, 11);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(133, 39);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // MESAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(830, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "MESAS";
            this.Text = "MESAS";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.MESAS_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MESAS_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboxDistrito;
        private System.Windows.Forms.ComboBox cboxProvincia;
        private System.Windows.Forms.TextBox txtNroVotantes;
        private System.Windows.Forms.TextBox txtDireLugar;
        private System.Windows.Forms.ComboBox cboxDepartamento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtnomColegio;
        private System.Windows.Forms.TextBox txtNroMesa;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ComboBox cboxTipoMesa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAgregados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.TextBox txtBuscarMesa;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox chkCargaMasiva;
        private System.Windows.Forms.Button btnBuscar;
    }
}