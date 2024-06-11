using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Automovil : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int cantidadPasajeros;
        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros) : base(cantidadRuedas,cantidadPuertas,color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
        public short CantidadMarchas
        {
            get { return cantidadMarchas; }
            set { cantidadMarchas = value; }
        }
        public int CantidadPasajeros
        {
            get { return cantidadPasajeros; }
            set { cantidadPasajeros = value; }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de ruedas: {CantidadRuedas}");
            sb.AppendLine($"Cantidad de puertas: {CantidadPuertas}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Cantidad de marchas: {CantidadMarchas}");
            sb.AppendLine($"Cantidad de pasajeros: {CantidadPasajeros}");
            return sb.ToString();
        }
    }
}
