using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Humanos;
using System.Xml.Serialization;
using System.IO;

namespace test.Humanos
{
    class Program
    {
        public static bool SerializarAlumno(Alumno a)
        {
            bool flag = false;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Alumno));
                StreamWriter sw = new StreamWriter(@"D:\Laboratorio-II\Humanos.xml");
                ser.Serialize(sw, a);
                sw.Close();
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }

            return flag;
        }

        public static Alumno DeserializarAlumno()
        {
            Alumno a = new Alumno();

            try
            {                
                XmlSerializer ser = new XmlSerializer(typeof(Alumno));
                StreamReader sr = new StreamReader(@"D:\Laboratorio-II\Alumnos.xml");

                a = (Alumno)ser.Deserialize(sr);
                sr.Close();
            }
            catch (Exception)
            {
                a = null;
            }

            return a;
        }

        public static bool SerializarHumano(Humano h)
        {
            bool flag = false;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Humano));
                StreamWriter sw = new StreamWriter(@"D:\Laboratorio-II\Humanos.xml");
                ser.Serialize(sw, h);
                sw.Close();
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }

            return flag;
        }

        public static Humano DeserializarHumano()
        {
            Humano h = new Humano();

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Humano));
                StreamReader sr = new StreamReader(@"D:\Laboratorio-II\Humanos.xml");

                h = (Humano)ser.Deserialize(sr);
                sr.Close();
            }
            catch (Exception)
            {
                h = null;
            }

            return h;
        }

        public static bool SerializarLista(List<Humano> l)
        {
            bool flag = false;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Humano>));
                StreamWriter sw = new StreamWriter(@"D:\Laboratorio-II\Lista.xml");
                ser.Serialize(sw, l);
                sw.Close();
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }

            return flag;
        }

        public static List<Humano> DeserializarLista()
        {
            List<Humano> l = new List<Humano>();

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(List<Humano>));
                StreamReader sr = new StreamReader(@"D:\Laboratorio-II\Lista.xml");

                l = (List<Humano>)ser.Deserialize(sr);
                sr.Close();
            }
            catch (Exception)
            {
                l = null;
            }

            return l;
        }

        static void Main(string[] args)
        {
            //List<Humano> lh = new List<Humano>();
            //Humano h = new Humano();
            //Persona p = new Persona("Jose", "Esperanza");
            //Alumno a = new Alumno();
            //Profesor prof = new Profesor();

            //a.Legajo = 108014;
            //a.Dni = 54832659;
            //a.nombre = "Pepe";
            //a.apellido = "Gimenez";

            //prof.Titulo = "Programador";
            //prof.nombre = "Carlos";
            //prof.apellido = "Martinez";
            //prof.Dni = 42404923;

            //p.Dni = 34636802;

            //h.Dni = 20573628;

            //lh.Add(h);
            //lh.Add(p);
            //lh.Add(a);
            //lh.Add(prof);

            //Console.WriteLine("Humano: \n" + h.ToString());
            //Console.WriteLine("\n\nPersona: \n" + p.ToString());
            //Console.WriteLine("\n\nProfesor: \n" + prof.ToString());
            //Console.WriteLine("\n\nAlumno: \n" + a.ToString());

            //if (SerializarLista(lh))
            //{
            //    Console.WriteLine("\nSe serializo correctamente.");
            //}
            //else
            //{
            //    Console.WriteLine("\nNo se pudo serializar.");
            //}

            List<Humano> lD= new List<Humano>();
            lD = DeserializarLista();
            if (lD != null)
            {
                foreach (Humano h in lD)
                {
                    Console.WriteLine("\n\nHumano: \n" + h.ToString());
                }
                
            }
            else
            {
                Console.WriteLine("No se pudo deserializar");
            }

            Console.ReadKey();
        }
    }
}
