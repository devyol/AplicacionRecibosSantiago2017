using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using RSA02.Model;
using RSA02.Clases;
using RSA02.DO.DATA;

namespace RSA02
{
    public partial class frmVistaPreviaConceptoUsuario : Form
    {
        public decimal evento { get; set; }
        public string usuario { get; set; }
        public string fechainicial { get; set; }
        public string fechafinal { get; set; }

        public frmVistaPreviaConceptoUsuario()
        {
            InitializeComponent();
        }

        private void frmVistaPreviaConceptoUsuario_Load(object sender, EventArgs e)
        {

            Reporteria datos = new Reporteria() { idevento = this.evento, idusuario = this.usuario, fecha_inicial = this.fechainicial, fecha_final = this.fechafinal };
            Mensaje<List<Reporteria>> resp = new Mensaje<List<Reporteria>>();
            resp.data = datos.individualConceptoFecha().data;

            try
            {
                this.rptconcepto.LocalReport.ReportPath = @"..\..\Reportes\RptfechaConcepto.rdlc";
                this.rptconcepto.LocalReport.DataSources.Clear();
                ReportDataSource ds = new ReportDataSource("dts_Concepto", resp.data);
                this.rptconcepto.LocalReport.DataSources.Add(ds);
                this.rptconcepto.LocalReport.Refresh();
                this.rptconcepto.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Referencia: " + ex.ToString());
            }
        }
    }
}
