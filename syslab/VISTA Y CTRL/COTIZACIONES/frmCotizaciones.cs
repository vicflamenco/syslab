using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.COTIZACIONES
{
    public partial class frmCotizaciones : Form
    {
        public frmCotizaciones()
        {
            InitializeComponent();
        }

        private void frmCotizaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSysLab.DOCTORES' table. You can move, or remove it, as needed.
            this.dOCTORESTableAdapter.Fill(this.dsSysLab.DOCTORES);
            // TODO: This line of code loads data into the 'dsSysLab.PACIENTE' table. You can move, or remove it, as needed.
            this.pACIENTETableAdapter.Fill(this.dsSysLab.PACIENTE);
            this.cOTIZACIONTableAdapter.Fill(this.dsSysLab.COTIZACION);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            var frm = new frmAgregarCotizacion();

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                frmCotizaciones_Load(sender, e);
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count == 1)
            {
                var fila = (dsSysLab.COTIZACIONRow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarCotizacion(fila.ID_COTIZACION);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmCotizaciones_Load(sender, e);
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
                        var fila = (dsSysLab.COTIZACIONRow)((DataRowView)item.DataBoundItem).Row;

                        if (!CTRL.Examenes.Cotizaciones.EliminarCotizacion(ps.DB, fila.ID_COTIZACION))
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
                        frmCotizaciones_Load(sender, e);
                    }
                }
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            cOTIZACIONBindingSource.Filter = string.Format("NOMBRES LIKE '%{0}%'", txtDesc.Text.Trim());
        }
    }
}
