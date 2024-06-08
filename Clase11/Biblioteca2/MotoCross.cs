using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public class MotoCross : VehiculoDeCarrera
    {
        private short cilindrada;
        public MotoCross(short numero, string escuderia) : base(numero, escuderia)
        {
            CantidadDeCombustible = 0;
            VueltasRestantes = 0;
        }
        public MotoCross(short numero, string escuderia, short cilindrada) : this(numero, escuderia)
        {
            this.cilindrada = cilindrada;
        }
        public short Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }
        public static bool operator ==(MotoCross moto1, MotoCross moto2)
        {
            return moto1 == moto2 && moto1.Cilindrada == moto2.Cilindrada;
        }
        public static bool operator !=(MotoCross moto1, MotoCross moto2)
        {
            return !(moto1 == moto2);
        }
        public string MostrarDatos()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(base.MostrarDatos());
            stringBuilder.AppendLine($"Cilindrada: {Cilindrada}");
            return stringBuilder.ToString();
        }
    }
}
