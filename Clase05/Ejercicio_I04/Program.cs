using Biblioteca1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empieza el programa!");
            AutoF1 auto1 = new AutoF1(95, "Rusteze");
            AutoF1 auto2 = new AutoF1(86, "HTB");
            AutoF1 auto3 = new AutoF1(43, "Dinoco");
            AutoF1 auto4 = new AutoF1(1, "Formula FB1");
            AutoF1 auto5 = new AutoF1(20, "IGNRT");
            AutoF1 auto6 = new AutoF1(95, "Rusteze");
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine(rnd.Next(15,100));
            }
            /*Console.WriteLine(auto1.MostrarDatos());
            Console.WriteLine(auto2.MostrarDatos());
            Console.WriteLine(auto3.MostrarDatos());*/
            Competencia copaPiston = new Competencia(20, 3);
            if (copaPiston + auto1)
            {
                Console.WriteLine(auto1.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No entro");
            }
            if (copaPiston + auto2)
            {
                Console.WriteLine(auto2.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No entro");
            }
            if (copaPiston + auto6)
            {
                Console.WriteLine(auto6.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No entro");
            }
            if (copaPiston + auto3)
            {
                Console.WriteLine(auto3.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No entro");
            }
            if (copaPiston + auto4)
            {
                Console.WriteLine(auto4.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No entro");
            }
            if (copaPiston + auto5)
            {
                Console.WriteLine(auto5.MostrarDatos());
            }
            else
            {
                Console.WriteLine("No entro");
            }

            Console.ReadKey();
        }
    }
}
