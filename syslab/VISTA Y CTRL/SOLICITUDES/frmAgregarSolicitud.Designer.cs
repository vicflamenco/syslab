namespace SYSLAB.VISTA.SOLICITUDES
{
    partial class frmAgregarSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarSolicitud));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPrecios = new System.Windows.Forms.ListBox();
            this.dgAnalisis = new System.Windows.Forms.DataGridView();
            this.aNALISISBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSysLab = new SYSLAB.dsSysLab();
            this.dgMovs = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosto = new SysLab.TNumEditDataGridViewColumn();
            this.colObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colImpuesto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tsMovimientos = new System.Windows.Forms.ToolStrip();
            this.cmdEliminarMov = new System.Windows.Forms.ToolStripButton();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.ckCFinal = new System.Windows.Forms.RadioButton();
            this.ckCFiscal = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtGiro = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNRC = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtDoctorNombre = new System.Windows.Forms.TextBox();
            this.txtDoctorID = new System.Windows.Forms.TextBox();
            this.cmdDoctor = new System.Windows.Forms.Button();
            this.txtPacienteID = new System.Windows.Forms.TextBox();
            this.cmdPaciente = new System.Windows.Forms.Button();
            this.dtpRequerido = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.cmdCancelar = new System.Windows.Forms.ToolStripButton();
            this.cmdGuardar = new System.Windows.Forms.ToolStripButton();
            this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtGravado = new System.Windows.Forms.TextBox();
            this.nudReten = new CoolSoft.UI.NumericUpDownEx();
            this.nudIVA = new CoolSoft.UI.NumericUpDownEx();
            this.ckRetencion = new System.Windows.Forms.CheckBox();
            this.lblIVA = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIVA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGravado = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPercepcion = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtExento = new System.Windows.Forms.TextBox();
            this.aNALISISTableAdapter = new SYSLAB.dsSysLabTableAdapters.ANALISISTableAdapter();
            this.tableAdapterManager = new SYSLAB.dsSysLabTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tNumEditDataGridViewColumn1 = new SysLab.TNumEditDataGridViewColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDANALISISDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIO1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIO2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRECIO3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnalisis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNALISISBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovs)).BeginInit();
            this.tsMovimientos.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.tsMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIVA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstPrecios);
            this.groupBox1.Controls.Add(this.dgAnalisis);
            this.groupBox1.Controls.Add(this.dgMovs);
            this.groupBox1.Controls.Add(this.tsMovimientos);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 280);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // lstPrecios
            // 
            this.lstPrecios.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lstPrecios.CausesValidation = false;
            this.lstPrecios.ColumnWidth = 120;
            this.lstPrecios.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPrecios.FormatString = "N4";
            this.lstPrecios.FormattingEnabled = true;
            this.lstPrecios.ItemHeight = 20;
            this.lstPrecios.Items.AddRange(new object[] {
            "1.0000",
            "2.0000",
            "3.0000"});
            this.lstPrecios.Location = new System.Drawing.Point(315, 111);
            this.lstPrecios.MultiColumn = true;
            this.lstPrecios.Name = "lstPrecios";
            this.lstPrecios.Size = new System.Drawing.Size(120, 64);
            this.lstPrecios.TabIndex = 59;
            this.lstPrecios.Visible = false;
            this.lstPrecios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstPrecios_MouseClick);
            this.lstPrecios.VisibleChanged += new System.EventHandler(this.lstPrecios_VisibleChanged);
            // 
            // dgAnalisis
            // 
            this.dgAnalisis.AllowUserToAddRows = false;
            this.dgAnalisis.AllowUserToDeleteRows = false;
            this.dgAnalisis.AllowUserToResizeRows = false;
            this.dgAnalisis.AutoGenerateColumns = false;
            this.dgAnalisis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAnalisis.BackgroundColor = System.Drawing.Color.White;
            this.dgAnalisis.CausesValidation = false;
            this.dgAnalisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnalisis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDANALISISDataGridViewTextBoxColumn,
            this.nOMBREDataGridViewTextBoxColumn,
            this.pRECIO1DataGridViewTextBoxColumn,
            this.pRECIO2DataGridViewTextBoxColumn,
            this.pRECIO3DataGridViewTextBoxColumn});
            this.dgAnalisis.DataSource = this.aNALISISBindingSource;
            this.dgAnalisis.Location = new System.Drawing.Point(146, 87);
            this.dgAnalisis.Name = "dgAnalisis";
            this.dgAnalisis.ReadOnly = true;
            this.dgAnalisis.RowHeadersVisible = false;
            this.dgAnalisis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAnalisis.Size = new System.Drawing.Size(540, 127);
            this.dgAnalisis.TabIndex = 58;
            this.dgAnalisis.Visible = false;
            this.dgAnalisis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAnalisis_CellClick);
            // 
            // aNALISISBindingSource
            // 
            this.aNALISISBindingSource.DataMember = "ANALISIS";
            this.aNALISISBindingSource.DataSource = this.dsSysLab;
            // 
            // dsSysLab
            // 
            this.dsSysLab.DataSetName = "dsSysLab";
            this.dsSysLab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgMovs
            // 
            this.dgMovs.AllowUserToResizeRows = false;
            this.dgMovs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgMovs.BackgroundColor = System.Drawing.Color.White;
            this.dgMovs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nombre,
            this.colCosto,
            this.colObs,
            this.colImpuesto});
            this.dgMovs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMovs.Location = new System.Drawing.Point(3, 21);
            this.dgMovs.Name = "dgMovs";
            this.dgMovs.RowHeadersWidth = 25;
            this.dgMovs.Size = new System.Drawing.Size(815, 231);
            this.dgMovs.TabIndex = 5;
            this.dgMovs.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgMovs_CellBeginEdit);
            this.dgMovs.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMovs_CellEndEdit);
            this.dgMovs.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMovs_CellEnter);
            this.dgMovs.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMovs_CellValueChanged);
            this.dgMovs.CurrentCellChanged += new System.EventHandler(this.dgMovs_CurrentCellChanged);
            this.dgMovs.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgMovs_DefaultValuesNeeded);
            this.dgMovs.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgMovs_EditingControlShowing);
            this.dgMovs.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgMovs_RowsRemoved);
            // 
            // codigo
            // 
            this.codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.Width = 76;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Análisis";
            this.nombre.Name = "nombre";
            // 
            // colCosto
            // 
            this.colCosto.AllowNegative = false;
            this.colCosto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colCosto.DecimalLength = 2;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "F2";
            this.colCosto.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCosto.HeaderText = "Precio";
            this.colCosto.Name = "colCosto";
            this.colCosto.Width = 69;
            // 
            // colObs
            // 
            this.colObs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colObs.HeaderText = "Observaciones";
            this.colObs.Name = "colObs";
            // 
            // colImpuesto
            // 
            this.colImpuesto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colImpuesto.HeaderText = "Exento";
            this.colImpuesto.Name = "colImpuesto";
            this.colImpuesto.Width = 53;
            // 
            // tsMovimientos
            // 
            this.tsMovimientos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsMovimientos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMovimientos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdEliminarMov});
            this.tsMovimientos.Location = new System.Drawing.Point(3, 252);
            this.tsMovimientos.Name = "tsMovimientos";
            this.tsMovimientos.Size = new System.Drawing.Size(815, 25);
            this.tsMovimientos.TabIndex = 50;
            this.tsMovimientos.Text = "ToolStrip2";
            // 
            // cmdEliminarMov
            // 
            this.cmdEliminarMov.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdEliminarMov.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEliminarMov.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminarMov.Image")));
            this.cmdEliminarMov.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEliminarMov.Name = "cmdEliminarMov";
            this.cmdEliminarMov.Size = new System.Drawing.Size(103, 22);
            this.cmdEliminarMov.Text = "Eliminar fila";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.ckCFinal);
            this.gbDatos.Controls.Add(this.ckCFiscal);
            this.gbDatos.Controls.Add(this.label6);
            this.gbDatos.Controls.Add(this.label11);
            this.gbDatos.Controls.Add(this.label10);
            this.gbDatos.Controls.Add(this.label15);
            this.gbDatos.Controls.Add(this.label16);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.txtNIT);
            this.gbDatos.Controls.Add(this.txtGiro);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.txtNRC);
            this.gbDatos.Controls.Add(this.txtFactura);
            this.gbDatos.Controls.Add(this.txtDoctorNombre);
            this.gbDatos.Controls.Add(this.txtDoctorID);
            this.gbDatos.Controls.Add(this.cmdDoctor);
            this.gbDatos.Controls.Add(this.txtPacienteID);
            this.gbDatos.Controls.Add(this.cmdPaciente);
            this.gbDatos.Controls.Add(this.dtpRequerido);
            this.gbDatos.Controls.Add(this.label8);
            this.gbDatos.Controls.Add(this.dtpFecha);
            this.gbDatos.Controls.Add(this.lblFecha);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDatos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDatos.Location = new System.Drawing.Point(0, 39);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(821, 141);
            this.gbDatos.TabIndex = 58;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos generales";
            // 
            // ckCFinal
            // 
            this.ckCFinal.AutoSize = true;
            this.ckCFinal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCFinal.Location = new System.Drawing.Point(665, 51);
            this.ckCFinal.Name = "ckCFinal";
            this.ckCFinal.Size = new System.Drawing.Size(127, 21);
            this.ckCFinal.TabIndex = 22;
            this.ckCFinal.Text = "Consumidor Final";
            this.ckCFinal.UseVisualStyleBackColor = true;
            // 
            // ckCFiscal
            // 
            this.ckCFiscal.AutoSize = true;
            this.ckCFiscal.Checked = true;
            this.ckCFiscal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckCFiscal.Location = new System.Drawing.Point(555, 51);
            this.ckCFiscal.Name = "ckCFiscal";
            this.ckCFiscal.Size = new System.Drawing.Size(104, 21);
            this.ckCFiscal.TabIndex = 21;
            this.ckCFiscal.TabStop = true;
            this.ckCFiscal.Text = "Crédito Fiscal";
            this.ckCFiscal.UseVisualStyleBackColor = true;
            this.ckCFiscal.CheckedChanged += new System.EventHandler(this.ckCFiscal_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(496, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Factura:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(48, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Giro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Nombre:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(185, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "NIT:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(46, 79);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 17);
            this.label16.TabIndex = 9;
            this.label16.Text = "NRC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(318, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "No. Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(337, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Doctor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Paciente:";
            // 
            // txtNIT
            // 
            this.txtNIT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNIT.Location = new System.Drawing.Point(217, 75);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(95, 25);
            this.txtNIT.TabIndex = 12;
            this.txtNIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGiro
            // 
            this.txtGiro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiro.Location = new System.Drawing.Point(90, 102);
            this.txtGiro.Name = "txtGiro";
            this.txtGiro.Size = new System.Drawing.Size(400, 25);
            this.txtGiro.TabIndex = 8;
            this.txtGiro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(90, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(400, 25);
            this.txtNombre.TabIndex = 8;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNRC
            // 
            this.txtNRC.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRC.Location = new System.Drawing.Point(90, 75);
            this.txtNRC.Name = "txtNRC";
            this.txtNRC.Size = new System.Drawing.Size(95, 25);
            this.txtNRC.TabIndex = 10;
            this.txtNRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFactura
            // 
            this.txtFactura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFactura.Location = new System.Drawing.Point(399, 75);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(91, 25);
            this.txtFactura.TabIndex = 14;
            this.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoctorNombre
            // 
            this.txtDoctorNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorNombre.Location = new System.Drawing.Point(488, 21);
            this.txtDoctorNombre.Name = "txtDoctorNombre";
            this.txtDoctorNombre.ReadOnly = true;
            this.txtDoctorNombre.Size = new System.Drawing.Size(215, 25);
            this.txtDoctorNombre.TabIndex = 0;
            this.txtDoctorNombre.Text = "- Ninguno -";
            this.txtDoctorNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoctorID
            // 
            this.txtDoctorID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoctorID.Location = new System.Drawing.Point(394, 21);
            this.txtDoctorID.Name = "txtDoctorID";
            this.txtDoctorID.ReadOnly = true;
            this.txtDoctorID.Size = new System.Drawing.Size(88, 25);
            this.txtDoctorID.TabIndex = 0;
            this.txtDoctorID.Text = "- Ninguno -";
            this.txtDoctorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdDoctor
            // 
            this.cmdDoctor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDoctor.Location = new System.Drawing.Point(709, 20);
            this.cmdDoctor.Name = "cmdDoctor";
            this.cmdDoctor.Size = new System.Drawing.Size(106, 27);
            this.cmdDoctor.TabIndex = 1;
            this.cmdDoctor.Text = "Sel. Doctor";
            this.cmdDoctor.UseVisualStyleBackColor = true;
            this.cmdDoctor.Click += new System.EventHandler(this.cmdDoctor_Click);
            // 
            // txtPacienteID
            // 
            this.txtPacienteID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPacienteID.Location = new System.Drawing.Point(90, 21);
            this.txtPacienteID.Name = "txtPacienteID";
            this.txtPacienteID.ReadOnly = true;
            this.txtPacienteID.Size = new System.Drawing.Size(126, 25);
            this.txtPacienteID.TabIndex = 0;
            this.txtPacienteID.Text = "- Ninguno -";
            this.txtPacienteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdPaciente
            // 
            this.cmdPaciente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPaciente.Location = new System.Drawing.Point(222, 20);
            this.cmdPaciente.Name = "cmdPaciente";
            this.cmdPaciente.Size = new System.Drawing.Size(106, 27);
            this.cmdPaciente.TabIndex = 1;
            this.cmdPaciente.Text = "Sel. Paciente";
            this.cmdPaciente.UseVisualStyleBackColor = true;
            this.cmdPaciente.Click += new System.EventHandler(this.cmdPaciente_Click);
            // 
            // dtpRequerido
            // 
            this.dtpRequerido.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRequerido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRequerido.Location = new System.Drawing.Point(569, 102);
            this.dtpRequerido.Name = "dtpRequerido";
            this.dtpRequerido.Size = new System.Drawing.Size(113, 25);
            this.dtpRequerido.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(496, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Requerido:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(569, 74);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(113, 25);
            this.dtpFecha.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(496, 79);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 17);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "Emisión:";
            // 
            // tsMenu
            // 
            this.tsMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdCancelar,
            this.cmdGuardar,
            this.lblTitulo,
            this.toolStripSeparator1});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(821, 39);
            this.tsMenu.TabIndex = 59;
            this.tsMenu.Text = "ToolStrip3";
            // 
            // cmdCancelar
            // 
            this.cmdCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdCancelar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCancelar.Image = ((System.Drawing.Image)(resources.GetObject("cmdCancelar.Image")));
            this.cmdCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdCancelar.Name = "cmdCancelar";
            this.cmdCancelar.Size = new System.Drawing.Size(96, 36);
            this.cmdCancelar.Text = "Cancelar";
            this.cmdCancelar.Click += new System.EventHandler(this.cmdCancelar_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdGuardar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cmdGuardar.Image")));
            this.cmdGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(93, 36);
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(126, 36);
            this.lblTitulo.Text = "Agregando solicitud";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtGravado);
            this.groupBox2.Controls.Add(this.nudReten);
            this.groupBox2.Controls.Add(this.nudIVA);
            this.groupBox2.Controls.Add(this.ckRetencion);
            this.groupBox2.Controls.Add(this.lblIVA);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIVA);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblGravado);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtPercepcion);
            this.groupBox2.Controls.Add(this.txtSubTotal);
            this.groupBox2.Controls.Add(this.txtExento);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 460);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 132);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            // 
            // txtGravado
            // 
            this.txtGravado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGravado.Location = new System.Drawing.Point(325, 18);
            this.txtGravado.Name = "txtGravado";
            this.txtGravado.ReadOnly = true;
            this.txtGravado.Size = new System.Drawing.Size(95, 25);
            this.txtGravado.TabIndex = 0;
            this.txtGravado.Text = "0.00";
            this.txtGravado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudReten
            // 
            this.nudReten.AutoSelect = true;
            this.nudReten.DecimalPlaces = 2;
            this.nudReten.Location = new System.Drawing.Point(105, 21);
            this.nudReten.Name = "nudReten";
            this.nudReten.Size = new System.Drawing.Size(94, 27);
            this.nudReten.TabIndex = 27;
            this.nudReten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudReten.ValueChanged += new System.EventHandler(this.nudReten_ValueChanged_1);
            // 
            // nudIVA
            // 
            this.nudIVA.AutoSelect = true;
            this.nudIVA.DecimalPlaces = 2;
            this.nudIVA.Location = new System.Drawing.Point(105, 54);
            this.nudIVA.Name = "nudIVA";
            this.nudIVA.Size = new System.Drawing.Size(94, 27);
            this.nudIVA.TabIndex = 27;
            this.nudIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudIVA.ValueChanged += new System.EventHandler(this.nudReten_ValueChanged_1);
            // 
            // ckRetencion
            // 
            this.ckRetencion.AutoSize = true;
            this.ckRetencion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckRetencion.Location = new System.Drawing.Point(599, 78);
            this.ckRetencion.Name = "ckRetencion";
            this.ckRetencion.Size = new System.Drawing.Size(87, 21);
            this.ckRetencion.TabIndex = 26;
            this.ckRetencion.Text = "Retención:";
            this.ckRetencion.UseVisualStyleBackColor = true;
            this.ckRetencion.CheckedChanged += new System.EventHandler(this.ckRetencion_CheckedChanged);
            // 
            // lblIVA
            // 
            this.lblIVA.AutoSize = true;
            this.lblIVA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(452, 21);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(30, 17);
            this.lblIVA.TabIndex = 25;
            this.lblIVA.Text = "IVA:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(643, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Exento:";
            // 
            // txtIVA
            // 
            this.txtIVA.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIVA.Location = new System.Drawing.Point(488, 18);
            this.txtIVA.Name = "txtIVA";
            this.txtIVA.ReadOnly = true;
            this.txtIVA.Size = new System.Drawing.Size(94, 25);
            this.txtIVA.TabIndex = 0;
            this.txtIVA.Text = "0.00";
            this.txtIVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(652, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "IVA (%):";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(625, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Sub-Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Retención (%):";
            // 
            // lblGravado
            // 
            this.lblGravado.AutoSize = true;
            this.lblGravado.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGravado.Location = new System.Drawing.Point(267, 21);
            this.lblGravado.Name = "lblGravado";
            this.lblGravado.Size = new System.Drawing.Size(61, 17);
            this.lblGravado.TabIndex = 25;
            this.lblGravado.Text = "Gravado:";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(699, 102);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(113, 25);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPercepcion
            // 
            this.txtPercepcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPercepcion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPercepcion.Location = new System.Drawing.Point(699, 74);
            this.txtPercepcion.Name = "txtPercepcion";
            this.txtPercepcion.ReadOnly = true;
            this.txtPercepcion.Size = new System.Drawing.Size(113, 25);
            this.txtPercepcion.TabIndex = 0;
            this.txtPercepcion.Text = "0.00";
            this.txtPercepcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(699, 18);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(113, 25);
            this.txtSubTotal.TabIndex = 0;
            this.txtSubTotal.Text = "0.00";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtExento
            // 
            this.txtExento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExento.Location = new System.Drawing.Point(699, 46);
            this.txtExento.Name = "txtExento";
            this.txtExento.ReadOnly = true;
            this.txtExento.Size = new System.Drawing.Size(113, 25);
            this.txtExento.TabIndex = 0;
            this.txtExento.Text = "0.00";
            this.txtExento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // aNALISISTableAdapter
            // 
            this.aNALISISTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANALISIS_DATOTableAdapter = null;
            this.tableAdapterManager.ANALISISTableAdapter = this.aNALISISTableAdapter;
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
            this.tableAdapterManager.SOLICITUDTableAdapter = null;
            this.tableAdapterManager.TALONARIOTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SYSLAB.dsSysLabTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USUARIOTableAdapter = null;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_ANALISIS";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_ANALISIS";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRECIO2";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRECIO2";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PRECIO3";
            this.dataGridViewTextBoxColumn4.HeaderText = "PRECIO3";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "Código";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Análisis";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // tNumEditDataGridViewColumn1
            // 
            this.tNumEditDataGridViewColumn1.AllowNegative = false;
            this.tNumEditDataGridViewColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tNumEditDataGridViewColumn1.DecimalLength = 2;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "F2";
            this.tNumEditDataGridViewColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.tNumEditDataGridViewColumn1.HeaderText = "Precio";
            this.tNumEditDataGridViewColumn1.Name = "tNumEditDataGridViewColumn1";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // iDANALISISDataGridViewTextBoxColumn
            // 
            this.iDANALISISDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.iDANALISISDataGridViewTextBoxColumn.DataPropertyName = "ID_ANALISIS";
            this.iDANALISISDataGridViewTextBoxColumn.HeaderText = "ID_ANALISIS";
            this.iDANALISISDataGridViewTextBoxColumn.Name = "iDANALISISDataGridViewTextBoxColumn";
            this.iDANALISISDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDANALISISDataGridViewTextBoxColumn.Visible = false;
            this.iDANALISISDataGridViewTextBoxColumn.Width = 83;
            // 
            // nOMBREDataGridViewTextBoxColumn
            // 
            this.nOMBREDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE";
            this.nOMBREDataGridViewTextBoxColumn.Name = "nOMBREDataGridViewTextBoxColumn";
            this.nOMBREDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRECIO1DataGridViewTextBoxColumn
            // 
            this.pRECIO1DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pRECIO1DataGridViewTextBoxColumn.DataPropertyName = "PRECIO1";
            this.pRECIO1DataGridViewTextBoxColumn.HeaderText = "PRECIO 1";
            this.pRECIO1DataGridViewTextBoxColumn.Name = "pRECIO1DataGridViewTextBoxColumn";
            this.pRECIO1DataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECIO1DataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pRECIO1DataGridViewTextBoxColumn.Width = 87;
            // 
            // pRECIO2DataGridViewTextBoxColumn
            // 
            this.pRECIO2DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pRECIO2DataGridViewTextBoxColumn.DataPropertyName = "PRECIO2";
            this.pRECIO2DataGridViewTextBoxColumn.HeaderText = "PRECIO 2";
            this.pRECIO2DataGridViewTextBoxColumn.Name = "pRECIO2DataGridViewTextBoxColumn";
            this.pRECIO2DataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECIO2DataGridViewTextBoxColumn.Width = 87;
            // 
            // pRECIO3DataGridViewTextBoxColumn
            // 
            this.pRECIO3DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.pRECIO3DataGridViewTextBoxColumn.DataPropertyName = "PRECIO3";
            this.pRECIO3DataGridViewTextBoxColumn.HeaderText = "PRECIO 3";
            this.pRECIO3DataGridViewTextBoxColumn.Name = "pRECIO3DataGridViewTextBoxColumn";
            this.pRECIO3DataGridViewTextBoxColumn.ReadOnly = true;
            this.pRECIO3DataGridViewTextBoxColumn.Width = 87;
            // 
            // frmAgregarSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 592);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.tsMenu);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarSolicitud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Solicitud";
            this.Load += new System.EventHandler(this.frmAgregarSolicitud_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnalisis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aNALISISBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovs)).EndInit();
            this.tsMovimientos.ResumeLayout(false);
            this.tsMovimientos.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudIVA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstPrecios;
        private System.Windows.Forms.DataGridView dgAnalisis;
        private System.Windows.Forms.DataGridView dgMovs;
        internal System.Windows.Forms.ToolStrip tsMovimientos;
        internal System.Windows.Forms.ToolStripButton cmdEliminarMov;
        internal System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.RadioButton ckCFinal;
        private System.Windows.Forms.RadioButton ckCFiscal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.TextBox txtGiro;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNRC;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.TextBox txtPacienteID;
        private System.Windows.Forms.Button cmdPaciente;
        internal System.Windows.Forms.DateTimePicker dtpFecha;
        internal System.Windows.Forms.Label lblFecha;
        internal System.Windows.Forms.ToolStrip tsMenu;
        internal System.Windows.Forms.ToolStripButton cmdCancelar;
        internal System.Windows.Forms.ToolStripButton cmdGuardar;
        internal System.Windows.Forms.ToolStripLabel lblTitulo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        internal System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckRetencion;
        private System.Windows.Forms.Label lblIVA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIVA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGravado;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPercepcion;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtExento;
        private System.Windows.Forms.TextBox txtGravado;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private SysLab.TNumEditDataGridViewColumn colCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObs;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colImpuesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDoctorID;
        private System.Windows.Forms.Button cmdDoctor;
        private System.Windows.Forms.TextBox txtDoctorNombre;
        private dsSysLab dsSysLab;
        private System.Windows.Forms.BindingSource aNALISISBindingSource;
        private dsSysLabTableAdapters.ANALISISTableAdapter aNALISISTableAdapter;
        private dsSysLabTableAdapters.TableAdapterManager tableAdapterManager;
        private CoolSoft.UI.NumericUpDownEx nudIVA;
        private System.Windows.Forms.Label label3;
        private CoolSoft.UI.NumericUpDownEx nudReten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private SysLab.TNumEditDataGridViewColumn tNumEditDataGridViewColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        internal System.Windows.Forms.DateTimePicker dtpRequerido;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDANALISISDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIO1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIO2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRECIO3DataGridViewTextBoxColumn;
    }
}