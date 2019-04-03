namespace RSA02
{
    partial class frmReciboEvento
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmmenuprincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmreportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmreporteevento = new System.Windows.Forms.ToolStripMenuItem();
            this.correlativoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificarCorrelativo = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbrecibo = new System.Windows.Forms.GroupBox();
            this.btnparticipante = new System.Windows.Forms.Button();
            this.txtrecibo = new System.Windows.Forms.TextBox();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.lblobsevacion = new System.Windows.Forms.Label();
            this.txtcheque = new System.Windows.Forms.TextBox();
            this.lblcheque = new System.Windows.Forms.Label();
            this.cbxbancos = new System.Windows.Forms.ComboBox();
            this.lblbanco = new System.Windows.Forms.Label();
            this.cbxmodopago = new System.Windows.Forms.ComboBox();
            this.lbltipopago = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.cbxconcepto = new System.Windows.Forms.ComboBox();
            this.lblconcepto = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.txtnit = new System.Windows.Forms.TextBox();
            this.lblnit = new System.Windows.Forms.Label();
            this.cbxpais = new System.Windows.Forms.ComboBox();
            this.lblpais = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.lbldireccion = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnanular = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.gpblista = new System.Windows.Forms.GroupBox();
            this.dgvlistado = new System.Windows.Forms.DataGridView();
            this.recibo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recibo_fisico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha_creacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprimir = new System.Windows.Forms.DataGridViewButtonColumn();
            this.medio_pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gpbcorrelativo = new System.Windows.Forms.GroupBox();
            this.lblSerie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCorrelativoFisico = new System.Windows.Forms.Label();
            this.lbltextocorrelativo = new System.Windows.Forms.Label();
            this.gpbBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblNumeroRecibo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.gpbrecibo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpblista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.gpbcorrelativo.SuspendLayout();
            this.gpbBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblusuario);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 38);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(318, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusuario.Location = new System.Drawing.Point(12, 9);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(51, 20);
            this.lblusuario.TabIndex = 3;
            this.lblusuario.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.tsmreportes,
            this.correlativoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMenu
            // 
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmmenuprincipal});
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(50, 20);
            this.tsmMenu.Text = "Menu";
            // 
            // tsmmenuprincipal
            // 
            this.tsmmenuprincipal.Name = "tsmmenuprincipal";
            this.tsmmenuprincipal.Size = new System.Drawing.Size(164, 22);
            this.tsmmenuprincipal.Text = "Ir Menu Principal";
            this.tsmmenuprincipal.Click += new System.EventHandler(this.tsmmenuprincipal_Click);
            // 
            // tsmreportes
            // 
            this.tsmreportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmreporteevento});
            this.tsmreportes.Name = "tsmreportes";
            this.tsmreportes.Size = new System.Drawing.Size(65, 20);
            this.tsmreportes.Text = "Reportes";
            // 
            // tsmreporteevento
            // 
            this.tsmreporteevento.Name = "tsmreporteevento";
            this.tsmreporteevento.Size = new System.Drawing.Size(159, 22);
            this.tsmreporteevento.Text = "Reporte Recibos";
            this.tsmreporteevento.Click += new System.EventHandler(this.tsmreporteevento_Click);
            // 
            // correlativoToolStripMenuItem
            // 
            this.correlativoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmModificarCorrelativo});
            this.correlativoToolStripMenuItem.Name = "correlativoToolStripMenuItem";
            this.correlativoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.correlativoToolStripMenuItem.Text = "Correlativo";
            // 
            // tsmModificarCorrelativo
            // 
            this.tsmModificarCorrelativo.Name = "tsmModificarCorrelativo";
            this.tsmModificarCorrelativo.Size = new System.Drawing.Size(186, 22);
            this.tsmModificarCorrelativo.Text = "Modificar Correlativo";
            this.tsmModificarCorrelativo.Click += new System.EventHandler(this.tsmModificarCorrelativo_Click);
            // 
            // gpbrecibo
            // 
            this.gpbrecibo.Controls.Add(this.btnparticipante);
            this.gpbrecibo.Controls.Add(this.txtrecibo);
            this.gpbrecibo.Controls.Add(this.txtobservacion);
            this.gpbrecibo.Controls.Add(this.lblobsevacion);
            this.gpbrecibo.Controls.Add(this.txtcheque);
            this.gpbrecibo.Controls.Add(this.lblcheque);
            this.gpbrecibo.Controls.Add(this.cbxbancos);
            this.gpbrecibo.Controls.Add(this.lblbanco);
            this.gpbrecibo.Controls.Add(this.cbxmodopago);
            this.gpbrecibo.Controls.Add(this.lbltipopago);
            this.gpbrecibo.Controls.Add(this.txttotal);
            this.gpbrecibo.Controls.Add(this.lbltotal);
            this.gpbrecibo.Controls.Add(this.txtcantidad);
            this.gpbrecibo.Controls.Add(this.lblcantidad);
            this.gpbrecibo.Controls.Add(this.txtprecio);
            this.gpbrecibo.Controls.Add(this.lblprecio);
            this.gpbrecibo.Controls.Add(this.cbxconcepto);
            this.gpbrecibo.Controls.Add(this.lblconcepto);
            this.gpbrecibo.Controls.Add(this.txttelefono);
            this.gpbrecibo.Controls.Add(this.lbltelefono);
            this.gpbrecibo.Controls.Add(this.txtnit);
            this.gpbrecibo.Controls.Add(this.lblnit);
            this.gpbrecibo.Controls.Add(this.cbxpais);
            this.gpbrecibo.Controls.Add(this.lblpais);
            this.gpbrecibo.Controls.Add(this.txtdireccion);
            this.gpbrecibo.Controls.Add(this.lbldireccion);
            this.gpbrecibo.Controls.Add(this.txtnombre);
            this.gpbrecibo.Controls.Add(this.lblnombre);
            this.gpbrecibo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbrecibo.Location = new System.Drawing.Point(12, 64);
            this.gpbrecibo.Name = "gpbrecibo";
            this.gpbrecibo.Size = new System.Drawing.Size(737, 295);
            this.gpbrecibo.TabIndex = 4;
            this.gpbrecibo.TabStop = false;
            this.gpbrecibo.Text = "Nuevo Recibo";
            // 
            // btnparticipante
            // 
            this.btnparticipante.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparticipante.Location = new System.Drawing.Point(333, 20);
            this.btnparticipante.Name = "btnparticipante";
            this.btnparticipante.Size = new System.Drawing.Size(104, 26);
            this.btnparticipante.TabIndex = 3;
            this.btnparticipante.Text = "Buscar";
            this.btnparticipante.UseVisualStyleBackColor = true;
            this.btnparticipante.Click += new System.EventHandler(this.btnparticipante_Click);
            // 
            // txtrecibo
            // 
            this.txtrecibo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecibo.Location = new System.Drawing.Point(624, 23);
            this.txtrecibo.Name = "txtrecibo";
            this.txtrecibo.Size = new System.Drawing.Size(100, 23);
            this.txtrecibo.TabIndex = 26;
            this.txtrecibo.Visible = false;
            // 
            // txtobservacion
            // 
            this.txtobservacion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtobservacion.Location = new System.Drawing.Point(162, 254);
            this.txtobservacion.MaxLength = 80;
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(449, 23);
            this.txtobservacion.TabIndex = 25;
            // 
            // lblobsevacion
            // 
            this.lblobsevacion.AutoSize = true;
            this.lblobsevacion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblobsevacion.Location = new System.Drawing.Point(39, 257);
            this.lblobsevacion.Name = "lblobsevacion";
            this.lblobsevacion.Size = new System.Drawing.Size(103, 18);
            this.lblobsevacion.TabIndex = 24;
            this.lblobsevacion.Text = "Observacion";
            // 
            // txtcheque
            // 
            this.txtcheque.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcheque.Location = new System.Drawing.Point(576, 224);
            this.txtcheque.Name = "txtcheque";
            this.txtcheque.Size = new System.Drawing.Size(148, 23);
            this.txtcheque.TabIndex = 23;
            // 
            // lblcheque
            // 
            this.lblcheque.AutoSize = true;
            this.lblcheque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcheque.Location = new System.Drawing.Point(481, 230);
            this.lblcheque.Name = "lblcheque";
            this.lblcheque.Size = new System.Drawing.Size(97, 18);
            this.lblcheque.TabIndex = 22;
            this.lblcheque.Text = "Cheque No.";
            // 
            // cbxbancos
            // 
            this.cbxbancos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxbancos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxbancos.FormattingEnabled = true;
            this.cbxbancos.Location = new System.Drawing.Point(333, 224);
            this.cbxbancos.Name = "cbxbancos";
            this.cbxbancos.Size = new System.Drawing.Size(136, 25);
            this.cbxbancos.TabIndex = 21;
            this.cbxbancos.SelectedIndexChanged += new System.EventHandler(this.cbxbancos_SelectedIndexChanged);
            // 
            // lblbanco
            // 
            this.lblbanco.AutoSize = true;
            this.lblbanco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbanco.Location = new System.Drawing.Point(277, 227);
            this.lblbanco.Name = "lblbanco";
            this.lblbanco.Size = new System.Drawing.Size(56, 18);
            this.lblbanco.TabIndex = 20;
            this.lblbanco.Text = "Banco";
            // 
            // cbxmodopago
            // 
            this.cbxmodopago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxmodopago.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxmodopago.FormattingEnabled = true;
            this.cbxmodopago.Location = new System.Drawing.Point(162, 224);
            this.cbxmodopago.Name = "cbxmodopago";
            this.cbxmodopago.Size = new System.Drawing.Size(105, 25);
            this.cbxmodopago.TabIndex = 19;
            this.cbxmodopago.SelectedIndexChanged += new System.EventHandler(this.cbxmodopago_SelectedIndexChanged);
            // 
            // lbltipopago
            // 
            this.lbltipopago.AutoSize = true;
            this.lbltipopago.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipopago.Location = new System.Drawing.Point(12, 227);
            this.lbltipopago.Name = "lbltipopago";
            this.lbltipopago.Size = new System.Drawing.Size(132, 18);
            this.lbltipopago.TabIndex = 18;
            this.lbltipopago.Text = "Modalidad Pago";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(475, 196);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(136, 23);
            this.txttotal.TabIndex = 17;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(415, 199);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(42, 18);
            this.lbltotal.TabIndex = 16;
            this.lbltotal.Text = "Total";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(162, 196);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(136, 23);
            this.txtcantidad.TabIndex = 15;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(65, 198);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(77, 18);
            this.lblcantidad.TabIndex = 14;
            this.lblcantidad.Text = "Cantidad";
            // 
            // txtprecio
            // 
            this.txtprecio.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(475, 168);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(136, 23);
            this.txtprecio.TabIndex = 13;
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
            this.txtprecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprecio_KeyPress);
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprecio.Location = new System.Drawing.Point(415, 171);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(55, 18);
            this.lblprecio.TabIndex = 12;
            this.lblprecio.Text = "Precio";
            // 
            // cbxconcepto
            // 
            this.cbxconcepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxconcepto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxconcepto.FormattingEnabled = true;
            this.cbxconcepto.Location = new System.Drawing.Point(162, 165);
            this.cbxconcepto.Name = "cbxconcepto";
            this.cbxconcepto.Size = new System.Drawing.Size(229, 25);
            this.cbxconcepto.TabIndex = 11;
            this.cbxconcepto.SelectedIndexChanged += new System.EventHandler(this.cbxconcepto_SelectedIndexChanged);
            // 
            // lblconcepto
            // 
            this.lblconcepto.AutoSize = true;
            this.lblconcepto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconcepto.Location = new System.Drawing.Point(61, 168);
            this.lblconcepto.Name = "lblconcepto";
            this.lblconcepto.Size = new System.Drawing.Size(83, 18);
            this.lblconcepto.TabIndex = 10;
            this.lblconcepto.Text = "Concepto";
            // 
            // txttelefono
            // 
            this.txttelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(162, 137);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(136, 23);
            this.txttelefono.TabIndex = 9;
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltelefono.Location = new System.Drawing.Point(65, 140);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(71, 18);
            this.lbltelefono.TabIndex = 8;
            this.lbltelefono.Text = "Telefono";
            // 
            // txtnit
            // 
            this.txtnit.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnit.Location = new System.Drawing.Point(162, 24);
            this.txtnit.Name = "txtnit";
            this.txtnit.Size = new System.Drawing.Size(136, 23);
            this.txtnit.TabIndex = 1;
            this.txtnit.Text = "C/F";
            // 
            // lblnit
            // 
            this.lblnit.AutoSize = true;
            this.lblnit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnit.Location = new System.Drawing.Point(102, 27);
            this.lblnit.Name = "lblnit";
            this.lblnit.Size = new System.Drawing.Size(29, 18);
            this.lblnit.TabIndex = 6;
            this.lblnit.Text = "NIT";
            // 
            // cbxpais
            // 
            this.cbxpais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxpais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxpais.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxpais.FormattingEnabled = true;
            this.cbxpais.Location = new System.Drawing.Point(162, 107);
            this.cbxpais.Name = "cbxpais";
            this.cbxpais.Size = new System.Drawing.Size(229, 25);
            this.cbxpais.TabIndex = 7;
            this.cbxpais.SelectedIndexChanged += new System.EventHandler(this.cbxpais_SelectedIndexChanged);
            // 
            // lblpais
            // 
            this.lblpais.AutoSize = true;
            this.lblpais.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpais.Location = new System.Drawing.Point(96, 110);
            this.lblpais.Name = "lblpais";
            this.lblpais.Size = new System.Drawing.Size(36, 18);
            this.lblpais.TabIndex = 4;
            this.lblpais.Text = "Pais";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdireccion.Location = new System.Drawing.Point(162, 79);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(449, 23);
            this.txtdireccion.TabIndex = 5;
            // 
            // lbldireccion
            // 
            this.lbldireccion.AutoSize = true;
            this.lbldireccion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldireccion.Location = new System.Drawing.Point(61, 82);
            this.lbldireccion.Name = "lbldireccion";
            this.lbldireccion.Size = new System.Drawing.Size(81, 18);
            this.lbldireccion.TabIndex = 2;
            this.lbldireccion.Text = "Direccion";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(162, 51);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(449, 23);
            this.txtnombre.TabIndex = 3;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(31, 54);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(109, 18);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Recibimos de";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnanular);
            this.groupBox1.Controls.Add(this.btnnuevo);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(755, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 295);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnanular
            // 
            this.btnanular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnanular.Location = new System.Drawing.Point(54, 215);
            this.btnanular.Name = "btnanular";
            this.btnanular.Size = new System.Drawing.Size(121, 44);
            this.btnanular.TabIndex = 2;
            this.btnanular.Text = "Anular";
            this.btnanular.UseVisualStyleBackColor = true;
            this.btnanular.Click += new System.EventHandler(this.btnanular_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(54, 128);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(121, 44);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(54, 39);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(121, 44);
            this.btnguardar.TabIndex = 0;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // gpblista
            // 
            this.gpblista.Controls.Add(this.dgvlistado);
            this.gpblista.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpblista.Location = new System.Drawing.Point(12, 506);
            this.gpblista.Name = "gpblista";
            this.gpblista.Size = new System.Drawing.Size(972, 223);
            this.gpblista.TabIndex = 6;
            this.gpblista.TabStop = false;
            this.gpblista.Text = "Lista de Recibos";
            // 
            // dgvlistado
            // 
            this.dgvlistado.AllowUserToAddRows = false;
            this.dgvlistado.AllowUserToDeleteRows = false;
            this.dgvlistado.AutoGenerateColumns = false;
            this.dgvlistado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlistado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recibo,
            this.recibo_fisico,
            this.Serie,
            this.nombre,
            this.total,
            this.usuario_creacion,
            this.fecha_creacion,
            this.imprimir,
            this.medio_pago});
            this.dgvlistado.DataSource = this.bindingSource1;
            this.dgvlistado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvlistado.Location = new System.Drawing.Point(3, 18);
            this.dgvlistado.Name = "dgvlistado";
            this.dgvlistado.ReadOnly = true;
            this.dgvlistado.RowHeadersVisible = false;
            this.dgvlistado.Size = new System.Drawing.Size(966, 202);
            this.dgvlistado.TabIndex = 0;
            this.dgvlistado.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvlistado_CellClick);
            // 
            // recibo
            // 
            this.recibo.DataPropertyName = "recibo";
            this.recibo.HeaderText = "Recibo";
            this.recibo.Name = "recibo";
            this.recibo.ReadOnly = true;
            this.recibo.Visible = false;
            // 
            // recibo_fisico
            // 
            this.recibo_fisico.DataPropertyName = "recibo_fisico";
            this.recibo_fisico.HeaderText = "Recibo Fisico";
            this.recibo_fisico.Name = "recibo_fisico";
            this.recibo_fisico.ReadOnly = true;
            // 
            // Serie
            // 
            this.Serie.DataPropertyName = "serie_recibo";
            this.Serie.HeaderText = "Serie";
            this.Serie.Name = "Serie";
            this.Serie.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // usuario_creacion
            // 
            this.usuario_creacion.DataPropertyName = "usuario_creacion";
            this.usuario_creacion.HeaderText = "Usuario Creacion";
            this.usuario_creacion.Name = "usuario_creacion";
            this.usuario_creacion.ReadOnly = true;
            // 
            // fecha_creacion
            // 
            this.fecha_creacion.DataPropertyName = "fecha_creacion";
            this.fecha_creacion.HeaderText = "Fecha Creacion";
            this.fecha_creacion.Name = "fecha_creacion";
            this.fecha_creacion.ReadOnly = true;
            // 
            // imprimir
            // 
            this.imprimir.HeaderText = "Imprimir";
            this.imprimir.Name = "imprimir";
            this.imprimir.ReadOnly = true;
            this.imprimir.Text = "Re-Imprimir";
            this.imprimir.UseColumnTextForButtonValue = true;
            // 
            // medio_pago
            // 
            this.medio_pago.DataPropertyName = "medio_pago";
            this.medio_pago.HeaderText = "Medio Pago";
            this.medio_pago.Name = "medio_pago";
            this.medio_pago.ReadOnly = true;
            this.medio_pago.Visible = false;
            // 
            // gpbcorrelativo
            // 
            this.gpbcorrelativo.Controls.Add(this.lblSerie);
            this.gpbcorrelativo.Controls.Add(this.label2);
            this.gpbcorrelativo.Controls.Add(this.lblCorrelativoFisico);
            this.gpbcorrelativo.Controls.Add(this.lbltextocorrelativo);
            this.gpbcorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbcorrelativo.Location = new System.Drawing.Point(12, 359);
            this.gpbcorrelativo.Name = "gpbcorrelativo";
            this.gpbcorrelativo.Size = new System.Drawing.Size(972, 77);
            this.gpbcorrelativo.TabIndex = 7;
            this.gpbcorrelativo.TabStop = false;
            this.gpbcorrelativo.Text = "Correlativo";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.ForeColor = System.Drawing.Color.Crimson;
            this.lblSerie.Location = new System.Drawing.Point(225, 48);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(76, 25);
            this.lblSerie.TabIndex = 3;
            this.lblSerie.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serie a Imprimir:";
            // 
            // lblCorrelativoFisico
            // 
            this.lblCorrelativoFisico.AutoSize = true;
            this.lblCorrelativoFisico.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblCorrelativoFisico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativoFisico.ForeColor = System.Drawing.Color.Crimson;
            this.lblCorrelativoFisico.Location = new System.Drawing.Point(225, 18);
            this.lblCorrelativoFisico.Name = "lblCorrelativoFisico";
            this.lblCorrelativoFisico.Size = new System.Drawing.Size(76, 25);
            this.lblCorrelativoFisico.TabIndex = 1;
            this.lblCorrelativoFisico.Text = "label2";
            // 
            // lbltextocorrelativo
            // 
            this.lbltextocorrelativo.AutoSize = true;
            this.lbltextocorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltextocorrelativo.Location = new System.Drawing.Point(9, 17);
            this.lbltextocorrelativo.Name = "lbltextocorrelativo";
            this.lbltextocorrelativo.Size = new System.Drawing.Size(221, 25);
            this.lbltextocorrelativo.TabIndex = 0;
            this.lbltextocorrelativo.Text = "Correlativo a Imprimir:";
            // 
            // gpbBusqueda
            // 
            this.gpbBusqueda.Controls.Add(this.btnBuscar);
            this.gpbBusqueda.Controls.Add(this.txtBuscar);
            this.gpbBusqueda.Controls.Add(this.lblNumeroRecibo);
            this.gpbBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbBusqueda.Location = new System.Drawing.Point(12, 435);
            this.gpbBusqueda.Name = "gpbBusqueda";
            this.gpbBusqueda.Size = new System.Drawing.Size(969, 71);
            this.gpbBusqueda.TabIndex = 8;
            this.gpbBusqueda.TabStop = false;
            this.gpbBusqueda.Text = "Busqueda de Recibo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(550, 28);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(104, 34);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(301, 34);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(207, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // lblNumeroRecibo
            // 
            this.lblNumeroRecibo.AutoSize = true;
            this.lblNumeroRecibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroRecibo.Location = new System.Drawing.Point(146, 34);
            this.lblNumeroRecibo.Name = "lblNumeroRecibo";
            this.lblNumeroRecibo.Size = new System.Drawing.Size(147, 20);
            this.lblNumeroRecibo.TabIndex = 0;
            this.lblNumeroRecibo.Text = "Correlativo Fisico";
            // 
            // frmReciboEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(996, 741);
            this.Controls.Add(this.gpbBusqueda);
            this.Controls.Add(this.gpbcorrelativo);
            this.Controls.Add(this.gpblista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbrecibo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmReciboEvento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Recibo";
            this.Load += new System.EventHandler(this.frmReciboEvento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbrecibo.ResumeLayout(false);
            this.gpbrecibo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gpblista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlistado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.gpbcorrelativo.ResumeLayout(false);
            this.gpbcorrelativo.PerformLayout();
            this.gpbBusqueda.ResumeLayout(false);
            this.gpbBusqueda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmmenuprincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbrecibo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.ComboBox cbxbancos;
        private System.Windows.Forms.Label lblbanco;
        private System.Windows.Forms.ComboBox cbxmodopago;
        private System.Windows.Forms.Label lbltipopago;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label lblprecio;
        private System.Windows.Forms.ComboBox cbxconcepto;
        private System.Windows.Forms.Label lblconcepto;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.TextBox txtnit;
        private System.Windows.Forms.Label lblnit;
        private System.Windows.Forms.ComboBox cbxpais;
        private System.Windows.Forms.Label lblpais;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label lbldireccion;
        private System.Windows.Forms.TextBox txtcheque;
        private System.Windows.Forms.Label lblcheque;
        private System.Windows.Forms.TextBox txtobservacion;
        private System.Windows.Forms.Label lblobsevacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.GroupBox gpblista;
        private System.Windows.Forms.DataGridView dgvlistado;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnanular;
        private System.Windows.Forms.ToolStripMenuItem tsmreportes;
        private System.Windows.Forms.ToolStripMenuItem tsmreporteevento;
        private System.Windows.Forms.GroupBox gpbcorrelativo;
        private System.Windows.Forms.Label lblCorrelativoFisico;
        private System.Windows.Forms.Label lbltextocorrelativo;
        private System.Windows.Forms.ToolStripMenuItem correlativoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmModificarCorrelativo;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn recibo;
        private System.Windows.Forms.DataGridViewTextBoxColumn recibo_fisico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serie;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario_creacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha_creacion;
        private System.Windows.Forms.DataGridViewButtonColumn imprimir;
        private System.Windows.Forms.DataGridViewTextBoxColumn medio_pago;
        private System.Windows.Forms.GroupBox gpbBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblNumeroRecibo;
        private System.Windows.Forms.TextBox txtrecibo;
        private System.Windows.Forms.Button btnparticipante;
    }
}