using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Vehiculos
{
    public class Camion : Vehiculos
    {
        protected float Tara;

        public Camion(string patente, EMarca Marca, byte CantidadRuedas, float Tara) : base(patente, Marca, CantidadRuedas)
        {
            this.Tara = Tara;
        }

        public string MostrarCamion()
        {
            return  base.Mostrar() + ", " + Tara.ToString();
        }

        
    }
}
