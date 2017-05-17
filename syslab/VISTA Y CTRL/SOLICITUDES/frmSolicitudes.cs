using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.SOLICITUDES
{
    public partial class frmSolicitudes : Form
    {
        public frmSolicitudes()
        {
            InitializeComponent();
        }

        private void frmSolicitudes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSysLab.DOCTORES' table. You can move, or remove it, as needed.
            this.dOCTORESTableAdapter.Fill(this.dsSysLab.DOCTORES);
            this.sOLICITUDTableAdapter.Fill(this.dsSysLab.SOLICITUD);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            var frm = new frmAgregarSolicitud();

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                frmSolicitudes_Load(sender, e);
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count == 1)
            {
                var fila = (dsSysLab.SOLICITUDRow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarSolicitud(fila.ID_SOLICITUD);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmSolicitudes_Load(sender, e);
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count == 0)
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (MessageBox.Show("Los registros seleccionados serán eliminados permanentemente. ¿Desea continuar?.", "SysLab",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    var ps = new CTRL.Persistencia();
                    ps.IniciarTransaccion();

                    int errores = 0;

                    foreach (DataGridViewRow item in dgRegistros.SelectedRows)
                    {
                        var fila = (dsSysLab.SOLICITUDRow)((DataRowView)item.DataBoundItem).Row;

                        if (!CTRL.Examenes.Solicitudes.EliminarSolicitud(ps.DB, fila.ID_SOLICITUD))
                            errores++;
                    }

                    if (errores > 0)
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("Los registros no pudieron ser eliminados porque tienen operaciones relacionadas.",
                            "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        ps.FinalizarTransaccion();

                        MessageBox.Show("Los registros fueron eliminados satisfactoriamente.", "SysLab", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        frmSolicitudes_Load(sender, e);
                    }
                }
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            int noFact; string Texto;
            if (int.TryParse(txtDesc.Text.Trim(), out noFact))
                Texto = string.Format("NO_FACTURA = {0}", noFact);
            else
                Texto = string.Format("NOMBRES LIKE '%{0}%'", txtDesc.Text.Trim());
            sOLICITUDBindingSource.Filter = Texto;    
        }
    }
}
