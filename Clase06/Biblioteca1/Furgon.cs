using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Furgon : VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;
        public Furgon(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }
        public short CantidadMarchas 
        { 
            get {  return cantidadMarchas; } 
            set {  cantidadMarchas = value; } 
        }
        public int PesoCarga
        {
            get { return pesoCarga; }
            set { pesoCarga = value; }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de ruedas: {CantidadRuedas}");
            sb.AppendLine($"Cantidad de puertas: {CantidadPuertas}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Cantidad de marchas: {CantidadMarchas}");
            sb.AppendLine($"Peso de la carga: {PesoCarga}");
            return sb.ToString();
        }
    }
}
