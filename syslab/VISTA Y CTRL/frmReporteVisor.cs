using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA
{
    public partial class frmReporteVisor : Form
    {
        public frmReporteVisor()
        {
            InitializeComponent();
        }

        public frmReporteVisor(Object reporte)
        {
            InitializeComponent();

            this.crvVisor.ReportSource = reporte;
            crvVisor.Refresh();
        }
    }
}
