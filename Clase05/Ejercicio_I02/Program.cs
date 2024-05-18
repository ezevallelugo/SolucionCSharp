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
            Console.WriteLine("Un proyecto mas");
            List<int> listaEnteros = new List<int>();
            Stack<int> pilaEnterosPositivos = new Stack<int>();
            Queue<int> colaEnterosNegativos = new Queue<int>();
            int numeroAleatorio;
            Random variableRandom = new Random();
            for (int i = 0; i < 20; i++)
            {
                do
                {
                    numeroAleatorio = variableRandom.Next(-100, 100);
                } while (numeroAleatorio == 0);
                listaEnteros.Add(numeroAleatorio);
            }
            Console.WriteLine("Lista de enteros");
            foreach (int numero in listaEnteros)
            {
                Console.WriteLine(numero);
            }
            foreach (int numero in listaEnteros)
            {
                if (numero > 0)
                {
                    pilaEnterosPositivos.Push(numero);
                }
                else
                {
                    colaEnterosNegativos.Enqueue(numero);
                }
            }
            List<int> listaPositivosDecreciente = new List<int>(pilaEnterosPositivos);
            listaPositivosDecreciente.Sort(); //Ordena de mayor a menor
            //listaPositivosDecreciente.Reverse(); //Le da vuelta
            Stack<int> pila1 = new Stack<int>(listaPositivosDecreciente);
            Console.WriteLine("Lista positivos decreciente:");
            foreach (int numero in pila1)
            {
                Console.WriteLine(numero);
            }
            List<int> listaNegativosCreciente = new List<int>(colaEnterosNegativos);
            listaNegativosCreciente.Sort();
            Queue<int> cola1 = new Queue<int>(listaNegativosCreciente);
            Console.WriteLine("Lista negativos creciente:");
            foreach (int numero in cola1)
            {
                Console.WriteLine(numero);
            }
            Console.ReadKey();
        }
    }
}
