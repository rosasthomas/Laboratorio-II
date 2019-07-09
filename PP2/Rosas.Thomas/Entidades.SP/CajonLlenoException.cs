using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.SP
{
    public class CajonLlenoException : Exception
    {
        public CajonLlenoException(string message) : base(message)
        {
        }
    }
}
