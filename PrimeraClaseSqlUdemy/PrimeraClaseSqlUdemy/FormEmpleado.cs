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
    public partial class FormEmpleado : Form
    {
        public FormEmpleado()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            BDPasajeEntities bDPasajeEntities = new BDPasajeEntities();
            var consulta = (from empleado in bDPasajeEntities.Empleado
                            where empleado.BHABILITADO == 1
                            select new
                            {
                                empleado.IIDEMPLEADO,
                                nombreCompleto = empleado.NOMBRE +
                                                 empleado.APPATERNO +
                                                 empleado.APMATERNO,
                                empleado.FECHACONTRATO,
                                empleado.SUELDO,
                            }).ToList();
            DGVSQL2.DataSource = consulta;
        }
    }
}
