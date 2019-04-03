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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo Privado para Autenticar
        /// </summary>
        private void Autentica()
        {            
            Login obj = new Login();

            if (obj.Autenticar(txtUsuario.Text,txtContrasena.Text))
            {
                if (Global.tipousuarioid == "1")
                {
                    this.Hide();
                    frmAdminPrincipal f = new frmAdminPrincipal();
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.Hide();
                    frmPrincipal f = new frmPrincipal();
                    f.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Usuario o Password Incorrectos, Intente de Nuevo");
                txtContrasena.Text = "";
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Autentica();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Autentica();
        }
    }
}
