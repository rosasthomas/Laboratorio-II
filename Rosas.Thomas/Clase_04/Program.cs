using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_04.entidades;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Cosa objeto = new Cosa(7, "hola", DateTime.Now);

            Console.WriteLine(Cosa.mostrar(objeto));
            Console.ReadLine();

        }
    }
}
