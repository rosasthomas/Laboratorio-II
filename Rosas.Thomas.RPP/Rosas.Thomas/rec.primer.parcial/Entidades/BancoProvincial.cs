using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class BancoProvincial : BancoNacional
    {
        public string provincia;

        public BancoProvincial(BancoNacional bN, string provincia) : base(bN.nombre, bN.pais)
        {
            this.provincia = provincia;
        }

        public override string Mostrar()
        {            
            return base.Mostrar();  
        }

        public override string Mostrar(Banco b)
        {
            return base.Mostrar(b) + "\nProvincia: " + ((BancoProvincial)b).provincia;
        }
    }
}
