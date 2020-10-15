using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseUdemy
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivo de programa |*.jpg;*.png;*.jpeg";
            if (ofd.ShowDialog().Equals(DialogResult.OK))
            {
                string rutaArchivo = ofd.FileName;
                RutaTxt.Text = rutaArchivo;
                byte[] buffer = File.ReadAllBytes(rutaArchivo);
                using (MemoryStream ms = new MemoryStream(buffer))
                {
                    ImgPB.Image = Image.FromStream(ms);
                }
            }
        }

        private void MoverBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de programa |*.jpg;*.png;*.jpeg";
            if (sfd.ShowDialog().Equals(DialogResult.OK))
            {
                string fileName = sfd.FileName;
                File.Move(RutaTxt.Text, fileName);
                MessageBox.Show("Se movio correctamente.");
            }
        }

        private void CopiarBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo de programa |*.jpg;*.png;*.jpeg";
            if (sfd.ShowDialog().Equals(DialogResult.OK))
            {
                string fileName = sfd.FileName;
                File.Copy(RutaTxt.Text, fileName);
                MessageBox.Show("Se copio correctamente.");                
            }
        }
    }
}
