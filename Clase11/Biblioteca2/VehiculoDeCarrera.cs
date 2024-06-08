using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public class VehiculoDeCarrera
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;
        public VehiculoDeCarrera(short numero, string escuderia)
        {
            this.enCompetencia = false;
            this.escuderia = escuderia;
            this.numero = numero;
        }
        public short CantidadDeCombustible
        {
            get { return cantidadCombustible; }
            set { cantidadCombustible = value; }
        }
        public bool EnCompetencia
        {
            get { return enCompetencia; }
            set { enCompetencia = value; }
        }
        public string Escuderia
        {
            get { return escuderia; }
            set {  escuderia = value; }
        }
        public short Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public short VueltasRestantes
        {
            get { return vueltasRestantes; }
            set { vueltasRestantes = value; }
        }
        public static bool operator ==(VehiculoDeCarrera vehiculo1, VehiculoDeCarrera vehiculo2)
        {
            return vehiculo1.numero == vehiculo2.numero && vehiculo1.escuderia == vehiculo2.escuderia;
        }
        public static bool operator !=(VehiculoDeCarrera vehiculo1, VehiculoDeCarrera vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Auto numero: {Numero}");
            sb.AppendLine($"Escuderia: {Escuderia}");            
            sb.AppendLine($"Esta en la competencia?: {EnCompetencia}");
            sb.AppendLine($"Cantidad de combustible: {CantidadDeCombustible}");
            sb.AppendLine($"Cantidad de vuletas restantes: {VueltasRestantes}");            
            return sb.ToString();
        }
    }
}
