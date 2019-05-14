using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Clase_14
{
    public class ErrorParserException : Exception
    {
        public ErrorParserException(string m, Exception i) :base(m, i)
        {

        }
    }
}
