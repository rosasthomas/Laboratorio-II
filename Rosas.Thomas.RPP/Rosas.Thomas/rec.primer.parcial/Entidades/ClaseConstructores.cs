using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class ClaseConstructores
    {

        static ClaseConstructores() 
        {
            MessageBox.Show("Constructor Estatico");
        }

        private ClaseConstructores(string par1, string par2)
        {
            MessageBox.Show("Constructor privado con dos parametros");
        }

        public ClaseConstructores():this("asd", "asd")
        {
            MessageBox.Show("Constructor default");
            this.PropEscritura = 2;

        }

        private int propEscritura;

        public int PropEscritura
        {
            set {
                MessageBox.Show("Propiedad de escritura");
                propEscritura = this.PropLectura; }
        }

        private int propLectura;

        public int PropLectura
        {
            get {
                MessageBox.Show("Propiedad de lectura");
                return MetodoDeInstancia(); }
        }

        public int MetodoDeInstancia()
        {
            MessageBox.Show("Metodo de instancia");
            return MetodoDeClase();
            
        }

        public static int MetodoDeClase()
        {
            MessageBox.Show("Metodo de clase");
            return 1;
        }

    }
}
