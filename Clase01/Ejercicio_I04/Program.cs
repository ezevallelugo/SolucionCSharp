using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            Console.WriteLine("Inicio del programa");
            for (int i = 0; i < 10; i++)
            {
                if (EsPrimo(i))
                {
                    double resultadoPotencia = Math.Pow(2, i - 1);
                    double resultadoResta = Math.Pow(2, i) - 1;
                    double resultado = resultadoPotencia * resultadoResta;
                    Console.WriteLine(resultado);
                    contador++;
                }
                if (contador == 4)
                {
                    break;
                }
            }
            Console.ReadKey();
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;
            if (numero <= 3)
                return true;
            if (numero % 2 == 0 || numero % 3 == 0)
                return false;
            int i = 5;
            while (i * i <= numero)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                    return false;
                i += 6;
            }
            return true;
        }
    }
}
