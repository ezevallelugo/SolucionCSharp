using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades1
{
    public class Supermercado
    {
        private List<Producto> listaProductos;
        public Supermercado()
        {
            listaProductos = new List<Producto>();
        }
        public List<Producto> ListaProductos
        {
            get { return listaProductos; }
            set { listaProductos = value; }
        }
        public void ArgregarProductos(Producto producto)
        {
            listaProductos.Add(producto);   
        }
        public void ActualizarPrecios(Func<Producto,decimal> delegado)
        {
            foreach (Producto producto in listaProductos)
            {
                producto.Precio = delegado(producto);
            }
        }
        public void MostrarProductos()
        {
            foreach (Producto producto in ListaProductos)
            {
                Console.WriteLine(producto.MostrarInformacion());
            }
        }
    }
}
