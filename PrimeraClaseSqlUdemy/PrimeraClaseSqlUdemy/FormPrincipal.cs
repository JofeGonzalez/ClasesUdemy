using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraClaseSqlUdemy
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ItemMarca_Click(object sender, EventArgs e)
        {
            Form marcaForm = new FormMarca();
            marcaForm.ShowDialog();           
        }

        private void ItemEmpleados_Click(object sender, EventArgs e)
        {
            Form empleadoForm = new FormEmpleado();
            empleadoForm.ShowDialog();
        }

        private void ItemClientes_Click(object sender, EventArgs e)
        {
            Form clienteForm = new FormCliente();
            clienteForm.ShowDialog();
        }

        private void busToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form busForm = new FormBus();
            busForm.ShowDialog();
        }
    }
}
