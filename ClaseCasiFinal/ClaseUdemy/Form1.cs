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
using System.Diagnostics;

namespace ClaseUdemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TiposArchivos> listaArchivos = new List<TiposArchivos>()
            {
                new TiposArchivos{extension = ".txt",nombreArchivos = "Archivos Planos"},
                new TiposArchivos{extension = ".docx",nombreArchivos = "Archivos Word"},
                new TiposArchivos{extension = ".xlsx",nombreArchivos = "Archivos Excel"},
            };
            cbArchivos.DataSource = listaArchivos;
            cbArchivos.DisplayMember = "nombreArchivos";
            cbArchivos.ValueMember = "extension";
        }

        private void ExaminarBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog().Equals(DialogResult.OK))
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }

        private void FiltrarBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                ErrorDatos.SetError(textBox1, "Tiene que ingresar una ruta");
                return;
            }
            else
            {
                ErrorDatos.SetError(textBox1, "");
            }
            string rutaDirectorio = textBox1.Text;
            string extension = cbArchivos.SelectedValue.ToString();            
            lbDatos.DataSource = Directory.GetFiles(rutaDirectorio, "*" + extension);
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            lbDatos.DataSource = null;
        }

        private void SeleccionarArchivo(object sender, EventArgs e)
        {
            if(lbDatos.Items.Count > 0)
            {
                string itemSeleccionado = lbDatos.SelectedItem.ToString();
                Process.Start(itemSeleccionado);
            }
        }
    }
}
