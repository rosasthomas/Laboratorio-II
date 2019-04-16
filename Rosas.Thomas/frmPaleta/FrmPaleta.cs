using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Libreria;

namespace frmPaleta
{
    public partial class FrmPaleta : Form
    {
        Paleta miPaleta = 5;       

        public FrmPaleta()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmTempera frmTempera = new FrmTempera();
            frmTempera.ShowDialog();
            
            miPaleta += frmTempera.MiTempera;

            LstLista.Items.Clear();
            foreach (Tempera t in miPaleta.MiTemperas)
            {
                if(frmTempera.DialogResult == DialogResult.OK && t != null)
                {
                    LstLista.Items.Add(Tempera.Mostrar(t));
                }
            }
        }

        private void BtnMenos_Click(object sender, EventArgs e)
        {
            int indexAux;

            indexAux = LstLista.SelectedIndex;

            FrmTempera frmTemperaMenos = new FrmTempera(miPaleta.MiTemperas[indexAux]);
            frmTemperaMenos.ShowDialog();

            if (frmTemperaMenos.DialogResult == DialogResult.OK)
            {
                miPaleta -= miPaleta.MiTemperas[indexAux];
            }

            foreach (Tempera t in miPaleta.MiTemperas)
            {
                if (t == null)
                {
                    LstLista.Items.RemoveAt(indexAux);
                }
            }
        }
    }
}
