using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public enum EMarcas
    {
        Honda,
        Ford,
        Zanella,
        Scania,
        Iveco,
        Fiat
    }
    public class Vehiculo
    {        
        protected string patente;
        protected byte cantidadRuedas;
        protected EMarcas marca;
        public Vehiculo(string patente, byte cantidadRuedas, EMarcas marca)
        {
            this.patente = patente;
            this.cantidadRuedas = cantidadRuedas;
            this.marca = marca;
        }          
        public string Patente
        {
            get { return this.patente; }
            set { this.patente = value; }
        }
        public byte CantidadRuedas
        {
            get { return this.cantidadRuedas; }
            set { this.cantidadRuedas = value; } 
        }
        public EMarcas Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {Patente}");
            sb.AppendLine($"Cantidad de ruedas: {CantidadRuedas}");
            sb.AppendLine($"Marca: {Marca}");
            return sb.ToString();
        }
        public static bool operator ==(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            if(vehiculo1.Patente == vehiculo2.Patente && vehiculo1.Marca == vehiculo2.Marca)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return !(vehiculo1 == vehiculo2);
        }
    }
}
