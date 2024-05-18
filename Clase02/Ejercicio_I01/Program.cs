using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int numero;
            int suma = 0;
            double promedio;
            int acumulador = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese un numero mayor a -100 y menor a 100 ({i + 1}): ");
                numero = Int32.Parse(Console.ReadLine());
                if(Validador.Validar(numero,-100,100))
                {
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    suma += numero;
                }
                else
                {
                    Console.WriteLine("No cumple dentro del rango");
                    i--;
                }
                acumulador += numero;
            }
            promedio = (double)acumulador / 10;
            Console.WriteLine($"El maximo es {maximo}");
            Console.WriteLine($"El minimo es {minimo}");
            Console.WriteLine($"El promedio es {promedio}");

            Console.ReadKey();
        }
    }
}
