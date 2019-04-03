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
using RSA02.DO.DATA;


namespace RSA02
{
    public partial class frmAdminContrasena : Form
    {
        #region Metodos Privados

        private void cambiarContrasenaUsuarios()
        {
            if (cbxUsuarios.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("No se ha seleccionado ningun usuario, favor de seleccionar un usuario de la lista");
                cbxUsuarios.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtConstrasena.Text))
            {                
                MessageBox.Show("La contraseña no puede ser un dato vacio, favor de colocar una contraseña Valida");
                txtConstrasena.Focus();
            }
            else
            {
                Mensaje<Login> objrespuesta = new Mensaje<Login>();
                Login objtransaccion = new Login();
                REC01_USUARIO objusuario = new REC01_USUARIO();

                objusuario.USUARIO = cbxUsuarios.SelectedValue.ToString();
                objusuario.PASSWORD = txtConstrasena.Text;

                objrespuesta = objtransaccion.modificarContrasena(objusuario);

                MessageBox.Show(objrespuesta.mensaje);
            }
        }

        private void cargarUsuarios()
        {
            Mensaje<List<REC01_USUARIO>> objrespuesta = new Mensaje<List<REC01_USUARIO>>();            
            Login objtransaccion = new Login();

            objrespuesta = objtransaccion.listarUsuarios();
                        
            cbxUsuarios.DisplayMember = "usuario";
            cbxUsuarios.ValueMember = "usuario";
            cbxUsuarios.DataSource = objrespuesta.data;

            if (cbxUsuarios.Items.Count > 0)
            {
                cbxUsuarios.SelectedIndex = -1;
            }

            cbxUsuarios.AutoCompleteCustomSource = objtransaccion.AutocompletarUsuarios();
            cbxUsuarios.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxUsuarios.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        #endregion

        public frmAdminContrasena()
        {
            InitializeComponent();
        }

        private void frmAdminContrasena_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            cambiarContrasenaUsuarios();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    cambiarContrasenaUsuarios();
                }
            }
        }

    }
}
