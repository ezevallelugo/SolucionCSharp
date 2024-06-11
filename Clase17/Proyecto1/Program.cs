using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades1;
namespace Proyecto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saludos vecinirijillo!");
            Supermercado supermercado = new Supermercado();
            supermercado.ArgregarProductos(new Producto("Jabon", 33.5m, 6));
            supermercado.ArgregarProductos(new Producto("Hielo", 10.0m, 4));
            supermercado.ArgregarProductos(new Producto("Cafe", 20.0m, 10));
            supermercado.ArgregarProductos(new Producto("Te", 55.0m, 2));
            supermercado.ArgregarProductos(new Producto("Arroz", 71.0m, 7));
            Console.WriteLine("**********************");
            Console.WriteLine("Lista de precios");
            supermercado.MostrarProductos();
            supermercado.ActualizarPrecios(producto => producto.Precio * 1.1m);
            Console.WriteLine("**********************");
            Console.WriteLine("Nueva lista de precios");
            supermercado.MostrarProductos();
            Console.ReadKey();
        }
    }
}
