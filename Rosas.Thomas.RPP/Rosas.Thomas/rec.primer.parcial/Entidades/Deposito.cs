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

        public static List<Producto> operator +(Deposito d1, Deposito d2)
        {
            List<Producto> nuevaLista = new List<Producto>();
            nuevaLista = d1.productos;

            foreach (Producto p2 in d2.productos)
            {
                bool flag = false;

                foreach (Producto p1 in nuevaLista)
                {
                    if (p1 == p2)
                    {
                        p1.stock += p2.stock;
                        flag = true;
                    }
                }
                if (!flag)
                {
                    nuevaLista.Add(p2);
                }
            }

            return nuevaLista;
        }

        public int OrdenarPorStock(Producto p1, Producto p2)
        {
            return p1.stock.CompareTo(p2.stock);
        }

        public int OrdenarPorNombre(Producto p1, Producto p2)
        {
            return p1.nombre.CompareTo(p2.nombre);
        }


    }
}
