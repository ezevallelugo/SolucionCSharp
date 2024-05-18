using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base (nombre, raza)
        {

        }
        protected override string Ficha()
        {
            return DatosCompletos();
        }
        public static bool operator ==(Gato gato1, Gato gato2)
        {
            return gato1.Nombre == gato2.Nombre && gato1.Raza == gato2.Raza;

        }
        public static bool operator !=(Gato gato1, Gato gato2)
        {
            return !(gato1 == gato2);
        }
        public override string ToString()
        {
            return Ficha();
        }
        public override bool Equals(object obj)
        {
            // Ver si este objeto es tipo Gato y guardar en la variable gato 
            // para luego validar si es igual al mismo tipo
            return obj is Gato gato && gato == this; ;
        }
        // Esto es opcional
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
