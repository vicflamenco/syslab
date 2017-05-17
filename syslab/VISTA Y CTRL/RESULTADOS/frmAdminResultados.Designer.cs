namespace SYSLAB.VISTA.RESULTADOS
{
    partial class frmAdminResultados
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
            System.Windows.Forms.Label nOMBRESLabel;
            System.Windows.Forms.Label fECHA_NACLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminResultados));
            this.tsBarra = new System.Windows.Forms.ToolStrip();
            this.cmdGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblProd = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbProgreso = new System.Windows.Forms.ProgressBar();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.dtpRequerido = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgRegistros = new System.Windows.Forms.DataGridView();
            this.tsMovimientos = new System.Windows.Forms.ToolStrip();
            this.cmdEditar = new System.Windows.Forms.ToolStripButton();
            this.cmdMostrar = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdAnalisis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObserv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nOMBRESLabel = new System.Windows.Forms.Label();
            fECHA_NACLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.tsBarra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            this.tsMovimientos.SuspendLayout();
            this.SuspendLayout();
            // 
            // nOMBRESLabel
            // 
            nOMBRESLabel.AutoSize = true;
            nOMBRESLabel.Location = new System.Drawing.Point(10, 66);
            nOMBRESLabel.Name = "nOMBRESLabel";
            nOMBRESLabel.Size = new System.Drawing.Size(71, 21);
            nOMBRESLabel.TabIndex = 6;
            nOMBRESLabel.Text = "Paciente:";
            // 
            // fECHA_NACLabel
            // 
            fECHA_NACLabel.AutoSize = true;
            fECHA_NACLabel.Location = new System.Drawing.Point(10, 31);
            fECHA_NACLabel.Name = "fECHA_NACLabel";
            fECHA_NACLabel.Size = new System.Drawing.Size(117, 21);
            fECHA_NACLabel.TabIndex = 10;
            fECHA_NACLabel.Text = "Fecha Solicitud:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(265, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(128, 21);
            label1.TabIndex = 10;
            label1.Text = "Fecha Requerida:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 102);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 21);
            label2.TabIndex = 6;
            label2.Text = "Progreso:";
            // 
            // tsBarra
            // 
            this.tsBarra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdGuardar,
            this.toolStripSeparator1,
            this.lblProd});
            this.tsBarra.Location = new System.Drawing.Point(0, 0);
            this.tsBarra.Name = "tsBarra";
            this.tsBarra.Size = new System.Drawing.Size(568, 39);
            this.tsBarra.TabIndex = 37;
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
            this.cmdGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(90, 36);
            this.cmdGuardar.Text = "Cerrar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // lblProd
            // 
            this.lblProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(189, 36);
            this.lblProd.Text = "Administrando resultados";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pbProgreso);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(nOMBRESLabel);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(fECHA_NACLabel);
            this.groupBox1.Controls.Add(this.dtpRequerido);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 140);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // pbProgreso
            // 
            this.pbProgreso.Location = new System.Drawing.Point(87, 98);
            this.pbProgreso.Name = "pbProgreso";
            this.pbProgreso.Size = new System.Drawing.Size(438, 30);
            this.pbProgreso.Step = 1;
            this.pbProgreso.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbProgreso.TabIndex = 3;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(87, 63);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.ReadOnly = true;
            this.txtNombres.Size = new System.Drawing.Size(438, 29);
            this.txtNombres.TabIndex = 2;
            // 
            // dtpRequerido
            // 
            this.dtpRequerido.Enabled = false;
            this.dtpRequerido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequerido.Location = new System.Drawing.Point(399, 28);
            this.dtpRequerido.Name = "dtpRequerido";
            this.dtpRequerido.Size = new System.Drawing.Size(126, 29);
            this.dtpRequerido.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Enabled = false;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(133, 28);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(126, 29);
            this.dtpFecha.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgRegistros);
            this.groupBox2.Controls.Add(this.tsMovimientos);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 287);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Análisis solicitados";
            // 
            // dgRegistros
            // 
            this.dgRegistros.AllowUserToAddRows = false;
            this.dgRegistros.AllowUserToDeleteRows = false;
            this.dgRegistros.BackgroundColor = System.Drawing.Color.White;
            this.dgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdAnalisis,
            this.codNombre,
            this.colObserv});
            this.dgRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRegistros.Location = new System.Drawing.Point(3, 52);
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.ReadOnly = true;
            this.dgRegistros.RowHeadersVisible = false;
            this.dgRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRegistros.Size = new System.Drawing.Size(538, 232);
            this.dgRegistros.TabIndex = 4;
            // 
            // tsMovimientos
            // 
            this.tsMovimientos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMovimientos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdEditar,
            this.cmdMostrar});
            this.tsMovimientos.Location = new System.Drawing.Point(3, 25);
            this.tsMovimientos.Name = "tsMovimientos";
            this.tsMovimientos.Size = new System.Drawing.Size(538, 27);
            this.tsMovimientos.TabIndex = 51;
            this.tsMovimientos.Text = "ToolStrip2";
            // 
            // cmdEditar
            // 
            this.cmdEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdEditar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditar.Image = ((System.Drawing.Image)(resources.GetObject("cmdEditar.Image")));
            this.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(138, 24);
            this.cmdEditar.Text = "Editar Resultado";
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdMostrar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMostrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdMostrar.Image")));
            this.cmdMostrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(150, 24);
            this.cmdMostrar.Text = "Mostrar Resultado";
            this.cmdMostrar.Click += new System.EventHandler(this.cmdMostrar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód. Análisis";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // colIdAnalisis
            // 
            this.colIdAnalisis.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colIdAnalisis.HeaderText = "Cód. Análisis";
            this.colIdAnalisis.Name = "colIdAnalisis";
            this.colIdAnalisis.ReadOnly = true;
            this.colIdAnalisis.Visible = false;
            this.colIdAnalisis.Width = 104;
            // 
            // codNombre
            // 
            this.codNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.codNombre.HeaderText = "Nombre";
            this.codNombre.Name = "codNombre";
            this.codNombre.ReadOnly = true;
            // 
            // colObserv
            // 
            this.colObserv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colObserv.HeaderText = "Observaciones";
            this.colObserv.Name = "colObserv";
            this.colObserv.ReadOnly = true;
            // 
            // frmAdminResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 487);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAdminResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrando resultados";
            this.tsBarra.ResumeLayout(false);
            this.tsBarra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            this.tsMovimientos.ResumeLayout(false);
            this.tsMovimientos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip tsBarra;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        internal System.Windows.Forms.ToolStripButton cmdGuardar;
        private System.Windows.Forms.DateTimePicker dtpRequerido;
        private System.Windows.Forms.ProgressBar pbProgreso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgRegistros;
        internal System.Windows.Forms.ToolStrip tsMovimientos;
        internal System.Windows.Forms.ToolStripButton cmdEditar;
        internal System.Windows.Forms.ToolStripButton cmdMostrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdAnalisis;
        private System.Windows.Forms.DataGridViewTextBoxColumn codNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObserv;
    }
}