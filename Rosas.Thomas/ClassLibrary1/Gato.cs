using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Gato : Mascota
    {
        public Gato(string nombre, string raza) : base(nombre,raza)
        {
        }

        protected override string Ficha()
        {
            return DatosCompletos();
        }

        public static bool operator ==(Gato gatoUno, Gato gatoDos)
        {
            bool retorno = false;

            if (gatoUno.Nombre == gatoDos.Nombre && gatoUno.Raza == gatoDos.Raza)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Gato gatoUno, Gato gatoDos)
        {
            return !(gatoUno == gatoDos);
        }

        public override string ToString()
        {
            return this.Ficha();
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Gato)
            {
                retorno = (this == obj);
            }

            return retorno;
        }
    }
}
