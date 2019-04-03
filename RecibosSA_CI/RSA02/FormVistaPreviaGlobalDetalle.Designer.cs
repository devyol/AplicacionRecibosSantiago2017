namespace RSA02
{
    partial class frmVistaPreviaGlobalDetalle
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
            this.rptglobal = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptglobal
            // 
            this.rptglobal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptglobal.LocalReport.ReportEmbeddedResource = "RSA02.Reportes.RptglobalEvento.rdlc";
            this.rptglobal.Location = new System.Drawing.Point(0, 0);
            this.rptglobal.Name = "rptglobal";
            this.rptglobal.Size = new System.Drawing.Size(1025, 675);
            this.rptglobal.TabIndex = 0;
            // 
            // frmVistaPreviaGlobalDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 675);
            this.Controls.Add(this.rptglobal);
            this.Name = "frmVistaPreviaGlobalDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Detallado Global";
            this.Load += new System.EventHandler(this.frmVistaPreviaGlobalDetalle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptglobal;
    }
}