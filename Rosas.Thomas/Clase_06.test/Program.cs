using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;
namespace Clase_06.test
{
    class Program
    {
        static void Main(string[] args)
        {
            Paleta paletaUno = 2;
            Tempera temperaRoja = new Tempera(ConsoleColor.Red, "maped", 1);
            Tempera temperaAzul = new Tempera(ConsoleColor.Blue, "faber", 1);
            paletaUno += temperaRoja;
            paletaUno += temperaAzul;        
            Console.WriteLine((string)paletaUno);
            Console.ReadKey();
            

        }
    }
}
