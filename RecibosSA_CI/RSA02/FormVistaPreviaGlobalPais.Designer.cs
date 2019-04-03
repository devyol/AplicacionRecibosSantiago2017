namespace RSA02
{
    partial class frmVistaPreviaGlobalPais
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
            this.rptpais = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptpais
            // 
            this.rptpais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptpais.LocalReport.ReportEmbeddedResource = "RSA02.Reportes.RptglobalPais.rdlc";
            this.rptpais.Location = new System.Drawing.Point(0, 0);
            this.rptpais.Name = "rptpais";
            this.rptpais.Size = new System.Drawing.Size(871, 685);
            this.rptpais.TabIndex = 0;
            // 
            // frmVistaPreviaGlobalPais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(871, 685);
            this.Controls.Add(this.rptpais);
            this.Name = "frmVistaPreviaGlobalPais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte por Pais";
            this.Load += new System.EventHandler(this.frmVistaPreviaGlobalPais_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptpais;
    }
}