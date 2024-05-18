using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public class Rectangulo : Figura
    {
        protected float longitudAltura;
        protected float longitudBase;
        public Rectangulo(float longitudAltura, float longitudBase) 
        {
            this.longitudAltura = longitudAltura;
            this.longitudBase = longitudBase;
        }
        public override string Dibujar()
        {
            return "Dibujando rectangulo...";
        }
        public override double CalcularSuperficie()
        {
            return longitudAltura * longitudBase;
        }
        public override double CalcularPerimetro()
        {
            return 2 * (longitudAltura + longitudBase);
        }
    }
}
