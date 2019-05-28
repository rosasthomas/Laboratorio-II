using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Deposito
{
    public class Cocina
    {
        private int _codigo;
        private bool _esIndustrial;
        private double _precio;

        public int Codigo
        {
            get { return this._codigo; }
        }

        public bool EsIndustrial
        {
            get { return this._esIndustrial; }
        }

        public double Precio
        {
            get { return this._precio; }
        }

        public Cocina(int codigo, double precio, bool esIndustrial)
        {
            this._codigo = codigo;
            this._esIndustrial = esIndustrial;
            this._precio = precio;
        }

        public static bool operator ==(Cocina a, Cocina b)
        {
            bool flag = false;

            if (a.Codigo == b.Codigo)
            {
                flag = true;
            }

            return flag;
        }

        public static bool operator !=(Cocina a, Cocina b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Cocina)
            {
                retorno = (this == (Cocina)obj);
            }

            return retorno;
        }

        public override string ToString()       
        {
            return "\nCodigo: " + this.Codigo + " - Precio: " + this.Precio + " - Es industrial? " + this.EsIndustrial;
        }


    }
}
