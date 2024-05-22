using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina : Producto
    {
        protected static bool _deConsumo;
        protected ETipoHarina _tipo;
        static Harina()
        {
            _deConsumo = false;
        }
        public Harina()
        {

        }
        public Harina(int codigoDeBarra, float precio, EMarcaProducto marca, ETipoHarina tipo) : base (codigoDeBarra, marca, precio)
        {
            _tipo = tipo;
        }
        public override float CalcularCostoDeProduccion
        {
            get { return Precio * 0.6F; }
            set { Precio = value; }
        }
        private static string MostrarHarina(Harina harina1)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)harina1);
            if (_deConsumo)
            {
                sb.AppendLine($"Es de consumo");
            }
            sb.AppendLine($"Tipo: {harina1._tipo}");
            return sb.ToString();
        }
        public override string ToString()
        {
            return MostrarHarina(this);
        }
    }
}
