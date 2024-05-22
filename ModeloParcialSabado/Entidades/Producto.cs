using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected int _codigoDeBarra;
        protected EMarcaProducto _marca;
        protected float _precio;
        public Producto() 
        { 

        }
        public Producto(int codigoDeBarra, EMarcaProducto marca, float precio)
        {
            _codigoDeBarra = codigoDeBarra;
            _marca = marca;
            _precio = precio;
        }
        public int CodigoDeBarra
        {
            get { return _codigoDeBarra; }
            set { _codigoDeBarra = value; }
        }
        public EMarcaProducto Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public float Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public abstract float CalcularCostoDeProduccion
        {
            get;
            set;
        }
        private static string MostrarProducto(Producto producto1)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de barra: {producto1.CodigoDeBarra}");
            sb.AppendLine($"Marca: {producto1.Marca}");
            sb.AppendLine($"Precio: ${producto1.Precio:#,###.00}");
            return sb.ToString();
        }
        public static bool operator ==(Producto producto1, EMarcaProducto marca1)
        {            
            return producto1.Marca == marca1;
        }
        public static bool operator !=(Producto producto1, EMarcaProducto marca1)
        {
            return !(producto1 == marca1);
        }
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            return producto1.CodigoDeBarra == producto2.CodigoDeBarra && producto1.Marca == producto2.Marca && producto1.GetType() == producto2.GetType();
        }
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }
        public static explicit operator int(Producto producto1)
        {
            return producto1.CodigoDeBarra;
        }
        public static implicit operator string(Producto producto1)
        {
            return MostrarProducto(producto1);
        }
        public override bool Equals(object obj)
        {
            return obj is Producto producto && producto == this;
        }
        public virtual string Consumir()
        {
            return "Parte de una mezcla";
        }


    }
}
