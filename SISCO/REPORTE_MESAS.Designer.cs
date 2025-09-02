namespace SISCO
{
    partial class REPORTE_MESAS
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Reporte_de_MesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSetPrincipal = new SISCO.DSetPrincipal();
            this.STP_MESASXCOLEGIOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxDist = new System.Windows.Forms.ComboBox();
            this.cboxProv = new System.Windows.Forms.ComboBox();
            this.cboxDepa = new System.Windows.Forms.ComboBox();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxDistrito = new System.Windows.Forms.ComboBox();
            this.cboxProvincia = new System.Windows.Forms.ComboBox();
            this.cboxDepartamento = new System.Windows.Forms.ComboBox();
            this.cboxTipoActa = new System.Windows.Forms.ComboBox();
            this.btnBuscarCOL = new System.Windows.Forms.Button();
            this.Reporte_de_MesasTableAdapter = new SISCO.DSetPrincipalTableAdapters.Reporte_de_MesasTableAdapter();
            this.STP_MESASXCOLEGIOSTableAdapter = new SISCO.DSetPrincipalTableAdapters.STP_MESASXCOLEGIOSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_de_MesasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSetPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STP_MESASXCOLEGIOSBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reporte_de_MesasBindingSource
            // 
            this.Reporte_de_MesasBindingSource.DataMember = "Reporte_de_Mesas";
            this.Reporte_de_MesasBindingSource.DataSource = this.DSetPrincipal;
            // 
            // DSetPrincipal
            // 
            this.DSetPrincipal.DataSetName = "DSetPrincipal";
            this.DSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // STP_MESASXCOLEGIOSBindingSource
            // 
            this.STP_MESASXCOLEGIOSBindingSource.DataMember = "STP_MESASXCOLEGIOS";
            this.STP_MESASXCOLEGIOSBindingSource.DataSource = this.DSetPrincipal;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cboxDist);
            this.groupBox1.Controls.Add(this.cboxProv);
            this.groupBox1.Controls.Add(this.cboxDepa);
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 70);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORTE DE MESAS - ERM 2022";
            // 
            // cboxDist
            // 
            this.cboxDist.BackColor = System.Drawing.SystemColors.Control;
            this.cboxDist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDist.ForeColor = System.Drawing.Color.Black;
            this.cboxDist.FormattingEnabled = true;
            this.cboxDist.Location = new System.Drawing.Point(312, 22);
            this.cboxDist.Name = "cboxDist";
            this.cboxDist.Size = new System.Drawing.Size(147, 25);
            this.cboxDist.TabIndex = 7;
            // 
            // cboxProv
            // 
            this.cboxProv.BackColor = System.Drawing.SystemColors.Control;
            this.cboxProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProv.Enabled = false;
            this.cboxProv.ForeColor = System.Drawing.Color.Black;
            this.cboxProv.FormattingEnabled = true;
            this.cboxProv.Location = new System.Drawing.Point(159, 22);
            this.cboxProv.Name = "cboxProv";
            this.cboxProv.Size = new System.Drawing.Size(147, 25);
            this.cboxProv.TabIndex = 6;
            this.cboxProv.SelectionChangeCommitted += new System.EventHandler(this.cboxProv_SelectionChangeCommitted);
            // 
            // cboxDepa
            // 
            this.cboxDepa.BackColor = System.Drawing.SystemColors.Control;
            this.cboxDepa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDepa.Enabled = false;
            this.cboxDepa.ForeColor = System.Drawing.Color.Black;
            this.cboxDepa.FormattingEnabled = true;
            this.cboxDepa.Location = new System.Drawing.Point(6, 22);
            this.cboxDepa.Name = "cboxDepa";
            this.cboxDepa.Size = new System.Drawing.Size(147, 25);
            this.cboxDepa.TabIndex = 5;
            this.cboxDepa.SelectionChangeCommitted += new System.EventHandler(this.cboxDepa_SelectionChangeCommitted);
            // 
            // cboxEstado
            // 
            this.cboxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxEstado.BackColor = System.Drawing.SystemColors.Control;
            this.cboxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxEstado.ForeColor = System.Drawing.Color.Black;
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Location = new System.Drawing.Point(469, 22);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(147, 25);
            this.cboxEstado.TabIndex = 0;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(206)))), ((int)(((byte)(229)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(622, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 39);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "BUSCAR";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.reportViewer1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(6, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 315);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTENIDO DEL REPORTE - ERM 2022";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.Reporte_de_MesasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCO.Reporte_Mesas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 19);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(739, 293);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 432);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MESAS GENERAL";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MESAS X COLEGIO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.reportViewer2);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(6, 82);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(745, 315);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CONTENIDO DEL REPORTE - ERM 2022";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource4.Name = "DataSet1";
            reportDataSource4.Value = this.STP_MESASXCOLEGIOSBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SISCO.Mesas_x_Colegios.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 19);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(739, 293);
            this.reportViewer2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cboxDistrito);
            this.groupBox3.Controls.Add(this.cboxProvincia);
            this.groupBox3.Controls.Add(this.cboxDepartamento);
            this.groupBox3.Controls.Add(this.cboxTipoActa);
            this.groupBox3.Controls.Add(this.btnBuscarCOL);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 70);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "REPORTE DE MESAS X COLEGIOS - ERM 2022";
            // 
            // cboxDistrito
            // 
            this.cboxDistrito.BackColor = System.Drawing.SystemColors.Control;
            this.cboxDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDistrito.ForeColor = System.Drawing.Color.Black;
            this.cboxDistrito.FormattingEnabled = true;
            this.cboxDistrito.Location = new System.Drawing.Point(312, 22);
            this.cboxDistrito.Name = "cboxDistrito";
            this.cboxDistrito.Size = new System.Drawing.Size(147, 25);
            this.cboxDistrito.TabIndex = 7;
            // 
            // cboxProvincia
            // 
            this.cboxProvincia.BackColor = System.Drawing.SystemColors.Control;
            this.cboxProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxProvincia.Enabled = false;
            this.cboxProvincia.ForeColor = System.Drawing.Color.Black;
            this.cboxProvincia.FormattingEnabled = true;
            this.cboxProvincia.Location = new System.Drawing.Point(159, 22);
            this.cboxProvincia.Name = "cboxProvincia";
            this.cboxProvincia.Size = new System.Drawing.Size(147, 25);
            this.cboxProvincia.TabIndex = 6;
            // 
            // cboxDepartamento
            // 
            this.cboxDepartamento.BackColor = System.Drawing.SystemColors.Control;
            this.cboxDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxDepartamento.Enabled = false;
            this.cboxDepartamento.ForeColor = System.Drawing.Color.Black;
            this.cboxDepartamento.FormattingEnabled = true;
            this.cboxDepartamento.Location = new System.Drawing.Point(6, 22);
            this.cboxDepartamento.Name = "cboxDepartamento";
            this.cboxDepartamento.Size = new System.Drawing.Size(147, 25);
            this.cboxDepartamento.TabIndex = 5;
            // 
            // cboxTipoActa
            // 
            this.cboxTipoActa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxTipoActa.BackColor = System.Drawing.SystemColors.Control;
            this.cboxTipoActa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTipoActa.ForeColor = System.Drawing.Color.Black;
            this.cboxTipoActa.FormattingEnabled = true;
            this.cboxTipoActa.Location = new System.Drawing.Point(469, 22);
            this.cboxTipoActa.Name = "cboxTipoActa";
            this.cboxTipoActa.Size = new System.Drawing.Size(147, 25);
            this.cboxTipoActa.TabIndex = 0;
            // 
            // btnBuscarCOL
            // 
            this.btnBuscarCOL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCOL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.btnBuscarCOL.FlatAppearance.BorderSize = 0;
            this.btnBuscarCOL.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkBlue;
            this.btnBuscarCOL.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(206)))), ((int)(((byte)(229)))));
            this.btnBuscarCOL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCOL.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCOL.Location = new System.Drawing.Point(622, 14);
            this.btnBuscarCOL.Name = "btnBuscarCOL";
            this.btnBuscarCOL.Size = new System.Drawing.Size(117, 39);
            this.btnBuscarCOL.TabIndex = 4;
            this.btnBuscarCOL.Text = "BUSCAR";
            this.btnBuscarCOL.UseVisualStyleBackColor = false;
            this.btnBuscarCOL.Click += new System.EventHandler(this.btnBuscarCOL_Click);
            // 
            // Reporte_de_MesasTableAdapter
            // 
            this.Reporte_de_MesasTableAdapter.ClearBeforeFill = true;
            // 
            // STP_MESASXCOLEGIOSTableAdapter
            // 
            this.STP_MESASXCOLEGIOSTableAdapter.ClearBeforeFill = true;
            // 
            // REPORTE_MESAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(789, 456);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "REPORTE_MESAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE_MESAS";
            this.Load += new System.EventHandler(this.REPORTE_MESAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_de_MesasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSetPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STP_MESASXCOLEGIOSBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cboxDist;
        private System.Windows.Forms.ComboBox cboxProv;
        private System.Windows.Forms.ComboBox cboxDepa;
        private System.Windows.Forms.BindingSource Reporte_de_MesasBindingSource;
        private DSetPrincipal DSetPrincipal;
        private DSetPrincipalTableAdapters.Reporte_de_MesasTableAdapter Reporte_de_MesasTableAdapter;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboxDistrito;
        private System.Windows.Forms.ComboBox cboxProvincia;
        private System.Windows.Forms.ComboBox cboxDepartamento;
        private System.Windows.Forms.ComboBox cboxTipoActa;
        private System.Windows.Forms.Button btnBuscarCOL;
        private System.Windows.Forms.BindingSource STP_MESASXCOLEGIOSBindingSource;
        private DSetPrincipalTableAdapters.STP_MESASXCOLEGIOSTableAdapter STP_MESASXCOLEGIOSTableAdapter;
    }
}