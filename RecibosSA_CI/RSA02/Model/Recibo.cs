using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSA02.DO.DATA;
using RSA02.Clases;
using System.Windows.Forms;
using System.Transactions;

namespace RSA02.Model
{
    public class Recibo
    {

        public decimal? recibo { get; set; }
        public string usuario { get; set; }
        public decimal medio_pago { get; set; }

        #region constantes

        private const string _sqlrecibo = @"select to_char(rec.fecha_creacion,'dd/mm/yyyy') fecha, total, rec.nombre,
                                            nit, direccion, telefono, medio_pago, numero_cheque, ba.nombre banco, rec.total_letras,
                                            cantidad||decode(rec.cantidad,1,' ofrenda por ',' ofrenda por ')||
                                            co.descripcion observacion_1,                                            
                                            'Pais: '||pa.descripcion||'. ' observacion_2,
                                            observacion_3 observacion_3
                                            from rec01_recibo rec, rec01_pais pa, rec01_concepto co, rec01_banco ba
                                            where rec.pais = pa.pais
                                            and rec.concepto = co.concepto
                                            and rec.banco = ba.banco(+)
                                            and rec.estado_registro = 'A'
                                            and rec.recibo = :recibo
                                            and rec.usuario_creacion = :usuario";

        #endregion

        #region Metodos Publicos
        
        /// <summary>
        /// Metodo que retorna todos los Paises Activos - llena el combo de la pantalla del recibo
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_PAIS>> listarPaisesActivos()
        {
            Mensaje<List<REC01_PAIS>> result = new Mensaje<List<REC01_PAIS>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Paises";
            result.data = new List<REC01_PAIS>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from li in db.REC01_PAIS.Where(a => a.ESTADO_REGISTRO == "A").OrderBy(a => a.DESCRIPCION) select li).ToList();

