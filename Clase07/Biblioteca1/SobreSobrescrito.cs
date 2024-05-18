using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class SobreSobrescrito : Sobrescrito
    {
        public override string MiPropiedad
        {
            get { return miAtributo; }
        }
        public override string MiMetodo()
        {
            return "Metodo sobrescrito";
        }
    }
}
