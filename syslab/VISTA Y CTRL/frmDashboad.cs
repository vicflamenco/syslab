using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA
{
    public partial class frmDashboad : Form
    {
        public frmDashboad(string tipo)
        {
            InitializeComponent();
            switch (tipo)
            {
                case "Administrador":
                    btUsuarios.Visible = true;
                    btSolicitud.Visible = false;
                    btCopiasSeg.Visible = true;
                    btResultados.Visible = false;
                    btPacientes.Visible = false;
                    btDoctores.Visible = false;
                    btEmpresas.Visible = false;
                    btCotizar.Visible = false;
                    btReportesGerenciales.Visible = false;
                    break;

                case "Gerente":
                    btUsuarios.Visible = false;
                    btSolicitud.Visible = true;
                    btCopiasSeg.Visible = false;
                    btResultados.Visible = true;
                    btPacientes.Visible = true;
                    btDoctores.Visible = true;
                    btEmpresas.Visible = true;
                    btCotizar.Visible = true;
                    btReportesGerenciales.Visible = true;
                    break;

                case "Operador":
                    btUsuarios.Visible = false;
                    btSolicitud.Visible = true;
                    btCopiasSeg.Visible = false;
                    btResultados.Visible = true;
                    btPacientes.Visible = true;
                    btDoctores.Visible = true;
                    btEmpresas.Visible = true;
                    btCotizar.Visible = true;
                    btReportesGerenciales.Visible = false;
                    break;
            }
        }

        private void frmDashboad_Load(object sender, EventArgs e)
        {
        }

        private void btReportesGerenciales_Click(object sender, EventArgs e)
        {
            var frm = new REPORTES.frmReportesVentas();
            frm.ShowDialog();
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            var padre = (frmPrincipal)this.Parent;
            padre.usuariosToolStripMenuItem_Click(sender, e);
        }

        private void btSolicitud_Click(object sender, EventArgs e)
        {
            var padre = (frmPrincipal)this.Parent;
            padre.soliciturdesDeAnálisisClínicosToolStripMenuItem_Click(sender, e);
        }

        private void btCopiasSeg_Click(object sender, EventArgs e)
        {
            var padre = (frmPrincipal)this.Parent;
            padre.realizarCopiaDeSeguridadToolStripMenuItem_Click(sender, e);
        }

        private void btResultados_Click(object sender, EventArgs e)
        {
            var padre = (frmPrincipal)this.Parent.Parent;
            padre.procesarResultadosDeAnálisisToolStripMenuItem_Click(sender, e);
        }

        private void btPacientes_Click(object sender, EventArgs e)
        {
            var padre = (frmPrincipal)this.Parent;
            padre.pacientesToolStripMenuItem_Click(sender, e);
        }

        private void btEmpresas_Click(object sender, EventArgs e)
        {
            var padre = (frmPrincipal)this.Parent;
            padre.empresasToolStripMenuItem_Click(sender, e);
        }

        private void btDoctores_Click(object sender, EventArgs e)
        {
            var padre = (frmPrincipal)this.Parent;
            padre.doctoresToolStripMenuItem_Click(sender, e);
        }

        private void btCotizar_Click(object sender, EventArgs e)
        {
            var padre = (frmPrincipal)this.Parent;
            padre.cotizacionesToolStripMenuItem_Click(sender, e);
        }
    }
}
