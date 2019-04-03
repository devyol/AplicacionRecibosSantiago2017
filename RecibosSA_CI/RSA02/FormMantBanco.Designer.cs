namespace RSA02
{
    partial class frmMantBanco
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
            this.grblistado = new System.Windows.Forms.GroupBox();
            this.dtglistado = new System.Windows.Forms.DataGridView();
            this.banco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado_registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_modificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbMant = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.grbbanco = new System.Windows.Forms.GroupBox();
            this.lblbanco = new System.Windows.Forms.Label();
            this.cbxestado = new System.Windows.Forms.ComboBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblestado = new System.Windows.Forms.Label();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.grblistado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtglistado)).BeginInit();
            this.grbMant.SuspendLayout();
            this.grbbanco.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grblistado
            // 
            this.grblistado.Controls.Add(this.dtglistado);
            this.grblistado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grblistado.Location = new System.Drawing.Point(54, 244);
            this.grblistado.Name = "grblistado";
            this.grblistado.Size = new System.Drawing.Size(621, 273);
            this.grblistado.TabIndex = 11;
            this.grblistado.TabStop = false;
            this.grblistado.Text = "Listado de Bancos";
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
            this.banco,
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
            // banco
            // 
            this.banco.DataPropertyName = "banco";
            this.banco.HeaderText = "Banco";
            this.banco.Name = "banco";
            this.banco.ReadOnly = true;
            this.banco.Visible = false;
            this.banco.Width = 72;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre del Banco";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 146;
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
            // grbMant
            // 
            this.grbMant.Controls.Add(this.btnlimpiar);
            this.grbMant.Controls.Add(this.btnmodificar);
            this.grbMant.Controls.Add(this.btnagregar);
            this.grbMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMant.Location = new System.Drawing.Point(504, 73);
            this.grbMant.Name = "grbMant";
            this.grbMant.Size = new System.Drawing.Size(171, 150);
            this.grbMant.TabIndex = 10;
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
            // grbbanco
            // 
            this.grbbanco.Controls.Add(this.lblbanco);
            this.grbbanco.Controls.Add(this.cbxestado);
            this.grbbanco.Controls.Add(this.txtnombre);
            this.grbbanco.Controls.Add(this.lblestado);
            this.grbbanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbanco.Location = new System.Drawing.Point(54, 73);
            this.grbbanco.Name = "grbbanco";
            this.grbbanco.Size = new System.Drawing.Size(439, 150);
            this.grbbanco.TabIndex = 9;
            this.grbbanco.TabStop = false;
            this.grbbanco.Text = "Datos del Banco";
            // 
            // lblbanco
            // 
            this.lblbanco.AutoSize = true;
            this.lblbanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbanco.Location = new System.Drawing.Point(6, 36);
            this.lblbanco.Name = "lblbanco";
            this.lblbanco.Size = new System.Drawing.Size(148, 18);
            this.lblbanco.TabIndex = 1;
            this.lblbanco.Text = "Nombre del Banco";
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
            this.lblestado.Size = new System.Drawing.Size(141, 18);
            this.lblestado.TabIndex = 3;
            this.lblestado.Text = "Estado del Banco";
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(206, 21);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(314, 29);
            this.lbltitulo.TabIndex = 8;
            this.lbltitulo.Text = "Mantenimiento de Bancos";
            // 
            // frmMantBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(728, 538);
            this.Controls.Add(this.grblistado);
            this.Controls.Add(this.grbMant);
            this.Controls.Add(this.grbbanco);
            this.Controls.Add(this.lbltitulo);
            this.Name = "frmMantBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bancos";
            this.Load += new System.EventHandler(this.frmMantBanco_Load);
            this.grblistado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtglistado)).EndInit();
            this.grbMant.ResumeLayout(false);
            this.grbbanco.ResumeLayout(false);
            this.grbbanco.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grblistado;
        private System.Windows.Forms.DataGridView dtglistado;
        private System.Windows.Forms.GroupBox grbMant;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.GroupBox grbbanco;
        private System.Windows.Forms.Label lblbanco;
        private System.Windows.Forms.ComboBox cbxestado;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn banco;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_modificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_modificacion;

    }
}