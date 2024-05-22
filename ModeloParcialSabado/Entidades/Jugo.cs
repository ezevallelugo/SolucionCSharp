using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo : Producto
    {
        protected static bool _deConsumo;
        protected ESaborJugo _sabor;
        static Jugo()
        {
            _deConsumo = true;
        }
        public Jugo() 
        {
            
        }
        public Jugo(int codigoDeBarra, float precio, EMarcaProducto marca, ESaborJugo sabor) : base (codigoDeBarra, marca, precio)
        {
            _sabor = sabor;
        }
        public override float CalcularCostoDeProduccion
        {
            get { return Precio * 0.4F ; }
            set { Precio = value; } 
        }
        private string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            if (_deConsumo)
            {
                sb.AppendLine($"Es para consumir");
            }
            sb.AppendLine($"Sabor: {_sabor}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return MostrarJugo();
        }
        public override string Consumir()
        {
            return "Bebible";
        }
    }
}
