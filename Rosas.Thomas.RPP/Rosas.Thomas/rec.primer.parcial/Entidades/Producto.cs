using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto : Deposito
    {
        public string nombre;
        public int stock;

        public Producto(string nombre, int stock)
        {
            this.nombre = nombre;
            this.stock = stock;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool flag = false;

            if (p1.nombre == p2.nombre)
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }
    }
}
