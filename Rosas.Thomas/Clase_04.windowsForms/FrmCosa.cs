using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_04.entidades;

namespace Clase_04.windowsForms
{
    public partial class FrmCosa : Form
    {
        public FrmCosa()
        {
            InitializeComponent();
        }

        private void FrmCosa_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo");
            this.Text = "Holas";

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cosa objeto = new Cosa();
            MessageBox.Show(objeto.mostrar());
            this.button1.Text = "Crear cosa bonita";
            this.BackColor = Color.Aquamarine;
        }
    }
}
