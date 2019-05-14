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

        private Shopping(int capacidad):this()
        {
            this._capacidad = capacidad;
        }

        //public double PrecioDeExportadores
        //{
        //    get { return ; }
        //}

        public static string Mostrar(Shopping s)
        {
            string retorno = "";
            foreach (Comercio c in s._comercios)
            {
                retorno += (string)c;
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
            else
            {
                Console.WriteLine("\n No se pudo agregar el comercio.");
            }

            return s;
        }

        //private double ObtenerPrecio(EComercio tipoComercio)
        //{
        //    double retorno;

        //    if (tipoComercio is EComercio.Importador)
        //    {
        //        this._comercios.
        //    }
        //    return retorno;
        //}
    }
}
