/*
Realizar un programa que sume números enteros hasta que el usuario lo determine por
medio de un mensaje "¿Desea continuar? (S/N)".
Crear la clase Validador y el método estático ValidarRespuesta, que validará el
ingreso de respuestas.

UTN Fra Avellaneda – Laboratorio y Programación II
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se
ingresó cualquier otro valor. 
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
            int acumulador = 0;
            int numero;
            string respuesta;
            Console.WriteLine("Empieza el programa!");
            while(true)
            {
                Console.Write("Ingrese un numero: ");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.Write("Error. Ingrese un numero valido: ");
                }
                acumulador += numero;
                Console.WriteLine($"El numero acumulado es {acumulador}");
                Console.Write("Desea  continuar? (s/n): ");
                respuesta = Console.ReadLine();
                if (Validador.ValidarRespuestas(respuesta))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine($"Programa finalizado");
            Console.ReadKey();
        }
    }
}
