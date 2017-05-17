using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.EMPRESAS
{
    public partial class frmAgregarEmpresa : Form
    {
        long _ID_EDITAR;
        bool _EDITANDO;

        public frmAgregarEmpresa()
        {
            InitializeComponent();
        }

        public frmAgregarEmpresa(long ID_EMPRESA, bool Visor = false)
        {
            InitializeComponent();

            this._ID_EDITAR = ID_EMPRESA;
            this._EDITANDO = true;

            var ps = new CTRL.Persistencia();
            ps.AbrirConexion();

            var reg = ps.SelPorLlave<EMPRESA>(ID_EMPRESA.ToString());

            this.Text = this.lblTitulo.Text = "Editando empresa";

            txtNombres.Text = reg.NOMBRE;
            txtGiro.Text = reg.GIRO;
            txtDireccion.Text = reg.DIRECCION;
            txtMunicipio.Text = reg.MUNICIPIO;
            txtDepartamento.Text = reg.DEPARTAMENTO;
            txtNIT.Text = reg.NIT;
            txtNRC.Text = reg.NRC;
            txtCorreo.Text = reg.CORREO;
            ckCredito.Checked = reg.CREDITO;
            ckGranContribuyente.Checked = reg.GRAN_CONTRIBUYENTE;
            nudDiasCredito.Value = reg.CREDITO_DIAS;

            txtContactoNombre.Text = reg.CONTACTO_NOMBRE;
            txtContactoTelefono.Text = reg.CONTACTO_TELEFONO;
            txtContactoNIT.Text = reg.CONTACTO_NIT;
            txtContactoCorreo.Text = reg.CONTACTO_CORREO;
            
            if (Visor)
            {
                this.ControlBox = true;
                this.Text = this.lblTitulo.Text = "Visualizando empresa";

                txtNombres.ReadOnly = txtGiro.ReadOnly = txtDireccion.ReadOnly =
                    txtMunicipio.ReadOnly = txtDepartamento.ReadOnly = txtNIT.ReadOnly = txtNRC.ReadOnly =
                    txtCorreo.ReadOnly = txtContactoCorreo.ReadOnly = txtContactoNIT.ReadOnly = txtContactoNombre.ReadOnly = 
                    txtContactoTelefono.ReadOnly = true;

                ckCredito.Enabled = ckGranContribuyente.Enabled = 
                    nudDiasCredito.Enabled = cmdGuardar.Visible = cmdCancelar.Visible = false;
            }

            ps.CerrarConexion();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los cambios realizados serán descartados. ¿Desea salir?", "SysLab", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text.Trim() == string.Empty)
                MessageBox.Show("El nombre no es válido.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var ps = new CTRL.Persistencia();
                ps.IniciarTransaccion();

                if (!this._EDITANDO)
                {
                    if (CTRL.Administracion.Empresas.AgregarEmpresa(ps.DB, txtNombres.Text.Trim(), txtGiro.Text.Trim(),
                        txtDireccion.Text.Trim(), txtMunicipio.Text.Trim(), txtDepartamento.Text.Trim(), txtNIT.Text.Trim(), txtNRC.Text.Trim(),
                        ckGranContribuyente.Checked, ckCredito.Checked, (int)nudDiasCredito.Value, txtCorreo.Text.Trim(),
                        txtContactoNombre.Text.Trim(), txtContactoNIT.Text.Trim(), txtContactoCorreo.Text.Trim(), 
                        txtContactoTelefono.Text.Trim()))
                    {
                        ps.FinalizarTransaccion();
                        MessageBox.Show("El registro fue procesado satisfactoriamente.", "SysLab", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Dispose();
                    }
                    else
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("La operación no pudo ser completada.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    if (CTRL.Administracion.Empresas.EditarEmpresa(ps.DB, this._ID_EDITAR, txtNombres.Text.Trim(), txtGiro.Text.Trim(),
                        txtDireccion.Text.Trim(), txtMunicipio.Text.Trim(), txtDepartamento.Text.Trim(), txtNIT.Text.Trim(), txtNRC.Text.Trim(),
                        ckGranContribuyente.Checked, ckCredito.Checked, (int)nudDiasCredito.Value, txtCorreo.Text.Trim(),
                        txtContactoNombre.Text.Trim(), txtContactoNIT.Text.Trim(), txtContactoCorreo.Text.Trim(),
                        txtContactoTelefono.Text.Trim()))
                    {
                        ps.FinalizarTransaccion();
                        MessageBox.Show("El registro fue procesado satisfactoriamente.", "SysLab", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Dispose();
                    }
                    else
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("La operación no pudo ser completada.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
