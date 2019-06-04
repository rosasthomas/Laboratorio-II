using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico {
            set {
                    if (value.ValidarAptitud())
                    {
                        this.directorTecnico = value;
                    };
                }
        }

        public string Nombre{ get { return this.nombre; } }

        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }

        public Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0} - Cantidad maxima de jugadores: {1}", e.Nombre, cantidadMaximaJugadores);
            if (e.directorTecnico != null)
            {
                sb.AppendFormat(" - DT: {0}", e.directorTecnico.Mostrar());
            }
            else
            {
                sb.Append(" - Sin DT asignado");
            }

            sb.AppendLine("\nJugadores:\n");
            foreach (Jugador j in e.jugadores)
            {
                sb.AppendLine(j.Mostrar());
            }

            return sb.ToString();
        }

        public static bool operator ==(Equipo e, Jugador j)
        {
            bool flag = false;

            foreach (Jugador jugador in e.jugadores)
            {
                if (jugador.Dni == j.Dni)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count < cantidadMaximaJugadores && j.ValidarAptitud())
            {
                e.jugadores.Add(j);
            }

            return e;
        }

        public static bool ValidarEquipo(Equipo e)
        {
            bool flag = false;

            if (e.directorTecnico != null)
            {
                bool flagArq = false;
                bool flagDel = false;
                bool flagCent = false;
                bool flagDef = false;
                int ArqCount = 0;

                foreach (Jugador jugador in e.jugadores)
                {
                    if (jugador.Posicion == Posicion.Arquero)
                    {
                        flagArq = true;
                        ArqCount++;
                    }
                    else if (jugador.Posicion == Posicion.Central)
                        flagCent = true;
                    else if (jugador.Posicion == Posicion.Defensor)
                        flagDef = true;
                    else if (jugador.Posicion == Posicion.Delantero)
                        flagDel = true;
                }

                if (flagArq && flagDel && flagDef && flagCent && ArqCount == 1 && e.jugadores.Count == cantidadMaximaJugadores)
                {
                    flag = true;
                }
            }

            return flag;
        }

    }
}
