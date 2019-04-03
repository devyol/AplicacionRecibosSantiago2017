namespace RSA02
{
    partial class frmVistaPreviaGlobalAnulados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptanulados = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptanulados
            // 
            this.rptanulados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptanulados.LocalReport.ReportEmbeddedResource = "RSA02.Reportes.RptglobalAnulados.rdlc";
            this.rptanulados.Location = new System.Drawing.Point(0, 0);
            this.rptanulados.Name = "rptanulados";
            this.rptanulados.Size = new System.Drawing.Size(871, 685);
            this.rptanulados.TabIndex = 0;
            // 
            // frmVistaPreviaGlobalAnulados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 685);
            this.Controls.Add(this.rptanulados);
            this.Name = "frmVistaPreviaGlobalAnulados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Recibos Anulados";
            this.Load += new System.EventHandler(this.frmVistaPreviaGlobalAnulados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptanulados;
    }
}