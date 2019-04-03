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
    public partial class frmAnulacion : Form
    {
        public decimal recibo { get; set; }
        public string usuario { get; set; }

        private void obtenerRecibo()
        {
            Recibo obj = new Recibo();
            REC01_RECIBO rec = new REC01_RECIBO();
            rec.RECIBO = Convert.ToDecimal(recibo);
            rec.USUARIO_CREACION = usuario;
            Mensaje<REC01_RECIBO> resp = obj.obtenerRecibo(rec);

            txtrecibo.Text = resp.data.RECIBO.ToString();
            txtusuario.Text = resp.data.USUARIO_CREACION.ToString();
            txtnombre.Text = resp.data.NOMBRE.ToString();
            txttotal.Text = resp.data.TOTAL.ToString();

            if (resp.data.RECIBO_FISICO != null || resp.data.SERIE_RECIBO != null)
            {
                txtnumerorecibo.Text = resp.data.RECIBO_FISICO.ToString();
                txtserie.Text = resp.data.SERIE_RECIBO.ToString();
                txtnumerorecibo.Enabled = false;
                txtserie.Enabled = false;
            }

        }

        private void Anular()
        {
            if (string.IsNullOrWhiteSpace(txtmotivo.Text))
            {
                MessageBox.Show("Favor de colocar una descripcion del Motivo por el cual se esta Anulando el Recibo.");
                txtmotivo.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtnumerorecibo.Text))
            {
                MessageBox.Show("Favor de colocar el numero del Recibo Fisico que sera Anulando.");
                txtnumerorecibo.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtserie.Text))
            {
                MessageBox.Show("Favor de colocar la Serie del Recibo Fisico que sera Anulando.");
                txtserie.Focus();
            }
            else
            {
                REC01_ANULACION objAnulacion = new REC01_ANULACION();
                objAnulacion.RECIBO = Convert.ToDecimal(txtrecibo.Text);
                objAnulacion.USUARIO_CREACION = txtusuario.Text;
                objAnulacion.MOTIVO = txtmotivo.Text;
                objAnulacion.RECIBO_FISICO = Convert.ToDecimal(txtnumerorecibo.Text);
                objAnulacion.SERIE = txtserie.Text;
                Recibo objRecibo = new Recibo();
                Mensaje<Recibo> resp = objRecibo.AnularRecibo(objAnulacion);
                MessageBox.Show(resp.mensaje);
                frmReciboEvento fre = new frmReciboEvento();
                this.Hide();
                fre.ShowDialog();
                this.Close();
            }
        }

        public frmAnulacion()
        {
            InitializeComponent();
        }

        private void frmAnulacion_Load(object sender, EventArgs e)
        {
            obtenerRecibo();
        }

        private void btnanular_Click(object sender, EventArgs e)
        {
            Anular();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            frmReciboEvento fre = new frmReciboEvento();
            this.Hide();
            fre.ShowDialog();
            this.Close();
        }

        private void txtnumerorecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.NumeroDecimal(e, txtnumerorecibo);
        }
    }
}
