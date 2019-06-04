using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private string nombre;
        private int edad;
        private int dni;

        public string Apellido { get { return this.apellido; } }
        public string Nombre { get { return this.nombre; } }
        public int Edad { get { return this.edad; } }
        public int Dni { get { return this.dni; } }

        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
        }
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Nombre: {0} - Apellido: {1} - Edad: {2} - Dni: {3}", this.Nombre, this.Apellido, this.Edad, this.Dni);

            return sb.ToString();
        }

        public abstract bool ValidarAptitud();
    }
}
