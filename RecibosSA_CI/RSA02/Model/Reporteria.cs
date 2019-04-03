using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSA02.DO.DATA;
using RSA02.Clases;

namespace RSA02.Model
{
    public class Reporteria
    {
        #region Propiedades

        public string usuario { get; set; }
        public string nombre { get; set; }
        public string concepto { get; set; }
        public decimal? precio { get; set; }
        public decimal? cantidad { get; set; }
        public decimal? total { get; set; }
        public string medio_pago { get; set; }
        public string numero_cheque { get; set; }
        public string banco { get; set; }
        public string fecha { get; set; }
        public string evento { get; set; }
        public decimal idevento { get; set; }
        public string idusuario { get; set; }
        public string fecha_inicial { get; set; }
        public string fecha_final { get; set; }
        public string pais { get; set; }
        public decimal? total_participantes { get; set; }
        public decimal? total_cobrado { get; set; }
        public string fecha_anulacion { get; set; }
        public string serie { get; set; }
        public decimal? recibo_fisico { get; set; }
        public string motivo { get; set; }

        #endregion

        #region Constantes

        private const string _sqlGlobalEvento = @"select rec.recibo_fisico, rec.serie_recibo serie, us.nombre usuario, rec.nombre, co.descripcion concepto, 
                                                    rec.precio, rec.cantidad, rec.total, mp.descripcion medio_pago,
                                                    rec.numero_cheque, ba.nombre banco,
                                                    to_char(rec.fecha_creacion,'dd/mm/yyyy')fecha, 
                                                    :ini fecha_inicial,
                                                    :fin fecha_final,ev.nombre evento
                                                    from
                                                    rec01_recibo rec,
                                                    rec01_evento ev,
                                                    rec01_concepto co,
                                                    rec01_usuario us,
                                                    rec01_medio_pago mp,
                                                    rec01_banco ba
                                                    where rec.evento = ev.evento 
                                                    and rec.concepto = co.concepto
                                                    and rec.usuario_creacion = us.usuario
                                                    and rec.medio_pago = mp.medio_pago
                                                    and rec.banco = ba.banco(+)
                                                    and rec.estado_registro = 'A'
                                                    and rec.evento = :evento
                                                    and trunc(rec.fecha_creacion) between to_date(:ini,'dd/mm/yyyy') and to_date(:fin,'dd/mm/yyyy')
                                                    order by rec.usuario_creacion, rec.recibo";

        private const string _sqlGlobalFecha = @"select rec.recibo_fisico, rec.serie_recibo serie, us.nombre usuario, rec.nombre, co.descripcion concepto, 
                                                    rec.precio, rec.cantidad, rec.total, mp.descripcion medio_pago,
                                                    rec.numero_cheque, ba.nombre banco,
                                                    to_char(rec.fecha_creacion,'dd/mm/yyyy')fecha, 
                                                    :ini fecha_inicial,
                                                    :fin fecha_final, ev.nombre evento
                                                    from
                                                    rec01_recibo rec,
                                                    rec01_evento ev,
                                                    rec01_concepto co,
                                                    rec01_usuario us,
                                                    rec01_medio_pago mp,
                                                    rec01_banco ba
                                                    where rec.evento = ev.evento  
                                                    and rec.concepto = co.concepto
                                                    and rec.usuario_creacion = us.usuario
                                                    and rec.medio_pago = mp.medio_pago
                                                    and rec.banco = ba.banco(+)
                                                    and rec.estado_registro = 'A'
                                                    and rec.evento = :evento
                                                    and rec.usuario_creacion = :usuario
                                                    and trunc(rec.fecha_creacion) between to_date(:ini,'dd/mm/yyyy') and to_date(:fin,'dd/mm/yyyy')
                                                    order by rec.recibo";

        private const string _sqlGlobalPais = @"select evento, pais, total_participantes, :ini fecha_inicial, :fin fecha_final
                                                from(
                                                select ev.nombre evento, pa.descripcion pais, sum(rec.cantidad) total_participantes
                                                from rec01_recibo rec, rec01_pais pa, rec01_evento ev
                                                where rec.evento = ev.evento 
                                                and rec.pais = pa.pais
                                                and rec.estado_registro = 'A'
                                                and rec.evento = :evento
                                                and trunc(rec.fecha_creacion) between to_date(:ini,'dd/mm/yyyy') and to_date(:fin,'dd/mm/yyyy')
                                                group by pa.descripcion, ev.nombre
                                                order by pa.descripcion)";


