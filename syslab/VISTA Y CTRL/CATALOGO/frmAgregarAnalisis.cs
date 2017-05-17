using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.CATALOGO
{
    public partial class frmAgregarAnalisis : Form
    {
        long _ID_EDITAR;
        bool _EDITANDO;
        string[] TipoDato = new string[] { "Número - Rango", "Ref. - Resultado", "Texto - Ref." };
        
        

        public frmAgregarAnalisis()
        {
            InitializeComponent();

            this.fAMILIATableAdapter.Fill(this.dsSysLab.FAMILIA);
            this.cATEGORIATableAdapter.Fill(this.dsSysLab.CATEGORIA);
        }

        public frmAgregarAnalisis(long ID)
        {
            InitializeComponent();

            this.fAMILIATableAdapter.Fill(this.dsSysLab.FAMILIA);
            this.cATEGORIATableAdapter.Fill(this.dsSysLab.CATEGORIA);

            this._ID_EDITAR = ID;
            this._EDITANDO = true;

            var ps = new CTRL.Persistencia();
            ps.AbrirConexion();

            var reg = ps.SelPorLlave<ANALISI>(ID.ToString());

            this.Text = this.lblTitulo.Text = "Editando Tipo de Análisis";

            cmbCateg.SelectedValue = reg.FAMILIA.ID_CATEGORIA;
            cmbFam.SelectedValue = reg.ID_FAMILIA;

            txtNombre.Text = reg.NOMBRE;
            txtDesc.Text = reg.DESCRIPCION;

            nudP1.Value = reg.PRECIO1;
            nudP2.Value = reg.PRECIO2;
            nudP3.Value = reg.PRECIO3;

            foreach (ANALISIS_DATO item in reg.ANALISIS_DATOs)
            {
                var fila = dgCampos.Rows[
                    dgCampos.Rows.Add(new object[] { item.CAMPO, null, item.UMEDIDA, item.REF, item.RMIN, item.RMAX })
                    ];

                var cmb = ((DataGridViewComboBoxCell)fila.Cells[1]);

                cmb.DataSource = this.TipoDato;
                cmb.Value = this.TipoDato[item.TIPO];
            }

            ps.CerrarConexion();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los cambios realizados serán descartados. ¿Desea salir?", "SysLab", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            this.Validate(true);

            if (txtNombre.Text.Trim() == string.Empty)
                MessageBox.Show("El nombre no es válido.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (cmbFam.SelectedIndex == -1)
                MessageBox.Show("Por favor, seleccione una familia existente.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                List<ANALISIS_DATO> Datos = new List<ANALISIS_DATO>();

                foreach (DataGridViewRow item in dgCampos.Rows)
                {
                    if (item.IsNewRow || item.Index < 0)
                        continue;

                    Datos.Add(
                        new ANALISIS_DATO
                        {
                            CAMPO = item.Cells[0].EditedFormattedValue.ToString(),
                            TIPO = Array.IndexOf(TipoDato, item.Cells[1].EditedFormattedValue.ToString()),
                            UMEDIDA = item.Cells[2].EditedFormattedValue.ToString(),
                            REF = item.Cells[3].EditedFormattedValue.ToString(),
                            RMAX = decimal.Parse(item.Cells[4].EditedFormattedValue.ToString()),
                            RMIN = decimal.Parse(item.Cells[5].EditedFormattedValue.ToString())
                        });
                }


                var ps = new CTRL.Persistencia();
                ps.IniciarTransaccion();

                if (!this._EDITANDO)
                {
                    if (CTRL.Administracion.CatalogoAnalisis.AgregarAnalisis(ps.DB, (long)cmbFam.SelectedValue, txtNombre.Text.Trim(), txtDesc.Text.Trim(),nudP1.Value, nudP2.Value, nudP3.Value,Datos))
                    {
                        ps.FinalizarTransaccion();
                        MessageBox.Show("El registro fue procesado satisfactoriamente.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Dispose();
                    }
                    else
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("Ha ocurrido un error, la operación fue cancelada.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    if (CTRL.Administracion.CatalogoAnalisis.EditarAnalisis(ps.DB, this._ID_EDITAR, (long)cmbFam.SelectedValue, txtNombre.Text.Trim(), txtDesc.Text.Trim(), nudP1.Value, nudP2.Value, nudP3.Value, Datos))
                    {
                        ps.FinalizarTransaccion();
                        MessageBox.Show("El registro fue procesado satisfactoriamente.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Dispose();
                    }
                    else
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("Ha ocurrido un error, la operación fue cancelada.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void dgCampos_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            var cmb = ((DataGridViewComboBoxCell)e.Row.Cells[1]);

            cmb.DataSource = this.TipoDato;
            cmb.Value = TipoDato[0];
        }

        private void dgCampos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                dgCampos.BeginEdit(false);
                if (this.dgCampos.EditingControl != null
                    && this.dgCampos.EditingControl is ComboBox)
                {
                    ComboBox cmb = this.dgCampos.EditingControl as ComboBox;
                    cmb.DroppedDown = true;
                }
            }
        }
    }
}
