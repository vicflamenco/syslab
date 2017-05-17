using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.PACIENTES
{
    public partial class frmAgregarPaciente : Form
    {
        long _ID_EDITAR;
        bool _EDITANDO;

        public frmAgregarPaciente()
        {
            InitializeComponent();
        }

        public frmAgregarPaciente(long ID, bool Visor = false)
        {
            InitializeComponent();

            this._ID_EDITAR = ID;
            this._EDITANDO = true;

            var ps = new CTRL.Persistencia();
            ps.AbrirConexion();

            var reg = ps.SelPorLlave<PACIENTE>(ID.ToString());

            this.Text = this.lblProd.Text = "Editando paciente";

            txtNombres.Text = reg.NOMBRES;
            txtTelefono.Text = reg.TELEFONO;
            dtpFecha.Value = reg.FECHA_NAC.Value;
            txtGiro.Text = reg.GIRO;
            txtDireccion.Text = reg.DIRECCION;
            txtMunicipio.Text = reg.MUNICIPIO;
            txtDepartamento.Text = reg.DEPARTAMENTO;
            txtNIT.Text = reg.NIT;
            txtCorreo.Text = reg.CORREO;

            ckCredito.Checked = reg.CREDITO;
            ckCFiscal.Checked = reg.CREDITO_FISCAL;
            ckExento.Checked = reg.EXENTO;
            ckTasaCero.Checked = reg.TASA_CERO;
            ckGranContribuyente.Checked = reg.GRAN_CONTRIBUYENTE;
            nudDiasCredito.Value = reg.CREDITO_DIAS;
            nudPrecioSel.Value = reg.PRECIO_SEL;

            if (Visor)
            {
                this.ControlBox = true;
                this.Text = this.lblProd.Text = "Visualizando cliente";

                txtNombres.ReadOnly = txtTelefono.ReadOnly = txtGiro.ReadOnly = txtDireccion.ReadOnly =
                    txtMunicipio.ReadOnly = txtDepartamento.ReadOnly = txtNIT.ReadOnly = txtNRC.ReadOnly =
                    txtCorreo.ReadOnly = true;

                nudPrecioSel.Enabled = dtpFecha.Enabled = ckCredito.Enabled = ckExento.Enabled = ckGranContribuyente.Enabled = ckTasaCero.Enabled =
                    nudDiasCredito.Enabled = cmdGuardar.Visible = cmdCancelar.Visible = false;
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
                    if (CTRL.Administracion.Pacientes.AgregarPaciente(ps.DB, dtpFecha.Value, txtNombres.Text.Trim(), 
                        txtGiro.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(),txtMunicipio.Text.Trim(),
                        txtDepartamento.Text.Trim(), txtNIT.Text.Trim(), txtNRC.Text.Trim(), ckGranContribuyente.Checked,
                        ckExento.Checked, ckTasaCero.Checked, ckCredito.Checked, (int)nudDiasCredito.Value, txtCorreo.Text.Trim(),
                        (int)nudPrecioSel.Value, ckCFiscal.Checked))
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
                    if (CTRL.Administracion.Pacientes.EditarPaciente(ps.DB,this._ID_EDITAR, dtpFecha.Value, txtNombres.Text.Trim(), 
                        txtGiro.Text.Trim(), txtDireccion.Text.Trim(), txtTelefono.Text.Trim(), txtMunicipio.Text.Trim(), 
                        txtDepartamento.Text.Trim(), txtNIT.Text.Trim(), txtNRC.Text.Trim(), ckGranContribuyente.Checked, 
                        ckExento.Checked, ckTasaCero.Checked, ckCredito.Checked, (int)nudDiasCredito.Value, txtCorreo.Text.Trim(),
                        (int)nudPrecioSel.Value, ckCFiscal.Checked))
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
