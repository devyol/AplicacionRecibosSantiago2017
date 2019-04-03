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

namespace RSA02
{
    public partial class frmVistaPrevia : Form
    {
        public Nullable<decimal> recibo { get; set; }
        public string usuario { get; set; }
        public decimal medio_pago { get; set; }

        public frmVistaPrevia()
        {
            InitializeComponent();
        }

        private void frmVistaPrevia_Load(object sender, EventArgs e)
        {
            Recibo objServicio = new Recibo() { recibo = recibo, usuario = usuario };
            List<reciboEntidad> servicio = objServicio.obtenerRecibo();

            if (medio_pago == 1)
            {
                try
                {
                    this.rptdiseno.LocalReport.ReportPath = @"..\..\Reportes\RptImpresionEfectivo.rdlc";
                    this.rptdiseno.LocalReport.DataSources.Clear();
                    ReportDataSource ds = new ReportDataSource("dts_recibo", servicio);
                    this.rptdiseno.LocalReport.DataSources.Add(ds);
                    this.rptdiseno.LocalReport.Refresh();
                    this.rptdiseno.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Referencia: " + ex.ToString());
                }
            }
            else if (medio_pago == 2)
            {
                try
                {
                    this.rptdiseno.LocalReport.ReportPath = @"..\..\Reportes\RptImpresionCheque.rdlc";
                    this.rptdiseno.LocalReport.DataSources.Clear();
                    ReportDataSource ds = new ReportDataSource("dts_recibo", servicio);
                    this.rptdiseno.LocalReport.DataSources.Add(ds);
                    this.rptdiseno.LocalReport.Refresh();
                    this.rptdiseno.RefreshReport();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Referencia: " + ex.ToString());
                }                
            }


        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            Recibo objServicio = new Recibo() { recibo = recibo, usuario = usuario };
            List<reciboEntidad> servicio = objServicio.obtenerRecibo();

            if (medio_pago == 1)
            {
                try
                {
                    //MUESTRA LA VISTA PREVIA DEL REPORTE
                    LocalReport rdlc = new LocalReport();
                    rdlc.ReportPath = @"..\..\Reportes\RptImpresionEfectivo.rdlc";
                    rdlc.DataSources.Clear();
                    ReportDataSource ds = new ReportDataSource("dts_recibo", servicio);
                    rdlc.DataSources.Add(ds);
                    //ENVIA EL REPORTE A LA IMPRESORA
                    impresor imp = new impresor();
                    imp.Imprime(rdlc);
                    //SE CIERRA VENTANA DE VISTA PREVIA Y SE HABRE LA PANTALLA DEL MENU PRINCIPAL
                    frmReciboEvento nre = new frmReciboEvento();
                    this.Hide();
                    nre.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (medio_pago == 2)
            {
                try
                {
                    //MUESTRA LA VISTA PREVIA DEL REPORTE
                    LocalReport rdlc = new LocalReport();
                    rdlc.ReportPath = @"..\..\Reportes\RptImpresionCheque.rdlc";
                    rdlc.DataSources.Clear();
                    ReportDataSource ds = new ReportDataSource("dts_recibo", servicio);
                    rdlc.DataSources.Add(ds);
                    //ENVIA EL REPORTE A LA IMPRESORA
                    impresor imp = new impresor();
                    imp.Imprime(rdlc);
                    //SE CIERRA VENTANA DE VISTA PREVIA Y SE HABRE LA PANTALLA DEL MENU PRINCIPAL
                    frmReciboEvento nre = new frmReciboEvento();
                    this.Hide();
                    nre.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }                
            }


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmReciboEvento nre = new frmReciboEvento();
            this.Hide();
            nre.ShowDialog();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmReciboEvento nreev = new frmReciboEvento();
            nreev.reciboimpresion = this.recibo;
            this.Hide();
            nreev.ShowDialog();
            this.Close();
        }
    }
}
