/*
Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el
usuario por consola.
Validar que el dato ingresado por el usuario sea un número.
Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
Si ingresa "salir", cierra la consola.
Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa,
iterar. De lo contrario, cerrar la consola. 
Nota: Utilizar sentencias de iteración, selectivas y el operador módulo (%).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empieza el programa!");
            int num;            
            while (true)
            {
                Console.Write("Ingrese un numero o finalice con 'salir': ");
                string entrada = Console.ReadLine();
                if (entrada == "salir")
                {
                    break;
                }
                if (!int.TryParse(entrada, out num))
                {
                    Console.Write("Error. Ingrese un numero valido");
                    continue;
                }
                for (int i = 0; i <= num; i++)
                {
                    if (EsPrimo(i))
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.Write("Desea volver a operar? [s/n]: ");
                string respuesta = Console.ReadLine();
                if (respuesta == "n")
                {
                    break;
                }
                else
                {
                    continue;
                }          
            }
            Console.WriteLine("Programa finalizado");
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
