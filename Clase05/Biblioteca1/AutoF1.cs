using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        public AutoF1(short numero,string escuderia)
        {
            this.numero = numero;
            this.escuderia = escuderia;
            enCompetencia = false;
            cantidadCombustible = 0;
            vueltasRestantes = 0;
        }
        public short CantidadCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }
        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set { enCompetencia = value; }
        }
        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { vueltasRestantes = value;}
        }
        public static bool operator == (AutoF1 auto1, AutoF1 auto2)
        {
            if (auto1.numero == auto2.numero && auto1.escuderia == auto2.escuderia)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(AutoF1 auto1, AutoF1 auto2)
        {
            return !(auto1 == auto2);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("***************************");
            sb.AppendLine($"Numero: {numero}");
            sb.AppendLine($"Escuderia: {escuderia}");
            sb.AppendLine($"Cantidad de combustible: {cantidadCombustible}");
            sb.AppendLine($"Vueltas restantes: {vueltasRestantes}");
            sb.AppendLine("***************************");
            return sb.ToString();
        }
    }
}
