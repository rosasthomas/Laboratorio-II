using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_02
{
    class  Sello
    {
        public static string mensaje;
        public static ConsoleColor color;
        

        public static string Imprimir()
        {
            return ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        
        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;

            Console.WriteLine(Sello.Imprimir());

            Sello.color = ConsoleColor.White;
            Console.ForegroundColor = Sello.color;
        }

        private static string ArmarFormatoMensaje()
        {
            int len;           
           
            string mensajeSello = "";

            len = Sello.mensaje.Length ;
            if (len > 0)
            {
                string techo = "";
                len += 2;
                for (int i = 0; i < len; i++)
                {
                    techo += "*";
                }

                mensajeSello += techo;
                mensajeSello += "\n*";
                mensajeSello += Sello.mensaje;
                mensajeSello += "*\n";
                mensajeSello += techo;

                
            }

            return mensajeSello;
        }
    }
}
