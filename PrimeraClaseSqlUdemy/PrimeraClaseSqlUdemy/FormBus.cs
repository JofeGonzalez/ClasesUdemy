using PrimeraClaseSqlUdemy.Models;
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
    public partial class FormBus : Form
    {
        public FormBus()
        {
            InitializeComponent();
        }
        private void listar()
        {
            BDPasajeEntities bd = new BDPasajeEntities();
            var consulta = (from bus in bd.Bus
                            join sucursal in bd.Sucursal
                            on bus.IIDSUCURSAL equals sucursal.IIDSUCURSAL
                            join tipobus in bd.TipoBus
                            on bus.IIDTIPOBUS equals tipobus.IIDTIPOBUS
                            where bus.BHABILITADO == 1
                            select new
                            {
                                bus.IIDBUS,
                                sucursal.NOMBRE,
                                busTipoNombre = tipobus.NOMBRE,
                                bus.PLACA
                            }).ToList();
            dataGridView1.DataSource = consulta;
        }
        private void llenarComboBox()
        {
            BDPasajeEntities bd = new BDPasajeEntities();
            var consulta = (from tipobus in bd.TipoBus
                            where tipobus.BHABILITADO == 1
                            select new
                            {
                                tipobus.IIDTIPOBUS,
                                tipobus.NOMBRE,
                            }).ToList();
            comboBox2.DataSource = consulta;
            comboBox2.DisplayMember = "Nombre";
            comboBox2.ValueMember = "IIDTIPOBUS";
        }

        private void FormBus_Load(object sender, EventArgs e)
        {
            listar();
            llenarComboBox();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            int valor = (int)comboBox2.SelectedValue;
            BDPasajeEntities bd = new BDPasajeEntities();
            var consulta = (from bus in bd.Bus
                            join sucursal in bd.Sucursal
                            on bus.IIDSUCURSAL equals sucursal.IIDSUCURSAL
                            join tipobus in bd.TipoBus
                            on bus.IIDTIPOBUS equals tipobus.IIDTIPOBUS
                            where bus.BHABILITADO == 1
                            && tipobus.IIDTIPOBUS == valor
                            select new
                            {
                                bus.IIDBUS,
                                sucursal.NOMBRE,
                                busTipoNombre = tipobus.NOMBRE,
                                bus.PLACA
                            }).ToList();
            dataGridView1.DataSource = consulta;
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            listar();
        }
    }
}
