using Biblioteca2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empieza el programa!");
            /*Auto auto1 = new Auto("SFG 432", 4, 0, 4);
            Camion camion1 = new Camion("TGR 455", 6, 0, 45.5F);
            Moto moto1 = new Moto("JKL 867", 2, 0, 6.5F);
            Console.WriteLine(auto1.MostrarAuto());
            Console.WriteLine(camion1.MostarCamion());
            Console.WriteLine(moto1.MostrarMoto()); */
            Lavadero lavadero1 = new Lavadero(450F, 550F, 300F);
            Auto auto1 = new Auto("SFG 432", 4, EMarcas.Zanella, 4);
            lavadero1 += auto1;
            lavadero1 += new Auto("HFD 482", 4, EMarcas.Ford, 4);
            lavadero1 += new Auto("EWQ 452", 4, EMarcas.Scania, 4);
            lavadero1 += new Auto("RRT 412", 4, EMarcas.Zanella, 4);
            lavadero1 += new Camion("TGR 455", 6, EMarcas.Ford, 45.5F);
            lavadero1 += new Camion("YUI 165", 6, EMarcas.Fiat, 55.5F);
            lavadero1 += new Moto("JKL 867", 2, EMarcas.Fiat, 6.5F);

            Console.WriteLine("Detalle del lavadero:");
            Console.WriteLine(lavadero1.Detalle);

            Console.WriteLine("Facturacion total:");
            Console.WriteLine(lavadero1.MostrarTotalFacturado());

            Console.WriteLine("Facturacion por tipo de vehiculo:");
            Console.WriteLine($"Total por camion: {lavadero1.MostrarTotalFacturado(EVehiculos.Camion)}");
            Console.WriteLine($"Total por moto: {lavadero1.MostrarTotalFacturado(EVehiculos.Moto)}");
            Console.WriteLine($"Total por auto: {lavadero1.MostrarTotalFacturado(EVehiculos.Auto)}");

            Console.WriteLine("Vehiculos ordenados por patente:");
            lavadero1.ListaVehiculos.Sort(Lavadero.OrdenarPorPatente);
            foreach (Vehiculo vehiculo in lavadero1.ListaVehiculos)
            {
                Console.WriteLine(vehiculo.Patente);
            }

            Console.WriteLine("Vehiculos ordenados por marca:");
            lavadero1.ListaVehiculos.Sort(Lavadero.OrdenarVehiculosPorMarca);
            foreach (Vehiculo vehiculo in lavadero1.ListaVehiculos)
            {
                Console.WriteLine(vehiculo.Patente);
                Console.WriteLine(vehiculo.Marca);
                Console.WriteLine("********************");
            }
            lavadero1 -= auto1;
            Console.WriteLine("Detalle de lavadero v2:");
            Console.WriteLine(lavadero1.Detalle);
            Console.ReadKey();
        }
    }
}
