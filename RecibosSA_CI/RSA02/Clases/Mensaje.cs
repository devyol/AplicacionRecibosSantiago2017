using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSA02.Clases
{
    public class Mensaje<T>
    {
        public int codigo { get; set; }
        public string mensaje { get; set; }
        public string mensajeError { get; set; }
        public int totalRecords { get; set; }
        public T data { get; set; }
        public Mensaje() { }
    }
}
