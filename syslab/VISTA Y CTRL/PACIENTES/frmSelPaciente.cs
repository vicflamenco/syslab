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
    public partial class frmSelPaciente : Form
    {
        public long _ID_PACIENTE;
        public string _NOMBRES, _NIT, _NRC, _GIRO;
        public bool _RETENCION, _EXENTO, _TASA_CERO, _CFISCAL;
        public int _PRECIO_SEL = 1;

        public frmSelPaciente()
        {
            InitializeComponent();
        }

        private void frmSelPaciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSysLab.PACIENTE' Puede moverla o quitarla según sea necesario.
            this.pACIENTETableAdapter.Fill(this.dsSysLab.PACIENTE);
            txtBuscar.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            int noFact; string Texto;
            if (int.TryParse(txtBuscar.Text.Trim(), out noFact))
                Texto = string.Format("NIT LIKE '{0}%' OR NRC '{0}%'", noFact);
            else
                Texto = string.Format("NOMBRES LIKE '%{0}%'", txtBuscar.Text.Trim());
            pACIENTEBindingSource.Filter = Texto;
        }


        private void cmdSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count == 1)
            {
                var fila = (dsSysLab.PACIENTERow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                _ID_PACIENTE = fila.ID_PACIENTE;
                _NOMBRES = fila.NOMBRES;
                _GIRO = fila.GIRO;
                _NRC = fila.NRC;
                _NIT = fila.NIT;
                _RETENCION = fila.GRAN_CONTRIBUYENTE;
                _TASA_CERO = fila.TASA_CERO;
                _EXENTO = fila.EXENTO;
                _PRECIO_SEL = fila.PRECIO_SEL;
                _CFISCAL = fila.CREDITO_FISCAL;

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
            }
            else
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Dispose();
        }
    }
}
