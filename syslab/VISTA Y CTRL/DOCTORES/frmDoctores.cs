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
    public partial class frmDoctores : Form
    {
        public frmDoctores()
        {
            InitializeComponent();
        }

        private void frmDoctores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSysLab.EMPRESA' table. You can move, or remove it, as needed.
            this.eMPRESATableAdapter.Fill(this.dsSysLab.EMPRESA);
            this.dOCTORESTableAdapter.Fill(this.dsSysLab.DOCTORES);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            var frm = new frmAgregarDoctor();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                frmDoctores_Load(sender, e);
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count != 1)
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.DOCTORESRow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarDoctor(fila.ID_DOCTOR);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmDoctores_Load(sender, e);
            }
        }

        private void cmdMostar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count != 1)
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.DOCTORESRow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarDoctor(fila.ID_DOCTOR, true);
                frm.ShowDialog();
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
                        var fila = (dsSysLab.DOCTORESRow)((DataRowView)item.DataBoundItem).Row;

                        if (!CTRL.Administracion.Doctores.EliminarDoctores(ps.DB, fila.ID_DOCTOR))
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
                        frmDoctores_Load(sender, e);
                    }
                }
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            dOCTORESBindingSource.Filter = string.Format("NOMBRES LIKE '%{0}%'", txtDesc.Text.Trim());
        }
    }
}
