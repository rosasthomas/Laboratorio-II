using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.ultimaClase;
using System.IO;

namespace test.ultimaClase
{
    class Program
    {
        public static void LimiteSueldoEmpleado(Empleado e, float f)
        {
            Console.WriteLine("Al empleado {0} con legajo {1} se le quizo asignar el siguiente sueldo {2}", e.Nombre, e.Legajo, f);
        }
        //hora minuto legajo nombre mas el sueldoq ue se le intento asignar
        public void GuardarLog(Empleado e, float f)
        {
            try
            {
                StreamWriter w = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Incidentes.log", true);
                w.WriteLine("\n" + DateTime.Now);
                w.Write("\nNombre: " + e.Nombre + " - Legajo: " + e.Legajo + " - Sueldo que se le intento asignar: " + f);
                w.Close();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
            
        }

        static void Main(string[] args)
        {
            Empleado e = new Empleado();

            e._limiteSueldo += new DelegadoSueldo(LimiteSueldoEmpleado);
            Program p = new Program();
            e._limiteSueldo += new DelegadoSueldo(p.GuardarLog);

            e.Nombre = "Juan";
            e.Legajo = 1;
            e.Sueldo = 14000;

            Console.WriteLine(e.ToString());
            
            Console.ReadKey();
        }
    }
}
