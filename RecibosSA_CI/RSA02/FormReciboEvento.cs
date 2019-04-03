using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSA02.Clases;
using RSA02.Model;
using RSA02.DO.DATA;

namespace RSA02
{
    public partial class frmReciboEvento : Form
    {

        #region Propiedades

        public Nullable<decimal> reciboimpresion { get; set; }

        #endregion

        #region Variables

        private bool validaCorrelativoExistente;
        private string mensajeValidacionCorrelativoExistente;

        #endregion

        #region Metodos Privados

        private void llenarListado()
        {
            Recibo lisRecibos = new Recibo();
            Mensaje<List<REC01_RECIBO>> resp = new Mensaje<List<REC01_RECIBO>>();
            resp.data = lisRecibos.listarRecibosActivos().data;

            bindingSource1.DataSource = resp.data;

        }

        private void llenarBusqueda()
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text.ToString()))
            {
                MessageBox.Show("El campo de busqueda se encuentra vacio o contiene un espacio, favor de colocar un dato en el campo");
            }
            else
            {
                Recibo objBusqueda = new Recibo();
                REC01_RECIBO objRecibo = new REC01_RECIBO();
                objRecibo.RECIBO_FISICO = Convert.ToDecimal(txtBuscar.Text);
                Mensaje<List<REC01_RECIBO>> resp = objBusqueda.BusquedaRecibosActivo(objRecibo);

                if (resp.codigo == 0)
                {
                    bindingSource1.DataSource = resp.data;
                }
                else if (resp.codigo == -1)
                {
                    MessageBox.Show(resp.mensaje);
                }
            }
        }

        private void obtenerCorrelativoUsuario()
        {
            //Modificacion 26-07-2018 
            //Se valida si es nulo el campo de texto que guarda el recibo, esto para setear el dato para la busqueda
            // de la informacion que llenara el recibo
            if (string.IsNullOrEmpty(txtrecibo.Text.ToString()))
            {
                Recibo obtener = new Recibo();
                Mensaje<REC01_CORRELATIVO_USUARIO> resp = obtener.obtenerCorrelativoActual();
                Global.correlativousuario = resp.data.CORRELATIVO_DISPONIBLE;
            }
            else
            {
                Global.correlativousuario = Convert.ToDecimal(txtrecibo.Text);
            }

            Global.mediodepago = Convert.ToDecimal(this.cbxmodopago.SelectedValue);
           
        }

        private void obtenerRecibo(REC01_RECIBO rec)
        {
            Recibo dato = new Recibo();
            Mensaje<REC01_RECIBO> resp = dato.obtenerRecibo(rec);

            if (resp.data.MEDIO_PAGO == 1)
            {                
                llenarPaises();
                llenarConceptos();
                llenarMediosPago();                
                lblbanco.Visible = false;
                cbxbancos.Visible = false;
                lblcheque.Visible = false;
                txtcheque.Visible = false;

                txtrecibo.Text = resp.data.RECIBO.ToString(); //En este campo se colocara el dato de recibo cuando ya exista
                txtnombre.Text = resp.data.NOMBRE;
                txtdireccion.Text = resp.data.DIRECCION;
                cbxpais.SelectedValue = resp.data.PAIS;
                txtnit.Text = resp.data.NIT;
                txttelefono.Text = resp.data.TELEFONO;
                cbxconcepto.SelectedValue = Convert.ToDecimal(resp.data.CONCEPTO);
                txtprecio.Text = resp.data.PRECIO.ToString();
                txtcantidad.Text = resp.data.CANTIDAD.ToString();
                txttotal.Text = resp.data.TOTAL.ToString();
                cbxmodopago.SelectedValue = Convert.ToDecimal(resp.data.MEDIO_PAGO);
                txtobservacion.Text = resp.data.OBSERVACION_3;

                //inactivar();
            }
            else if (resp.data.MEDIO_PAGO == 2)
            {                
                llenarPaises();
                llenarConceptos();
                llenarMediosPago();
                llenarBancos();
                lblbanco.Visible = true;
                cbxbancos.Visible = true;
                lblcheque.Visible = true;
                txtcheque.Visible = true;

                txtrecibo.Text = resp.data.RECIBO.ToString(); //En este campo se colocara el dato de recibo cuando ya exista
                txtnombre.Text = resp.data.NOMBRE;
                txtdireccion.Text = resp.data.DIRECCION;
                cbxpais.SelectedValue = resp.data.PAIS;
                txtnit.Text = resp.data.NIT;
                txttelefono.Text = resp.data.TELEFONO;
                cbxconcepto.SelectedValue = Convert.ToDecimal(resp.data.CONCEPTO);
                txtprecio.Text = resp.data.PRECIO.ToString();
                txtcantidad.Text = resp.data.CANTIDAD.ToString();
                txtcantidad.Text = resp.data.TOTAL.ToString();
                cbxmodopago.SelectedValue = Convert.ToDecimal(resp.data.MEDIO_PAGO);
                cbxbancos.SelectedValue = Convert.ToDecimal(resp.data.BANCO);
                txtcheque.Text = resp.data.NUMERO_CHEQUE;
                txtobservacion.Text = resp.data.OBSERVACION_3;

                //inactivar();
            }
        }

        private void llenarPaises()
        {
            Recibo paises = new Recibo();
            Mensaje<List<REC01_PAIS>> resp = paises.listarPaisesActivos();
                        
            cbxpais.DisplayMember = "descripcion";
            cbxpais.ValueMember = "pais";
            cbxpais.DataSource = resp.data;

            if (cbxpais.Items.Count > 0)
            {
                cbxpais.SelectedIndex = -1;
            }

            cbxpais.AutoCompleteCustomSource = paises.AutocompletarUsuarios();
            cbxpais.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbxpais.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void llenarConceptos()
        {
            Recibo concepto = new Recibo();
            Mensaje<List<REC01_CONCEPTO>> li = new Mensaje<List<REC01_CONCEPTO>>();
            li.data = concepto.listarConceptosActivos().data;

            cbxconcepto.DisplayMember = "descripcion";
            cbxconcepto.ValueMember = "concepto";
            cbxconcepto.DataSource = li.data;

            if (cbxconcepto.Items.Count > 0)
            {
                cbxconcepto.SelectedIndex = -1;
            }
        }

        private void llenarMediosPago()
        {
            Recibo medio = new Recibo();
            Mensaje<List<REC01_MEDIO_PAGO>> resp = new Mensaje<List<REC01_MEDIO_PAGO>>();
            resp.data = medio.listarMedioPagoActivos().data;
                        
            cbxmodopago.DisplayMember = "descripcion";
            cbxmodopago.ValueMember = "medio_pago";
            cbxmodopago.DataSource = resp.data;

            if (cbxmodopago.Items.Count > 0)
            {
                cbxmodopago.SelectedIndex = -1;
            }
        }

        private void llenarBancos()
        {
            Recibo entidad = new Recibo();
            Mensaje<List<REC01_BANCO>> resp = new Mensaje<List<REC01_BANCO>>();
            resp.data = entidad.listarBancosActivos().data;

            cbxbancos.DisplayMember = "nombre";
            cbxbancos.ValueMember = "banco";
            cbxbancos.DataSource = resp.data;

            if (cbxbancos.Items.Count > 0)
            {
                cbxbancos.SelectedIndex = -1;
            }
        }

        private void obtenerConcepto(decimal id)
        {            
            Recibo concepto = new Recibo();
            Mensaje<REC01_CONCEPTO> resp = new Mensaje<REC01_CONCEPTO>();
            resp = concepto.obtenerConcepto(id);

            if (resp.data.PRECIO != 0)
            {
                lblprecio.Visible = true;
                txtprecio.Visible = true;
                txtprecio.Enabled = false;
                txtprecio.Text = resp.data.PRECIO.ToString();
                calculartotal();
                txtcantidad.Focus();
            }
            else if (resp.data.PRECIO == null || resp.data.PRECIO == 0)
            {
                lblprecio.Visible = true;
                txtprecio.Visible = true;
                txtprecio.Enabled = true;
                txtprecio.Text = "";
                txtprecio.Focus();   
            }
        }

        private void obtenerMedioPago(decimal id)
        {
            Recibo banco = new Recibo();
            Mensaje<REC01_MEDIO_PAGO> resp = new Mensaje<REC01_MEDIO_PAGO>();
            resp = banco.obtenerModoPago(id);

            if (resp.data.MEDIO_PAGO == 2)
            {
                lblbanco.Visible = true;
                cbxbancos.Visible = true;
                lblcheque.Visible = true;
                txtcheque.Visible = true;
            }
            else
            {
                lblbanco.Visible = false;
                cbxbancos.Visible = false;
                lblcheque.Visible = false;
                txtcheque.Visible = false;
                txtcheque.Text = "";
                if (cbxbancos.Items.Count > 0)
                {
                    cbxbancos.SelectedIndex = -1;
                }
            }
        }

        private void calculartotal()
        {
            decimal precio;
            decimal cantidad;

            if (txtprecio.Text == null || txtprecio.Text == "" || txtprecio.Text == ".")
            {
                precio = 0;
            }
            else
            {
                precio = Convert.ToDecimal(txtprecio.Text);
            }

            if (txtcantidad.Text == null || txtcantidad.Text == "" || txtcantidad.Text == ".")
            {
                cantidad = 0;
            }
            else
            {
                cantidad = Convert.ToDecimal(txtcantidad.Text);
            }

            decimal total = precio * cantidad;
            txttotal.Text = total.ToString();
        }

        private void nuevoregistro()
        {
            llenarPaises();
            llenarConceptos();
            llenarMediosPago();
            llenarBancos();
            llenarListado();
            lblbanco.Visible = false;
            cbxbancos.Visible = false;
            lblcheque.Visible = false;
            txtcheque.Visible = false;
            txtrecibo.Text = "";
            txtnombre.Text = "";
            txtdireccion.Text = "";
            txtnit.Text = "";
            txttelefono.Text = "";
            txtprecio.Text = "";
            txtcantidad.Text = "";
            txtcheque.Text = "";
            txtobservacion.Text = "";
            txtBuscar.Text = "";

            if (cbxpais.Items.Count > 0)
            {
                cbxpais.SelectedIndex = -1;
            }
            if (cbxconcepto.Items.Count > 0)
            {
                cbxconcepto.SelectedIndex = -1;
            }
            if (cbxmodopago.Items.Count > 0)
            {
                cbxmodopago.SelectedIndex = -1;
            }
            if (cbxbancos.Items.Count > 0)
            {
                cbxbancos.SelectedIndex = -1;
            }
            lblprecio.Visible = false;
            txtprecio.Visible = false;
            btnanular.Visible = false;
            btnguardar.Enabled = true;
            activar();
            txtnit.Text = "C/F";
            txtnit.Focus();
        }

        private void inactivar()
        {
            txtnombre.Enabled = false;
            txtdireccion.Enabled = false;
            cbxpais.Enabled = false;
            txtnit.Enabled = false;
            txttelefono.Enabled = false;
            cbxconcepto.Enabled = false;
            txtprecio.Enabled = false;
            txtcantidad.Enabled = false;
            txttotal.Enabled = false;
            cbxmodopago.Enabled = false;
            cbxbancos.Enabled = false;
            txtcheque.Enabled = false;
            txtobservacion.Enabled = false;
        }

        private void activar()
        {
            txtnombre.Enabled = true;
            txtdireccion.Enabled = true;
            cbxpais.Enabled = true;
            txtnit.Enabled = true;
            txttelefono.Enabled = true;
            cbxconcepto.Enabled = true;            
            txtcantidad.Enabled = true;            
            cbxmodopago.Enabled = true;
            cbxbancos.Enabled = true;
            txtcheque.Enabled = true;
            txtobservacion.Enabled = true;
        }

        private void RegistrarNuevoRecibo()
        {
            REC01_CORRELATIVO_RECIBO objcorrelativo = new REC01_CORRELATIVO_RECIBO();
            Recibo objrecibo = new Recibo();
            Mensaje<REC01_CORRELATIVO_RECIBO> objresp = objrecibo.obtenerCorrelativoFisico();

            if ((objresp.data.CORRELATIVO_FINAL < objresp.data.CORRELATIVO_ACTUAL) && string.IsNullOrEmpty(txtrecibo.Text.ToString()))
            {
                MessageBox.Show("Se ha terminado Rango de Correlativos Fisicos, Favor de Proceder a Modificar los rangos en el Mantenimiento de Correlativos para continuar");
            }
            else if (string.IsNullOrWhiteSpace(txtnit.Text.ToString()))
            {
                MessageBox.Show("El campo de Nit se encuentra vacio o contiene un espacio, sino tiene un nit colocar C/F");
                txtnit.Focus();
            }
            else if ( string.IsNullOrWhiteSpace(txtnombre.Text.ToString()))
            {
                MessageBox.Show("El campo de Nombre se encuentra vacio o contiene un espacio, favor de colocar un dato en el campo");
                txtnombre.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtdireccion.Text.ToString()))
            {
                MessageBox.Show("El campo de Dirección se encuentra vacio o contiene un espacio, favor de colocar un dato en el campo");
                txtdireccion.Focus();
            }
            else if (cbxpais.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor de ingresar el dato de un Pais");
                cbxpais.Focus();
            }
            else if (cbxconcepto.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor de ingresar el dato de un Concepto");
                cbxconcepto.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtprecio.Text.ToString()))
            {
                MessageBox.Show("El campo de Precio se encuentra vacio o contiene un espacio, favor de colocar un dato en el campo");
                txtprecio.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtcantidad.Text.ToString()))
            {
                MessageBox.Show("El campo de Cantidad se encuentra vacio o contiene un espacio, favor de colocar un dato en el campo");
                txtcantidad.Focus();
            }
            else
            {
                guardarRecibo();

                if (validaCorrelativoExistente)
                {
                    MessageBox.Show(mensajeValidacionCorrelativoExistente);
                }
                else
                {
                    llenarListado();
                    frmVistaPrevia nfvp = new frmVistaPrevia();
                    nfvp.recibo = Global.correlativousuario;
                    nfvp.usuario = Global.usuariologueado;
                    nfvp.medio_pago = Global.mediodepago;
                    this.Hide();
                    nfvp.ShowDialog();
                    this.Close();
                }
            }
        }

        private void guardarRecibo()
        {
            REC01_RECIBO nuevoRecibo = new REC01_RECIBO();
            if (!string.IsNullOrEmpty(txtrecibo.Text.ToString()))
            {
                nuevoRecibo.RECIBO = Convert.ToDecimal(this.txtrecibo.Text);
            }
            nuevoRecibo.NOMBRE = this.txtnombre.Text.ToString();
            nuevoRecibo.DIRECCION = this.txtdireccion.Text.ToString();
            nuevoRecibo.NIT = this.txtnit.Text.ToString().ToUpper();
            nuevoRecibo.TELEFONO = this.txttelefono.Text.ToString();
            nuevoRecibo.MEDIO_PAGO = Convert.ToDecimal(this.cbxmodopago.SelectedValue);
            nuevoRecibo.BANCO = Convert.ToDecimal(this.cbxbancos.SelectedValue);
            nuevoRecibo.NUMERO_CHEQUE = this.txtcheque.Text;
            nuevoRecibo.CONCEPTO = Convert.ToDecimal(this.cbxconcepto.SelectedValue);
            nuevoRecibo.TOTAL = Convert.ToDecimal(this.txttotal.Text);
            nuevoRecibo.PRECIO = Convert.ToDecimal(this.txtprecio.Text);
            nuevoRecibo.CANTIDAD = Convert.ToDecimal(this.txtcantidad.Text);
            nuevoRecibo.PAIS = this.cbxpais.SelectedValue.ToString();
            nuevoRecibo.OBSERVACION_3 = this.txtobservacion.Text;

            Recibo guardar = new Recibo();
            Mensaje<Recibo> resp = guardar.registrarRecibo(nuevoRecibo);

            if (resp.codigo == -2)
            {
                validaCorrelativoExistente = true;
                mensajeValidacionCorrelativoExistente = resp.mensaje;
            }
            else if (resp.codigo == 1)
            {
                validaCorrelativoExistente = false;
                nuevoregistro();
            }            
        }

        private void mostrarCorrelativoFisico()
        {
            REC01_CORRELATIVO_RECIBO objcorrelativo = new REC01_CORRELATIVO_RECIBO();
            Recibo objrecibo = new Recibo();
            Mensaje<REC01_CORRELATIVO_RECIBO> objresp = objrecibo.obtenerCorrelativoFisico();

            if (objresp.data.CORRELATIVO_ACTUAL <= objresp.data.CORRELATIVO_FINAL)
            {
                //SE PASA EL VALOR DEL CORRELATIVO PROXIMO A IMPRIMIR
                lblCorrelativoFisico.Text = objresp.data.CORRELATIVO_ACTUAL.ToString();
                lblSerie.Text = objresp.data.SERIE.ToString().ToUpper();
                //SE PASA EL VALOR DE LA SERIE A LA VARIABLE GLOBAL
                Global.serieActiva = objresp.data.SERIE;
            }
            else
            {
                lblCorrelativoFisico.AutoSize = true;
                lblCorrelativoFisico.Text = "No existe Correlativo Disponible";
                lblSerie.Text = "No existe Serie Disponible";
            }
        }

        //SE AGREGA NUEVA FUNCIONALIDAD PARA REALIZAR BUSQUEDA DE PARTICIPANTES
        private void buscarParticipante()
        {
            /********************
             SE AGREGA EL METODO BUSCAR POR NIT PARA QUE CARGUE LA INFORMACION DE UN PARTICIPANTE EXISTENTE
             FECHA 24/10/2018
             ********************/

            Participante objParticipante = new Participante();
            objParticipante.nit = txtnit.Text;
            Mensaje<Participante> respuesta = objParticipante.obtenerParticipante();

            if (string.IsNullOrWhiteSpace(txtnit.Text.ToString()))
            {
                MessageBox.Show("El campo de Nit esta vacio, escriba un nit para realizar la busqueda");
                txtnit.Focus();
            }
            else
            {
                if (respuesta.codigo != 0)
                {
                    MessageBox.Show(respuesta.mensaje);                    
                    txtnombre.Focus();
                }
                else
                {
                    txtnombre.Text = respuesta.data.nombre;
                    txtdireccion.Text = respuesta.data.direccion;
                    cbxpais.SelectedValue = respuesta.data.pais;
                    txtnit.Text = respuesta.data.nit;
                    txttelefono.Text = respuesta.data.telefono;
                    cbxconcepto.Focus();
                }
            }
        }

        #endregion

        #region Eventos

        public frmReciboEvento()
        {
            InitializeComponent();
        }

        private void frmReciboEvento_Load(object sender, EventArgs e)
        {
            lblusuario.Text = "Bienvenido " + Global.usuariologueado.ToString();
            label1.Text = "Evento " + Global.nombreeventoActivo.ToUpper();

            
            llenarListado();
            llenarPaises();
            llenarConceptos();
            llenarMediosPago();
            llenarBancos();
            mostrarCorrelativoFisico();

            lblprecio.Visible = false;
            txtprecio.Visible = false;
            lblbanco.Visible = false;
            cbxbancos.Visible = false;
            lblcheque.Visible = false;
            txtcheque.Visible = false;
            btnanular.Visible = false;

            txttotal.Enabled = false;
            

            //Se agrega esta opcion para llenar los datos que vienen del boton "Modificar" de la pantalla de impresion
            if (reciboimpresion != null)
            {
                REC01_RECIBO rec = new REC01_RECIBO();
                rec.RECIBO = reciboimpresion;
                rec.USUARIO_CREACION = Global.usuariologueado;
                //
                obtenerRecibo(rec);
            }
            

        }

        private void tsmmenuprincipal_Click(object sender, EventArgs e)
        {
            Global.eventoActivo = 0;
            frmPrincipal fp = new frmPrincipal();
            this.Hide();
            fp.ShowDialog();
            this.Close();
        }

        private void cbxconcepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerConcepto(Convert.ToDecimal(cbxconcepto.SelectedValue));
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {            
            calculartotal();
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.NumeroDecimal(e,txtcantidad);
        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {
            calculartotal();
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.NumeroDecimal(e, txtprecio);
        }

        private void cbxpais_SelectedIndexChanged(object sender, EventArgs e)
        {
            txttelefono.Focus();
        }

        private void cbxmodopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            obtenerMedioPago(Convert.ToDecimal(cbxmodopago.SelectedValue));

        }

        private void cbxbancos_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcheque.Focus();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            nuevoregistro();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            obtenerCorrelativoUsuario();
            RegistrarNuevoRecibo();

        }

        private void dgvlistado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.ColumnIndex != 7)
            {
                REC01_RECIBO obj = new REC01_RECIBO();
                obj.RECIBO = Convert.ToDecimal(dgvlistado.CurrentRow.Cells[0].Value);
                obj.USUARIO_CREACION = dgvlistado.CurrentRow.Cells[5].Value.ToString();
                obtenerRecibo(obj);
                txtnombre.Focus();
                btnanular.Visible = true;
                btnguardar.Enabled = true;
            }
            else if (e.ColumnIndex == 7)
            {
                DataGridViewRow dgv = dgvlistado.Rows[e.RowIndex];

                frmVistaPrevia vp = new frmVistaPrevia();
                vp.recibo = Convert.ToDecimal(dgv.Cells[0].Value);
                vp.usuario = dgv.Cells[5].Value.ToString();
                vp.medio_pago = Convert.ToDecimal(dgv.Cells[8].Value);
                this.Hide();
                vp.ShowDialog();
                this.Close();
            }
        }

        private void btnanular_Click(object sender, EventArgs e)
        {
            frmAnulacion fan = new frmAnulacion();
            fan.recibo = Convert.ToDecimal(dgvlistado.CurrentRow.Cells[0].Value);
            fan.usuario = dgvlistado.CurrentRow.Cells[5].Value.ToString();
            this.Hide();
            fan.ShowDialog();
            this.Close();
        }

        private void tsmreporteevento_Click(object sender, EventArgs e)
        {
            frmReporteEvento fre = new frmReporteEvento();
            fre.ShowDialog();
        }

        private void tsmModificarCorrelativo_Click(object sender, EventArgs e)
        {
            frmMantCorrelativo fmc = new frmMantCorrelativo();
            this.Hide();
            fmc.ShowDialog();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            llenarBusqueda();
            inactivar();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Global.NumeroDecimal(e, txtBuscar);
        }

        private void btnparticipante_Click(object sender, EventArgs e)
        {
            buscarParticipante();
        }

        #endregion

        
    }
}
