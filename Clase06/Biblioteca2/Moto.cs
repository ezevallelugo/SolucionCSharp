using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public class Moto : Vehiculo
    {
        protected float cilindrada;
        public Moto(string patente, byte cantidadRuedas, EMarcas marca, float cilindrada) : base(patente, cantidadRuedas, marca)
        {
            this.cilindrada = cilindrada;   
        }
        public float Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }
        public string MostrarMoto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Mostrar());
            sb.AppendLine($"Cilindrada: {Cilindrada}");
            return sb.ToString();
        }
    }
}
