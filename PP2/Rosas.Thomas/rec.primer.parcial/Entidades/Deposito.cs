using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Deposito
    {
        public List<Producto> productos;

        public Deposito() : this(3)
        {

        }

        public Deposito(int cantidadProductos)
        {
            productos = new List<Producto>(cantidadProductos);
        }

        public static bool operator ==(Deposito d, Producto p)
        {
            bool flag = false;

            foreach (Producto pr in d.productos)
            {
                if (pr.nombre == p.nombre)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public static bool operator !=(Deposito d, Producto p)
        {
            return !(d == p);
        }

        public static List<Producto> operator +(Deposito d1, Deposito d2)
        {
            List<Producto> nuevaLista = new List<Producto>();

            foreach (Producto p1 in d1.productos)
            {
                foreach (Producto p2 in d2.productos)
                {
                    if (p2 == p1)
                    {
                        p1.stock += p2.stock;                         
                    }
                    else
                    {
                        nuevaLista.Add(p2);
                    }
                }
                nuevaLista.Add(p1);
            }

            return nuevaLista;
        }




    }
}
