using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.REPORTES
{
    public partial class frmReportesVentas : Form
    {
        public frmReportesVentas()
        {
            InitializeComponent();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btReporteDiario_Click(object sender, EventArgs e)
        {
            var rep = new VISTA_Y_CTRL.REPORTES.rptVentaDiaria();

            var ds = new dsSysLab();
            var ventasdiarias = new dsSysLabTableAdapters.VENTAS_DIARIASTableAdapter();
            
            ventasdiarias.Fill(ds.VENTAS_DIARIAS);

            rep.SetDataSource(ds);
            rep.SetParameterValue("FECHA", dtpFecha.Value.Date);

            var frm = new VISTA.frmReporteVisor(rep);
            frm.ShowDialog();
        }

        private void frmReportesVentas_Load(object sender, EventArgs e)
        {
            
        }

        private void btReporteMensual_Click(object sender, EventArgs e)
        {
            var rep = new VISTA_Y_CTRL.REPORTES.rptVentaMensual();

            var ds = new dsSysLab();
            var ventasmensuales = new dsSysLabTableAdapters.VENTAS_MENSUALESTableAdapter();

            ventasmensuales.Fill(ds.VENTAS_MENSUALES);

            string mes = System.Globalization.CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat.GetMonthName(dtpMes.Value.Month);
            string mes2 = mes.Substring(0, 1).ToUpper() + mes.Substring(1, mes.Length - 1).ToLower();
            int año = dtpMes.Value.Year;
            rep.SetDataSource(ds);
            rep.SetParameterValue("Mes", mes2);
            rep.SetParameterValue("Año", año);

            var frm = new VISTA.frmReporteVisor(rep);
            frm.ShowDialog();
        }
    }
}
