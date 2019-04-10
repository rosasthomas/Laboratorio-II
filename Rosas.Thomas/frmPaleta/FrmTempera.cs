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
    public partial class FrmTempera : Form
    {
        private Tempera _miTempera;

        public Tempera MiTempera
        {
            get { return _miTempera; }           
        }


        public FrmTempera()
        {
            InitializeComponent();
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                CboColor.Items.Add(c);
            }
        }

        private void Cantidad_Click(object sender, EventArgs e)
        {

        }

        private void CboColor_SelectedIndexChanged(object sender, EventArgs e)
        {            
            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Tempera NuevaTempera = new Tempera((ConsoleColor)this.CboColor.SelectedItem, this.TxtMarca.Text, sbyte.Parse(this.TxtCantidad.Text));            
            this._miTempera = NuevaTempera;
            this.DialogResult = DialogResult.OK;
        }
    }
}
