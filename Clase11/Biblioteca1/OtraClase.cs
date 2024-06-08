using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class OtraClase
    {
        public void OtroMetodo()
        {
            try
            {
                new MiClase(true);
            }
            catch (UnaExcepcion excepcion)
            {
                throw new MiExcepcion("Esta es la excepcion de OtraClase", excepcion);
            }
        }
    }
}
