using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_05.entidades;
using Libreria;

namespace Clase_05.test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tinta obj1 = new Tinta();
            //Console.WriteLine("\nObjeto sin parametros:");
            //Console.WriteLine(Tinta.Mostrar(obj1));

            //Tinta obj2 = new Tinta(ConsoleColor.Red);
            //Console.WriteLine("\nObjeto con 1 parametro:");
            //Console.WriteLine(Tinta.Mostrar(obj2));

            //Tinta obj3 = new Tinta(ConsoleColor.Blue, ETipoTinta.China);
            //Console.WriteLine("\nObjeto con 2 parametros:");
            //Console.WriteLine(Tinta.Mostrar(obj3));

            //Console.ReadKey();

            //Tinta t1 = new Tinta();
            //Console.WriteLine("\nObjeto sin parametros:");
            //Console.WriteLine(Tinta.Mostrar(t1));

            //Tinta t2 = new Tinta(ConsoleColor.Red);
            //Console.WriteLine("\nObjeto con 1 parametro:");
            //Console.WriteLine(Tinta.Mostrar(t2));

            //Tinta t3 = new Tinta(ConsoleColor.Blue, ETipoTinta.China);
            //Console.WriteLine("\nObjeto con 2 parametros:");
            //Console.WriteLine(Tinta.Mostrar(t3));

            //Tinta t4 = new Tinta();
            //Console.WriteLine("\nObjeto con 2 parametros:");
            //Console.WriteLine(Tinta.Mostrar(t4));

            //if (t1.Equals(t4))
            //{
            //    Console.WriteLine("\n t1 y t4 son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("\n t1 y t4 no son iguales");
            //}

            //Tinta t5 = t1;

            //if (t1.Equals(t5))
            //{
            //    Console.WriteLine("\n t1 y t5 son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("\n t1 y t5 no son iguales");
            //}

            //if (t1==t4)
            //{
            //    Console.WriteLine("\n t1 y t4 son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("\n t1 y t4 no son iguales");
            //}

            //if (t2 != t3)
            //{
            //    Console.WriteLine("\n t2 y t3 no son iguales");
            //}
            //else
            //{
            //    Console.WriteLine("\n t2 y t3 son iguales");
            //}

            Tinta t1 = new Tinta();
            Pluma p1 = new Pluma("Bic", t1, 20);

            string s = p1;
            Console.WriteLine(s);

            p1 = p1 + t1;

            s = p1;

            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}
