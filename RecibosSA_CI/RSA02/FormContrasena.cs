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
using RSA02.DO.DATA;

namespace RSA02
{
    public partial class FrmContrasena : Form
    {
        public FrmContrasena()
        {
            InitializeComponent();
        }

        private void obtenerDatos()
        {
            Login lo = new Login();
            REC01_USUARIO us = new REC01_USUARIO();

            us = lo.obtenerUsuario(Global.usuariologueado);

            txtUsuario.Text = us.USUARIO.ToString();
            txtNombre.Text = us.NOMBRE.ToString();

        }

        private void modificarContrasena(string nuevopassword)
        {
            REC01_USUARIO us = new REC01_USUARIO();
            Mensaje<Login> cambio = new Mensaje<Login>();
            Login obj = new Login();

            us.USUARIO = Global.usuariologueado;
            us.PASSWORD = nuevopassword;

            cambio = obj.modificarContrasena(us);
            
            MessageBox.Show(cambio.mensaje);

        }

        private void FrmContrasena_Load(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtConstrasena.Text.Trim()==null || txtConstrasena.Text.Trim()=="")
            {
                MessageBox.Show("La contraseña no puede ser nula o espacios en blanco, favor de colocar otra contraseña");
            }
            else
            {
                modificarContrasena(txtConstrasena.Text);
            }            
        }

        private void txtConstrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtConstrasena.Text.Trim() == null || txtConstrasena.Text.Trim() == "")
                {
                    MessageBox.Show("La contraseña no puede ser nula o espacios en blanco, favor de colocar una contraseña valida");
                }
                else
                {
                    modificarContrasena(txtConstrasena.Text);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
