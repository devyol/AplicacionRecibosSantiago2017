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
    public partial class frmVistaPreviaGlobalPais : Form
    {
        public string fechainicial { get; set; }
        public string fechafinal { get; set; }
        public decimal idEvento { get; set; }

        public frmVistaPreviaGlobalPais()
        {
            InitializeComponent();
        }

        private void frmVistaPreviaGlobalPais_Load(object sender, EventArgs e)
        {
            Reporteria datos = new Reporteria() { fecha_inicial = this.fechainicial, 
                                                  fecha_final = this.fechafinal,
                                                  idevento = this.idEvento};
            Mensaje<List<Reporteria>> resp = new Mensaje<List<Reporteria>>();
            resp.data = datos.globalPaisFecha().data;

            try
            {
                this.rptpais.LocalReport.ReportPath = @"..\..\Reportes\RptglobalPais.rdlc";
                this.rptpais.LocalReport.DataSources.Clear();
                ReportDataSource ds = new ReportDataSource("dts_Pais", resp.data);
                this.rptpais.LocalReport.DataSources.Add(ds);
                this.rptpais.LocalReport.Refresh();
                this.rptpais.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Referencia: " + ex.ToString());
            }

        }
    }
}
