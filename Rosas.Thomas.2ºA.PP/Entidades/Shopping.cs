using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Shopping
    {
        private int _capacidad;
        private List<Comercio> _comercios;

        private Shopping()
        {
            this._comercios = new List<Comercio>();
        }

        private Shopping(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public double PrecioDeExportadores
        {
            get { return this.ObtenerPrecio(EComercio.Exportador); }
        }
        public double PrecioDeImportadores
        {
            get { return this.ObtenerPrecio(EComercio.Importador); }
        }
        public double PrecioTotal
        {
            get { return this.ObtenerPrecio(EComercio.Ambos); }
        }

        public static string Mostrar(Shopping s)
        {
            string retorno = "";

            retorno += "Capacidad del Shopping: " + s._capacidad + "\n";
            retorno += "Total por Importadores: " + s.PrecioDeImportadores + "\n";
            retorno += "Total por Exportadores: " + s.PrecioDeExportadores + "\n";
            retorno += "Total por ambos: " + s.PrecioTotal + "\n\n";
            retorno += "*****************************\n";
            retorno += "Listado de Comercios\n";
            retorno += "*****************************";

            foreach (Comercio co in s._comercios)
            {
                if (co is Importador)
                {
                    retorno += ((Importador)co).Mostrar();
                }
                else
                {
                    retorno += ((Exportador)co).Mostrar();
                }
            }


            return retorno;
        }

        public static implicit operator Shopping(int capacidad)
        {
            Shopping s = new Shopping(capacidad);

            return s;
        }

        public static bool operator ==(Shopping s, Comercio c)
        {
            bool retorno = false;

            foreach (Comercio com in s._comercios)
            {
                if (com == c)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Shopping s, Comercio c)
        {
            return !(s == c);
        }

        public static Shopping operator +(Shopping s, Comercio c)
        {
            if(s._comercios.Count < s._capacidad && s!=c)
            {
                s._comercios.Add(c);
            }
            else if(s._comercios.Count >= s._capacidad)
            {
                Console.WriteLine("\n No hay más capacidad en el shopping.");
            }
            else
            {
                Console.WriteLine("El comercio ya está en el shopping.");
            }

            return s;
        }

        private double ObtenerPrecio(EComercio tipoComercio)
        {
            double retorno = 0;

            foreach (Comercio c in _comercios)
            {
                if (tipoComercio == EComercio.Importador && c is Importador)
                {
                    retorno += ((Importador)c);
                }
                else if(tipoComercio == EComercio.Importador && c is Exportador)
                {
                    retorno += ((Exportador)c);
                }
                else if(tipoComercio == EComercio.Ambos)
                {
                    if (c is Importador)
                    {
                        retorno += (Importador)c;
                    }
                    else
                    {
                        retorno += (Exportador)c;
                    }
                }

            }

            return retorno;
        }

    }
}
