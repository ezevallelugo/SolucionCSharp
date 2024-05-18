using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos una instancia de la clase Random para generar números aleatorios
            Random rnd = new Random();

            // Creamos un array para almacenar los números
            int[] numeros = new int[20];

            // Llenamos el array con números aleatorios distintos de cero
            for (int i = 0; i < numeros.Length; i++)
            {
                int numeroAleatorio;
                do
                {
                    numeroAleatorio = rnd.Next(-100, 101); // Genera números aleatorios entre -100 y 100
                } while (numeroAleatorio == 0 || Array.IndexOf(numeros, numeroAleatorio) != -1); // Aseguramos que el número no sea cero ni se repita
                numeros[i] = numeroAleatorio;
            }

            // Mostramos el vector tal como fue ingresado
            Console.WriteLine("Vector original:");
            MostrarVector(numeros);

            // Ordenamos los números positivos en forma decreciente
            Array.Sort(numeros, (a, b) => Math.Sign(b) - Math.Sign(a));
            int[] positivos = Array.FindAll(numeros, n => n > 0);

            // Mostramos los números positivos ordenados
            Console.WriteLine("\nPositivos ordenados en forma decreciente:");
            MostrarVector(positivos);

            // Ordenamos los números negativos en forma creciente
            Array.Sort(numeros, (a, b) => Math.Sign(a) - Math.Sign(b));
            int[] negativos = Array.FindAll(numeros, n => n < 0);

            // Mostramos los números negativos ordenados
            Console.WriteLine("\nNegativos ordenados en forma creciente:");
            MostrarVector(negativos);

            Console.ReadLine();
        }

        // Método para mostrar un vector en la consola
        static void MostrarVector(int[] vector)
        {
            foreach (int num in vector)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
