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
    public partial class DashboardAdministrador : Form
    {
        public DashboardAdministrador()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ContenedorRegistroAplicacionForm contenedorRegistroAplicacionForm = new ContenedorRegistroAplicacionForm();
            contenedorRegistroAplicacionForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ContenedorClientesForm contenedorClientesForm = new ContenedorClientesForm();
            contenedorClientesForm.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            ContenedorRetiroBodegaForm contenedorRetiroBodegaForm = new ContenedorRetiroBodegaForm();
            contenedorRetiroBodegaForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InformeDeIngresosForm informeDeIngresosForm = new InformeDeIngresosForm();
            informeDeIngresosForm.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            InformeDeInventarioForm informeDeInventarioForm = new InformeDeInventarioForm();
            informeDeInventarioForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InformeDePromocionesForm informeDePromocionesForm = new InformeDePromocionesForm();
            informeDePromocionesForm.ShowDialog();
        }
    }
}
