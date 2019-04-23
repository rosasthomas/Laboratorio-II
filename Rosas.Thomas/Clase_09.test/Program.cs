using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Vehiculos;

namespace Clase_09.test
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero lavaderoGato = new Lavadero(200, 500, 120);
            Auto autoUno = new Auto("RGW 234", EMarca.Ford, 4, 3);
            Auto autoDos = new Auto("JRT 743", EMarca.Fiat, 4, 5);
            Camion camion = new Camion("ITJ 638", EMarca.Scania, 6, 3500);
            Camion camionDos = new Camion("MFW 694", EMarca.Iveco, 8, 5000);
            Moto moto = new Moto("JRY 835", EMarca.Zanella, 2, 250);
            Moto motoDos = new Moto("YJY 447", EMarca.Honda, 2, 600);

            lavaderoGato += autoUno;
            //lavaderoGato += moto;
            lavaderoGato += camion;
            lavaderoGato += autoDos;
            lavaderoGato += camionDos;
            autoUno.Precio = 300000;

            Console.WriteLine(lavaderoGato.MiLavadero);

            Console.WriteLine("\nEl total facturado es: " + lavaderoGato.MostrarTotalFacturado());
            Console.WriteLine("El total facturado por auto es: " + lavaderoGato.MostrarTotalFacturado(EVehiculo.Auto));
            Console.WriteLine("El total facturado por moto es: " + lavaderoGato.MostrarTotalFacturado(EVehiculo.Moto));
            Console.WriteLine("El total facturado por camion es: " + lavaderoGato.MostrarTotalFacturado(EVehiculo.Camion));
            Console.WriteLine("El precio del auto mas el iva es: " + autoUno.CalcularPrecioConIVA());
            Console.ReadKey();
        }
    }
}
