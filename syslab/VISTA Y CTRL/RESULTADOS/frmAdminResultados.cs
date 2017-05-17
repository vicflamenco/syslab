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
    public partial class frmAdminResultados : Form
    {
        long ID_SOLICITUD;

        void Cargar()
        {
            dgRegistros.Rows.Clear();

            var ps = new CTRL.Persistencia();
            ps.AbrirConexion();

            var reg = ps.SelPorLlave<SOLICITUD>(ID_SOLICITUD.ToString());

            if (reg != null)
            {
                dtpFecha.Value = reg.FECHA_EMISION;
                dtpRequerido.Value = reg.FECHA_ENTREGA.Value;

                txtNombres.Text = reg.NOMBRES;

                decimal A = reg.SOLICITUD_RESULTADOs.Count();
                decimal B = reg.SOLICITUD_DETALLEs.Count();

                var progreso = (int)((A / B) * 100);

                pbProgreso.Value = progreso;

                foreach (var item in reg.SOLICITUD_DETALLEs)
                {
                    dgRegistros.Rows.Add(
                        new object[]{
                            item.ID_ANALISIS.ToString(), item.ANALISI.NOMBRE, 
                            reg.SOLICITUD_RESULTADOs.Where(c=> c.ID_ANALISIS == item.ID_ANALISIS)
                            .Select(c=>c.OBSERVACIONES).SingleOrDefault()
                            }
                        );
                }
            }

            ps.CerrarConexion();
        }

        public frmAdminResultados(long ID_SOLICITUD)
        {
            InitializeComponent();

            this.ID_SOLICITUD = ID_SOLICITUD;

            Cargar();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los cambios realizados serán descartados. ¿Desea salir?", "SysLab", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.CurrentRow != null)
            {
                var id_analisis = long.Parse(dgRegistros.CurrentRow.Cells[0].EditedFormattedValue.ToString());

                var frm = new frmResultadoAnalisis(this.ID_SOLICITUD, id_analisis, false);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    Cargar();
            }
            else
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdMostrar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.CurrentRow != null)
            {
                var id_analisis = long.Parse(dgRegistros.CurrentRow.Cells[0].EditedFormattedValue.ToString());

                var frm = new frmResultadoAnalisis(this.ID_SOLICITUD, id_analisis, true);

                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    Cargar();
            }
            else
                MessageBox.Show("Por favor, seleccione un registro.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
