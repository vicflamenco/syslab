using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.DOCTORES
{
    public partial class frmAgregarDoctor : Form
    {
        long _ID_EDITAR;
        bool _EDITANDO;

        public frmAgregarDoctor()
        {
            InitializeComponent();
        }

        public frmAgregarDoctor(long ID, bool Visor = false)
        {
            InitializeComponent();

            this._ID_EDITAR = ID;
            this._EDITANDO = true;

            var ps = new CTRL.Persistencia();
            ps.AbrirConexion();

            var reg = ps.SelPorLlave<DOCTORE>(ID.ToString());

            this.Text = this.lblTitulo.Text = "Editando doctor";

            txtNombres.Text = reg.NOMBRES;
            txtTelefono.Text = reg.TELEFONO;
            txtDireccion.Text = reg.DIRECCION;
            txtNIT.Text = reg.NIT;
            txtDUI.Text = reg.DUI;
            txtCorreo.Text = reg.CORREO;
            txtClinicaNombre.Text = reg.CLINICA_NOMBRE;
            txtClinicaTelefono.Text = reg.CLINICA_TELEFONO;

            if (Visor)
            {
                this.ControlBox = true;
                this.Text = this.lblTitulo.Text = "Visualizando doctor";

                txtNombres.ReadOnly = txtTelefono.ReadOnly = txtDUI.ReadOnly = txtDireccion.ReadOnly =
                    txtClinicaNombre.ReadOnly = txtClinicaTelefono.ReadOnly = txtNIT.ReadOnly = txtCorreo.ReadOnly = true;

                cmdGuardar.Visible = cmdCancelar.Visible = false;
            }

            ps.CerrarConexion();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los cambios realizados serán descartados. ¿Desea salir?", "SysLab", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
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
                    if (CTRL.Administracion.Doctores.AgregarDoctores(ps.DB, txtNombres.Text.Trim(), txtDireccion.Text.Trim(), 
                        txtTelefono.Text.Trim(), txtNIT.Text.Trim(), txtDUI.Text.Trim(),txtCorreo.Text.Trim(), 
                        txtClinicaNombre.Text.Trim(), txtClinicaTelefono.Text.Trim()))
                    {
                        ps.FinalizarTransaccion();
                        MessageBox.Show("El registro fue procesado satisfactoriamente.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                    if (CTRL.Administracion.Doctores.EditarDoctores(ps.DB, this._ID_EDITAR, txtNombres.Text.Trim(), txtDireccion.Text.Trim(),
                        txtTelefono.Text.Trim(), txtNIT.Text.Trim(), txtDUI.Text.Trim(), txtCorreo.Text.Trim(),
                        txtClinicaNombre.Text.Trim(), txtClinicaTelefono.Text.Trim()))
                    {
                        ps.FinalizarTransaccion();
                        MessageBox.Show("El registro fue procesado satisfactoriamente.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
