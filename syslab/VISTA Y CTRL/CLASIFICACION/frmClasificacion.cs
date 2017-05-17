using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.CLASIFICACION
{
    public partial class frmClasificacion : Form
    {
        public frmClasificacion()
        {
            InitializeComponent();
        }

        private void frmClasificacion_Load(object sender, EventArgs e)
        {
            this.fAMILIATableAdapter.Fill(this.dsSysLab.FAMILIA);
            this.cATEGORIATableAdapter.Fill(this.dsSysLab.CATEGORIA);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            var frm = new frmAgregarCategoria();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                frmClasificacion_Load(sender, e);
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count != 1)
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.CATEGORIARow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarCategoria(fila.ID_CATEGORIA);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmClasificacion_Load(sender, e);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
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

                    foreach (DataGridViewRow item in dgRegistros.SelectedRows)
                    {
                        var fila = (dsSysLab.CATEGORIARow)((DataRowView)item.DataBoundItem).Row;

                        if (!CTRL.Administracion.Clasificaciones.EliminarCategoria(ps.DB, fila.ID_CATEGORIA))
                            errores++;
                    }

                    if (errores > 0)
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("Los registros no pudieron ser eliminados porque tienen operaciones relacionadas.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ps.FinalizarTransaccion();

                        MessageBox.Show("Los registros fueron eliminados satisfactoriamente.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmClasificacion_Load(sender, e);
                    }
                }
            }
        }

        private void cmdAgregarFamilia_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count != 1)
                MessageBox.Show("Por favor, seleccione una categoría.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.CATEGORIARow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarFamilia(fila.ID_CATEGORIA);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmClasificacion_Load(sender, e);
            }
        }

        private void cmdEditarFamilia_Click(object sender, EventArgs e)
        {
            if (dgDetalle.SelectedRows.Count != 1)
                MessageBox.Show("Por favor, seleccione una familia.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.FAMILIARow)((DataRowView)dgDetalle.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarFamilia(fila.ID_FAMILIA,fila.ID_CATEGORIA);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmClasificacion_Load(sender, e);
            }
        }

        private void cmdEliminarFamilia_Click(object sender, EventArgs e)
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
                        var fila = (dsSysLab.FAMILIARow)((DataRowView)item.DataBoundItem).Row;

                        if (!CTRL.Administracion.Clasificaciones.EliminarFamilia(ps.DB, fila.ID_FAMILIA))
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
                        frmClasificacion_Load(sender, e);
                    }
                }
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            cATEGORIABindingSource.Filter = string.Format("NOMBRE LIKE '%{0}%'", txtDesc.Text.Trim());
        }
    }
}
