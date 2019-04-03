namespace RSA02
{
    partial class frmVistaPreviaGlobalAlimentacion
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
            this.rptalimentacion = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptalimentacion
            // 
            this.rptalimentacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptalimentacion.LocalReport.ReportEmbeddedResource = "RSA02.Reportes.RptfechaAlimentacion.rdlc";
            this.rptalimentacion.Location = new System.Drawing.Point(0, 0);
            this.rptalimentacion.Name = "rptalimentacion";
            this.rptalimentacion.Size = new System.Drawing.Size(871, 685);
            this.rptalimentacion.TabIndex = 0;
            // 
            // frmVistaPreviaGlobalAlimentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 685);
            this.Controls.Add(this.rptalimentacion);
            this.Name = "frmVistaPreviaGlobalAlimentacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVistaPreviaGlobalAlimentacion";
            this.Load += new System.EventHandler(this.frmVistaPreviaGlobalAlimentacion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptalimentacion;
    }
}