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
            this.label1 = new System.Windows.Forms.Label();
            this.lblAgregados = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvMesas = new System.Windows.Forms.DataGridView();
            this.txtBuscarMesa = new System.Windows.Forms.TextBox();
            this.chkCargaMasiva = new System.Windows.Forms.CheckBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtNroMesa = new System.Windows.Forms.TextBox();
            this.txtnomColegio = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cboxDepartamento = new System.Windows.Forms.ComboBox();
            this.txtDireLugar = new System.Windows.Forms.TextBox();
            this.txtNroVotantes = new System.Windows.Forms.TextBox();
            this.cboxProvincia = new System.Windows.Forms.ComboBox();
            this.cboxDistrito = new System.Windows.Forms.ComboBox();
            this.cboxTipoMesa = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxProceso = new System.Windows.Forms.ComboBox();
            this.lblNroMesaRegional = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 270);
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
            this.lblAgregados.Location = new System.Drawing.Point(411, 270);
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
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.dgvMesas);
            this.groupBox2.Controls.Add(this.txtBuscarMesa);
            this.groupBox2.Controls.Add(this.lblAgregados);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.chkCargaMasiva);
            this.groupBox2.Controls.Add(this.btnExaminar);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(13, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 290);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CRITERIOS DE BUSQUEDA / CARGAR MASIVA DE NUMERO DE MESAS";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.label10.Location = new System.Drawing.Point(6, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "BUSQUEDA :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(206)))), ((int)(((byte)(229)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(485, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(134, 35);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.dgvMesas.RowHeadersVisible = false;
            this.dgvMesas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMesas.Size = new System.Drawing.Size(793, 212);
            this.dgvMesas.TabIndex = 2;
            // 
            // txtBuscarMesa
            // 
            this.txtBuscarMesa.BackColor = System.Drawing.Color.White;
            this.txtBuscarMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarMesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.txtBuscarMesa.Location = new System.Drawing.Point(96, 22);
            this.txtBuscarMesa.Name = "txtBuscarMesa";
            this.txtBuscarMesa.Size = new System.Drawing.Size(383, 23);
            this.txtBuscarMesa.TabIndex = 1;
            this.txtBuscarMesa.Text = "BUSCAR NUMEROS DE MESA";
            this.txtBuscarMesa.TextChanged += new System.EventHandler(this.txtBuscarMesa_TextChanged);
            this.txtBuscarMesa.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.txtBuscarMesa.MouseLeave += new System.EventHandler(this.txtBuscarMesa_MouseLeave);
            // 
            // chkCargaMasiva
            // 
            this.chkCargaMasiva.AutoSize = true;
            this.chkCargaMasiva.Location = new System.Drawing.Point(625, 24);
            this.chkCargaMasiva.Name = "chkCargaMasiva";
            this.chkCargaMasiva.Size = new System.Drawing.Size(126, 21);
            this.chkCargaMasiva.TabIndex = 9;
            this.chkCargaMasiva.Text = "CARGA MASIVA";
            this.chkCargaMasiva.UseVisualStyleBackColor = true;
            this.chkCargaMasiva.CheckedChanged += new System.EventHandler(this.chkCargaMasiva_CheckedChanged);
            // 
            // btnExaminar
            // 
            this.btnExaminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.btnExaminar.FlatAppearance.BorderSize = 0;
            this.btnExaminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnExaminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(206)))), ((int)(((byte)(229)))));
            this.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminar.ForeColor = System.Drawing.Color.White;
            this.btnExaminar.Location = new System.Drawing.Point(757, 19);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(42, 30);
            this.btnExaminar.TabIndex = 10;
            this.btnExaminar.Text = "...";
            this.btnExaminar.UseVisualStyleBackColor = false;
            this.btnExaminar.Click += new System.EventHandler(this.btnExaminar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txtNroMesa
            // 
            this.txtNroMesa.BackColor = System.Drawing.Color.White;
            this.txtNroMesa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroMesa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroMesa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.txtNroMesa.Location = new System.Drawing.Point(171, 51);
            this.txtNroMesa.Name = "txtNroMesa";
            this.txtNroMesa.Size = new System.Drawing.Size(206, 23);
            this.txtNroMesa.TabIndex = 0;
            this.txtNroMesa.Text = "NUMERO DE MESA";
            this.txtNroMesa.MouseEnter += new System.EventHandler(this.txtNroMesa_MouseEnter);
            this.txtNroMesa.MouseLeave += new System.EventHandler(this.txtNroMesa_MouseLeave);
            // 
            // txtnomColegio
            // 
            this.txtnomColegio.BackColor = System.Drawing.Color.White;
            this.txtnomColegio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnomColegio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnomColegio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.txtnomColegio.Location = new System.Drawing.Point(171, 80);
            this.txtnomColegio.Name = "txtnomColegio";
            this.txtnomColegio.Size = new System.Drawing.Size(328, 23);
            this.txtnomColegio.TabIndex = 1;
            this.txtnomColegio.Text = "INSTITUCION / COLEGIO";
            this.txtnomColegio.MouseEnter += new System.EventHandler(this.txtnomColegio_MouseEnter);
            this.txtnomColegio.MouseLeave += new System.EventHandler(this.txtnomColegio_MouseLeave);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(206)))), ((int)(((byte)(229)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(629, 146);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(170, 39);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cboxDepartamento
            // 
            this.cboxDepartamento.BackColor = System.Drawing.SystemColors.Control;
            this.cboxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDepartamento.ForeColor = System.Drawing.Color.Black;
            this.cboxDepartamento.FormattingEnabled = true;
            this.cboxDepartamento.Location = new System.Drawing.Point(629, 53);
            this.cboxDepartamento.Name = "cboxDepartamento";
            this.cboxDepartamento.Size = new System.Drawing.Size(170, 25);
            this.cboxDepartamento.TabIndex = 5;
            this.cboxDepartamento.SelectionChangeCommitted += new System.EventHandler(this.cboxDepartamento_SelectionChangeCommitted);
            // 
            // txtDireLugar
            // 
            this.txtDireLugar.BackColor = System.Drawing.Color.White;
            this.txtDireLugar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireLugar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireLugar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.txtDireLugar.Location = new System.Drawing.Point(171, 109);
            this.txtDireLugar.Name = "txtDireLugar";
            this.txtDireLugar.Size = new System.Drawing.Size(328, 23);
            this.txtDireLugar.TabIndex = 2;
            this.txtDireLugar.Text = "DIRECCION / LUGAR DE LA MESA DE VOTACION";
            this.txtDireLugar.MouseEnter += new System.EventHandler(this.txtDireLugar_MouseEnter);
            this.txtDireLugar.MouseLeave += new System.EventHandler(this.txtDireLugar_MouseLeave);
            // 
            // txtNroVotantes
            // 
            this.txtNroVotantes.BackColor = System.Drawing.Color.White;
            this.txtNroVotantes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroVotantes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNroVotantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.txtNroVotantes.Location = new System.Drawing.Point(171, 138);
            this.txtNroVotantes.Name = "txtNroVotantes";
            this.txtNroVotantes.Size = new System.Drawing.Size(206, 23);
            this.txtNroVotantes.TabIndex = 3;
            this.txtNroVotantes.Text = "NUMERO DE VOTANTES HABILES";
            this.txtNroVotantes.TextChanged += new System.EventHandler(this.txtNroVotantes_TextChanged);
            this.txtNroVotantes.MouseEnter += new System.EventHandler(this.txtNroVotantes_MouseEnter);
            this.txtNroVotantes.MouseLeave += new System.EventHandler(this.txtNroVotantes_MouseLeave);
            // 
            // cboxProvincia
            // 
            this.cboxProvincia.BackColor = System.Drawing.SystemColors.Control;
            this.cboxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProvincia.Enabled = false;
            this.cboxProvincia.ForeColor = System.Drawing.Color.Black;
            this.cboxProvincia.FormattingEnabled = true;
            this.cboxProvincia.Location = new System.Drawing.Point(629, 84);
            this.cboxProvincia.Name = "cboxProvincia";
            this.cboxProvincia.Size = new System.Drawing.Size(170, 25);
            this.cboxProvincia.TabIndex = 6;
            this.cboxProvincia.SelectionChangeCommitted += new System.EventHandler(this.cboxProvincia_SelectionChangeCommitted);
            // 
            // cboxDistrito
            // 
            this.cboxDistrito.BackColor = System.Drawing.SystemColors.Control;
            this.cboxDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDistrito.Enabled = false;
            this.cboxDistrito.ForeColor = System.Drawing.Color.Black;
            this.cboxDistrito.FormattingEnabled = true;
            this.cboxDistrito.Location = new System.Drawing.Point(629, 115);
            this.cboxDistrito.Name = "cboxDistrito";
            this.cboxDistrito.Size = new System.Drawing.Size(170, 25);
            this.cboxDistrito.TabIndex = 7;
            // 
            // cboxTipoMesa
            // 
            this.cboxTipoMesa.BackColor = System.Drawing.SystemColors.Control;
            this.cboxTipoMesa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoMesa.ForeColor = System.Drawing.Color.Black;
            this.cboxTipoMesa.FormattingEnabled = true;
            this.cboxTipoMesa.Location = new System.Drawing.Point(629, 20);
            this.cboxTipoMesa.Name = "cboxTipoMesa";
            this.cboxTipoMesa.Size = new System.Drawing.Size(170, 25);
            this.cboxTipoMesa.TabIndex = 4;
           
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxProceso);
            this.groupBox1.Controls.Add(this.lblNroMesaRegional);
            this.groupBox1.Controls.Add(this.cboxTipoMesa);
            this.groupBox1.Controls.Add(this.cboxDistrito);
            this.groupBox1.Controls.Add(this.cboxProvincia);
            this.groupBox1.Controls.Add(this.txtNroVotantes);
            this.groupBox1.Controls.Add(this.txtDireLugar);
            this.groupBox1.Controls.Add(this.cboxDepartamento);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.txtnomColegio);
            this.groupBox1.Controls.Add(this.txtNroMesa);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(805, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE MESAS DE LOS LOCALES DE VOTACION";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.label9.Location = new System.Drawing.Point(552, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "DISTRITO :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.label8.Location = new System.Drawing.Point(534, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "PROVINCIA :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.label7.Location = new System.Drawing.Point(504, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "DEPARTAMENTO :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(539, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "TIPO MESA :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.label5.Location = new System.Drawing.Point(30, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "TOTAL ELECTORES :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.label4.Location = new System.Drawing.Point(24, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "DIRECCION LOCAL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.label3.Location = new System.Drawing.Point(24, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "LOCAL VOTACION :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(18, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "MESA SUFRAGIO N° :";
            // 
            // cboxProceso
            // 
            this.cboxProceso.BackColor = System.Drawing.SystemColors.Control;
            this.cboxProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProceso.Enabled = false;
            this.cboxProceso.ForeColor = System.Drawing.Color.Black;
            this.cboxProceso.FormattingEnabled = true;
            this.cboxProceso.Location = new System.Drawing.Point(171, 20);
            this.cboxProceso.Name = "cboxProceso";
            this.cboxProceso.Size = new System.Drawing.Size(328, 25);
            this.cboxProceso.TabIndex = 12;
            // 
            // lblNroMesaRegional
            // 
            this.lblNroMesaRegional.AutoSize = true;
            this.lblNroMesaRegional.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNroMesaRegional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.lblNroMesaRegional.Location = new System.Drawing.Point(6, 23);
            this.lblNroMesaRegional.Name = "lblNroMesaRegional";
            this.lblNroMesaRegional.Size = new System.Drawing.Size(152, 16);
            this.lblNroMesaRegional.TabIndex = 11;
            this.lblNroMesaRegional.Text = "PROCESO ELECTORAL :";
            // 
            // MESAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMesas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAgregados;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscarMesa;
        private System.Windows.Forms.DataGridView dgvMesas;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNroMesa;
        private System.Windows.Forms.TextBox txtnomColegio;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cboxDepartamento;
        private System.Windows.Forms.TextBox txtDireLugar;
        private System.Windows.Forms.TextBox txtNroVotantes;
        private System.Windows.Forms.ComboBox cboxProvincia;
        private System.Windows.Forms.ComboBox cboxDistrito;
        private System.Windows.Forms.ComboBox cboxTipoMesa;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.CheckBox chkCargaMasiva;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNroMesaRegional;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxProceso;
    }
}