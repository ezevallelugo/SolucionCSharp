using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class VehiculoTerrestre
    {
        public enum Colores
        {
            Rojo,
            Blanco,
            Azul,
            Gris,
            Negro
        }
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)
        {
            this.cantidadRuedas = cantidadRuedas;
            this.cantidadPuertas = cantidadPuertas;
            this.color = color;
        }
        public short CantidadRuedas
        {
            get { return cantidadRuedas; }
            set { cantidadRuedas = value; }
        }
        public short CantidadPuertas
        {
            get { return cantidadPuertas; }
            set { cantidadPuertas = value; }
        }
        public Colores Color
        {
            get { return color; }
            set { color = value; }
        }
    }
}
