using Biblioteca1;
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
            Console.Title = " Ejercicio Nro 01: Sobre-Sobrescrito";
            SobreSobrescrito objetoSobrescrito = new SobreSobrescrito();
            Console.WriteLine(objetoSobrescrito.ToString());
            string objeto = "¡Este es mi método ToString sobrescrito!";
            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());
            Console.WriteLine(objetoSobrescrito.MiPropiedad);
            Console.WriteLine(objetoSobrescrito.MiMetodo());
            Console.ReadKey();
        }
    }
}
