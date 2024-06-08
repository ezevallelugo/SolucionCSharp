using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private ETipoCompetencia tipo;
        private Competencia()
        {
            competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadCompetidores, short cantidadVueltas, ETipoCompetencia tipo) : this ()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas; 
            this.tipo = tipo;
        }
        public short CantidadCompetidores
        {
            get { return cantidadCompetidores; }
            set {cantidadCompetidores = value; }
        }
        public short CantidadVueltas 
        {
            get { return cantidadVueltas; }
            set { cantidadVueltas = value; }
        }
        public List<VehiculoDeCarrera> ListaCompetidores
        {
            get { return competidores; }
            set { competidores = value; }
        }
        public ETipoCompetencia Tipo
        {
            get { return tipo; }
            set {  tipo = value; }
        }
        public static bool operator ==(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            if (competencia.Tipo == ETipoCompetencia.F1 && vehiculo.GetType() == typeof(AutoF1) ||
                competencia.tipo == ETipoCompetencia.MotoCross && vehiculo.GetType() == typeof(MotoCross)) 
            {
                foreach (VehiculoDeCarrera vehiculoRegistrado in competencia.ListaCompetidores)
                {
                    if (vehiculoRegistrado == vehiculo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            return !(competencia == vehiculo);
        }
        public static bool operator +(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            if (competencia != vehiculo && competencia.ListaCompetidores.Count < competencia.cantidadCompetidores)
            {
                vehiculo.EnCompetencia = true;
                vehiculo.VueltasRestantes = competencia.CantidadVueltas;
                Random random = new Random();
                vehiculo.CantidadDeCombustible = (short)random.Next(15, 100);
                competencia.ListaCompetidores.Add(vehiculo);
                return true;
            }
            else if (competencia == vehiculo)
            {
                Console.WriteLine("Este vehiculo ya esta registrado");
                Console.WriteLine($"Numero: {vehiculo.Numero} |Escuderia: {vehiculo.Escuderia}\n");
            }
            else
            {
                Console.WriteLine("Competencia llena. No se puede agregar este vehiculo");
                Console.WriteLine($"Numero: {vehiculo.Numero} |Escuderia: {vehiculo.Escuderia}\n");
            }
            return false;
        }
        public static bool operator -(Competencia competencia, VehiculoDeCarrera vehiculo)
        {
            if (competencia == vehiculo)
            {
                competencia.ListaCompetidores.Remove(vehiculo);
                return true;
            }
            return false;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"*** Competencia de {Tipo}***");
            sb.AppendLine($"Cantidad de competidores: {CantidadCompetidores}");
            sb.AppendLine($"Cantidad de vueltas: {CantidadVueltas}");
            foreach (VehiculoDeCarrera vehiculo in ListaCompetidores)
            {
                sb.AppendLine(vehiculo.MostrarDatos());
            }
            return sb.ToString();   
        }
    }
}
