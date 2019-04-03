namespace RSA02
{
    partial class frmEvento
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
            this.btnregresar = new System.Windows.Forms.Button();
            this.gpbEvento = new System.Windows.Forms.GroupBox();
            this.btnactivar = new System.Windows.Forms.Button();
            this.cbxevento = new System.Windows.Forms.ComboBox();
            this.lblevento = new System.Windows.Forms.Label();
            this.gpbEvento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnregresar
            // 
            this.btnregresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregresar.Location = new System.Drawing.Point(210, 99);
            this.btnregresar.Name = "btnregresar";
            this.btnregresar.Size = new System.Drawing.Size(128, 39);
            this.btnregresar.TabIndex = 0;
            this.btnregresar.Text = "Cerrar";
            this.btnregresar.UseVisualStyleBackColor = true;
            this.btnregresar.Click += new System.EventHandler(this.btnregresar_Click);
            // 
            // gpbEvento
            // 
            this.gpbEvento.Controls.Add(this.btnactivar);
            this.gpbEvento.Controls.Add(this.btnregresar);
            this.gpbEvento.Controls.Add(this.cbxevento);
            this.gpbEvento.Controls.Add(this.lblevento);
            this.gpbEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEvento.Location = new System.Drawing.Point(12, 32);
            this.gpbEvento.Name = "gpbEvento";
            this.gpbEvento.Size = new System.Drawing.Size(377, 215);
            this.gpbEvento.TabIndex = 1;
            this.gpbEvento.TabStop = false;
            this.gpbEvento.Text = "Lista de Eventos";
            // 
            // btnactivar
            // 
            this.btnactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivar.Location = new System.Drawing.Point(37, 99);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(128, 39);
            this.btnactivar.TabIndex = 2;
            this.btnactivar.Text = "Acceder";
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // cbxevento
            // 
            this.cbxevento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxevento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxevento.FormattingEnabled = true;
            this.cbxevento.Location = new System.Drawing.Point(68, 39);
            this.cbxevento.Name = "cbxevento";
            this.cbxevento.Size = new System.Drawing.Size(291, 24);
            this.cbxevento.TabIndex = 1;
            // 
            // lblevento
            // 
            this.lblevento.AutoSize = true;
            this.lblevento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevento.Location = new System.Drawing.Point(6, 42);
            this.lblevento.Name = "lblevento";
            this.lblevento.Size = new System.Drawing.Size(56, 16);
            this.lblevento.TabIndex = 0;
            this.lblevento.Text = "Evento";
            // 
            // frmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 281);
            this.Controls.Add(this.gpbEvento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activar Evento";
            this.Load += new System.EventHandler(this.frmEvento_Load);
            this.gpbEvento.ResumeLayout(false);
            this.gpbEvento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnregresar;
        private System.Windows.Forms.GroupBox gpbEvento;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.ComboBox cbxevento;
        private System.Windows.Forms.Label lblevento;
    }
}