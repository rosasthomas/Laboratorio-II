using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace VistaForm
{
    public partial class FrmPickUp : Form
    {
        public FrmPickUp()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            PickUp p = new PickUp(txtbxPatente.Text, txtbxModelo.Text);
            MessageBox.Show(p.ConsultarDatos());
        }
    }
}
