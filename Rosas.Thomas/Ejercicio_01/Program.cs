using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio_01";
            int numero;
            int max = int.MinValue;
            int min = int.MaxValue;
            float prom = 0;

            for(int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > max)
                    max = numero;
                else if (numero < min)
                    min = numero;

                prom += numero;
                Console.Clear();
            }

            prom = prom / 5;

            Console.WriteLine("El numero maximo es: {0}", max);
            Console.WriteLine("El numero minimo es: {0}", min);
            Console.WriteLine("El promedio es: {0}", prom);
            Console.ReadKey();
        }
    }
}
