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
    public partial class frmSelDoctor : Form
    {
        public long _ID_DOCTOR;
        public string _NOMBRES;

        public frmSelDoctor()
        {
            InitializeComponent();
        }

        private void frmSelDoctor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSysLab.DOCTORES' Puede moverla o quitarla según sea necesario.
            this.dOCTORESTableAdapter.Fill(this.dsSysLab.DOCTORES);
            txtBuscar.Focus();
        }

        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count == 1)
            {
                var fila = (dsSysLab.DOCTORESRow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                _ID_DOCTOR = fila.ID_DOCTOR;
                _NOMBRES = fila.NOMBRES;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
            }
            else
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dOCTORESBindingSource.Filter =
                string.Format("NOMBRES LIKE '%{0}%'", txtBuscar.Text.Trim());
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
    }
}
