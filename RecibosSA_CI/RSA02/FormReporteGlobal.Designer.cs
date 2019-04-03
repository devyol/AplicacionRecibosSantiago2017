namespace RSA02
{
    partial class frmReporteGlobal
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
            this.btnreportepais = new System.Windows.Forms.Button();
            this.btnconcepto = new System.Windows.Forms.Button();
            this.btnreportedetalle = new System.Windows.Forms.Button();
            this.btnconceptoalimentacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblevento = new System.Windows.Forms.Label();
            this.dtpfechafinal = new System.Windows.Forms.DateTimePicker();
            this.dtpfechainicial = new System.Windows.Forms.DateTimePicker();
            this.btnanulados = new System.Windows.Forms.Button();
            this.lblev = new System.Windows.Forms.Label();
            this.cbxevento = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnreportepais
            // 
            this.btnreportepais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportepais.Location = new System.Drawing.Point(273, 233);
            this.btnreportepais.Name = "btnreportepais";
            this.btnreportepais.Size = new System.Drawing.Size(243, 40);
            this.btnreportepais.TabIndex = 3;
            this.btnreportepais.Text = "Reporte por Pais";
            this.btnreportepais.UseVisualStyleBackColor = true;
            this.btnreportepais.Click += new System.EventHandler(this.btnreportepais_Click);
            // 
            // btnconcepto
            // 
            this.btnconcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconcepto.Location = new System.Drawing.Point(273, 297);
            this.btnconcepto.Name = "btnconcepto";
            this.btnconcepto.Size = new System.Drawing.Size(243, 40);
            this.btnconcepto.TabIndex = 4;
            this.btnconcepto.Text = "Reporte por Conceptos";
            this.btnconcepto.UseVisualStyleBackColor = true;
            this.btnconcepto.Click += new System.EventHandler(this.btnconcepto_Click);
            // 
            // btnreportedetalle
            // 
            this.btnreportedetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportedetalle.Location = new System.Drawing.Point(273, 166);
            this.btnreportedetalle.Name = "btnreportedetalle";
            this.btnreportedetalle.Size = new System.Drawing.Size(243, 40);
            this.btnreportedetalle.TabIndex = 2;
            this.btnreportedetalle.Text = "Reporte Detallado";
            this.btnreportedetalle.UseVisualStyleBackColor = true;
            this.btnreportedetalle.Click += new System.EventHandler(this.btnreportedetalle_Click);
            // 
            // btnconceptoalimentacion
            // 
            this.btnconceptoalimentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconceptoalimentacion.Location = new System.Drawing.Point(273, 361);
            this.btnconceptoalimentacion.Name = "btnconceptoalimentacion";
            this.btnconceptoalimentacion.Size = new System.Drawing.Size(243, 40);
            this.btnconceptoalimentacion.TabIndex = 5;
            this.btnconceptoalimentacion.Text = "Reporte por Alimentacion";
            this.btnconceptoalimentacion.UseVisualStyleBackColor = true;
            this.btnconceptoalimentacion.Click += new System.EventHandler(this.btnconceptoalimentacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha Final";
            // 
            // lblevento
            // 
            this.lblevento.AutoSize = true;
            this.lblevento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevento.Location = new System.Drawing.Point(157, 72);
            this.lblevento.Name = "lblevento";
            this.lblevento.Size = new System.Drawing.Size(111, 20);
            this.lblevento.TabIndex = 8;
            this.lblevento.Text = "Fecha Inicial";
            // 
            // dtpfechafinal
            // 
            this.dtpfechafinal.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechafinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechafinal.Location = new System.Drawing.Point(299, 115);
            this.dtpfechafinal.Name = "dtpfechafinal";
            this.dtpfechafinal.Size = new System.Drawing.Size(200, 20);
            this.dtpfechafinal.TabIndex = 11;
            // 
            // dtpfechainicial
            // 
            this.dtpfechainicial.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechainicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechainicial.Location = new System.Drawing.Point(299, 72);
            this.dtpfechainicial.Name = "dtpfechainicial";
            this.dtpfechainicial.Size = new System.Drawing.Size(200, 20);
            this.dtpfechainicial.TabIndex = 10;
            // 
            // btnanulados
            // 
            this.btnanulados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanulados.Location = new System.Drawing.Point(273, 420);
            this.btnanulados.Name = "btnanulados";
            this.btnanulados.Size = new System.Drawing.Size(243, 40);
            this.btnanulados.TabIndex = 12;
            this.btnanulados.Text = "Reporte Recibos Anulados";
            this.btnanulados.UseVisualStyleBackColor = true;
            this.btnanulados.Click += new System.EventHandler(this.btnanulados_Click);
            // 
            // lblev
            // 
            this.lblev.AutoSize = true;
            this.lblev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblev.Location = new System.Drawing.Point(195, 35);
            this.lblev.Name = "lblev";
            this.lblev.Size = new System.Drawing.Size(65, 20);
            this.lblev.TabIndex = 13;
            this.lblev.Text = "Evento";
            // 
            // cbxevento
            // 
            this.cbxevento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxevento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxevento.FormattingEnabled = true;
            this.cbxevento.Location = new System.Drawing.Point(299, 31);
            this.cbxevento.Name = "cbxevento";
            this.cbxevento.Size = new System.Drawing.Size(291, 24);
            this.cbxevento.TabIndex = 14;
            // 
            // frmReporteGlobal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(754, 510);
            this.Controls.Add(this.cbxevento);
            this.Controls.Add(this.lblev);
            this.Controls.Add(this.btnanulados);
            this.Controls.Add(this.dtpfechafinal);
            this.Controls.Add(this.dtpfechainicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblevento);
            this.Controls.Add(this.btnconceptoalimentacion);
            this.Controls.Add(this.btnconcepto);
            this.Controls.Add(this.btnreportepais);
            this.Controls.Add(this.btnreportedetalle);
            this.Name = "frmReporteGlobal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes Globales";
            this.Load += new System.EventHandler(this.frmReporteGlobal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnreportepais;
        private System.Windows.Forms.Button btnconcepto;
        private System.Windows.Forms.Button btnreportedetalle;
        private System.Windows.Forms.Button btnconceptoalimentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblevento;
        private System.Windows.Forms.DateTimePicker dtpfechafinal;
        private System.Windows.Forms.DateTimePicker dtpfechainicial;
        private System.Windows.Forms.Button btnanulados;
        private System.Windows.Forms.Label lblev;
        private System.Windows.Forms.ComboBox cbxevento;
    }
}