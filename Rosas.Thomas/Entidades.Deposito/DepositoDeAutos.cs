using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Deposito
{
    public class DepositoDeAutos
    {
        private int cantidadMaxima;
        private List<Auto> lista;

        public DepositoDeAutos(int capacidad)
        {
            this.cantidadMaxima = capacidad;
            lista = new List<Auto>(capacidad);
        }

        public static bool operator +(DepositoDeAutos d, Auto a)
        {
            bool flag = false;

            if (d.lista.Count < d.cantidadMaxima)
            {
                d.lista.Add(a);
                flag = true;
            }

            return flag;
        }

        private int GetIndice(Auto a)
        {
            int index = -1;

            foreach (Auto aux in this.lista)
            {
                if(a == aux)
                {
                    index = this.lista.IndexOf(aux);
                    break;
                }
            }

            return index;
        }

        public static bool operator -(DepositoDeAutos d, Auto a)
        {
            bool flag = false;

            if (d.GetIndice(a) != -1)
            {
                d.lista.Remove(a);
                flag = true;
            }         
                
            return flag;
        }

        public bool Agregar(Auto a)
        {           
            return this + a;
        }

        public bool Remover(Auto a)
        {
            return this - a;
        }

        public override string ToString()
        {
            string retorno;

            retorno = "Capacidad máxima: " + this.cantidadMaxima + "\nListado de autos: ";
            
            foreach (Auto aux in this.lista)
            {
                retorno += aux.ToString();
            }

            return retorno += "\n";
        }

    }
}
