using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimeraClaseSqlUdemy.Models;

namespace PrimeraClaseSqlUdemy
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BDPasajeEntities bDPasajeEntities = new BDPasajeEntities();
            // id, email, nombre completo, sexo
            var consulta = (from cliente in bDPasajeEntities.Cliente
                            join sexo in bDPasajeEntities.Sexo
                            on cliente.IIDSEXO equals sexo.IIDSEXO
                            where cliente.BHABILITADO == 1
                            select new
                            {
                                cliente.IIDCLIENTE,
                                NombreCompleto = cliente.NOMBRE +
                                                 " " + cliente.APPATERNO +
                                                 " " + cliente.APMATERNO,
                                cliente.EMAIL,
                                sexo.NOMBRE,
                            }).ToList();
            DGVSQL3.DataSource = consulta;
        }
    }
}
