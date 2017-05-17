namespace SYSLAB.VISTA.PACIENTES
{
    partial class frmAgregarPaciente
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
            System.Windows.Forms.Label tELEFONOLabel;
            System.Windows.Forms.Label fECHA_NACLabel;
            System.Windows.Forms.Label gIROLabel;
            System.Windows.Forms.Label dIRECCIONLabel;
            System.Windows.Forms.Label mUNICIPIOLabel;
            System.Windows.Forms.Label dEPARTAMENTOLabel;
            System.Windows.Forms.Label nITLabel;
            System.Windows.Forms.Label nRCLabel;
            System.Windows.Forms.Label cREDITO_DIASLabel;
            System.Windows.Forms.Label cORREOLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarPaciente));
            this.tsBarra = new System.Windows.Forms.ToolStrip();
            this.cmdCancelar = new System.Windows.Forms.ToolStripButton();
            this.cmdGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblProd = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudPrecioSel = new System.Windows.Forms.NumericUpDown();
            this.nudDiasCredito = new System.Windows.Forms.NumericUpDown();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtGiro = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtNRC = new System.Windows.Forms.TextBox();
            this.ckGranContribuyente = new System.Windows.Forms.CheckBox();
            this.ckExento = new System.Windows.Forms.CheckBox();
            this.ckCFiscal = new System.Windows.Forms.CheckBox();
            this.ckTasaCero = new System.Windows.Forms.CheckBox();
            this.ckCredito = new System.Windows.Forms.CheckBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            nOMBRESLabel = new System.Windows.Forms.Label();
            tELEFONOLabel = new System.Windows.Forms.Label();
            fECHA_NACLabel = new System.Windows.Forms.Label();
            gIROLabel = new System.Windows.Forms.Label();
            dIRECCIONLabel = new System.Windows.Forms.Label();
            mUNICIPIOLabel = new System.Windows.Forms.Label();
            dEPARTAMENTOLabel = new System.Windows.Forms.Label();
            nITLabel = new System.Windows.Forms.Label();
            nRCLabel = new System.Windows.Forms.Label();
            cREDITO_DIASLabel = new System.Windows.Forms.Label();
            cORREOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tsBarra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioSel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasCredito)).BeginInit();
            this.SuspendLayout();
            // 
            // nOMBRESLabel
            // 
            nOMBRESLabel.AutoSize = true;
            nOMBRESLabel.Location = new System.Drawing.Point(79, 31);
            nOMBRESLabel.Name = "nOMBRESLabel";
            nOMBRESLabel.Size = new System.Drawing.Size(71, 21);
            nOMBRESLabel.TabIndex = 6;
            nOMBRESLabel.Text = "Nombre:";
            // 
            // tELEFONOLabel
            // 
            tELEFONOLabel.AutoSize = true;
            tELEFONOLabel.Location = new System.Drawing.Point(77, 66);
            tELEFONOLabel.Name = "tELEFONOLabel";
            tELEFONOLabel.Size = new System.Drawing.Size(73, 21);
            tELEFONOLabel.TabIndex = 8;
            tELEFONOLabel.Text = "Teléfono:";
            // 
            // fECHA_NACLabel
            // 
            fECHA_NACLabel.AutoSize = true;
            fECHA_NACLabel.Location = new System.Drawing.Point(331, 66);
            fECHA_NACLabel.Name = "fECHA_NACLabel";
            fECHA_NACLabel.Size = new System.Drawing.Size(137, 21);
            fECHA_NACLabel.TabIndex = 10;
            fECHA_NACLabel.Text = "Fecha Nacimiento:";
            // 
            // gIROLabel
            // 
            gIROLabel.AutoSize = true;
            gIROLabel.Location = new System.Drawing.Point(107, 101);
            gIROLabel.Name = "gIROLabel";
            gIROLabel.Size = new System.Drawing.Size(43, 21);
            gIROLabel.TabIndex = 12;
            gIROLabel.Text = "Giro:";
            // 
            // dIRECCIONLabel
            // 
            dIRECCIONLabel.AutoSize = true;
            dIRECCIONLabel.Location = new System.Drawing.Point(72, 136);
            dIRECCIONLabel.Name = "dIRECCIONLabel";
            dIRECCIONLabel.Size = new System.Drawing.Size(78, 21);
            dIRECCIONLabel.TabIndex = 14;
            dIRECCIONLabel.Text = "Dirección:";
            // 
            // mUNICIPIOLabel
            // 
            mUNICIPIOLabel.AutoSize = true;
            mUNICIPIOLabel.Location = new System.Drawing.Point(68, 171);
            mUNICIPIOLabel.Name = "mUNICIPIOLabel";
            mUNICIPIOLabel.Size = new System.Drawing.Size(82, 21);
            mUNICIPIOLabel.TabIndex = 16;
            mUNICIPIOLabel.Text = "Municipio:";
            // 
            // dEPARTAMENTOLabel
            // 
            dEPARTAMENTOLabel.AutoSize = true;
            dEPARTAMENTOLabel.Location = new System.Drawing.Point(37, 206);
            dEPARTAMENTOLabel.Name = "dEPARTAMENTOLabel";
            dEPARTAMENTOLabel.Size = new System.Drawing.Size(113, 21);
            dEPARTAMENTOLabel.TabIndex = 18;
            dEPARTAMENTOLabel.Text = "Departamento:";
            // 
            // nITLabel
            // 
            nITLabel.AutoSize = true;
            nITLabel.Location = new System.Drawing.Point(113, 241);
            nITLabel.Name = "nITLabel";
            nITLabel.Size = new System.Drawing.Size(37, 21);
            nITLabel.TabIndex = 20;
            nITLabel.Text = "NIT:";
            // 
            // nRCLabel
            // 
            nRCLabel.AutoSize = true;
            nRCLabel.Location = new System.Drawing.Point(371, 241);
            nRCLabel.Name = "nRCLabel";
            nRCLabel.Size = new System.Drawing.Size(45, 21);
            nRCLabel.TabIndex = 22;
            nRCLabel.Text = "NRC:";
            // 
            // cREDITO_DIASLabel
            // 
            cREDITO_DIASLabel.AutoSize = true;
            cREDITO_DIASLabel.Location = new System.Drawing.Point(222, 346);
            cREDITO_DIASLabel.Name = "cREDITO_DIASLabel";
            cREDITO_DIASLabel.Size = new System.Drawing.Size(119, 21);
            cREDITO_DIASLabel.TabIndex = 32;
            cREDITO_DIASLabel.Text = "Días de Crédito:";
            // 
            // cORREOLabel
            // 
            cORREOLabel.AutoSize = true;
            cORREOLabel.Location = new System.Drawing.Point(9, 276);
            cORREOLabel.Name = "cORREOLabel";
            cORREOLabel.Size = new System.Drawing.Size(141, 21);
            cORREOLabel.TabIndex = 34;
            cORREOLabel.Text = "Correo electrónico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(423, 344);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 21);
            label1.TabIndex = 32;
            label1.Text = "Nivel de Precio:";
            // 
            // tsBarra
            // 
            this.tsBarra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdCancelar,
            this.cmdGuardar,
            this.toolStripSeparator1,
            this.lblProd});
            this.tsBarra.Location = new System.Drawing.Point(0, 0);
            this.tsBarra.Name = "tsBarra";
            this.tsBarra.Size = new System.Drawing.Size(653, 39);
            this.tsBarra.TabIndex = 37;
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.Image")));
            this.cmdCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(106, 36);
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
            this.cmdGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(103, 36);
            this.cmdGuardar.Text = "Guardar";
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
            this.lblProd.Size = new System.Drawing.Size(128, 36);
            this.lblProd.Text = "Agregar Paciente";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nudPrecioSel);
            this.groupBox1.Controls.Add(this.nudDiasCredito);
            this.groupBox1.Controls.Add(nOMBRESLabel);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(tELEFONOLabel);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(fECHA_NACLabel);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(gIROLabel);
            this.groupBox1.Controls.Add(this.txtGiro);
            this.groupBox1.Controls.Add(dIRECCIONLabel);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(mUNICIPIOLabel);
            this.groupBox1.Controls.Add(this.txtMunicipio);
            this.groupBox1.Controls.Add(dEPARTAMENTOLabel);
            this.groupBox1.Controls.Add(this.txtDepartamento);
            this.groupBox1.Controls.Add(nITLabel);
            this.groupBox1.Controls.Add(this.txtNIT);
            this.groupBox1.Controls.Add(nRCLabel);
            this.groupBox1.Controls.Add(this.txtNRC);
            this.groupBox1.Controls.Add(this.ckGranContribuyente);
            this.groupBox1.Controls.Add(this.ckExento);
            this.groupBox1.Controls.Add(this.ckCFiscal);
            this.groupBox1.Controls.Add(this.ckTasaCero);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.ckCredito);
            this.groupBox1.Controls.Add(cREDITO_DIASLabel);
            this.groupBox1.Controls.Add(cORREOLabel);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(629, 385);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // nudPrecioSel
            // 
            this.nudPrecioSel.Location = new System.Drawing.Point(546, 342);
            this.nudPrecioSel.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudPrecioSel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPrecioSel.Name = "nudPrecioSel";
            this.nudPrecioSel.Size = new System.Drawing.Size(65, 29);
            this.nudPrecioSel.TabIndex = 36;
            this.nudPrecioSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPrecioSel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDiasCredito
            // 
            this.nudDiasCredito.Location = new System.Drawing.Point(347, 342);
            this.nudDiasCredito.Name = "nudDiasCredito";
            this.nudDiasCredito.Size = new System.Drawing.Size(69, 29);
            this.nudDiasCredito.TabIndex = 36;
            this.nudDiasCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(156, 28);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(455, 29);
            this.txtNombres.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(156, 63);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(169, 29);
            this.txtTelefono.TabIndex = 9;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(474, 63);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(137, 29);
            this.dtpFecha.TabIndex = 11;
            // 
            // txtGiro
            // 
            this.txtGiro.Location = new System.Drawing.Point(156, 98);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(455, 29);
            this.txtGiro.TabIndex = 13;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(156, 133);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(455, 29);
            this.txtDireccion.TabIndex = 15;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Location = new System.Drawing.Point(156, 168);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(455, 29);
            this.txtMunicipio.TabIndex = 17;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(156, 203);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(455, 29);
            this.txtDepartamento.TabIndex = 19;
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(156, 238);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(209, 29);
            this.txtNIT.TabIndex = 21;
            // 
            // txtNRC
            // 
            this.txtNRC.Location = new System.Drawing.Point(422, 238);
            this.txtNRC.Name = "txtNRC";
            this.txtNRC.Size = new System.Drawing.Size(189, 29);
            this.txtNRC.TabIndex = 23;
            // 
            // ckGranContribuyente
            // 
            this.ckGranContribuyente.Location = new System.Drawing.Point(68, 311);
            this.ckGranContribuyente.Name = "ckGranContribuyente";
            this.ckGranContribuyente.Size = new System.Drawing.Size(173, 24);
            this.ckGranContribuyente.TabIndex = 25;
            this.ckGranContribuyente.Text = "Gran contribuyente";
            this.ckGranContribuyente.UseVisualStyleBackColor = true;
            // 
            // ckExento
            // 
            this.ckExento.Location = new System.Drawing.Point(535, 310);
            this.ckExento.Name = "ckExento";
            this.ckExento.Size = new System.Drawing.Size(76, 24);
            this.ckExento.TabIndex = 27;
            this.ckExento.Text = "Exento";
            this.ckExento.UseVisualStyleBackColor = true;
            // 
            // ckCFiscal
            // 
            this.ckCFiscal.Location = new System.Drawing.Point(375, 310);
            this.ckCFiscal.Name = "ckCFiscal";
            this.ckCFiscal.Size = new System.Drawing.Size(148, 25);
            this.ckCFiscal.TabIndex = 29;
            this.ckCFiscal.Text = "Crédito Fiscal";
            this.ckCFiscal.UseVisualStyleBackColor = true;
            // 
            // ckTasaCero
            // 
            this.ckTasaCero.Location = new System.Drawing.Point(247, 311);
            this.ckTasaCero.Name = "ckTasaCero";
            this.ckTasaCero.Size = new System.Drawing.Size(118, 24);
            this.ckTasaCero.TabIndex = 29;
            this.ckTasaCero.Text = "Tasa cero";
            this.ckTasaCero.UseVisualStyleBackColor = true;
            // 
            // ckCredito
            // 
            this.ckCredito.Location = new System.Drawing.Point(68, 343);
            this.ckCredito.Name = "ckCredito";
            this.ckCredito.Size = new System.Drawing.Size(148, 24);
            this.ckCredito.TabIndex = 31;
            this.ckCredito.Text = "Pago crédito";
            this.ckCredito.UseVisualStyleBackColor = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(156, 273);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(455, 29);
            this.txtCorreo.TabIndex = 35;
            // 
            // frmAgregarPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 439);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsBarra);
            this.Name = "frmAgregarPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Paciente";
            this.tsBarra.ResumeLayout(false);
            this.tsBarra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrecioSel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiasCredito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip tsBarra;
        internal System.Windows.Forms.ToolStripButton cmdCancelar;
        internal System.Windows.Forms.ToolStripButton cmdGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblProd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.TextBox txtGiro;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.TextBox txtNRC;
        private System.Windows.Forms.CheckBox ckGranContribuyente;
        private System.Windows.Forms.CheckBox ckExento;
        private System.Windows.Forms.CheckBox ckTasaCero;
        private System.Windows.Forms.CheckBox ckCredito;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.NumericUpDown nudDiasCredito;
        private System.Windows.Forms.NumericUpDown nudPrecioSel;
        private System.Windows.Forms.CheckBox ckCFiscal;
    }
}