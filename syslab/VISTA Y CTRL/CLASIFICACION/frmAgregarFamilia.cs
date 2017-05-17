using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.CLASIFICACION
{
    public partial class frmAgregarFamilia : Form
    {
        long _ID__CATEG, _ID_EDITAR;
        bool _EDITANDO;

        public frmAgregarFamilia(long ID_CATEG)
        {
            InitializeComponent();
            this._ID__CATEG = ID_CATEG;
        }

        public frmAgregarFamilia(long ID, long ID_CATEG)
        {
            InitializeComponent();

            this._ID_EDITAR = ID;
            this._EDITANDO = true;

            var ps = new CTRL.Persistencia();
            ps.AbrirConexion();

            var reg = ps.SelPorLlave<FAMILIA>(ID.ToString());

            this.Text = this.lblTitulo.Text = "Editando Familia";

            txtNombres.Text = reg.NOMBRE;
            txtDesc.Text = reg.DESCRIPCION;

            ps.CerrarConexion();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los cambios realizados serán descartados. ¿Desea salir?", "SysLab", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text.Trim() == string.Empty)
                MessageBox.Show("El nombre de la familia no es válido.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var ps = new CTRL.Persistencia();
                ps.IniciarTransaccion();

                if (!this._EDITANDO)
                {
                    if (CTRL.Administracion.Clasificaciones.AgregarFamilia(ps.DB, this._ID__CATEG, txtNombres.Text.Trim(), txtDesc.Text.Trim()))
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
                        MessageBox.Show("Ha ocurrido un error, la operación fue cancelada.", "SysLab", MessageBoxButtons.OK, 
                            MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    if (CTRL.Administracion.Clasificaciones.EditarFamilia(ps.DB, this._ID_EDITAR, txtNombres.Text.Trim(), txtDesc.Text.Trim()))
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
                        MessageBox.Show("Ha ocurrido un error, la operación fue cancelada.", "SysLab", MessageBoxButtons.OK, 
                            MessageBoxIcon.Exclamation);
                    }
                }

            }
        }
    }
}
