using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa : Producto
    {
        protected static bool _deConsumo;
        protected float _litros;
        static Gaseosa()
        {
            _deConsumo = true;
        }
        public Gaseosa()
        {

        }
        public Gaseosa(int codigoDeBarra,   float precio,EMarcaProducto marca, float litros) : base (codigoDeBarra,marca,precio)
        {
            _litros = litros;
        }
        public Gaseosa(Producto producto, float litros) : this (producto.CodigoDeBarra,producto.Precio,producto.Marca,litros)
        {

        }            
        public override float CalcularCostoDeProduccion
        {
            get { return Precio * 0.42F; }
            set { Precio = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="gaseosa1"></param>
        /// <returns></returns>
        private static string MostrarGaseosa(Gaseosa gaseosa1)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)gaseosa1);
            if (_deConsumo)
            {
                sb.AppendLine($"Es de consumo");
            }
            sb.AppendLine($"Litros: {gaseosa1._litros}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return MostrarGaseosa(this);
        }
        public override string Consumir()
        {
            return "Bebible";
        }

    }
}
