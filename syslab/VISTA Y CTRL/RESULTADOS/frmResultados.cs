using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.RESULTADOS
{
    public partial class frmResultados : Form
    {
        public frmResultados()
        {
            InitializeComponent();
        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsSysLab.SOLICITUD' Puede moverla o quitarla según sea necesario.
            this.sOLICITUDTableAdapter.Fill(this.dsSysLab.SOLICITUD);
        }

        private void cmdAdministrar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count == 1)
            {
                var fila = (dsSysLab.SOLICITUDRow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAdminResultados(fila.ID_SOLICITUD);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    frmResultados_Load(sender, e);
            }
            else
                MessageBox.Show("Por favor, seleccione una solicitud.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count == 1)
            {
                var fila = (dsSysLab.SOLICITUDRow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var rep = new VISTA_Y_CTRL.RESULTADOS.rptResultados();

                var ds = new dsSysLab();
                var analisis = new dsSysLabTableAdapters.ANALISISTableAdapter();
                var analisis_dato = new dsSysLabTableAdapters.ANALISIS_DATOTableAdapter();
                var categoria = new dsSysLabTableAdapters.CATEGORIATableAdapter();
                var paciente = new dsSysLabTableAdapters.PACIENTETableAdapter();
                var solicitud = new dsSysLabTableAdapters.SOLICITUDTableAdapter();
                var solicitud_resulados = new dsSysLabTableAdapters.SOLICITUD_RESULTADOTableAdapter();
                var solicitud_resulados_detalle = new dsSysLabTableAdapters.SOLICITUD_RESULTADO_DETALLETableAdapter();
                var familias = new dsSysLabTableAdapters.FAMILIATableAdapter();
                var doctores = new dsSysLabTableAdapters.DOCTORESTableAdapter();

                analisis.Fill(ds.ANALISIS);
                analisis_dato.Fill(ds.ANALISIS_DATO);
                categoria.Fill(ds.CATEGORIA);
                paciente.Fill(ds.PACIENTE);
                solicitud.Fill(ds.SOLICITUD);
                solicitud_resulados.Fill(ds.SOLICITUD_RESULTADO);
                solicitud_resulados_detalle.Fill(ds.SOLICITUD_RESULTADO_DETALLE);
                familias.Fill(ds.FAMILIA);
                doctores.Fill(ds.DOCTORES);

                rep.SetDataSource(ds);
                rep.SetParameterValue("ID_SOLICITUD", fila.ID_SOLICITUD);

                var frm = new VISTA.frmReporteVisor(rep);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Por favor, seleccione una solicitud.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            sOLICITUDBindingSource.Filter =
                string.Format("NOMBRES LIKE '%{0}%'", txtDesc.Text.Trim());
        }
    }
}
