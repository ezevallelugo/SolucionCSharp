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
            Console.WriteLine("Empieza el programa!");
            Automovil auto1 = new Automovil(4, 2, VehiculoTerrestre.Colores.Negro, 3, 4);
            Furgon furgon1 = new Furgon(4, 6, VehiculoTerrestre.Colores.Rojo, 6, 200);
            Ciclomotor ciclomotor1 = new Ciclomotor(2, 0, VehiculoTerrestre.Colores.Azul, 4);
            Console.WriteLine(auto1.Mostrar());
            Console.WriteLine(furgon1.Mostrar());
            Console.WriteLine(ciclomotor1.Mostrar());
            Console.ReadKey();
        }
    }
}
