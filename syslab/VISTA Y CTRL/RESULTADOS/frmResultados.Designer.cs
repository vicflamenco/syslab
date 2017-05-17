namespace SYSLAB.VISTA.RESULTADOS
{
    partial class frmResultados
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultados));
            this.dgRegistros = new System.Windows.Forms.DataGridView();
            this.sOLICITUDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSysLab = new SYSLAB.dsSysLab();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.cmdAdministrar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
            this.cmdImprimir = new System.Windows.Forms.ToolStripButton();
            this.sOLICITUDTableAdapter = new SYSLAB.dsSysLabTableAdapters.SOLICITUDTableAdapter();
            this.tableAdapterManager = new SYSLAB.dsSysLabTableAdapters.TableAdapterManager();
            this.nOMBRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDSOLICITUDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDPACIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAEMISIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHAENTREGADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pROCESADADataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLICITUDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgRegistros
            // 
            this.dgRegistros.AllowUserToAddRows = false;
            this.dgRegistros.AllowUserToDeleteRows = false;
            this.dgRegistros.AllowUserToResizeRows = false;
            this.dgRegistros.AutoGenerateColumns = false;
            this.dgRegistros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgRegistros.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nOMBRESDataGridViewTextBoxColumn,
            this.iDSOLICITUDDataGridViewTextBoxColumn,
            this.iDPACIENTEDataGridViewTextBoxColumn,
            this.fECHAEMISIONDataGridViewTextBoxColumn,
            this.fECHAENTREGADataGridViewTextBoxColumn,
            this.pROCESADADataGridViewCheckBoxColumn});
            this.dgRegistros.DataSource = this.sOLICITUDBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRegistros.Location = new System.Drawing.Point(0, 108);
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.ReadOnly = true;
            this.dgRegistros.RowHeadersVisible = false;
            this.dgRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRegistros.Size = new System.Drawing.Size(877, 527);
            this.dgRegistros.TabIndex = 18;
            // 
            // sOLICITUDBindingSource
            // 
            this.sOLICITUDBindingSource.DataMember = "SOLICITUD";
            this.sOLICITUDBindingSource.DataSource = this.dsSysLab;
            // 
            // dsSysLab
            // 
            this.dsSysLab.DataSetName = "dsSysLab";
            this.dsSysLab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 69);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar datos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paciente:";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(86, 28);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(366, 29);
            this.txtDesc.TabIndex = 0;
            this.txtDesc.TextChanged += new System.EventHandler(this.txtDesc_TextChanged);
            // 
            // tsMenu
            // 
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdAdministrar,
            this.ToolStripSeparator1,
            this.lblTitulo,
            this.cmdImprimir});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(877, 39);
            this.tsMenu.TabIndex = 16;
            // 
            // cmdAdministrar
            // 
            this.cmdAdministrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdAdministrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdministrar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdministrar.Image")));
            this.cmdAdministrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAdministrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdministrar.Name = "cmdAdministrar";
            this.cmdAdministrar.Size = new System.Drawing.Size(204, 36);
            this.cmdAdministrar.Text = "Administrar resultados";
            this.cmdAdministrar.Click += new System.EventHandler(this.cmdAdministrar_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Image = ((System.Drawing.Image)(resources.GetObject("lblTitulo.Image")));
            this.lblTitulo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(249, 36);
            this.lblTitulo.Text = "Resultados de análisis clínicos";
            // 
            // cmdImprimir
            // 
            this.cmdImprimir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdImprimir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cmdImprimir.Image")));
            this.cmdImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdImprimir.Name = "cmdImprimir";
            this.cmdImprimir.Size = new System.Drawing.Size(107, 36);
            this.cmdImprimir.Text = "Imprimir";
            this.cmdImprimir.Click += new System.EventHandler(this.cmdImprimir_Click);
            // 
            // sOLICITUDTableAdapter
            // 
            this.sOLICITUDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANALISIS_DATOTableAdapter = null;
            this.tableAdapterManager.ANALISISTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = null;
            this.tableAdapterManager.COTIZACION_DETALLETableAdapter = null;
            this.tableAdapterManager.COTIZACIONTableAdapter = null;
            this.tableAdapterManager.DOCTORESTableAdapter = null;
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
            this.tableAdapterManager.SOLICITUDTableAdapter = this.sOLICITUDTableAdapter;
            this.tableAdapterManager.TALONARIOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SYSLAB.dsSysLabTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // nOMBRESDataGridViewTextBoxColumn
            // 
            this.nOMBRESDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMBRESDataGridViewTextBoxColumn.DataPropertyName = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.HeaderText = "PACIENTE";
            this.nOMBRESDataGridViewTextBoxColumn.Name = "nOMBRESDataGridViewTextBoxColumn";
            this.nOMBRESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDSOLICITUDDataGridViewTextBoxColumn
            // 
            this.iDSOLICITUDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDSOLICITUDDataGridViewTextBoxColumn.DataPropertyName = "ID_SOLICITUD";
            this.iDSOLICITUDDataGridViewTextBoxColumn.HeaderText = "ID_SOLICITUD";
            this.iDSOLICITUDDataGridViewTextBoxColumn.Name = "iDSOLICITUDDataGridViewTextBoxColumn";
            this.iDSOLICITUDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSOLICITUDDataGridViewTextBoxColumn.Visible = false;
            this.iDSOLICITUDDataGridViewTextBoxColumn.Width = 134;
            // 
            // iDPACIENTEDataGridViewTextBoxColumn
            // 
            this.iDPACIENTEDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDPACIENTEDataGridViewTextBoxColumn.DataPropertyName = "ID_PACIENTE";
            this.iDPACIENTEDataGridViewTextBoxColumn.HeaderText = "ID_PACIENTE";
            this.iDPACIENTEDataGridViewTextBoxColumn.Name = "iDPACIENTEDataGridViewTextBoxColumn";
            this.iDPACIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDPACIENTEDataGridViewTextBoxColumn.Visible = false;
            this.iDPACIENTEDataGridViewTextBoxColumn.Width = 126;
            // 
            // fECHAEMISIONDataGridViewTextBoxColumn
            // 
            this.fECHAEMISIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fECHAEMISIONDataGridViewTextBoxColumn.DataPropertyName = "FECHA_EMISION";
            this.fECHAEMISIONDataGridViewTextBoxColumn.HeaderText = "FECHA EMISIÓN";
            this.fECHAEMISIONDataGridViewTextBoxColumn.Name = "fECHAEMISIONDataGridViewTextBoxColumn";
            this.fECHAEMISIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHAEMISIONDataGridViewTextBoxColumn.Width = 149;
            // 
            // fECHAENTREGADataGridViewTextBoxColumn
            // 
            this.fECHAENTREGADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.fECHAENTREGADataGridViewTextBoxColumn.DataPropertyName = "FECHA_ENTREGA";
            this.fECHAENTREGADataGridViewTextBoxColumn.HeaderText = "FECHA ENTREGA";
            this.fECHAENTREGADataGridViewTextBoxColumn.Name = "fECHAENTREGADataGridViewTextBoxColumn";
            this.fECHAENTREGADataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHAENTREGADataGridViewTextBoxColumn.Width = 153;
            // 
            // pROCESADADataGridViewCheckBoxColumn
            // 
            this.pROCESADADataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pROCESADADataGridViewCheckBoxColumn.DataPropertyName = "PROCESADA";
            this.pROCESADADataGridViewCheckBoxColumn.HeaderText = "PROCESADA";
            this.pROCESADADataGridViewCheckBoxColumn.Name = "pROCESADADataGridViewCheckBoxColumn";
            this.pROCESADADataGridViewCheckBoxColumn.ReadOnly = true;
            this.pROCESADADataGridViewCheckBoxColumn.Visible = false;
            this.pROCESADADataGridViewCheckBoxColumn.Width = 105;
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 635);
            this.Controls.Add(this.dgRegistros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsMenu);
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resultados de análisis clínicos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLICITUDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgRegistros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        internal System.Windows.Forms.ToolStrip tsMenu;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblTitulo;
        internal System.Windows.Forms.ToolStripButton cmdAdministrar;
        private dsSysLab dsSysLab;
        private System.Windows.Forms.BindingSource sOLICITUDBindingSource;
        private dsSysLabTableAdapters.SOLICITUDTableAdapter sOLICITUDTableAdapter;
        private dsSysLabTableAdapters.TableAdapterManager tableAdapterManager;
        internal System.Windows.Forms.ToolStripButton cmdImprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSOLICITUDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPACIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAEMISIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAENTREGADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pROCESADADataGridViewCheckBoxColumn;
    }
}