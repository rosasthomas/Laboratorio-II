using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clase_05.entidades;

namespace Libreria
{
    public class Pluma
    {
        private string _marca;
        private Tinta _tinta;
        private int _cantidad;

        public Pluma(string marca, Tinta tinta, int cantidad)
        {
            this._marca = marca;
            this._tinta = tinta;
            this._cantidad = cantidad;
        }
        public Pluma(string marca, Tinta tinta) : this(marca, tinta, 0)
        {

        }
        public Pluma(string marca) : this(marca, null, 0)
        {

        }
        public Pluma() : this("Sin marca", null, 0)
        {

        }

        private string Mostrar()
        {
            return this._marca + ", " + Tinta.Mostrar(this._tinta) + ", " + this._cantidad.ToString();
        }

        public static bool operator == (Pluma pluma, Tinta tinta)
        {
            return pluma._tinta == tinta;
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma == tinta);
        }

        public static implicit operator string(Pluma p)
        {
            return p.Mostrar();
        }

        public static Pluma operator + (Pluma p, Tinta t)
        {
            if (p._cantidad < 91 && p == t)
            {
                p._cantidad += 10;
            }

            return p;
        }
    }
}