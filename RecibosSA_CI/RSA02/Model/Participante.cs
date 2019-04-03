using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSA02.DO.DATA;
using RSA02.Clases;

namespace RSA02.Model
{
    public class Participante
    {
        #region Atributos Privados

        private REC01_PARTICIPANTE dbModel;

        #endregion

        #region Propiedades Publicas
        
        public string nit
        {
            get { return dbModel.NIT; }
            set { dbModel.NIT = value; }
        }

        public string nombre
        {
            get { return dbModel.NOMBRE; }
            set { dbModel.NOMBRE = value; }
        }

        public string direccion
        {
            get { return dbModel.DIRECCION; }
            set { dbModel.DIRECCION = value; }
        }

        public string pais
        {
            get { return dbModel.PAIS; }
            set { dbModel.PAIS = value; }
        }

        public string telefono
        {
            get { return dbModel.TELEFONO; }
            set { dbModel.TELEFONO = value; }
        }

        public string estadoRegistro
        {
            get { return dbModel.ESTADO_REGISTRO; }
            set { dbModel.ESTADO_REGISTRO = value; }
        }

        public string usuarioCreacion
        {
            get { return dbModel.USUARIO_CREACION; }
            set { dbModel.USUARIO_CREACION = value; }
        }

        public string usuarioModificacion
        {
            get { return dbModel.USUARIO_MODIFICACION; }
            set { dbModel.USUARIO_MODIFICACION = value; }
        }

        public DateTime? fechaCreacion
        {
            get { return dbModel.FECHA_CREACION; }
            set { dbModel.FECHA_CREACION = value; }
        }

        public DateTime? fechaModificacion
        {
            get { return dbModel.FECHA_MODIFICACION; }
            set { dbModel.FECHA_MODIFICACION = value; }
        }

        #endregion

        #region Constructores

        public Participante()
        {
            dbModel = new REC01_PARTICIPANTE();
        }

        public Participante(REC01_PARTICIPANTE datos)
        {
            dbModel = datos;
        }

        #endregion

        #region Metodos Publicos

        public Mensaje<Participante> obtenerParticipante()
        {
            Mensaje<Participante> result = new Mensaje<Participante>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en Base de Datos";
            result.data = new Participante();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var part = db.REC01_PARTICIPANTE.Where(p => p.NIT.Trim() == this.nit.Trim()).Select(p => p).SingleOrDefault();

                    if (part == null)
                    {
                        result.codigo = -1;
                        result.mensaje = "No existe informacion para el Nit: " + this.nit.ToString() + " Proceda a registrar el Recibo y en automatico quedara agregado el Participante en Base de Datos";
                        result.data = new Participante();
                        return result;
                    }
                    else
                    {
                        dbModel = part;
                    }
                }
                result.codigo = 0;
                result.mensaje = "Ok";
                result.data = this;
                return result;
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion al momento de obtener la informacion, ref: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }

