using Biblioteca1;
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
            Persona persona1 = new Persona("Ezequiel", new DateTime(1998, 02, 28), 40923387);
            Persona persona2 = new Persona("Leandro", new DateTime(2000, 02, 28), 40122437);
            Persona persona3 = new Persona("Gonzalo", new DateTime(2015, 02, 28), 41876445);
            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());
            Console.ReadKey();  
        }
    }
}
