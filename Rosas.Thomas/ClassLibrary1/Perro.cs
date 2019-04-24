using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Perro : Mascota
    {
        private int edad;
        private bool esAlfa;

        public Perro(string nombre, string raza) : this(nombre, raza, 0, false)
        {
        }

        public Perro(string nombre, string raza, int edad, bool esAlfa) : base(nombre, raza)
        {
            this.edad = edad;
            this.esAlfa = esAlfa;
        }

        protected override string Ficha()
        {
            string retorno;

            if (this.esAlfa)
            {
                retorno = base.DatosCompletos() + ", alfa de la manada, edad " + this.edad;
            }
            else
            {
                retorno = base.DatosCompletos() + ", edad " + this.edad;
            }

            return retorno;
        }

        public static bool operator ==(Perro perroUno, Perro perroDos)
        {
            bool retorno = false;

            if (perroUno.Nombre == perroDos.Nombre && perroUno.Raza == perroDos.Raza && perroUno.edad == perroDos.edad)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Perro perroUno, Perro perroDos)
        {
            return !(perroUno == perroDos);
        }

        public static explicit operator int(Perro p)
        {
            return p.edad;
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if(obj is Perro)
            {
                retorno = (this == obj);
            }

            return retorno;
        }

    }
}
