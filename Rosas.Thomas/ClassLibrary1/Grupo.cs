using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Grupo
    {
        private List<Mascota> _manada;
        private string _nombre;
        private static EtipoManada _tipo;

        public EtipoManada Tipo
        {
            set {_tipo = value; }
        }

        static Grupo()
        {
            _tipo = EtipoManada.Unica;
        }
        private Grupo()
        {
            this._manada = new List<Mascota>();
        }
        public Grupo(string nombre) : this()
        {
            this._nombre = nombre;
        }
        public Grupo(string nombre, EtipoManada tipo) : this(nombre)
        {           
            this.Tipo = tipo;
        }

        public static bool operator ==(Grupo g, Mascota m)
        {
            bool retorno = false;

            foreach (Mascota masc in g._manada)
            {               
                if (masc == m)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Grupo g, Mascota m)
        {
            return !(g == m);
        }

        public static Grupo operator +(Grupo g, Mascota m)
        {
            if(g != m)
            {
                g._manada.Add(m);
            }
            else
            {
                Console.WriteLine("Ya está " + m.ToString() + " en el grupo");
            }

            return g;
        }

        public static Grupo operator -(Grupo g, Mascota m)
        {
            if (g == m)
            {
                g._manada.Remove(m);
            }
            else
            {
                Console.WriteLine("No está " + m.ToString() + " en el grupo");
            }

            return g;
        }

        public static implicit operator string(Grupo g)
        {
            string retorno;

            retorno = "Grupo: " + g._nombre + " - " + "tipo: " + _tipo;
            retorno += "\nIntegrantes (" + g._manada.Count + "):\n";
            foreach (Mascota m in g._manada)
            {
                retorno += m.ToString() + "\n";
            }
            return retorno;
        }

    }
}
