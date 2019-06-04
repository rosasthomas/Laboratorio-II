using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades.Humanos
{
    [Serializable]
    [XmlInclude(typeof(Persona))]
    [XmlInclude(typeof(Alumno))]
    [XmlInclude(typeof(Profesor))]

    public class Humano
    {
        private int _dni;

        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public override string ToString()
        {
            return "Dni: " + this.Dni.ToString(); 
        }

    }
}
