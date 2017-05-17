namespace SYSLAB.VISTA.TALONARIOS
{
    partial class frmAgregarTalonario
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
            System.Windows.Forms.Label nOMBRESLabel;
            System.Windows.Forms.Label dIRECCIONLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarTalonario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.dOCTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSysLab = new SYSLAB.dsSysLab();
            this.tsBarra = new System.Windows.Forms.ToolStrip();
            this.cmdCancelar = new System.Windows.Forms.ToolStripButton();
            this.cmdGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
            this.dOCTORESTableAdapter = new SYSLAB.dsSysLabTableAdapters.DOCTORESTableAdapter();
            this.tableAdapterManager = new SYSLAB.dsSysLabTableAdapters.TableAdapterManager();
            nOMBRESLabel = new System.Windows.Forms.Label();
            dIRECCIONLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).BeginInit();
            this.tsBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // nOMBRESLabel
            // 
            nOMBRESLabel.AutoSize = true;
            nOMBRESLabel.Location = new System.Drawing.Point(59, 25);
            nOMBRESLabel.Name = "nOMBRESLabel";
            nOMBRESLabel.Size = new System.Drawing.Size(60, 21);
            nOMBRESLabel.TabIndex = 6;
            nOMBRESLabel.Text = "Doctor:";
            // 
            // dIRECCIONLabel
            // 
            dIRECCIONLabel.AutoSize = true;
            dIRECCIONLabel.Location = new System.Drawing.Point(9, 61);
            dIRECCIONLabel.Name = "dIRECCIONLabel";
            dIRECCIONLabel.Size = new System.Drawing.Size(110, 21);
            dIRECCIONLabel.TabIndex = 14;
            dIRECCIONLabel.Text = "Fecha Entrega:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 92);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(75, 21);
            label1.TabIndex = 24;
            label1.Text = "Cantidad:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.nudCantidad);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.dtpFecha);
            this.groupBox1.Controls.Add(this.cbDoctor);
            this.groupBox1.Controls.Add(nOMBRESLabel);
            this.groupBox1.Controls.Add(dIRECCIONLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 138);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(125, 90);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(322, 29);
            this.nudCantidad.TabIndex = 25;
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(125, 57);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(322, 27);
            this.dtpFecha.TabIndex = 23;
            // 
            // cbDoctor
            // 
            this.cbDoctor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dOCTORESBindingSource, "ID_DOCTOR", true));
            this.cbDoctor.DataSource = this.dOCTORESBindingSource;
            this.cbDoctor.DisplayMember = "NOMBRES";
            this.cbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(125, 22);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(322, 29);
            this.cbDoctor.TabIndex = 22;
            this.cbDoctor.ValueMember = "ID_DOCTOR";
            this.cbDoctor.SelectedIndexChanged += new System.EventHandler(this.cbDoctor_SelectedIndexChanged);
            // 
            // dOCTORESBindingSource
            // 
            this.dOCTORESBindingSource.DataMember = "DOCTORES";
            this.dOCTORESBindingSource.DataSource = this.dsSysLab;
            // 
            // dsSysLab
            // 
            this.dsSysLab.DataSetName = "dsSysLab";
            this.dsSysLab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tsBarra
            // 
            this.tsBarra.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsBarra.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdCancelar,
            this.cmdGuardar,
            this.toolStripSeparator1,
            this.lblTitulo});
            this.tsBarra.Location = new System.Drawing.Point(0, 0);
            this.tsBarra.Name = "tsBarra";
            this.tsBarra.Size = new System.Drawing.Size(503, 39);
            this.tsBarra.TabIndex = 39;
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
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(159, 36);
            this.lblTitulo.Text = "Control de Talonarios";
            // 
            // dOCTORESTableAdapter
            // 
            this.dOCTORESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANALISIS_DATOTableAdapter = null;
            this.tableAdapterManager.ANALISISTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = null;
            this.tableAdapterManager.COTIZACION_DETALLETableAdapter = null;
            this.tableAdapterManager.COTIZACIONTableAdapter = null;
            this.tableAdapterManager.DOCTORESTableAdapter = this.dOCTORESTableAdapter;
            this.tableAdapterManager.EMPRESA_SECTORTableAdapter = null;
            this.tableAdapterManager.EMPRESATableAdapter = null;
            this.tableAdapterManager.EX_BACITableAdapter = null;
            this.tableAdapterManager.EX_HCES_GRALTableAdapter = null;
            this.tableAdapterManager.EX_HMTO_GRALTableAdapter = null;
            this.tableAdapterManager.EX_ORNA_GRALTableAdapter = null;
            this.tableAdapterManager.EX_QMSA_ESP_DETALLETableAdapter = null;
            this.tableAdapterManager.EX_QMSA_ESPTableAdapter = null;
            this.tableAdapterManager.EX_VDRLTableAdapter = null;
            this.tableAdapterManager.FAMILIATableAdapter = null;
            this.tableAdapterManager.PACIENTETableAdapter = null;
            this.tableAdapterManager.PARAMETROTableAdapter = null;
            this.tableAdapterManager.SOLICITUD_DETALLETableAdapter = null;
            this.tableAdapterManager.SOLICITUD_RESULTADO_DETALLETableAdapter = null;
            this.tableAdapterManager.SOLICITUD_RESULTADOTableAdapter = null;
            this.tableAdapterManager.SOLICITUDTableAdapter = null;
            this.tableAdapterManager.TALONARIOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SYSLAB.dsSysLabTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // frmAgregarTalonario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 192);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsBarra);
            this.Name = "frmAgregarTalonario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Talonarios";
            this.Load += new System.EventHandler(this.frmAgregarTalonario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).EndInit();
            this.tsBarra.ResumeLayout(false);
            this.tsBarra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.ToolStrip tsBarra;
        internal System.Windows.Forms.ToolStripButton cmdCancelar;
        internal System.Windows.Forms.ToolStripButton cmdGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblTitulo;
        private dsSysLab dsSysLab;
        private System.Windows.Forms.BindingSource dOCTORESBindingSource;
        private dsSysLabTableAdapters.DOCTORESTableAdapter dOCTORESTableAdapter;
        private dsSysLabTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cbDoctor;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.NumericUpDown nudCantidad;
    }
}