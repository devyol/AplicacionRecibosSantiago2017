namespace RSA02
{
    partial class frmReporteEvento
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
            this.lblevento = new System.Windows.Forms.Label();
            this.btnreportedetalle = new System.Windows.Forms.Button();
            this.dtpfechainicial = new System.Windows.Forms.DateTimePicker();
            this.dtpfechafinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnconcepto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblevento
            // 
            this.lblevento.AutoSize = true;
            this.lblevento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevento.Location = new System.Drawing.Point(151, 55);
            this.lblevento.Name = "lblevento";
            this.lblevento.Size = new System.Drawing.Size(111, 20);
            this.lblevento.TabIndex = 0;
            this.lblevento.Text = "Fecha Inicial";
            // 
            // btnreportedetalle
            // 
            this.btnreportedetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportedetalle.Location = new System.Drawing.Point(273, 147);
            this.btnreportedetalle.Name = "btnreportedetalle";
            this.btnreportedetalle.Size = new System.Drawing.Size(243, 40);
            this.btnreportedetalle.TabIndex = 2;
            this.btnreportedetalle.Text = "Reporte Detallado";
            this.btnreportedetalle.UseVisualStyleBackColor = true;
            this.btnreportedetalle.Click += new System.EventHandler(this.btnreportedetalle_Click);
            // 
            // dtpfechainicial
            // 
            this.dtpfechainicial.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechainicial.Location = new System.Drawing.Point(270, 55);
            this.dtpfechainicial.Name = "dtpfechainicial";
            this.dtpfechainicial.Size = new System.Drawing.Size(200, 20);
            this.dtpfechainicial.TabIndex = 6;
            // 
            // dtpfechafinal
            // 
            this.dtpfechafinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafinal.Location = new System.Drawing.Point(270, 98);
            this.dtpfechafinal.Name = "dtpfechafinal";
            this.dtpfechafinal.Size = new System.Drawing.Size(200, 20);
            this.dtpfechafinal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha Final";
            // 
            // btnconcepto
            // 
            this.btnconcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconcepto.Location = new System.Drawing.Point(273, 209);
            this.btnconcepto.Name = "btnconcepto";
            this.btnconcepto.Size = new System.Drawing.Size(243, 40);
            this.btnconcepto.TabIndex = 9;
            this.btnconcepto.Text = "Reporte por Concepto";
            this.btnconcepto.UseVisualStyleBackColor = true;
            this.btnconcepto.Click += new System.EventHandler(this.btnconcepto_Click);
            // 
            // frmReporteEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(708, 330);
            this.Controls.Add(this.btnconcepto);
            this.Controls.Add(this.dtpfechafinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpfechainicial);
            this.Controls.Add(this.btnreportedetalle);
            this.Controls.Add(this.lblevento);
            this.Name = "frmReporteEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes por Evento";
            this.Load += new System.EventHandler(this.frmReporteEvento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblevento;
        private System.Windows.Forms.Button btnreportedetalle;
        private System.Windows.Forms.DateTimePicker dtpfechainicial;
        private System.Windows.Forms.DateTimePicker dtpfechafinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnconcepto;
    }
}