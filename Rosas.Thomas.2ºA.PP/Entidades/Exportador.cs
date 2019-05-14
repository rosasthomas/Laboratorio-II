using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Exportador : Comercio
    {
        public ETipoProducto tipo;

        public Exportador(string nombreComercio, float precioAlquiler, string nombre, string apellido, ETipoProducto tipo):base(precioAlquiler, nombreComercio, nombre, apellido)
        {
            this.tipo = tipo;
        }

        public string Mostrar()
        {
            return base._comerciante + "\nTipo: " + this.tipo;
        }

        public static implicit operator double(Exportador a)
        {
            return a._precioAlquiler;
        }
        public static bool operator ==(Exportador a, Exportador b)
        {
            bool retorno = false;

            if ((Comercio)a == (Comercio)b && a.tipo == b.tipo)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Exportador a, Exportador b)
        {
            return !(a == b);
        }
    }
}
