namespace RSA02
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRecibo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReciboEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConcepto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBanco = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPais = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmreportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmreportesGlobales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmprincipalayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmmanual = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmacerca = new System.Windows.Forms.ToolStripMenuItem();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lbltipousuario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tsmRecibo,
            this.tsmMantenimiento,
            this.tsmreportes,
            this.tsmprincipalayuda});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(865, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 21);
            this.toolStripMenuItem1.Text = "Menu";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem3.Text = "Cambiar Contraseña";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 22);
            this.toolStripMenuItem2.Text = "Cerrar Sesion";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // tsmRecibo
            // 
            this.tsmRecibo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmReciboEvento});
            this.tsmRecibo.Name = "tsmRecibo";
            this.tsmRecibo.Size = new System.Drawing.Size(108, 21);
            this.tsmRecibo.Text = "Gestion Recibo";
            // 
            // tsmReciboEvento
            // 
            this.tsmReciboEvento.Name = "tsmReciboEvento";
            this.tsmReciboEvento.Size = new System.Drawing.Size(178, 22);
            this.tsmReciboEvento.Text = "Recibo de Evento";
            this.tsmReciboEvento.Click += new System.EventHandler(this.tsmReciboEvento_Click);
            // 
            // tsmMantenimiento
            // 
            this.tsmMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEvento,
            this.tsmConcepto,
            this.tsmBanco,
            this.tsmPais});
            this.tsmMantenimiento.Name = "tsmMantenimiento";
            this.tsmMantenimiento.Size = new System.Drawing.Size(113, 21);
            this.tsmMantenimiento.Text = "Mantenimientos";
            // 
            // tsmEvento
            // 
            this.tsmEvento.Name = "tsmEvento";
            this.tsmEvento.Size = new System.Drawing.Size(138, 22);
            this.tsmEvento.Text = "Eventos";
            this.tsmEvento.Click += new System.EventHandler(this.tsmEvento_Click);
            // 
            // tsmConcepto
            // 
            this.tsmConcepto.Name = "tsmConcepto";
            this.tsmConcepto.Size = new System.Drawing.Size(138, 22);
            this.tsmConcepto.Text = "Conceptos";
            this.tsmConcepto.Click += new System.EventHandler(this.tsmConcepto_Click);
            // 
            // tsmBanco
            // 
            this.tsmBanco.Name = "tsmBanco";
            this.tsmBanco.Size = new System.Drawing.Size(138, 22);
            this.tsmBanco.Text = "Bancos";
            this.tsmBanco.Click += new System.EventHandler(this.tsmBanco_Click);
            // 
            // tsmPais
            // 
            this.tsmPais.Name = "tsmPais";
            this.tsmPais.Size = new System.Drawing.Size(138, 22);
            this.tsmPais.Text = "Paises";
            this.tsmPais.Click += new System.EventHandler(this.tsmPais_Click);
            // 
            // tsmreportes
            // 
            this.tsmreportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmreportesGlobales});
            this.tsmreportes.Name = "tsmreportes";
            this.tsmreportes.Size = new System.Drawing.Size(73, 21);
            this.tsmreportes.Text = "Reportes";
            // 
            // tsmreportesGlobales
            // 
            this.tsmreportesGlobales.Name = "tsmreportesGlobales";
            this.tsmreportesGlobales.Size = new System.Drawing.Size(184, 22);
            this.tsmreportesGlobales.Text = "Reportes Globales";
            this.tsmreportesGlobales.Click += new System.EventHandler(this.tsmreportesGlobales_Click);
            // 
            // tsmprincipalayuda
            // 
            this.tsmprincipalayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmmanual,
            this.tsmacerca});
            this.tsmprincipalayuda.Name = "tsmprincipalayuda";
            this.tsmprincipalayuda.Size = new System.Drawing.Size(56, 21);
            this.tsmprincipalayuda.Text = "Ayuda";
            // 
            // tsmmanual
            // 
            this.tsmmanual.Name = "tsmmanual";
            this.tsmmanual.Size = new System.Drawing.Size(187, 22);
            this.tsmmanual.Text = "Manual de Usuario";
            this.tsmmanual.Click += new System.EventHandler(this.tsmmanual_Click);
            // 
            // tsmacerca
            // 
            this.tsmacerca.Name = "tsmacerca";
            this.tsmacerca.Size = new System.Drawing.Size(187, 22);
            this.tsmacerca.Text = "Acerca de";
            this.tsmacerca.Click += new System.EventHandler(this.tsmacerca_Click);
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusuario.Location = new System.Drawing.Point(677, 228);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(51, 20);
            this.lblusuario.TabIndex = 1;
            this.lblusuario.Text = "label1";
            // 
            // lbltipousuario
            // 
            this.lbltipousuario.AutoSize = true;
            this.lbltipousuario.Location = new System.Drawing.Point(25, 199);
            this.lbltipousuario.Name = "lbltipousuario";
            this.lbltipousuario.Size = new System.Drawing.Size(35, 13);
            this.lbltipousuario.TabIndex = 2;
            this.lbltipousuario.Text = "label2";
            this.lbltipousuario.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbltitulo);
            this.panel1.Controls.Add(this.lblusuario);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(865, 271);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Image = global::RSA02.Properties.Resources.IDJPMG;
            this.pictureBox1.Location = new System.Drawing.Point(28, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltitulo.Location = new System.Drawing.Point(309, 23);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(408, 58);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Iglesia de Jesucristo Palabra Miel\r\nSistema de Recibos - Retiros\r\n";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(865, 587);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltipousuario);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label lbltipousuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem tsmRecibo;
        private System.Windows.Forms.ToolStripMenuItem tsmReciboEvento;
        private System.Windows.Forms.ToolStripMenuItem tsmMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tsmEvento;
        private System.Windows.Forms.ToolStripMenuItem tsmBanco;
        private System.Windows.Forms.ToolStripMenuItem tsmPais;
        private System.Windows.Forms.ToolStripMenuItem tsmreportes;
        private System.Windows.Forms.ToolStripMenuItem tsmConcepto;
        private System.Windows.Forms.ToolStripMenuItem tsmreportesGlobales;
        private System.Windows.Forms.ToolStripMenuItem tsmprincipalayuda;
        private System.Windows.Forms.ToolStripMenuItem tsmmanual;
        private System.Windows.Forms.ToolStripMenuItem tsmacerca;
    }
}