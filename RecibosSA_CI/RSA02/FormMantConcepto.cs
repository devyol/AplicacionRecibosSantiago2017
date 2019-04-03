using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSA02.DO.DATA;
using RSA02.Clases;
using RSA02.Model;

namespace RSA02
{
    public partial class frmMantConcepto : Form
    {

        private void limpiar()
        {
            txtconcepto.Text = "";
            txtprecio.Text = "";
            if (cbxestado.Items.Count > 0)
            {
                cbxestado.SelectedIndex = -1;
            }

        }

        private void cargarGridConcepto()
        {
            Concepto list = new Concepto();
            Mensaje<List<REC01_CONCEPTO>> resp = list.listarTodosConceptos();

            if (resp.codigo != 0)
            {
                MessageBox.Show(resp.mensaje);
            }
            else
            {
                bindingSource1.DataSource = resp.data;
            }
        }

        private void descripcionEstado()
        {
            Concepto lis = new Concepto();
            Mensaje<List<REC01_ESTADO>> resp = lis.listaDescripcionEstadoConcepto();

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

        private void obtenerUnConcepto(REC01_CONCEPTO co)
        {
            Concepto obj = new Concepto();
            Mensaje<REC01_CONCEPTO> resp = obj.obtenerConcepto(co);

            descripcionEstado();
            txtconcepto.Text = resp.data.DESCRIPCION;
            txtprecio.Text = resp.data.PRECIO.ToString();
            cbxestado.SelectedValue = resp.data.ESTADO_REGISTRO;
        }

        private void registrarConcepto()
        {
            if (string.IsNullOrWhiteSpace(txtconcepto.Text)/*txtconcepto.Text.Trim() == "" || txtconcepto.Text.Trim() == null*/)
            {
                MessageBox.Show("El dato del Nombre del Concepto esta vacio o solo contiene espacios, favor de colocar un nombre Valido");
                txtconcepto.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtprecio.Text))
            {
                MessageBox.Show("El dato del Precio del Concepto esta vacio, \n Si el concepto no tiene valor coloque un \"0\" \n de lo contrario coloque un Precio Valido");
                txtprecio.Focus();
            }
            else if (cbxestado.SelectedValue == null)
            {
                MessageBox.Show("El ESTADO DEL CONCEPTO que requiere registrar esta vacio, favor de seleccionar un estado para registrar");
                cbxestado.Focus();
            }
            else
            {
                REC01_CONCEPTO obj = new REC01_CONCEPTO();
                obj.DESCRIPCION = txtconcepto.Text.ToString();
                obj.PRECIO = Convert.ToDecimal(txtprecio.Text);
                obj.ESTADO_REGISTRO = cbxestado.SelectedValue.ToString();
                Concepto reg = new Concepto();
                Mensaje<Concepto> resp = reg.RegistrarConcepto(obj);
                MessageBox.Show(resp.mensaje);
                limpiar();
            }
        }

        private void actualizarRegistroEvento()
        {
            if (string.IsNullOrWhiteSpace(txtconcepto.Text)/*txtconcepto.Text.Trim() == "" || txtconcepto.Text.Trim() == null*/)
            {
                MessageBox.Show("El dato del Nombre del Concepto esta vacio o solo contiene espacios, favor de colocar un nombre Valido");
                txtconcepto.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtprecio.Text))
            {
                MessageBox.Show("El dato del Precio del Concepto esta vacio, \n Si el concepto no tiene valor coloque un \"0\" \n de lo contrario coloque un Precio Valido");
                txtprecio.Focus();
            }
            else if (cbxestado.SelectedValue == null)
            {
                MessageBox.Show("El ESTADO DEL CONCEPTO que requiere actualizar esta vacio, favor de seleccionar un estado para modificar");
                cbxestado.Focus();
            }
            else
            {
                REC01_CONCEPTO obj = new REC01_CONCEPTO();
                obj.CONCEPTO = Convert.ToDecimal(dtglistado.CurrentRow.Cells[0].Value);
                obj.DESCRIPCION = txtconcepto.Text.ToString();
                obj.PRECIO = Convert.ToDecimal(txtprecio.Text);
                obj.ESTADO_REGISTRO = cbxestado.SelectedValue.ToString();
                Concepto reg = new Concepto();
                Mensaje<Concepto> resp = reg.ActualizarRegistroConcepto(obj);
                MessageBox.Show(resp.mensaje);
            }
        }

        public frmMantConcepto()
        {
            InitializeComponent();
        }

        private void frmMantConcepto_Load(object sender, EventArgs e)
        {
            limpiar();
            cargarGridConcepto();
            descripcionEstado();
            btnmodificar.Enabled = false;
        }

        private void dtglistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                REC01_CONCEPTO obj = new REC01_CONCEPTO();
                obj.CONCEPTO = Convert.ToDecimal(dtglistado.CurrentRow.Cells[0].Value);
                obtenerUnConcepto(obj);
                btnagregar.Visible = false;
                btnmodificar.Enabled = true;
                btnlimpiar.Text = "Registrar Nuevo";
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            registrarConcepto();
            cargarGridConcepto();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            actualizarRegistroEvento();
            cargarGridConcepto();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            btnmodificar.Enabled = false;
            btnagregar.Visible = true;
            txtconcepto.Focus();
            btnlimpiar.Text = "Limpiar";
            limpiar();
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.NumeroDecimal(e, txtprecio);
        }


    }
}
