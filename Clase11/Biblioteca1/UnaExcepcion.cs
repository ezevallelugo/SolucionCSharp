using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class UnaExcepcion : Exception
    {
        public UnaExcepcion(string mensaje, Exception innerException) : base(mensaje,innerException)
        {

        }
    }
}
