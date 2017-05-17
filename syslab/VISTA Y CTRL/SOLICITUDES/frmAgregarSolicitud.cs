using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.SOLICITUDES
{
    public partial class frmAgregarSolicitud : Form
    {
        long _ID_SOLICITUD;

        bool _EDITANDO, _RETENCION, _EXENTO, _AGREGANDO_FILAS;
        int _PRECIO_SEL=1;

        decimal gravado, iva, subtotal, exento, retencion, total;

        decimal ptjIVA, ptjReten;

        public frmAgregarSolicitud()
        {
            InitializeComponent();
            this.nudIVA.Value = CTRL.Datos.ptjeIVA*100;
            this.nudReten.Value = CTRL.Datos.ptjeRetencion*100;
            this.ckCFinal.Checked = true; 
        }

        public frmAgregarSolicitud(long ID, bool visor = false)
        {
            InitializeComponent();

            this._EDITANDO = true;
            this.lblTitulo.Text = this.Text = "Editando Solicitud";

            this._ID_SOLICITUD = ID;

            var ps = new CTRL.Persistencia();
            ps.AbrirConexion();

            var reg = ps.SelPorLlave<SOLICITUD>(ID.ToString());

            if (reg != null)
            {
                this.nudIVA.Value = reg.PORCENTAJE_IVA * 100;
                this.nudReten.Value = reg.PORCENTAJE_RETENCION * 100;

                txtPacienteID.Text = reg.ID_PACIENTE.ToString();
                txtDoctorID.Text = reg.ID_DOCTOR.ToString();
                txtDoctorNombre.Text = reg.DOCTORE.NOMBRES;
                txtNombre.Text = reg.NOMBRES;
                txtNRC.Text = reg.NRC;
                txtNIT.Text = reg.NIT;
                txtGiro.Text = reg.GIRO;
                txtFactura.Text = reg.NO_FACTURA.ToString();

                dtpFecha.Value = reg.FECHA_EMISION;
                dtpRequerido.Value = reg.FECHA_ENTREGA.Value;

                ckCFinal.Checked = !reg.CREDITO_FISCAL;
                ckCFiscal.Checked = reg.CREDITO_FISCAL;
                ckRetencion.Checked = reg.RETENCION;

                //AGREGANDO DETALLE
                this._AGREGANDO_FILAS = true;

                foreach (var item in reg.SOLICITUD_DETALLEs)
                {
                    int f = dgMovs.Rows.Add();

                    dgMovs.Rows[f].SetValues(new object[] {item.ID_ANALISIS, item.ANALISI.NOMBRE, item.PRECIO, item.OBSERVACIONES, 
                        item.EXENTO });
                }
                this._AGREGANDO_FILAS = false;

                if (visor)
                {
                    this.cmdPaciente.Enabled = cmdDoctor.Enabled = ckRetencion.Enabled = ckCFiscal.Enabled = ckCFinal.Enabled =
                        dtpFecha.Enabled = dtpRequerido.Enabled = cmdEliminarMov.Enabled = nudIVA.Enabled = nudReten.Enabled = false;

                    txtNombre.ReadOnly = txtNRC.ReadOnly = txtNIT.ReadOnly = txtFactura.ReadOnly = txtGiro.ReadOnly = true;
                }
                
                ActualizarTotales();
            }
            else
            {
                MessageBox.Show("El registro no fue encontrado.", "ContaClic", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }

        }

        private void frmAgregarSolicitud_Load(object sender, EventArgs e)
        {
            this.aNALISISTableAdapter.Fill(this.dsSysLab.ANALISIS);
        }

        void ActualizarTotales()
        {
            if (!_AGREGANDO_FILAS)
            {
                gravado = (from DataGridViewRow c in dgMovs.Rows
                           where !c.IsNewRow && ((bool)c.Cells[4].FormattedValue) == false
                           select
                           decimal.Parse(c.Cells[2].FormattedValue.ToString())
                           ).Sum();
                gravado = decimal.Round(gravado, 2);

                //SE UTILIZARÁ COMO SUBTOTAL SI ES CONSUMIDOR FINAL
                decimal aux_subtotal = gravado;

                gravado = (this.ckCFinal.Checked) ?
                    decimal.Round(gravado / (1 + this.ptjIVA), 2) : gravado;

                txtGravado.Text = gravado.ToString("0.00");

                iva = (this.ckCFinal.Checked) ?
                    decimal.Round(aux_subtotal - gravado, 2) : decimal.Round(gravado * this.ptjIVA, 2);
                txtIVA.Text = iva.ToString("0.00");

                subtotal = gravado + iva;
                txtSubTotal.Text = subtotal.ToString("0.00");

                exento = (from DataGridViewRow c in dgMovs.Rows
                          where !c.IsNewRow && ((bool)c.Cells[4].FormattedValue) == true
                          select
                          decimal.Parse(c.Cells[2].FormattedValue.ToString())
                          ).Sum();

                exento = decimal.Round(exento, 2);
                txtExento.Text = exento.ToString("0.00");

                retencion = (ckRetencion.Checked) ? decimal.Round(gravado * this.ptjReten, 2) : 0;
                txtPercepcion.Text = retencion.ToString("0.00");

                total = subtotal + exento - retencion;
                txtTotal.Text = total.ToString("0.00");

                if  (_RETENCION)
                    ckRetencion.Checked = true;
            }
        }

        private void cmdPaciente_Click(object sender, EventArgs e)
        {
            var frm = new PACIENTES.frmSelPaciente();

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtPacienteID.Text = frm._ID_PACIENTE.ToString();
                this._RETENCION = frm._RETENCION;
                this._EXENTO = frm._EXENTO;
                if (frm._TASA_CERO) nudIVA.Value = 0;

                this._PRECIO_SEL = frm._PRECIO_SEL;

                ckCFinal.Checked = !frm._CFISCAL;
                ckCFiscal.Checked = frm._CFISCAL;

                txtNombre.Text = frm._NOMBRES;
                txtNRC.Text = frm._NRC;
                txtNIT.Text = frm._NIT;
                txtGiro.Text = frm._GIRO;
            }
        }

        private void cmdDoctor_Click(object sender, EventArgs e)
        {
            var frm = new DOCTORES.frmSelDoctor();

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtDoctorID.Text = frm._ID_DOCTOR.ToString();
                this.txtDoctorNombre.Text = frm._NOMBRES;
            }
        }

        private void nudIVA_ValueChanged(object sender, EventArgs e)
        {
            this.ptjIVA = decimal.Round(this.nudIVA.Value / 100,4);
        }

        private void nudReten_ValueChanged(object sender, EventArgs e)
        {
            this.ptjReten = decimal.Round(this.nudReten.Value / 100, 4);
        }

        private void dgMovs_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            ActualizarTotales();
        }

        private void dgMovs_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
                dgAnalisis.Visible = true;
            else if (e.ColumnIndex == 4)
                lstPrecios.Visible = true;
        }

        private void dgMovs_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 || e.ColumnIndex == 1)
            {
                if (dgAnalisis.SelectedRows.Count > 0)
                {
                    dsSysLab.ANALISISRow fila = (dsSysLab.ANALISISRow)((System.Data.DataRowView)dgAnalisis.SelectedRows[0].DataBoundItem).Row;

                    dgMovs.Rows[e.RowIndex].Cells[0].Value = fila.ID_ANALISIS;
                    dgMovs.Rows[e.RowIndex].Cells[1].Value = fila.NOMBRE;

                    dgAnalisis.Visible = false;
                }
                else
                {
                    dgMovs.Rows[e.RowIndex].Cells[0].Value = "";
                    dgMovs.Rows[e.RowIndex].Cells[1].Value = "";
                    dgMovs.Rows[e.RowIndex].Cells[2].Value = "0.00";
                    dgMovs.Rows[e.RowIndex].Cells[3].Value = "";

                    dgMovs.Rows[e.RowIndex].Tag = null;

                    dgAnalisis.Visible = false;
                }
            }
            else if (e.ColumnIndex == 4)
                lstPrecios.Visible = false;
        }

        private void dgMovs_CurrentCellChanged(object sender, EventArgs e)
        {
            dgAnalisis.Visible = false;
            lstPrecios.Visible = false;
        }

        private void dgMovs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //SI SE CHECKEO QUE ES EXENTO Y LA FACTURA ESTÁ EN CONSUMIDOR FINAL SE DEBE QUITAR EL IVA
            if (e.ColumnIndex == 4 && !_AGREGANDO_FILAS && e.RowIndex >= 0)
            {
                if (ckCFinal.Checked && (bool)dgMovs[4, e.RowIndex].Value)
                    dgMovs[2, e.RowIndex].Value = decimal.Round((decimal)dgMovs[2, e.RowIndex].Value / (1 + this.ptjIVA), 2);
                else if (ckCFinal.Checked && !(bool)dgMovs[4, e.RowIndex].Value)
                    dgMovs[2, e.RowIndex].Value = decimal.Round((decimal)dgMovs[2, e.RowIndex].Value * (1 + this.ptjIVA), 2);

                var fila = dgMovs.Rows[e.RowIndex];

                if (fila.Tag != null)
                {
                    var lsPrecios = (List<decimal>)fila.Tag;
                    bool fila_Exenta = (bool)fila.Cells[4].FormattedValue;


                    if (fila_Exenta)
                    {
                        //CONSUMIDOR FINAL, LISTA DE PRECIOS TIENE IVA, SE DEBE QUITAR
                        if (ckCFinal.Checked)
                        {
                            lsPrecios[0] = decimal.Round((lsPrecios[0] / (1 + this.ptjIVA)), 4);
                            lsPrecios[1] = decimal.Round((lsPrecios[1] / (1 + this.ptjIVA)), 4);
                            lsPrecios[2] = decimal.Round((lsPrecios[2] / (1 + this.ptjIVA )), 4);
                        }
                    }
                    else
                    {
                        //CONSUMIDOR FINAL, LISTA DE PRECIOS TIENE IVA, SE DEBE PONER
                        if (ckCFinal.Checked)
                        {
                            lsPrecios[0] = decimal.Round((lsPrecios[0] * (1 + this.ptjIVA)), 4);
                            lsPrecios[1] = decimal.Round((lsPrecios[1] * (1 + this.ptjIVA)), 4);
                            lsPrecios[2] = decimal.Round((lsPrecios[2] * (1 + this.ptjIVA)), 4);
                        }
                    }
                    fila.Tag = lsPrecios;
                }
            }
            ActualizarTotales();

            if (e.ColumnIndex == 0 && e.RowIndex >= 0 && dgMovs[0, e.RowIndex].EditedFormattedValue.ToString() != string.Empty)
            {
                var ps = new CTRL.Persistencia();
                ps.AbrirConexion();
                var db = ps.DB;

                try
                {
                    List<decimal> precios = new List<decimal>();

                    var analisis = db.ANALISIs.Where(p => p.ID_ANALISIS ==
                        long.Parse(dgMovs[0, e.RowIndex].Value.ToString())).SingleOrDefault();

                    if (analisis != null)
                    {
                        precios.Add(decimal.Round(analisis.PRECIO1 * ((ckCFinal.Checked) ? (1 + this.ptjIVA) : 1), 2));
                        precios.Add(decimal.Round(analisis.PRECIO2 * ((ckCFinal.Checked) ? (1 + this.ptjIVA) : 1), 2));
                        precios.Add(decimal.Round(analisis.PRECIO3 * ((ckCFinal.Checked) ? (1 + this.ptjIVA) : 1), 2));

                        dgMovs.Rows[e.RowIndex].Tag = precios;

                        dgMovs.Rows[e.RowIndex].Cells[2].Value = precios[_PRECIO_SEL - 1];
                    }
                }
                catch (Exception)
                {
                    ps.CerrarConexion();
                }
            }
            else if (e.RowIndex >= 0 && e.ColumnIndex == 0)
                dgMovs.Rows[e.RowIndex].Tag = null;
        }

        private void dgMovs_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
                if (dgMovs.Rows[e.RowIndex].Tag != null && !this.ControlBox)
                    lstPrecios.Visible = true;
        }

        private void dgMovs_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgMovs.CurrentCell.ColumnIndex == 0 || dgMovs.CurrentCell.ColumnIndex == 1)
            {
                TextBox tb = (TextBox)e.Control;
                tb.TextChanged += new EventHandler(tb_TextChanged);
            }
        }
        
        void tb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            try
            {
                if (tb.Text.Length != 0)
                {
                    if (dgMovs.CurrentCell.ColumnIndex == 0)
                        aNALISISBindingSource.Filter = "ID_ANALISIS LIKE " + tb.Text;
                    else if (dgMovs.CurrentCell.ColumnIndex == 1)
                        aNALISISBindingSource.Filter = string.Format("NOMBRE LIKE '%{0}%'", tb.Text);
                }
                else
                    aNALISISBindingSource.Filter = "";
            }
            catch (Exception)
            {

            }
        }

        private void dgMovs_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            if (e.Row.Index >= 0 && this._EXENTO)
            {
                e.Row.Cells[4].Value = true;
            }
        }

        private void dgAnalisis_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgAnalisis.SelectedRows.Count > 0)
                dgMovs.EndEdit();
        }

        private void lstPrecios_VisibleChanged(object sender, EventArgs e)
        {
            if (dgMovs.CurrentRow != null && lstPrecios.Visible)
            {
                if (dgMovs.CurrentRow.Tag != null)
                {
                    lstPrecios.DataSource = null;
                    lstPrecios.Items.Clear();
                    lstPrecios.DataSource = dgMovs.CurrentRow.Tag;
                    lstPrecios.Refresh();
                }
            }
            else if (!lstPrecios.Visible)
            {
                dgMovs.Focus();
            }
        }

        private void lstPrecios_MouseClick(object sender, MouseEventArgs e)
        {
            if (lstPrecios.SelectedItem != null && dgMovs.CurrentRow != null)
            {
                dgMovs.CurrentRow.Cells[2].Value = decimal.Parse(lstPrecios.SelectedItem.ToString());
                dgMovs.Focus();
                SendKeys.Send("{TAB}");
            }
        }

        private void ckCFiscal_CheckedChanged(object sender, EventArgs e)
        {
            if (lstPrecios.Visible)
            {
                lstPrecios.Hide(); lstPrecios.Show();
            }

            lblIVA.Visible = lblGravado.Visible = txtGravado.Visible = txtIVA.Visible = ckRetencion.Enabled = txtPercepcion.Enabled =
                (this.ckCFiscal.Checked) ? true : false;

            ckRetencion.Checked = (ckCFinal.Checked) ? false : ckRetencion.Checked;

            foreach (DataGridViewRow fila in dgMovs.Rows)
            {
                if (!fila.IsNewRow)
                {
                    if ((bool)fila.Cells[4].FormattedValue == false)
                    {
                        decimal valorU = decimal.Parse(fila.Cells[2].FormattedValue.ToString());

                        valorU = (!this.ckCFiscal.Checked) ? decimal.Round(valorU * (1 + this.ptjIVA), 2) : decimal.Round(valorU / (1 + this.ptjIVA), 2);

                        if (fila.Tag != null)
                            fila.Cells[2].Value = valorU.ToString("0.00");
                    }
                }

                if (fila.Tag != null)
                {
                    var lsPrecios = (List<decimal>)fila.Tag;
                    bool fila_Exenta = (bool)fila.Cells[4].FormattedValue;

                    //VIENE DE CREDITO FISCAL, LISTA DE PRECIOS NO TIENEN IVA
                    if (ckCFinal.Checked)
                    {
                        lsPrecios[0] = decimal.Round((lsPrecios[0] * (1 + ((!fila_Exenta) ? this.ptjIVA : 0))), 2);
                        lsPrecios[1] = decimal.Round((lsPrecios[1] * (1 + ((!fila_Exenta) ? this.ptjIVA : 0))), 2);
                        lsPrecios[2] = decimal.Round((lsPrecios[2] * (1 + ((!fila_Exenta) ? this.ptjIVA : 0))), 2);
                    }
                    else
                    {//VIENE DE CONSUMIDOR FINAL, LISTA DE PRECIOS TIENE IVA, EXCEPTO LAS EXENTAS
                        lsPrecios[0] = decimal.Round((lsPrecios[0] / (1 + ((!fila_Exenta) ? this.ptjIVA : 0))), 2);
                        lsPrecios[1] = decimal.Round((lsPrecios[1] / (1 + ((!fila_Exenta) ? this.ptjIVA : 0))), 2);
                        lsPrecios[2] = decimal.Round((lsPrecios[2] / (1 + ((!fila_Exenta) ? this.ptjIVA : 0))), 2);
                    }

                    fila.Tag = lsPrecios;
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los cambios realizados serán descartados. ¿Desea salir?", "ContaClic", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            ActualizarTotales();

            int no_factura = 0;

            int no_validas = (from DataGridViewRow c in dgMovs.Rows
                              where (c.Cells[0].EditedFormattedValue.ToString() == "" ||
                              c.Cells[1].EditedFormattedValue.ToString() == "" )
                              && c.IsNewRow == false
                              select c).Count();
            if (no_validas > 0 || dgMovs.Rows.Count <= 1)
                MessageBox.Show("Por favor, verifique las filas agregadas.", "SysLab",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!int.TryParse(txtFactura.Text, out no_factura))
                MessageBox.Show("Por favor, verifique el número de factura.", "SysLab",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtPacienteID.Text == "- Ninguno -")
                MessageBox.Show("Por favor, seleccione un paciente.", "SysLab",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtDoctorID.Text == "- Ninguno -")
                MessageBox.Show("Por favor, seleccione un doctor.", "SysLab",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            { //GENERANDO DETALLE 
                List<SOLICITUD_DETALLE> Detalle = new List<SOLICITUD_DETALLE>();
                foreach (DataGridViewRow item in dgMovs.Rows)
                {
                    if (!item.IsNewRow)
                    {
                        SOLICITUD_DETALLE reg = new SOLICITUD_DETALLE();

                        reg.ID_ANALISIS = long.Parse(item.Cells[0].Value.ToString());
                        reg.PRECIO = decimal.Parse(item.Cells[2].FormattedValue.ToString());
                        reg.OBSERVACIONES = item.Cells[3].FormattedValue.ToString();
                        reg.EXENTO = (bool)item.Cells[4].FormattedValue;

                        Detalle.Add(reg);
                    }
                }

                if (!this._EDITANDO)
                {//AGREGANDO 
                    var ps = new CTRL.Persistencia();
                    ps.IniciarTransaccion();

                    if (CTRL.Examenes.Solicitudes.AgregarSolicitud(ps.DB, long.Parse(txtPacienteID.Text), long.Parse(txtDoctorID.Text),
                        dtpFecha.Value,dtpRequerido.Value, int.Parse(txtFactura.Text), txtNombre.Text.Trim(), txtGiro.Text.Trim(),
                        txtNIT.Text.Trim(), txtNRC.Text.Trim(), ckRetencion.Checked, ckCFiscal.Checked, this.ptjIVA, this.ptjReten,
                        this.gravado, this.iva,this.subtotal, this.exento, this.retencion, this.total, Detalle)
                        )
                    {
                        ps.FinalizarTransaccion();
                        MessageBox.Show("La solicitud fue agregada satisfactoriamente.", "SysLab", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Dispose();
                    }
                    else
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("El registro no pudo ser agregado satisfactoriamente, "
                        + "por favor verifique que la información sea correcta.", "SysLab",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {//EDITANDO 
                    var ps = new CTRL.Persistencia();
                    ps.IniciarTransaccion();

                    if (CTRL.Examenes.Solicitudes.EditarSolicitud(ps.DB, this._ID_SOLICITUD, long.Parse(txtPacienteID.Text), 
                        long.Parse(txtDoctorID.Text), dtpFecha.Value, dtpRequerido.Value, int.Parse(txtFactura.Text),
                        txtNombre.Text.Trim(), txtGiro.Text.Trim(), txtNIT.Text.Trim(), txtNRC.Text.Trim(), ckRetencion.Checked,
                        ckCFiscal.Checked, this.ptjIVA, this.ptjReten, this.gravado, this.iva, this.subtotal, this.exento, 
                        this.retencion, this.total, Detalle)
                        )
                    {
                        ps.FinalizarTransaccion();
                        MessageBox.Show("El registro fue procesado satisfactoriamente.", "SysLab", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Dispose();
                    }
                    else
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("El registro no pudo ser procesado satisfactoriamente, "
                        + "por favor verifique que la información sea correcta.", "SysLab",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void nudReten_ValueChanged_1(object sender, EventArgs e)
        {
            this.ptjIVA = decimal.Round(nudIVA.Value / 100, 2);
            this.ptjReten = decimal.Round(nudReten.Value / 100, 2);

            ActualizarTotales();
        }

        private void ckRetencion_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarTotales();
        }
    }
}
