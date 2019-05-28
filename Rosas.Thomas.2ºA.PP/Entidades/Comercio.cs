using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercio
    {
        protected int _cantidadDeEmpleados;
        protected Comerciante _comerciante;
        protected static Random _generadorDeEmpleados;
        protected string _nombre;
        protected float _precioAlquiler;

        public int CantidadDeEmpleados
        {
            get {
                    if(this._cantidadDeEmpleados == 0)
                    {                        
                        this._cantidadDeEmpleados = _generadorDeEmpleados.Next(0,100);
                    }
                    return this._cantidadDeEmpleados;
                }
        }

        static Comercio()
        {
            _generadorDeEmpleados = new Random();
        }

        public Comercio(float precioAlquiler, string nombreComercio, string nombre, string apellido)
        {
            this._precioAlquiler = precioAlquiler;
            this._nombre = nombreComercio;
            this._comerciante = new Comerciante(nombre, apellido);
        }

        public Comercio(string nombre, Comerciante comerciante, float precioAlquiler)
        {
            this._nombre = nombre;
            this._comerciante = comerciante;
            this._precioAlquiler = precioAlquiler;
            
        }

        public static explicit operator string(Comercio c)
        {
            return Comercio.Mostrar(c);
        }

        private static string Mostrar(Comercio c)
        {
            return "\n\nNombre de comercio: " + c._nombre  + "\nCantidad de empleados: " + c.CantidadDeEmpleados + "\nComerciante: " + c._comerciante + "\nPrecio de alquiler: " + c._precioAlquiler;
        }

        public static bool operator ==(Comercio a, Comercio b)
        {
            bool retorno = false;

            if (a._nombre == b._nombre && a._comerciante == b._comerciante)
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Comercio a, Comercio b)
        {
            return !(a == b);
        }

    }
}
