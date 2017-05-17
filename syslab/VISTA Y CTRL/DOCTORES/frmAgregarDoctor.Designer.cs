namespace SYSLAB.VISTA.DOCTORES
{
    partial class frmAgregarDoctor
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
            System.Windows.Forms.Label dIRECCIONLabel;
            System.Windows.Forms.Label mUNICIPIOLabel;
            System.Windows.Forms.Label nITLabel;
            System.Windows.Forms.Label nRCLabel;
            System.Windows.Forms.Label cORREOLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarDoctor));
            this.tsBarra = new System.Windows.Forms.ToolStrip();
            this.cmdCancelar = new System.Windows.Forms.ToolStripButton();
            this.cmdGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.lblTitulo = new System.Windows.Forms.ToolStripLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtClinicaTelefono = new System.Windows.Forms.TextBox();
            this.txtClinicaNombre = new System.Windows.Forms.TextBox();
            this.txtNIT = new System.Windows.Forms.TextBox();
            this.txtDUI = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            nOMBRESLabel = new System.Windows.Forms.Label();
            tELEFONOLabel = new System.Windows.Forms.Label();
            dIRECCIONLabel = new System.Windows.Forms.Label();
            mUNICIPIOLabel = new System.Windows.Forms.Label();
            nITLabel = new System.Windows.Forms.Label();
            nRCLabel = new System.Windows.Forms.Label();
            cORREOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.tsBarra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nOMBRESLabel
            // 
            nOMBRESLabel.AutoSize = true;
            nOMBRESLabel.Location = new System.Drawing.Point(84, 28);
            nOMBRESLabel.Name = "nOMBRESLabel";
            nOMBRESLabel.Size = new System.Drawing.Size(71, 21);
            nOMBRESLabel.TabIndex = 6;
            nOMBRESLabel.Text = "Nombre:";
            // 
            // tELEFONOLabel
            // 
            tELEFONOLabel.AutoSize = true;
            tELEFONOLabel.Location = new System.Drawing.Point(82, 171);
            tELEFONOLabel.Name = "tELEFONOLabel";
            tELEFONOLabel.Size = new System.Drawing.Size(73, 21);
            tELEFONOLabel.TabIndex = 8;
            tELEFONOLabel.Text = "Teléfono:";
            // 
            // dIRECCIONLabel
            // 
            dIRECCIONLabel.AutoSize = true;
            dIRECCIONLabel.Location = new System.Drawing.Point(77, 66);
            dIRECCIONLabel.Name = "dIRECCIONLabel";
            dIRECCIONLabel.Size = new System.Drawing.Size(78, 21);
            dIRECCIONLabel.TabIndex = 14;
            dIRECCIONLabel.Text = "Dirección:";
            // 
            // mUNICIPIOLabel
            // 
            mUNICIPIOLabel.AutoSize = true;
            mUNICIPIOLabel.Location = new System.Drawing.Point(34, 206);
            mUNICIPIOLabel.Name = "mUNICIPIOLabel";
            mUNICIPIOLabel.Size = new System.Drawing.Size(121, 21);
            mUNICIPIOLabel.TabIndex = 16;
            mUNICIPIOLabel.Text = "Nombre Clínica:";
            // 
            // nITLabel
            // 
            nITLabel.AutoSize = true;
            nITLabel.Location = new System.Drawing.Point(327, 136);
            nITLabel.Name = "nITLabel";
            nITLabel.Size = new System.Drawing.Size(37, 21);
            nITLabel.TabIndex = 20;
            nITLabel.Text = "NIT:";
            // 
            // nRCLabel
            // 
            nRCLabel.AutoSize = true;
            nRCLabel.Location = new System.Drawing.Point(116, 136);
            nRCLabel.Name = "nRCLabel";
            nRCLabel.Size = new System.Drawing.Size(39, 21);
            nRCLabel.TabIndex = 22;
            nRCLabel.Text = "DUI:";
            // 
            // cORREOLabel
            // 
            cORREOLabel.AutoSize = true;
            cORREOLabel.Location = new System.Drawing.Point(14, 101);
            cORREOLabel.Name = "cORREOLabel";
            cORREOLabel.Size = new System.Drawing.Size(141, 21);
            cORREOLabel.TabIndex = 34;
            cORREOLabel.Text = "Correo electrónico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(32, 241);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 21);
            label1.TabIndex = 16;
            label1.Text = "Teléfono Clínica:";
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
            this.tsBarra.Size = new System.Drawing.Size(610, 39);
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
            this.lblTitulo.Size = new System.Drawing.Size(138, 36);
            this.lblTitulo.Text = "Agregando Doctor";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(nOMBRESLabel);
            this.groupBox1.Controls.Add(this.txtNombres);
            this.groupBox1.Controls.Add(tELEFONOLabel);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(dIRECCIONLabel);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(mUNICIPIOLabel);
            this.groupBox1.Controls.Add(this.txtClinicaTelefono);
            this.groupBox1.Controls.Add(this.txtClinicaNombre);
            this.groupBox1.Controls.Add(nITLabel);
            this.groupBox1.Controls.Add(this.txtNIT);
            this.groupBox1.Controls.Add(nRCLabel);
            this.groupBox1.Controls.Add(this.txtDUI);
            this.groupBox1.Controls.Add(cORREOLabel);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 290);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(161, 28);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(409, 29);
            this.txtNombres.TabIndex = 0;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(161, 168);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(409, 29);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(161, 63);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(409, 29);
            this.txtDireccion.TabIndex = 1;
            // 
            // txtClinicaTelefono
            // 
            this.txtClinicaTelefono.Location = new System.Drawing.Point(161, 238);
            this.txtClinicaTelefono.Name = "txtClinicaTelefono";
            this.txtClinicaTelefono.Size = new System.Drawing.Size(409, 29);
            this.txtClinicaTelefono.TabIndex = 7;
            // 
            // txtClinicaNombre
            // 
            this.txtClinicaNombre.Location = new System.Drawing.Point(161, 203);
            this.txtClinicaNombre.Name = "txtClinicaNombre";
            this.txtClinicaNombre.Size = new System.Drawing.Size(409, 29);
            this.txtClinicaNombre.TabIndex = 6;
            // 
            // txtNIT
            // 
            this.txtNIT.Location = new System.Drawing.Point(370, 133);
            this.txtNIT.Name = "txtNIT";
            this.txtNIT.Size = new System.Drawing.Size(200, 29);
            this.txtNIT.TabIndex = 3;
            // 
            // txtDUI
            // 
            this.txtDUI.Location = new System.Drawing.Point(161, 133);
            this.txtDUI.Name = "txtDUI";
            this.txtDUI.Size = new System.Drawing.Size(154, 29);
            this.txtDUI.TabIndex = 5;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(161, 98);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(409, 29);
            this.txtCorreo.TabIndex = 4;
            // 
            // frmAgregarDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 344);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tsBarra);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAgregarDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregando Doctor";
            this.tsBarra.ResumeLayout(false);
            this.tsBarra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtClinicaNombre;
        private System.Windows.Forms.TextBox txtNIT;
        private System.Windows.Forms.TextBox txtDUI;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtClinicaTelefono;
    }
}