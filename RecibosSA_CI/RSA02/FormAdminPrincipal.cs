using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSA02.Model;
using RSA02.Clases;

namespace RSA02
{
    public partial class frmAdminPrincipal : Form
    {
        public frmAdminPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmContrasena c = new FrmContrasena();
            c.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.cerrarSesion(this);
        }

        private void frmAdminPrincipal_Load(object sender, EventArgs e)
        {
            lblusuario.Text = Global.usuariologueado.ToString();
            lbltipousuario.Text = Global.tipousuario.ToString();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario nu = new frmNuevoUsuario();
            nu.ShowDialog();
        }

        private void tsmContrasenaUsuarios_Click(object sender, EventArgs e)
        {
            frmAdminContrasena ac = new frmAdminContrasena();
            ac.ShowDialog();
        }
    }
}
