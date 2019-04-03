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
    public partial class frmMantPais : Form
    {

        #region Metodos Publicos

        private void limpiar()
        {
            txtnombre.Text = "";
            if (cbxestado.Items.Count > 0)
            {
                cbxestado.SelectedIndex = -1;
            }
        }

        private void cargarGridPaises()
        {
            Pais list = new Pais();
            Mensaje<List<REC01_PAIS>> resp = list.listarTodosPaises();

            if (resp.codigo != 0)
            {
                MessageBox.Show(resp.mensaje);
            }
            else
            {
                bindingSource1.DataSource = resp.data;
            }
        }

        private void obtenerUnPais(REC01_PAIS pa)
        {
            Pais obj = new Pais();
            Mensaje<REC01_PAIS> resp = obj.obtenerPais(pa);

            descripcionEstado();
            txtnombre.Text = resp.data.DESCRIPCION;
            cbxestado.SelectedValue = resp.data.ESTADO_REGISTRO.ToString();
        }

        private void descripcionEstado()
        {
            Pais lis = new Pais();
            Mensaje<List<REC01_ESTADO>> resp = lis.listaDescripcionEstadoPais();

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

        private void actualizarRegistroPais()
        {
            if (string.IsNullOrWhiteSpace(txtnombre.Text)/* txtnombre.Text.Trim() == "" || txtnombre.Text.Trim() == null*/)
            {
                MessageBox.Show("El dato del Nombre del Pais esta vacio o solo contiene espacios, favor de colocar un nombre Valido");
                txtnombre.Focus();

            }
            else if (cbxestado.SelectedValue == null)
            {
                MessageBox.Show("El ESTADO DEL PAIS que requiere actualizar esta vacio, favor de seleccionar un estado para modificar");
            }
            else
            {
                REC01_PAIS obj = new REC01_PAIS();
                obj.PAIS = dtglistado.CurrentRow.Cells[0].Value.ToString();
                obj.DESCRIPCION = txtnombre.Text.ToString();
                obj.ESTADO_REGISTRO = cbxestado.SelectedValue.ToString();
                Pais reg = new Pais();
                Mensaje<Pais> resp = reg.ActualizarRegistroPais(obj);
                MessageBox.Show(resp.mensaje);
            }
        }

        #endregion

        public frmMantPais()
        {
            InitializeComponent();
        }

        private void frmMantPais_Load(object sender, EventArgs e)
        {
            limpiar();
            cargarGridPaises();
            descripcionEstado();
            btnmodificar.Enabled = false;
        }

        private void dtglistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1)
            {
                REC01_PAIS obj = new REC01_PAIS();
                obj.PAIS = dtglistado.CurrentRow.Cells[0].Value.ToString();
                obtenerUnPais(obj);

                txtnombre.Text = dtglistado.CurrentRow.Cells[1].Value.ToString();
                btnmodificar.Enabled = true;
            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            actualizarRegistroPais();
            cargarGridPaises();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {            
            limpiar();
            txtnombre.Focus();
        }


    }
}
