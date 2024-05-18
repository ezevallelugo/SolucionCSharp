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
            Random variableRandom = new Random();
            int numeroAleatorio;
            int[] arrayNumeros = new int[20];
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                do
                {
                    numeroAleatorio = variableRandom.Next(-100, 100);
                } while (numeroAleatorio == 0);
                arrayNumeros[i] = numeroAleatorio;
            }
            //Muestro array original
            Console.WriteLine("Lista de numeros original");
            MostrarLista(arrayNumeros);
            //Muestro array decreciente de positivos
            Console.WriteLine("Lista numeros positivos decreciente");
            for (int i = 0;i < arrayNumeros.Length - 1; i++)
            {
                for (int j = 0; j < arrayNumeros.Length - i - 1; j++)
                {
                    if (arrayNumeros[j] < arrayNumeros[j+1])
                    {
                        int aux = arrayNumeros[j];
                        arrayNumeros[j] = arrayNumeros[j + 1];
                        arrayNumeros[j + 1] = aux;
                    }
                }
            }
            //Array.Sort(arrayNumeros); //Ordena de menor a mayor
            //Array.Reverse(arrayNumeros); //Ordena la lista al reves
            for (int i = 0;i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] > 0)
                {
                    Console.WriteLine(arrayNumeros[i]);
                }
            }
            Console.WriteLine("Lista numeros negativos creciente");
            for (int i = 0; i < arrayNumeros.Length - 1; i++)
            {
                for (int j = 0; j < arrayNumeros.Length - i - 1; j++)
                {
                    if (arrayNumeros[j] > arrayNumeros[j + 1])
                    {
                        int aux = arrayNumeros[j];
                        arrayNumeros[j] = arrayNumeros[j + 1];
                        arrayNumeros[j + 1] = aux;
                    }
                }
            }
            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                if (arrayNumeros[i] < 0)
                {
                    Console.WriteLine(arrayNumeros[i]);
                }
            }
            Console.ReadKey();

        }

        static void MostrarLista(int[] lista)
        {
            foreach (int elemento in lista)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}
