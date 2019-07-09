using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Entidades.SP
{
    public class Cajon<T> : ISerializable
    {
        protected int _capacidad;
        protected List<T> _elementos;
        protected double _precioUnitario;
        public event PrecioExcedido eventoPrecio;

        public double PrecioUnitario
        {
            get { return this._precioUnitario; }
            set { this._precioUnitario = value; }
        }

        public List<T> Elementos
        {
            get
            {
                return this._elementos;
            }
        }

        public double PrecioTotal
        {
            get
            {
                return this._precioUnitario * this._elementos.Count;
            }
        }

        public Cajon()
        {
            this._elementos = new List<T>();
        }

        public Cajon(int capacidad) : this()
        {
            this._capacidad = capacidad;
        }

        public Cajon(double precioUnitario, int capacidad) : this(capacidad)
        {
            this._precioUnitario = precioUnitario;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Cajon:\n");
            sb.AppendFormat("Capacidad: {0}", this._capacidad);
            sb.AppendFormat("\nCantidad total de elementos: {0}", this._elementos.Count);
            sb.AppendFormat("\nPrecio Total: {0}", this.PrecioTotal);
            sb.AppendLine("\n\nFrutas:\n");
            foreach (T item in this._elementos)
            {
                if (item != null)
                {
                    sb.AppendLine(item.ToString());
                }
            }

            return sb.ToString();
        }

        public bool Xml(string path)
        {
            bool flag = false;
            StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\" + path); ;

            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(Cajon<T>));
                ser.Serialize(sw, this);
                flag = true;
            }
            catch (Exception e)
            {
                flag = false;
                throw e;
            }
            finally
            {
                sw.Close();
            }

            return flag;
        }

        public static Cajon<T> operator +(Cajon<T> cajon, T fruta)
        {
            try
            {
                if (cajon.PrecioTotal > 55)
                {
                    cajon.eventoPrecio(cajon);
                }
                else if (cajon._elementos.Count < cajon._capacidad)
                {
                    cajon._elementos.Add(fruta);
                }
                else if (cajon._elementos.Count >= cajon._capacidad)
                {
                    throw new CajonLlenoException("El cajon tiene la maxima cantidad de frutas.");
                }
            }
            catch (CajonLlenoException e)
            {
                throw e;
            }

            return cajon;
        }

        
    }

    public delegate void PrecioExcedido(object sender);
}
