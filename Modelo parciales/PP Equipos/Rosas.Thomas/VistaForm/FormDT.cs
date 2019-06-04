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
    public partial class FormDT : Form
    {
        public DirectorTecnico d;
        public FormDT()
        {
            InitializeComponent();
            
        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            d = new DirectorTecnico(txtbxNombre.Text, txtbxApellido.Text, (int)nUDEdad.Value, (int)nUDDni.Value, (int)nUDExp.Value);
            MessageBox.Show("Se ha creado el DT!!");
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if (d == null)
            {
                MessageBox.Show("Aun no se ha creado el Dt del formulario.");
            }
            else if (d.ValidarAptitud())
            {
                MessageBox.Show("El DT es apto.");
            }
            else
            {
                MessageBox.Show("El DT no es apto.");
            }
        }
    }
}
