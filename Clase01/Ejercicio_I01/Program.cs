/*
Ingresar 5 números por consola, guardándolos en una variable escalar. Luego calcular y
mostrar: el valor máximo, el valor mínimo y el promedio.
Nota: Un escalar es una constante o variable que contiene un dato atómico y
unidimensional. En contraposición al concepto de escalar, están los conceptos de array, lista
y objeto, que pueden tener almacenado en su estructura más de un valor.
 */

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
            Console.WriteLine("Empieza el programa!");
            int num;
            int maximo = 0;
            int minimo = 0;
            int acumulador = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                while (!int.TryParse(Console.ReadLine(), out num))
                {
                    Console.Write("Error. Reintente: ");
                }
                if (i == 0)
                {
                    maximo = num;
                    minimo = num;
                }
                else
                {
                    if (num > maximo)
                    {
                        maximo = num;
                    }
                    if (num < minimo)
                    {
                        minimo = num;
                    }
                }
                acumulador += num;
            }
            float promedio = (float)acumulador / 5;
            Console.WriteLine($"El numero mayor es: {maximo}");
            Console.WriteLine($"El numero menor es: {minimo}");
            Console.WriteLine($"El promedio es: {promedio:#,###.00}");

            Console.ReadKey();
        }
    }
}
