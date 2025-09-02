namespace SISCO
{
    partial class REPORTE_ACTAS
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Reporte_x_Actas_x_PartidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSetPrincipal = new SISCO.DSetPrincipal();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxDist = new System.Windows.Forms.ComboBox();
            this.cboxProv = new System.Windows.Forms.ComboBox();
            this.cboxDepa = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Reporte_x_Actas_x_PartidoTableAdapter = new SISCO.DSetPrincipalTableAdapters.Reporte_x_Actas_x_PartidoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_x_Actas_x_PartidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSetPrincipal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reporte_x_Actas_x_PartidoBindingSource
            // 
            this.Reporte_x_Actas_x_PartidoBindingSource.DataMember = "Reporte_x_Actas_x_Partido";
            this.Reporte_x_Actas_x_PartidoBindingSource.DataSource = this.DSetPrincipal;
            // 
            // DSetPrincipal
            // 
            this.DSetPrincipal.DataSetName = "DSetPrincipal";
            this.DSetPrincipal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cboxDist);
            this.groupBox1.Controls.Add(this.cboxProv);
            this.groupBox1.Controls.Add(this.cboxDepa);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 66);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REPORTE DE ACTAS  - CONTABILIZADAS ERM 2022";
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
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(99)))), ((int)(((byte)(174)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(729, 14);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 434);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTENIDO DEL REPORTE -  ERM 2022";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Reporte_x_Actas_x_PartidoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SISCO.Reporte_Actas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 19);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(846, 412);
            this.reportViewer1.TabIndex = 0;
            // 
            // Reporte_x_Actas_x_PartidoTableAdapter
            // 
            this.Reporte_x_Actas_x_PartidoTableAdapter.ClearBeforeFill = true;
            // 
            // REPORTE_ACTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "REPORTE_ACTAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORTE_ACTAS";
            this.Load += new System.EventHandler(this.REPORTE_ACTAS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Reporte_x_Actas_x_PartidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSetPrincipal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxDist;
        private System.Windows.Forms.ComboBox cboxProv;
        private System.Windows.Forms.ComboBox cboxDepa;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Reporte_x_Actas_x_PartidoBindingSource;
        private DSetPrincipal DSetPrincipal;
        private DSetPrincipalTableAdapters.Reporte_x_Actas_x_PartidoTableAdapter Reporte_x_Actas_x_PartidoTableAdapter;
    }
}