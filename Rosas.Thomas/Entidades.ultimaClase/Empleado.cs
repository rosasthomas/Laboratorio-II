using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.ultimaClase
{
    public class Empleado
    {
        private string _nombre;
        private int _legajo;
        private float _sueldo;

        public event DelegadoSueldo _limiteSueldo;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public int Legajo
        {
            get { return _legajo; }
            set { _legajo = value; }
        }

        public float Sueldo
        {
            get { return _sueldo; }
            set
            {
                if (value > 12000)
                {
                    this._limiteSueldo(this, value);
                }
                else
                    _sueldo = value;
            }
        }

        public override string ToString()
        {
            return "Nombre: " + this.Nombre + " - Legajo: " + this.Legajo + " - Sueldo: " + this.Sueldo; 
        }
    }
}
