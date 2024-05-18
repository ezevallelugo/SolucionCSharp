using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    internal class Validador
    {
        /// <summary>
        /// Valida el rango de numeros
        /// </summary>
        /// <param name="valor">dato a validar</param>
        /// <param name="min">minimo valor a cumplir</param>
        /// <param name="max">maximo valor a cumplir</param>
        /// <returns>Retorna un bool</returns>
        public static bool Validar(int valor, int min, int max)
        {
            return valor > min && valor < max;
        }
    }
}
