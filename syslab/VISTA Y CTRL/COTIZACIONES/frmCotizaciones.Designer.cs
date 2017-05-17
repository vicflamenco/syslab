namespace SYSLAB.VISTA.COTIZACIONES
{
    partial class frmCotizaciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCotizaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgRegistros = new System.Windows.Forms.DataGridView();
            this.dOCTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSysLab = new SYSLAB.dsSysLab();
            this.cOTIZACIONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pACIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.cmdEliminar = new System.Windows.Forms.ToolStripButton();
            this.cmdEditar = new System.Windows.Forms.ToolStripButton();
            this.cmdAgregar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
            this.cOTIZACIONTableAdapter = new SYSLAB.dsSysLabTableAdapters.COTIZACIONTableAdapter();
            this.tableAdapterManager = new SYSLAB.dsSysLabTableAdapters.TableAdapterManager();
            this.pACIENTETableAdapter = new SYSLAB.dsSysLabTableAdapters.PACIENTETableAdapter();
            this.dOCTORESTableAdapter = new SYSLAB.dsSysLabTableAdapters.DOCTORESTableAdapter();
            this.iDCOTIZACIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDOCTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fECHAEMISIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONTOGRAVADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONTOIVADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUBTOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONTOEXENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mONTORETENCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tOTALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOTIZACIONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEBindingSource)).BeginInit();
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
            this.iDCOTIZACIONDataGridViewTextBoxColumn,
            this.nOMBRESDataGridViewTextBoxColumn,
            this.iDDOCTORDataGridViewTextBoxColumn,
            this.fECHAEMISIONDataGridViewTextBoxColumn,
            this.mONTOGRAVADODataGridViewTextBoxColumn,
            this.mONTOIVADataGridViewTextBoxColumn,
            this.sUBTOTALDataGridViewTextBoxColumn,
            this.mONTOEXENTODataGridViewTextBoxColumn,
            this.mONTORETENCIONDataGridViewTextBoxColumn,
            this.tOTALDataGridViewTextBoxColumn});
            this.dgRegistros.DataSource = this.cOTIZACIONBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRegistros.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRegistros.Location = new System.Drawing.Point(0, 108);
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.ReadOnly = true;
            this.dgRegistros.RowHeadersVisible = false;
            this.dgRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRegistros.Size = new System.Drawing.Size(873, 553);
            this.dgRegistros.TabIndex = 21;
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
            // cOTIZACIONBindingSource
            // 
            this.cOTIZACIONBindingSource.DataMember = "COTIZACION";
            this.cOTIZACIONBindingSource.DataSource = this.dsSysLab;
            // 
            // pACIENTEBindingSource
            // 
            this.pACIENTEBindingSource.DataMember = "PACIENTE";
            this.pACIENTEBindingSource.DataSource = this.dsSysLab;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 69);
            this.groupBox1.TabIndex = 20;
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
            this.cmdEliminar,
            this.cmdEditar,
            this.cmdAgregar,
            this.ToolStripSeparator1,
            this.lblTitulo});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(873, 39);
            this.tsMenu.TabIndex = 19;
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdEliminar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminar.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminar.Image")));
            this.cmdEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(103, 36);
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // cmdEditar
            // 
            this.cmdEditar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdEditar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditar.Image = ((System.Drawing.Image)(resources.GetObject("cmdEditar.Image")));
            this.cmdEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEditar.Name = "cmdEditar";
            this.cmdEditar.Size = new System.Drawing.Size(112, 36);
            this.cmdEditar.Text = "Modificar";
            this.cmdEditar.Click += new System.EventHandler(this.cmdEditar_Click);
            // 
            // cmdAgregar
            // 
            this.cmdAgregar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdAgregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregar.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregar.Image")));
            this.cmdAgregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAgregar.Name = "cmdAgregar";
            this.cmdAgregar.Size = new System.Drawing.Size(102, 36);
            this.cmdAgregar.Text = "Agregar";
            this.cmdAgregar.Click += new System.EventHandler(this.cmdAgregar_Click);
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
            this.lblTitulo.Size = new System.Drawing.Size(260, 36);
            this.lblTitulo.Text = "Cotizaciones de análisis clínicos";
            // 
            // cOTIZACIONTableAdapter
            // 
            this.cOTIZACIONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANALISIS_DATOTableAdapter = null;
            this.tableAdapterManager.ANALISISTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = null;
            this.tableAdapterManager.COTIZACION_DETALLETableAdapter = null;
            this.tableAdapterManager.COTIZACIONTableAdapter = this.cOTIZACIONTableAdapter;
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
            this.tableAdapterManager.SOLICITUDTableAdapter = null;
            this.tableAdapterManager.TALONARIOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SYSLAB.dsSysLabTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // pACIENTETableAdapter
            // 
            this.pACIENTETableAdapter.ClearBeforeFill = true;
            // 
            // dOCTORESTableAdapter
            // 
            this.dOCTORESTableAdapter.ClearBeforeFill = true;
            // 
            // iDCOTIZACIONDataGridViewTextBoxColumn
            // 
            this.iDCOTIZACIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDCOTIZACIONDataGridViewTextBoxColumn.DataPropertyName = "ID_COTIZACION";
            this.iDCOTIZACIONDataGridViewTextBoxColumn.HeaderText = "ID_COTIZACION";
            this.iDCOTIZACIONDataGridViewTextBoxColumn.Name = "iDCOTIZACIONDataGridViewTextBoxColumn";
            this.iDCOTIZACIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDCOTIZACIONDataGridViewTextBoxColumn.Visible = false;
            this.iDCOTIZACIONDataGridViewTextBoxColumn.Width = 129;
            // 
            // nOMBRESDataGridViewTextBoxColumn
            // 
            this.nOMBRESDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nOMBRESDataGridViewTextBoxColumn.DataPropertyName = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.HeaderText = "PACIENTE";
            this.nOMBRESDataGridViewTextBoxColumn.Name = "nOMBRESDataGridViewTextBoxColumn";
            this.nOMBRESDataGridViewTextBoxColumn.ReadOnly = true;
            this.nOMBRESDataGridViewTextBoxColumn.Width = 104;
            // 
            // iDDOCTORDataGridViewTextBoxColumn
            // 
            this.iDDOCTORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDDOCTORDataGridViewTextBoxColumn.DataPropertyName = "ID_DOCTOR";
            this.iDDOCTORDataGridViewTextBoxColumn.DataSource = this.dOCTORESBindingSource;
            this.iDDOCTORDataGridViewTextBoxColumn.DisplayMember = "NOMBRES";
            this.iDDOCTORDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDDOCTORDataGridViewTextBoxColumn.HeaderText = "DOCTOR";
            this.iDDOCTORDataGridViewTextBoxColumn.Name = "iDDOCTORDataGridViewTextBoxColumn";
            this.iDDOCTORDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDOCTORDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDDOCTORDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDDOCTORDataGridViewTextBoxColumn.ValueMember = "ID_DOCTOR";
            this.iDDOCTORDataGridViewTextBoxColumn.Width = 98;
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
            // mONTOGRAVADODataGridViewTextBoxColumn
            // 
            this.mONTOGRAVADODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mONTOGRAVADODataGridViewTextBoxColumn.DataPropertyName = "MONTO_GRAVADO";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "$0.00";
            this.mONTOGRAVADODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.mONTOGRAVADODataGridViewTextBoxColumn.HeaderText = "MONTO GRAVADO";
            this.mONTOGRAVADODataGridViewTextBoxColumn.Name = "mONTOGRAVADODataGridViewTextBoxColumn";
            this.mONTOGRAVADODataGridViewTextBoxColumn.ReadOnly = true;
            this.mONTOGRAVADODataGridViewTextBoxColumn.Width = 156;
            // 
            // mONTOIVADataGridViewTextBoxColumn
            // 
            this.mONTOIVADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mONTOIVADataGridViewTextBoxColumn.DataPropertyName = "MONTO_IVA";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = "$0.00";
            this.mONTOIVADataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.mONTOIVADataGridViewTextBoxColumn.HeaderText = "MONTO IVA";
            this.mONTOIVADataGridViewTextBoxColumn.Name = "mONTOIVADataGridViewTextBoxColumn";
            this.mONTOIVADataGridViewTextBoxColumn.ReadOnly = true;
            this.mONTOIVADataGridViewTextBoxColumn.Width = 111;
            // 
            // sUBTOTALDataGridViewTextBoxColumn
            // 
            this.sUBTOTALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sUBTOTALDataGridViewTextBoxColumn.DataPropertyName = "SUBTOTAL";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "$0.00";
            this.sUBTOTALDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.sUBTOTALDataGridViewTextBoxColumn.HeaderText = "SUBTOTAL";
            this.sUBTOTALDataGridViewTextBoxColumn.Name = "sUBTOTALDataGridViewTextBoxColumn";
            this.sUBTOTALDataGridViewTextBoxColumn.ReadOnly = true;
            this.sUBTOTALDataGridViewTextBoxColumn.Width = 110;
            // 
            // mONTOEXENTODataGridViewTextBoxColumn
            // 
            this.mONTOEXENTODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mONTOEXENTODataGridViewTextBoxColumn.DataPropertyName = "MONTO_EXENTO";
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = "$0.00";
            this.mONTOEXENTODataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.mONTOEXENTODataGridViewTextBoxColumn.HeaderText = "MONTO EXENTO";
            this.mONTOEXENTODataGridViewTextBoxColumn.Name = "mONTOEXENTODataGridViewTextBoxColumn";
            this.mONTOEXENTODataGridViewTextBoxColumn.ReadOnly = true;
            this.mONTOEXENTODataGridViewTextBoxColumn.Width = 141;
            // 
            // mONTORETENCIONDataGridViewTextBoxColumn
            // 
            this.mONTORETENCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.mONTORETENCIONDataGridViewTextBoxColumn.DataPropertyName = "MONTO_RETENCION";
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "$0.00";
            this.mONTORETENCIONDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.mONTORETENCIONDataGridViewTextBoxColumn.HeaderText = "MONTO RETENCION";
            this.mONTORETENCIONDataGridViewTextBoxColumn.Name = "mONTORETENCIONDataGridViewTextBoxColumn";
            this.mONTORETENCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.mONTORETENCIONDataGridViewTextBoxColumn.Width = 165;
            // 
            // tOTALDataGridViewTextBoxColumn
            // 
            this.tOTALDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tOTALDataGridViewTextBoxColumn.DataPropertyName = "TOTAL";
            dataGridViewCellStyle7.Format = "C2";
            dataGridViewCellStyle7.NullValue = "$0.00";
            this.tOTALDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.tOTALDataGridViewTextBoxColumn.HeaderText = "TOTAL";
            this.tOTALDataGridViewTextBoxColumn.Name = "tOTALDataGridViewTextBoxColumn";
            this.tOTALDataGridViewTextBoxColumn.ReadOnly = true;
            this.tOTALDataGridViewTextBoxColumn.Width = 81;
            // 
            // frmCotizaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 661);
            this.Controls.Add(this.dgRegistros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsMenu);
            this.Name = "frmCotizaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cotizaciones";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCotizaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOTIZACIONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEBindingSource)).EndInit();
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
        internal System.Windows.Forms.ToolStripButton cmdEliminar;
        internal System.Windows.Forms.ToolStripButton cmdEditar;
        internal System.Windows.Forms.ToolStripButton cmdAgregar;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblTitulo;
        private dsSysLab dsSysLab;
        private System.Windows.Forms.BindingSource cOTIZACIONBindingSource;
        private dsSysLabTableAdapters.COTIZACIONTableAdapter cOTIZACIONTableAdapter;
        private dsSysLabTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource pACIENTEBindingSource;
        private dsSysLabTableAdapters.PACIENTETableAdapter pACIENTETableAdapter;
        private System.Windows.Forms.BindingSource dOCTORESBindingSource;
        private dsSysLabTableAdapters.DOCTORESTableAdapter dOCTORESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDCOTIZACIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDDOCTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHAEMISIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTOGRAVADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTOIVADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUBTOTALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTOEXENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mONTORETENCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tOTALDataGridViewTextBoxColumn;
    }
}