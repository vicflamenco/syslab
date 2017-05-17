using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB
{
    public partial class frmPrincipal : Form
    {

        public Sesion _SESION;

        public frmPrincipal()
        {
            InitializeComponent();
            sistemaToolStripMenuItem.Visible = gESTIÓNCOMERCIALToolStripMenuItem.Visible =
                aDMINISTRARToolStripMenuItem.Visible = rEPORTESToolStripMenuItem.Visible =
                boletasToolStripItem.Visible = aNÁLISISToolStripMenuItem.Visible = false;
        }

        public void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanas();
            var frm = new VISTA.PACIENTES.frmPacientes();
            frm.MdiParent = this;
            frm.Show();
        }

        public void doctoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanas();
            var frm = new VISTA.DOCTORES.frmDoctores();
            frm.MdiParent = this;
            frm.Show();
        }

        public void soliciturdesDeAnálisisClínicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanas();
            var frm = new VISTA.SOLICITUDES.frmSolicitudes();
            frm.MdiParent = this;
            frm.Show();
        }

        public void procesarResultadosDeAnálisisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanas();
            var frm = new VISTA.RESULTADOS.frmResultados();
            frm.MdiParent = this;
            frm.Show();
        }

        public void frmPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        public void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanas();
            var frm = new VISTA.COTIZACIONES.frmCotizaciones();
            frm.MdiParent = this;
            frm.Show();
        }

        public void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanas();
            var frm = new VISTA.EMPRESAS.frmEmpresas();
            frm.MdiParent = this;
            frm.Show();
        }

        public void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanas();
            var frm = new VISTA.USUARIOS.frmAdminUsuarios();
            frm.MdiParent = this;
            frm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void Salir()
        {
            if (MessageBox.Show("¿Realmente desea salir de SysLab?", "SysLab",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (_SESION == null) // INICIAR SESIÓN
            {
                var login = new frmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    _SESION = login._Sesion;
                    btLogin.Text = "Bienvenido " + _SESION._NOMBRE + " " + _SESION._APELLIDO + " [&CERRAR SESIÓN]";
                    var frm = new VISTA.frmDashboad(_SESION.Tipo);
                    frm.MdiParent = this;
                    frm.Show();

                    switch (_SESION.Tipo)
                    {
                        case "Administrador":
                            sistemaToolStripMenuItem.Visible = true;
                            gESTIÓNCOMERCIALToolStripMenuItem.Visible = false;
                            aDMINISTRARToolStripMenuItem.Visible = false;
                            rEPORTESToolStripMenuItem.Visible = false;
                            boletasToolStripItem.Visible = false;
                            aNÁLISISToolStripMenuItem.Visible = false;
                            aYUDAToolStripMenuItem.Visible = true;
                            break;

                        case "Gerente":
                            sistemaToolStripMenuItem.Visible = false;
                            gESTIÓNCOMERCIALToolStripMenuItem.Visible = true;
                            aDMINISTRARToolStripMenuItem.Visible = true;
                            rEPORTESToolStripMenuItem.Visible = true;
                            boletasToolStripItem.Visible = true;
                            aNÁLISISToolStripMenuItem.Visible = true;
                            aYUDAToolStripMenuItem.Visible = true;
                            break;

                        case "Operador":
                            sistemaToolStripMenuItem.Visible = false;
                            gESTIÓNCOMERCIALToolStripMenuItem.Visible = true;
                            aDMINISTRARToolStripMenuItem.Visible = true;
                            rEPORTESToolStripMenuItem.Visible = true;
                            boletasToolStripItem.Visible = true;
                            aNÁLISISToolStripMenuItem.Visible = true;
                            aYUDAToolStripMenuItem.Visible = true;
                            break;
                    }

                }
            }
            else // CERRAR SESIÓN
            {
                if (MessageBox.Show("Cualquier trabajo no guardado se perderá." + Environment.NewLine
                    + "¿Realmente desea cerrar sesión?", "SysLab",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CerrarTodasLasVentanas();
                    _SESION = null;
                    sistemaToolStripMenuItem.Visible = gESTIÓNCOMERCIALToolStripMenuItem.Visible =
                        aDMINISTRARToolStripMenuItem.Visible = rEPORTESToolStripMenuItem.Visible =
                        boletasToolStripItem.Visible = aNÁLISISToolStripMenuItem.Visible = false;
                    btLogin.Text = "&INICIAR SESIÓN";
                }

            }
        }

        private void CerrarTodasLasVentanas()
        {
            foreach (Form frm in this.MdiChildren) frm.Dispose();
        }

        public void clasificaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanas();
            var frm = new VISTA.CLASIFICACION.frmClasificacion();
            frm.MdiParent = this;
            frm.Show();
        }

        public void catálogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanas();
            var frm = new VISTA.CATALOGO.frmCatalogo();
            frm.MdiParent = this;
            frm.Show();
        }

        public void controlTalonariosToolStripItem_Click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanas();
            var frm = new VISTA.TALONARIOS.frmControlTalonarios();
            frm.MdiParent = this;
            frm.Show();
        }

        public void realizarCopiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanas();
            // Procedimiento para realizar copia de seguridad
        }

        public void restaurarCopiaDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btReporteVentas_Click(object sender, EventArgs e)
        {
            CerrarTodasLasVentanas();
            var frm = new VISTA.REPORTES.frmReportesVentas();
            frm.ShowDialog();
        }
    }
}
