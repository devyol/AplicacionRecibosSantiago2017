namespace RSA02
{
    partial class frmAnulacion
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
            this.lblanulacion = new System.Windows.Forms.Label();
            this.grbdatosrecibo = new System.Windows.Forms.GroupBox();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.lblserie = new System.Windows.Forms.Label();
            this.txtnumerorecibo = new System.Windows.Forms.TextBox();
            this.lblnumerorecibo = new System.Windows.Forms.Label();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnanular = new System.Windows.Forms.Button();
            this.txtmotivo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblrecibo = new System.Windows.Forms.Label();
            this.txtrecibo = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.grbdatosrecibo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblanulacion
            // 
            this.lblanulacion.AutoSize = true;
            this.lblanulacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblanulacion.Location = new System.Drawing.Point(214, 35);
            this.lblanulacion.Name = "lblanulacion";
            this.lblanulacion.Size = new System.Drawing.Size(254, 29);
            this.lblanulacion.TabIndex = 0;
            this.lblanulacion.Text = "Anulacion de Recibo";
            // 
            // grbdatosrecibo
            // 
            this.grbdatosrecibo.Controls.Add(this.txtserie);
            this.grbdatosrecibo.Controls.Add(this.lblserie);
            this.grbdatosrecibo.Controls.Add(this.txtnumerorecibo);
            this.grbdatosrecibo.Controls.Add(this.lblnumerorecibo);
            this.grbdatosrecibo.Controls.Add(this.btncancelar);
            this.grbdatosrecibo.Controls.Add(this.btnanular);
            this.grbdatosrecibo.Controls.Add(this.txtmotivo);
            this.grbdatosrecibo.Controls.Add(this.label1);
            this.grbdatosrecibo.Controls.Add(this.txttotal);
            this.grbdatosrecibo.Controls.Add(this.lbltotal);
            this.grbdatosrecibo.Controls.Add(this.txtnombre);
            this.grbdatosrecibo.Controls.Add(this.lblnombre);
            this.grbdatosrecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbdatosrecibo.Location = new System.Drawing.Point(12, 70);
            this.grbdatosrecibo.Name = "grbdatosrecibo";
            this.grbdatosrecibo.Size = new System.Drawing.Size(637, 273);
            this.grbdatosrecibo.TabIndex = 1;
            this.grbdatosrecibo.TabStop = false;
            this.grbdatosrecibo.Text = "Datos del Recibo";
            // 
            // txtserie
            // 
            this.txtserie.Location = new System.Drawing.Point(396, 148);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(100, 22);
            this.txtserie.TabIndex = 13;
            // 
            // lblserie
            // 
            this.lblserie.AutoSize = true;
            this.lblserie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblserie.Location = new System.Drawing.Point(345, 151);
            this.lblserie.Name = "lblserie";
            this.lblserie.Size = new System.Drawing.Size(45, 16);
            this.lblserie.TabIndex = 12;
            this.lblserie.Text = "Serie";
            // 
            // txtnumerorecibo
            // 
            this.txtnumerorecibo.Location = new System.Drawing.Point(174, 148);
            this.txtnumerorecibo.Name = "txtnumerorecibo";
            this.txtnumerorecibo.Size = new System.Drawing.Size(152, 22);
            this.txtnumerorecibo.TabIndex = 11;
            this.txtnumerorecibo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumerorecibo_KeyPress);
            // 
            // lblnumerorecibo
            // 
            this.lblnumerorecibo.AutoSize = true;
            this.lblnumerorecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumerorecibo.Location = new System.Drawing.Point(61, 151);
            this.lblnumerorecibo.Name = "lblnumerorecibo";
            this.lblnumerorecibo.Size = new System.Drawing.Size(104, 16);
            this.lblnumerorecibo.TabIndex = 10;
            this.lblnumerorecibo.Text = "Recibo Fisico";
            // 
            // btncancelar
            // 
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.Location = new System.Drawing.Point(348, 191);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(137, 47);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnanular
            // 
            this.btnanular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanular.Location = new System.Drawing.Point(174, 191);
            this.btnanular.Name = "btnanular";
            this.btnanular.Size = new System.Drawing.Size(137, 47);
            this.btnanular.TabIndex = 14;
            this.btnanular.Text = "Anular Recibo";
            this.btnanular.UseVisualStyleBackColor = true;
            this.btnanular.Click += new System.EventHandler(this.btnanular_Click);
            // 
            // txtmotivo
            // 
            this.txtmotivo.Location = new System.Drawing.Point(174, 107);
            this.txtmotivo.Name = "txtmotivo";
            this.txtmotivo.Size = new System.Drawing.Size(382, 22);
            this.txtmotivo.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Motivo de Anulación";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(174, 67);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(152, 22);
            this.txttotal.TabIndex = 7;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(121, 70);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(44, 16);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "Total";
            // 
            // txtnombre
            // 
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(174, 32);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(382, 22);
            this.txtnombre.TabIndex = 5;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(102, 35);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(63, 16);
            this.lblnombre.TabIndex = 4;
            this.lblnombre.Text = "Nombre";
            // 
            // lblrecibo
            // 
            this.lblrecibo.AutoSize = true;
            this.lblrecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrecibo.Location = new System.Drawing.Point(25, 9);
            this.lblrecibo.Name = "lblrecibo";
            this.lblrecibo.Size = new System.Drawing.Size(58, 16);
            this.lblrecibo.TabIndex = 0;
            this.lblrecibo.Text = "Recibo";
            this.lblrecibo.Visible = false;
            // 
            // txtrecibo
            // 
            this.txtrecibo.Location = new System.Drawing.Point(101, 6);
            this.txtrecibo.Name = "txtrecibo";
            this.txtrecibo.Size = new System.Drawing.Size(191, 20);
            this.txtrecibo.TabIndex = 1;
            this.txtrecibo.Visible = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(103, 32);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(185, 20);
            this.txtusuario.TabIndex = 3;
            this.txtusuario.Visible = false;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.Location = new System.Drawing.Point(21, 35);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(62, 16);
            this.lblusuario.TabIndex = 2;
            this.lblusuario.Text = "Usuario";
            this.lblusuario.Visible = false;
            // 
            // frmAnulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(661, 389);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.grbdatosrecibo);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblanulacion);
            this.Controls.Add(this.txtrecibo);
            this.Controls.Add(this.lblrecibo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAnulacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anulacion de Recibo";
            this.Load += new System.EventHandler(this.frmAnulacion_Load);
            this.grbdatosrecibo.ResumeLayout(false);
            this.grbdatosrecibo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblanulacion;
        private System.Windows.Forms.GroupBox grbdatosrecibo;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.TextBox txtrecibo;
        private System.Windows.Forms.Label lblrecibo;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox txtmotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnanular;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtnumerorecibo;
        private System.Windows.Forms.Label lblnumerorecibo;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Label lblserie;
    }
}