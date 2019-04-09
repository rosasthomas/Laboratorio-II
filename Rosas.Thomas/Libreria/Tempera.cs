using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Tempera
    {
        private ConsoleColor _Color;
        private string _Marca;
        private sbyte _Cantidad;

        public  Tempera(ConsoleColor color, string marca, sbyte cantidad)
        {
            this._Marca = marca;
            this._Color = color;
            this._Cantidad = cantidad;
        }

        private string Mostrar()
        {
            return this._Marca + ", " + this._Color.ToString() + ", " + this._Cantidad.ToString();
        }

        public static string Mostrar(Tempera tempera)
        {
            string retorno;
            if(!object.Equals(tempera, null))
            {
                retorno = tempera.Mostrar();
            }
            else
            {
                retorno = "Vacio";
            }
            return retorno;
        }

        public static bool operator == (Tempera auxUno, Tempera auxDos)
        {
            bool flag = false;
            if (auxUno == null && auxDos == null)
            {
                flag = true;
            }
            else if (auxUno == null || auxDos == null)
            {
                flag = false;
            }
            else if(auxUno._Marca == auxDos._Marca && auxUno._Color == auxDos._Color)
            {
                flag = true;
            }
            return flag;
        }

        public static bool operator !=(Tempera auxUno, Tempera auxDos)
        {
            return !(auxUno == auxDos);
        }

        public static Tempera operator +(Tempera auxTempera, sbyte auxCantidad)
        {
            auxTempera._Cantidad += auxCantidad;
            return auxTempera;
        }

        public static Tempera operator +(Tempera auxTempera, Tempera auxTemperaDos)
        {
            if (auxTempera == auxTemperaDos)
            {
                auxTempera += auxTemperaDos._Cantidad;
            }
            return auxTempera;
        }

        public static implicit operator sbyte(Tempera tempera)
        {
            return tempera._Cantidad;
        }
    }
}
