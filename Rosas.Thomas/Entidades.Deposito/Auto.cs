using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Deposito
{
    public class Auto
    {
        private string _color;
        private string _marca;

        public string Color
        {
            get { return this._color; }
        }       

        public string Marca
        {
            get { return this._marca; }
        }

        public Auto(string color, string marca)
        {
            this._color = color;
            this._marca = marca;
        }

        public static bool operator ==(Auto a, Auto b)
        {
            bool flag = false;

            if (a.Marca == b.Marca && a.Color == b.Color)
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Auto)
            {
                retorno = (this == (Auto)obj);
            }

            return retorno;
        }      

        public override string ToString()
        {
            return "\nMarca: " + this.Marca + " - Color: " + this.Color;
        }
    }
}
