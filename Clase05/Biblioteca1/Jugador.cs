using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Jugador
    {
        private int dni;
        private string nombre;
        private int partidosJugados;
        private float promedioGoles;
        private int totalGoles;
        private Jugador()
        {
            partidosJugados = 0;
            promedioGoles = 0;
            totalGoles = 0;
        }
        public Jugador(int dni,string nombre) : this ()
        {
            this.dni = dni;
            this.nombre = nombre;
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos) : this(dni, nombre)
        {
            partidosJugados = totalPartidos;
            this.totalGoles = totalGoles;
        }
        public float GetPromedioGoles()
        {
            if (partidosJugados > 0)
            {
                promedioGoles = (float)totalGoles / partidosJugados;
                return promedioGoles;
            }
            else
            {
                return 0;
            }
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"DNI: {dni}");
            sb.AppendLine($"Partidos jugados: {partidosJugados}");
            sb.AppendLine($"Total de goles: {totalGoles}");
            sb.AppendLine($"Promedio de goles por partido: {GetPromedioGoles():F2}");
            return sb.ToString();
        }
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            return jugador1.dni == jugador2.dni;
        }
        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }
    }
}
