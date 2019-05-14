using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Clase_14;

namespace clase_15.test.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int o;
                o = ParseadoraDeEnteros.Parse("a");
                Console.Write(o.ToString());
            }
            catch (ErrorParserException p)
            {
                Console.WriteLine(p.Message + p.InnerException.Message);
            }
            
            Console.ReadKey();
        }
    }
}
