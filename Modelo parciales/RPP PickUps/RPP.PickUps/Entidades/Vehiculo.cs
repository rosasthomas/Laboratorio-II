using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        protected DateTime ingreso;
        private string patente;

        public string Patente
        {
            get { return patente; }
            set
            {
                if (value.Length == 6)
                {
                    patente = value;
                }
            }
        }

        public Vehiculo(string patente)
        {
            this.ingreso = DateTime.Now.AddHours(-3);
            this.Patente = patente;
        }

        public abstract string ConsultarDatos();

        public virtual string ImprimirTicket()
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(this.ToString());
            datos.Append( " - " + ingreso.ToLocalTime());

            return datos.ToString();
        } 

        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            if(v1.Patente == v2.Patente && Equals(v1, v2))
            {
                retorno = true;
            }

            return retorno;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return String.Format("Patente {0}", this.Patente);
        }


    }
}
