using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Harina))]
    [XmlInclude(typeof(Jugo))]
    [XmlInclude(typeof(Gaseosa))]
    [XmlInclude(typeof(Galletita))]
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos;
        private Estante()
        { 
            _productos = new List<Producto>();
        }
        public Estante(sbyte capacidad) : this()
        {
            _capacidad = capacidad;
        }
        public float ValorEstanteTotal
        {
            get { return GetValorEstante(); }
            set { }
        }
        public List<Producto> Productos
        {
            get { return _productos; }
            set { _productos = value; }
        }
        public sbyte Capacidad
        {   get { return _capacidad; } 
            set { _capacidad = value; }
        }
        
        public List<Producto> GetProductos()
        {
            return _productos;
        }
        public static string MostrarEstante(Estante estante1)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Capacidad: {estante1._capacidad}");
            if (estante1._productos.Count > 0)
            {
                foreach (Producto producto in estante1._productos)
                {
                    sb.AppendLine(producto.ToString());
                    sb.AppendLine("*****");
                }
            }
            else
            {
                sb.AppendLine("El estante no posee productos");
            }
            return sb.ToString();
        }
        public static bool operator ==(Estante estante1, Producto producto1)
        {
            return estante1._productos.Contains(producto1);
        }
        public static bool operator !=(Estante estante1, Producto producto1)
        { 
            return !(estante1 == producto1);
        }
        public static bool operator +(Estante estante1, Producto producto1)
        {
            if (estante1 != producto1 && estante1._productos.Count < estante1._capacidad)
            {
                estante1._productos.Add(producto1);
                return true;
            }            
            return false;                       
        }
        public static Estante operator -(Estante estante1, Producto producto1)
        {
            if(estante1 == producto1)
            {
                estante1._productos.Remove(producto1);
                return estante1;
            }
            return estante1;
        }
        public static Estante operator -(Estante estante1, ETipoProducto tipoProducto1)
        {
            //foreach (Producto producto in estante1._productos)
            //{
            //    if (tipoProducto1 == ETipoProducto.Todos)
            //    {
            //        estante1._productos.Clear();
            //    }
            //    else if (producto.GetType().Name == tipoProducto1.ToString())
            //    {
            //        estante1._productos.Remove(producto);
            //    }

            if (tipoProducto1 == ETipoProducto.Todos)
            {
                estante1._productos.Clear();
            }
            else
            {
                for (int i = 0; i < estante1._productos.Count; i++)
                {
                    if (tipoProducto1.ToString() == estante1._productos[i].GetType().Name)
                    {
                        estante1._productos.RemoveAt(i);
                        i--;
                    }
                }
            }        
            return estante1;
        }
        private float GetValorEstante()
        {
            return GetValorEstante(ETipoProducto.Todos);
        }
        public float GetValorEstante(ETipoProducto tipoProducto)
        {
            float acumulador = 0.0F;
            foreach (Producto producto in _productos)
            {
                if (tipoProducto == ETipoProducto.Todos)
                {
                    acumulador += producto.CalcularCostoDeProduccion;
                }
                else if (producto.GetType().Name == tipoProducto.ToString())
                {
                    acumulador += producto.CalcularCostoDeProduccion;
                }
            }
            return acumulador;
        }
        public static void GuardarEstante(Estante estante1, string rutaDeArchivo)
        {
            //Validar si el archivo no existe para crearlo
            if (!File.Exists(rutaDeArchivo))
            {
                using(FileStream fileStream = File.Create(rutaDeArchivo))
                {
                    fileStream.Close();
                }
            }
            using(StreamWriter streamWriter = new StreamWriter(rutaDeArchivo))
            {
                streamWriter.WriteLine(MostrarEstante(estante1));
            }
        }
        public static void SerializarEstante(Estante estante1, string rutaDeArchivo)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Estante));
            using (StreamWriter streamWriter = new StreamWriter(rutaDeArchivo))
            {
                xmlSerializer.Serialize(streamWriter, estante1);
            }
        }
        public static Estante DeserializarEstante(string rutaArchivo)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Estante));
            using(StreamReader streamReader = new StreamReader(rutaArchivo))
            {
                return (Estante)xmlSerializer.Deserialize(streamReader);
            }
        }
    }
}
