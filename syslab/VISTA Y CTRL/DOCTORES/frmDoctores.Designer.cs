namespace SYSLAB.VISTA.DOCTORES
{
    partial class frmDoctores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctores));
            this.dgRegistros = new System.Windows.Forms.DataGridView();
            this.dOCTORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSysLab = new SYSLAB.dsSysLab();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.cmdEliminar = new System.Windows.Forms.ToolStripButton();
            this.cmdEditar = new System.Windows.Forms.ToolStripButton();
            this.cmdAgregar = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdMostar = new System.Windows.Forms.ToolStripButton();
            this.dOCTORESTableAdapter = new SYSLAB.dsSysLabTableAdapters.DOCTORESTableAdapter();
            this.tableAdapterManager = new SYSLAB.dsSysLabTableAdapters.TableAdapterManager();
            this.eMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eMPRESATableAdapter = new SYSLAB.dsSysLabTableAdapters.EMPRESATableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDOCTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHACREADODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLINICANOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLINICATELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDEMPRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).BeginInit();
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
            this.iDDOCTORDataGridViewTextBoxColumn,
            this.fECHACREADODataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.nITDataGridViewTextBoxColumn,
            this.dUIDataGridViewTextBoxColumn,
            this.cORREODataGridViewTextBoxColumn,
            this.cLINICANOMBREDataGridViewTextBoxColumn,
            this.cLINICATELEFONODataGridViewTextBoxColumn,
            this.iDEMPRESADataGridViewTextBoxColumn});
            this.dgRegistros.DataSource = this.dOCTORESBindingSource;
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
            this.label1.Text = "Nombre:";
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
            this.lblTitulo,
            this.toolStripSeparator2,
            this.cmdMostar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(877, 39);
            this.tsMenu.TabIndex = 16;
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
            this.lblTitulo.Size = new System.Drawing.Size(104, 36);
            this.lblTitulo.Text = "Doctores";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // cmdMostar
            // 
            this.cmdMostar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMostar.Image = ((System.Drawing.Image)(resources.GetObject("cmdMostar.Image")));
            this.cmdMostar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdMostar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdMostar.Name = "cmdMostar";
            this.cmdMostar.Size = new System.Drawing.Size(101, 36);
            this.cmdMostar.Text = "Mostrar";
            this.cmdMostar.Click += new System.EventHandler(this.cmdMostar_Click);
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
            // eMPRESABindingSource
            // 
            this.eMPRESABindingSource.DataMember = "EMPRESA";
            this.eMPRESABindingSource.DataSource = this.dsSysLab;
            // 
            // eMPRESATableAdapter
            // 
            this.eMPRESATableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NOMBRES";
            this.dataGridViewTextBoxColumn1.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_DOCTOR";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_DOCTOR";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 120;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FECHA_CREADO";
            this.dataGridViewTextBoxColumn3.HeaderText = "FECHA_CREADO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TELEFONO";
            this.dataGridViewTextBoxColumn4.HeaderText = "TELEFONO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 111;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DIRECCION";
            this.dataGridViewTextBoxColumn5.HeaderText = "DIRECCION";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "NIT";
            this.dataGridViewTextBoxColumn6.HeaderText = "NIT";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DUI";
            this.dataGridViewTextBoxColumn7.HeaderText = "DUI";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CORREO";
            this.dataGridViewTextBoxColumn8.HeaderText = "CORREO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CLINICA_NOMBRE";
            this.dataGridViewTextBoxColumn9.HeaderText = "CLINICA";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn10.DataPropertyName = "CLINICA_TELEFONO";
            this.dataGridViewTextBoxColumn10.HeaderText = "TELEFONO CLÍNICA";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 158;
            // 
            // nOMBRESDataGridViewTextBoxColumn
            // 
            this.nOMBRESDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMBRESDataGridViewTextBoxColumn.DataPropertyName = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBRESDataGridViewTextBoxColumn.Name = "nOMBRESDataGridViewTextBoxColumn";
            this.nOMBRESDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDDOCTORDataGridViewTextBoxColumn
            // 
            this.iDDOCTORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDDOCTORDataGridViewTextBoxColumn.DataPropertyName = "ID_DOCTOR";
            this.iDDOCTORDataGridViewTextBoxColumn.HeaderText = "ID_DOCTOR";
            this.iDDOCTORDataGridViewTextBoxColumn.Name = "iDDOCTORDataGridViewTextBoxColumn";
            this.iDDOCTORDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDOCTORDataGridViewTextBoxColumn.Visible = false;
            this.iDDOCTORDataGridViewTextBoxColumn.Width = 120;
            // 
            // fECHACREADODataGridViewTextBoxColumn
            // 
            this.fECHACREADODataGridViewTextBoxColumn.DataPropertyName = "FECHA_CREADO";
            this.fECHACREADODataGridViewTextBoxColumn.HeaderText = "FECHA_CREADO";
            this.fECHACREADODataGridViewTextBoxColumn.Name = "fECHACREADODataGridViewTextBoxColumn";
            this.fECHACREADODataGridViewTextBoxColumn.ReadOnly = true;
            this.fECHACREADODataGridViewTextBoxColumn.Visible = false;
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            this.tELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            this.tELEFONODataGridViewTextBoxColumn.Width = 111;
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            this.dIRECCIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIRECCIONDataGridViewTextBoxColumn.Visible = false;
            // 
            // nITDataGridViewTextBoxColumn
            // 
            this.nITDataGridViewTextBoxColumn.DataPropertyName = "NIT";
            this.nITDataGridViewTextBoxColumn.HeaderText = "NIT";
            this.nITDataGridViewTextBoxColumn.Name = "nITDataGridViewTextBoxColumn";
            this.nITDataGridViewTextBoxColumn.ReadOnly = true;
            this.nITDataGridViewTextBoxColumn.Visible = false;
            // 
            // dUIDataGridViewTextBoxColumn
            // 
            this.dUIDataGridViewTextBoxColumn.DataPropertyName = "DUI";
            this.dUIDataGridViewTextBoxColumn.HeaderText = "DUI";
            this.dUIDataGridViewTextBoxColumn.Name = "dUIDataGridViewTextBoxColumn";
            this.dUIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dUIDataGridViewTextBoxColumn.Visible = false;
            // 
            // cORREODataGridViewTextBoxColumn
            // 
            this.cORREODataGridViewTextBoxColumn.DataPropertyName = "CORREO";
            this.cORREODataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREODataGridViewTextBoxColumn.Name = "cORREODataGridViewTextBoxColumn";
            this.cORREODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLINICANOMBREDataGridViewTextBoxColumn
            // 
            this.cLINICANOMBREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cLINICANOMBREDataGridViewTextBoxColumn.DataPropertyName = "CLINICA_NOMBRE";
            this.cLINICANOMBREDataGridViewTextBoxColumn.HeaderText = "CLINICA";
            this.cLINICANOMBREDataGridViewTextBoxColumn.Name = "cLINICANOMBREDataGridViewTextBoxColumn";
            this.cLINICANOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLINICATELEFONODataGridViewTextBoxColumn
            // 
            this.cLINICATELEFONODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cLINICATELEFONODataGridViewTextBoxColumn.DataPropertyName = "CLINICA_TELEFONO";
            this.cLINICATELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO CLÍNICA";
            this.cLINICATELEFONODataGridViewTextBoxColumn.Name = "cLINICATELEFONODataGridViewTextBoxColumn";
            this.cLINICATELEFONODataGridViewTextBoxColumn.ReadOnly = true;
            this.cLINICATELEFONODataGridViewTextBoxColumn.Width = 158;
            // 
            // iDEMPRESADataGridViewTextBoxColumn
            // 
            this.iDEMPRESADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDEMPRESADataGridViewTextBoxColumn.DataPropertyName = "ID_EMPRESA";
            this.iDEMPRESADataGridViewTextBoxColumn.DataSource = this.eMPRESABindingSource;
            this.iDEMPRESADataGridViewTextBoxColumn.DisplayMember = "NOMBRE";
            this.iDEMPRESADataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDEMPRESADataGridViewTextBoxColumn.HeaderText = "EMPRESA";
            this.iDEMPRESADataGridViewTextBoxColumn.Name = "iDEMPRESADataGridViewTextBoxColumn";
            this.iDEMPRESADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEMPRESADataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDEMPRESADataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDEMPRESADataGridViewTextBoxColumn.ValueMember = "ID_EMPRESA";
            this.iDEMPRESADataGridViewTextBoxColumn.Width = 103;
            // 
            // frmDoctores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 635);
            this.Controls.Add(this.dgRegistros);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsMenu);
            this.Name = "frmDoctores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Doctores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDoctores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOCTORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource dOCTORESBindingSource;
        private dsSysLabTableAdapters.DOCTORESTableAdapter dOCTORESTableAdapter;
        private dsSysLabTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton cmdMostar;
        private System.Windows.Forms.BindingSource eMPRESABindingSource;
        private dsSysLabTableAdapters.EMPRESATableAdapter eMPRESATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDOCTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHACREADODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLINICANOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLINICATELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDEMPRESADataGridViewTextBoxColumn;
    }
}