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
    public partial class frmLogin : Form
    {

        public Sesion _Sesion;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }

        private void lblIniciar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            IniciarSesion();   
        }

        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) IniciarSesion();
        }

        private void IniciarSesion()
        {
            string usuario = txtUsuario.Text.Trim();
            string contra = txtContra.Text.Trim();
            if (usuario == string.Empty || contra == string.Empty)
            {
                MessageBox.Show("Debe ingresar su identificador y su contraseña."
                    , "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var ps = new CTRL.Persistencia();
                ps.IniciarTransaccion();

                MD5.MD5 encrip = new MD5.MD5(contra);
                if (CTRL.Administracion.Usuarios.IniciarSesion(ps.DB, usuario, encrip.FingerPrint))
                {
                    var reg = ps.SelPorLlave<USUARIO>(usuario);
                    this._Sesion = new Sesion(true, reg.TIPO, usuario, reg.NOMBRES, reg.APELLIDOS);
                    this.DialogResult = DialogResult.OK;
                    this.Dispose();
                }
                else
                    MessageBox.Show("El nombre de usuario no existe o la contraseña es incorrecta."
                        + Environment.NewLine + "Por favor, intente nuevamente.", "SysLab",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ps.FinalizarTransaccion();
            }
        }
    }
}
