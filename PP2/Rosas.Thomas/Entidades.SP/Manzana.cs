using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Entidades.SP
{
    public class Manzana : Fruta, ISerializable, IDeserializar
    {
        protected string _provinciaOrigen;

        public string Nombre
        {
            get
            {
                return "Manzana";
            }
        }

        public Manzana()
        {

        }
        public Manzana(string color, double precio, string provincia) : base(color, precio)
        {
            this._provinciaOrigen = provincia;
        }

        protected override string FrutaToString()
        {
            return base.FrutaToString() + "\nNombre: " + this.Nombre + "\nProvincia de origen: " + this._provinciaOrigen + "\nTiene carozo?: " + this.TieneCarozo;
        }

        public override string ToString()
        {
            return this.FrutaToString() ;
        }

        public bool Xml(string path)
        {
            bool flag = false;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Manzana));
                StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + path);
                ser.Serialize(sw, this);
                sw.Close();
                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
                throw e;
            }

            return flag;
        }

        bool IDeserializar.Xml(string path, out Fruta f)
        {
            bool flag = false;
            StreamReader sr = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + path);

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Manzana));
                f = (Manzana)ser.Deserialize(sr);
                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
                throw e;
            }
            finally
            {
                sr.Close();
            }

            return flag;
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
