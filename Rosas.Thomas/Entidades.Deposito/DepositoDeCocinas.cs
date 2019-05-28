using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Deposito
{
    public class DepositoDeCocinas
    {
        private int cantidadMaxima;
        private List<Cocina> lista;

        public DepositoDeCocinas(int capacidad)
        {
            this.cantidadMaxima = capacidad;
            lista = new List<Cocina>(capacidad);
        }

        public static bool operator +(DepositoDeCocinas d, Cocina c)
        {
            bool flag = false;

            if (d.lista.Count < d.cantidadMaxima)
            {
                d.lista.Add(c);
                flag = true;
            }

            return flag;
        }

        private int GetIndice(Cocina c)
        {
            int index = -1;

            foreach (Cocina aux in this.lista)
            {
                if (c == aux)
                {
                    index = this.lista.IndexOf(aux);
                    break;
                }
            }

            return index;
        }

        public static bool operator -(DepositoDeCocinas d, Cocina c)
        {
            bool flag = false;

            if (d.GetIndice(c) != -1)
            {
                d.lista.Remove(c);
                flag = true;
            }

            return flag;
        }

        public bool Agregar(Cocina c)
        {
            return this + c;
        }

        public bool Remover(Cocina c)
        {
            return this - c;
        }

        public override string ToString()
        {
            string retorno;

            retorno = "Capacidad máxima: " + this.cantidadMaxima + "\nListado de cocinas: ";

            foreach (Cocina aux in this.lista)
            {
                retorno += aux.ToString();
            }

            return retorno += "\n";
        }

    }
}
