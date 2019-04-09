using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Paleta
    {
        private Tempera[] _temperas;
        private int _cantidadMaxima;

        private Paleta(int cantidad)
        {
            _cantidadMaxima = cantidad;
            _temperas = new Tempera[cantidad];
        }
        private Paleta() : this(5)
        {

        }

        public static implicit operator Paleta(int cantidad)
        {
            Paleta auxPaleta = new Paleta(cantidad);
            return auxPaleta;
        }

        private string Mostrar()
        {
            string retorno;
            retorno = "La cantidad de paletas es de " + _cantidadMaxima.ToString();
            foreach (Tempera t in _temperas)
            {
                retorno += "\n" + Tempera.Mostrar(t);
            }
            return retorno;
        }

        public static explicit operator string(Paleta auxPaleta)
        {
            return auxPaleta.Mostrar();
        }

        public static bool operator ==(Paleta pal, Tempera temp)
        {
            bool flag = false;

            foreach (Tempera t in pal._temperas)
            {
                if (t == temp)
                {
                    flag = true;
                }
            }
            return flag;
        }
        public static bool operator !=(Paleta pal, Tempera temp)
        {
            return !(pal == temp);
        }

        public static Paleta operator +(Paleta pal, Tempera temp)
        {
            if (!(pal == temp))
            {
                pal._temperas[pal.ObtenerIndice()] = temp;
            }
            return pal;
        }

        private  int ObtenerIndice()
        {
            int indice = -1;
            int i = -1;
            foreach (Tempera t in _temperas)
            {
                i++;
                if (object.Equals(t, null))
                {
                    indice = i;
                }
            }
            return indice;
        }
    }
}
