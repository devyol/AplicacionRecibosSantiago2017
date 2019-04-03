using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSA02.Clases;
using RSA02.DO.DATA;

namespace RSA02.Model
{
    public class Banco
    {
        /// <summary>
        /// Metodo que retorna todos los Bancos - Activos o Inactivos
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_BANCO>> listarTodosBancos()
        {
            Mensaje<List<REC01_BANCO>> result = new Mensaje<List<REC01_BANCO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener los Bancos";
            result.data = new List<REC01_BANCO>();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var list = (from li in db.REC01_BANCO.OrderBy(a => a.BANCO) select li).ToList();

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
                        result.mensaje = "No existen Bancos Registrados que mostrar, ir al Mantenimiento de Bancos";
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
        /// Metodo que retorna informacion de un Banco
        /// </summary>
        /// <param name="ba"></param>
        /// <returns></returns>
        public Mensaje<REC01_BANCO> obtenerBanco(REC01_BANCO ba)
        {
            Mensaje<REC01_BANCO> result = new Mensaje<REC01_BANCO>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al obtener el Banco";
            result.data = new REC01_BANCO();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var concep = (from li in db.REC01_BANCO
                                  where li.BANCO == ba.BANCO
                                  select li).SingleOrDefault();

                    if (concep != null)
                    {
                        result.data = concep;
                    }
                    else
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe informacion del Banco enviado";
                        result.data = new REC01_BANCO();
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
        /// Metodo que retorna los estados validos para un Banco - con esta informacion se llena el combo de estado Banco
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_ESTADO>> listaDescripcionEstadoBanco()
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
        /// Metodo que se utiliza para registrar un nuevo Banco
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        public Mensaje<Banco> RegistrarBanco(REC01_BANCO ba)
        {
            Mensaje<Banco> result = new Mensaje<Banco>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al tratar de registrar la entidad Bancaria";
            result.data = new Banco();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var valcorrelativo = (from li in db.REC01_BANCO select li.BANCO).ToList();
                    decimal correlativo = 0;

                    if (valcorrelativo.Count > 0)
                    {
                        correlativo = valcorrelativo.Max() + 1;
                    }
                    else
                    {
                        correlativo = 1;
                    }

                    REC01_BANCO nuevoBanco = new REC01_BANCO()
                    {
                        //BANCO = correlativo,
                        //NOMBRE = ba.NOMBRE,
                        //ESTADO_REGISTRO = ba.ESTADO_REGISTRO,
                        //USUARIO_CREACION = Global.usuariologueado,
                        //FECHA_CREACION = DateTime.Now
                    };
                    nuevoBanco.BANCO = correlativo;
                    nuevoBanco.NOMBRE = ba.NOMBRE;
                    nuevoBanco.ESTADO_REGISTRO = ba.ESTADO_REGISTRO;
                    nuevoBanco.USUARIO_CREACION = Global.usuariologueado;
                    nuevoBanco.FECHA_CREACION = DateTime.Now;

                    db.REC01_BANCO.Add(nuevoBanco);
                    db.SaveChanges();
                }
                result.codigo = 0;
                result.mensaje = "Se ha registrado correctamente la entidad Bancaria: " + ba.NOMBRE;
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
        /// Metodo que se utiliza para Modificar el nombre o estado de un Banco
        /// </summary>
        /// <param name="ev"></param>
        /// <returns></returns>
        public Mensaje<Banco> ActualizarRegistroBanco(REC01_BANCO ev)
        {
            Mensaje<Banco> result = new Mensaje<Banco>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un Error en base de datos al Actualizar el registro del Banco " + ev.NOMBRE;
            result.data = new Banco();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    REC01_BANCO nuevoBanco = (from e in db.REC01_BANCO
                                                where e.BANCO == ev.BANCO
                                                select e).SingleOrDefault();

                    if (nuevoBanco == null)
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe ningun registro con el dato del Banco enviando para su Actualizacion";
                        return result;
                    }

                    nuevoBanco.NOMBRE = ev.NOMBRE;
                    nuevoBanco.ESTADO_REGISTRO = ev.ESTADO_REGISTRO;
                    nuevoBanco.USUARIO_MODIFICACION = Global.usuariologueado;
                    nuevoBanco.FECHA_MODIFICACION = DateTime.Now;
                    db.SaveChanges();
                }
                result.codigo = 0;
                result.mensaje = "Se ha actualizado correctamente el Banco: " + ev.NOMBRE;
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
