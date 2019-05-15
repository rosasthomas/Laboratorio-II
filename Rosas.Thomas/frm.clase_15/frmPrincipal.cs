using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace frm.clase_15
{
    public partial class FrmPrincipal : Form
    {
        private string _path;
        public FrmPrincipal()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            this.openFileDialog1.Title = "Seleccione un archivo...";
            this.openFileDialog1.DefaultExt = ".txt";
            this.openFileDialog1.AddExtension = true;
            this.openFileDialog1.Filter = "Archivos *.txt|*.TXT";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {

                //string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\miArchivo.txt"; //AppDomain.CurrentDomain.BaseDirectory + @"miArchivo.txt";
                if (_path != null)
                {
                    StreamWriter lista = new StreamWriter(_path,true);
                     lista.Write(txtValor.Text);
                     lista.Close();
                }
                else
                {
                    MessageBox.Show("Debes elegir una dirección primero.");
                }
                
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se pudo escribir el archivo\n" + exc.Message);
            }
        }

        private void btnTraer_Click(object sender, EventArgs e)
        {
            try
            {
                if (_path != null)
                {
                    lstVisor.Items.Clear();
                    //string path = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\miArchivo.txt";
                    StreamReader leer = new StreamReader(_path);

                    do
                    {
                        lstVisor.Items.Add(leer.ReadLine());
                    } while (!leer.EndOfStream);

                    leer.Close();
                }
                else
                {
                    if(this.openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        _path = openFileDialog1.FileName;
                        MessageBox.Show(_path);
                    }
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("No se pudo leer el archivo\n" + exc.Message);                
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
         
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _path = openFileDialog1.FileName;
                MessageBox.Show(_path);
            }


            
        }
    }
}
