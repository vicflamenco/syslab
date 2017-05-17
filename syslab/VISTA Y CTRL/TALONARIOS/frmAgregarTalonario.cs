using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.TALONARIOS
{
    public partial class frmAgregarTalonario : Form
    {

        long _ID_EDITAR;
        bool _EDITANDO;
        
        public frmAgregarTalonario()
        {
            InitializeComponent();

            this.dOCTORESTableAdapter.Fill(this.dsSysLab.DOCTORES);
        }

        public frmAgregarTalonario(long ID)
        {
            InitializeComponent();

            this.dOCTORESTableAdapter.Fill(this.dsSysLab.DOCTORES);

            this._ID_EDITAR = ID;
            this._EDITANDO = true;

            var ps = new CTRL.Persistencia();
            ps.AbrirConexion();

            var reg = ps.SelPorLlave<TALONARIO>(ID.ToString());

            this.Text = this.lblTitulo.Text = "Editando Entrega de Talonario";

            nudCantidad.Value = (decimal)reg.CANTIDAD;
            dtpFecha.Value = reg.FECHA ?? dtpFecha.Value;

            if (_EDITANDO) this.cbDoctor.SelectedValue = reg.ID_DOCTOR;

            ps.CerrarConexion();
        }

        private void dOCTORESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dOCTORESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dsSysLab);

        }

        private void frmAgregarTalonario_Load(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los cambios realizados serán descartados. ¿Desea salir?", "SysLab", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (cbDoctor.SelectedIndex  < 0)
                MessageBox.Show("Debe seleccionar un doctor.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                var ps = new CTRL.Persistencia();
                ps.IniciarTransaccion();

                if (!this._EDITANDO)
                {
                    if (CTRL.Administracion.Talonarios.AgregarTalonario(ps.DB, (long)cbDoctor.SelectedValue,
                        dtpFecha.Value, (int)nudCantidad.Value))
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
                    if (CTRL.Administracion.Talonarios.EditarTalonario(ps.DB, this._ID_EDITAR, (long)cbDoctor.SelectedValue,
                        (int)nudCantidad.Value, dtpFecha.Value))
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

        private void cbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
