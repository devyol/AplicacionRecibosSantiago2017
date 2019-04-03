namespace RSA02
{
    partial class frmMantCorrelativo
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
            this.lbltitulo = new System.Windows.Forms.Label();
            this.grbbanco = new System.Windows.Forms.GroupBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCorrelativoFinal = new System.Windows.Forms.TextBox();
            this.lblCorrelativoActual = new System.Windows.Forms.Label();
            this.txtCorrelativoActual = new System.Windows.Forms.TextBox();
            this.grbMant = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.grbbanco.SuspendLayout();
            this.grbMant.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(112, 21);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(460, 29);
            this.lbltitulo.TabIndex = 9;
            this.lbltitulo.Text = "Mantenimiento de Correlativos Fisicos";
            // 
            // grbbanco
            // 
            this.grbbanco.Controls.Add(this.txtSerie);
            this.grbbanco.Controls.Add(this.lblSerie);
            this.grbbanco.Controls.Add(this.label1);
            this.grbbanco.Controls.Add(this.txtCorrelativoFinal);
            this.grbbanco.Controls.Add(this.lblCorrelativoActual);
            this.grbbanco.Controls.Add(this.txtCorrelativoActual);
            this.grbbanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbanco.Location = new System.Drawing.Point(32, 73);
            this.grbbanco.Name = "grbbanco";
            this.grbbanco.Size = new System.Drawing.Size(493, 139);
            this.grbbanco.TabIndex = 10;
            this.grbbanco.TabStop = false;
            this.grbbanco.Text = "Correlativos Fisicos";
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(221, 102);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(260, 22);
            this.txtSerie.TabIndex = 6;
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(106, 103);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(105, 18);
            this.lblSerie.TabIndex = 5;
            this.lblSerie.Text = "Serie Recibo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correlativo Final";
            // 
            // txtCorrelativoFinal
            // 
            this.txtCorrelativoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrelativoFinal.Location = new System.Drawing.Point(221, 67);
            this.txtCorrelativoFinal.Name = "txtCorrelativoFinal";
            this.txtCorrelativoFinal.Size = new System.Drawing.Size(260, 22);
            this.txtCorrelativoFinal.TabIndex = 4;
            this.txtCorrelativoFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorrelativoFinal_KeyPress);
            // 
            // lblCorrelativoActual
            // 
            this.lblCorrelativoActual.AutoSize = true;
            this.lblCorrelativoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativoActual.Location = new System.Drawing.Point(6, 36);
            this.lblCorrelativoActual.Name = "lblCorrelativoActual";
            this.lblCorrelativoActual.Size = new System.Drawing.Size(205, 18);
            this.lblCorrelativoActual.TabIndex = 1;
            this.lblCorrelativoActual.Text = "Correlativo Inicial o Actual";
            // 
            // txtCorrelativoActual
            // 
            this.txtCorrelativoActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorrelativoActual.Location = new System.Drawing.Point(221, 34);
            this.txtCorrelativoActual.Name = "txtCorrelativoActual";
            this.txtCorrelativoActual.Size = new System.Drawing.Size(260, 22);
            this.txtCorrelativoActual.TabIndex = 2;
            this.txtCorrelativoActual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCorrelativoActual_KeyPress);
            // 
            // grbMant
            // 
            this.grbMant.Controls.Add(this.btnSalir);
            this.grbMant.Controls.Add(this.btnagregar);
            this.grbMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMant.Location = new System.Drawing.Point(531, 73);
            this.grbMant.Name = "grbMant";
            this.grbMant.Size = new System.Drawing.Size(171, 139);
            this.grbMant.TabIndex = 11;
            this.grbMant.TabStop = false;
            this.grbMant.Text = "Acciones";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(42, 69);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(99, 37);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(42, 17);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(99, 37);
            this.btnagregar.TabIndex = 0;
            this.btnagregar.Text = "Guardar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // frmMantCorrelativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 286);
            this.Controls.Add(this.grbMant);
            this.Controls.Add(this.grbbanco);
            this.Controls.Add(this.lbltitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMantCorrelativo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correlativos Fisicos";
            this.Load += new System.EventHandler(this.frmMantCorrelativo_Load);
            this.grbbanco.ResumeLayout(false);
            this.grbbanco.PerformLayout();
            this.grbMant.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.GroupBox grbbanco;
        private System.Windows.Forms.Label lblCorrelativoActual;
        private System.Windows.Forms.TextBox txtCorrelativoActual;
        private System.Windows.Forms.GroupBox grbMant;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCorrelativoFinal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Label lblSerie;
    }
}