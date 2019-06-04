using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        private int cilindrada;
        private short ruedas;
        private static int valorHora;

        static Moto()
        {
            valorHora = 30;
        }

        public Moto(string patente, int cilindrada):this(patente, cilindrada, 2, 30)
        {

        }
        public Moto(string patente, int cilindrada, short ruedas):base(patente)
        {
            this.cilindrada = cilindrada;
            this.ruedas = ruedas;
        }
        public Moto(string patente, int cilindrada, short ruedas, int valorHoras) : this(patente, cilindrada, ruedas)
        {            
            valorHora = valorHoras;
        }

        public override string ConsultarDatos()
        {
            return "Patente: " + this.Patente + " - Cilindrada: " + this.cilindrada + " - Ruedas: " + this.ruedas;
        }

        public override bool Equals(object obj)
        {
            bool flag = false;

            if (obj is Moto)
            {
                flag = true ;
            }

            return flag;
        }

        public override string ImprimirTicket()
        {
            return base.ImprimirTicket() + "\n Costo de estadia: " + (DateTime.Now - this.ingreso).TotalHours * valorHora;
        }

    }
}
