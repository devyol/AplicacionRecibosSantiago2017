using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSA02.Clases;
using RSA02.DO.DATA;

namespace RSA02.Model
{
    public class Evento
    {
        /// <summary>
        /// Metodo que retorna todos los Eventos - Activos o Inactivos
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_EVENTO>> listarTodosEventos()
        {
            Mensaje<List<REC01_EVENTO>> result = new Mensaje<List<REC01_EVENTO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Eventos";
            result.data = new List<REC01_EVENTO>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from li in db.REC01_EVENTO.OrderByDescending(a => a.EVENTO) select li).ToList();

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
                        result.mensaje = "No existen Eventos Registrados que mostrar, ir al Mantenimiento de Eventos";
                        result.data = new List<REC01_EVENTO>();
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
        /// Metodo que retorna informacion de un Evento
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        public Mensaje<REC01_EVENTO> obtenerEvento(REC01_EVENTO ev)
        {
            Mensaje<REC01_EVENTO> result = new Mensaje<REC01_EVENTO>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener el Evento";
            result.data = new REC01_EVENTO();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var concep = (from li in db.REC01_EVENTO
                                  where li.EVENTO == ev.EVENTO                                  
                                  select li).SingleOrDefault();

                    if (concep != null)
                    {
                        result.data = concep;
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe informacion del Evento enviado";
                        result.data = new REC01_EVENTO();
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
        /// Metodo que retorna los Eventos Activos
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_EVENTO>> listarEventosActivos()
        {
            Mensaje<List<REC01_EVENTO>> result = new Mensaje<List<REC01_EVENTO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Eventos";
            result.data = new List<REC01_EVENTO>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from li in db.REC01_EVENTO.Where(e => e.ESTADO_REGISTRO =="A").OrderByDescending(a => a.EVENTO) select li).ToList();

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
                        result.mensaje = "No existen Eventos Registrados que mostrar, ir al Mantenimiento de Eventos";
                        result.data = new List<REC01_EVENTO>();
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
        /// Metodo que retorna los estados validos para un Evento - con esta informacion se llena el combo de estado Evento
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_ESTADO>> listaDescripcionEstadoEvento()
        {
            Mensaje<List<REC01_ESTADO>> result = new Mensaje<List<REC01_ESTADO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Estados";
            result.data = new List<REC01_ESTADO>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from es in db.REC01_ESTADO.Where(d => d.ESTADO =="A" || d.ESTADO =="B").OrderBy(e => e.ESTADO) select es).ToList();

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
        /// Metodo que se utiliza para registrar un nuevo evento
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        public Mensaje<Evento> RegistrarEvento(REC01_EVENTO ev)
        {
            Mensaje<Evento> result = new Mensaje<Evento>();            
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al tratar de registrar el Evento";
            result.data = new Evento();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var valcorrelativo = (from li in db.REC01_EVENTO select li.EVENTO).ToList();
                    decimal correlativo = 0;

                    if (valcorrelativo.Count > 0)
                    {
                        correlativo = valcorrelativo.Max() + 1;
                    }
                    else
                    {
                        correlativo = 1;
                    }

                    REC01_EVENTO nuevoEvento = new REC01_EVENTO()
                    {
                        EVENTO = correlativo,
                        NOMBRE = ev.NOMBRE,
                        ESTADO_REGISTRO = ev.ESTADO_REGISTRO,
                        USUARIO_CREACION = Global.usuariologueado,
                        FECHA_CREACION = DateTime.Now
                    };

                    db.REC01_EVENTO.Add(nuevoEvento);
                    db.SaveChanges();
                }
                result.codigo = 0;
                result.mensaje = "Se ha registrado correctamente el Evento: "+ ev.NOMBRE;
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
        /// Metodo que se utiliza para Modificar el nombre o estado de un Evento
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        public Mensaje<Evento> ActualizarRegistroEvento(REC01_EVENTO ev)
        {
            Mensaje<Evento> result = new Mensaje<Evento>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al Actualizar el registro del Evento " + ev.NOMBRE;
            result.data = new Evento();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    REC01_EVENTO nuevoEvento = (from e in db.REC01_EVENTO
                                                where e.EVENTO == ev.EVENTO
                                                select e).SingleOrDefault();
                    
                    if (nuevoEvento == null)
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe ningun registro con el dato del evento enviando para su Actualizacion";
                        return result;
                    }

                    nuevoEvento.NOMBRE = ev.NOMBRE;
                    nuevoEvento.ESTADO_REGISTRO = ev.ESTADO_REGISTRO;
                    nuevoEvento.USUARIO_MODIFICACION = Global.usuariologueado;
                    nuevoEvento.FECHA_MODIFICACION = DateTime.Now;
                    db.SaveChanges();
                }
                result.codigo = 0;
                result.mensaje = "Se ha actualizado correctamente el Evento: " + ev.NOMBRE;
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
