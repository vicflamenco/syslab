using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.CATALOGO
{
    public partial class frmCatalogo : Form
    {
        public frmCatalogo()
        {
            InitializeComponent();
        }

        private void frmCatalogo_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'dsSysLab.FAMILIA' table. You can move, or remove it, as needed.
this.fAMILIATableAdapter.Fill(this.dsSysLab.FAMILIA);
            this.aNALISISTableAdapter.Fill(this.dsSysLab.ANALISIS);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            var frm = new frmAgregarAnalisis();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                frmCatalogo_Load(sender, e);
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count != 1)
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.ANALISISRow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarAnalisis(fila.ID_ANALISIS);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmCatalogo_Load(sender, e);
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
                        var fila = (dsSysLab.ANALISISRow)((DataRowView)item.DataBoundItem).Row;

                        if (!CTRL.Administracion.CatalogoAnalisis.EliminarAnalisis(ps.DB, fila.ID_ANALISIS))
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
                        frmCatalogo_Load(sender, e);
                    }
                }
            }
        }

        private void cmdFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            aNALISISBindingSource.Filter = string.Format("NOMBRE LIKE '%{0}%' OR DESCRIPCION LIKE '%{0}%'", txtDesc.Text.Trim());
        }
    }
}
