using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Vehiculos
{
    public class Auto : Vehiculos
    {
        protected int CantidadAsientos;

        public Auto(string patente, EMarca Marca, byte CantidadRuedas, int CantidadAsientos) : base(patente, Marca, CantidadRuedas)
        {          
            this.CantidadAsientos = CantidadAsientos;
        }

        //public string MostrarAuto()
        //{
        //    return base.Mostrar() + ", " + CantidadAsientos.ToString();
        //}

        public override string ToString()
        {
            return "Auto: " + base.ToString() + ", " + CantidadAsientos.ToString();
        }

        public override double Precio
        {
            get;
            set;
        }

        public override double CalcularPrecioConIVA()
        {
            return Precio * 1.21;
        }
    }


}
