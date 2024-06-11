using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Sumador
    {
        private int cantidadSumas;
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this (0)
        {

        }
        public int Cantidad
        {
            get { return cantidadSumas; }
            set { cantidadSumas = value; }
        }
        public long Sumar(long num1, long num2)
        {
            cantidadSumas++;
            return num1 + num2;
        }
        public string Sumar(string str1, string str2)
        {
            cantidadSumas++;
            return str1 + str2;
        }
        public static explicit operator int (Sumador sumador)
        {
            return sumador.cantidadSumas;
        }
        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas + sumador2.cantidadSumas;
        }
        public static bool operator /(Sumador sumador1, Sumador sumador2)
        {
            return sumador1.cantidadSumas == sumador2.cantidadSumas;
        }
    }
}