        private const string _sqlFechaPais = @"select evento, pais, total_participantes, :ini fecha_inicial, :fin fecha_final
                                                from(
                                                select ev.nombre evento, pa.descripcion pais, sum(rec.cantidad) total_participantes
                                                from rec01_recibo rec, rec01_pais pa, rec01_evento ev
                                                where rec.evento = ev.evento
                                                and rec.pais = pa.pais
                                                and rec.estado_registro = 'A'
                                                and rec.evento = :evento
                                                and rec.usuario_creacion = :usuario
                                                and trunc(rec.fecha_creacion) between to_date(:ini,'dd/mm/yyyy') and to_date(:fin,'dd/mm/yyyy')
                                                group by pa.descripcion, ev.nombre
                                                order by pa.descripcion)";

        private const string _sqlGlobalConcepto = @"select evento, concepto, total, total_cobrado, :ini fecha_inicial, :fin fecha_final
                                                    from(
                                                    select  ev.nombre evento, co.descripcion concepto, sum(rec.cantidad) total, sum(rec.total) total_cobrado
                                                    from rec01_recibo rec, rec01_concepto co, rec01_evento ev
                                                    where rec.evento = ev.evento
                                                    and rec.concepto = co.concepto
                                                    and rec.estado_registro = 'A'
                                                    and rec.evento = :evento
                                                    and trunc(rec.fecha_creacion) between to_date(:ini,'dd/mm/yyyy') and to_date(:fin,'dd/mm/yyyy')
                                                    group by co.descripcion, co.concepto, ev.nombre
                                                    order by co.concepto)";

        private const string _sqlFechaConcepto = @"select evento, concepto, total, total_cobrado, :ini fecha_inicial, :fin fecha_final
                                                    from(
                                                    select  ev.nombre evento, co.descripcion concepto, sum(rec.cantidad) total, sum(rec.total) total_cobrado
                                                    from rec01_recibo rec, rec01_concepto co, rec01_evento ev
                                                    where rec.evento = ev.evento
                                                    and rec.concepto = co.concepto
                                                    and rec.estado_registro = 'A'
                                                    and rec.evento = :evento
                                                    and rec.usuario_creacion = :usuario
                                                    and trunc(rec.fecha_creacion) between to_date(:ini,'dd/mm/yyyy') and to_date(:fin,'dd/mm/yyyy')
                                                    group by co.descripcion, co.concepto, ev.nombre
                                                    order by co.concepto)";

        private const string _sqlFechaAlimentacion = @"select evento, concepto, total, total_cobrado, :ini fecha_inicial, :fin fecha_final
                                                        from(
                                                        select  ev.nombre evento, co.descripcion concepto, sum(rec.cantidad) total, sum(rec.total) total_cobrado
                                                        from rec01_recibo rec, rec01_concepto co, rec01_evento ev
                                                        where rec.evento = ev.evento
                                                        and rec.concepto = co.concepto
                                                        and rec.estado_registro = 'A'
                                                        and rec.evento = :evento
                                                        and upper(co.descripcion) like upper('%ALIMENTACION%')
                                                        and trunc(rec.fecha_creacion) between to_date(:ini,'dd/mm/yyyy') and to_date(:fin,'dd/mm/yyyy')
                                                        group by co.descripcion, co.concepto, ev.nombre
                                                        order by co.concepto)";

        private const string _sqlAnulacionFecha = @"select to_char(anu.fecha_anulacion,'dd/mm/yyyy') fecha_anulacion,
                                                    anu.serie, anu.recibo_fisico, rec.nombre, anu.motivo, us.nombre usuario,
                                                    :ini fecha_inicial, :fin fecha_final
                                                    from rec01_recibo rec, rec01_anulacion anu, rec01_usuario us
                                                    where rec.recibo = anu.recibo
                                                    and anu.usuario_anulacion = us.usuario
                                                    and rec.evento = :evento
                                                    and trunc(anu.fecha_anulacion) between to_date(:ini,'dd/mm/yyyy') and to_date(:fin,'dd/mm/yyyy')
                                                    and rec.usuario_creacion = anu.usuario_anulacion                                                    
                                                    order by anu.usuario_anulacion, anu.fecha_anulacion";


