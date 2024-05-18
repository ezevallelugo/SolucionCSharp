using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Mascota
    {
        private string _nombre;
        private string _raza;
        public string Nombre
        {
            get { return _nombre; }
        }
        public string Raza
        {
            get { return _raza; }
        }
        public Mascota(string nombre, string raza)
        {
            _nombre = nombre;
            _raza = raza;
        }
        protected abstract string Ficha();
        protected virtual string DatosCompletos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {Nombre}");
            sb.AppendLine($"Raza: {Raza}");
            return sb.ToString();
        }
    }
}
