using Biblioteca2;
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
            Rectangulo rectangulo = new Rectangulo(12F,10F);   
            Circulo circulo = new Circulo(5F);
            Cuadrado cuadrado = new Cuadrado(3F);
            //Console.WriteLine(rectangulo.Dibujar());
            //Console.WriteLine(circulo.Dibujar());
            //Console.WriteLine(cuadrado.Dibujar());
            List<Figura> listaFiguras = new List<Figura>();            
            listaFiguras.Add(rectangulo);
            listaFiguras.Add(circulo);
            listaFiguras.Add(cuadrado);
            foreach (Figura figurita in listaFiguras)
            {
                Console.WriteLine("*********************");
                Console.WriteLine($"Tipo: {figurita.GetType():#,###.00}");
                Console.WriteLine(figurita.Dibujar());
                Console.WriteLine($"Area: {figurita.CalcularSuperficie():#,###.00}");
                Console.WriteLine($"Perimetro: {figurita.CalcularPerimetro():#,###.00}");                
            }
            Console.ReadKey();
        }
    }
}
