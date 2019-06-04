using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        private ConsoleColor color;
        private static int valorHora;

        static Automovil()
        {
            valorHora = 50;
        }

        public Automovil(string patente, ConsoleColor color) : base(patente)
        {
            this.color = color;
        }
        public Automovil(string patente, ConsoleColor color, int valorHoras) : this(patente, color)
        {
            valorHora = valorHoras;
        }

        public override string ConsultarDatos()
        {
            return "Patente: " + this.Patente + " - Color: " + this.color;
        }

        public override bool Equals(object obj)
        {
            bool flag = false;

            if (obj is Automovil)
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
