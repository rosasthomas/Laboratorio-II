using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmTest.clase20
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
            Manejadora m = new Manejadora();
            this.BtnBoton.Click += new EventHandler(Manejadora.Manejador);
            this.TxtCuadroTexto.Click += new System.EventHandler(Manejadora.Manejador);
            this.LblEtiqueta.Click += new EventHandler(Manejadora.Manejador);

            this.BtnBoton.Click += new EventHandler(m.ManejadorIns);
            this.TxtCuadroTexto.Click += new System.EventHandler(m.ManejadorIns);
            this.LblEtiqueta.Click += new EventHandler(m.ManejadorIns);
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {

        }

        private void MostrarMensaje(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del boton");
            
        }

        private void LblEtiqueta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del label");

        }

        private void TxtCuadroTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del txtbox");
        }

        private void FrmTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Evento click del frm");
        }

        private void BtnBoton_Click(object sender, EventArgs e)
        {

        }
    }
}
