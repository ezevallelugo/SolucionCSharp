using Biblioteca2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioI03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empieza el programa!");
            AutoF1 auto1 = new AutoF1(95, "Rusteze",5);
            AutoF1 auto2 = new AutoF1(86, "HTB",2);
            AutoF1 auto3 = new AutoF1(95, "Rusteze", 5);
            AutoF1 auto4 = new AutoF1(43, "Dinoco",7);
            AutoF1 auto5 = new AutoF1(1, "Formula FB1", 10);
            MotoCross moto1 = new MotoCross(99, "Sanchez", 6);
            MotoCross moto2 = new MotoCross(98, "Perez", 7);
            MotoCross moto3 = new MotoCross(97, "Godling", 8);
            MotoCross moto4 = new MotoCross(96, "Mojo", 9);

            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {

                Console.WriteLine(rnd.Next(15, 100));
            }
            /*Console.WriteLine(auto1.MostrarDatos());
            Console.WriteLine(auto2.MostrarDatos());
            Console.WriteLine(auto3.MostrarDatos());*/
            Competencia copaPiston = new Competencia(3, 30, ETipoCompetencia.F1);
            if (copaPiston + auto1)
            {
                Console.WriteLine("Se agregó");
            }            
            if (copaPiston + auto2)
            {
                Console.WriteLine("Se agregó");
            }
            if (copaPiston + auto3)
            {
                Console.WriteLine("Se agregó");
            }
            if (copaPiston + auto4)
            {
                Console.WriteLine("Se agregó");
            }
            if (copaPiston + auto5)
            {
                Console.WriteLine("Se agregó");
            }
            Console.WriteLine(copaPiston.MostrarDatos());
            Console.WriteLine("Fin del programa!");
            Console.ReadKey();
        }
    }
}
