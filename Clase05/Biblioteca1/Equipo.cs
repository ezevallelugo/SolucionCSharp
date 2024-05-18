using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> listaJugadores;
        private string nombre;
        private Equipo()
        {
            listaJugadores = new List<Jugador>();
        }
        public Equipo(short cantidad, string nombre) : this()
        {
            cantidadDeJugadores = cantidad;
            this.nombre = nombre;
        }
        public List<Jugador> GetListaJugadores
        {
            get { return listaJugadores; }
        }
        public static bool operator +(Equipo equipo,Jugador jugador)
        {
            if ( equipo.listaJugadores.Count < equipo.cantidadDeJugadores)
            {
                foreach (Jugador j in equipo.listaJugadores)
                {
                    if (j == jugador)
                    {
                        return false;
                    }
                }
                equipo.listaJugadores.Add(jugador);
                return true;
            } 
            return false;
        }
    }
}
