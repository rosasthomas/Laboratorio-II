using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BancoMunicipal : BancoProvincial
    {
        public string municipio;

        public BancoMunicipal(BancoProvincial bP, string municipio) : base(new BancoNacional(bP.nombre, bP.pais) ,bP.provincia)
        {
            this.municipio = municipio;
        }

        public static implicit operator string(BancoMunicipal bM)
        {
            return "Nombre: " + bM.nombre + " - Pais:" + bM.pais + " - Provincia: " + bM.provincia + " - Municipio: " + bM.municipio;
        }

        public override string ToString()
        {
            return this; 
        }

        public override string Mostrar()
        {
            return "Nombre: " + this.nombre;
        }

        public override string Mostrar(Banco b)
        {
            return base.Mostrar(b) + " - Municipio: " + this.municipio;
        }

    }
}
