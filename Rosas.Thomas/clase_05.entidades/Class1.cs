using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_05.entidades
{
    public class Tinta
    {
        private ConsoleColor _color;
        private ETipoTinta _tipoTinta;

        public Tinta(ConsoleColor color, ETipoTinta tipoTinta)
        {
            this._tipoTinta = tipoTinta;
            this._color = color;
        }

        public Tinta(ConsoleColor color) : this(color, ETipoTinta.Comun)
        {
            
        }

        public Tinta() : this(ConsoleColor.Black, ETipoTinta.Comun)
        {

        }
        private string Mostrar()
        {
            return this._color.ToString() + ", "+ this._tipoTinta.ToString();
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        public static bool operator == (Tinta a, Tinta b)
        {
            bool rta = false;
            if (a._color == b._color && a._tipoTinta == b._tipoTinta)
            {
                rta = true;
            }

            return rta;
        }

        public static bool operator !=(Tinta a, Tinta b)
        {
            return !(a == b);
        }
    }
}