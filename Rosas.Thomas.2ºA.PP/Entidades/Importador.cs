using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Importador : Comercio
    {
        public EPaises paisOrigen;

        public Importador(string nombreComercio, float precioAlquiler, Comerciante comermciante, EPaises paisOrigen):base(nombreComercio, comermciante, precioAlquiler)
        {
            this.paisOrigen = paisOrigen;
        }

        public string Mostrar()
        {
            return base._comerciante + "\nPais de origen: "+ this.paisOrigen; 
        }

        public static bool operator ==(Importador a, Importador b)
        {
            bool retorno = false;

            if ((Comercio)a == (Comercio)b && a.paisOrigen == b.paisOrigen)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Importador a, Importador b)
        {
            return !(a == b);
        }

        public static implicit operator double(Importador n)
        {
            return n._precioAlquiler;
        }
    }
}
