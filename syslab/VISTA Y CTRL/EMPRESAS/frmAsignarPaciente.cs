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
    public partial class frmAsignarPaciente : Form
    {

        public long _ID_PACIENTE;
        public long _ID_SECTOR;

        public frmAsignarPaciente(long idSector)
        {
            InitializeComponent();
            this._ID_SECTOR = idSector;
            this.pACIENTETableAdapter.Fill(this.dsSysLab.PACIENTE);
            pACIENTEBindingSource.Filter = "ID_SECTOR IS NULL";
        }

        private void frmAsignarPaciente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSysLab.PACIENTE' table. You can move, or remove it, as needed.
            
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Trim() == string.Empty)
                pACIENTEBindingSource.Filter = "ID_SECTOR IS NULL";
            else
                pACIENTEBindingSource.Filter = string.Format("ID_SECTOR IS NULL AND (NOMBRES LIKE '%{0}%' OR NIT LIKE '{0}%' OR NRC LIKE '{0}%')", txtBuscar.Text);
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count > 0)
            {
                var ps = new CTRL.Persistencia();
                ps.IniciarTransaccion();
                
                int errores = 0;

                foreach (DataGridViewRow F in dgRegistros.SelectedRows)
                {
                    var fila = (dsSysLab.PACIENTERow)((DataRowView)F.DataBoundItem).Row;
                    if (!CTRL.Administracion.Pacientes.AsignarPaciente(ps.DB, fila.ID_PACIENTE, this._ID_SECTOR))
                        errores ++;                    
                }

                if (errores == 0)
                {
                    ps.FinalizarTransaccion();
                    MessageBox.Show("Los pacientes se asignaron satisfactoriamente.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
