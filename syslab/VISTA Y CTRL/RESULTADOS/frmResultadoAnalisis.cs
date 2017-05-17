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
    public partial class frmResultadoAnalisis : Form
    {
        long ID_SOL, ID_ANALISIS;

        public frmResultadoAnalisis(long ID_SOLICITUD, long ID_ANALISIS, bool visor)
        {
            InitializeComponent();

            this.ID_SOL = ID_SOLICITUD;
            this.ID_ANALISIS = ID_ANALISIS;

            var ps = new CTRL.Persistencia();
            ps.AbrirConexion();

            var reg = ps.SelPorLlave<ANALISI>(ID_ANALISIS.ToString());

            txtNombre.Text = reg.NOMBRE;
            txtDesc.Text = reg.DESCRIPCION;
            txtObservaciones.Text = ps.DB.SOLICITUD_RESULTADOs.Where(c => c.ID_ANALISIS == ID_ANALISIS && c.ID_SOLICITUD == ID_SOLICITUD)
                .Select(c => c.OBSERVACIONES).SingleOrDefault();

            foreach (ANALISIS_DATO item in reg.ANALISIS_DATOs)
            {
                var fila = dgCampos.Rows[
                    dgCampos.Rows.Add(new object[] { item.CAMPO, item.UMEDIDA, item.REF, item.RMIN, item.RMAX,
                    item.SOLICITUD_RESULTADO_DETALLEs.Where(
                        c=> c.SOLICITUD_RESULTADO.ID_SOLICITUD == ID_SOLICITUD && 
                            c.SOLICITUD_RESULTADO.ID_ANALISIS == ID_ANALISIS).Select(c => c.VALOR).SingleOrDefault(),
                    item.SOLICITUD_RESULTADO_DETALLEs.Where(
                        c=> c.SOLICITUD_RESULTADO.ID_SOLICITUD == ID_SOLICITUD && 
                            c.SOLICITUD_RESULTADO.ID_ANALISIS == ID_ANALISIS).Select(c => c.COMENTARIOS).SingleOrDefault(),
                    })
                    ];
                fila.Tag = item.ID_ANALISIS_DATO;
            }

            ps.CerrarConexion();

            if (visor)
            {
                dgCampos.ReadOnly = true;
                colValor.ReadOnly = true;
                colComentario.ReadOnly = true;

                txtObservaciones.ReadOnly = true;

                this.Text = lblTitulo.Text = "Visualizando resultado de análisis clínico";
                this.cmdCancelar.Visible = this.cmdGuardar.Visible = false;

                this.ControlBox = true;
            }

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los cambios realizados serán descartados. ¿Desea salir?", "SysLab", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            var detalle = new List<SOLICITUD_RESULTADO_DETALLE>();

            foreach (DataGridViewRow fila in dgCampos.Rows)
            {
                if (fila.IsNewRow || fila.Index < 0)
                    continue;

                detalle.Add(
                    new SOLICITUD_RESULTADO_DETALLE
                    {
                        ID_ANALISIS_DATO = (string)fila.Tag,
                        VALOR = fila.Cells[5].EditedFormattedValue.ToString(),
                        COMENTARIOS = fila.Cells[6].EditedFormattedValue.ToString()
                    }
                    );
            }

            var ps = new CTRL.Persistencia();
            ps.IniciarTransaccion();

            if (CTRL.Examenes.Resultados.ProcesarResultados(ps.DB, this.ID_SOL, this.ID_ANALISIS, txtObservaciones.Text.Trim(),
                detalle))
            {
                ps.FinalizarTransaccion();

                MessageBox.Show("El resultado fue procesado satisfactoriamente.", "SysLab", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Dispose();
            }
            else
            {
                ps.RevertirTransaccion();
                MessageBox.Show("El resultado no pudo ser procesado. La operación fue cancelada.", "SysLab", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }
    }
}
