using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estacionamiento
    {
        private int espacioDisponible;
        private string nombre;
        private List<Vehiculo> vehiculos;

        private Estacionamiento()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Estacionamiento(string nombre, int espacioDisponible) : this()
        {
            this.nombre = nombre;
            this.espacioDisponible = espacioDisponible;
        }

        public static explicit  operator string(Estacionamiento e)
        {
            StringBuilder datos = new StringBuilder();

            datos.Append(e.nombre);
            datos.AppendLine("");
            datos.AppendFormat("Espacio disponible: {0}", e.espacioDisponible);

            foreach (Vehiculo v in e.vehiculos)
            {
                if(v is Moto)
                {
                    datos.AppendLine(((Moto)v).ConsultarDatos());
                }
                else if(v is PickUp)
                {
                    datos.AppendLine(((PickUp)v).ConsultarDatos());
                }
                else if (v is Automovil)
                {
                    datos.AppendLine(((Automovil)v).ConsultarDatos());
                }
            }

            return datos.ToString();
        }

        public static bool operator ==(Estacionamiento e, Vehiculo v)
        {
            bool flag = false;

            foreach (Vehiculo ve in e.vehiculos)
            {
                if(ve == v)
                {
                    flag = true;
                }
            }

            return flag;
        }

        public static bool operator !=(Estacionamiento e, Vehiculo v)
        {
            return !(e == v);
        }

        public static Estacionamiento operator +(Estacionamiento e, Vehiculo v)
        {
            if (e != v && v.Patente != null && e.vehiculos.Count < e.espacioDisponible)
            {
                e.vehiculos.Add(v);
            }

            return e;
        }

        public static string operator -(Estacionamiento e, Vehiculo v)
        {
            string retorno;

            if (e == v)
            {
                retorno = v.ImprimirTicket();
            }
            else
            {
                retorno = "El vehiculo no es parte del estacionamiento";
            }

            return retorno;
        }

    }
}
