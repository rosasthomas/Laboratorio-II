using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTest.clase20
{
    public class Manejadora
    {


        public static void Manejador(object obj, EventArgs e)
        {
            MessageBox.Show("Estoy usando la clase estatica manejadora");
            MessageBox.Show("lo provovo " + obj.ToString());
        }

        public void ManejadorIns(object obj, EventArgs e)
        {
            MessageBox.Show("Estoy usando la clase de instancia manejadora");
            if (obj is TextBox)
            {
                MessageBox.Show("Lo provoco txtbox");
            }
            else if(obj is Label)
            {
                MessageBox.Show("Lo provoco lbl");
            }
            else if (obj is Button)
            {
                MessageBox.Show("Lo provoco btn");
            }
            
        }

        
    }
}
