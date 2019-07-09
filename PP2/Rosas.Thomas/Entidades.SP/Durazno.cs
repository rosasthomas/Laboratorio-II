using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.SP
{
    public class Durazno : Fruta
    {
        protected int _cantPelusa;

        public string Nombre
        {
            get
            {
                return "Durazno";
            }
        }

        public Durazno()
        {

        }
        public Durazno(string color, double peso, int pelusa) : base(color, peso)
        {
            this._cantPelusa = pelusa;
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + "\nNombre: " + this.Nombre + "\nCantidad de pelusa: " + this._cantPelusa + "\nTiene carozo?: " + this.TieneCarozo;
        }

        public override string ToString()
        {
            return this.FrutaToString();
        }

        public override bool TieneCarozo
        {
            get
            {
                return true;
            }
        }
    }
}
