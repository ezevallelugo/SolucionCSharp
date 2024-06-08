using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public class CompetenciaNoDisponibleException : Exception
    {
        private string nombreClase;
        private string nombreMetodo;
        public CompetenciaNoDisponibleException(string mensaje, string metodo)
        {

        }
        public CompetenciaNoDisponibleException(string mensaje, string metodo, Exception innerException)
        {

        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Excepcion del metodo {this.nombreMetodo} de la clase {this.nombreClase}");
            stringBuilder.AppendLine($"Mensaje propio de la excepcion");
            stringBuilder.AppendLine("Todos los inner exception");
            return stringBuilder.ToString();
        }
    }
}
