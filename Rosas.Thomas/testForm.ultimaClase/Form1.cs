using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.ultimaClase;
using System.IO;

namespace testForm.ultimaClase
{
    public partial class Form1 : Form
    {
        public static void LimiteSueldoEmpleado(EmpleadoMejorado e, EmpleadoSueldoArgs f)
        {
            MessageBox.Show("Al empleado " + e.Nombre + " con legajo " + e.Legajo + " se le quizo asignar el siguiente sueldo " + f.Sueldo);
        }
        public void GuardarLog(EmpleadoMejorado e, EmpleadoSueldoArgs s)
        {
            try
            {
                StreamWriter w = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + @"Incidentes.log", true);
                w.WriteLine("\n" + DateTime.Now);
                w.Write("\nNombre: " + e.Nombre + " - Legajo: " + e.Legajo + " - Sueldo que se le intento asignar: " + s.Sueldo);
                w.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }
        public Form1()
        {
            InitializeComponent();
            cmbTipo.Items.Add(TipoManejador.LimiteSueldo);
            cmbTipo.Items.Add(TipoManejador.Log);
            cmbTipo.Items.Add(TipoManejador.Ambos);
            
        }

        private void btnEmpleadoMej_Click(object sender, EventArgs e)
        {
            EmpleadoMejorado emp = new EmpleadoMejorado();

            emp.Legajo = int.Parse(txtLegajo.Text);
            emp.Nombre = txtNombre.Text;           

            if (cmbTipo.SelectedItem is TipoManejador.Log)
            {
                emp._limiteSueldo += new DelSueldo(this.GuardarLog);
            }
            else if (cmbTipo.SelectedItem is TipoManejador.LimiteSueldo)
            {
                emp._limiteSueldo += new DelSueldo(LimiteSueldoEmpleado);
            }
            else if (cmbTipo.SelectedItem is TipoManejador.Ambos)
            {
                emp._limiteSueldo += new DelSueldo(this.GuardarLog);
                emp._limiteSueldo += new DelSueldo(LimiteSueldoEmpleado);
            }

            emp.Sueldo = float.Parse(txtSueldo.Text);

        }

        private void Emp__limiteSueldo(EmpleadoMejorado eM, EmpleadoSueldoArgs sA)
        {
            throw new NotImplementedException();
        }
    }
}