        #endregion

        #region Metodos Publicos

        /// <summary>
        /// Metodo que Devuelve el listado de Recibos Global por Fecha
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<Reporteria>> globalDetalladoFecha()
        {
            Mensaje<List<Reporteria>> result = new Mensaje<List<Reporteria>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al tratar de generar la informacion";
            result.data = new List<Reporteria>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    StringBuilder sqlGE = new StringBuilder();
                    sqlGE.Append(_sqlGlobalEvento);

                    var list = db.Database.SqlQuery<Reporteria>(sqlGE.ToString(), new object[] { fecha_inicial, fecha_final, idevento, fecha_inicial, fecha_final}).ToList<Reporteria>();

                    if (list.Count == 0)
                    {
                        result.codigo = 1;
                        result.mensaje = "No existen registros para este Evento";
                        result.data = new List<Reporteria>();
                        return result;
                    }
                    foreach (var item in list)
                    {
                        result.data.Add(item);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion al tratar de Recuperar los datos, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        /// <summary>
        /// Metodo que Devuelve el listado de Recibos por Usuario Logueado y por Rango de Fechas 
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<Reporteria>> individualDetalladoFecha()
        {
            Mensaje<List<Reporteria>> result = new Mensaje<List<Reporteria>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al tratar de generar la informacion";
            result.data = new List<Reporteria>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    StringBuilder sqlGE = new StringBuilder();
                    sqlGE.Append(_sqlGlobalFecha);

                    var list = db.Database.SqlQuery<Reporteria>(sqlGE.ToString(), new object[] {fecha_inicial,fecha_final, idevento, idusuario, fecha_inicial,fecha_final }).ToList<Reporteria>();

                    if (list.Count == 0)
                    {
                        result.codigo = 1;
                        result.mensaje = "No existen registros para este Rango de Fechas";
                        result.data = new List<Reporteria>();
                        return result;
                    }
                    foreach (var item in list)
                    {
                        result.data.Add(item);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion al tratar de Recuperar los datos, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }

        }

        /// <summary>
        /// Metodo que devuelve listado de Cantidad de participantes por Pais de forma Global por Fecha
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<Reporteria>> globalPaisFecha()
        {
            Mensaje<List<Reporteria>> result = new Mensaje<List<Reporteria>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al tratar de generar la informacion";
            result.data = new List<Reporteria>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    StringBuilder sqlGE = new StringBuilder();
                    sqlGE.Append(_sqlGlobalPais);

                    var list = db.Database.SqlQuery<Reporteria>(sqlGE.ToString(), new object[] { fecha_inicial, fecha_final, idevento, fecha_inicial, fecha_final }).ToList<Reporteria>();

                    if (list.Count == 0)
                    {
                        result.codigo = 1;
                        result.mensaje = "No existen registros para este Evento";
                        result.data = new List<Reporteria>();
                        return result;
                    }
                    foreach (var item in list)
                    {
                        result.data.Add(item);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion al tratar de Recuperar los datos, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        /// <summary>
        /// Metodo que devuelve listado de Cantidad de participantes por Pais por Usuario Logueado y por Rango de Fechas 
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<Reporteria>> individualPaisFecha()
        {
            Mensaje<List<Reporteria>> result = new Mensaje<List<Reporteria>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al tratar de generar la informacion";
            result.data = new List<Reporteria>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    StringBuilder sqlGE = new StringBuilder();
                    sqlGE.Append(_sqlFechaPais);

                    var list = db.Database.SqlQuery<Reporteria>(sqlGE.ToString(), new object[] { fecha_inicial, fecha_final, idevento, idusuario, fecha_inicial, fecha_final }).ToList<Reporteria>();

                    if (list.Count == 0)
                    {
                        result.codigo = 1;
                        result.mensaje = "No existen registros para este Evento";
                        result.data = new List<Reporteria>();
                        return result;
                    }
                    foreach (var item in list)
                    {
                        result.data.Add(item);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion al tratar de Recuperar los datos, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        /// <summary>
        /// Metodo que devuelve listado de Cantidad de participantes por Concepto de forma Global por Fecha
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<Reporteria>> globalConceptoFecha()
        {
            Mensaje<List<Reporteria>> result = new Mensaje<List<Reporteria>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al tratar de generar la informacion";
            result.data = new List<Reporteria>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    StringBuilder sqlGE = new StringBuilder();
                    sqlGE.Append(_sqlGlobalConcepto);

                    var list = db.Database.SqlQuery<Reporteria>(sqlGE.ToString(), new object[] { fecha_inicial, fecha_final, idevento, fecha_inicial, fecha_final }).ToList<Reporteria>();

                    if (list.Count == 0)
                    {
                        result.codigo = 1;
                        result.mensaje = "No existen registros para este Evento";
                        result.data = new List<Reporteria>();
                        return result;
                    }
                    foreach (var item in list)
                    {
                        result.data.Add(item);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion al tratar de Recuperar los datos, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        /// <summary>
        /// Metodo que devuelve listado de Cantidad de participantes por Concepto por Usuario Logueado y por Rango de Fechas 
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<Reporteria>> individualConceptoFecha()
        {
            Mensaje<List<Reporteria>> result = new Mensaje<List<Reporteria>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al tratar de generar la informacion";
            result.data = new List<Reporteria>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    StringBuilder sqlGE = new StringBuilder();
                    sqlGE.Append(_sqlFechaConcepto);

                    var list = db.Database.SqlQuery<Reporteria>(sqlGE.ToString(), new object[] { fecha_inicial, fecha_final, idevento, idusuario, fecha_inicial, fecha_final }).ToList<Reporteria>();

                    if (list.Count == 0)
                    {
                        result.codigo = 1;
                        result.mensaje = "No existen registros para este Evento";
                        result.data = new List<Reporteria>();
                        return result;
                    }
                    foreach (var item in list)
                    {
                        result.data.Add(item);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion al tratar de Recuperar los datos, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        /// <summary>
        /// Metodo que devuelve listado de Cantidad de participantes por Concepto de Alimentacion en un Evento
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<Reporteria>> fechaAlimentacion()
        {
            Mensaje<List<Reporteria>> result = new Mensaje<List<Reporteria>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al tratar de generar la informacion";
            result.data = new List<Reporteria>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    StringBuilder sqlGE = new StringBuilder();
                    sqlGE.Append(_sqlFechaAlimentacion);

                    var list = db.Database.SqlQuery<Reporteria>(sqlGE.ToString(), new object[] { fecha_inicial, fecha_final, idevento, fecha_inicial, fecha_final }).ToList<Reporteria>();

                    if (list.Count == 0)
                    {
                        result.codigo = 1;
                        result.mensaje = "No existen registros para este Evento";
                        result.data = new List<Reporteria>();
                        return result;
                    }
                    foreach (var item in list)
                    {
                        result.data.Add(item);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion al tratar de Recuperar los datos, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        /// <summary>
        /// Metodo que devuelve listado de Recibos Anulados Global por rango de Fechas
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<Reporteria>> fechaAnulacion()
        {
            Mensaje<List<Reporteria>> result = new Mensaje<List<Reporteria>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al tratar de generar la informacion";
            result.data = new List<Reporteria>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    StringBuilder sqlGE = new StringBuilder();
                    sqlGE.Append(_sqlAnulacionFecha);

                    var list = db.Database.SqlQuery<Reporteria>(sqlGE.ToString(), new object[] { fecha_inicial, fecha_final, idevento, fecha_inicial, fecha_final }).ToList<Reporteria>();

                    if (list.Count == 0)
                    {
                        result.codigo = 1;
                        result.mensaje = "No existen registros para este Evento";
                        result.data = new List<Reporteria>();
                        return result;
                    }
                    foreach (var item in list)
                    {
                        result.data.Add(item);
                    }
                }
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una Excepcion al tratar de Recuperar los datos, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        #endregion
    }
}
