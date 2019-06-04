using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Humanos
{
     interface ISerializableXML
    {
        bool SerializarXML();
        bool Deserializar();

        string Path
        {
            get;
            set; 
        }

    }
}
