using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.EMPRESAS
{
    public partial class frmAgregarSector : Form
    {
        long _ID_EMPRESA, _ID_EDITAR;
        bool _EDITANDO;

        public frmAgregarSector(long ID_EMPRESA)
        {
            InitializeComponent();
            this._ID_EMPRESA = ID_EMPRESA;
        }

        public frmAgregarSector(long ID, long ID_EMPRESA)
        {
            InitializeComponent();

            this._ID_EDITAR = ID;
            this._EDITANDO = true;

            var ps = new CTRL.Persistencia();
            ps.AbrirConexion();

            var reg = ps.SelPorLlave<EMPRESA_SECTOR>(ID.ToString());

            this.Text = this.lblTitulo.Text = "Editando Sector";

            txtNombres.Text = reg.NOMBRE;
            txtDesc.Text = reg.DESCRIPCION;

            ps.CerrarConexion();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text.Trim() == string.Empty)
                MessageBox.Show("El nombre del sector no es válido.", "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                var ps = new CTRL.Persistencia();
                ps.IniciarTransaccion();

                if (!this._EDITANDO)
                {
                    if (CTRL.Administracion.Empresas.AgregarSector(ps.DB, this._ID_EMPRESA, txtNombres.Text.Trim(), txtDesc.Text.Trim()))
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
                    if (CTRL.Administracion.Empresas.EditarSector(ps.DB, this._ID_EDITAR, txtNombres.Text.Trim(), txtDesc.Text.Trim()))
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

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Los cambios realizados serán descartados. ¿Desea salir?", "SysLab", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                this.Dispose();
        }
    }
}
