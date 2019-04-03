using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSA02.Clases;
using RSA02.Model;
using System.Diagnostics;

namespace RSA02
{
    public partial class frmPrincipal : Form
    {
        string pathusuario = @"C:\Manual de Usuario.pdf";
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Login lo = new Login();
            lo.cerrarSesion(this);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmContrasena c = new FrmContrasena();
            c.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblusuario.Text = "Bienvenid@ "+ Global.usuariologueado.ToString();
            lbltipousuario.Text = "Rol " + Global.tipousuario.ToString();
        }

        private void tsmReciboEvento_Click(object sender, EventArgs e)
        {
            frmEvento fp = new frmEvento();
            this.Hide();
            fp.ShowDialog();
            this.Close();

        }

        private void tsmEvento_Click(object sender, EventArgs e)
        {
            frmMantEvento fme = new frmMantEvento();
            fme.ShowDialog();
        }

        private void tsmBanco_Click(object sender, EventArgs e)
        {
            frmMantBanco fmb = new frmMantBanco();
            fmb.ShowDialog();
        }

        private void tsmPais_Click(object sender, EventArgs e)
        {
            frmMantPais fmp = new frmMantPais();
            fmp.ShowDialog();
        }

        private void tsmConcepto_Click(object sender, EventArgs e)
        {
            frmMantConcepto fmc = new frmMantConcepto();
            fmc.ShowDialog();
        }

        private void tsmreportesGlobales_Click(object sender, EventArgs e)
        {
            frmReporteGlobal fg = new frmReporteGlobal();
            fg.ShowDialog();
        }

        private void tsmmanual_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(pathusuario);
            }
            catch (Exception)
            {
                MessageBox.Show("Verifique que exista en la ruta C:\\ el archivo con nombre \"Manual de Usuario.pdf\"");
            }
            
        }

        private void tsmacerca_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Iglesia de Jesucristo Palabra Miel \nSistema de Recibos de Retiros\nVersion 1.0 \n2017");
        }




    }
}
