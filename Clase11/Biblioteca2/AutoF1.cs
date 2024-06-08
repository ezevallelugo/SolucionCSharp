using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public class AutoF1 : VehiculoDeCarrera
    {
        private short caballoDeFuerza;
        public AutoF1(short numero, string escuderia) : base (numero, escuderia)
        {
            CantidadDeCombustible = 0;
            VueltasRestantes = 0;
        }
        public AutoF1(short numero, string escuderia, short caballoDeFuerza) : this(numero, escuderia)
        {
            this.caballoDeFuerza = caballoDeFuerza;
        }
        public short CaballoDeFuerza
        {
            get { return caballoDeFuerza; }
            set { caballoDeFuerza = value; }
        }
        public static bool operator ==(AutoF1 auto1, AutoF1 auto2)
        {
            return auto1 == auto2 && auto1.CaballoDeFuerza == auto2.CaballoDeFuerza;
        }
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine($"Caballos de fuerza: {CaballoDeFuerza}");
            return sb.ToString();
        }
    }
}
