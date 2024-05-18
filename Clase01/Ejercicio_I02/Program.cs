/*
Ingresar un número y mostrar el cuadrado y el cubo del mismo. Se debe validar que el
número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar
número!".
Nota: Utilizar el método Pow de la clase Math para calcular las potencias. 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empieza el programa!");
            double num;
            Console.Write("Ingrese un numero: ");
            while (!double.TryParse(Console.ReadLine(), out num) || num < 1)
            {
                Console.Write("Error. Reingresar el numero: ");
            }
            double cuadradro = Math.Pow(num, 2);
            double cubo = Math.Pow(num, 3);
            Console.WriteLine($"El cuadrado de {num} es {cuadradro:#,###.00} y el cubo es {cubo:#,###.00}");
            Console.ReadKey();
        }
    }
}
