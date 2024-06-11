using Billetes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Euro billeteEuro = 1;
            Console.WriteLine($"Euros: {billeteEuro.GetCantidad(),10:#,###.00}");
            Peso billetePeso = (Peso)billeteEuro;
            Console.WriteLine($"Pesos: {billetePeso.GetCantidad(),10:#,###.00}");

            Console.WriteLine(" ***********************************");

            Dolar billeteDolar = 1;
            Console.WriteLine($"Dolar: {billeteDolar.GetCantidad(),10:#,###.00}");
            Peso billetito = (Peso)billeteDolar;
            Console.WriteLine($"Pesos: {billetito.GetCantidad(),10:#,###.00}");

            Console.WriteLine(" ************************************");

            Peso billetin = 1;
            Console.WriteLine($"Pesos: {billetin.GetCantidad(),10:#,###.00}");
            Euro billetinEuro = (Euro)billetin;
            Console.WriteLine($"Euros: {billetinEuro.GetCantidad(),10:#,###.00}");

            Console.WriteLine(" **********************************");
            Peso unPeso = 1;
            Console.WriteLine($"Pesos: {unPeso.GetCantidad(),10:#,###.00}");
            Dolar dolarito = (Dolar)unPeso;
            Console.WriteLine($"Dolar: {dolarito.GetCantidad(),10:#,###.00}");

            Console.WriteLine("*******************************");

            Peso pesos = 200;
            Peso pesos2 = 200;
            Euro euros = 300;
            Dolar dolares = 500;

            Peso sumaPesos = pesos + euros;
            Euro restaEuro = euros - dolares;
            Dolar sumaDolar = dolares + pesos;

            Console.WriteLine($"Suma de peso y euro: {sumaPesos.GetCantidad(),20:#,###.00}");
            Console.WriteLine($"Resta de euro y dolar: {restaEuro.GetCantidad(),20:#,###.00}");
            Console.WriteLine($"Suma de dolar y peso: {sumaDolar.GetCantidad(),20:#,###.00}");

            Console.WriteLine($"pesos es igual a dolares?: {pesos == dolares}");
            Console.WriteLine($"euros es igual a euros?: {pesos == pesos2}");
            Console.WriteLine($"dolares es distinto a pesos?: {dolares != pesos}");

            Console.ReadKey();
        }
    }
}
