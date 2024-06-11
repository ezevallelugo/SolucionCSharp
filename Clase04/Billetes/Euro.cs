using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        #region Atributos
        private double cantidad;
        private static double cotzRespectoDolar;
        #endregion
        #region Constructores
        static Euro()
        {
            cotzRespectoDolar = 1.17;
        }
        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion) : this (cantidad)
        {
            cotzRespectoDolar = cotizacion;
        }
        #endregion
        #region Propiedades
        public double GetCantidad()
        {
            return cantidad;
        }
        public static double GetCotizacion()
        {
            return cotzRespectoDolar;
        }
        #endregion
        #region Metodo Implicito
        public static implicit operator Euro(double e)
        {
            return new Euro(e);
        }
        #endregion
        #region Metodo Explicito
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * Euro.GetCotizacion());
        }
        public static explicit operator Peso(Euro e)
        {
            //return new Peso(e.GetCantidad() * Euro.GetCotizacion() * Peso.GetCotizacion());
            return (Peso)(Dolar)e;
        }
        #endregion
        #region Metodo Comparador y Aritmetico
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad() == e2.GetCantidad();
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        public static bool operator ==(Euro e1, Peso p1)
        {
            return e1.GetCantidad() == p1.GetCantidad();
        }
        public static bool operator !=(Euro e1, Peso p1)
        {
            return !(e1 == p1);
        }
        public static bool operator ==(Euro e1, Dolar d1)
        {
            return e1.GetCantidad() == d1.GetCantidad();
        }
        public static bool operator !=(Euro e1, Dolar d1)
        {
            return !(e1 == d1);
        }
        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() - ((Euro)d).GetCantidad());
        }
        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() - ((Euro)p).GetCantidad());
        }
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad() + ((Euro)d).GetCantidad());
        }
        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad() + ((Euro)p).GetCantidad());
        }
        #endregion
    }
}
