using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Entidades.Humanos
{
    public class Persona : Humano , ISerializableXML
    {
        public string nombre;
        public string apellido;


        public Persona()
        {

        }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public override string ToString()
        {
            return base.ToString() + " - Nombre: " + this.nombre + " - Apellido: " + this.apellido;
        }

        public bool SerializarXML()
        {
            bool flag = false;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Persona));
                StreamWriter sw = new StreamWriter(Path);
                ser.Serialize(sw);
                sw.Close();
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
            }

            return flag;
        }
        public bool Deserializar()
        {
            Persona a = new Persona();

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Persona));
                StreamReader sr = new StreamReader(Path);

                a = (Persona)ser.Deserialize(sr);
                sr.Close();
            }
            catch (Exception)
            {
                a = null;
            }

            return a;
        }
        private string _path;
        string Path
        {
            get {return _path; }
            set {_path = value; }
        }
    }
}
