using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;
        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string DevolverTitular()
        {
            return titular;
        }
        public decimal DevolverCantidad()
        {
            return cantidad;
        }
        public string Mostrar()
        {
            return $"Titular: {titular} | Cantidad: {cantidad}";
        }
        public void Ingresar(decimal monto)
        {
            if (monto > 0)
            {
                cantidad += monto;
            }
        }
        public void Retirar(decimal monto)
        {
            if (cantidad > 0)
            {
                cantidad -= monto;
            }            
        }
    }
}
