using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico : Persona
    {
        private int añosExperiencia;

        public int AñosExperiencia
        {
            get { return this.añosExperiencia; }
            set { this.añosExperiencia = value; }
        }

        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia) : base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }

        public override string Mostrar()
        {
            return base.Mostrar() + " - Años de experiencia: " + this.AñosExperiencia;  
        }

        public override bool ValidarAptitud()
        {
            bool flag = false;

            if (this.Edad < 65 && this.AñosExperiencia >= 2)
            {
                flag = true;
            }

            return flag;
        }
    }
}
