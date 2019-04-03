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
    public partial class frmReporteEvento : Form
    {
        

        public frmReporteEvento()
        {
            InitializeComponent();
        }

        private void frmReporteEvento_Load(object sender, EventArgs e)
        {
            
        }

        private void btnreportedetalle_Click(object sender, EventArgs e)
        {
            frmVistaPreviaEventoDetalle fvpe = new frmVistaPreviaEventoDetalle();
            fvpe.evento = Global.eventoActivo;
            fvpe.usuario = Global.usuariologueado;
            fvpe.fechainicial = dtpfechainicial.Value.ToShortDateString();
            fvpe.fechafinal = dtpfechafinal.Value.ToShortDateString();
            fvpe.ShowDialog();
        }

        private void btnconcepto_Click(object sender, EventArgs e)
        {
            frmVistaPreviaConceptoUsuario fvpcu = new frmVistaPreviaConceptoUsuario();
            fvpcu.evento = Global.eventoActivo;
            fvpcu.usuario = Global.usuariologueado;
            fvpcu.fechainicial = dtpfechainicial.Value.ToShortDateString();
            fvpcu.fechafinal = dtpfechafinal.Value.ToShortDateString();
            fvpcu.ShowDialog();
        }

    }
}
