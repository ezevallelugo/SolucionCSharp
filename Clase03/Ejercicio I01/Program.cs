using Biblioteca1;
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
            Console.Title = "Ejercicio_I01";
            Console.WriteLine("Empieza el programa!");
            Cuenta miCuenta = new Cuenta("Ezequiel", 10000);
            Console.WriteLine(miCuenta.Mostrar());
            miCuenta.Ingresar(-200);
            miCuenta.Retirar(20000);
            Console.WriteLine(miCuenta.Mostrar());
            Console.ReadKey();
        }
    }
}