        public Mensaje<Participante> validaInfoParticipante(REC01_RECIBO arg)
        {
            Mensaje<Participante> result = new Mensaje<Participante>();
            result.codigo = 1;
            result.mensaje = "Ocurrio un error en Base de Datos";
            result.data = new Participante();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    //SI EL NIT ES C/F NO ES NECESARIO VALIDAR PARA REGISTRAR O ACTUALIZAR
                    if (arg.NIT != "C/F")
                    {
                        var valida = db.REC01_PARTICIPANTE.Where(p => p.NIT.Trim() == arg.NIT.Trim()).Select(p => p).SingleOrDefault();

                        //SI EXISITE EL NIT, SE COMPARAN DATOS EN BD CON LOS QUE TRAE EL RECIBO Y SE EVALUA SI EXISTEN DIFERENCIAS
                        if (valida != null)
                        {
                            //SI VARIAN LOS DATOS SE PROCEDE A ACTUALIZAR
                            if (valida.NOMBRE != arg.NOMBRE || valida.DIRECCION != arg.DIRECCION || valida.PAIS != arg.PAIS || valida.TELEFONO != arg.TELEFONO)
                            {
                                Mensaje<Participante> resp = actualizarParticipante(arg);
                                result.codigo = resp.codigo;
                                result.mensaje = resp.mensaje;
                                return result;
                            }
                            //SI NO VARIAN LOS DATOS, NO SE REALIZA NINGUNA ACCION
                            else
                            {
                                result.codigo = 0;
                                result.mensaje = "Ok";
                                return result;
                            }
                        }
                        //SI EL NIT NO SE ENCUENTRA EN LA BD SE PROCEDE A REGISTRAR EL NUEVO PARTICIPANTE
                        else
                        {
                            Mensaje<Participante> resp = guardarParticipante(arg);
                            result.codigo = resp.codigo;
                            result.mensaje = resp.mensaje;
                            return result;
                        }
                    }
                    else
                    {
                        result.codigo = 0;
                        result.mensaje = "Ok";
                        return result;
                    }                    
                }
            }
            catch (Exception ex)
            {
                result.codigo = -1;
                result.mensaje = "Ocurrio una excepcion al validar el Participante, ref: " + ex.ToString();
                result.mensajeError = ex.ToString();
                return result;
            }
        }



        #endregion

        #region Metodos Privados

        private Mensaje<Participante> actualizarParticipante(REC01_RECIBO arg)
        {
            Mensaje<Participante> res = new Mensaje<Participante>();
            res.codigo = 1;
            res.mensaje = "Ocurrio un error en Base de datos al Actualizar el Participante";
            res.data = new Participante();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    var actualilza = db.REC01_PARTICIPANTE.Where(p => p.NIT == arg.NIT).Select(p => p).SingleOrDefault();

                    actualilza.NOMBRE = arg.NOMBRE;
                    actualilza.DIRECCION = arg.DIRECCION;
                    actualilza.PAIS = arg.PAIS;
                    actualilza.TELEFONO = arg.TELEFONO;                    
                    actualilza.USUARIO_MODIFICACION = Global.usuariologueado;
                    actualilza.FECHA_MODIFICACION = DateTime.Now;
                    db.SaveChanges();
                }
                res.codigo = 0;
                res.mensaje = "Ok";
                return res;
            }
            catch (Exception ex)
            {
                res.codigo = -1;
                res.mensaje = "Ocurrio una excepcion al actualizar al Participante, ref; " + ex.ToString();
                res.mensajeError = ex.ToString();
                return res;
            }
            
        }

        private Mensaje<Participante> guardarParticipante(REC01_RECIBO arg)
        {
            Mensaje<Participante> res = new Mensaje<Participante>();
            res.codigo = 1;
            res.mensaje = "Ocurrio un error en base de datos";
            res.data = new Participante();

            try
            {
                using (var db = new EsquemaREC01())
                {
                    REC01_PARTICIPANTE nuevo = new REC01_PARTICIPANTE();
                    nuevo.NIT = arg.NIT.Trim();
                    nuevo.NOMBRE = arg.NOMBRE;
                    nuevo.DIRECCION = arg.DIRECCION;
                    nuevo.PAIS = arg.PAIS;
                    nuevo.TELEFONO = arg.TELEFONO;
                    nuevo.ESTADO_REGISTRO = "A";
                    nuevo.USUARIO_CREACION = Global.usuariologueado;
                    nuevo.FECHA_CREACION = DateTime.Now;
                    db.REC01_PARTICIPANTE.Add(nuevo);
                    db.SaveChanges();
                }
                res.codigo = 0;
                res.mensaje = "Se guardo el participante correctamente";
                return res;
            }
            catch (Exception ex)
            {
                res.codigo = -1;
                res.mensaje = "Ocurrio una excepcion al momento de registrar el Participante, ref: " + ex.ToString();
                res.mensajeError = ex.ToString();
                return res;
            }
            
        }

        #endregion

    }
}
