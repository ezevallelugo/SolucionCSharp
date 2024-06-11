using Biblioteca1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I01";
            Sumador sumador1 = new Sumador();
            long resultado1 = sumador1.Sumar(20, 30);
            string resultado2 = sumador1.Sumar("2", "1");
            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(sumador1.Cantidad);

            Sumador sumador2 = new Sumador(0);
            long cantidadTotal = sumador1 + sumador2;
            bool igualdad = sumador1 / sumador2;
            Console.WriteLine(cantidadTotal);
            Console.WriteLine(igualdad);
            Console.ReadKey();
        }
    }
}
