using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PickUp : Vehiculo
    {
        private string modelo;
        private static int valorHora;

        static PickUp()
        {
            valorHora = 70;
        }

        public PickUp(string patente, string modelo) : base(patente)
        {
            this.modelo = modelo;
        }
        public PickUp(string patente, string modelo, int valorHoras) : this(patente, modelo)
        {
            valorHora = valorHoras;
        }

        public override string ConsultarDatos()
        {
            return "Patente: " + this.Patente + " - Modelo: " + this.modelo;
        }

        public override bool Equals(object obj)
        {
            bool flag = false;

            if (obj is PickUp)
            {
                flag = true;
            }

            return flag;
        }

        public override string ImprimirTicket()
        {
            return base.ImprimirTicket() + "\n Costo de estadia: " + (DateTime.Now - this.ingreso).TotalHours * valorHora;
        }
    }
}
