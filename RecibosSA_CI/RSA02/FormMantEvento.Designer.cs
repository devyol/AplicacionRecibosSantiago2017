namespace RSA02
{
    partial class frmMantEvento
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblevento = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.cbxestado = new System.Windows.Forms.ComboBox();
            this.grbevento = new System.Windows.Forms.GroupBox();
            this.grbMant = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.grblistado = new System.Windows.Forms.GroupBox();
            this.dtglistado = new System.Windows.Forms.DataGridView();
            this.evento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grbevento.SuspendLayout();
            this.grbMant.SuspendLayout();
            this.grblistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(190, 27);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(321, 29);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Mantenimiento de Eventos";
            // 
            // lblevento
            // 
            this.lblevento.AutoSize = true;
            this.lblevento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblevento.Location = new System.Drawing.Point(6, 36);
            this.lblevento.Name = "lblevento";
            this.lblevento.Size = new System.Drawing.Size(152, 18);
            this.lblevento.TabIndex = 1;
            this.lblevento.Text = "Nombre del Evento";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(163, 34);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(260, 22);
            this.txtnombre.TabIndex = 2;
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(13, 81);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(145, 18);
            this.lblestado.TabIndex = 3;
            this.lblestado.Text = "Estado del Evento";
            // 
            // cbxestado
            // 
            this.cbxestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxestado.FormattingEnabled = true;
            this.cbxestado.Location = new System.Drawing.Point(163, 80);
            this.cbxestado.Name = "cbxestado";
            this.cbxestado.Size = new System.Drawing.Size(168, 24);
            this.cbxestado.TabIndex = 4;
            // 
            // grbevento
            // 
            this.grbevento.Controls.Add(this.lblevento);
            this.grbevento.Controls.Add(this.cbxestado);
            this.grbevento.Controls.Add(this.txtnombre);
            this.grbevento.Controls.Add(this.lblestado);
            this.grbevento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbevento.Location = new System.Drawing.Point(38, 79);
            this.grbevento.Name = "grbevento";
            this.grbevento.Size = new System.Drawing.Size(439, 150);
            this.grbevento.TabIndex = 5;
            this.grbevento.TabStop = false;
            this.grbevento.Text = "Datos del Evento";
            // 
            // grbMant
            // 
            this.grbMant.Controls.Add(this.btnlimpiar);
            this.grbMant.Controls.Add(this.btnmodificar);
            this.grbMant.Controls.Add(this.btnagregar);
            this.grbMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMant.Location = new System.Drawing.Point(488, 79);
            this.grbMant.Name = "grbMant";
            this.grbMant.Size = new System.Drawing.Size(171, 150);
            this.grbMant.TabIndex = 6;
            this.grbMant.TabStop = false;
            this.grbMant.Text = "Acciones";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.Location = new System.Drawing.Point(42, 103);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(108, 37);
            this.btnlimpiar.TabIndex = 2;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.Location = new System.Drawing.Point(42, 60);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(99, 37);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
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
            // grblistado
            // 
            this.grblistado.Controls.Add(this.dtglistado);
            this.grblistado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grblistado.Location = new System.Drawing.Point(38, 250);
            this.grblistado.Name = "grblistado";
            this.grblistado.Size = new System.Drawing.Size(621, 273);
            this.grblistado.TabIndex = 7;
            this.grblistado.TabStop = false;
            this.grblistado.Text = "Listado de eventos";
            // 
            // dtglistado
            // 
            this.dtglistado.AllowUserToAddRows = false;
            this.dtglistado.AllowUserToDeleteRows = false;
            this.dtglistado.AutoGenerateColumns = false;
            this.dtglistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtglistado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtglistado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtglistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtglistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.evento,
            this.nombre,
            this.estado_registro,
            this.usuario_creacion,
            this.fecha_creacion,
            this.usuario_modificacion,
            this.fecha_modificacion});
            this.dtglistado.DataSource = this.bindingSource1;
            this.dtglistado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtglistado.Location = new System.Drawing.Point(3, 18);
            this.dtglistado.Name = "dtglistado";
            this.dtglistado.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtglistado.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtglistado.RowHeadersVisible = false;
            this.dtglistado.Size = new System.Drawing.Size(615, 252);
            this.dtglistado.TabIndex = 0;
            this.dtglistado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtglistado_CellClick);
            // 
            // evento
            // 
            this.evento.DataPropertyName = "evento";
            this.evento.HeaderText = "Evento";
            this.evento.Name = "evento";
            this.evento.ReadOnly = true;
            this.evento.Visible = false;
            this.evento.Width = 75;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre del Evento";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 149;
            // 
            // estado_registro
            // 
            this.estado_registro.DataPropertyName = "estado_registro";
            this.estado_registro.HeaderText = "Estado";
            this.estado_registro.Name = "estado_registro";
            this.estado_registro.ReadOnly = true;
            this.estado_registro.Width = 76;
            // 
            // usuario_creacion
            // 
            this.usuario_creacion.DataPropertyName = "usuario_creacion";
            this.usuario_creacion.HeaderText = "Usuario Creacion";
            this.usuario_creacion.Name = "usuario_creacion";
            this.usuario_creacion.ReadOnly = true;
            this.usuario_creacion.Width = 137;
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.DataPropertyName = "fecha_creacion";
            this.fecha_creacion.HeaderText = "Fecha Creacion";
            this.fecha_creacion.Name = "fecha_creacion";
            this.fecha_creacion.ReadOnly = true;
            this.fecha_creacion.Width = 128;
            // 
            // usuario_modificacion
            // 
            this.usuario_modificacion.DataPropertyName = "usuario_modificacion";
            this.usuario_modificacion.HeaderText = "Usuario Modificacion";
            this.usuario_modificacion.Name = "usuario_modificacion";
            this.usuario_modificacion.ReadOnly = true;
            this.usuario_modificacion.Width = 159;
            // 
            // fecha_modificacion
            // 
            this.fecha_modificacion.DataPropertyName = "fecha_modificacion";
            this.fecha_modificacion.HeaderText = "Fecha Modificacion";
            this.fecha_modificacion.Name = "fecha_modificacion";
            this.fecha_modificacion.ReadOnly = true;
            this.fecha_modificacion.Width = 150;
            // 
            // frmMantEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 538);
            this.Controls.Add(this.grblistado);
            this.Controls.Add(this.grbMant);
            this.Controls.Add(this.grbevento);
            this.Controls.Add(this.lbltitulo);
            this.Name = "frmMantEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.frmMantEvento_Load);
            this.grbevento.ResumeLayout(false);
            this.grbevento.PerformLayout();
            this.grbMant.ResumeLayout(false);
            this.grblistado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtglistado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblevento;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.ComboBox cbxestado;
        private System.Windows.Forms.GroupBox grbevento;
        private System.Windows.Forms.GroupBox grbMant;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.GroupBox grblistado;
        private System.Windows.Forms.DataGridView dtglistado;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn evento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_modificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_modificacion;
        private System.Windows.Forms.Button btnlimpiar;
    }
}