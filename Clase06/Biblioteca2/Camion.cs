using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public class Camion : Vehiculo
    {
        protected float tara; //Peso sin contar el contenido 
        public Camion(string patente, byte cantidadRuedas, EMarcas marca, float tara) : base(patente, cantidadRuedas, marca)
        {
            this.tara = tara;
        }
        public float Tara
        {
            get { return tara; }
            set { tara = value; }
        }
        public string MostarCamion()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Mostrar());
            sb.AppendLine($"Tara: {Tara}");
            return sb.ToString();
        }
    }
}
