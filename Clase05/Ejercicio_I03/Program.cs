using Biblioteca1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empieza el programa!");
            Jugador jugador1 = new Jugador(28374612, "Pedro", 10, 10);
            Jugador jugador2 = new Jugador(48765384, "Marcelo");
            Jugador jugador3 = new Jugador(87676534, "Santiago", 0, 20);
            Jugador jugador4 = new Jugador(12345678, "Sofia", 4, 5);
            Jugador jugador5 = new Jugador(34546755, "Camila", 7, 15);
            Jugador jugador6 = new Jugador(12345678, "Fernando", 7, 7);
            /*Console.WriteLine(jugador1.MostrarDatos());
            Console.WriteLine(jugador2.MostrarDatos());
            Console.WriteLine(jugador3.MostrarDatos());
            Console.WriteLine(jugador4.MostrarDatos());
            Console.WriteLine(jugador5.MostrarDatos());
            Console.WriteLine(jugador6.MostrarDatos());*/
            Equipo equipo1 = new Equipo(3, "Equipo dinamita");
            Equipo equipo2 = new Equipo(2, "Equipo esmeralda");
            if(equipo1 + jugador1)
            {
                Console.WriteLine("Entro");
            }
            else
            {
                Console.WriteLine("No entro");
            }
            if (equipo1 + jugador2)
            {
                Console.WriteLine("Entro");
            }
            else
            {
                Console.WriteLine("No entro");
            }
            if (equipo1 + jugador3)
            {
                Console.WriteLine("Entro");
            }
            else
            {
                Console.WriteLine("No entro");
            }
            if (equipo1 + jugador4)
            {
                Console.WriteLine("Entro");
            }
            else
            {
                Console.WriteLine("No entro");
            }
            foreach (Jugador j in equipo1.GetListaJugadores)
            {
                Console.WriteLine(j.MostrarDatos());
            }
            Console.ReadKey();  
        }
    }
}
