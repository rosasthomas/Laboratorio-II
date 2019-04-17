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
            new List<Vehiculos>();
        }

        public Lavadero(float PrecioAuto, float PrecioCamion, float PrecioMoto) : this()
        {            
            this._precioAuto = PrecioAuto;
            this._precioCamion = PrecioCamion;
            this._precioMoto = PrecioMoto;
        }

        public  string MiLavadero
        {
            get { return this._precioAuto.ToString() + ", " + this._precioCamion.ToString() + ", " + this._precioCamion.ToString() + MisVehiculos; }
        }

        public string MisVehiculos
        {
            get 
            { 
                string retorno = "";

                foreach (Vehiculos v in _vehiculos)
	            {
                    if(v is Auto)
                    {
                        retorno += ((Auto)v).MostrarAuto() + "\n";
                    }
                    else if (v is Camion)
                    {
                        retorno += ((Camion)v).MostrarCamion() + "\n";
                    }
                    else if (v is Moto)
                    {
                        retorno += ((Moto)v).MostrarMoto() + "\n";
                    }
                }
            
                return retorno; 
            }

        }





    }
}
