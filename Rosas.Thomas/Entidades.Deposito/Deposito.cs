using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Deposito
{
     public class Deposito<T>
    {
        private int cantidadMaxima;
        private List<T> lista;

        public Deposito(int capacidad)
        {
            this.cantidadMaxima = capacidad;
            lista = new List<T>(capacidad);
        }

        public static bool operator +(Deposito<T> d, T c)
        {
            bool flag = false;

            if (d.lista.Count < d.cantidadMaxima)
            {
                d.lista.Add(c);
                flag = true;
            }

            return flag;
        }

        private int GetIndice(T c)
        {
            int index = -1;

            foreach (T aux in this.lista)
            {
                if (aux.Equals(c))
                {
                    index = this.lista.IndexOf(aux);
                    break;
                }
            }

            return index;
        }

        public static bool operator -(Deposito<T> d, T c)
        {
            bool flag = false;

            if (d.GetIndice(c) != -1)
            {
                d.lista.Remove(c);
                flag = true;
            }

            return flag;
        }

        public bool Agregar(T c)
        {
            return this + c;
        }

        public bool Remover(T c)
        {
            return this - c;
        }

        public override string ToString()
        {
            string retorno;

            retorno = "Capacidad máxima: " + this.cantidadMaxima + "\nListado: ";

            foreach (T aux in this.lista)
            {
                retorno += aux.ToString();
            }

            return retorno += "\n";
        }
    }
}
