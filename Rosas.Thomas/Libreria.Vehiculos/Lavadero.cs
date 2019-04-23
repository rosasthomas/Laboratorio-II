using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Vehiculos
{
    public class Lavadero
    {
        private List<Vehiculos> _vehiculos;
        private float _precioAuto;
        private float _precioCamion;
        private float _precioMoto;

        private Lavadero()
        {
            _vehiculos = new List<Vehiculos>();
        }

        public Lavadero(float PrecioAuto, float PrecioCamion, float PrecioMoto) : this()
        {            
            this._precioAuto = PrecioAuto;
            this._precioCamion = PrecioCamion;
            this._precioMoto = PrecioMoto;
        }

        public  string MiLavadero
        {
            get { return "-Precio auto :" + this._precioAuto.ToString() + "\n-Precio camion: " + this._precioCamion.ToString() + "\n-Precio Moto" + this._precioMoto.ToString() + MisVehiculos; }
        }

        public string MisVehiculos
        {
            get 
            { 
                string retorno = "";

                foreach (Vehiculos v in _vehiculos)
	            {
                    //if(v is Auto)
                    //{
                    //    retorno += ((Auto)v).MostrarAuto() + "\n";
                    //}
                    //else if (v is Camion)
                    //{
                    //    retorno += ((Camion)v).MostrarCamion() + "\n";
                    //}
                    //else if (v is Moto)
                    //{
                    //    retorno += ((Moto)v).MostrarMoto() + "\n";
                    //}

                    retorno += v.ToString();
                }
            
                return retorno; 
            }

        }

        


        public static bool operator ==(Lavadero l, Vehiculos v)
        {
            bool retorno = false;

            foreach (Vehiculos ve in l._vehiculos)
            {
                if (ve.MiPatente == v.MiPatente && ve.MiMarca == v.MiMarca)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        public static bool operator !=(Lavadero l, Vehiculos v)
        {
            return !(l == v);
        }

        public static Lavadero operator +(Lavadero l, Vehiculos v)
        {
            if(!(l == v))
            {
                l._vehiculos.Add(v);
            }

            return l;
        }

        public static Lavadero operator -(Lavadero l, Vehiculos v)
        {
            if (l == v)
            {
                l._vehiculos.Remove(v);
            }

            return l;
        }

        public double MostrarTotalFacturado()
        {
            double retorno = 0;

            foreach (Vehiculos v in _vehiculos)
            {
                if (v is Auto)
                {
                    retorno += _precioAuto;
                }
                else if (v is Camion)
                {
                    retorno += _precioCamion;
                }
                else if (v is Moto)
                {
                    retorno += _precioMoto;
                }
            }
            return retorno;
        }

        public double MostrarTotalFacturado(EVehiculo tipo)
        {
            double total = 0;

            foreach (Vehiculos v in _vehiculos)
            {
                if(v is Auto && tipo == EVehiculo.Auto)
                {
                    total += _precioAuto;
                }
                else if (v is Moto && tipo == EVehiculo.Moto)
                {
                    total += _precioMoto;
                }
                else if (v is Camion && tipo == EVehiculo.Camion)
                {
                    total += _precioCamion;
                }
            }

            return total;
        }
    }
}
