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
    public partial class frmEvento : Form
    {
        public void cargarEventosActivos()
        {
            Evento lis = new Evento();
            Mensaje<List<REC01_EVENTO>> llenar = lis.listarEventosActivos();

            if (llenar.codigo != 0)
            {
                MessageBox.Show(llenar.mensaje);
            }
            else
            {                
                cbxevento.DisplayMember = "nombre";
                cbxevento.ValueMember = "evento";
                cbxevento.DataSource = llenar.data;
                if (cbxevento.Items.Count > 0)
                {
                    cbxevento.SelectedIndex = -1;
                }
            }
        }

        public frmEvento()
        {
            InitializeComponent();
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            frmPrincipal fp = new frmPrincipal();
            this.Hide();
            fp.ShowDialog();
            this.Close();
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            if (cbxevento.SelectedValue != null)
            {
                Global.eventoActivo = Convert.ToDecimal(cbxevento.SelectedValue);
                Global.nombreeventoActivo = cbxevento.Text;

                frmReciboEvento fp = new frmReciboEvento();
                this.Hide();
                fp.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("No ha seleccionado un Evento para Iniciar la Gestion de Recibos");
            }

        }

        private void frmEvento_Load(object sender, EventArgs e)
        {
            cargarEventosActivos();
        }
    }
}
