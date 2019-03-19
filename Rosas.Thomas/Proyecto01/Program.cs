using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Hola mundo c#");
            Console.ReadKey();*/

            string nombre;
            Console.Write("Ingrese nombre: ");
            nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("El nombre ingresado es: {0}", nombre);
            Console.ReadKey();

             /*Console.Write("Ingrese nombre: ");
            Console.WriteLine("El nombre ingresado es: {0}", Console.ReadLine());
            Console.ReadKey();*/
        }
    }
}
