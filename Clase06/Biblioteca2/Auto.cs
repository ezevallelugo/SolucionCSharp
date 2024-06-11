using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public class Auto : Vehiculo
    {
        protected int cantidadAsientos;
        public Auto(string patente, byte cantidadRuedas, EMarcas marca, int cantidadAsientos) : base (patente,cantidadRuedas,marca)
        {
            this.cantidadAsientos = cantidadAsientos;
        }
        public int CantidadAsientos
        {
            get { return cantidadAsientos; }
            set { cantidadAsientos = value; }
        }
        public string MostrarAuto()
        {
            //base.Mostrar();
            StringBuilder sb = new StringBuilder();
            sb.Append(Mostrar());
            sb.AppendLine($"Cantidad de asientos: {CantidadAsientos}");          
            return sb.ToString();
        }
    }
}
