using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca2
{
    public enum EVehiculos
    {
        Auto,
        Camion,
        Moto
    }
    public class Lavadero
    {
        private List<Vehiculo> listaVehiculos;
        private float precioAuto;
        private float precioCamion;
        private float precioMoto;
        private Lavadero()
        {
            listaVehiculos = new List<Vehiculo>();
        }
        public Lavadero(float precioAuto, float precioCamion, float precioMoto) : this()
        {
            this.precioAuto = precioAuto;
            this.precioCamion = precioCamion;
            this.precioMoto = precioMoto;
        }
        public string Detalle
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Precio del auto: {precioAuto}");
                sb.AppendLine($"Precio del camion: {precioCamion}");
                sb.AppendLine($"Precio de la moto: {precioMoto}");
                sb.AppendLine($"Lista de vehiculos");
                foreach (Vehiculo vehiculo in listaVehiculos)
                {
                    sb.AppendLine($"Patente: {vehiculo.Patente}");                    
                }
                return sb.ToString();
            }
        }
        public List<Vehiculo> ListaVehiculos
        {
            get { return listaVehiculos; }
        }
        public double MostrarTotalFacturado()
        {
            double total = 0;
            foreach (Vehiculo vehiculo in ListaVehiculos)
            {
                if (vehiculo is Auto)
                {
                    total += precioAuto;
                }
                else if (vehiculo is Camion)
                {
                    total += precioCamion;
                }
                else if (vehiculo is Moto)
                {
                    total += precioMoto;
                }
            }
            return total;
        }
        public double MostrarTotalFacturado(EVehiculos tipoDeVehiculo)
        {
            double total = 0;
            foreach (Vehiculo vehiculo in ListaVehiculos)
            {
                if((vehiculo is Auto && tipoDeVehiculo == EVehiculos.Auto) || (vehiculo is Camion && tipoDeVehiculo == EVehiculos.Camion) || (vehiculo is Moto && tipoDeVehiculo == EVehiculos.Moto))
                {
                    if (tipoDeVehiculo == EVehiculos.Auto)
                    {
                        total += precioAuto;
                    }
                    else if (tipoDeVehiculo == EVehiculos.Camion)
                    {
                        total += precioCamion;
                    }
                    else if (tipoDeVehiculo == EVehiculos.Moto)
                    {
                        total += precioMoto;
                    }
                }
            }
            return total;
        }
        public static bool operator ==(Lavadero lavadero1, Vehiculo vehiculo1)
        {
            foreach (Vehiculo vehiculo in lavadero1.ListaVehiculos)
            {
                if (vehiculo == vehiculo1)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Lavadero lavadero1, Vehiculo vehiculo1)
        {
            return !(lavadero1 == vehiculo1);
        }
        public static Lavadero operator +(Lavadero lavadero1, Vehiculo vehiculo1)
        {
            if (lavadero1 != vehiculo1)
            {
                lavadero1.ListaVehiculos.Add(vehiculo1);                
            }
            return lavadero1;
        }
        public static Lavadero operator -(Lavadero lavadero1, Vehiculo vehiculo1)
        {
            if (lavadero1 == vehiculo1)
            {
                lavadero1.ListaVehiculos.Remove(vehiculo1);
            }
            return lavadero1;
        }
        public static int OrdenarPorPatente(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return string.Compare(vehiculo1.Patente, vehiculo2.Patente, StringComparison.OrdinalIgnoreCase);
        }
        public static int OrdenarVehiculosPorMarca(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return vehiculo1.Marca.CompareTo(vehiculo2.Marca);
        }
    }
}
