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
    public partial class FrmTestDos : Form
    {
        public FrmTestDos()
        {
            InitializeComponent();
            this.Load += new EventHandler(Inicializar);
        }

        private void Inicializar(object sender, EventArgs e)
        {
            
           this.BtnBoton1.Click += new EventHandler(this.MiManejador);
           
        }

        public void MiManejador(object obj, EventArgs e)
        {
            MessageBox.Show("Fue ejecutado por el boton " + ((Control)obj).Name);

            if ((Button)obj == this.BtnBoton1)
            {
                this.BtnBoton1.Click -= new EventHandler(this.MiManejador);
                this.BtnBoton2.Click += new EventHandler(this.MiManejador);
            }
            else if ((Button)obj == this.BtnBoton2)
            {
                this.BtnBoton2.Click -= new EventHandler(this.MiManejador);
                this.BtnBoton3.Click += new EventHandler(this.MiManejador);
            }
            else if ((Button)obj == this.BtnBoton3)
            {
                this.BtnBoton3.Click -= new EventHandler(this.MiManejador);
                this.BtnBoton1.Click += new EventHandler(this.MiManejador);
            }
            
        }

        public static void Sumar(int a, int b)
        {
            int result;

            result = a + b;

            MessageBox.Show(result.ToString());
        }
        public void Restar(int a, int b)
        {
            int result;

            result = a - b;
            MessageBox.Show(result.ToString());
        }

        public void Multiplicar(int a, int b)
        {
            int result;

            result = a * b;
            MessageBox.Show(result.ToString());
        }

        void OtraSuma(MiDelegado d, int a, int b)
        {
            d(a, b);
        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            MiDelegado del = new MiDelegado(Sumar);
            
            del.Invoke(5, 2);
            del(8, 4);

            
            MiDelegado resta = new MiDelegado(Restar);
            resta(8, 2);
            
            MiDelegado delCombinado = (MiDelegado)Delegate.Combine(del, resta);
            
            delCombinado(40, 20);

            MessageBox.Show(del.Method.ToString());
            MessageBox.Show(resta.Target.ToString());
            foreach (MiDelegado a in delCombinado.GetInvocationList())
            {
                MessageBox.Show(a.Method.ToString());
            }

            MiDelegado del4 = (MiDelegado)Delegate.Combine(delCombinado, new MiDelegado(Multiplicar));
            del4(100, 10);

            this.OtraSuma(Sumar, 60, 1);
            
        }
    }
}
