namespace SYSLAB.VISTA
{
    partial class frmDashboad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboad));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btUsuarios = new System.Windows.Forms.Button();
            this.btSolicitud = new System.Windows.Forms.Button();
            this.btCopiasSeg = new System.Windows.Forms.Button();
            this.btResultados = new System.Windows.Forms.Button();
            this.btPacientes = new System.Windows.Forms.Button();
            this.btEmpresas = new System.Windows.Forms.Button();
            this.btDoctores = new System.Windows.Forms.Button();
            this.btCotizar = new System.Windows.Forms.Button();
            this.btReportesGerenciales = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(83, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(615, 463);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.btUsuarios);
            this.flowLayoutPanel1.Controls.Add(this.btSolicitud);
            this.flowLayoutPanel1.Controls.Add(this.btCopiasSeg);
            this.flowLayoutPanel1.Controls.Add(this.btResultados);
            this.flowLayoutPanel1.Controls.Add(this.btPacientes);
            this.flowLayoutPanel1.Controls.Add(this.btEmpresas);
            this.flowLayoutPanel1.Controls.Add(this.btDoctores);
            this.flowLayoutPanel1.Controls.Add(this.btCotizar);
            this.flowLayoutPanel1.Controls.Add(this.btReportesGerenciales);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(602, 457);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btUsuarios
            // 
            this.btUsuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btUsuarios.Image")));
            this.btUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btUsuarios.Location = new System.Drawing.Point(14, 15);
            this.btUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btUsuarios.Name = "btUsuarios";
            this.btUsuarios.Size = new System.Drawing.Size(283, 78);
            this.btUsuarios.TabIndex = 0;
            this.btUsuarios.Text = "Control de usuarios";
            this.btUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btUsuarios.UseVisualStyleBackColor = true;
            this.btUsuarios.Click += new System.EventHandler(this.btUsuarios_Click);
            // 
            // btSolicitud
            // 
            this.btSolicitud.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSolicitud.Image = ((System.Drawing.Image)(resources.GetObject("btSolicitud.Image")));
            this.btSolicitud.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSolicitud.Location = new System.Drawing.Point(305, 15);
            this.btSolicitud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSolicitud.Name = "btSolicitud";
            this.btSolicitud.Size = new System.Drawing.Size(283, 78);
            this.btSolicitud.TabIndex = 0;
            this.btSolicitud.Text = "Solicitud de análisis";
            this.btSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSolicitud.UseVisualStyleBackColor = true;
            this.btSolicitud.Click += new System.EventHandler(this.btSolicitud_Click);
            // 
            // btCopiasSeg
            // 
            this.btCopiasSeg.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCopiasSeg.Image = ((System.Drawing.Image)(resources.GetObject("btCopiasSeg.Image")));
            this.btCopiasSeg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCopiasSeg.Location = new System.Drawing.Point(14, 103);
            this.btCopiasSeg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCopiasSeg.Name = "btCopiasSeg";
            this.btCopiasSeg.Size = new System.Drawing.Size(283, 78);
            this.btCopiasSeg.TabIndex = 0;
            this.btCopiasSeg.Text = "Copias de seguridad";
            this.btCopiasSeg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCopiasSeg.UseVisualStyleBackColor = true;
            this.btCopiasSeg.Click += new System.EventHandler(this.btCopiasSeg_Click);
            // 
            // btResultados
            // 
            this.btResultados.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResultados.Image = ((System.Drawing.Image)(resources.GetObject("btResultados.Image")));
            this.btResultados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btResultados.Location = new System.Drawing.Point(305, 103);
            this.btResultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btResultados.Name = "btResultados";
            this.btResultados.Size = new System.Drawing.Size(283, 78);
            this.btResultados.TabIndex = 1;
            this.btResultados.Text = "Resultados de análisis";
            this.btResultados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btResultados.UseVisualStyleBackColor = true;
            this.btResultados.Click += new System.EventHandler(this.btResultados_Click);
            // 
            // btPacientes
            // 
            this.btPacientes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPacientes.Image = ((System.Drawing.Image)(resources.GetObject("btPacientes.Image")));
            this.btPacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPacientes.Location = new System.Drawing.Point(14, 191);
            this.btPacientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPacientes.Name = "btPacientes";
            this.btPacientes.Size = new System.Drawing.Size(283, 78);
            this.btPacientes.TabIndex = 2;
            this.btPacientes.Text = "Pacientes";
            this.btPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPacientes.UseVisualStyleBackColor = true;
            this.btPacientes.Click += new System.EventHandler(this.btPacientes_Click);
            // 
            // btEmpresas
            // 
            this.btEmpresas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmpresas.Image = ((System.Drawing.Image)(resources.GetObject("btEmpresas.Image")));
            this.btEmpresas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEmpresas.Location = new System.Drawing.Point(305, 191);
            this.btEmpresas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEmpresas.Name = "btEmpresas";
            this.btEmpresas.Size = new System.Drawing.Size(283, 78);
            this.btEmpresas.TabIndex = 3;
            this.btEmpresas.Text = "Empresas";
            this.btEmpresas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btEmpresas.UseVisualStyleBackColor = true;
            this.btEmpresas.Click += new System.EventHandler(this.btEmpresas_Click);
            // 
            // btDoctores
            // 
            this.btDoctores.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDoctores.Image = ((System.Drawing.Image)(resources.GetObject("btDoctores.Image")));
            this.btDoctores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDoctores.Location = new System.Drawing.Point(14, 279);
            this.btDoctores.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDoctores.Name = "btDoctores";
            this.btDoctores.Size = new System.Drawing.Size(283, 78);
            this.btDoctores.TabIndex = 4;
            this.btDoctores.Text = "Doctores";
            this.btDoctores.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btDoctores.UseVisualStyleBackColor = true;
            this.btDoctores.Click += new System.EventHandler(this.btDoctores_Click);
            // 
            // btCotizar
            // 
            this.btCotizar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCotizar.Image = ((System.Drawing.Image)(resources.GetObject("btCotizar.Image")));
            this.btCotizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCotizar.Location = new System.Drawing.Point(305, 279);
            this.btCotizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCotizar.Name = "btCotizar";
            this.btCotizar.Size = new System.Drawing.Size(283, 78);
            this.btCotizar.TabIndex = 5;
            this.btCotizar.Text = "Cotizaciones";
            this.btCotizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCotizar.UseVisualStyleBackColor = true;
            this.btCotizar.Click += new System.EventHandler(this.btCotizar_Click);
            // 
            // btReportesGerenciales
            // 
            this.btReportesGerenciales.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportesGerenciales.Image = ((System.Drawing.Image)(resources.GetObject("btReportesGerenciales.Image")));
            this.btReportesGerenciales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btReportesGerenciales.Location = new System.Drawing.Point(14, 367);
            this.btReportesGerenciales.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btReportesGerenciales.Name = "btReportesGerenciales";
            this.btReportesGerenciales.Size = new System.Drawing.Size(283, 78);
            this.btReportesGerenciales.TabIndex = 6;
            this.btReportesGerenciales.Text = "Reportes Gerenciales";
            this.btReportesGerenciales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btReportesGerenciales.UseVisualStyleBackColor = true;
            this.btReportesGerenciales.Click += new System.EventHandler(this.btReportesGerenciales_Click);
            // 
            // frmDashboad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 539);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDashboad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDashboad_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        protected System.Windows.Forms.Button btUsuarios;
        protected System.Windows.Forms.Button btSolicitud;
        protected System.Windows.Forms.Button btCopiasSeg;
        protected System.Windows.Forms.Button btResultados;
        protected System.Windows.Forms.Button btPacientes;
        protected System.Windows.Forms.Button btEmpresas;
        protected System.Windows.Forms.Button btDoctores;
        protected System.Windows.Forms.Button btCotizar;
        protected System.Windows.Forms.Button btReportesGerenciales;
    }
}