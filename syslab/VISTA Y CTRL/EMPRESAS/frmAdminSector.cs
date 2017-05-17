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
    public partial class frmAdminSector : Form
    {
        private long _ID_SECTOR;

        public frmAdminSector()
        {
            InitializeComponent();
            this.pACIENTETableAdapter.Fill(this.dsSysLab.PACIENTE);
        }
        public frmAdminSector(long idSector)
        {
            InitializeComponent();
            this.pACIENTETableAdapter.Fill(this.dsSysLab.PACIENTE);

            this._ID_SECTOR = idSector;
            pACIENTEBindingSource.Filter = "ID_SECTOR = " + idSector;

        }

        private void frmAdminSector_Load(object sender, EventArgs e)
        {
            
        }

        private void btAsignar_Click(object sender, EventArgs e)
        {
            var frm = new frmAsignarPaciente(this._ID_SECTOR);
            frm.ShowDialog();
            this.pACIENTETableAdapter.Fill(this.dsSysLab.PACIENTE);
        }

        private void btDesasignar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count > 0)
            {
                var ps = new CTRL.Persistencia();
                ps.IniciarTransaccion();

                foreach (DataGridViewRow F in dgRegistros.SelectedRows)
                {
                    var fila = (dsSysLab.PACIENTERow)((DataRowView)F.DataBoundItem).Row;
                    if (CTRL.Administracion.Pacientes.AsignarPaciente(ps.DB, fila.ID_PACIENTE, null))
                    {
                        ps.FinalizarTransaccion();
                        MessageBox.Show("Los pacientes se asignaron satisfactoriamente.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.pACIENTETableAdapter.Fill(this.dsSysLab.PACIENTE);
                    }
                    else
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("La operación no pudo ser completada.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar al menos un paciente a desasignar", "SysLab",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
