using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Ciclomotor : VehiculoTerrestre
    {
        private short cilindrada;
        public Ciclomotor(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada) : base(cantidadRuedas, cantidadPuertas, color) 
        { 
            this.cilindrada = cilindrada;
        }
        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de ruedas: {CantidadRuedas}");
            sb.AppendLine($"Cantidad de puertas: {CantidadPuertas}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Cilindrada (no se que es): {Cilindrada}");
            return sb.ToString();
        }
    }
}
