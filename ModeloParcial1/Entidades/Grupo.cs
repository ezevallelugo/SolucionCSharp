using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private string _nombre;
        // No tiene que ser inicializado, su valor perdura en al compilacion
        private static ETipoManada _tipo;
        //De clase -> es estatico!
        public ETipoManada Tipo
        {
            set { _tipo = value; }
        }
        static Grupo()
        {
            _tipo = ETipoManada.Unica;
        }
        private Grupo()
        {
            _manada = new List<Mascota>();
        }
        // No lo llamo a ninguno porque estan privados asi que incializo la lista con this()
        public Grupo(string nombre) : this()
        {
            _nombre = nombre;
        }
        public Grupo(string nombre, ETipoManada tipo) : this(nombre)
        {
            _tipo = tipo;
        }
        public static bool operator ==(Grupo grupo, Mascota mascota)
        {
            return grupo._manada.Contains(mascota);
        }
        public static bool operator !=(Grupo grupo, Mascota mascota)
        {
            return !(grupo == mascota);
        }
        public static Grupo operator +(Grupo grupo, Mascota mascota)
        {
            if (grupo != mascota)
            {
                grupo._manada.Add(mascota);
            }
            else
            {
                Console.WriteLine("No se pudo agregar porque ya estaba previamente agregada");
            }
            return grupo;
        }
        public static Grupo operator -(Grupo grupo, Mascota mascota)
        {
            if(grupo == mascota)
            {
                grupo._manada.Remove(mascota);
            }
            else
            {
                Console.WriteLine("No se puedo quitar porque no existe previamente en la lista");
            }
            return grupo;
        }
        public static implicit operator string (Grupo grupo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*** Manada: {grupo._nombre} - Tipo: {_tipo} - Integrantes: {grupo._manada.Count} ***");
            foreach (Mascota mascota in grupo._manada)
            {
                sb.AppendLine(mascota.ToString());
                /*if (mascota is Gato gato)
                {
                    sb.AppendLine("===== Gato =====");
                    sb.AppendLine(gato.ToString());
                }
                //Para que se siga almacenando en is
                else if (mascota is Perro perro)
                {
                    sb.AppendLine("===== Perro =====");
                    sb.AppendLine(perro.ToString());
                }*/
            }
            return sb.ToString();
        }
    }
}
