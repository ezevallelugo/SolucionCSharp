using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Perro : Mascota
    {
        private int _edad;
        private bool _esAlfa;
        public Perro(string nombre, string raza) : base (nombre, raza)
        {
            _edad = 0;
            _esAlfa = false;
        }
        public Perro(string nombre, string raza, int edad, bool esAlfa) : this (nombre, raza)
        {
            _edad = edad;
            _esAlfa = esAlfa;
        }
        protected override string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DatosCompletos());
            sb.AppendLine($"Edad: {_edad}");
            if (_esAlfa)
            {
                sb.AppendLine($"Alfa de la manada");
            }
            return sb.ToString();
        }
        public static bool operator ==( Perro perro1, Perro perro2 )
        {
            return perro1.Nombre == perro2.Nombre && perro1.Raza == perro2.Raza && perro1._edad == perro2._edad;
        }
        public static bool operator !=(Perro perro1, Perro perro2)
        {
            return !(perro1 == perro2);
        }
        public static explicit operator int (Perro perro)
        {
            return perro._edad;
        }
        public override string ToString()
        {
            return Ficha();
        }
        public override bool Equals(object obj)
        {
            // Comparacion entre objetos. Validacion doble
            // Se puede con GetType
            return obj is Perro perro && perro == this;
        }
        public override int GetHashCode()
        {
            return Nombre.GetHashCode();
        }
    }
}
