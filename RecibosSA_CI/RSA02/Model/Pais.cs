using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSA02.Clases;
using RSA02.DO.DATA;

namespace RSA02.Model
{
    public class Pais
    {
        /// <summary>
        /// Metodo que retorna todos los Paises - Activos o Inactivos
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_PAIS>> listarTodosPaises()
        {
            Mensaje<List<REC01_PAIS>> result = new Mensaje<List<REC01_PAIS>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Paises";
            result.data = new List<REC01_PAIS>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from li in db.REC01_PAIS.OrderBy(a => a.REGION) select li).ToList();

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
        /// Metodo que retorna informacion de un Banco
        /// </summary>
        /// <param name="pa"></param>
        /// <returns></returns>
        public Mensaje<REC01_PAIS> obtenerPais(REC01_PAIS pa)
        {
            Mensaje<REC01_PAIS> result = new Mensaje<REC01_PAIS>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener el Pais";
            result.data = new REC01_PAIS();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var concep = (from li in db.REC01_PAIS
                                  where li.PAIS == pa.PAIS
                                  select li).SingleOrDefault();

                    if (concep != null)
                    {
                        result.data = concep;
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe informacion del Pais enviado";
                        result.data = new REC01_PAIS();
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
        /// Metodo que retorna los estados validos para un Pais - con esta informacion se llena el combo de estado Pais
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_ESTADO>> listaDescripcionEstadoPais()
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
        /// Metodo que se utiliza para Modificar el nombre o estado de un Pais
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        public Mensaje<Pais> ActualizarRegistroPais(REC01_PAIS ev)
        {
            Mensaje<Pais> result = new Mensaje<Pais>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al Actualizar el registro del Pais " + ev.DESCRIPCION;
            result.data = new Pais();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    REC01_PAIS nuevoPais = (from e in db.REC01_PAIS
                                               where e.PAIS == ev.PAIS
                                               select e).SingleOrDefault();

                    if (nuevoPais == null)
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe ningun registro con el dato del Pais enviando para su Actualizacion";
                        return result;
                    }

                    nuevoPais.DESCRIPCION = ev.DESCRIPCION;
                    nuevoPais.ESTADO_REGISTRO = ev.ESTADO_REGISTRO;
                    nuevoPais.USUARIO_MODIFICACION = Global.usuariologueado;
                    nuevoPais.FECHA_MODIFICACION = DateTime.Now;
                    db.SaveChanges();
                }
                result.codigo = 0;
                result.mensaje = "Se ha actualizado correctamente el Pais: " + ev.DESCRIPCION;
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
