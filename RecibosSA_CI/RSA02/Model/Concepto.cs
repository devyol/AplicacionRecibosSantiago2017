using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSA02.Clases;
using RSA02.DO.DATA;

namespace RSA02.Model
{
    public class Concepto
    {

        /// <summary>
        /// Metodo que retorna todos los Conceptos - Activos
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_CONCEPTO>> listarTodosConceptos()
        {
            Mensaje<List<REC01_CONCEPTO>> result = new Mensaje<List<REC01_CONCEPTO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Conceptos";
            result.data = new List<REC01_CONCEPTO>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from li in db.REC01_CONCEPTO/*.Where(c => c.ESTADO_REGISTRO == "A")*/.OrderBy(a => a.CONCEPTO) select li).ToList();

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
                        result.mensaje = "No existen Conceptos Registrados que mostrar";
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
        /// Metodo que retorna informacion de un Concepto
        /// </summary>
        /// <param name="con"></param>
        /// <returns></returns>
        public Mensaje<REC01_CONCEPTO> obtenerConcepto(REC01_CONCEPTO con)
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
                                  where li.CONCEPTO == con.CONCEPTO
                                  select li).SingleOrDefault();

                    if (concep != null)
                    {
                        result.data = concep;
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe informacion del Concepto enviado";
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
        /// Metodo que retorna los estados validos para un Concepto - con esta informacion se llena el combo de estado Concepto
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_ESTADO>> listaDescripcionEstadoConcepto()
        {
            Mensaje<List<REC01_ESTADO>> result = new Mensaje<List<REC01_ESTADO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Estados";
            result.data = new List<REC01_ESTADO>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from es in db.REC01_ESTADO.Where(d => d.ESTADO == "A" || d.ESTADO == "B").OrderBy(e => e.ESTADO) select es).ToList();

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
                        result.mensaje = "No existen Estados Registrados que mostrar";
                        result.data = new List<REC01_ESTADO>();
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
        /// Metodo que se utiliza para registrar un nuevo Concepto
        /// </summary>
        /// <param name="co"></param>
        /// <returns></returns>
        public Mensaje<Concepto> RegistrarConcepto(REC01_CONCEPTO co)
        {
            Mensaje<Concepto> result = new Mensaje<Concepto>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al tratar de registrar el Concepto";
            result.data = new Concepto();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var valcorrelativo = (from li in db.REC01_CONCEPTO select li.CONCEPTO).ToList();
                    decimal correlativo = 0;

                    if (valcorrelativo.Count > 0)
                    {
                        correlativo = valcorrelativo.Max() + 1;
                    }
                    else
                    {
                        correlativo = 1;
                    }

                    REC01_CONCEPTO nuevoConcepto = new REC01_CONCEPTO()
                    {
                        CONCEPTO = correlativo,
                        DESCRIPCION = co.DESCRIPCION,
                        PRECIO = co.PRECIO,
                        ESTADO_REGISTRO = co.ESTADO_REGISTRO,
                        USUARIO_CREACION = Global.usuariologueado,
                        FECHA_CREACION = DateTime.Now
                    };

                    db.REC01_CONCEPTO.Add(nuevoConcepto);
                    db.SaveChanges();
                }
                result.codigo = 0;
                result.mensaje = "Se ha registrado correctamente el Concepto: " + co.DESCRIPCION;
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
        /// Metodo que se utiliza para Modificar el nombre, precio o estado de un Concepto
        /// </summary>
        /// <param name="co"></param>
        /// <returns></returns>
        public Mensaje<Concepto> ActualizarRegistroConcepto(REC01_CONCEPTO co)
        {
            Mensaje<Concepto> result = new Mensaje<Concepto>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al Actualizar el registro del Concepto " + co.DESCRIPCION;
            result.data = new Concepto();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    REC01_CONCEPTO nuevoConcepto = (from c in db.REC01_CONCEPTO
                                                where c.CONCEPTO == co.CONCEPTO
                                                select c).SingleOrDefault();

                    if (nuevoConcepto == null)
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe ningun registro con el dato del Concepto enviando para su Actualizacion";
                        return result;
                    }

                    nuevoConcepto.DESCRIPCION = co.DESCRIPCION;
                    nuevoConcepto.PRECIO = co.PRECIO;
                    nuevoConcepto.ESTADO_REGISTRO = co.ESTADO_REGISTRO;
                    nuevoConcepto.USUARIO_MODIFICACION = Global.usuariologueado;
                    nuevoConcepto.FECHA_MODIFICACION = DateTime.Now;
                    db.SaveChanges();
                }
                result.codigo = 0;
                result.mensaje = "Se ha actualizado correctamente el Concepto: " + co.DESCRIPCION;
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

    }
}
