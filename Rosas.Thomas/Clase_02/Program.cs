using System;

namespace Clase_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Hola";
            
            Console.WriteLine(Sello.Imprimir());        

            //Sello.Borrar();
           
            //Sello.color = ConsoleColor.Blue;

            //Sello.ImprimirEnColor();            

            //Console.WriteLine(Sello.Imprimir());
            
            Console.ReadKey();
        }
    }
}
