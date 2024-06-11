using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        #region Atributos
        private double cantidad;
        private static double cotzRespectoDolar;
        #endregion
        #region Constructores
        static Dolar()
        {
            cotzRespectoDolar = 1;
        }
        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion) : this (cantidad)
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
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }
        #endregion
        #region Metodo Explicito
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad() / Euro.GetCotizacion());
        }
        public static explicit operator Peso(Dolar d)
        {
            return new Peso(d.GetCantidad() * Peso.GetCotizacion());
        }
        #endregion
        #region Metodo Comparativo y Aritmetico
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.GetCantidad() == d2.GetCantidad();
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }
        public static bool operator ==(Dolar d1, Peso p1)
        {
            return d1.GetCantidad() == p1.GetCantidad();
        }
        public static bool operator !=(Dolar d1, Peso p1)
        {
            return !(d1 == p1);
        }
        public static bool operator ==(Dolar d1, Euro e1)
        {
            return d1.GetCantidad() == e1.GetCantidad();
        }
        public static bool operator !=(Dolar d1, Euro e1)
        {
            return !(d1 == e1);
        }
        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)e).GetCantidad());
        }
        public static Dolar operator -(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() - ((Dolar)p).GetCantidad());
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)e).GetCantidad());
        }
        public static Dolar operator +(Dolar d, Peso p)
        {
            return new Dolar(d.GetCantidad() + ((Dolar)p).GetCantidad());
        }
        #endregion
    }
}
