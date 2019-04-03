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
    public partial class frmMantCorrelativo : Form
    {

        #region Metodos Privados

        
        private void obtenerCorrelativos()
        {
            REC01_CORRELATIVO_RECIBO objcorrelativo = new REC01_CORRELATIVO_RECIBO();
            Recibo objrecibo = new Recibo();
            Mensaje<REC01_CORRELATIVO_RECIBO> objresp = objrecibo.obtenerCorrelativoFisico();

            txtCorrelativoActual.Text = objresp.data.CORRELATIVO_ACTUAL.ToString();
            txtCorrelativoFinal.Text = objresp.data.CORRELATIVO_FINAL.ToString();
            txtSerie.Text = objresp.data.SERIE;            
        }

        private void guardarCorrelativos()
        {
            if (string.IsNullOrWhiteSpace(txtCorrelativoActual.Text.ToString()))
            {
                MessageBox.Show("El Campo de Correlativo Inicial se encuentra vacio o contiene un espacio, favor de colocar un dato en el campo");
                txtCorrelativoActual.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtCorrelativoFinal.Text.ToString()))
            {
                MessageBox.Show("El Campo de Correlativo Final se encuentra vacio o contiene un espacio, favor de colocar un dato en el campo");
                txtCorrelativoFinal.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtSerie.Text.ToString()))
            {
                MessageBox.Show("El Campo de Serie se encuentra vacio o contiene un espacio, favor de colocar un dato en el campo");
                txtSerie.Focus();                
            }
            else if (Convert.ToDecimal(txtCorrelativoActual.Text) > Convert.ToDecimal(txtCorrelativoFinal.Text))
	        {
                MessageBox.Show("El Valor del Correlativo Inicial no puede ser Mayor al Valor del Correlativo Final");
                txtCorrelativoActual.Focus();		 
	        }
            else
            {
                REC01_CORRELATIVO_RECIBO objcorrelativo = new REC01_CORRELATIVO_RECIBO();
                objcorrelativo.CORRELATIVO_ACTUAL = Convert.ToDecimal(txtCorrelativoActual.Text);
                objcorrelativo.CORRELATIVO_FINAL = Convert.ToDecimal(txtCorrelativoFinal.Text);
                objcorrelativo.SERIE = txtSerie.Text;
                Recibo objrecibo = new Recibo();
                Mensaje<Recibo> objrespuesta = objrecibo.guardarCorrelativoFisico(objcorrelativo);
                MessageBox.Show(objrespuesta.mensaje);
                frmReciboEvento fp = new frmReciboEvento();
                this.Hide();
                fp.ShowDialog();
                this.Close();
            }
        }

        #endregion

        public frmMantCorrelativo()
        {
            InitializeComponent();
        }

        private void frmMantCorrelativo_Load(object sender, EventArgs e)
        {            
            obtenerCorrelativos();
        }

        private void txtCorrelativoActual_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.NumeroDecimal(e, txtCorrelativoActual);
        }

        private void txtCorrelativoFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.NumeroDecimal(e, txtCorrelativoFinal);
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            guardarCorrelativos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmReciboEvento fp = new frmReciboEvento();
            this.Hide();
            fp.ShowDialog();
            this.Close();
        }
    }
}
