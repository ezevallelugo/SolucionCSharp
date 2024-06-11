using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Peso
    {
        #region Atributos
        private double cantidad;
        private static double cotzRespectoDolar;
        #endregion
        #region Constructores
        static Peso()
        {
            cotzRespectoDolar = 102.65;
        }
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion) : this (cantidad)
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
        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }
        #endregion
        #region Metodo Explicito
        public static explicit operator Euro(Peso p)
        {
            return (Euro)(Dolar)p;
        }        
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.GetCantidad() / Peso.GetCotizacion());
        }
        #endregion
        #region Metodo Comparador y Aritmetico
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad() == p2.GetCantidad();
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        public static bool operator ==(Peso p1, Dolar d1)
        {
            return p1.GetCantidad() == d1.GetCantidad();
        }
        public static bool operator !=(Peso p1, Dolar d1)
        {
            return !(d1 == p1);
        }
        public static bool operator ==(Peso p1, Euro e1)
        {
            return p1.GetCantidad() == e1.GetCantidad();
        }
        public static bool operator !=(Peso p1, Euro e1)
        {
            return !(p1 == e1);
        }
        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() - ((Peso)e).GetCantidad());
        }
        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(d.GetCantidad() - ((Peso)p).GetCantidad());
        }
        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad() + ((Peso)e).GetCantidad());
        }
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad() + ((Peso)d).GetCantidad());
        }
        #endregion
    }
}
