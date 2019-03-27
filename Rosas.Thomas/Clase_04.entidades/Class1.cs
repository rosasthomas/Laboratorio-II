using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04.entidades
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;

        public string mostrar()
        {
            string retorno = "";
            retorno = (this.entero.ToString() + " - " + this.cadena + " - " + this.fecha).ToString();
            return retorno;
        }

        static public string mostrar(Cosa obj)
        {
            string retorno = "";
            retorno = obj.mostrar();
            return retorno;
        }

        public void establecerValor(int entero)
        {
            this.entero = entero;
        }
        public void establecerValor(string cadena)
        {
            this.cadena = cadena;
        }
        public void establecerValor(DateTime fecha)
        {
            this.fecha = fecha;
        }

        public Cosa()
        {
            this.entero = 10;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(int entero) : this()
        {
            this.entero = entero;
        }
        public Cosa(int entero, string cadena) : this(entero)
        {
            this.cadena = cadena;
        }
        public Cosa(int entero, string cadena, DateTime fecha) : this(entero, cadena)
        {
            this.fecha = fecha;
        }
    }
}
