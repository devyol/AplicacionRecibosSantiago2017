//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RSA02.DO.DATA
{
    using System;
    using System.Collections.Generic;
    
    public partial class REC01_MEDIO_PAGO
    {
        public REC01_MEDIO_PAGO()
        {
            this.REC01_RECIBO = new HashSet<REC01_RECIBO>();
        }
    
        public decimal MEDIO_PAGO { get; set; }
        public string DESCRIPCION { get; set; }
        public string ESTADO_REGISTRO { get; set; }
        public string USUARIO_CREACION { get; set; }
        public Nullable<System.DateTime> FECHA_CREACION { get; set; }
        public string USUARIO_MODIFICACION { get; set; }
        public Nullable<System.DateTime> FECHA_MODIFICACION { get; set; }
    
        public virtual ICollection<REC01_RECIBO> REC01_RECIBO { get; set; }
    }
}
