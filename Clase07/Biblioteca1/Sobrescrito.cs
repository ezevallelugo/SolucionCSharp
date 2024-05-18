using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;
        public override string ToString()
        {
            return "Este es mi metodo ToString sobrescrito!";
        }
        public Sobrescrito()
        {
            miAtributo = "Probar abstractos";
        }
        public abstract string MiPropiedad { get; }
        public abstract string MiMetodo();
        public override bool Equals(object obj)
        {
            Sobrescrito sobrescrito = obj as Sobrescrito;
            return sobrescrito != null && obj == sobrescrito;
        }
        public override int GetHashCode()
        {
            return 1142510181;
        }
    }
}
