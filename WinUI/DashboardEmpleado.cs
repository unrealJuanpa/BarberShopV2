using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class DashboardEmpleado : Form
    {
        public DashboardEmpleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearClienteForm crearClienteForm = new CrearClienteForm();
            crearClienteForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrearRegistroAplicacionForm crearRegistroAplicacionForm = new CrearRegistroAplicacionForm();
            crearRegistroAplicacionForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrearRetiroBodegaForm crearRetiroBodegaForm = new CrearRetiroBodegaForm();
            crearRetiroBodegaForm.ShowDialog();
        }
    }
}
