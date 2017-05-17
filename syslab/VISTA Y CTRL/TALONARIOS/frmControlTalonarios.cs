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
    public partial class frmControlTalonarios : Form
    {
        public frmControlTalonarios()
        {
            InitializeComponent();
        }

        private void frmControlTalonarios_Load(object sender, EventArgs e)
        {
            this.dOCTORESTableAdapter.Fill(this.dsSysLab.DOCTORES);
            this.tALONARIOTableAdapter.Fill(this.dsSysLab.TALONARIO);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            var frm = new frmAgregarTalonario();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                frmControlTalonarios_Load(sender, e);
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
                        var fila = (dsSysLab.TALONARIORow)((DataRowView)item.DataBoundItem).Row;

                        if (!CTRL.Administracion.Talonarios.EliminarTalonario(ps.DB, fila.ID_TALONARIO))
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
                        frmControlTalonarios_Load(sender, e);
                    }
                }
            }
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count != 1)
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.TALONARIORow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarTalonario(fila.ID_TALONARIO);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmControlTalonarios_Load(sender, e);
            }
        }
    }
}
