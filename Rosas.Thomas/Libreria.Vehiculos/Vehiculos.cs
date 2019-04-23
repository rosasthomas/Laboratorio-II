using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Vehiculos
{
    public abstract class Vehiculos
    {
        protected string _patente;
        protected EMarca _marca;
        protected byte _cantidadRuedas;

        public abstract double Precio { get; set; }
        public abstract double CalcularPrecioConIVA();


        private Vehiculos _miPatente;

        public Vehiculos MiPatente
        {
            get { return _miPatente; }
        }

        private Vehiculos _miMarca;

        public Vehiculos MiMarca
        {
            get { return _miMarca; }
        }

        public Vehiculos(string patente, EMarca Marca, byte CantidadRuedas)
        {
            this._patente = patente;
            this._marca = Marca;
            this._cantidadRuedas = CantidadRuedas;
        }

        //protected string Mostrar()
        //{
        //    return _patente + ", " + _marca.ToString() + ", " + _cantidadRuedas.ToString();
        //}

        public static bool operator ==(Vehiculos vehiculoUno, Vehiculos vehiculoDos)
        {
            bool retorno = false;

            if (vehiculoUno._miPatente == vehiculoDos._miPatente && vehiculoUno._miMarca == vehiculoDos._miMarca )
            {
                retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Vehiculos vehiculoUno, Vehiculos vehiculoDos)
        {
            return !(vehiculoUno == vehiculoDos);
        }

       

        public override string ToString()
        {
            return _patente + ", " + _marca.ToString() + ", " + _cantidadRuedas.ToString();
        }
    }
}
