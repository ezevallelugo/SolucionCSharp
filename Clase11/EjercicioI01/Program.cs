using Biblioteca1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!");
            try
            {
                OtraClase otraClase = new OtraClase();
                otraClase.OtroMetodo();
            }
            catch (MiExcepcion excepcion)
            {
                Console.WriteLine($"Esta es mi expecion: {excepcion.Message}");
                Exception inner = excepcion.InnerException;
                while ( inner != null )
                {
                    Console.WriteLine($"InnerExpection: {inner.Message}");
                    //Si quito esto va al infinito
                    inner = inner.InnerException;
                }
            }
            Console.ReadKey();
        }
    }
}
