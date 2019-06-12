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

namespace TestForm
{

  public partial class FrmListado : Form
  {
    private List<Persona> _personas;
    private DataTable _tabla;

    public FrmListado()
    {
      InitializeComponent();
      //Inicializar el personas con traert todo
      //Inicializar la tabla con traer tabla
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
       
    }

    private void FrmListado_Load(object sender, EventArgs e)
    {
      dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      dataGridView1.DataSource = _personas;
    }
  }
}
