using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita : Producto
    {
        protected static bool _deConsumo;
        protected float _peso;
        static Galletita()
        {
            _deConsumo = true;
        }
        public Galletita()
        {

        }
        public Galletita(int codigoDeBarra, float precio, EMarcaProducto marca, float peso) : base (codigoDeBarra,marca,precio)
        {
            _peso = peso;
        }
        public override float CalcularCostoDeProduccion 
        {
            get { return Precio * 0.33f; }
            set { Precio = value; }
        }
        private static string MostrarGalletita(Galletita galletita1)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)galletita1);
            if (_deConsumo)
            {
                sb.AppendLine($"Es de consumo");
            }
            sb.AppendLine($"Peso: {galletita1._peso}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return MostrarGalletita(this);
        }
        public override string Consumir()
        {
            return "Comestible";
        }
    }
}
