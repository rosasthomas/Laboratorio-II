using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.SP
{
    public class Banana : Fruta
    {
        protected string _paisOrigen;

        public string Nombre
        {
            get
            {
                return "Banana";
            }
        }
        public Banana()
        {

        }

        public Banana(string color, double peso, string pais) : base(color, peso)
        {
            this._paisOrigen = pais;
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + "\nNombre: " + this.Nombre + "\nPais de origen: " + this._paisOrigen + "\nTiene carozo?: " + this.TieneCarozo;
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
        }
    }
}
