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
    public partial class frmReporteGlobal : Form
    {

        public void cargarEventos()
        {
            Evento lis = new Evento();
            Mensaje<List<REC01_EVENTO>> llenar = lis.listarTodosEventos();

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

        public frmReporteGlobal()
        {
            InitializeComponent();
        }

        private void btnreportedetalle_Click(object sender, EventArgs e)
        {
            frmVistaPreviaGlobalDetalle fvpe = new frmVistaPreviaGlobalDetalle();
            fvpe.idEvento = Convert.ToDecimal(cbxevento.SelectedValue);
            fvpe.fechainicial = dtpfechainicial.Value.ToShortDateString();
            fvpe.fechafinal = dtpfechafinal.Value.ToShortDateString();
            fvpe.ShowDialog();
        }

        private void btnreportepais_Click(object sender, EventArgs e)
        {
            frmVistaPreviaGlobalPais fvpe = new frmVistaPreviaGlobalPais();
            fvpe.idEvento = Convert.ToDecimal(cbxevento.SelectedValue);
            fvpe.fechainicial = dtpfechainicial.Value.ToShortDateString();
            fvpe.fechafinal = dtpfechafinal.Value.ToShortDateString();
            fvpe.ShowDialog();

        }

        private void btnconcepto_Click(object sender, EventArgs e)
        {
            frmVistaPreviaGlobalConcepto fvpe = new frmVistaPreviaGlobalConcepto();
            fvpe.idEvento = Convert.ToDecimal(cbxevento.SelectedValue);
            fvpe.fechainicial = dtpfechainicial.Value.ToShortDateString();
            fvpe.fechafinal = dtpfechafinal.Value.ToShortDateString();
            fvpe.ShowDialog();
        }

        private void btnconceptoalimentacion_Click(object sender, EventArgs e)
        {
            frmVistaPreviaGlobalAlimentacion fvpe = new frmVistaPreviaGlobalAlimentacion();
            fvpe.idEvento = Convert.ToDecimal(cbxevento.SelectedValue);
            fvpe.fechainicial = dtpfechainicial.Value.ToShortDateString();
            fvpe.fechafinal = dtpfechafinal.Value.ToShortDateString();
            fvpe.ShowDialog();
        }

        private void btnanulados_Click(object sender, EventArgs e)
        {
            frmVistaPreviaGlobalAnulados fvpe = new frmVistaPreviaGlobalAnulados();
            fvpe.idEvento = Convert.ToDecimal(cbxevento.SelectedValue);
            fvpe.fechainicial = dtpfechainicial.Value.ToShortDateString();
            fvpe.fechafinal = dtpfechafinal.Value.ToShortDateString();
            fvpe.ShowDialog();
        }

        private void frmReporteGlobal_Load(object sender, EventArgs e)
        {
            cargarEventos();
        }
    }
}
