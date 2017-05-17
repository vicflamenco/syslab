namespace SYSLAB.VISTA.CATALOGO
{
    partial class frmAgregarAnalisis
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
            System.Windows.Forms.Label tELEFONOLabel;
            System.Windows.Forms.Label cREDITO_DIASLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label nOMBRELabel;
            System.Windows.Forms.Label nOMBRELabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarAnalisis));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsBarra = new System.Windows.Forms.ToolStrip();
            this.cmdCancelar = new System.Windows.Forms.ToolStripButton();
            this.cmdGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudP3 = new CoolSoft.UI.NumericUpDownEx();
            this.nudP2 = new CoolSoft.UI.NumericUpDownEx();
            this.nudP1 = new CoolSoft.UI.NumericUpDownEx();
            this.cmbFam = new System.Windows.Forms.ComboBox();
            this.fAMILIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsSysLab = new SYSLAB.dsSysLab();
            this.cmbCateg = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.cATEGORIATableAdapter = new SYSLAB.dsSysLabTableAdapters.CATEGORIATableAdapter();
            this.tableAdapterManager = new SYSLAB.dsSysLabTableAdapters.TableAdapterManager();
            this.fAMILIATableAdapter = new SYSLAB.dsSysLabTableAdapters.FAMILIATableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgCampos = new System.Windows.Forms.DataGridView();
            this.colCampo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colUMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMin = new SysLab.TNumEditDataGridViewColumn();
            this.colMax = new SysLab.TNumEditDataGridViewColumn();
            this.tsAcabados = new System.Windows.Forms.ToolStrip();
            this.cmdEliminarDato = new System.Windows.Forms.ToolStripButton();
            nOMBRESLabel = new System.Windows.Forms.Label();
            tELEFONOLabel = new System.Windows.Forms.Label();
            cREDITO_DIASLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            nOMBRELabel = new System.Windows.Forms.Label();
            nOMBRELabel1 = new System.Windows.Forms.Label();
            this.tsBarra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudP3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCampos)).BeginInit();
            this.tsAcabados.SuspendLayout();
            this.SuspendLayout();
            // 
            // nOMBRESLabel
            // 
            nOMBRESLabel.AutoSize = true;
            nOMBRESLabel.Location = new System.Drawing.Point(19, 95);
            nOMBRESLabel.Name = "nOMBRESLabel";
            nOMBRESLabel.Size = new System.Drawing.Size(71, 21);
            nOMBRESLabel.TabIndex = 6;
            nOMBRESLabel.Text = "Nombre:";
            // 
            // tELEFONOLabel
            // 
            tELEFONOLabel.AutoSize = true;
            tELEFONOLabel.Location = new System.Drawing.Point(19, 130);
            tELEFONOLabel.Name = "tELEFONOLabel";
            tELEFONOLabel.Size = new System.Drawing.Size(94, 21);
            tELEFONOLabel.TabIndex = 8;
            tELEFONOLabel.Text = "Descripción:";
            // 
            // cREDITO_DIASLabel
            // 
            cREDITO_DIASLabel.AutoSize = true;
            cREDITO_DIASLabel.Location = new System.Drawing.Point(19, 203);
            cREDITO_DIASLabel.Name = "cREDITO_DIASLabel";
            cREDITO_DIASLabel.Size = new System.Drawing.Size(69, 21);
            cREDITO_DIASLabel.TabIndex = 32;
            cREDITO_DIASLabel.Text = "Precio 1:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(259, 203);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 21);
            label1.TabIndex = 32;
            label1.Text = "Precio 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(481, 203);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 21);
            label2.TabIndex = 32;
            label2.Text = "Precio 3:";
            // 
            // nOMBRELabel
            // 
            nOMBRELabel.AutoSize = true;
            nOMBRELabel.Location = new System.Drawing.Point(19, 25);
            nOMBRELabel.Name = "nOMBRELabel";
            nOMBRELabel.Size = new System.Drawing.Size(80, 21);
            nOMBRELabel.TabIndex = 36;
            nOMBRELabel.Text = "Categoría:";
            // 
            // nOMBRELabel1
            // 
            nOMBRELabel1.AutoSize = true;
            nOMBRELabel1.Location = new System.Drawing.Point(19, 60);
            nOMBRELabel1.Name = "nOMBRELabel1";
            nOMBRELabel1.Size = new System.Drawing.Size(63, 21);
            nOMBRELabel1.TabIndex = 37;
            nOMBRELabel1.Text = "Familia:";
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
            this.tsBarra.Size = new System.Drawing.Size(685, 39);
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
            // lblTitulo
            // 
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(178, 36);
            this.lblTitulo.Text = "Agregar Tipo de Análisis";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudP3);
            this.groupBox1.Controls.Add(this.nudP2);
            this.groupBox1.Controls.Add(this.nudP1);
            this.groupBox1.Controls.Add(nOMBRELabel1);
            this.groupBox1.Controls.Add(this.cmbFam);
            this.groupBox1.Controls.Add(nOMBRELabel);
            this.groupBox1.Controls.Add(this.cmbCateg);
            this.groupBox1.Controls.Add(nOMBRESLabel);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(label2);
            this.groupBox1.Controls.Add(tELEFONOLabel);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.txtDesc);
            this.groupBox1.Controls.Add(cREDITO_DIASLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 241);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos generales";
            // 
            // nudP3
            // 
            this.nudP3.AutoSelect = true;
            this.nudP3.DecimalPlaces = 2;
            this.nudP3.Location = new System.Drawing.Point(556, 201);
            this.nudP3.Name = "nudP3";
            this.nudP3.ShowUpDownButtons = CoolSoft.UI.NumericUpDownEx.ShowUpDownButtonsMode.WhenFocusOrMouseOver;
            this.nudP3.Size = new System.Drawing.Size(102, 29);
            this.nudP3.TabIndex = 6;
            this.nudP3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudP2
            // 
            this.nudP2.AutoSelect = true;
            this.nudP2.DecimalPlaces = 2;
            this.nudP2.Location = new System.Drawing.Point(334, 201);
            this.nudP2.Name = "nudP2";
            this.nudP2.ShowUpDownButtons = CoolSoft.UI.NumericUpDownEx.ShowUpDownButtonsMode.WhenFocusOrMouseOver;
            this.nudP2.Size = new System.Drawing.Size(102, 29);
            this.nudP2.TabIndex = 5;
            this.nudP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudP1
            // 
            this.nudP1.AutoSelect = true;
            this.nudP1.DecimalPlaces = 2;
            this.nudP1.Location = new System.Drawing.Point(120, 201);
            this.nudP1.Name = "nudP1";
            this.nudP1.ShowUpDownButtons = CoolSoft.UI.NumericUpDownEx.ShowUpDownButtonsMode.WhenFocusOrMouseOver;
            this.nudP1.Size = new System.Drawing.Size(102, 29);
            this.nudP1.TabIndex = 4;
            this.nudP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbFam
            // 
            this.cmbFam.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fAMILIABindingSource, "NOMBRE", true));
            this.cmbFam.DataSource = this.fAMILIABindingSource;
            this.cmbFam.DisplayMember = "NOMBRE";
            this.cmbFam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFam.FormattingEnabled = true;
            this.cmbFam.Location = new System.Drawing.Point(120, 57);
            this.cmbFam.Name = "cmbFam";
            this.cmbFam.Size = new System.Drawing.Size(538, 29);
            this.cmbFam.TabIndex = 1;
            this.cmbFam.ValueMember = "ID_FAMILIA";
            // 
            // fAMILIABindingSource
            // 
            this.fAMILIABindingSource.DataMember = "FK_FAMILIA_CATEGORIA";
            this.fAMILIABindingSource.DataSource = this.cATEGORIABindingSource;
            // 
            // cATEGORIABindingSource
            // 
            this.cATEGORIABindingSource.DataMember = "CATEGORIA";
            this.cATEGORIABindingSource.DataSource = this.dsSysLab;
            // 
            // dsSysLab
            // 
            this.dsSysLab.DataSetName = "dsSysLab";
            this.dsSysLab.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbCateg
            // 
            this.cmbCateg.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cATEGORIABindingSource, "NOMBRE", true));
            this.cmbCateg.DataSource = this.cATEGORIABindingSource;
            this.cmbCateg.DisplayMember = "NOMBRE";
            this.cmbCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCateg.FormattingEnabled = true;
            this.cmbCateg.Location = new System.Drawing.Point(120, 22);
            this.cmbCateg.Name = "cmbCateg";
            this.cmbCateg.Size = new System.Drawing.Size(539, 29);
            this.cmbCateg.TabIndex = 0;
            this.cmbCateg.ValueMember = "ID_CATEGORIA";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 92);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(538, 29);
            this.txtNombre.TabIndex = 2;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(120, 127);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(538, 58);
            this.txtDesc.TabIndex = 3;
            // 
            // cATEGORIATableAdapter
            // 
            this.cATEGORIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ANALISIS_DATOTableAdapter = null;
            this.tableAdapterManager.ANALISISTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = this.cATEGORIATableAdapter;
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
            // fAMILIATableAdapter
            // 
            this.fAMILIATableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgCampos);
            this.groupBox2.Controls.Add(this.tsAcabados);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(664, 223);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Campos";
            // 
            // dgCampos
            // 
            this.dgCampos.BackgroundColor = System.Drawing.Color.White;
            this.dgCampos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCampos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCampo,
            this.colTipo,
            this.colUMed,
            this.colRef,
            this.colMin,
            this.colMax});
            this.dgCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgCampos.Location = new System.Drawing.Point(3, 50);
            this.dgCampos.Name = "dgCampos";
            this.dgCampos.RowHeadersWidth = 25;
            this.dgCampos.Size = new System.Drawing.Size(658, 170);
            this.dgCampos.TabIndex = 7;
            this.dgCampos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCampos_CellEnter);
            this.dgCampos.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgCampos_DefaultValuesNeeded);
            // 
            // colCampo
            // 
            this.colCampo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colCampo.HeaderText = "Campo";
            this.colCampo.Name = "colCampo";
            this.colCampo.Width = 85;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.colTipo.HeaderText = "Formato Presentación";
            this.colTipo.Name = "colTipo";
            this.colTipo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colTipo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTipo.Width = 170;
            // 
            // colUMed
            // 
            this.colUMed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colUMed.HeaderText = "U. Medida";
            this.colUMed.Name = "colUMed";
            this.colUMed.Width = 96;
            // 
            // colRef
            // 
            this.colRef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colRef.HeaderText = "Ref.";
            this.colRef.Name = "colRef";
            // 
            // colMin
            // 
            this.colMin.AllowNegative = false;
            this.colMin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMin.DecimalLength = 2;
            dataGridViewCellStyle1.Format = "F2";
            this.colMin.DefaultCellStyle = dataGridViewCellStyle1;
            this.colMin.HeaderText = "R. Mín.";
            this.colMin.Name = "colMin";
            this.colMin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMin.Width = 76;
            // 
            // colMax
            // 
            this.colMax.AllowNegative = false;
            this.colMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colMax.DecimalLength = 2;
            dataGridViewCellStyle2.Format = "F2";
            this.colMax.DefaultCellStyle = dataGridViewCellStyle2;
            this.colMax.HeaderText = "R. Máx.";
            this.colMax.Name = "colMax";
            this.colMax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colMax.Width = 78;
            // 
            // tsAcabados
            // 
            this.tsAcabados.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAcabados.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdEliminarDato});
            this.tsAcabados.Location = new System.Drawing.Point(3, 25);
            this.tsAcabados.Name = "tsAcabados";
            this.tsAcabados.Size = new System.Drawing.Size(658, 25);
            this.tsAcabados.TabIndex = 2;
            this.tsAcabados.Text = "toolStrip2";
            // 
            // cmdEliminarDato
            // 
            this.cmdEliminarDato.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cmdEliminarDato.Image = ((System.Drawing.Image)(resources.GetObject("cmdEliminarDato.Image")));
            this.cmdEliminarDato.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEliminarDato.Name = "cmdEliminarDato";
            this.cmdEliminarDato.Size = new System.Drawing.Size(70, 22);
            this.cmdEliminarDato.Text = "Eliminar";
            // 
            // frmAgregarAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 518);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarAnalisis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Tipo de Análisis";
            this.tsBarra.ResumeLayout(false);
            this.tsBarra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudP3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fAMILIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsSysLab)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCampos)).EndInit();
            this.tsAcabados.ResumeLayout(false);
            this.tsAcabados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip tsBarra;
        internal System.Windows.Forms.ToolStripButton cmdCancelar;
        internal System.Windows.Forms.ToolStripButton cmdGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel lblTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDesc;
        private dsSysLab dsSysLab;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource;
        private dsSysLabTableAdapters.CATEGORIATableAdapter cATEGORIATableAdapter;
        private dsSysLabTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbCateg;
        private System.Windows.Forms.BindingSource fAMILIABindingSource;
        private dsSysLabTableAdapters.FAMILIATableAdapter fAMILIATableAdapter;
        private System.Windows.Forms.ComboBox cmbFam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgCampos;
        private System.Windows.Forms.ToolStrip tsAcabados;
        private System.Windows.Forms.ToolStripButton cmdEliminarDato;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCampo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRef;
        private SysLab.TNumEditDataGridViewColumn colMin;
        private SysLab.TNumEditDataGridViewColumn colMax;
        private CoolSoft.UI.NumericUpDownEx nudP1;
        private CoolSoft.UI.NumericUpDownEx nudP3;
        private CoolSoft.UI.NumericUpDownEx nudP2;
    }
}