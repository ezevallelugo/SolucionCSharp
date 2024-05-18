using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca1
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> listaCompetidores;
        private Competencia()
        {
            listaCompetidores = new List<AutoF1>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Cantidad de competidores: {cantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {cantidadVueltas}");
            sb.AppendLine($"Lista de competidores:");
            foreach (AutoF1 autoF1 in listaCompetidores)
            {
                sb.AppendLine(autoF1.MostrarDatos());
            }
            return sb.ToString();
        }
        public static bool operator ==(Competencia competencia, AutoF1 auto)
        {
            foreach (AutoF1 a in competencia.listaCompetidores)
            {
                if (a == auto)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Competencia competencia, AutoF1 auto)
        {
            return !(competencia == auto);
        }
        public static bool operator +(Competencia competencia, AutoF1 autoF1)
        {
            //Random variableRandom = new Random();
            if (competencia.listaCompetidores.Count < competencia.cantidadCompetidores && competencia != autoF1)
            {            
                Random variableRandom = new Random();
                autoF1.EnCompetencia = true;
                autoF1.VueltasRestantes = competencia.cantidadVueltas;
                autoF1.CantidadCombustible = (short)variableRandom.Next(15, 100);
                competencia.listaCompetidores.Add(autoF1);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator -(Competencia competencia, AutoF1 auto)
        {
            if (competencia == auto)
            {
                competencia.listaCompetidores.Remove(auto);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
