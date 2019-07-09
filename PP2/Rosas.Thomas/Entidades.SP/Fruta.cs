using System;

namespace Entidades.SP
{
    public abstract class Fruta
    {
        protected string _color;
        protected double _peso;

        public abstract bool TieneCarozo { get; }

        public Fruta()
        {

        }

        public double Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }


        public Fruta(string color, double peso)
        {
            this._color = color;
            this._peso = peso;
        }

        protected virtual string FrutaToString()
        {
            return "Peso: " + this._peso + "\nColor: " + this._color;
        }
    }
}