                    if (list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            result.data.Add(item);
                        }
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existen Paises Registrados que mostrar, ir al Mantenimiento de Paises";
                        result.data = new List<REC01_PAIS>();
                        return result;
                    }
                    result.codigo = 0;
                    result.mensaje = "Ok";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }

        }

        /// <summary>
        /// Metodo que se utiliza para autocompletar paises del combo del Recibo
        /// </summary>
        /// <returns></returns>
        public AutoCompleteStringCollection AutocompletarUsuarios()
        {
            Recibo objlistar = new Recibo();
            Mensaje<List<REC01_PAIS>> li = new Mensaje<List<REC01_PAIS>>();
            li.data = objlistar.listarPaisesActivos().data;

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            foreach (var item in li.data)
            {
                coleccion.Add(item.DESCRIPCION);
            }
            return coleccion;
        }

        /// <summary>
        /// Metodo que retorna todos los Conceptos Activos - llena el combo de la pantalla del recibo
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_CONCEPTO>> listarConceptosActivos()
        {
            Mensaje<List<REC01_CONCEPTO>> result = new Mensaje<List<REC01_CONCEPTO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Conceptos";
            result.data = new List<REC01_CONCEPTO>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from li in db.REC01_CONCEPTO.Where(a => a.ESTADO_REGISTRO == "A").OrderBy(a => a.CONCEPTO) select li).ToList();

                    if (list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            result.data.Add(item);
                        }
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existen Conceptos Registrados que mostrar, ir al Mantenimiento de Conceptos";
                        result.data = new List<REC01_CONCEPTO>();
                        return result;
                    }
                    result.codigo = 0;
                    result.mensaje = "Ok";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }

        }

        /// <summary>
        /// Metodo que retorna informacion de un Concepto Activo
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public Mensaje<REC01_CONCEPTO> obtenerConcepto(decimal con)
        {
            Mensaje<REC01_CONCEPTO> result = new Mensaje<REC01_CONCEPTO>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener el Concepto";
            result.data = new REC01_CONCEPTO();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var concep = (from li in db.REC01_CONCEPTO
                                where li.CONCEPTO == con
                                && li.ESTADO_REGISTRO == "A"
                                select li).SingleOrDefault();

                    if (concep != null)
                    {
                        result.data = concep;
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe informacion del concepto enviado";
                        result.data = new REC01_CONCEPTO();
                        return result;
                    }
                    result.codigo = 0;
                    result.mensaje = "Ok";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }

        }

        /// <summary>
        /// Metodo que retorna informacion de un Modo de Pago
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public Mensaje<REC01_MEDIO_PAGO> obtenerModoPago(decimal con)
        {
            Mensaje<REC01_MEDIO_PAGO> result = new Mensaje<REC01_MEDIO_PAGO>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener el Modo de Pago";
            result.data = new REC01_MEDIO_PAGO();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var concep = (from li in db.REC01_MEDIO_PAGO
                                  where li.MEDIO_PAGO == con
                                  && li.ESTADO_REGISTRO == "A"
                                  select li).SingleOrDefault();

                    if (concep != null)
                    {
                        result.data = concep;
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe informacion del Modo de Pago enviado";
                        result.data = new REC01_MEDIO_PAGO();
                        return result;
                    }
                    result.codigo = 0;
                    result.mensaje = "Ok";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }

        }

        /// <summary>
        /// Metodo que retorna todos los Medios de Pago Activos - llena el combo de la pantalla del recibo
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_MEDIO_PAGO>> listarMedioPagoActivos()
        {
            Mensaje<List<REC01_MEDIO_PAGO>> result = new Mensaje<List<REC01_MEDIO_PAGO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Tipos de Pago";
            result.data = new List<REC01_MEDIO_PAGO>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from li in db.REC01_MEDIO_PAGO.Where(a => a.ESTADO_REGISTRO == "A").OrderBy(a => a.MEDIO_PAGO) select li).ToList();

                    if (list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            result.data.Add(item);
                        }
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existen Medios de Pago Registrados que mostrar, ir al Mantenimiento de Medios de Pago";
                        result.data = new List<REC01_MEDIO_PAGO>();
                        return result;
                    }
                    result.codigo = 0;
                    result.mensaje = "Ok";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }

        }

        /// <summary>
        /// Metodo que retorna todos los Bancos Activos - llena el combo de la pantalla del recibo
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_BANCO>> listarBancosActivos()
        {
            Mensaje<List<REC01_BANCO>> result = new Mensaje<List<REC01_BANCO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Bancos";
            result.data = new List<REC01_BANCO>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from li in db.REC01_BANCO.Where(a => a.ESTADO_REGISTRO == "A").OrderBy(a => a.BANCO) select li).ToList();

                    if (list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            result.data.Add(item);
                        }
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existen Bancos Registrados que mostrar, ir al Mantenimiento de Medios de Pago";
                        result.data = new List<REC01_BANCO>();
                        return result;
                    }
                    result.codigo = 0;
                    result.mensaje = "Ok";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }

        }

        /// <summary>
        /// Metodo que retorna todos los Recibos Activos - llena el DataGridView de la pantalla del recibo
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_RECIBO>> listarRecibosActivos()
        {
            Mensaje<List<REC01_RECIBO>> result = new Mensaje<List<REC01_RECIBO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Recibos";
            result.data = new List<REC01_RECIBO>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from li in db.REC01_RECIBO.Include("REC01_CONCEPTO").Where(a => a.ESTADO_REGISTRO == "A" && a.USUARIO_CREACION == Global.usuariologueado && a.EVENTO == Global.eventoActivo).OrderByDescending(a => a.RECIBO) select li).ToList();

                    if (list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            result.data.Add(item);
                        }
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existen Recibos relacionados con este Usuario";
                        result.data = new List<REC01_RECIBO>();
                        return result;
                    }
                    result.codigo = 0;
                    result.mensaje = "Ok";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }

        }

        /// <summary>
        /// Metodo que retorna informacion de un recibo y se utiliza para la opcion de Busqueda en la pantalla de Recibo Evento
        /// </summary>
        /// <param name="re"></param>
        /// <returns></returns>
        public Mensaje<List<REC01_RECIBO>> BusquedaRecibosActivo(REC01_RECIBO re)
        {
            Mensaje<List<REC01_RECIBO>> result = new Mensaje<List<REC01_RECIBO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Recibos";
            result.data = new List<REC01_RECIBO>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from li in db.REC01_RECIBO.Include("REC01_CONCEPTO").Where(a => a.RECIBO_FISICO == re.RECIBO_FISICO && a.ESTADO_REGISTRO == "A").OrderByDescending(a => a.RECIBO) select li).ToList();

                    if (list.Count > 0)
                    {
                        foreach (var item in list)
                        {
                            result.data.Add(item);
                        }
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existen Recibos relacionados con este Correlativo";
                        result.data = new List<REC01_RECIBO>();
                        return result;
                    }
                    result.codigo = 0;
                    result.mensaje = "Ok";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }

        }

        /// <summary>
        /// Metodo que retorna informacion de un Recibo
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        public Mensaje<REC01_RECIBO> obtenerRecibo(REC01_RECIBO rec)
        {
            Mensaje<REC01_RECIBO> result = new Mensaje<REC01_RECIBO>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener el Recibo";
            result.data = new REC01_RECIBO();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var concep = (from li in db.REC01_RECIBO
                                  where li.RECIBO == rec.RECIBO
                                  && li.USUARIO_CREACION.ToUpper() == rec.USUARIO_CREACION.ToUpper()
                                  && li.ESTADO_REGISTRO == "A"
                                  select li).SingleOrDefault();

                    if (concep != null)
                    {
                        result.data = concep;
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe informacion del Recibo enviado";
                        result.data = new REC01_RECIBO();
                        return result;
                    }
                    result.codigo = 0;
                    result.mensaje = "Ok";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }

        }

        /// <summary>
        /// Metodo que retorna Correlativo Actual del Usuario Logueado
        /// </summary>
        /// <returns></returns>
        public Mensaje<REC01_CORRELATIVO_USUARIO> obtenerCorrelativoActual()
        {
            Mensaje<REC01_CORRELATIVO_USUARIO> result = new Mensaje<REC01_CORRELATIVO_USUARIO>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener el Correlativo";
            result.data = new REC01_CORRELATIVO_USUARIO();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var concep = (from li in db.REC01_CORRELATIVO_USUARIO
                                  where li.USUARIO.ToUpper() == Global.usuariologueado.ToUpper()
                                  && li.ESTADO_REGISTRO == "A"
                                  select li).SingleOrDefault();

                    if (concep != null)
                    {
                        result.data = concep;
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe informacion del Correlativo enviado";
                        result.data = new REC01_CORRELATIVO_USUARIO();
                        return result;
                    }
                    result.codigo = 0;
                    result.mensaje = "Ok";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }

        }

        /// <summary>
        /// Metodo para Registra los Recibos Nuevos
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        public Mensaje<Recibo> registrarRecibo(REC01_RECIBO rec)
        {
            Mensaje<Recibo> resultado = new Mensaje<Recibo>();
            resultado.codigo = 1;
            resultado.mensaje = "Ocurrio un error en la Conexion a la Base de Datos";
            resultado.data = new Recibo();

            try
            {

                //AL MOMENTO DE GUARDAR SE VALIDA SI EL PARTICIPANTE EXISTE EN BD
                Participante validar = new Participante();
                Mensaje<Participante> respValida = validar.validaInfoParticipante(rec);//SE AGREGA METODO PARA AGREGAR O ACTUALIZAR PARTICIPANTE - FECHA 24/10/2018


                if (respValida.codigo != 0)
                {
                    resultado.codigo = respValida.codigo;
                    resultado.mensaje = respValida.mensaje;
                    resultado.mensajeError = respValida.mensajeError;
                    return resultado;
                }
                else
                {
                    if (rec.RECIBO != null)//Si el Recibo esta lleno, se Actualiza
                    {
                        Mensaje<Recibo> resp = new Mensaje<Recibo>();
                        Recibo r = new Recibo();
                        resp = r.ActualizarRecibo(rec);
                        resultado.codigo = resp.codigo;
                        resultado.mensaje = resp.mensaje;
                        resultado.data = resp.data;
                        resultado.mensajeError = resp.mensajeError;
                        return resultado;
                    }
                    else // Si el objeto esta Vacio, Se Inserta
                    {
                        Mensaje<Recibo> resp = new Mensaje<Recibo>();
                        Recibo r = new Recibo();
                        resp = r.NuevoRecibo(rec);
                        resultado.codigo = resp.codigo;
                        resultado.mensaje = resp.mensaje;
                        resultado.data = resp.data;
                        resultado.mensajeError = resp.mensajeError;
                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                resultado.codigo = -1;
                resultado.mensaje = "Ocurrio una excepcion, Referencia: " + ex.ToString();
                resultado.mensajeError = ex.ToString();
                return resultado;
            }
        }

        /// <summary>
        /// Metodo que obtiene la informacion de un recibo para llenar el Reporte de Impresion
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        public List<reciboEntidad> obtenerRecibo()
        {
            List<reciboEntidad> result = new List<reciboEntidad>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    StringBuilder sql = new StringBuilder();
                    sql.Append(_sqlrecibo);

                    var resp = db.Database.SqlQuery<reciboEntidad>(sql.ToString(), new object[] { recibo, usuario }).ToList<reciboEntidad>();

                    result = resp;
                }
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Metodo para Anular recibo
        /// </summary>
        /// <param name="re"></param>
        /// <returns></returns>
        public Mensaje<Recibo> AnularRecibo(REC01_ANULACION re)
        {
            Mensaje<Recibo> result = new Mensaje<Recibo>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos al tratar de Anular el Recibo";
            result.data = new Recibo();

            try
            {
                using (var trans = new TransactionScope())
                {
                    using (var db = new EsquemaREC01())
                    {
                        //Se valida que exista el Reicibo
                        REC01_RECIBO validaRecibo = (from r in db.REC01_RECIBO
                                                     where r.RECIBO == re.RECIBO
                                                     && r.USUARIO_CREACION.ToUpper() == re.USUARIO_CREACION.ToUpper()
                                                     select r).FirstOrDefault();
                        if (validaRecibo==null)
                        {
                            result.codigo = -1;
                            result.mensaje = "No existe el recibo indicado";
                            return result;
                        }
                        
                        validaRecibo.ESTADO_REGISTRO = "N";
                        validaRecibo.USUARIO_MODIFICACION = Global.usuariologueado;
                        validaRecibo.FECHA_MODIFICACION = DateTime.Now;
                        //Se procede a modificar el estado_registro del Recibo
                        int res = db.SaveChanges();
                        if (res <= 0)
                        {
                            Transaction.Current.Rollback();
                            result.codigo = 2;
                            result.mensaje = "No fue posible Cambiar el estado del Recibo";
                            return result;
                        }

                        //Se obtiene el valor del correlativo de la tabla REC01_ANULACION para ser utilizado como identificador de Anulacion
                        var valAnulado = (from a in db.REC01_ANULACION select a.ANULACION).ToList();
                        decimal corrAnulado = 0;

                        if (valAnulado.Count > 0)
                        {
                            corrAnulado = valAnulado.Max() + 1;
                        }
                        else
                        {
                            corrAnulado = 1;
                        }

                        REC01_ANULACION nuevaAnulacion = new REC01_ANULACION()
                        {
                            ANULACION = corrAnulado,
                            RECIBO = re.RECIBO,
                            USUARIO_CREACION = re.USUARIO_CREACION,
                            MOTIVO = re.MOTIVO,
                            RECIBO_FISICO = re.RECIBO_FISICO,
                            SERIE = re.SERIE.ToUpper(),
                            ESTADO_REGISTRO = "A",
                            USUARIO_ANULACION = Global.usuariologueado,
                            FECHA_ANULACION = DateTime.Now
                        };

                        db.REC01_ANULACION.Add(nuevaAnulacion);
                        res = db.SaveChanges();
                        if (res <= 0)
                        {
                            Transaction.Current.Rollback();
                            result.codigo = 2;
                            result.mensaje = "No fue posible registrar la Anulacion";
                            return result;
                        }
                    }
                    trans.Complete();
                    result.codigo = 0;
                    result.mensaje = "Se Anulo el Recibo de forma Exitosa...!!!";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion al tratar de Anular el Recibo, Referencia " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        /// <summary>
        /// Metodo que registra o actualiza el rango de correlativos fisicos para un Evento en Especifico por un Usuario en Sesion
        /// </summary>
        /// <param name="co"></param>
        /// <returns></returns>
        public Mensaje<Recibo> guardarCorrelativoFisico(REC01_CORRELATIVO_RECIBO co)
        {
            Mensaje<Recibo> result = new Mensaje<Recibo>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en Base de Datos al actualizar el correlativo fisico";
            result.data = new Recibo();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    REC01_CORRELATIVO_RECIBO correlativoActual = (from c in db.REC01_CORRELATIVO_RECIBO
                                                                  where c.EVENTO == Global.eventoActivo
                                                                  && c.USUARIO == Global.usuariologueado
                                                                  select c).SingleOrDefault();
                    if (correlativoActual == null)
                    {
                        REC01_CORRELATIVO_RECIBO nuevoCorrelativo = new REC01_CORRELATIVO_RECIBO()
                        {
                            EVENTO = Global.eventoActivo,
                            USUARIO = Global.usuariologueado,
                            SERIE = co.SERIE.ToUpper(),
                            CORRELATIVO_ACTUAL = co.CORRELATIVO_ACTUAL,
                            CORRELATIVO_FINAL = co.CORRELATIVO_FINAL,
                            DESCRIPCION = "Correlativo de Recibos para el Evento " + Global.nombreeventoActivo,
                            ESTADO_REGISTRO = "A",
                            USUARIO_CREACION = Global.usuariologueado,
                            FECHA_CREACION = DateTime.Now
                        };
                        db.REC01_CORRELATIVO_RECIBO.Add(nuevoCorrelativo);
                        db.SaveChanges();
                        result.mensaje = "Se registro correctamente el Correlativo Fisico de Recibo para el Evento: " + Global.nombreeventoActivo;
                    }
                    else
                    {
                        correlativoActual.CORRELATIVO_ACTUAL = co.CORRELATIVO_ACTUAL;
                        correlativoActual.CORRELATIVO_FINAL = co.CORRELATIVO_FINAL;
                        correlativoActual.SERIE = co.SERIE.ToUpper();
                        correlativoActual.USUARIO_MODIFICACION = Global.usuariologueado;
                        correlativoActual.FECHA_MODIFICACION = DateTime.Now;
                        db.SaveChanges();
                        result.mensaje = "Se ha actualizado correctamente el Correlativo Fisico de Recibo para el Evento: " + Global.nombreeventoActivo;
                    }
                }
                result.codigo = 0;
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion, Referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        /// <summary>
        /// Metodo que me retorna informacion del Correlativo de Recibo Fisico del Usuario y Evento en Sesion
        /// </summary>
        /// <returns></returns>
        public Mensaje<REC01_CORRELATIVO_RECIBO> obtenerCorrelativoFisico()
        {
            Mensaje<REC01_CORRELATIVO_RECIBO> result = new Mensaje<REC01_CORRELATIVO_RECIBO>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en Base de Datos al obtener el correlativo fisico";
            result.data = new REC01_CORRELATIVO_RECIBO();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var resultado = (from c in db.REC01_CORRELATIVO_RECIBO
                                     where c.EVENTO == Global.eventoActivo
                                     && c.USUARIO == Global.usuariologueado
                                     && c.ESTADO_REGISTRO == "A"
                                     select c).SingleOrDefault();

                    if (resultado != null)
                    {
                        result.data = resultado;
                    }
                    else
                    {
                        result.data = new REC01_CORRELATIVO_RECIBO();
                    }
                }
                result.codigo = 0;
                result.mensaje = "Ok";
                return result;

            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        /// <summary>
        /// Metodo que Inserta un Recibo
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        public Mensaje<Recibo> NuevoRecibo(REC01_RECIBO rec)
        {
            Mensaje<Recibo> result = new Mensaje<Recibo>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos al tratar de registrar el recibo";
            result.data = new Recibo();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    //SE OBTIENE CORRELATIVO INTERNO POR USUARIO
                    var correlativo = (from c in db.REC01_CORRELATIVO_USUARIO
                                       where c.USUARIO == Global.usuariologueado.ToUpper()
                                       && c.ESTADO_REGISTRO == "A"
                                       select c).SingleOrDefault();

                    //SE VALIDA EL CORRELATIVO POR USUARIO, SI RETORNA NULO ES PORQUE EL USUARIO NO HA SIDO CREADO DESDE EL SISTEMA
                    if (correlativo == null)
                    {
                        result.codigo = -1;
                        result.mensaje = "No se pudo generar el recibo, el usuario no es operador o No fue creado desde el Sistema";
                        return result;
                    }

                    //SE OBTIENE CORRELATIVO FISICO DE RECIBO
                    var correlativoFisico = (from c in db.REC01_CORRELATIVO_RECIBO
                                             where c.EVENTO == Global.eventoActivo
                                             && c.USUARIO == Global.usuariologueado.ToUpper()
                                             && c.ESTADO_REGISTRO == "A"
                                             select c).SingleOrDefault();

                    //SE VERIFICA SI EXISTE UN RECIBO CON EL CORRELATIVO FISICO QUE SE ESTA TRATANDO DE ASIGNAR EN ESTADO ACTIVO
                    var validaReciboFisico = (from vr in db.REC01_RECIBO
                                              where vr.RECIBO_FISICO == correlativoFisico.CORRELATIVO_ACTUAL
                                              && vr.SERIE_RECIBO == Global.serieActiva.ToUpper()
                                              && vr.ESTADO_REGISTRO == "A"
                                              select vr).SingleOrDefault();

                    if (validaReciboFisico != null)
                    {
                        result.codigo = -2;
                        result.mensaje = "El correlativo: " + validaReciboFisico.RECIBO_FISICO + " con Serie " + Global.serieActiva + " ya ha sido utilizado anteriormente, no es posible volverlo a utilizar. Modifique el Rango Inicial o Actual en el Mantenimiento de Correlativos de Recibo o la Serie del Documento";
                        return result;
                    }
                    else
                    {
                        string letras = NumeroLetras.NumeroALetras(rec.TOTAL.ToString()).ToUpper();
                        REC01_RECIBO nuevoRecibo = new REC01_RECIBO();
                        if (rec.MEDIO_PAGO == 1)//MEDIO DE PAGO = 1 EQUIVALE A EFECTIVO
                        {
                            nuevoRecibo.RECIBO = Convert.ToDecimal(correlativo.CORRELATIVO_DISPONIBLE);
                            nuevoRecibo.NOMBRE = rec.NOMBRE.ToUpper();
                            nuevoRecibo.DIRECCION = rec.DIRECCION;
                            nuevoRecibo.NIT = rec.NIT;
                            nuevoRecibo.TELEFONO = rec.TELEFONO;
                            nuevoRecibo.MEDIO_PAGO = rec.MEDIO_PAGO;
                            nuevoRecibo.CONCEPTO = rec.CONCEPTO;
                            nuevoRecibo.TOTAL = rec.TOTAL;
                            nuevoRecibo.TOTAL_LETRAS = letras;
                            nuevoRecibo.PRECIO = rec.PRECIO;
                            nuevoRecibo.CANTIDAD = rec.CANTIDAD;
                            nuevoRecibo.EVENTO = Global.eventoActivo;
                            nuevoRecibo.PAIS = rec.PAIS;
                            nuevoRecibo.OBSERVACION_3 = rec.OBSERVACION_3.ToUpper();
                            nuevoRecibo.ESTADO_REGISTRO = "A";
                            nuevoRecibo.USUARIO_CREACION = Global.usuariologueado.ToUpper();
                            nuevoRecibo.FECHA_CREACION = DateTime.Now;
                            nuevoRecibo.RECIBO_FISICO = correlativoFisico.CORRELATIVO_ACTUAL;
                            nuevoRecibo.SERIE_RECIBO = Global.serieActiva;
                        }
                        else if (rec.MEDIO_PAGO == 2)//MEDIO DE PAGO = 2 EQUIVALE A CHEQUE
                        {
                            nuevoRecibo.RECIBO = Convert.ToDecimal(correlativo.CORRELATIVO_DISPONIBLE);
                            nuevoRecibo.NOMBRE = rec.NOMBRE.ToUpper();
                            nuevoRecibo.DIRECCION = rec.DIRECCION;
                            nuevoRecibo.NIT = rec.NIT;
                            nuevoRecibo.TELEFONO = rec.TELEFONO;
                            nuevoRecibo.MEDIO_PAGO = rec.MEDIO_PAGO;
                            nuevoRecibo.BANCO = rec.BANCO;
                            nuevoRecibo.NUMERO_CHEQUE = rec.NUMERO_CHEQUE;
                            nuevoRecibo.CONCEPTO = rec.CONCEPTO;
                            nuevoRecibo.TOTAL = rec.TOTAL;
                            nuevoRecibo.TOTAL_LETRAS = letras;
                            nuevoRecibo.PRECIO = rec.PRECIO;
                            nuevoRecibo.CANTIDAD = rec.CANTIDAD;
                            nuevoRecibo.EVENTO = Global.eventoActivo;
                            nuevoRecibo.PAIS = rec.PAIS;
                            nuevoRecibo.OBSERVACION_3 = rec.OBSERVACION_3.ToUpper();
                            nuevoRecibo.ESTADO_REGISTRO = "A";
                            nuevoRecibo.USUARIO_CREACION = Global.usuariologueado.ToUpper();
                            nuevoRecibo.FECHA_CREACION = DateTime.Now;
                            nuevoRecibo.RECIBO_FISICO = correlativoFisico.CORRELATIVO_ACTUAL;
                            nuevoRecibo.SERIE_RECIBO = Global.serieActiva;
                        }
                        db.REC01_RECIBO.Add(nuevoRecibo);
                        correlativo.CORRELATIVO_DISPONIBLE++;
                        correlativoFisico.CORRELATIVO_ACTUAL++;
                        db.SaveChanges();
                    }
                }
                result.codigo = 0;
                result.mensaje = "Se registro el recibo con nombre: " + rec.NOMBRE + " de forma Exitosa...!!!";
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
            
        }

        /// <summary>
        /// Metodo que Actualiza un Recibo
        /// </summary>
        /// <param name="rec"></param>
        /// <returns></returns>
        public Mensaje<Recibo> ActualizarRecibo(REC01_RECIBO rec)
        {
            Mensaje<Recibo> result = new Mensaje<Recibo>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos al tratar de registrar el recibo";
            result.data = new Recibo();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var reciboExistente = (from r in db.REC01_RECIBO
                                           where r.RECIBO == rec.RECIBO
                                           && r.USUARIO_CREACION == Global.usuariologueado.ToUpper()
                                           select r).SingleOrDefault();

                    string letras = NumeroLetras.NumeroALetras(rec.TOTAL.ToString()).ToUpper();
                    if (rec.MEDIO_PAGO == 1)//MEDIO DE PAGO = 1 EQUIVALE A EFECTIVO
                    {                        
                        reciboExistente.NOMBRE = rec.NOMBRE.ToUpper();
                        reciboExistente.DIRECCION = rec.DIRECCION;
                        reciboExistente.NIT = rec.NIT;
                        reciboExistente.TELEFONO = rec.TELEFONO;
                        reciboExistente.MEDIO_PAGO = rec.MEDIO_PAGO;
                        reciboExistente.CONCEPTO = rec.CONCEPTO;
                        reciboExistente.TOTAL = rec.TOTAL;
                        reciboExistente.TOTAL_LETRAS = letras;
                        reciboExistente.PRECIO = rec.PRECIO;
                        reciboExistente.CANTIDAD = rec.CANTIDAD;
                        reciboExistente.EVENTO = Global.eventoActivo;//
                        reciboExistente.PAIS = rec.PAIS;
                        reciboExistente.OBSERVACION_3 = rec.OBSERVACION_3.ToUpper();
                        reciboExistente.ESTADO_REGISTRO = "A";
                        reciboExistente.USUARIO_MODIFICACION = Global.usuariologueado.ToUpper();//
                        reciboExistente.FECHA_MODIFICACION = DateTime.Now;
                        //reciboExistente.RECIBO_FISICO = rec.RECIBO_FISICO;//
                        //reciboExistente.SERIE_RECIBO = rec.SERIE_RECIBO;//
                    }
                    else if (rec.MEDIO_PAGO == 2)//MEDIO DE PAGO = 2 EQUIVALE A CHEQUE
                    {                        
                        reciboExistente.NOMBRE = rec.NOMBRE.ToUpper();
                        reciboExistente.DIRECCION = rec.DIRECCION;
                        reciboExistente.NIT = rec.NIT;
                        reciboExistente.TELEFONO = rec.TELEFONO;
                        reciboExistente.MEDIO_PAGO = rec.MEDIO_PAGO;
                        reciboExistente.BANCO = rec.BANCO;
                        reciboExistente.NUMERO_CHEQUE = rec.NUMERO_CHEQUE;
                        reciboExistente.CONCEPTO = rec.CONCEPTO;
                        reciboExistente.TOTAL = rec.TOTAL;
                        reciboExistente.TOTAL_LETRAS = letras;
                        reciboExistente.PRECIO = rec.PRECIO;
                        reciboExistente.CANTIDAD = rec.CANTIDAD;
                        reciboExistente.EVENTO = rec.EVENTO;//
                        reciboExistente.PAIS = rec.PAIS;
                        reciboExistente.OBSERVACION_3 = rec.OBSERVACION_3.ToUpper();
                        reciboExistente.ESTADO_REGISTRO = "A";
                        reciboExistente.USUARIO_MODIFICACION = Global.usuariologueado.ToUpper();
                        reciboExistente.FECHA_MODIFICACION = DateTime.Now;
                        //reciboExistente.RECIBO_FISICO = rec.RECIBO_FISICO;
                        //reciboExistente.SERIE_RECIBO = rec.SERIE_RECIBO;
                    }

                    db.SaveChanges();
                }
                result.codigo = 0;
                result.mensaje = "Se ha actualizado correctamente el Recibo No. : " + rec.RECIBO_FISICO;
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion, Referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }


        #endregion
    }
}
