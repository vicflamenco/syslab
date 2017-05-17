using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SYSLAB.VISTA.USUARIOS
{
    public partial class frmAdminUsuarios : Form
    {
        public frmAdminUsuarios()
        {
            InitializeComponent();
        }

        private void frmAdminUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsSysLab.USUARIO' table. You can move, or remove it, as needed.
            this.uSUARIOTableAdapter.Fill(this.dsSysLab.USUARIO);
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            var frm = new frmAgregarUsuario();
            if (frm.ShowDialog() == DialogResult.OK)
                frmAdminUsuarios_Load(sender, e);
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count == 1)
            {
                var fila = (dsSysLab.USUARIORow)((DataRowView)dgRegistros.CurrentRow.DataBoundItem).Row;

                var frm = new frmAgregarUsuario(fila.ID_USUARIO);
                if (frm.ShowDialog() == DialogResult.OK)
                    frmAdminUsuarios_Load(sender, e);
            }
            else
                MessageBox.Show("Debe seleccionar exactamente un usuario a editar.",
                    "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (dgRegistros.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Los registros seleccionados serán eliminados. ¿Desesa continuar?", "SysLab", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    var ps = new CTRL.Persistencia();
                    ps.IniciarTransaccion();

                    int errores = 0;

                    foreach (DataGridViewRow item in dgRegistros.SelectedRows)
                    {
                        var fila = (dsSysLab.USUARIORow)((DataRowView)item.DataBoundItem).Row;

                        if (!CTRL.Administracion.Usuarios.EliminarUsuario(ps.DB, fila.ID_USUARIO))
                            errores++;
                    }

                    if (errores > 0)
                    {
                        ps.RevertirTransaccion();
                        MessageBox.Show("Los registros no pudieron ser eliminados porque " 
                        + "tienen operaciones relacionadas.", "SysLab", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        ps.FinalizarTransaccion();

                        MessageBox.Show("Los registros fueron eliminados satisfactoriamente.",
                            "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        frmAdminUsuarios_Load(sender, e);
                    }
                }
            }
            else
                MessageBox.Show("Debe seleccionar al menos un usuario a eliminar.",
                    "SysLab", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
