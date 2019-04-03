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
    public partial class frmMantBanco : Form
    {

        #region Metodos Privados

        private void limpiar()
        {
            txtnombre.Text = "";
            if (cbxestado.Items.Count > 0)
            {
                cbxestado.SelectedIndex = -1;
            }
        }

        private void cargarGridBancos()
        {
            Banco list = new Banco();
            Mensaje<List<REC01_BANCO>> resp = list.listarTodosBancos();

            if (resp.codigo != 0)
            {
                MessageBox.Show(resp.mensaje);
            }
            else
            {
                bindingSource1.DataSource = resp.data;
            }
        }

        private void obtenerUnBanco(REC01_BANCO ba)
        {
            Banco obj = new Banco();
            Mensaje<REC01_BANCO> resp = obj.obtenerBanco(ba);

            descripcionEstado();
            txtnombre.Text = resp.data.NOMBRE;
            cbxestado.SelectedValue = resp.data.ESTADO_REGISTRO.ToString();
        }

        private void descripcionEstado()
        {
            Banco lis = new Banco();
            Mensaje<List<REC01_ESTADO>> resp = lis.listaDescripcionEstadoBanco();

            if (resp.codigo != 0)
            {
                MessageBox.Show(resp.mensaje);
            }
            else
            {                
                cbxestado.DisplayMember = "descripcion";
                cbxestado.ValueMember = "estado";
                cbxestado.DataSource = resp.data;
                if (cbxestado.Items.Count > 0)
                {
                    cbxestado.SelectedIndex = -1;
                }
            }
        }

        private void registrarBanco()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text))
            {
                MessageBox.Show("El dato del Nombre del Banco esta vacio o solo contiene espacios, favor de colocar un nombre Valido");
                txtnombre.Focus();
            }
            else if (cbxestado.SelectedValue == null)
            {
                MessageBox.Show("El ESTADO DEL BANCO que requiere registrar esta vacio, favor de seleccionar un estado para registrar");
                cbxestado.Focus();
            }
            else
            {
                REC01_BANCO obj = new REC01_BANCO();                
                obj.NOMBRE = txtnombre.Text.ToString();
                obj.ESTADO_REGISTRO = cbxestado.SelectedValue.ToString();
                Banco reg = new Banco();
                Mensaje<Banco> resp = reg.RegistrarBanco(obj);
                MessageBox.Show(resp.mensaje);
                limpiar();
            }
        }

        private void actualizarRegistroBanco()
        {
            if (txtnombre.Text.Trim() == "" || txtnombre.Text.Trim() == null)
            {
                MessageBox.Show("El dato del Nombre del Banco esta vacio o solo contiene espacios, favor de colocar un nombre Valido");
            }
            else if (cbxestado.SelectedValue == null)
            {
                MessageBox.Show("El ESTADO DEL BANCO que requiere actualizar esta vacio, favor de seleccionar un estado para modificar");
            }
            else
            {
                REC01_BANCO obj = new REC01_BANCO();
                obj.BANCO = Convert.ToDecimal(dtglistado.CurrentRow.Cells[0].Value);
                obj.NOMBRE = txtnombre.Text.ToString();
                obj.ESTADO_REGISTRO = cbxestado.SelectedValue.ToString();
                Banco reg = new Banco();
                Mensaje<Banco> resp = reg.ActualizarRegistroBanco(obj);
                MessageBox.Show(resp.mensaje);
            }
        }

        #endregion
        public frmMantBanco()
        {
            InitializeComponent();
        }

        private void frmMantBanco_Load(object sender, EventArgs e)
        {
            limpiar();
            cargarGridBancos();
            descripcionEstado();
            btnmodificar.Enabled = false;

        }
        
        private void dtglistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                REC01_BANCO obj = new REC01_BANCO();
                obj.BANCO = Convert.ToDecimal(dtglistado.CurrentRow.Cells[0].Value);
                obtenerUnBanco(obj);
                
                btnagregar.Visible = false;
                btnmodificar.Enabled = true;
                btnlimpiar.Text = "Registrar Nuevo";
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {            
            registrarBanco();
            cargarGridBancos();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {            
            actualizarRegistroBanco();
            cargarGridBancos();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            btnmodificar.Enabled = false;
            btnagregar.Visible = true;
            txtnombre.Focus();
            btnlimpiar.Text = "Limpiar";
            limpiar();
        }


    }
}
