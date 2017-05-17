namespace SYSLAB.VISTA.EMPRESAS
{
    partial class frmEmpresas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmpresas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgRegistros = new System.Windows.Forms.DataGridView();
            this.iDEMPRESADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cORREODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPRESABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSysLab = new SYSLAB.dsSysLab();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.iDSECTORDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESCRIPCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eMPRESA_SECTORBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.cmdEliminarSector = new System.Windows.Forms.ToolStripButton();
            this.cmdEditarSector = new System.Windows.Forms.ToolStripButton();
            this.cmdAgregarSector = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmdAdminPacientes = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cmdEliminarEmpresa = new System.Windows.Forms.ToolStripButton();
            this.cmdEditarEmpresa = new System.Windows.Forms.ToolStripButton();
            this.cmdAgregarEmpresa = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.eMPRESATableAdapter = new SYSLAB.dsSysLabTableAdapters.EMPRESATableAdapter();
            this.tableAdapterManager = new SYSLAB.dsSysLabTableAdapters.TableAdapterManager();
            this.eMPRESA_SECTORTableAdapter = new SYSLAB.dsSysLabTableAdapters.EMPRESA_SECTORTableAdapter();
            this.groupBox1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESA_SECTORBindingSource)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 69);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar Empresas";
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 108);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgRegistros);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgDetalle);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer1.Size = new System.Drawing.Size(790, 260);
            this.splitContainer1.SplitterDistance = 104;
            this.splitContainer1.TabIndex = 26;
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
            this.iDEMPRESADataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn,
            this.nITDataGridViewTextBoxColumn,
            this.nRCDataGridViewTextBoxColumn,
            this.cORREODataGridViewTextBoxColumn});
            this.dgRegistros.DataSource = this.eMPRESABindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgRegistros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRegistros.Location = new System.Drawing.Point(0, 25);
            this.dgRegistros.Name = "dgRegistros";
            this.dgRegistros.ReadOnly = true;
            this.dgRegistros.RowHeadersVisible = false;
            this.dgRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRegistros.Size = new System.Drawing.Size(790, 79);
            this.dgRegistros.TabIndex = 18;
            // 
            // iDEMPRESADataGridViewTextBoxColumn
            // 
            this.iDEMPRESADataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDEMPRESADataGridViewTextBoxColumn.DataPropertyName = "ID_EMPRESA";
            this.iDEMPRESADataGridViewTextBoxColumn.HeaderText = "ID_EMPRESA";
            this.iDEMPRESADataGridViewTextBoxColumn.Name = "iDEMPRESADataGridViewTextBoxColumn";
            this.iDEMPRESADataGridViewTextBoxColumn.ReadOnly = true;
            this.iDEMPRESADataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            this.dIRECCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nITDataGridViewTextBoxColumn
            // 
            this.nITDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nITDataGridViewTextBoxColumn.DataPropertyName = "NIT";
            this.nITDataGridViewTextBoxColumn.HeaderText = "NIT";
            this.nITDataGridViewTextBoxColumn.Name = "nITDataGridViewTextBoxColumn";
            this.nITDataGridViewTextBoxColumn.ReadOnly = true;
            this.nITDataGridViewTextBoxColumn.Width = 59;
            // 
            // nRCDataGridViewTextBoxColumn
            // 
            this.nRCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nRCDataGridViewTextBoxColumn.DataPropertyName = "NRC";
            this.nRCDataGridViewTextBoxColumn.HeaderText = "NRC";
            this.nRCDataGridViewTextBoxColumn.Name = "nRCDataGridViewTextBoxColumn";
            this.nRCDataGridViewTextBoxColumn.ReadOnly = true;
            this.nRCDataGridViewTextBoxColumn.Width = 67;
            // 
            // cORREODataGridViewTextBoxColumn
            // 
            this.cORREODataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.cORREODataGridViewTextBoxColumn.DataPropertyName = "CORREO";
            this.cORREODataGridViewTextBoxColumn.HeaderText = "CORREO";
            this.cORREODataGridViewTextBoxColumn.Name = "cORREODataGridViewTextBoxColumn";
            this.cORREODataGridViewTextBoxColumn.ReadOnly = true;
            this.cORREODataGridViewTextBoxColumn.Width = 97;
            // 
            // eMPRESABindingSource
            // 
            this.eMPRESABindingSource.DataMember = "EMPRESA";
            this.eMPRESABindingSource.DataSource = this.dsSysLab;
            // 
            // dsSysLab
            // 
            this.dsSysLab.DataSetName = "dsSysLab";
            this.dsSysLab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripSeparator5});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(790, 25);
            this.toolStrip2.TabIndex = 21;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(152, 22);
            this.toolStripLabel2.Text = "Listado de Empresas";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.AllowUserToDeleteRows = false;
            this.dgDetalle.AllowUserToResizeRows = false;
            this.dgDetalle.AutoGenerateColumns = false;
            this.dgDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDetalle.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSECTORDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn1,
            this.dESCRIPCIONDataGridViewTextBoxColumn});
            this.dgDetalle.DataSource = this.eMPRESA_SECTORBindingSource;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetalle.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDetalle.Location = new System.Drawing.Point(0, 39);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.ReadOnly = true;
            this.dgDetalle.RowHeadersVisible = false;
            this.dgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetalle.Size = new System.Drawing.Size(790, 113);
            this.dgDetalle.TabIndex = 19;
            // 
            // iDSECTORDataGridViewTextBoxColumn
            // 
            this.iDSECTORDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDSECTORDataGridViewTextBoxColumn.DataPropertyName = "ID_SECTOR";
            this.iDSECTORDataGridViewTextBoxColumn.HeaderText = "ID_SECTOR";
            this.iDSECTORDataGridViewTextBoxColumn.Name = "iDSECTORDataGridViewTextBoxColumn";
            this.iDSECTORDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDSECTORDataGridViewTextBoxColumn.Visible = false;
            // 
            // nOMBREDataGridViewTextBoxColumn1
            // 
            this.nOMBREDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.nOMBREDataGridViewTextBoxColumn1.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn1.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn1.Name = "nOMBREDataGridViewTextBoxColumn1";
            this.nOMBREDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dESCRIPCIONDataGridViewTextBoxColumn
            // 
            this.dESCRIPCIONDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dESCRIPCIONDataGridViewTextBoxColumn.DataPropertyName = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.dESCRIPCIONDataGridViewTextBoxColumn.Name = "dESCRIPCIONDataGridViewTextBoxColumn";
            this.dESCRIPCIONDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eMPRESA_SECTORBindingSource
            // 
            this.eMPRESA_SECTORBindingSource.DataMember = "FK_EMPRESA_SECTOR_EMPRESA";
            this.eMPRESA_SECTORBindingSource.DataSource = this.eMPRESABindingSource;
            // 
            // toolStrip3
            // 
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel3,
            this.cmdEliminarSector,
            this.cmdEditarSector,
            this.cmdAgregarSector,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.cmdAdminPacientes});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(790, 39);
            this.toolStrip3.TabIndex = 20;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(140, 36);
            this.toolStripLabel3.Text = "Detalle de sectores";
            // 
            // cmdEliminarSector
            // 
            this.cmdEliminarSector.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdEliminarSector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarSector.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminarSector.Image")));
            this.cmdEliminarSector.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdEliminarSector.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEliminarSector.Name = "cmdEliminarSector";
            this.cmdEliminarSector.Size = new System.Drawing.Size(103, 36);
            this.cmdEliminarSector.Text = "Eliminar";
            this.cmdEliminarSector.ToolTipText = "Eliminar Familia";
            this.cmdEliminarSector.Click += new System.EventHandler(this.cmdEliminarSector_Click);
            // 
            // cmdEditarSector
            // 
            this.cmdEditarSector.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdEditarSector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditarSector.Image = ((System.Drawing.Image)(resources.GetObject("cmdEditarSector.Image")));
            this.cmdEditarSector.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdEditarSector.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEditarSector.Name = "cmdEditarSector";
            this.cmdEditarSector.Size = new System.Drawing.Size(112, 36);
            this.cmdEditarSector.Text = "Modificar";
            this.cmdEditarSector.ToolTipText = "Modificar Familia";
            this.cmdEditarSector.Click += new System.EventHandler(this.cmdEditarSector_Click);
            // 
            // cmdAgregarSector
            // 
            this.cmdAgregarSector.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdAgregarSector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregarSector.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregarSector.Image")));
            this.cmdAgregarSector.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAgregarSector.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAgregarSector.Name = "cmdAgregarSector";
            this.cmdAgregarSector.Size = new System.Drawing.Size(102, 36);
            this.cmdAgregarSector.Text = "Agregar";
            this.cmdAgregarSector.ToolTipText = "Agregar Familia";
            this.cmdAgregarSector.Click += new System.EventHandler(this.cmdAgregarSector_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // cmdAdminPacientes
            // 
            this.cmdAdminPacientes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdAdminPacientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdminPacientes.Image = ((System.Drawing.Image)(resources.GetObject("cmdAdminPacientes.Image")));
            this.cmdAdminPacientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAdminPacientes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAdminPacientes.Name = "cmdAdminPacientes";
            this.cmdAdminPacientes.Size = new System.Drawing.Size(197, 36);
            this.cmdAdminPacientes.Text = "Administrar Pacientes";
            this.cmdAdminPacientes.ToolTipText = "Agregar Familia";
            this.cmdAdminPacientes.Click += new System.EventHandler(this.cmdAdminPacientes_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(207, 36);
            this.toolStripLabel1.Text = "Administración de empresas";
            // 
            // cmdEliminarEmpresa
            // 
            this.cmdEliminarEmpresa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdEliminarEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminarEmpresa.Image")));
            this.cmdEliminarEmpresa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdEliminarEmpresa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEliminarEmpresa.Name = "cmdEliminarEmpresa";
            this.cmdEliminarEmpresa.Size = new System.Drawing.Size(103, 36);
            this.cmdEliminarEmpresa.Text = "Eliminar";
            this.cmdEliminarEmpresa.ToolTipText = "Eliminar Familia";
            this.cmdEliminarEmpresa.Click += new System.EventHandler(this.cmdEliminarEmpresa_Click);
            // 
            // cmdEditarEmpresa
            // 
            this.cmdEditarEmpresa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdEditarEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEditarEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("cmdEditarEmpresa.Image")));
            this.cmdEditarEmpresa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdEditarEmpresa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEditarEmpresa.Name = "cmdEditarEmpresa";
            this.cmdEditarEmpresa.Size = new System.Drawing.Size(112, 36);
            this.cmdEditarEmpresa.Text = "Modificar";
            this.cmdEditarEmpresa.ToolTipText = "Modificar Familia";
            this.cmdEditarEmpresa.Click += new System.EventHandler(this.cmdEditarEmpresa_Click);
            // 
            // cmdAgregarEmpresa
            // 
            this.cmdAgregarEmpresa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdAgregarEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAgregarEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("cmdAgregarEmpresa.Image")));
            this.cmdAgregarEmpresa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdAgregarEmpresa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdAgregarEmpresa.Name = "cmdAgregarEmpresa";
            this.cmdAgregarEmpresa.Size = new System.Drawing.Size(102, 36);
            this.cmdAgregarEmpresa.Text = "Agregar";
            this.cmdAgregarEmpresa.ToolTipText = "Agregar Familia";
            this.cmdAgregarEmpresa.Click += new System.EventHandler(this.cmdAgregarEmpresa_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cmdEliminarEmpresa,
            this.cmdEditarEmpresa,
            this.cmdAgregarEmpresa,
            this.toolStripSeparator4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(790, 39);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // eMPRESATableAdapter
            // 
            this.eMPRESATableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.EMPRESA_SECTORTableAdapter = this.eMPRESA_SECTORTableAdapter;
            this.tableAdapterManager.EMPRESATableAdapter = this.eMPRESATableAdapter;
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
            // eMPRESA_SECTORTableAdapter
            // 
            this.eMPRESA_SECTORTableAdapter.ClearBeforeFill = true;
            // 
            // frmEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 368);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmEmpresas";
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.frmEmpresas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eMPRESA_SECTORBindingSource)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgRegistros;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridView dgDetalle;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        internal System.Windows.Forms.ToolStripButton cmdEliminarSector;
        internal System.Windows.Forms.ToolStripButton cmdEditarSector;
        internal System.Windows.Forms.ToolStripButton cmdAgregarSector;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        internal System.Windows.Forms.ToolStripButton cmdEliminarEmpresa;
        internal System.Windows.Forms.ToolStripButton cmdEditarEmpresa;
        internal System.Windows.Forms.ToolStripButton cmdAgregarEmpresa;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        internal System.Windows.Forms.ToolStripButton cmdAdminPacientes;
        private dsSysLab dsSysLab;
        private System.Windows.Forms.BindingSource eMPRESABindingSource;
        private dsSysLabTableAdapters.EMPRESATableAdapter eMPRESATableAdapter;
        private dsSysLabTableAdapters.TableAdapterManager tableAdapterManager;
        private dsSysLabTableAdapters.EMPRESA_SECTORTableAdapter eMPRESA_SECTORTableAdapter;
        private System.Windows.Forms.BindingSource eMPRESA_SECTORBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDEMPRESADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cORREODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSECTORDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESCRIPCIONDataGridViewTextBoxColumn;
    }
}