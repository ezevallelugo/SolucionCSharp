using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class MiClase
    {
        public MiClase() 
        {
            try
            {
                UnMetodoEstatico();
            }
            catch (DivideByZeroException excepcion)
            {
                throw excepcion;
            }

        }
        public MiClase(bool bandera)
        {
            try
            {
                new MiClase();
            }
            catch (DivideByZeroException excepcion) 
            {
                throw new UnaExcepcion("Es una excepcion de MiClase", excepcion);
            }
            
        }
        public static void UnMetodoEstatico()
        {
            throw new DivideByZeroException();
        }

    }
}
