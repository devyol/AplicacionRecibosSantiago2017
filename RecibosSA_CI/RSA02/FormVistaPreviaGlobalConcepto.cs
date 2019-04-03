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
    public partial class frmVistaPreviaGlobalConcepto : Form
    {
        public string fechainicial { get; set; }
        public string fechafinal { get; set; }
        public decimal idEvento { get; set; }

        public frmVistaPreviaGlobalConcepto()
        {
            InitializeComponent();
        }

        private void frmVistaPreviaGlobalConcepto_Load(object sender, EventArgs e)
        {

            Reporteria datos = new Reporteria() { fecha_inicial = this.fechainicial, 
                                                  fecha_final = this.fechafinal,
                                                  idevento = this.idEvento};
            Mensaje<List<Reporteria>> resp = new Mensaje<List<Reporteria>>();
            resp.data = datos.globalConceptoFecha().data;

            try
            {
                this.rptconcepto.LocalReport.ReportPath = @"..\..\Reportes\RptglobalConcepto.rdlc";
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
