using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace RSA02.Clases
{
    public static class Global
    {
        public static string usuariologueado { get; set; }
        public static string tipousuario { get; set; }
        public static string tipousuarioid { get; set; }
        public static decimal eventoActivo { get; set; }
        public static string nombreeventoActivo { get; set; }
        public static Nullable<decimal> correlativousuario { get; set; }
        public static decimal mediodepago { get; set; }
        public static string serieActiva { get; set; }
                
        public static void sololetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
                
        public static void NumeroDecimal(KeyPressEventArgs e, TextBox te)
        {
            char tecla = e.KeyChar;
            if (te.Text.Contains("."))
            {
                if (Char.IsDigit(tecla) || tecla == 8)
                {
                    e.Handled = false;//No se bloque el evento
                }
                else
                {
                    e.Handled = true;//Se bloquea el evento
                }
            }
            else
            {
                if (Char.IsDigit(tecla) || tecla == 8 || tecla == 46)
                {
                    e.Handled = false;//No se bloque el evento
                }
                else
                {
                    e.Handled = true;//Se bloquea el evento
                }
            }

        }
        
    }
}
