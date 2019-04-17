using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Vehiculos
{
    public class Moto : Vehiculos   
    {
        protected float Cilindrada;

        public Moto(string patente, EMarca Marca, byte CantidadRuedas, float Cilindrada) : base(patente, Marca, CantidadRuedas)
        {
            this.Cilindrada = Cilindrada;
        }

        public string MostrarMoto()
        {
            return base.Mostrar() + ", " + Cilindrada.ToString();
        }
    }
}
