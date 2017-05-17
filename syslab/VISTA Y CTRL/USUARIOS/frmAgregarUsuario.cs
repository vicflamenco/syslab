using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.USUARIOS
{
    public partial class frmAgregarUsuario : Form
    {

        private bool _EDITANDO;
        private string _ID_EDITANDO;


        public frmAgregarUsuario()
        {
            InitializeComponent();
            _EDITANDO = false;
            GenerarContraseña();
            cbTipo.SelectedIndex = 0;
        }
        public frmAgregarUsuario(string idEditando)
        {
            InitializeComponent();
            
            this._ID_EDITANDO = idEditando;
            _EDITANDO = true;
            txtIdentificador.ReadOnly = true;

            var ps = new CTRL.Persistencia();
            ps.AbrirConexion();

            var reg = ps.SelPorLlave<USUARIO>(idEditando);

            this.Text = this.lblProd.Text = "Editando Usuario";

            txtNombres.Text = reg.NOMBRES;
            txtApellidos.Text = reg.APELLIDOS;
            txtTelefono.Text = reg.TELEFONO;
            txtCorreo.Text = reg.CORREO;
            txtIdentificador.Text = reg.ID_USUARIO;
            cbTipo.SelectedIndex = cbTipo.Items.IndexOf(reg.TIPO);
            txtContra.Text = "(Sin Cambios)";
            ps.CerrarConexion();
            cbTipo.SelectedIndex = 0;
        }


        private void btGenerar_Click(object sender, EventArgs e)
        {
            GenerarContraseña();
        }

        private void GenerarContraseña()
        {
            var chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var result = new string(
                Enumerable.Repeat(chars, 8)
                          .Select(s => s[aleatorio.Next(s.Length)])
                          .ToArray());
            txtContra.Text = result;
        }

        private void frmAgregarUsuario_Load(object sender, EventArgs e)
        {
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text.Length < 3 || txtApellidos.Text.Length < 3)
            {
                MessageBox.Show("Los nombres y los apellidos deben tener una longitud mínima "
                    + "de 3 caracteres.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtContra.Text.Length < 8 || txtIdentificador.Text.Length < 8)
            {
                MessageBox.Show("El identificador y la contraseña deben tener una longitud mínima"
                + "de 8 caraceres.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var ps = new CTRL.Persistencia();
                ps.IniciarTransaccion();

                if (!this._EDITANDO) // AGREGANDO
                {
                    if (CTRL.Administracion.Usuarios.AgregarUsuario(ps.DB,txtContra.Text.Trim(),
                        txtTelefono.Text.Trim(),txtIdentificador.Text.Trim(),txtNombres.Text.Trim(),
                        txtCorreo.Text.Trim(),txtApellidos.Text.Trim(),cbTipo.Text))
                    {
                        ps.FinalizarTransaccion();
                        MessageBox.Show("El registro fue procesado satisfactoriamente.", 
                            "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Dispose();
                    }
                    else
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("La operación no pudo ser completada.", "SysLab",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else // EDITANDO
                {
                    if (CTRL.Administracion.Usuarios.EditarUsuario(ps.DB,_ID_EDITANDO,
                        (txtContra.Text.Trim() == "(Sin Cambios)") ? "" : txtContra.Text.Trim(),
                        txtTelefono.Text.Trim(),txtNombres.Text.Trim(), 
                        txtCorreo.Text.Trim(), txtApellidos.Text.Trim(), cbTipo.Text))
                    {
                        ps.FinalizarTransaccion();
                        MessageBox.Show("El registro fue procesado satisfactoriamente.", "SysLab", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Dispose();
                    }
                    else
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("La operación no pudo ser completada.", "SysLab", 
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los cambios realizados serán descartados. ¿Desea salir?", "SysLab", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Dispose();
            }
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            ActualizarUsuario();
        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            ActualizarUsuario();
        }

        Random aleatorio = new Random();

        private void ActualizarUsuario()
        {
            if (!_EDITANDO)
            {
                string nom = txtNombres.Text.Trim();
                string ape = txtApellidos.Text.Trim();
                if (nom.Length >= 3 && ape.Length >= 3)
                {
                    string usuario = ape.ToLower() + nom.ToLower() + aleatorio.Next(1, 10);
                    string ConSignos = "áàäéèëíìïóòöúùuñÁÀÄÉÈËÍÌÏÓÒÖÚÙÜçÇ";
                    string SinSignos = "aaaeeeiiiooouuunAAAEEEIIIOOOUUUcC";

                    var textoSinAcentos = string.Empty;

                    foreach (char caracter in usuario)
                    {
                        var indexConAcento = ConSignos.IndexOf(caracter);
                        if (indexConAcento > -1)
                            textoSinAcentos = textoSinAcentos + (SinSignos.Substring(indexConAcento, 1));
                        else textoSinAcentos = textoSinAcentos + (caracter);
                    }

                    txtIdentificador.Text = textoSinAcentos;
                } 
            }  
        }

        private void txtContra_Enter(object sender, EventArgs e)
        {
            if (txtContra.Text == "(Sin Cambios)") txtContra.Text = string.Empty;
        }
    }
}
