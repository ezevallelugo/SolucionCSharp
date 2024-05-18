using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    internal class Validador
    {
        public static bool ValidarRespuestas(string respuesta)
        {
            bool retorno = false;
            if (respuesta == "s")
            {
                retorno= true;
            }
            return retorno;
        }
    }
}
