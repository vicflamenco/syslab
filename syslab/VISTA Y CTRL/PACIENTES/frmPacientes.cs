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
    public partial class frmPacientes : Form
    {
        public frmPacientes()
        {
            InitializeComponent();
        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            this.pACIENTETableAdapter.Fill(this.dsSysLab.PACIENTE);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            var frm = new frmAgregarPaciente();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                frmPacientes_Load(sender, e);
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count != 1)
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.PACIENTERow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarPaciente(fila.ID_PACIENTE);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmPacientes_Load(sender, e);
            }
        }

        private void cmdMostar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count != 1)
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var fila = (dsSysLab.PACIENTERow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarPaciente(fila.ID_PACIENTE,true);
                frm.ShowDialog();
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count != 0)
            {
                var ps = new CTRL.Persistencia();
                ps.IniciarTransaccion();
                int errores = 0;
                foreach (DataGridViewRow item in dgRegistros.SelectedRows)
                {
                    var fila = (dsSysLab.PACIENTERow)((DataRowView)item.DataBoundItem).Row;
                    if (!CTRL.Administracion.Pacientes.EliminarPaciente(ps.DB, fila.ID_PACIENTE))
                        errores++;
                }
                if (errores > 0) ps.RevertirTransaccion();
                else
                {
                    ps.FinalizarTransaccion();
                    frmPacientes_Load(sender, e);
                }
            }  
        }



        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            pACIENTEBindingSource.Filter = "NOMBRES LIKE '%" + txtDesc.Text + "%'";
        }
    }
}
