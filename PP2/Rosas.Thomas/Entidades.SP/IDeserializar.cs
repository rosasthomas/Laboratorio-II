using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.SP
{
    public interface IDeserializar
    {
        bool Xml(string path, out Fruta f);
    }
}
