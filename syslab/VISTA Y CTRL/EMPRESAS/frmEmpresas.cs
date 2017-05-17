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
    public partial class frmEmpresas : Form
    {
        public frmEmpresas()
        {
            InitializeComponent();
        }

        private void frmEmpresas_Load(object sender, EventArgs e)
        {
            this.eMPRESA_SECTORTableAdapter.Fill(this.dsSysLab.EMPRESA_SECTOR);
            this.eMPRESATableAdapter.Fill(this.dsSysLab.EMPRESA);
        }

        private void cmdAgregarEmpresa_Click(object sender, EventArgs e)
        {
            var frm = new frmAgregarEmpresa();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                frmEmpresas_Load(sender, e);
        }

        private void cmdEditarEmpresa_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count != 1)
                MessageBox.Show("Por favor, seleccione una empresa.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.EMPRESARow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarEmpresa(fila.ID_EMPRESA);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmEmpresas_Load(sender, e);
            }
        }

        private void cmdEliminarEmpresa_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count == 0)
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (MessageBox.Show("Los registros seleccionados serán eliminados. ¿Desesa continuar?", "SysLab", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    var ps = new CTRL.Persistencia();
                    ps.IniciarTransaccion();

                    int errores = 0;

                    foreach (DataGridViewRow item in dgDetalle.SelectedRows)
                    {
                        var fila = (dsSysLab.EMPRESARow)((DataRowView)item.DataBoundItem).Row;

                        if (!CTRL.Administracion.Empresas.EliminarEmpresa(ps.DB, fila.ID_EMPRESA))
                            errores++;
                    }

                    if (errores > 0)
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("Los registros no pudieron ser eliminados porque tienen operaciones relacionadas.", "SysLab",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ps.FinalizarTransaccion();

                        MessageBox.Show("Los registros fueron eliminados satisfactoriamente.", "SysLab", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        frmEmpresas_Load(sender, e);
                    }
                }
            }
        }

        private void cmdAgregarSector_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count != 1)
                MessageBox.Show("Por favor, seleccione una empresa.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.EMPRESARow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarSector(fila.ID_EMPRESA);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmEmpresas_Load(sender, e);
            }
        }

        private void cmdEditarSector_Click(object sender, EventArgs e)
        {
            if (dgDetalle.SelectedRows.Count != 1)
                MessageBox.Show("Por favor, seleccione una empresa.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.EMPRESA_SECTORRow)((DataRowView)dgDetalle.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarSector(fila.ID_SECTOR, fila.ID_EMPRESA);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmEmpresas_Load(sender, e);
            }
        }

        private void cmdEliminarSector_Click(object sender, EventArgs e)
        {
            if (dgDetalle.SelectedRows.Count == 0)
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (MessageBox.Show("Los registros seleccionados serán eliminados. ¿Desesa continuar?", "SysLab", MessageBoxButtons.YesNo, 
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    var ps = new CTRL.Persistencia();
                    ps.IniciarTransaccion();

                    int errores = 0;

                    foreach (DataGridViewRow item in dgDetalle.SelectedRows)
                    {
                        var fila = (dsSysLab.EMPRESA_SECTORRow)((DataRowView)item.DataBoundItem).Row;

                        if (!CTRL.Administracion.Empresas.EliminarSector(ps.DB, fila.ID_SECTOR))
                            errores++;
                    }

                    if (errores > 0)
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("Los registros no pudieron ser eliminados porque tienen operaciones relacionadas.", "SysLab",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ps.FinalizarTransaccion();

                        MessageBox.Show("Los registros fueron eliminados satisfactoriamente.", "SysLab", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        frmEmpresas_Load(sender, e);
                    }
                }
            }
        }

        private void cmdFiltrar_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdAdminPacientes_Click(object sender, EventArgs e)
        {
            if (dgDetalle.SelectedRows.Count == 0)
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.EMPRESA_SECTORRow)((DataRowView)dgDetalle.CurrentRow.DataBoundItem).Row;
                var frm = new frmAdminSector(fila.ID_SECTOR);
                frm.Text = "Administrar Pacientes del Sector " + fila.NOMBRE;
                frm.ShowDialog();
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            eMPRESABindingSource.Filter =
                string.Format("NOMBRE LIKE '%{0}%'", txtDesc.Text.Trim());
        }

        
    }
}
