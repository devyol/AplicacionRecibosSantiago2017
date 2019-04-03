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
    public partial class frmNuevoUsuario : Form
    {

        #region Metodos Privados

        public void cargarTiposUsuarios()
        {
            Mensaje<List<REC01_TIPO_USUARIO>> lista = new Mensaje<List<REC01_TIPO_USUARIO>>();
            Login obj = new Login();
            lista = obj.tiposUsuarios();

            if (lista.codigo != 0)
            {
                MessageBox.Show(lista.mensaje);
                this.Close();
            }
            else
            {                
                cbxtipousuario.DisplayMember = "descripcion";
                cbxtipousuario.ValueMember = "tipo_usuario";
                cbxtipousuario.DataSource = lista.data;
                if (cbxtipousuario.Items.Count > 0)
                {
                    cbxtipousuario.SelectedIndex = -1;
                }
            }



        }

        private void guardarUsuario()
        {
            if (string.IsNullOrWhiteSpace(txtusuario.Text))
            {
                MessageBox.Show("El campo de Usuario esta Vacio, favor de colocar un Usuario Valido");
                txtusuario.Focus();
            }
            else if (cbxtipousuario.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor de Seleccionar un Tipo de Usuario");
                cbxtipousuario.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("El campo de Nombre esta Vacio, favor de colocar un Nombre Valido");
                txtnombre.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtcontrasena.Text))
            {
                MessageBox.Show("El campo de la Contraseña esta Vacio, favor de colocar una Contraseña Valida");
                txtcontrasena.Focus();
            }
            else
            {
                REC01_USUARIO usNuevo = new REC01_USUARIO();
                Mensaje<Login> resul = new Mensaje<Login>();
                Login transaccion = new Login();

                usNuevo.USUARIO = txtusuario.Text.ToUpper();
                usNuevo.TIPO_USUARIO = Convert.ToDecimal(cbxtipousuario.SelectedValue);
                usNuevo.NOMBRE = txtnombre.Text;
                usNuevo.PASSWORD = txtcontrasena.Text;
                usNuevo.USUARIO_CREACION = Global.usuariologueado;
                usNuevo.FECHA_CREACION = DateTime.Now;

                resul = transaccion.registrarUsuario(usNuevo);

                MessageBox.Show(resul.mensaje);
            }
        }

        #endregion

        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {
            cargarTiposUsuarios();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            guardarUsuario();
        }

    }
}
