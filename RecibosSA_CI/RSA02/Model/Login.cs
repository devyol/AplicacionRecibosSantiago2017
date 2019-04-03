using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSA02.DO.DATA;
using RSA02.Clases;
using System.Windows.Forms;

namespace RSA02.Model
{
    public class Login
    {
        /// <summary>
        /// Metodo para validar el usuario y password registrado en base de datos
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Autenticar(string usuario, string password)
        {
            using (var db = new RSA02.DO.DATA.EsquemaREC01())
            {
                //var result = from u in db.REC01_USUARIO where (u.USUARIO.ToUpper() == usuario.ToUpper() && u.ESTADO_REGISTRO == "A") select u;

                var result = from u in db.REC01_USUARIO.Include("REC01_TIPO_USUARIO")
                             where u.USUARIO.ToUpper() == usuario.ToUpper()
                             && u.ESTADO_REGISTRO == "A"
                             select u;

                if (result.Count() != 0)
                {
                    var dbuser = result.SingleOrDefault();

                    if (SEG01_DO.Encriptor.validarPassword(password,dbuser.PASSWORD))
                    {
                        Global.usuariologueado = dbuser.USUARIO.ToUpper();
                        Global.tipousuario = dbuser.REC01_TIPO_USUARIO.DESCRIPCION;
                        Global.tipousuarioid = dbuser.TIPO_USUARIO.ToString();
                        return true;                        
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Metodo para Cerrar Sesion
        /// </summary>
        /// <param name="f"></param>
        public void cerrarSesion(Form f)
        {
            Global.usuariologueado = "";
            f.Hide();
            frmLogin l = new frmLogin();
            l.ShowDialog();
            f.Close();
        }

        /// <summary>
        /// Metodo que devuelve informacion del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public REC01_USUARIO obtenerUsuario(string usuario)
        {
            REC01_USUARIO result = new REC01_USUARIO();

            using (var db = new RSA02.DO.DATA.EsquemaREC01())
            {
                var resultado = from u in db.REC01_USUARIO where (u.USUARIO.ToUpper() == usuario.ToUpper() && u.ESTADO_REGISTRO == "A") select u;

                if (resultado.Count()!=0)
                {
                    result = resultado.SingleOrDefault();
                }
                else
                {
                    result = new REC01_USUARIO();
                }
                return result;
            }
        }

        /// <summary>
        /// Metodo para cambiar la contraseña del usuario que esta logueado
        /// </summary>
        /// <param name="us"></param>
        /// <returns></returns>        
        public Mensaje<Login> modificarContrasena(REC01_USUARIO us)
        {
            Mensaje<Login> result = new Mensaje<Login>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base datos al tratar de modificar la Contraseña";
            result.data = new Login();

            try
            {
                using (var db = new RSA02.DO.DATA.EsquemaREC01())
                {
                    REC01_USUARIO regActual = (from u in db.REC01_USUARIO
                                               where u.USUARIO.ToUpper() == us.USUARIO.ToUpper()
                                               select u).FirstOrDefault();

                    if (regActual == null)
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe el Usuario indicado, favor de validar";
                        return result;
                    }

                    regActual.PASSWORD = SEG01_DO.Encriptor.encriptarPassword(us.PASSWORD).ToString();
                    regActual.USUARIO_MODIFICACION = Global.usuariologueado;
                    regActual.FECHA_MODIFICACION = DateTime.Now;
                    db.SaveChanges();
                }
                result.codigo = 0;
                result.mensaje = "Se Modifico la contraseña de forma exitosa....!!!!";
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion al tratar de cambiar la contraseña, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        /// <summary>
        /// Metodo que registra Usuario y Correlativo de Usuario para transacciones individuales
        /// </summary>
        /// <param name="us"></param>
        /// <returns></returns>
        public Mensaje<Login> registrarUsuario(REC01_USUARIO us)
        {
            Mensaje<Login> result = new Mensaje<Login>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos al tratar de registrar al usuario: " + us.USUARIO;
            result.data = new Login();

            try
            {
                using (var transaccion = new System.Transactions.TransactionScope())
                {
                    using (var db = new RSA02.DO.DATA.EsquemaREC01())
                    {
                        //Se Valida que el usuario a registrar no exista
                        REC01_USUARIO regNuevo = (from u in db.REC01_USUARIO
                                                  where u.USUARIO.ToUpper() == us.USUARIO.ToUpper()
                                                  select u).FirstOrDefault();

                         
                        if (regNuevo != null)
                        {
                            result.codigo = -1;
                            result.mensaje = "El Usuario ya existe, favor de utilizar otro usuario";
                            return result;
                        }

                        //SE REGISTRA EL USUARIO
                        REC01_USUARIO nuevoUsuario = new REC01_USUARIO() { 
                        USUARIO = us.USUARIO.ToUpper(),
                        TIPO_USUARIO = us.TIPO_USUARIO,
                        NOMBRE = us.NOMBRE,
                        PASSWORD = SEG01_DO.Encriptor.encriptarPassword(us.PASSWORD).ToString(),
                        ESTADO_REGISTRO = "A",
                        USUARIO_CREACION = Global.usuariologueado,
                        FECHA_CREACION = DateTime.Now
                        };

                        db.REC01_USUARIO.Add(nuevoUsuario);
                        int res = db.SaveChanges();
                        if (res <= 0)
                        {
                            System.Transactions.Transaction.Current.Rollback();
                            result.codigo = 2;
                            result.mensaje = "No Fue Posible registrar el usuario";
                            return result;
                        }

                        if (us.TIPO_USUARIO == 2)
                        {
                            //SE REGISTRA EL CORRELATIVO DEL USUARIO OPERADOR PARA TRANSACCIONES INDIVIDUALES
                            REC01_CORRELATIVO_USUARIO correlativo = new REC01_CORRELATIVO_USUARIO()
                            {
                                USUARIO = us.USUARIO,
                                CORRELATIVO_DISPONIBLE = 1,
                                ESTADO_REGISTRO = "A",
                                USUARIO_CREACION = Global.usuariologueado,
                                FECHA_CREACION = DateTime.Now
                            };

                            db.REC01_CORRELATIVO_USUARIO.Add(correlativo);
                            int resp = db.SaveChanges();
                            if (resp <= 0)
                            {
                                System.Transactions.Transaction.Current.Rollback();
                                result.codigo = 2;
                                result.mensaje = "Inconveniente para finalizar el registro del Usuario";
                                return result;
                            }                            
                        }
                    }
                    transaccion.Complete();
                    result.codigo = 0;
                    result.mensaje = "Usuario : " + us.USUARIO + " creado exitosamente....!!!";
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion al tratar de registrar el Usuario, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }

        }

        /// <summary>
        /// Metodo que devuelve el listado de Tipos de Usuario
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_TIPO_USUARIO>> tiposUsuarios()
        {
            Mensaje<List<REC01_TIPO_USUARIO>> result = new Mensaje<List<REC01_TIPO_USUARIO>>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en base de datos al obtener lista de tipos";
            result.data = new List<REC01_TIPO_USUARIO>();

            try
            {
                using (var db = new RSA02.DO.DATA.EsquemaREC01())
                {
                    var list = (from l in db.REC01_TIPO_USUARIO
                                where l.ESTADO_REGISTRO == "A"
                                select l).ToList();

                    if (list.Count>0)
                    {
                        result.data = list;
                    }
                    else
                    {
                        result.codigo = 1;
                        result.mensaje = "Actualmente no existen tipos de Usuarios Activos, verificar en el mantenimiento de Tipos de Usuarios";
                        result.data = new List<REC01_TIPO_USUARIO>();
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
                result.mensaje = "Ocurrio una excepcion al tratar de obtener la lista de tipos, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        /// <summary>
        /// Metodo que lista los usuarios disponibles para modificar la contraseña
        /// </summary>
        /// <returns></returns>
        public Mensaje<List<REC01_USUARIO>> listarUsuarios()
        {
            Mensaje<List<REC01_USUARIO>> result = new Mensaje<List<REC01_USUARIO>>();
            result.codigo = 1;
            result.mensaje = "ocurrio un error en base de datos al tratar de obtener el listado de datos";
            result.data = new List<REC01_USUARIO>();

            try
            {
                using (var db = new RSA02.DO.DATA.EsquemaREC01())
                {
                    var list = (from us in db.REC01_USUARIO where us.ESTADO_REGISTRO == "A" select us).ToList();

                    if (list.Count > 0)
                    {
                        result.data = list;
                    }
                    else
                    {
                        result.codigo = 1;
                        result.mensaje = "Actualmente no existen Usuarios Activos, verificar en el mantenimiento de Usuarios";
                        result.data = new List<REC01_USUARIO>();
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
                result.mensaje = "Ocurrio una excepcion al tratar de obtener la lista de Usuarios, referencia: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        public AutoCompleteStringCollection AutocompletarUsuarios()
        {
            Mensaje<List<REC01_USUARIO>> li = new Mensaje<List<REC01_USUARIO>>();
            Login objlistar = new Login();

            li.data = objlistar.listarUsuarios().data;

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();

            foreach (var item in li.data)
            {
                coleccion.Add(item.USUARIO);
            }
            return coleccion;
        }
    }
}
