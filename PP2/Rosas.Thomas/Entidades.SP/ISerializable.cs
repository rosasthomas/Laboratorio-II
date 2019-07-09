using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades.SP
{
    public interface ISerializable
    {
        bool Xml(string path);
    }
}
