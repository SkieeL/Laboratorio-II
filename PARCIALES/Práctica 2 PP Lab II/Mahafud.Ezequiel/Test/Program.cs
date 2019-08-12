using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavadero lavadero = new Lavadero("Lavadero de SkieL, sacale el 'lavame puto' a tu auto");
            Vehiculo vehiculo = new Vehiculo("MANITO", EMarcas.Iveco, 8);
            Auto auto = new Auto("FMK 325", EMarcas.Ford, 4);
            Auto auto1 = new Auto("RLM 678", EMarcas.Fiat, 4, 4);
            Camion camion = new Camion("GG IZI", EMarcas.Scania, 6, 500);
            Camion camion1 = new Camion(vehiculo, 1000);
            Moto moto = new Moto(EMarcas.Zanella, "FALA AGORA", 125, 2);
            Moto moto1 = new Moto("BOLUDITO", EMarcas.Fiat, 2, 110);

            lavadero += auto;
            lavadero += camion;
            lavadero += moto;
            lavadero += auto1;
            lavadero += camion1;
            lavadero += moto1;

            Console.WriteLine("********************");
            Console.WriteLine("Muestreo individual");
            Console.WriteLine("********************");

            Console.WriteLine(auto.ToString());
            Console.WriteLine(auto1.ToString());
            Console.WriteLine(camion.ToString());
            Console.WriteLine(camion1.ToString());
            Console.WriteLine(moto.ToString());
            Console.WriteLine(moto1.ToString());

            Console.WriteLine("******************************");
            Console.WriteLine("Muestreo individual vehiculo");
            Console.WriteLine("******************************");

            Console.WriteLine(vehiculo.ToString());

            Console.WriteLine("******************************");
            Console.WriteLine("Muestreo Lavadero completo");
            Console.WriteLine("******************************");

            Console.WriteLine(lavadero.Lavaderos);

            Console.WriteLine("****************************************");
            Console.WriteLine("Muestreo Lavadero removiendo vehiculos");
            Console.WriteLine("****************************************");

            lavadero -= auto;
            lavadero -= camion;
            lavadero -= moto;
            lavadero -= auto;
            lavadero -= camion;
            lavadero -= moto;

            Console.WriteLine(lavadero.Lavaderos);
            Console.Read();
        }
    }
}
