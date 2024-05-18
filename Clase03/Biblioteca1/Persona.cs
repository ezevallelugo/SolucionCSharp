using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaDeNacimiento;
        private int dni;
        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }
        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaDeNacimiento.Year;
            return edad;
        }
        public string Mostrar()
        {
            int edad = CalcularEdad();
            return $"Nombre: {nombre}| Edad: {edad}| DNI: {dni}";
        }
        public string EsMayorDeEdad()
        {
            int edad = CalcularEdad();
            string mensaje;
            if (edad < 18 && edad > -1)
            {
                mensaje = "Es menor";
            }
            else if (edad > 17)
            {
                mensaje = "Es mayor de edad";
            }
            else
            {
                mensaje = "Edad no valida";
            }
            return mensaje;
        }
    }
}
